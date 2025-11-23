using Expense_Tracker.Data;
using Expense_Tracker.Forms;
using Expense_Tracker.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.ComponentModel;

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
                             .ToList()
                             .Select(e => new ExpenseRow(e))
                             .ToList();

            dgvExpenses.DataSource = expenses;

            // Friendly headers/formatting for the grid.
            var amountColumn = dgvExpenses.Columns[nameof(Expense.Amount)];
            if (amountColumn is not null)
            {
                amountColumn.DefaultCellStyle.Format = "C2";
                amountColumn.DefaultCellStyle.FormatProvider = new CultureInfo("sv-SE");
                amountColumn.HeaderText = "Amount (SEK)";
            }

            var dateColumn = dgvExpenses.Columns[nameof(Expense.Date)];
            if (dateColumn is not null)
            {
                dateColumn.DefaultCellStyle.Format = "yyyy-MM-dd";
            }

            var descriptionColumn = dgvExpenses.Columns[nameof(Expense.Description)];
            if (descriptionColumn is not null)
            {
                descriptionColumn.HeaderText = "Description";
            }

            var categoryColumn = dgvExpenses.Columns[nameof(Expense.Category)];
            if (categoryColumn is not null)
            {
                categoryColumn.HeaderText = "Category";
            }

            var orderedColumns = new[]
            {
                amountColumn,
                categoryColumn,
                descriptionColumn,
                dateColumn
            };

            var displayIndex = 0;
            foreach (var column in orderedColumns)
            {
                if (column is null)
                {
                    continue;
                }

                column.DisplayIndex = displayIndex;
                displayIndex++;
            }

            var total = expenses.Sum(e => e.Amount);
            lblTotal.Text = $"Total: {total.ToString("C2", new CultureInfo("sv-SE"))}";
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
            if (dgvExpenses.CurrentRow?.DataBoundItem is ExpenseRow selectedRow)
            {
                var selected = selectedRow.Entity;
                using var form = new EditExpenseForm(selected);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    LoadExpenses();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.CurrentRow?.DataBoundItem is ExpenseRow selectedRow)
            {
                var selected = selectedRow.Entity;
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

        // Lightweight view-model so the grid shows friendly category text while keeping the entity reachable.
        private sealed class ExpenseRow
        {
            public ExpenseRow(Expense entity) => Entity = entity;

            [Browsable(false)]
            public Expense Entity { get; }
            public decimal Amount => Entity.Amount;
            public DateTime Date => Entity.Date;
            public string Description => Entity.Description;
            public string Category => Entity.Category?.Name ?? string.Empty;
        }
    }
}
