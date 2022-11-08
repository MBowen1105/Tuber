namespace Tuber.BLL.Banks.Queries;
public class GetBankByIdQueryResponse : QueryResponseBase
{
    public Guid Id { get; set; }
    public string Name { get; set; } = "";
    public int OrderBy { get; set; }
    public bool IsArchived { get; set; }
}
