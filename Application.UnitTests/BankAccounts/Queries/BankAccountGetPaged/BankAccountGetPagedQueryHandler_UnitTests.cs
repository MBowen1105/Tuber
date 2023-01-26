using AutoMapper;
using FluentAssertions;
using Moq;
using Tuber.Application.InstitutionAccounts.Queries.InstitutionAccountGetPaged;
using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.Application.UnitTests.InstitutionAccounts.Queries.InstitutionAccountGetPaged;
internal class InstitutionAccountGetPagedQueryHandler_UnitTests
{
    private InstitutionAccount[] _bankAccountArray;
    private List<InstitutionAccountGetPaged_InstitutionAccount> _bankAccountDtoList;

    [SetUp]
    public void SetUp()
    {
        _bankAccountArray = new InstitutionAccount[]
        {
            new InstitutionAccount
            {
                 InstitutionAccountId = Guid.NewGuid(),
                 InstitutionAccountName = "Institution Account 1",
                 OrderBy = 10,
                 IsDeleted = true
            },
            new InstitutionAccount
            {
                 InstitutionAccountId = Guid.NewGuid(),
                 InstitutionAccountName = "Institution Account 2",
                 OrderBy = 20,
                 IsDeleted = true
            },
            new InstitutionAccount
            {
                 InstitutionAccountId = Guid.NewGuid(),
                 InstitutionAccountName = "Institution Account 3",
                 OrderBy = 30,
                 IsDeleted = true
            },
            new InstitutionAccount
            {
                 InstitutionAccountId = Guid.NewGuid(),
                 InstitutionAccountName = "Institution Account 4",
                 OrderBy = 40,
                 IsDeleted = true
            },
            new InstitutionAccount
            {
                 InstitutionAccountId = Guid.NewGuid(),
                 InstitutionAccountName = "Deleted Institution Account",
                 OrderBy = 99,
                 IsDeleted = false
            }
        };

        _bankAccountDtoList = new List<InstitutionAccountGetPaged_InstitutionAccount>();

        for (var i = 0; i < _bankAccountArray.Length; i++)
        {
            _bankAccountDtoList.Add(new InstitutionAccountGetPaged_InstitutionAccount
            {
                InstitutionAccountId = _bankAccountArray[i].InstitutionAccountId,
                InstitutionAccountName = _bankAccountArray[i].InstitutionAccountName!,
                OrderBy = _bankAccountArray[i].OrderBy
            });
        }
    }

    [Test, Parallelizable]
    [TestCase(1, 2, 10)]
    [TestCase(2, 2, 30)]
    [TestCase(1, 5, 10)]
    public void GetInstitutionAccountPagedQueryHandler_ValidPayload_ReturnsValidResult(
        int pageNumber, int pageSize, int orderBy)
    {
        var page = new ArraySegment<InstitutionAccount>(_bankAccountArray, (pageNumber - 1) * pageSize, pageSize).ToList();

        var mockInstitutionAccountRetrieverService = new Mock<IInstitutionAccountRetrievalService>();

        mockInstitutionAccountRetrieverService.Setup(x => x.GetPaged(pageNumber, pageSize))
            .Returns(new ServiceResult<List<InstitutionAccount>>(payload: page));

        var mockMapper = new Mock<IMapper>();
        var subSet = _bankAccountDtoList.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

        mockMapper.Setup(x => x.Map<List<InstitutionAccount>, List<InstitutionAccountGetPaged_InstitutionAccount>>(It.IsAny<List<InstitutionAccount>>()))
            .Returns(subSet);

        var totalPages = (int)Math.Ceiling(_bankAccountArray.Count(x => x.IsDeleted == false) / (pageSize * 1.0));

        mockInstitutionAccountRetrieverService.Setup(x => x.CountPages(pageSize))
            .Returns(totalPages);

        var sut = new InstitutionAccountGetPagedQueryHandler(mockInstitutionAccountRetrieverService.Object,
            mockMapper.Object);

        var request = new InstitutionAccountGetPagedQueryRequest
        {
            PageNumber = pageNumber,
            PageSize = pageSize
        };

        var result = sut.Handle(request, new CancellationToken());

        //  Returned the correct number of bank rows (pageSize)
        result.Result.InstitutionAccountCount.Should().Be(pageSize);

        //  Returned no exceptions
        result.Result.HasExceptions.Should().BeFalse();

        //  The first item has the correct OrderBy - indicating that the paging is correct.
        result.Result.InstitutionAccounts[0].OrderBy.Should().Be(orderBy);

        result.Result.TotalPages.Should().Be(totalPages);
    }
}
