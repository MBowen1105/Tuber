﻿using Tuber.Core.Enums;
using Tuber.Domain.Common;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.BLL.BankAccounts.Services;
public  class BankAccountRetrievalService : IBankAccountRetrievalService
{
    private readonly IBankAccountRepository _bankAccountRepository;

    public BankAccountRetrievalService(IBankAccountRepository bankAccountRepo)
    {
        _bankAccountRepository = bankAccountRepo;
    }

    public ServiceResult<BankAccount> GetById(Guid bankAccountId)
    {
        var bankAccount = _bankAccountRepository.GetById(bankAccountId);

        if (bankAccount.BankAccountId == Guid.Empty)
            return new ServiceResult<BankAccount>(
                bankAccount,
                new EntityDoesNotExistException(ExceptionDbOperation.Get, BankAccount.FriendlyName, bankAccount.BankAccountId));

        return new ServiceResult<BankAccount>(bankAccount);
    }

    public ServiceResult<List<BankAccount>> GetPaged(int pageNumber, int pageSize)
    {
        return new ServiceResult<List<BankAccount>>(
            payload: _bankAccountRepository.GetPaged(pageNumber, pageSize));
    }

    public int CountPages(int pageSize)
    {
        return _bankAccountRepository.CountPages(pageSize);
    }
}
