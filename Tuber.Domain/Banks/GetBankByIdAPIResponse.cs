namespace Tuber.Domain.Banks;
public class GetBankByIdAPIResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = "";
    public int OrderBy { get; set; }
    public bool IsArchived { get; set; }
}
