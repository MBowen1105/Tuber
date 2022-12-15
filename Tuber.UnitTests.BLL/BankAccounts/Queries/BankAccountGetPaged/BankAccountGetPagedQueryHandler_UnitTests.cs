using AutoMapper;
using FluentAssertions;
using Moq;
using Tuber.BLL.BankAccounts.Queries.BankAccountGetPaged;
using Tuber.Domain.Common;
using Tuber.Domain.Dtos;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Models;

namespace Tuber.UnitTests.BLL.BankAccounts.Queries.BankAccountGetPaged;
internal class BankAccountGetPagedQueryHandler_UnitTests
{
    private BankAccount[] _bankAccountArray;
    private List<BankAccountGetPaged_BankAccount> _bankAccountDtoList;

    [SetUp]
    public void SetUp()
    {
        _bankAccountArray = new BankAccount[]
        {
            new BankAccount
            {
                 BankAccountId = Guid.NewGuid(),
                 BankAccountName = "Bank Account 1",
                 OrderBy = 10,
                 IsDeleted = true
            },
            new BankAccount
            {
                 BankAccountId = Guid.NewGuid(),
                 BankAccountName = "Bank Account 2",
                 OrderBy = 20,
                 IsDeleted = true
            },
            new BankAccount
            {
                 BankAccountId = Guid.NewGuid(),
                 BankAccountName = "Bank Account 3",
                 OrderBy = 30,
                 IsDeleted = true
            },
            new BankAccount
            {
                 BankAccountId = Guid.NewGuid(),
                 BankAccountName = "Bank Account 4",
                 OrderBy = 40,
                 IsDeleted = true
            },
            new BankAccount
            {
                 BankAccountId = Guid.NewGuid(),
                 BankAccountName = "Deleted Bank Account",
                 OrderBy = 99,
                 IsDeleted = false
            }
        };

        _bankAccountDtoList = new List<BankAccountGetPaged_BankAccount>();

        for (var i = 0; i < _bankAccountArray.Length; i++)
        {
            _bankAccountDtoList.Add(new BankAccountGetPaged_BankAccount
            {
                BankAccountId = _bankAccountArray[i].BankAccountId,
                BankAccountName = _bankAccountArray[i].BankAccountName!,
                OrderBy = _bankAccountArray[i].OrderBy
            });
        }
    }

    [Test, Parallelizable]
    [TestCase(1, 2, 10)]
    [TestCase(2, 2, 30)]
    [TestCase(1, 5, 10)]
    public void GetBankAccountPagedQueryHandler_ValidPayload_ReturnsValidResult(
        int pageNumber, int pageSize, int orderBy)
    {
        var page = new ArraySegment<BankAccount>(_bankAccountArray, (pageNumber - 1) * pageSize, pageSize).ToList();

        var mockBankAccountRetrieverService = new Mock<IBankAccountRetrievalService>();

        mockBankAccountRetrieverService.Setup(x => x.GetPaged(pageNumber, pageSize))
            .Returns(new ServiceResult<List<BankAccount>>(payload: page));

        var mockMapper = new Mock<IMapper>();
        var subSet = _bankAccountDtoList.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

        mockMapper.Setup(x => x.Map<List<BankAccount>, List<BankAccountGetPaged_BankAccount>>(It.IsAny<List<BankAccount>>()))
            .Returns(subSet);

        var totalPages = (int)Math.Ceiling(_bankAccountArray.Count(x => x.IsDeleted == false) / (pageSize * 1.0));

        mockBankAccountRetrieverService.Setup(x => x.CountPages(pageSize))
            .Returns(totalPages);

        var sut = new BankAccountGetPagedQueryHandler(mockBankAccountRetrieverService.Object,
            mockMapper.Object);

        var request = new BankAccountGetPagedQueryRequest
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
