﻿using Microsoft.EntityFrameworkCore;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.DAL.BankAccounts;
public class BankAccountRepository : Repository<BankAccount>, IBankAccountRepository
{
    public BankAccountRepository(ApplicationDbContext context)
           : base(context)
    {
    }

    #region "Commands"
    #endregion

    #region "Queries"
    public BankAccount GetById(Guid bankAccountId)
    {
        var bankAccount = _context.Set<BankAccount>()
            .Include(x => x.Bank)
            .FirstOrDefault(x => x.BankAccountId == bankAccountId && x.IsDeleted == false);

        return bankAccount ?? new BankAccount();
    }

    public List<BankAccount> GetPaged(int pageNumber, int pageSize)
    {
        return _context.Set<BankAccount>()
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

    public ApplicationDbContext ApplicationDbContext
    {
        get { return ApplicationDbContext; }
    }

}
