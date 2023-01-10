using AutoMapper;
using FluentAssertions;
using Moq;
using Tuber.Application.Banks.Queries.BankGetPaged;
using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.Application.UnitTests.Banks.Queries.GetBank;
internal class GetBankPagedQueryHandler_UnitTests
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
    [TestCase(1, 2, 10)]
    [TestCase(2, 2, 30)]
    [TestCase(1, 5, 10)]
    public void GetBankPagedQueryHandler_ValidPayload_ReturnsValidResult(
        int pageNumber, int pageSize, int orderBy)
    {
        var pageOfBanks = new ArraySegment<Bank>(_bankArray, (pageNumber - 1) * pageSize, pageSize).ToList();

        var mockBankRetrieverService = new Mock<IBankRetrievalService>();

        mockBankRetrieverService.Setup(x => x.GetPaged(pageNumber, pageSize))
            .Returns(new ServiceResult<List<Bank>>(payload: pageOfBanks));

        var mockMapper = new Mock<IMapper>();
        var subSet = _bankDtoList.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

        mockMapper.Setup(x => x.Map<List<Bank>, List<BankGetPaged_Bank>>(It.IsAny<List<Bank>>()))
            .Returns(subSet);

        var totalPages = (int)Math.Ceiling(_bankArray.Count(x => x.IsDeleted == false) / (pageSize * 1.0));

        mockBankRetrieverService.Setup(x => x.CountPages(pageSize))
            .Returns(totalPages);

        var sut = new BankGetPagedQueryHandler(mockBankRetrieverService.Object, mockMapper.Object);

        var request = new BankGetPagedQueryRequest
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
