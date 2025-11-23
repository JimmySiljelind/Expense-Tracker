using Expense_Tracker.Models;
using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Data
{
    public class ExpenseContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var dataDir = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\..\Data"));
                Directory.CreateDirectory(dataDir);
                var dbPath = Path.Combine(dataDir, "expenses.db");

                optionsBuilder.UseSqlite($"Data Source={dbPath}");
            }
        }
    }
}
