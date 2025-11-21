using Expense_Tracker.Data;
using Expense_Tracker.Forms;
using Expense_Tracker.Models;
using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadExpenses();
        }

        private void LoadExpenses()
        {
            using var db = new ExpenseContext();
            var expenses = db.Expenses
                             .Include(e => e.Category)
                             .OrderByDescending(e => e.Date)
                             .ToList();

            dgvExpenses.DataSource = expenses;

            var total = expenses.Sum(e => e.Amount);
            lblTotal.Text = $"Total: {total:C}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var form = new EditExpenseForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                LoadExpenses();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.CurrentRow?.DataBoundItem is Expense selected)
            {
                using var form = new EditExpenseForm(selected);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    LoadExpenses();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.CurrentRow?.DataBoundItem is Expense selected)
            {
                var confirm = MessageBox.Show("Delete selected expense?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    using var db = new ExpenseContext();
                    var entity = db.Expenses.First(e => e.Id == selected.Id);
                    db.Expenses.Remove(entity);
                    db.SaveChanges();
                    LoadExpenses();
                }
            }
        }
    }
}
