namespace Expense_Tracker.Forms
{
    partial class EditExpenseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAmount = new TextBox();
            dtpDate = new DateTimePicker();
            cmbCategory = new ComboBox();
            txtDescription = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(200, 98);
            txtAmount.Multiline = true;
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(387, 23);
            txtAmount.TabIndex = 0;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(200, 158);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(387, 23);
            dtpDate.TabIndex = 1;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(200, 223);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(387, 23);
            cmbCategory.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(200, 284);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(387, 23);
            txtDescription.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(303, 337);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(410, 337);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // EditExpenseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(cmbCategory);
            Controls.Add(dtpDate);
            Controls.Add(txtAmount);
            Name = "EditExpenseForm";
            Text = "Edit Expenses";
            Load += EditExpenseForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAmount;
        private DateTimePicker dtpDate;
        private ComboBox cmbCategory;
        private TextBox txtDescription;
        private Button btnSave;
        private Button btnCancel;
    }
}