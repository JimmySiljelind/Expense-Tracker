using Expense_Tracker.Data;
using Expense_Tracker.Models;

namespace Expense_Tracker.Forms
{
    public partial class EditExpenseForm : Form
    {
        private readonly Expense? _expense; // null = new

        public EditExpenseForm(Expense? expense = null)
        {
            InitializeComponent();
            _expense = expense;
        }

        private void EditExpenseForm_Load(object sender, EventArgs e)
        {
            using var db = new ExpenseContext();
            var categories = db.Categories.OrderBy(c => c.Name).ToList();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";

            if (_expense != null)
            {
                numAmount.Value = _expense.Amount;
                dtpDate.Value = _expense.Date;
                txtDescription.Text = _expense.Description;
                cmbCategory.SelectedValue = _expense.CategoryId;
            }
            else
            {
                numAmount.Value = 0;
                numAmount.Text = string.Empty;
                dtpDate.Value = DateTime.Today;
                txtDescription.Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using var db = new ExpenseContext();

            if (string.IsNullOrWhiteSpace(numAmount.Text) || !decimal.TryParse(numAmount.Text, out var amount))
            {
                MessageBox.Show("Please enter a valid amount.", "Invalid amount",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCategory.SelectedItem is not Category selectedCategory)
            {
                MessageBox.Show("Please choose a category.", "Missing category",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Expense entity;
            if (_expense == null)
            {
                entity = new Expense();
                db.Expenses.Add(entity);
            }
            else
            {
                entity = db.Expenses.First(e => e.Id == _expense.Id);
            }

            entity.Amount = amount;
            entity.Date = dtpDate.Value.Date;
            entity.Description = txtDescription.Text;
            entity.CategoryId = selectedCategory.Id;

            db.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
