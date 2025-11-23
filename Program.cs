using CategoryClassLibrary;
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
                    var defaultCategories = CategoriesList
                        .GetDefaultNames()
                        .Select(name => new Category { Name = name });

                    db.Categories.AddRange(defaultCategories);
                    db.SaveChanges();
                }
            }

            Application.Run(new MainForm());
        }
    }
}
