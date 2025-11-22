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
            panelCard = new Panel();
            lblDescription = new Label();
            lblCategory = new Label();
            lblDate = new Label();
            lblTitle = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            txtDescription = new TextBox();
            cmbCategory = new ComboBox();
            dtpDate = new DateTimePicker();
            lblAmount = new Label();
            numAmount = new NumericUpDown();
            panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // 
            // panelCard
            // 
            panelCard.BackColor = Color.FromArgb(248, 250, 252);
            panelCard.BorderStyle = BorderStyle.FixedSingle;
            panelCard.Controls.Add(lblDescription);
            panelCard.Controls.Add(lblCategory);
            panelCard.Controls.Add(lblDate);
            panelCard.Controls.Add(lblTitle);
            panelCard.Controls.Add(btnCancel);
            panelCard.Controls.Add(btnSave);
            panelCard.Controls.Add(txtDescription);
            panelCard.Controls.Add(cmbCategory);
            panelCard.Controls.Add(dtpDate);
            panelCard.Controls.Add(lblAmount);
            panelCard.Controls.Add(numAmount);
            panelCard.Location = new Point(16, 16);
            panelCard.Name = "panelCard";
            panelCard.Padding = new Padding(16);
            panelCard.Size = new Size(768, 418);
            panelCard.TabIndex = 0;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescription.ForeColor = Color.FromArgb(17, 24, 39);
            lblDescription.Location = new Point(200, 236);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(238, 15);
            lblDescription.TabIndex = 13;
            lblDescription.Text = "Description - a short note to remember it";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCategory.ForeColor = Color.FromArgb(17, 24, 39);
            lblCategory.Location = new Point(199, 179);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(161, 15);
            lblCategory.TabIndex = 11;
            lblCategory.Text = "Category - where it belongs";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDate.ForeColor = Color.FromArgb(17, 24, 39);
            lblDate.Location = new Point(199, 121);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(125, 15);
            lblDate.TabIndex = 9;
            lblDate.Text = "Date - when you paid";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(17, 24, 39);
            lblTitle.Location = new Point(32, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(146, 25);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Expense Details";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.BackColor = Color.FromArgb(243, 244, 246);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.FromArgb(17, 24, 39);
            btnCancel.Location = new Point(390, 369);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 28);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.BackColor = Color.FromArgb(52, 120, 246);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(284, 369);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 28);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(200, 256);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(360, 80);
            txtDescription.TabIndex = 3;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(200, 198);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(360, 23);
            cmbCategory.TabIndex = 2;
            // 
            // dtpDate
            // 
            dtpDate.CalendarForeColor = Color.Black;
            dtpDate.CalendarMonthBackground = Color.White;
            dtpDate.CalendarTitleBackColor = Color.White;
            dtpDate.CalendarTitleForeColor = Color.Black;
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(200, 140);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(360, 23);
            dtpDate.TabIndex = 1;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAmount.ForeColor = Color.FromArgb(17, 24, 39);
            lblAmount.Location = new Point(199, 66);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(160, 15);
            lblAmount.TabIndex = 8;
            lblAmount.Text = "Amount (SEK) - what it cost";
            // 
            // numAmount
            // 
            numAmount.BackColor = Color.White;
            numAmount.BorderStyle = BorderStyle.FixedSingle;
            numAmount.DecimalPlaces = 2;
            numAmount.Location = new Point(200, 85);
            numAmount.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(360, 23);
            numAmount.TabIndex = 0;
            numAmount.ThousandsSeparator = true;
            // 
            // EditExpenseForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(panelCard);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditExpenseForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Expenses";
            Load += EditExpenseForm_Load;
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCard;
        private Label lblTitle;
        private Label lblAmount;
        private NumericUpDown numAmount;
        private DateTimePicker dtpDate;
        private Label lblDate;
        private ComboBox cmbCategory;
        private Label lblCategory;
        private TextBox txtDescription;
        private Label lblDescription;
        private Button btnSave;
        private Button btnCancel;
    }
}
