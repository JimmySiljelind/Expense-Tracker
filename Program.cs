using Expense_Tracker.Data;
using Expense_Tracker.Models;

namespace Expense_Tracker
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using (var db = new ExpenseContext())
            {
                db.Database.EnsureCreated();

                if (!db.Categories.Any())
                {
                    db.Categories.AddRange(
                        new Category { Name = "Food" },
                        new Category { Name = "Transport" },
                        new Category { Name = "Utilities" },
                        new Category { Name = "Entertainment" },
                        new Category { Name = "Clothes" },
                        new Category { Name = "Other" }
                    );
                    db.SaveChanges();
                }
            }

            Application.Run(new MainForm());
        }
    }
}