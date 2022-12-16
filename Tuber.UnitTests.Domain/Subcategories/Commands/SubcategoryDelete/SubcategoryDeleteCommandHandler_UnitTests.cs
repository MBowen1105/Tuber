﻿using FluentAssertions;
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
            .Returns(new ServiceResult<Subcategory>(new Subcategory()));

        var mockSubcategoryUpdaterService = new Mock<ISubcategoryUpdaterService>();

        mockSubcategoryUpdaterService.Setup(x => x.Delete(It.IsAny<Guid>()))
            .Returns(new ServiceResult<int>(0));

        var sut = new SubcategoryDeleteCommandHandler(
            mockSubcategoryRetrievalService.Object,
            mockSubcategoryUpdaterService.Object);

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

        var mockSubcategoryUpdaterService = new Mock<ISubcategoryUpdaterService>();

        mockSubcategoryUpdaterService.Setup(x => x.Delete(It.IsAny<Guid>()))
            .Returns(new ServiceResult<int>(0));

        var sut = new SubcategoryDeleteCommandHandler(
            mockSubcategoryRetrievalService.Object,
            mockSubcategoryUpdaterService.Object);

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
}
