using Tuber.Core.ValueObjects;
using Tuber.Domain.API.Banks.Domains;
using Tuber.Domain.DAL;

namespace Tuber.DAL;
public class BankRepo : IRepo
{
    public BankDomain[] Get(ISO8601Date fromDate, PositiveInt numberOfDays)
    {
        var bankNames = new[]
            {
                "Co-Operative", "Lloyds", "Santander", "Halifax", "WBBS", "Nat West", "Barclays", "RBS", "Anna"
            };

        return Enumerable.Range(1, numberOfDays.Value).Select(index =>
                new BankDomain
                {
                    Date = DateTime.Now.AddDays(index),
                    Name = bankNames[Random.Shared.Next(bankNames.Length)]
                })
            .ToArray();
    }
}
