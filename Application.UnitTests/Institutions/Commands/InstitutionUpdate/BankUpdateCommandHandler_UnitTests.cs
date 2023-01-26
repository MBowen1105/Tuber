using FluentAssertions;
using Moq;
using Tuber.Application.Institutions.Commands.InstitutionUpdate;
using Tuber.Application.Institutions.Services;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.Application.UnitTests.Institutions.Commands.InstitutionUpdate;
internal class InstitutionUpdateCommandHandler_UnitTests
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
                 InstitutionName = "Institution 1",
                 OrderBy = 10
            },
            new Institution
            {
                 InstitutionId = Guid.Parse("598ddc62-6729-4aa6-91f3-dad0c9bd2768"),
                 InstitutionName = "Institution 2",
                 OrderBy = 20
            },
            new Institution
            {
                 InstitutionId = Guid.Parse("598ddc62-6729-4aa6-91f3-dad0c9bd2768"),
                 InstitutionName = "Institution 3",
                 OrderBy = 30
            },
            new Institution
            {
                 InstitutionId = Guid.Parse("598ddc62-6729-4aa6-91f3-dad0c9bd2768"),
                 InstitutionName = "Institution 4",
                 OrderBy = 40
            },
            new Institution
            {
                 InstitutionId = Guid.Parse("598ddc62-6729-4aa6-91f3-dad0c9bd2768"),
                 InstitutionName = "Deleted Institution",
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
    public void InstitutionUpdateCommandHandler_MissingInstitution_ReturnsInvalidResult()
    {
        var mockInstitutionRepository = new Mock<IInstitutionRepository>();

        mockInstitutionRepository.Setup(x => x.Update(It.IsAny<Institution>()))
            .Returns(new Institution());

        var bankUpdatorService = new InstitutionUpdaterService(mockInstitutionRepository.Object);

        var sut = new InstitutionUpdateCommandHandler(bankUpdatorService);

        var request = new InstitutionUpdateCommandRequest
        {
            InstitutionId = Guid.NewGuid(),
            InstitutionName = "Test 123",
            OrderBy = 88,
        };

        var bankUpdateCommandResponse = sut.Handle(request, new CancellationToken());

        //  The bank to update does not exist, so should return one exception of
        //  type "InstitutionDoesNotExistsException()"
        bankUpdateCommandResponse.Result.HasExceptions.Should().BeTrue();
        bankUpdateCommandResponse.Result.Exceptions.Count.Should().Be(1);
    }
}
