﻿using Microsoft.EntityFrameworkCore;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Domain.Models;

namespace Tuber.Persistence.Banks;
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
        try
        {
            _context.Banks.Add(bank);
        }
        catch (Exception)
        {
            //  Return a null Bank object
            bank = new Bank();
        }
        return bank;
    }

    public Bank Update(Bank bank)
    {
        var bankModel = _context.Banks
            .Include(x => x.CreatedByUser)
            .Include(x => x.UpdatedByUser)
            .FirstOrDefault(x => x.BankId == bank.BankId && x.IsDeleted == false);

        if (bankModel is null)
            return new Bank();

        bankModel.BankName = bank.BankName;
        bankModel.OrderBy = bank.OrderBy;

        return bankModel;
    }

    public int Delete(Guid bankId)
    {
        var bank = _context.Banks
            .FirstOrDefault(x => x.BankId == bankId && x.IsDeleted == false);

        if (bank == null)
            return 0;

        bank.IsDeleted = true;

        //  Soft Delete all associated bank accounts
        foreach (var bankAccount in bank.BankAccounts!)
        {
            bankAccount.IsDeleted = true;
        }

        return 1;
    }

    #endregion

    #region "Queries"
    public Bank GetById(Guid id)
    {
        var bank = _context.Banks
            .Include(x => x.BankAccounts)
            .Include(x => x.ImportTemplate)
            .Include(x => x.CreatedByUser)
            .Include(x => x.UpdatedByUser)
            .FirstOrDefault(x => x.BankId == id && x.IsDeleted == false);

        return bank ?? new Bank();
    }

    public List<Bank> GetPaged(int pageNumber, int pageSize)
    {
        return _context.Banks
            .Include(x => x.BankAccounts)
            .Include(x => x.CreatedByUser)
            .Include(x => x.UpdatedByUser)
            .Where(x => x.IsDeleted == false)
            .OrderBy(x => x.OrderBy)
            .Skip(pageNumber * pageSize - pageSize)
            .Take(pageSize)
            .ToList();
    }

    public int CountPages(int pageSize)
    {
        var itemCount = _context.Banks
            .Count(x => x.IsDeleted == false);

        var totalPages = itemCount / (pageSize * 1.0);

        return (int)Math.Ceiling(totalPages);
    }

    public bool NameExists(string bankName)
    {
        return _context.Banks.Any(x => x.BankName == bankName);
    }

    #endregion

    public int SaveChanges()
    {
        return _context.SaveChanges();
    }
}
