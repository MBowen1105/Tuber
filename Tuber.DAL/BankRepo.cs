using Tuber.Domain.API.Banks.Models;
using Tuber.Domain.DAL;

namespace Tuber.DAL;
public class BankRepo : IBankRepo
{
    public int CountPages(int pageSize)
    {
        return 25;
    }

    public List<BankDto> GetPaged(int pageNumber, int pageSize)
    {
        var bankNames = new[]
            {
                "Co-Operative", "Lloyds", "Santander", "Halifax", "WBBS", "Nat West", "Barclays", "RBS", "Anna"
            };

        return Enumerable.Range(1, pageSize).Select(index =>
                new BankDto
                {
                    Date = DateTime.Now.AddDays(index),
                    Name = bankNames[Random.Shared.Next(bankNames.Length)]
                })
            .ToList();
    }
}
