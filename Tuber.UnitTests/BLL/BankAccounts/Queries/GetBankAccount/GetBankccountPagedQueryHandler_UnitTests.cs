using FluentAssertions;
using Moq;
using Tuber.BLL.BankAccounts.Queries.GetBankAccountPaged;
using Tuber.Domain.Dtos;
using Tuber.Domain.Interfaces.BLL;

namespace Tuber.UnitTests.BLL.BankAccounts.Queries.GetBankAccount;
internal class GetBankAccountPagedQueryHandler_UnitTests
{
    private BankAccountDto[] _bankAccountList;

    [SetUp]
    public void SetUp()
    {
        _bankAccountList = new BankAccountDto[]
        {
            new BankAccountDto
            {
                 Id = Guid.NewGuid(),
                 Name = "Bank Account 1",
                 OrderBy = 10,
                 IsArchived = false
            },
            new BankAccountDto
            {
                 Id = Guid.NewGuid(),
                 Name = "Bank Account 2",
                 OrderBy = 20,
                 IsArchived = false
            },
            new BankAccountDto
            {
                 Id = Guid.NewGuid(),
                 Name = "Bank Account 3",
                 OrderBy = 30,
                 IsArchived = false
            },
            new BankAccountDto
            {
                 Id = Guid.NewGuid(),
                 Name = "Bank Account 4",
                 OrderBy = 40,
                 IsArchived = false
            },
            new BankAccountDto
            {
                 Id = Guid.NewGuid(),
                 Name = "Deleted Bank Account",
                 OrderBy = 99,
                 IsArchived = true
            }
        };
    }

    [Test]
    [TestCase(1, 2, 10)]
    [TestCase(2, 2, 30)]
    [TestCase(1, 5, 10)]
    public void GetBankAccountPagedQueryHandler_ValidPayload_ReturnsValidResult(
        int pageNumber, int pageSize, int orderBy)
    {
        var page = new ArraySegment<BankAccountDto>(_bankAccountList, (pageNumber - 1) * pageSize, pageSize).ToList();

        var mockBankAccountService = new Mock<IBankAccountService>();

        mockBankAccountService.Setup(x => x.GetPaged(pageNumber, pageSize))
            .Returns(page);

        var totalPages = (int)Math.Ceiling(_bankAccountList.Count(x => x.IsArchived == false) / (pageSize * 1.0));

        mockBankAccountService.Setup(x => x.CountPages(pageSize))
            .Returns(totalPages);

        var sut = new GetBankAccountPagedQueryHandler(mockBankAccountService.Object);

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
