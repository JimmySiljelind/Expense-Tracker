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
            lblDescription = new Label();
            lblAmount = new Label();
            numAmount = new NumericUpDown();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            txtDescription = new TextBox();
            lblTitle = new Label();
            panelCard.SuspendLayout();
            actionsPanel.SuspendLayout();
            tableFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // 
            // panelCard
            // 
            panelCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCard.BorderStyle = BorderStyle.None;
            panelCard.Controls.Add(actionsPanel);
            panelCard.Controls.Add(tableFields);
            panelCard.Controls.Add(lblTitle);
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
            tableFields.Controls.Add(lblDescription, 0, 3);
            tableFields.Controls.Add(lblAmount, 0, 0);
            tableFields.Controls.Add(numAmount, 1, 0);
            tableFields.Controls.Add(lblDate, 0, 1);
            tableFields.Controls.Add(dtpDate, 1, 1);
            tableFields.Controls.Add(lblCategory, 0, 2);
            tableFields.Controls.Add(cmbCategory, 1, 2);
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
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDescription.ForeColor = Color.FromArgb(17, 24, 39);
            lblDescription.Location = new Point(3, 180);
            lblDescription.Margin = new Padding(3, 12, 3, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(129, 17);
            lblDescription.TabIndex = 13;
            lblDescription.Text = "Description / Notes";
            lblDescription.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblAmount
            // 
            lblAmount.Anchor = AnchorStyles.Left;
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblAmount.ForeColor = Color.FromArgb(17, 24, 39);
            lblAmount.Location = new Point(3, 19);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(94, 17);
            lblAmount.TabIndex = 8;
            lblAmount.Text = "Amount (SEK)";
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
            lblDate.Anchor = AnchorStyles.Left;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDate.ForeColor = Color.FromArgb(17, 24, 39);
            lblDate.Location = new Point(3, 75);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(37, 17);
            lblDate.TabIndex = 9;
            lblDate.Text = "Date";
            // 
            // dtpDate
            // 
            dtpDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpDate.CalendarForeColor = Color.Black;
            dtpDate.CalendarMonthBackground = Color.White;
            dtpDate.CalendarTitleBackColor = Color.White;
            dtpDate.CalendarTitleForeColor = Color.Black;
            dtpDate.Font = new Font("Segoe UI", 9.5F);
            dtpDate.Location = new Point(233, 72);
            dtpDate.Margin = new Padding(8);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(465, 24);
            dtpDate.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.Anchor = AnchorStyles.Left;
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCategory.ForeColor = Color.FromArgb(17, 24, 39);
            lblCategory.Location = new Point(3, 131);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(64, 17);
            lblCategory.TabIndex = 11;
            lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 9.5F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(233, 127);
            cmbCategory.Margin = new Padding(8);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(465, 25);
            cmbCategory.TabIndex = 2;
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
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(17, 24, 39);
            lblTitle.Location = new Point(24, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(168, 30);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Expense Details";
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
            Text = "Edit Expenses";
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
        private FlowLayoutPanel actionsPanel;
        private TableLayoutPanel tableFields;
    }
}
