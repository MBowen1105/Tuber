using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Reflection.Metadata;
using Tuber.DAL;
using Tuber.DAL.BankAccounts;
using Tuber.Domain.Models;

namespace Tuber.UnitTests.DAL.BankAccounts;
internal class BankAccountRepository_UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GetById_Existing_ReturnsRecord()
    {
        var mockApplicationDbContext = new Mock<ApplicationDbContext>();
        var DbSetBankAccount = new List<BankAccount>();

        mockApplicationDbContext.Setup(x => x.BankAccounts)
            .Returns((DbSet<BankAccount>)DbSetBankAccount);

        var _sut = new BankAccountRepository(mockApplicationDbContext.Object);
        var bankAccount = _sut.getById(GoodID);
    }
}
