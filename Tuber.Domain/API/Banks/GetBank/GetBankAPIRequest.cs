using Tuber.Core.Interfaces;

namespace Tuber.Domain.API.Banks.GetBank
{
    public class GetBankAPIRequest : IPagedAPIQuery
    {
        public int PageNumber { get; init; } = 1;
        public int PageSize { get; init; } = 5;
    }
}
