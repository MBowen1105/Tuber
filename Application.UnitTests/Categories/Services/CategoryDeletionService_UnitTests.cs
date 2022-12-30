using FluentAssertions;
using Moq;
using Tuber.Application.Categories.Services;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Domain.Models;

namespace Application.UnitTests.Categories.Services;
internal class CategoryDeletionService_UnitTests
{
    private ICategoryDeletionService _sut;

    private Mock<ICategoryRepository> _mockCategoryRepo = new();

    private readonly Guid CORE_CATEGORY_ID = Guid.Parse("0fe799e6-c14d-4387-8aa8-6775531620f6");
    private readonly Guid NONCORE_CATEGORY_ID = Guid.Parse("37ad872a-0304-4b10-abd3-3427dd90ec02");
    private readonly Guid MISSING_CATEGORY_ID = Guid.Parse("b0a40ab9-74e6-47f3-964f-951b42fd28a3");

    [SetUp]
    public void Setup()
    {
        _mockCategoryRepo.Setup(x => x.GetById(It.Is<Guid>(x => x.Equals(CORE_CATEGORY_ID))))
            .Returns(new Category
            {
                CategoryId = CORE_CATEGORY_ID,
                IsCoreCategory = true
            });

        _mockCategoryRepo.Setup(x => x.GetById(It.Is<Guid>(x => x.Equals(NONCORE_CATEGORY_ID))))
           .Returns(new Category
           {
               CategoryId = NONCORE_CATEGORY_ID,
               IsCoreCategory = false
           });
        _mockCategoryRepo.Setup(x => x.Delete(It.Is<Guid>(x => x.Equals(NONCORE_CATEGORY_ID))))
          .Returns(1);

        _mockCategoryRepo.Setup(x => x.GetById(It.Is<Guid>(x => x.Equals(MISSING_CATEGORY_ID))))
           .Returns(new Category());
        _mockCategoryRepo.Setup(x => x.Delete(It.Is<Guid>(x => x.Equals(MISSING_CATEGORY_ID))))
          .Returns(0);

        _sut = new CategoryDeletionService(_mockCategoryRepo.Object);
    }

    [Test, Parallelizable]
    public void DeletingCategoryThatIsACoreCategory_ReturnsException()
    {
        var serviceResult = _sut.Delete(CORE_CATEGORY_ID);

        serviceResult.IsSuccess.Should().BeFalse();
        serviceResult.HasFailed.Should().BeTrue();
        serviceResult.Exceptions.Count.Should().Be(1);
        serviceResult.Exceptions.First().Should().BeOfType<CannotDeleteCoreEntityException>();
        serviceResult.Payload.Should().Be(0);
    }

    [Test, Parallelizable]
    public void DeletingCategoryThatNotACoreCategory_ReturnsPayloadOf1AndNoException()
    {
        var serviceResult = _sut.Delete(NONCORE_CATEGORY_ID);

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.HasFailed.Should().BeFalse();
        serviceResult.Exceptions.Count.Should().Be(0);
        serviceResult.Payload.Should().Be(1);
    }

    [Test, Parallelizable]
    public void DeletingCategoryThatDoesNotExist_ReturnsException()
    {
        var serviceResult = _sut.Delete(MISSING_CATEGORY_ID);

        serviceResult.IsSuccess.Should().BeFalse();
        serviceResult.HasFailed.Should().BeTrue();
        serviceResult.Exceptions.Count.Should().Be(1);
        serviceResult.Exceptions.First().Should().BeOfType<EntityDoesNotExistException>();
        serviceResult.Payload.Should().Be(0);
    }
}
