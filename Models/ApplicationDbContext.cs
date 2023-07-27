using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker_Web.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
