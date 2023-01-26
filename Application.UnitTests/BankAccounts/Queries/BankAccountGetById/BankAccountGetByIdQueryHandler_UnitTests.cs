using AutoMapper;
using FluentAssertions;
using Moq;
using Tuber.Application.InstitutionAccounts;
using Tuber.Application.InstitutionAccounts.Queries.InstitutionAccountGetById;
using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Exceptions;
using Tuber.Domain.Models;

namespace Tuber.Application.UnitTests.InstitutionAccounts.Queries.InstitutionAccountGetById;
internal class InstitutionAccountGetByIdQueryHandler_UnitTests
{
    private InstitutionAccount[] _bankAccountArray;
    private List<InstitutionAccount> _bankAccountList;
    private IMapper _mapper;
    private readonly Mock<IInstitutionAccountRetrievalService> _mockInstitutionAccountRetrievalService = new();

    [SetUp]
    public void SetUp()
    {
        _bankAccountArray = new InstitutionAccount[]
        {
            new InstitutionAccount
            {
                 InstitutionAccountId = Guid.NewGuid(),
                 InstitutionAccountName = "Institution Account 1",
                 UKInstitutionAccount = "12345678",
                 InstitutionId = Guid.NewGuid(),
                 OrderBy = 10,
                 IsDeleted = false
            },
            new InstitutionAccount
            {
                 InstitutionAccountId = Guid.NewGuid(),
                 InstitutionAccountName = "Institution Account 2",
                 UKInstitutionAccount = "12345678",
                 InstitutionId = Guid.NewGuid(),
                 OrderBy = 20,
                 IsDeleted = true
            },
            new InstitutionAccount
            {
                 InstitutionAccountId = Guid.NewGuid(),
                 InstitutionAccountName = "Institution Account 3",
                 UKInstitutionAccount = "12345678",
                 InstitutionId = Guid.NewGuid(),
                 OrderBy = 30,
                 IsDeleted = true
            },
            new InstitutionAccount
            {
                 InstitutionAccountId = Guid.NewGuid(),
                 InstitutionAccountName = "Institution Account 4",
                 UKInstitutionAccount = "12345678",
                 InstitutionId = Guid.NewGuid(),
                 OrderBy = 40,
                 IsDeleted = true
            },
            new InstitutionAccount
            {
                 InstitutionAccountId = Guid.NewGuid(),
                 InstitutionAccountName = "Deleted Institution Account",
                 UKInstitutionAccount = "12345678",
                 InstitutionId = Guid.NewGuid(),
                 OrderBy = 99,
                 IsDeleted = false
            }
        };

        _bankAccountList = new List<InstitutionAccount>();

        for (var i = 0; i < _bankAccountArray.Length; i++)
        {
            _bankAccountList.Add(new InstitutionAccount
            {
                InstitutionAccountId = _bankAccountArray[i].InstitutionAccountId,
                InstitutionAccountName = _bankAccountArray[i].InstitutionAccountName!,
                UKInstitutionAccount = "12345678",
                OrderBy = _bankAccountArray[i].OrderBy
            });
        }
        var config = new MapperConfiguration(cfg => cfg.AddProfile<InstitutionAccountProfile>());
        _mapper = new Mapper(config);


    }

    [Test, Parallelizable]
    public void GetInstitutionAccountByIdQueryHandler_ExistingInstitutionAccount_ReturnsValidPayload()
    {
        var firstRecord = _bankAccountArray[0];

        _mockInstitutionAccountRetrievalService.Setup(x => x.GetById(It.Is<Guid>(g => g == firstRecord.InstitutionAccountId)))
            .Returns(new ServiceResult<InstitutionAccount>(payload: firstRecord));

        var sut = new InstitutionAccountGetByIdQueryHandler(_mockInstitutionAccountRetrievalService.Object, _mapper);

        var request = new InstitutionAccountGetByIdQueryRequest
        {
            InstitutionAccountId = firstRecord.InstitutionAccountId
        };

        var result = sut.Handle(request, new CancellationToken());

        //  Returned the correct bank account record
        //result.Result.Should().BeEquivalentTo(firstRecord);
        result.Result.InstitutionAccountId.Should().Be(firstRecord.InstitutionAccountId);
        result.Result.InstitutionAccountName.Should().Be(firstRecord.InstitutionAccountName);
        result.Result.OrderBy.Should().Be(firstRecord.OrderBy);

        //  Returned no exceptions
        result.Result.HasExceptions.Should().BeFalse();
        result.Result.Exceptions.Count.Should().Be(0);
    }

    [Test, Parallelizable]
    public void GetInstitutionAccountByIdQueryHandler_MissingInstitutionAccount_ReturnsNullPayloadWithException()
    {
        var badId = Guid.NewGuid();

        _mockInstitutionAccountRetrievalService.Setup(x => x.GetById(It.Is<Guid>(x => x == badId)))
            .Returns(new ServiceResult<InstitutionAccount>(
                payload: new InstitutionAccount(),
                exception: new EntityDoesNotExistException(Institution.FriendlyName, badId)));

        var sut = new InstitutionAccountGetByIdQueryHandler(_mockInstitutionAccountRetrievalService.Object, _mapper);

        var request = new InstitutionAccountGetByIdQueryRequest
        {
            InstitutionAccountId = badId
        };

        var result = sut.Handle(request, new CancellationToken());

        //  Returned a null bank account record
        result.Result.InstitutionAccountId.Should().Be(Guid.Empty);
        result.Result.InstitutionAccountName.Should().Be("");
        result.Result.UKInstitutionAccount.Should().Be("");
        result.Result.OrderBy.Should().Be(int.MaxValue);
        result.Result.InstitutionId.Should().Be(Guid.Empty);

        //  Returned one exception
        result.Result.HasExceptions.Should().BeTrue();
        result.Result.Exceptions.Count.Should().Be(1);
        result.Result.Exceptions.First().Should().BeOfType(typeof(EntityDoesNotExistException));
    }
}
