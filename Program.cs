using Expense_Tracker.Data;

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
            }

            Application.Run(new MainForm());
        }
    }
}