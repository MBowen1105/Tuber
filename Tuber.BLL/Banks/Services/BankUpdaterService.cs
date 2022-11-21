using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.BLL.Banks.Services;
internal class BankUpdaterService : IBankUpdaterService
{
    private readonly IBankRepository _bankRepo;

    public BankUpdaterService(IBankRepository bankRepo)
    {
        _bankRepo = bankRepo;
    }

    public Bank Add(string name, int orderBy)
    {
        var bankModel = _bankRepo.Add(new Bank
        {
            Name = name,
            OrderBy = orderBy
        });

        _bankRepo.SaveChanges();

        return bankModel;
    }

    public Bank Update(Guid id, string name, int orderBy)
    {
        var bankModel = _bankRepo.Update(new Bank
        {
            BankId = id,
            Name = name,
            OrderBy = orderBy
        });

        _bankRepo.SaveChanges();

        return bankModel;
    }

    public int Delete(Guid id)
    {
        var bankModel = _bankRepo.GetById(id);

        if (bankModel.BankId == Guid.Empty)
            return 0;

        var result = _bankRepo.Delete(id);

        _bankRepo.SaveChanges();

        return result;
    }
}
