﻿using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces;
public interface IInstitutionAccountRetrievalService
{
    ServiceResult<List<InstitutionAccount>> GetPaged(int pageNumber, int pageSize);
    ServiceResult<InstitutionAccount> GetById(Guid bankAccountId);
    int CountPages(int pageSize);
}
