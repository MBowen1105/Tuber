using Microsoft.EntityFrameworkCore;
using Tuber.Domain.Banks.Models;

namespace Tuber.DAL;
public class ApplicationDbContext
        : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<BankModel> Banks { get; set; }

}
