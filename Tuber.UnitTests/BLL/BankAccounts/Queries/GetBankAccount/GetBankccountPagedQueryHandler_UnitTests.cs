using AutoMapper;
using FluentAssertions;
using Moq;
using Tuber.BLL.BankAccounts.Queries.GetBankAccountPaged;
using Tuber.Domain.Dtos;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Models;

namespace Tuber.UnitTests.BLL.BankAccounts.Queries.GetBankAccount;
internal class GetBankAccountPagedQueryHandler_UnitTests
{
    private BankAccount[] _bankAccountArray;
    private List<BankAccountDto> _bankAccountDtoList;

    [SetUp]
    public void SetUp()
    {
        _bankAccountArray = new BankAccount[]
        {
            new BankAccount
            {
                 Id = Guid.NewGuid(),
                 Name = "Bank Account 1",
                 OrderBy = 10,
                 IsArchived = false
            },
            new BankAccount
            {
                 Id = Guid.NewGuid(),
                 Name = "Bank Account 2",
                 OrderBy = 20,
                 IsArchived = false
            },
            new BankAccount
            {
                 Id = Guid.NewGuid(),
                 Name = "Bank Account 3",
                 OrderBy = 30,
                 IsArchived = false
            },
            new BankAccount
            {
                 Id = Guid.NewGuid(),
                 Name = "Bank Account 4",
                 OrderBy = 40,
                 IsArchived = false
            },
            new BankAccount
            {
                 Id = Guid.NewGuid(),
                 Name = "Deleted Bank Account",
                 OrderBy = 99,
                 IsArchived = true
            }
        };

        _bankAccountDtoList = new List<BankAccountDto>();

        for (var i = 0; i < _bankAccountArray.Length; i++)
        {
            _bankAccountDtoList.Add(new BankAccountDto
            {
                Id = _bankAccountArray[i].Id,
                Name = _bankAccountArray[i].Name!,
                OrderBy = _bankAccountArray[i].OrderBy,
                IsArchived = _bankAccountArray[i].IsArchived
            });
        }
    }

    [Test]
    [TestCase(1, 2, 10)]
    [TestCase(2, 2, 30)]
    [TestCase(1, 5, 10)]
    public void GetBankAccountPagedQueryHandler_ValidPayload_ReturnsValidResult(
        int pageNumber, int pageSize, int orderBy)
    {
        var page = new ArraySegment<BankAccount>(_bankAccountArray, (pageNumber - 1) * pageSize, pageSize).ToList();

        var mockBankAccountRetrieverService = new Mock<IBankAccountRetrieverService>();

        mockBankAccountRetrieverService.Setup(x => x.GetPaged(pageNumber, pageSize))
            .Returns(page);

        var mockMapper = new Mock<IMapper>();
        var subSet = _bankAccountDtoList.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

        mockMapper.Setup(x => x.Map<List<BankAccount>, List<BankAccountDto>>(It.IsAny<List<BankAccount>>()))
            .Returns(subSet);

        var totalPages = (int)Math.Ceiling(_bankAccountArray.Count(x => x.IsArchived == false) / (pageSize * 1.0));

        mockBankAccountRetrieverService.Setup(x => x.CountPages(pageSize))
            .Returns(totalPages);

        var sut = new GetBankAccountPagedQueryHandler(mockBankAccountRetrieverService.Object,
            mockMapper.Object);

        var request = new GetBankAccountPagedQueryRequest
        {
            PageNumber = pageNumber,
            PageSize = pageSize
        };

        var result = sut.Handle(request, new CancellationToken());

        //  Returned the correct number of bank rows (pageSize)
        result.Result.BankAccountCount.Should().Be(pageSize);

        //  Returned no exceptions
        result.Result.HasExceptions.Should().BeFalse();

        //  The first item has the correct OrderBy - indicating that the paging is correct.
        result.Result.BankAccounts[0].OrderBy.Should().Be(orderBy);

        result.Result.TotalPages.Should().Be(totalPages);
    }
}
