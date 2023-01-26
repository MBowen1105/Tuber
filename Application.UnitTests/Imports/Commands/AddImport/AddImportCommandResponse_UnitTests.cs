using FluentAssertions;
using Tuber.Application.Imports.Commands.ImportAdd;

namespace Tuber.Application.UnitTests.Imports.Commands.AddImport;
internal class AddImportCommandResponse_UnitTests
{
    [TestCase]
    public void NewingUpAddImportCommandResponse_ReturnsCorrectNullValues()
    {
        var sut = new ImportAddCommandResponse();

        sut.InstitutionAccountId.Should().Be(Guid.Empty);
        sut.ImportFileName.Should().Be("");
        sut.ValidImportRowCount.Should().Be(0);
        sut.InvalidImportRowCount.Should().Be(0);
        sut.Exceptions.Count.Should().Be(0);
        sut.HasExceptions.Should().BeFalse();
    }
}
