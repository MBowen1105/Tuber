using FluentAssertions;
using Moq;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Domain.Models;
using Tuber.Application.Subcategories.Services;

namespace Application.UnitTests.Subcategories.Services;
internal class SubcategoryDeletionService_UnitTests
{
    private ISubcategoryDeletionService _sut;

    private Mock<ISubcategoryRepository> _mockSubcategoryRepo = new();

    private readonly Guid CORE_SUBCATEGORY_ID = Guid.Parse("0fe799e6-c14d-4387-8aa8-6775531620f6");
    private readonly Guid NONCORE_SUBCATEGORY_ID = Guid.Parse("37ad872a-0304-4b10-abd3-3427dd90ec02");
    private readonly Guid MISSING_SUBCATEGORY_ID = Guid.Parse("b0a40ab9-74e6-47f3-964f-951b42fd28a3");

    [SetUp]
    public void Setup()
    {
        _mockSubcategoryRepo.Setup(x => x.GetById(It.Is<Guid>(x => x.Equals(CORE_SUBCATEGORY_ID))))
            .Returns(new Subcategory
            {
                SubcategoryId = CORE_SUBCATEGORY_ID,
                IsCoreSubcategory = true
            });

        _mockSubcategoryRepo.Setup(x => x.GetById(It.Is<Guid>(x => x.Equals(NONCORE_SUBCATEGORY_ID))))
           .Returns(new Subcategory
           {
               SubcategoryId = NONCORE_SUBCATEGORY_ID,
               IsCoreSubcategory = false
           });
        _mockSubcategoryRepo.Setup(x => x.Delete(It.Is<Guid>(x => x.Equals(NONCORE_SUBCATEGORY_ID))))
          .Returns(1);

        _mockSubcategoryRepo.Setup(x => x.GetById(It.Is<Guid>(x => x.Equals(MISSING_SUBCATEGORY_ID))))
           .Returns(new Subcategory());
        _mockSubcategoryRepo.Setup(x => x.Delete(It.Is<Guid>(x => x.Equals(MISSING_SUBCATEGORY_ID))))
          .Returns(0);

        _sut = new SubcategoryDeletionService(_mockSubcategoryRepo.Object);
    }

    [Test, Parallelizable]
    public void DeletingSubcategoryThatIsACoreSubcategory_ReturnsException()
    {
        var serviceResult = _sut.Delete(CORE_SUBCATEGORY_ID);

        serviceResult.IsSuccess.Should().BeFalse();
        serviceResult.HasFailed.Should().BeTrue();
        serviceResult.Exceptions.Count.Should().Be(1);
        serviceResult.Exceptions.First().Should().BeOfType<CannotDeleteCoreEntityException>();
        serviceResult.Payload.Should().Be(0);
    }

    [Test, Parallelizable]
    public void DeletingSubcategoryThatNotACoreSubcategory_ReturnsPayloadOf1AndNoException()
    {
        var serviceResult = _sut.Delete(NONCORE_SUBCATEGORY_ID);

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.HasFailed.Should().BeFalse();
        serviceResult.Exceptions.Count.Should().Be(0);
        serviceResult.Payload.Should().Be(1);
    }

    [Test, Parallelizable]
    public void DeletingSubcategoryThatDoesNotExist_ReturnsException()
    {
        var serviceResult = _sut.Delete(MISSING_SUBCATEGORY_ID);

        serviceResult.IsSuccess.Should().BeFalse();
        serviceResult.HasFailed.Should().BeTrue();
        serviceResult.Exceptions.Count.Should().Be(1);
        serviceResult.Exceptions.First().Should().BeOfType<EntityDoesNotExistException>();
        serviceResult.Payload.Should().Be(0);
    }
}
