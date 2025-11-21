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
                txtAmount.Text = _expense.Amount.ToString();
                dtpDate.Value = _expense.Date;
                txtDescription.Text = _expense.Description;
                cmbCategory.SelectedValue = _expense.CategoryId;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using var db = new ExpenseContext();

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

            entity.Amount = decimal.Parse(txtAmount.Text);
            entity.Date = dtpDate.Value.Date;
            entity.Description = txtDescription.Text;
            entity.CategoryId = (int)cmbCategory.SelectedValue;

            db.SaveChanges();
            DialogResult = DialogResult.OK;
        }
    }
}
