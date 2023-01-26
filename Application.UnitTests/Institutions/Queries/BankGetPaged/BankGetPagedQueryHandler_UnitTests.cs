using AutoMapper;
using FluentAssertions;
using Moq;
using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Institutions.Queries.InstitutionGetPaged;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.Application.UnitTests.Banks.Queries.BankGetPaged;
internal class BankGetPagedQueryHandler_UnitTests
{
    private Institution[] _bankArray;
    private List<InstitutionGetPaged_Institution> _bankDtoList;

    [SetUp]
    public void SetUp()
    {
        _bankArray = new Institution[]
        {
            new Institution
            {
                 InstitutionId = Guid.Parse("598ddc62-6729-4aa6-91f3-dad0c9bd2768"),
                 InstitutionName = "Bank 1",
                 OrderBy = 10
            },
            new Institution
            {
                 InstitutionId = Guid.Parse("598ddc62-6729-4aa6-91f3-dad0c9bd2768"),
                 InstitutionName = "Bank 2",
                 OrderBy = 20
            },
            new Institution
            {
                 InstitutionId = Guid.Parse("598ddc62-6729-4aa6-91f3-dad0c9bd2768"),
                 InstitutionName = "Bank 3",
                 OrderBy = 30
            },
            new Institution
            {
                 InstitutionId = Guid.Parse("598ddc62-6729-4aa6-91f3-dad0c9bd2768"),
                 InstitutionName = "Bank 4",
                 OrderBy = 40
            },
            new Institution
            {
                 InstitutionId = Guid.Parse("598ddc62-6729-4aa6-91f3-dad0c9bd2768"),
                 InstitutionName = "Deleted Bank",
                 OrderBy = 99,
                 IsDeleted = true
            }
        };

        _bankDtoList = new List<InstitutionGetPaged_Institution>();

        for (var i = 0; i < _bankArray.Length; i++)
        {
            _bankDtoList.Add(new InstitutionGetPaged_Institution
            {
                InstitutionId = _bankArray[i].InstitutionId,
                InstitutionName = _bankArray[i].InstitutionName!,
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
        var pageOfBanks = new ArraySegment<Institution>(_bankArray, (pageNumber - 1) * pageSize, pageSize).ToList();

        var mockBankRetrieverService = new Mock<IInstitutionRetrievalService>();

        mockBankRetrieverService.Setup(x => x.GetPaged(pageNumber, pageSize))
            .Returns(new ServiceResult<List<Institution>>(payload: pageOfBanks));

        var mockMapper = new Mock<IMapper>();
        var subSet = _bankDtoList.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

        mockMapper.Setup(x => x.Map<List<Institution>, List<InstitutionGetPaged_Institution>>(It.IsAny<List<Institution>>()))
            .Returns(subSet);

        var totalPages = (int)Math.Ceiling(_bankArray.Count(x => x.IsDeleted == false) / (pageSize * 1.0));

        mockBankRetrieverService.Setup(x => x.CountPages(pageSize))
            .Returns(totalPages);

        var sut = new InstitutionGetPagedQueryHandler(mockBankRetrieverService.Object, mockMapper.Object);

        var request = new InstitutionGetPagedQueryRequest
        {
            PageNumber = pageNumber,
            PageSize = pageSize
        };

        var result = sut.Handle(request, new CancellationToken());

        //  Returned the correct number of bank rows (pageSize)
        result.Result.InstitutionCount.Should().Be(pageSize);

        //  Returned no exceptions
        result.Result.HasExceptions.Should().BeFalse();

        //  The first item has the correct OrderBy - indicating that the paging is correct.
        result.Result.Institutions[0].OrderBy.Should().Be(orderBy);

        result.Result.TotalPages.Should().Be(totalPages);
    }
}
