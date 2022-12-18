using FluentAssertions;
using Moq;
using Tuber.BLL.Banks.Commands.BankUpdate;
using Tuber.BLL.Banks.Services;
using Tuber.Domain.Dtos;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.UnitTests.BLL.Banks.Commands.BankUpdate;
internal class BankUpdateCommandHandler_UnitTests
{
    private Bank[] _bankArray;
    private List<BankGetPaged_Bank> _bankDtoList;

    [SetUp]
    public void SetUp()
    {
        _bankArray = new Bank[]
        {
            new Bank
            {
                 BankId = Guid.Parse("598ddc62-6729-4aa6-91f3-dad0c9bd2768"),
                 BankName = "Bank 1",
                 OrderBy = 10
            },
            new Bank
            {
                 BankId = Guid.Parse("598ddc62-6729-4aa6-91f3-dad0c9bd2768"),
                 BankName = "Bank 2",
                 OrderBy = 20
            },
            new Bank
            {
                 BankId = Guid.Parse("598ddc62-6729-4aa6-91f3-dad0c9bd2768"),
                 BankName = "Bank 3",
                 OrderBy = 30
            },
            new Bank
            {
                 BankId = Guid.Parse("598ddc62-6729-4aa6-91f3-dad0c9bd2768"),
                 BankName = "Bank 4",
                 OrderBy = 40
            },
            new Bank
            {
                 BankId = Guid.Parse("598ddc62-6729-4aa6-91f3-dad0c9bd2768"),
                 BankName = "Deleted Bank",
                 OrderBy = 99,
                 IsDeleted = true
            }
        };

        _bankDtoList = new List<BankGetPaged_Bank>();

        for (var i = 0; i < _bankArray.Length; i++)
        {
            _bankDtoList.Add(new BankGetPaged_Bank
            {
                BankId = _bankArray[i].BankId,
                BankName = _bankArray[i].BankName!,
                OrderBy = _bankArray[i].OrderBy
            });
        }
    }

    [Test]
    public void BankUpdateCommandHandler_MissingBank_ReturnsInvalidResult()
    {
        var mockBankRepository = new Mock<IBankRepository>();

        mockBankRepository.Setup(x => x.Update(It.IsAny<Bank>()))
            .Returns(new Bank());

        var bankUpdatorService = new BankUpdaterService(mockBankRepository.Object);

        var sut = new BankUpdateCommandHandler(bankUpdatorService);

        var request = new BankUpdateCommandRequest
        {
            BankId = Guid.NewGuid(),
            Name = "Test 123",
            OrderBy = 88,
        };

        var bankUpdateCommandResponse = sut.Handle(request, new CancellationToken());

        //  The bank to update does not exist, so should return one exception of
        //  type "BankDoesNotExistsException()"
        bankUpdateCommandResponse.Result.HasExceptions.Should().BeTrue();
        bankUpdateCommandResponse.Result.Exceptions.Count.Should().Be(1);
    }
}
