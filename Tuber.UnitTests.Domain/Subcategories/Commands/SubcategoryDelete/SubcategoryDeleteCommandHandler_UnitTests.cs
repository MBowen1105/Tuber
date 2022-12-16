using FluentAssertions;
using Moq;
using Tuber.BLL.Subcategories.Commands.SubcategoryDelete;
using Tuber.Core.Exceptions;
using Tuber.Domain.Common;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Models;

namespace Tuber.UnitTests.Domain.Subcategories.Commands.SubcategoryDelete;
internal class SubcategoryDeleteCommandHandler_UnitTests
{
    [SetUp]
    public void SetUp()
    {
    }

    [Test]
    public void SubcategoryDeleteCommandHandler_MissingSubcategory_ReturnsEntityToDeleteDoesNotExistException()
    {
        var mockSubcategoryRetrievalService = new Mock<ISubcategoryRetrievalService>();

        mockSubcategoryRetrievalService.Setup(x => x.GetById(It.IsAny<Guid>()))
            .Returns(new ServiceResult<Subcategory>(
                payload: new Subcategory(),
                exception: new EntityToDeleteDoesNotExistException(Subcategory.FriendlyName, Guid.NewGuid())));

        var mockSubcategoryDeletionService = new Mock<ISubcategoryDeletionService>();

        mockSubcategoryDeletionService.Setup(x => x.Delete(It.IsAny<Guid>()))
            .Returns(new ServiceResult<int>(0));

        var sut = new SubcategoryDeleteCommandHandler(
            mockSubcategoryRetrievalService.Object,
            mockSubcategoryDeletionService.Object);

        var request = new SubcategoryDeleteCommandRequest
        {
            SubcategoryId = Guid.NewGuid(),
        };

        var subcategoryDeleteCommandResponse = sut.Handle(request, new CancellationToken());

        subcategoryDeleteCommandResponse.Result.DeletedCount.Should().Be(0);
        subcategoryDeleteCommandResponse.Result.HasExceptions.Should().BeTrue();
        subcategoryDeleteCommandResponse.Result.Exceptions.Count.Should().Be(1);
        subcategoryDeleteCommandResponse.Result.Exceptions.First().Should().BeOfType<EntityToDeleteDoesNotExistException>();
    }

    [Test]
    public void SubcategoryDeleteCommandHandler_CoreSubcategory_ReturnsCannotDeleteCoreEntityException()
    {
        var mockSubcategoryRetrievalService = new Mock<ISubcategoryRetrievalService>();

        mockSubcategoryRetrievalService.Setup(x => x.GetById(It.IsAny<Guid>()))
            .Returns(new ServiceResult<Subcategory>(new Subcategory
            {
                IsCoreSubcategory = true
            }));

        var mockSubcategoryDeletionService = new Mock<ISubcategoryDeletionService>();

        mockSubcategoryDeletionService.Setup(x => x.Delete(It.IsAny<Guid>()))
            .Returns(new ServiceResult<int>(0));

        var sut = new SubcategoryDeleteCommandHandler(
            mockSubcategoryRetrievalService.Object,
            mockSubcategoryDeletionService.Object);

       var request = new SubcategoryDeleteCommandRequest
        {
            SubcategoryId = Guid.NewGuid(),
        };

        var subcategoryDeleteCommandResponse = sut.Handle(request, new CancellationToken());

        subcategoryDeleteCommandResponse.Result.DeletedCount.Should().Be(0);
        subcategoryDeleteCommandResponse.Result.HasExceptions.Should().BeTrue();
        subcategoryDeleteCommandResponse.Result.Exceptions.Count.Should().Be(1);
        subcategoryDeleteCommandResponse.Result.Exceptions.First().Should().BeOfType<CannotDeleteCoreEntityException>();
    }

    [Test]
    public void SubcategoryDeleteCommandHandler_NonCoreSubcategory_Returns1WithNoExceptionsException()
    {
        var mockSubcategoryRetrievalService = new Mock<ISubcategoryRetrievalService>();

        mockSubcategoryRetrievalService.Setup(x => x.GetById(It.IsAny<Guid>()))
            .Returns(new ServiceResult<Subcategory>(new Subcategory()));

        var mockSubcategoryDeletionService = new Mock<ISubcategoryDeletionService>();

        mockSubcategoryDeletionService.Setup(x => x.Delete(It.IsAny<Guid>()))
            .Returns(new ServiceResult<int>(1));

        var sut = new SubcategoryDeleteCommandHandler(
            mockSubcategoryRetrievalService.Object,
            mockSubcategoryDeletionService.Object);

        var request = new SubcategoryDeleteCommandRequest
        {
            SubcategoryId = Guid.NewGuid(),
        };

        var subcategoryDeleteCommandResponse = sut.Handle(request, new CancellationToken());

        subcategoryDeleteCommandResponse.Result.DeletedCount.Should().Be(1);
        subcategoryDeleteCommandResponse.Result.HasExceptions.Should().BeFalse();
        subcategoryDeleteCommandResponse.Result.Exceptions.Count.Should().Be(0);
    }

}
