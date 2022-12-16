using Microsoft.EntityFrameworkCore;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.DAL.BankAccounts;
public class BankAccountRepository : IBankAccountRepository
{
    private readonly ApplicationDbContext _context;
    public BankAccountRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    #region "Commands"
    public BankAccount Add(BankAccount bankAccount)
    {
        try
        {
            _context.BankAccounts.Add(bankAccount);
        }
        catch (Exception)
        {
            //  Return a null Bank object
            bankAccount = new BankAccount();
        }
        return bankAccount;
    }

    public BankAccount Update(BankAccount bankAccount)
    {
        var bankAccountModel = _context.BankAccounts
            .Include(x => x.CreatedByUser)
            .Include(x => x.UpdatedByUser)
            .FirstOrDefault(x => x.BankAccountId == bankAccount.BankAccountId && x.IsDeleted == false);

        if (bankAccountModel is null)
            return new BankAccount();

        bankAccountModel.BankAccountName = bankAccountModel.BankAccountName;
        bankAccountModel.UKBankAccount = bankAccountModel.UKBankAccount;
        bankAccountModel.UKSortCode = bankAccountModel.UKSortCode;
        bankAccountModel.BankId = bankAccountModel.BankId;
        bankAccountModel.ImportTemplateId = bankAccountModel.ImportTemplateId;
        bankAccountModel.OrderBy = bankAccount.OrderBy;

        return bankAccountModel;
    }

    public int Delete(Guid bankAccountId)
    {
        var bankAccount = _context.BankAccounts
            .FirstOrDefault(x => x.BankAccountId == bankAccountId && x.IsDeleted == false);

        if (bankAccount == null)
            return 0;

        bankAccount.IsDeleted = true;

        return 1;
    }
    #endregion

    #region "Queries"
    public BankAccount GetById(Guid bankAccountId)
    {
        var bankAccount = _context.Set<BankAccount>()
            .Include(x => x.CreatedByUser)
            .Include(x => x.UpdatedByUser)
            .FirstOrDefault(x => x.BankAccountId == bankAccountId && x.IsDeleted == false);

        return bankAccount ?? new BankAccount();
    }

    public List<BankAccount> GetPaged(int pageNumber, int pageSize)
    {
        return _context.Set<BankAccount>()
            .Include(x => x.CreatedByUser)
            .Include(x => x.UpdatedByUser)
            .Where(x => x.IsDeleted == false)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .OrderBy(x => x.OrderBy)
            .ToList();
    }

    public int CountPages(int pageSize)
    {
        var itemCount = _context.Set<BankAccount>()
            .Count(x => x.IsDeleted == false);

        var pages = itemCount / (pageSize * 1.0);

        return (int)Math.Ceiling(pages);
    }

    #endregion

    public int SaveChanges()
    {
        return _context.SaveChanges();
    }
}
