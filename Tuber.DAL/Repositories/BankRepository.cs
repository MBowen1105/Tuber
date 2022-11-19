using Microsoft.EntityFrameworkCore;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.DAL.Repositories;
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
            .FirstOrDefault(x => x.Id == bank.Id && x.IsArchived == false);

        if (bankModel is null)
            return new Bank { Id = Guid.Empty };

        bankModel.Name = bank.Name;
        bankModel.OrderBy = bank.OrderBy;

        return bankModel;
    }

    public int Delete(Guid id)
    {
        var bank = _context.Banks
            .Include(x => x.BankAccounts)
            .FirstOrDefault(x => x.Id == id && x.IsArchived == false);

        if (bank == null)
            return 0;

        bank.IsArchived = true;

        foreach (var bankAccount in bank.BankAccounts!)
        {
            bankAccount.IsArchived = true;
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
            .FirstOrDefault(x => x.Id == id && x.IsArchived == false);

        return (bank ?? new Bank { Id = Guid.Empty });
    }

    public List<Bank> GetAll()
    {
        //  TODO: Order by Bank, then BankAccount OrderBy
        var list = _context.Banks
            .Include(x => x.BankAccounts)
            .Where(x => x.IsArchived == false)
            .OrderBy(x => x.OrderBy)
            .ToList();

        return list;
    }

    public List<Bank> GetPaged(int pageNumber, int pageSize)
    {
        var list = _context.Banks
            .Include(x => x.BankAccounts)
            .Where(x => x.IsArchived == false)
            .OrderBy(x => x.OrderBy)
            .Skip((pageNumber * pageSize) - pageSize)
            .Take(pageSize)
            .ToList();

        return list;
    }

    public int CountPages(int pageSize)
    {
        var itemCount = _context.Banks
            .Count(x => x.IsArchived == false);

        var totalPages = itemCount / (pageSize * 1.0);

        return (int)Math.Ceiling(totalPages);
    }

    #endregion
}
