using FluentAssertions;
using Moq;
using Tuber.BLL.Subcategories.Commands.SubcategoryDelete;
using Tuber.Core.Enums;
using Tuber.Core.Exceptions;
using Tuber.Domain.Common;
using Tuber.Domain.Exceptions;
using Tuber.BLL.Interfaces;
using Tuber.Domain.Models;

namespace Tuber.UnitTests.Domain.Subcategories.Commands.SubcategoryDelete;
internal class SubcategoryDeleteCommandHandler_UnitTests
{
    private SubcategoryDeleteCommandHandler _sut;

    private readonly Guid GoodIsCoreId = Guid.Parse("40ba8e81-5b0f-4470-8719-51bd53597d89");
    private readonly Guid GoodIsNotCoreId = Guid.Parse("1260fbc6-a6d7-4617-bc2c-f09e3ef86ea2");
    private readonly Guid BadId = Guid.Parse("cd25992c-4a81-4f10-9e73-b741fc625099");

    private readonly Mock<ISubcategoryRetrievalService> _mockSubcategoryRetrievalService = new();
    private readonly Mock<ISubcategoryDeletionService> _mockSubcategoryDeletionService = new();

    [SetUp]
    public void SetUp()
    {
        //  Existing Subcategory that is NOT a Core entity
        _mockSubcategoryRetrievalService.Setup(x => x.GetById(It.Is<Guid>(x => x.Equals(GoodIsNotCoreId))))
            .Returns(new ServiceResult<Subcategory>(new Subcategory() { IsCoreSubcategory = false }));

        //  Existing Subcategory that IS a Core entity
        _mockSubcategoryRetrievalService.Setup(x => x.GetById(It.Is<Guid>(x => x.Equals(GoodIsCoreId))))
            .Returns(new ServiceResult<Subcategory>(new Subcategory() { IsCoreSubcategory = true }));

        //  Missing Subcategory
        _mockSubcategoryRetrievalService.Setup(x => x.GetById(It.Is<Guid>(x => x.Equals(BadId))))
            .Returns(new ServiceResult<Subcategory>(new Subcategory()));

        _mockSubcategoryDeletionService.Setup(x => x.Delete(It.Is<Guid>(x => x.Equals(GoodIsNotCoreId))))
           .Returns(new ServiceResult<int>(1)
           );
        _mockSubcategoryDeletionService.Setup(x => x.Delete(It.Is<Guid>(x => x.Equals(BadId))))
           .Returns(new ServiceResult<int>(0, new EntityDoesNotExistException(
               ExceptionDbOperation.Delete, Subcategory.FriendlyName, BadId))
           );


        _sut = new SubcategoryDeleteCommandHandler(
            _mockSubcategoryRetrievalService.Object,
            _mockSubcategoryDeletionService.Object);

    }

    [Test, Parallelizable]
    public void NonCoreSubcategory_Returns1WithNoExceptionsException()
    {
        var subcategoryDeleteCommandResponse = _sut.Handle(
            new SubcategoryDeleteCommandRequest
            {
                SubcategoryId = GoodIsNotCoreId,
            }, new CancellationToken());

        subcategoryDeleteCommandResponse.Result.HasExceptions.Should().BeFalse();
        subcategoryDeleteCommandResponse.Result.Exceptions.Count.Should().Be(0);

        subcategoryDeleteCommandResponse.Result.DeletedCount.Should().Be(1);
    }

    [Test, Parallelizable]
    public void CoreSubcategory_ReturnsCannotDeleteCoreEntityException()
    {
        var subcategoryDeleteCommandResponse = _sut.Handle(
            new SubcategoryDeleteCommandRequest
            {
                SubcategoryId = GoodIsCoreId,
            }, new CancellationToken());

        subcategoryDeleteCommandResponse.Result.HasExceptions.Should().BeTrue();
        subcategoryDeleteCommandResponse.Result.Exceptions.Count.Should().Be(1);
        subcategoryDeleteCommandResponse.Result.Exceptions.First().Should().BeEquivalentTo(
            new CannotDeleteCoreEntityException(Subcategory.FriendlyName, GoodIsCoreId));

        subcategoryDeleteCommandResponse.Result.DeletedCount.Should().Be(0);
    }

    [Test, Parallelizable]
    public void MissingSubcategory_ReturnsEntityToDeleteDoesNotExistException()
    {
        var subcategoryDeleteCommandResponse = _sut.Handle(
                    new SubcategoryDeleteCommandRequest
                    {
                        SubcategoryId = BadId,
                    }, new CancellationToken());

        subcategoryDeleteCommandResponse.Result.HasExceptions.Should().BeTrue();
        subcategoryDeleteCommandResponse.Result.Exceptions.Count.Should().Be(1);
        subcategoryDeleteCommandResponse.Result.Exceptions.First().Should().BeEquivalentTo(
            new EntityDoesNotExistException(
                ExceptionDbOperation.Delete, Subcategory.FriendlyName, BadId));

        subcategoryDeleteCommandResponse.Result.DeletedCount.Should().Be(0);
    }




}
