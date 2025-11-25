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
            actionsPanel = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            tableFields = new TableLayoutPanel();
            lableDescription = new Label();
            lableAmount = new Label();
            numAmount = new NumericUpDown();
            lableDate = new Label();
            ExpenseDate = new DateTimePicker();
            lableCategory = new Label();
            comBoxCategory = new ComboBox();
            txtDescription = new TextBox();
            lableTitle = new Label();
            panelCard.SuspendLayout();
            actionsPanel.SuspendLayout();
            tableFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // 
            // panelCard
            // 
            panelCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCard.Controls.Add(actionsPanel);
            panelCard.Controls.Add(tableFields);
            panelCard.Controls.Add(lableTitle);
            panelCard.Location = new Point(16, 16);
            panelCard.Name = "panelCard";
            panelCard.Padding = new Padding(24);
            panelCard.Size = new Size(768, 418);
            panelCard.TabIndex = 0;
            // 
            // actionsPanel
            // 
            actionsPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            actionsPanel.BackColor = Color.Transparent;
            actionsPanel.Controls.Add(btnSave);
            actionsPanel.Controls.Add(btnCancel);
            actionsPanel.FlowDirection = FlowDirection.RightToLeft;
            actionsPanel.Location = new Point(461, 345);
            actionsPanel.Name = "actionsPanel";
            actionsPanel.Size = new Size(264, 40);
            actionsPanel.TabIndex = 6;
            actionsPanel.WrapContents = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(52, 120, 246);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(171, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 32);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.ForeColor = Color.FromArgb(17, 24, 39);
            btnCancel.Location = new Point(75, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 32);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // tableFields
            // 
            tableFields.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableFields.ColumnCount = 2;
            tableFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tableFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68F));
            tableFields.Controls.Add(lableDescription, 0, 3);
            tableFields.Controls.Add(lableAmount, 0, 0);
            tableFields.Controls.Add(numAmount, 1, 0);
            tableFields.Controls.Add(lableDate, 0, 1);
            tableFields.Controls.Add(ExpenseDate, 1, 1);
            tableFields.Controls.Add(lableCategory, 0, 2);
            tableFields.Controls.Add(comBoxCategory, 1, 2);
            tableFields.Controls.Add(txtDescription, 1, 3);
            tableFields.Location = new Point(24, 72);
            tableFields.Name = "tableFields";
            tableFields.RowCount = 4;
            tableFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            tableFields.Size = new Size(706, 264);
            tableFields.TabIndex = 1;
            // 
            // lblDescription
            // 
            lableDescription.AutoSize = true;
            lableDescription.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lableDescription.ForeColor = Color.FromArgb(17, 24, 39);
            lableDescription.Location = new Point(3, 180);
            lableDescription.Margin = new Padding(3, 12, 3, 0);
            lableDescription.Name = "lblDescription";
            lableDescription.Size = new Size(129, 17);
            lableDescription.TabIndex = 13;
            lableDescription.Text = "Description / Notes";
            lableDescription.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblAmount
            // 
            lableAmount.Anchor = AnchorStyles.Left;
            lableAmount.AutoSize = true;
            lableAmount.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lableAmount.ForeColor = Color.FromArgb(17, 24, 39);
            lableAmount.Location = new Point(3, 19);
            lableAmount.Name = "lblAmount";
            lableAmount.Size = new Size(94, 17);
            lableAmount.TabIndex = 8;
            lableAmount.Text = "Amount (SEK)";
            // 
            // numAmount
            // 
            numAmount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numAmount.BackColor = Color.White;
            numAmount.BorderStyle = BorderStyle.FixedSingle;
            numAmount.DecimalPlaces = 2;
            numAmount.Font = new Font("Segoe UI", 9.5F);
            numAmount.Location = new Point(233, 16);
            numAmount.Margin = new Padding(8);
            numAmount.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(465, 24);
            numAmount.TabIndex = 0;
            numAmount.ThousandsSeparator = true;
            // 
            // lblDate
            // 
            lableDate.Anchor = AnchorStyles.Left;
            lableDate.AutoSize = true;
            lableDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lableDate.ForeColor = Color.FromArgb(17, 24, 39);
            lableDate.Location = new Point(3, 75);
            lableDate.Name = "lblDate";
            lableDate.Size = new Size(37, 17);
            lableDate.TabIndex = 9;
            lableDate.Text = "Date";
            // 
            // dtpDate
            // 
            ExpenseDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ExpenseDate.CalendarForeColor = Color.Black;
            ExpenseDate.CalendarMonthBackground = Color.White;
            ExpenseDate.CalendarTitleBackColor = Color.White;
            ExpenseDate.CalendarTitleForeColor = Color.Black;
            ExpenseDate.Font = new Font("Segoe UI", 9.5F);
            ExpenseDate.Location = new Point(233, 72);
            ExpenseDate.Margin = new Padding(8);
            ExpenseDate.Name = "dtpDate";
            ExpenseDate.Size = new Size(465, 24);
            ExpenseDate.TabIndex = 1;
            // 
            // lblCategory
            // 
            lableCategory.Anchor = AnchorStyles.Left;
            lableCategory.AutoSize = true;
            lableCategory.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lableCategory.ForeColor = Color.FromArgb(17, 24, 39);
            lableCategory.Location = new Point(3, 131);
            lableCategory.Name = "lblCategory";
            lableCategory.Size = new Size(64, 17);
            lableCategory.TabIndex = 11;
            lableCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            comBoxCategory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxCategory.Font = new Font("Segoe UI", 9.5F);
            comBoxCategory.FormattingEnabled = true;
            comBoxCategory.Location = new Point(233, 127);
            comBoxCategory.Margin = new Padding(8);
            comBoxCategory.Name = "cmbCategory";
            comBoxCategory.Size = new Size(465, 25);
            comBoxCategory.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Dock = DockStyle.Fill;
            txtDescription.Font = new Font("Segoe UI", 9.5F);
            txtDescription.Location = new Point(233, 176);
            txtDescription.Margin = new Padding(8);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Add a description";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(465, 80);
            txtDescription.TabIndex = 3;
            // 
            // lblTitle
            // 
            lableTitle.AutoSize = true;
            lableTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lableTitle.ForeColor = Color.FromArgb(17, 24, 39);
            lableTitle.Location = new Point(24, 24);
            lableTitle.Name = "lblTitle";
            lableTitle.Size = new Size(168, 30);
            lableTitle.TabIndex = 6;
            lableTitle.Text = "Expense Details";
            // 
            // EditExpenseForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            CancelButton = btnCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(panelCard);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditExpenseForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add/Edit Expenses";
            Load += EditExpenseForm_Load;
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            actionsPanel.ResumeLayout(false);
            tableFields.ResumeLayout(false);
            tableFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCard;
        private Label lableTitle;
        private Label lableAmount;
        private NumericUpDown numAmount;
        private DateTimePicker ExpenseDate;
        private Label lableDate;
        private ComboBox comBoxCategory;
        private Label lableCategory;
        private TextBox txtDescription;
        private Label lableDescription;
        private Button btnSave;
        private Button btnCancel;
        private FlowLayoutPanel actionsPanel;
        private TableLayoutPanel tableFields;
    }
}
