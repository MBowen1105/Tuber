using FluentAssertions;
using Moq;
using Tuber.Application.Imports.Services;
using Tuber.Domain.Enums;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Interfaces.Authorisation;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.SystemClock;
using Tuber.Domain.Models;

namespace Tuber.Application.UnitTests.Imports.Services;
internal class ImportValidationService_CoOp_UnitTests
{
    private readonly Mock<ICurrentUserService> _mockCurrentUserService = new();
    private readonly Mock<IDateTimeService> _mockDateTimeService = new();
    private readonly Mock<ICategorySubcategoryRetrievalService> _mockCategorySubcategoryRetrievalService = new();
    private readonly Guid _bankAccountId = Guid.NewGuid();
    private IImportValidationService _sut;
    private ImportTemplate _importTemplate = new ImportTemplate
    {
        ImportTemplateId = Guid.NewGuid(),
        ImportTemplateName = "",
        ImportFileName = "",
        ExpectedHeaderRowCount = 1,
        ExpectedColumnCount = 6,
        SeperatorChar = ',',
        DateTemplate = "yyyy-mm-dd",
        DateColumnNumber = 1,
        DescriptionOnStatementColumnNumber = 2,
        ReferenceOnStatementStartCharacter = 19,
        TransactionTypeColumnNumber = 3,
        MoneyInColumnNumber = 4,
        MoneyOutColumnNumber = 5,
        BalanceOnStatementColumnNumber = 6,
        SortCodeColumnNumber = 0,
        AccountNumberColumnNumber = 0,
        IsDeleted = false
    };

    [SetUp]
    public void Setup()
    {
        _mockCurrentUserService.Setup(x => x.User())
            .Returns(new User { UserId = Guid.NewGuid() });

        _mockDateTimeService.Setup(x => x.UtcNow())
            .Returns(new DateTime(2022, 12, 15));

        //_mockCategorySubcategoryRetrievalService.Setup(x => x.SuggestCategorisation(
        //    It.Is<string>(x => x == "20221215"),
        //    It.Is<string>(x => x == "Description Value"),
        //    It.Is<string>(x => x == "Reference on Statement Value"),
        //    It.Is<string>(x => x == "Money In Value"),
        //    It.Is<string>(x => x == "Money Out Value"))
        //        .Returns();

        _sut = new ImportValidationService(
            _mockCurrentUserService.Object,
            _mockDateTimeService.Object,
            _mockCategorySubcategoryRetrievalService.Object);
    }

    #region "Validate"
    [Test, Parallelizable]
    public void Validate_ValidImport_ReturnsImportListWithNoExceptions()
    {
        string[] allRows = {
            "Date,Description,Type,Money In, Money Out, Balance",
            "2022-08-01,M&S BANK,DD,,176.24,255.17",
            "2022-08-04,CYRUS SOLUTIONS LT EXPENSES E003,CREDIT,283.89,,431.41"};

        var serviceResult = _sut.Validate(_importTemplate, _bankAccountId,
            suggestCategorisation: false, allRows);

        serviceResult.Payload.Count.Should().Be(2);
        serviceResult.Payload.First().ImportRowStatus.Should().Be(ImportRowStatus.IsValid);

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.Exceptions.Count.Should().Be(0);
        serviceResult.Payload.Count().Should().Be(2);
    }

    [Test, Parallelizable]
    public void Validate_WrongNumberOfColumns_ReturnsEmptyImportListWithException()
    {
        string[] allRows = {
            "Date,Description,Type,Money In, Money Out",
            "2022-08-32,M&S BANK,DD,,176.24" };

        var serviceResult = _sut.Validate(_importTemplate, _bankAccountId,
            suggestCategorisation: false, allRows);

        serviceResult.IsSuccess.Should().BeFalse();
        serviceResult.Exceptions.Count.Should().Be(1);
        serviceResult.Exceptions.First().Should().BeOfType<InvalidImportFileException>();

        serviceResult.Payload.Count().Should().Be(0);
    }

    [Test, Parallelizable]
    public void Validate_WrongSeperator_ReturnsEmptyImportListWithException()
    {
        string[] allRows = {
            "Date;Description;Type;Money In; Money Out; Balance",
            "2022-08-32;M&S BANK,DD;;176.24;431.41" };

        var serviceResult = _sut.Validate(_importTemplate, _bankAccountId,
            suggestCategorisation: false, allRows);

        serviceResult.IsSuccess.Should().BeFalse();
        serviceResult.Exceptions.Count.Should().Be(1);
        serviceResult.Exceptions.First().Should().BeOfType<InvalidImportFileException>();

        serviceResult.Payload.Count().Should().Be(0);
    }

    [Test, Parallelizable]
    public void Validate_MissingMandatoryColumnValues_ReturnsImportListWithValidationFailureMessages()
    {
        string[] allRows = {
            "Date,Description,Type,Money In, Money Out, Balance",
            ",,DD,,,"};

        var serviceResult = _sut.Validate(_importTemplate, _bankAccountId,
            suggestCategorisation: false, allRows);

        serviceResult.Payload.Count.Should().Be(1);
        serviceResult.Payload.First().ImportRowStatus.Should().Be(ImportRowStatus.IsInvalid);

        var messages = serviceResult.Payload.First().ValidationFailureMessages!.Split(ImportValidationService.ValidationMessageSeperator);
        messages.Should().HaveCount(5);
        messages[0].Should().Contain("Transaction Date is missing.");
        messages[1].Should().Contain($"Transaction Date is invalid. Must be of the format {_importTemplate.DateTemplate}.");
        messages[2].Should().Contain($"Description on statement is missing.");
        messages[3].Should().Contain($"This transaction has no Money In or Money Out value.");
        messages[4].Should().Contain($"Balance on Statement is missing.");

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.Exceptions.Count.Should().Be(0);
    }

    [Test, Parallelizable]
    public void Validate_LengthlyColumnValues_ReturnsImportListWithValidationFailureMessages()
    {
        string[] allRows = {
            "Date,Description,Type,Money In, Money Out, Balance",
            "2022-12-10,123456789.123456789.123456789.123456789.1,123456789.1,,176.24,255.17"};

        var serviceResult = _sut.Validate(_importTemplate, _bankAccountId,
            suggestCategorisation: false, allRows);

        var messages = serviceResult.Payload.First().ValidationFailureMessages!.Split(ImportValidationService.ValidationMessageSeperator);
        messages.Should().HaveCount(2);
        messages[0].Should().Contain("Description on statement cannot exceed 40 character - truncating.");
        messages[1].Should().Contain($"Transaction Type cannot exceed 10 characters - truncating.");

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.Exceptions.Count.Should().Be(0);
    }

    [Test, Parallelizable]
    [TestCase("2022/1/1")]
    [TestCase("20220101")]
    [TestCase("2022-13-01")]
    [TestCase("2022-04-31")]
    [TestCase("2022-13-01")]
    public void Validate_InvalidDateValues_ReturnsImportListWithValidationFailureMessages(
        string invalidDateValue)
    {
        string[] allRows = {
            "Date,Description,Type,Money In, Money Out, Balance",
            $"{invalidDateValue},M&S BANK,DD,,176.24,255.17" };

        var serviceResult = _sut.Validate(_importTemplate, _bankAccountId,
            suggestCategorisation: false, allRows);

        serviceResult.Payload.Count.Should().Be(1);
        serviceResult.Payload.First().ImportRowStatus.Should().Be(ImportRowStatus.IsInvalid);

        var messages = serviceResult.Payload.First().ValidationFailureMessages!.Split(ImportValidationService.ValidationMessageSeperator);
        messages.Should().HaveCount(1);
        messages[0].Should().Contain($"Transaction Date is invalid. Must be of the format {_importTemplate.DateTemplate}.");

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.Exceptions.Count.Should().Be(0);
    }

    [Test, Parallelizable]
    [TestCase("0", "Money In value cannot be zero.")]
    [TestCase(".", "Invalid Money In value. Must be a valid amount.")]
    [TestCase("-123.45", "Money In value cannot be negative.")]
    public void Validate_InvalidMoneyInValues_ReturnsImportListWithValidationFailureMessages(
        string invalidMoneyInValue, string failureMessage)
    {
        string[] allRows = {
            "Date,Description,Type,Money In, Money Out, Balance",
            $"2022-01-01,M&S BANK,DD,{invalidMoneyInValue},,255.17" };

        var serviceResult = _sut.Validate(_importTemplate, _bankAccountId,
            suggestCategorisation: false, allRows);

        serviceResult.Payload.Count.Should().Be(1);
        serviceResult.Payload.First().ImportRowStatus.Should().Be(ImportRowStatus.IsInvalid);

        var messages = serviceResult.Payload.First().ValidationFailureMessages!.Split(ImportValidationService.ValidationMessageSeperator);
        messages.Should().HaveCount(1);
        messages[0].Should().Contain(failureMessage);

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.Exceptions.Count.Should().Be(0);
    }

    [Test, Parallelizable]
    [TestCase("0", "Money Out value cannot be zero.")]
    [TestCase(".", "Invalid Money Out value. Must be a valid amount.")]
    [TestCase("-123.45", "Money Out value cannot be negative.")]
    public void Validate_InvalidMoneyOutValues_ReturnsImportListWithValidationFailureMessages(
        string invalidMoneyOutValue, string failureMessage)
    {
        string[] allRows = {
            "Date,Description,Type,Money In, Money Out, Balance",
            $"2022-01-01,M&S BANK,DD,,{invalidMoneyOutValue},255.17" };

        var serviceResult = _sut.Validate(_importTemplate, _bankAccountId,
            suggestCategorisation: false, allRows);

        serviceResult.Payload.Count.Should().Be(1);
        serviceResult.Payload.First().ImportRowStatus.Should().Be(ImportRowStatus.IsInvalid);

        var messages = serviceResult.Payload.First().ValidationFailureMessages!.Split(ImportValidationService.ValidationMessageSeperator);
        messages.Should().HaveCount(1);
        messages[0].Should().Contain(failureMessage);

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.Exceptions.Count.Should().Be(0);
    }

    [Test, Parallelizable]    
    public void Validate_BothMoneyInAndOutMissingValues_ReturnsImportListWithValidationFailureMessage()
    {
        string[] allRows = {
            "Date,Description,Type,Money In, Money Out, Balance",
            $"2022-01-01,M&S BANK,DD,,,255.17" };

        var serviceResult = _sut.Validate(_importTemplate, _bankAccountId,
            suggestCategorisation: false, allRows);

        serviceResult.Payload.Count.Should().Be(1);
        serviceResult.Payload.First().ImportRowStatus.Should().Be(ImportRowStatus.IsInvalid);

        var messages = serviceResult.Payload.First().ValidationFailureMessages!.Split(ImportValidationService.ValidationMessageSeperator);
        messages.Should().HaveCount(1);
        messages[0].Should().Contain("This transaction has no Money In or Money Out value.");

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.Exceptions.Count.Should().Be(0);
    }


    [Test, Parallelizable]
    [TestCase("", "Balance on Statement is missing.")]
    [TestCase("abc", "Balance on Statement value is not a valid amount.")]
    public void Validate_InvalidBalanceOnStatementValues_ReturnsImportListWithValidationFailureMessages(
        string invalidBalanceOnStatement, string failureMessage)
    {
        string[] allRows = {
            "Date,Description,Type,Money In, Money Out, Balance",
            $"2022-01-01,M&S BANK,DD,1,,{invalidBalanceOnStatement}" };

        var serviceResult = _sut.Validate(_importTemplate, _bankAccountId,
            suggestCategorisation: false, allRows);

        serviceResult.Payload.Count.Should().Be(1);
        serviceResult.Payload.First().ImportRowStatus.Should().Be(ImportRowStatus.IsInvalid);

        var messages = serviceResult.Payload.First().ValidationFailureMessages!.Split(ImportValidationService.ValidationMessageSeperator);
        messages.Should().HaveCount(1);
        messages[0].Should().Contain(failureMessage);
        

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.Exceptions.Count.Should().Be(0);
    }
    #endregion
}
