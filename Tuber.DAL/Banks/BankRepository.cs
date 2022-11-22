using Microsoft.EntityFrameworkCore;
using Tuber.Domain.Dtos;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.DAL.Banks;
public class BankRepository : IBankRepository
{
    private readonly ApplicationDbContext _context;

    public BankRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    #region "Commands"
    public Bank Add(Bank bank)
    {
        _context.Banks.Add(bank);

        return bank;
    }

    public Bank Update(Bank bank)
    {
        var bankModel = _context.Banks
            .Include(x => x.CreatedByUser)
            .Include(x => x.UpdatedByUser)
            .FirstOrDefault(x => x.BankId == bank.BankId && x.IsActive == true);

        if (bankModel is null)
            return new Bank { BankId = Guid.Empty };

        bankModel.Name = bank.Name;
        bankModel.OrderBy = bank.OrderBy;

        return bankModel;
    }

    public int Delete(Guid id)
    {
        var bank = _context.Banks
            .Include(x => x.BankAccounts)
            .FirstOrDefault(x => x.BankId == id && x.IsActive == true);

        if (bank == null)
            return 0;

        bank.IsActive = false;

        foreach (var bankAccount in bank.BankAccounts!)
        {
            bankAccount.IsActive = false;
        }

        return 1;
    }

    public int SaveChanges()
    {
        return _context.SaveChanges();
    }

    #endregion

    #region "Queries"
    public Bank GetById(Guid id)
    {
        var bank = _context.Banks
            .Include(x => x.BankAccounts)
            .FirstOrDefault(x => x.BankId == id && x.IsActive == true);

        return bank ?? new Bank { BankId = Guid.Empty };
    }

    public List<Bank> GetAll()
    {
        //  TODO: Order by Bank, then BankAccount OrderBy
        var list = _context.Banks
            .Include(x => x.BankAccounts)
            .Include(x => x.CreatedByUser)
            .Include(x => x.UpdatedByUser)
            .Where(x => x.IsActive == true)
            .OrderBy(x => x.OrderBy)
            .ToList();

        return list;
    }

    public List<Bank> GetPaged(int pageNumber, int pageSize)
    {
        var list = _context.Banks
            .Include(x => x.BankAccounts)
            .Include(x => x.CreatedByUser)
            .Include(x => x.UpdatedByUser)
            .Where(x => x.IsActive == true)
            .OrderBy(x => x.OrderBy)
            .Skip(pageNumber * pageSize - pageSize)
            .Take(pageSize)
            .ToList();

        
        return list;
    }

    public int CountPages(int pageSize)
    {
        var itemCount = _context.Banks
            .Count(x => x.IsActive == true);

        var totalPages = itemCount / (pageSize * 1.0);

        return (int)Math.Ceiling(totalPages);
    }

    #endregion
}
