using Tuber.Domain.API.Banks.Domains;
using Tuber.Domain.DAL;

namespace Tuber.DAL;
public class BankRepo : IBankRepo
{
    public List<BankDomain> Get(int pageNumber, int pageSize)
    {
        var bankNames = new[]
            {
                "Co-Operative", "Lloyds", "Santander", "Halifax", "WBBS", "Nat West", "Barclays", "RBS", "Anna"
            };

        return Enumerable.Range(1, pageSize).Select(index =>
                new BankDomain
                {
                    Date = DateTime.Now.AddDays(index),
                    Name = bankNames[Random.Shared.Next(bankNames.Length)]
                })
            .ToList();
    }
}
