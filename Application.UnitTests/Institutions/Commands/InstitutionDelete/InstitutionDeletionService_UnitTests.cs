using FluentAssertions;
using Moq;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Application.Institutions.Services;
using Tuber.Domain.Models;

namespace Application.UnitTests.Categories.Services;
internal class InstitutionDeletionService_UnitTests
{
    private IInstitutionDeletionService _sut;

    private Mock<IInstitutionRepository> _mockInstitutionRepo = new();

    private readonly Guid GOOD_INSTITUTION_ID = Guid.Parse("37ad872a-0304-4b10-abd3-3427dd90ec02");
    private readonly Guid MISSING_INSTITUTION_ID = Guid.Parse("b0a40ab9-74e6-47f3-964f-951b42fd28a3");

    [SetUp]
    public void Setup()
    {
        _mockInstitutionRepo.Setup(x => x.GetById(It.Is<Guid>(x => x.Equals(GOOD_INSTITUTION_ID))))
           .Returns(new Institution
           {
               InstitutionId = GOOD_INSTITUTION_ID,
           });
        _mockInstitutionRepo.Setup(x => x.Delete(It.Is<Guid>(x => x.Equals(GOOD_INSTITUTION_ID))))
          .Returns(1);

        _mockInstitutionRepo.Setup(x => x.GetById(It.Is<Guid>(x => x.Equals(MISSING_INSTITUTION_ID))))
           .Returns(new Institution());
        _mockInstitutionRepo.Setup(x => x.Delete(It.Is<Guid>(x => x.Equals(MISSING_INSTITUTION_ID))))
          .Returns(0);

        _sut = new InstitutionDeletionService(_mockInstitutionRepo.Object);
    }


    [Test, Parallelizable]
    public void DeletingInstitution_ReturnsPayloadOf1AndNoException()
    {
        var serviceResult = _sut.Delete(GOOD_INSTITUTION_ID);

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.HasFailed.Should().BeFalse();
        serviceResult.Exceptions.Count.Should().Be(0);
        serviceResult.Payload.Should().Be(1);
    }

    [Test, Parallelizable]
    public void DeletingInstitutionThatDoesNotExist_ReturnsException()
    {
        var serviceResult = _sut.Delete(MISSING_INSTITUTION_ID);

        serviceResult.IsSuccess.Should().BeFalse();
        serviceResult.HasFailed.Should().BeTrue();
        serviceResult.Exceptions.Count.Should().Be(1);
        serviceResult.Exceptions.First().Should().BeOfType<EntityDoesNotExistException>();
        serviceResult.Payload.Should().Be(0);
    }
}
