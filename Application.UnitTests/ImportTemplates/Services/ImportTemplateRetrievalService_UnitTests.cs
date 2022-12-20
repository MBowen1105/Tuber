using FluentAssertions;
using Moq;
using Tuber.Application.ImportTemplates.Services;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.Application.UnitTests.ImportTemplates.Services;

internal class ImportTemplateRetrievalService_UnitTests
{
    private Mock<IImportTemplateRepository> _importTemplateRepository;

    [SetUp]
    public void SetUp()
    {
        _importTemplateRepository = new Mock<IImportTemplateRepository>();
        
    }

    [Test, Parallelizable]
    public void ImportTemplateRetrievalService_NonExistentImportTemplate_ReturnsException()
    {
        //  An attempt to retrieve any ImportTemplate will return the Null version.
        var nullImportTemplate = new ImportTemplate();
        _importTemplateRepository.Setup(x => x.GetById(It.IsAny<Guid>()))
            .Returns(nullImportTemplate);

        var sut = new ImportTemplateRetrievalService(_importTemplateRepository.Object);

        var badId = Guid.NewGuid();
        var serviceResult = sut.GetById(badId);

        serviceResult.Should().NotBeNull();
        serviceResult.IsSuccess.Should().Be(false);
        serviceResult.Payload.Should().Be(nullImportTemplate);
        serviceResult.Exceptions.Count.Should().Be(1);
        var firstException = serviceResult.Exceptions.First();
        firstException.Message.Should().Be(new EntityDoesNotExistException(ImportTemplate.FriendlyName, badId).Message);
    }

    [Test]
    public void ImportTemplateRetrievalService_ExistingImportTemplate_IsReturned()
    {
        //  An attempt to retrieve any ImportTemplate will return the Null version.
        var id = Guid.NewGuid();
        var importTemplate = new ImportTemplate
        {
             ImportTemplateId = id,
        };
        _importTemplateRepository.Setup(x => x.GetById(It.IsAny<Guid>()))
            .Returns(importTemplate);

        var sut = new ImportTemplateRetrievalService(_importTemplateRepository.Object);

        var serviceResult = sut.GetById(id);

        serviceResult.Should().NotBeNull();
        serviceResult.IsSuccess.Should().Be(true);
        serviceResult.Payload.Should().Be(importTemplate);
        serviceResult.Exceptions.Count.Should().Be(0);
    }
}
