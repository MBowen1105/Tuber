using FluentAssertions;
using Moq;
using Tuber.BLL.Banks.Queries.GetBankPaged;
using Tuber.Domain.Dtos;
using Tuber.Domain.Interfaces.BLL;

namespace Tuber.UnitTests.BLL.Banks.Queries.GetBank;
internal class GetBankPagedQueryHandler_UnitTests
{
    private BankDto[] _bankList;

    [SetUp]
    public void SetUp()
    {
        _bankList = new BankDto[]
        {
            new BankDto
            {
                 Id = Guid.NewGuid(),
                 Name = "Bank 1",
                 OrderBy = 10,
                 IsArchived = false
            },
            new BankDto
            {
                 Id = Guid.NewGuid(),
                 Name = "Bank 2",
                 OrderBy = 20,
                 IsArchived = false
            },
            new BankDto
            {
                 Id = Guid.NewGuid(),
                 Name = "Bank 3",
                 OrderBy = 30,
                 IsArchived = false
            },
            new BankDto
            {
                 Id = Guid.NewGuid(),
                 Name = "Bank 4",
                 OrderBy = 40,
                 IsArchived = false
            },
            new BankDto
            {
                 Id = Guid.NewGuid(),
                 Name = "Deleted Bank",
                 OrderBy = 99,
                 IsArchived = true
            }
        };
    }

    [Test]
    [TestCase(1, 2, 10)]
    [TestCase(2, 2, 30)]
    [TestCase(1, 5, 10)]
    public void GetBankPagedQueryHandler_ValidPayload_ReturnsValidResult(
        int pageNumber, int pageSize, int orderBy)
    {
        var page = new ArraySegment<BankDto>(_bankList, (pageNumber - 1) * pageSize, pageSize).ToList();

        var mockBankService = new Mock<IBankService>();

        mockBankService.Setup(x => x.GetPaged(pageNumber, pageSize))
            .Returns(page);

        var totalPages = (int)Math.Ceiling(_bankList.Count(x => x.IsArchived == false) / (pageSize * 1.0));
        
        mockBankService.Setup(x => x.CountPages(pageSize))
            .Returns(totalPages);

        var sut = new GetBankPagedQueryHandler(mockBankService.Object);

        var request = new GetBankPagedQueryRequest
        {
            PageNumber = pageNumber,
            PageSize = pageSize
        };

        var result = sut.Handle(request, new CancellationToken());

        //  Returned the correct number of bank rows (pageSize)
        result.Result.BankCount.Should().Be(pageSize);

        //  Returned no exceptions
        result.Result.HasExceptions.Should().BeFalse();

        //  The first item has the correct OrderBy - indicating that the paging is correct.
        result.Result.Banks[0].OrderBy.Should().Be(orderBy);

        result.Result.TotalPages.Should().Be(totalPages);
    }
}
