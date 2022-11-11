namespace Tuber.BLL.Banks.Commands;
public class PutBankAPIResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int OrderBy { get; set; }
    public Guid CreatedByUserId { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid UpdatedByUserId { get; set; }
    public DateTime UpdatedOn { get; set; }
}
