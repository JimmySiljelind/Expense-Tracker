namespace Expense_Tracker
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvExpenses = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lblTotal = new Label();
            topPanel = new Panel();
            lblHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dgvExpenses
            // 
            dgvExpenses.AllowUserToOrderColumns = true;
            dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenses.Dock = DockStyle.Fill;
            dgvExpenses.Location = new Point(0, 50);
            dgvExpenses.MultiSelect = false;
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.BackgroundColor = Color.White;
            dgvExpenses.BorderStyle = BorderStyle.None;
            dgvExpenses.ReadOnly = true;
            dgvExpenses.RowHeadersVisible = false;
            dgvExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpenses.Size = new Size(800, 400);
            dgvExpenses.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(446, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.BackColor = Color.FromArgb(52, 120, 246);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(527, 15);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.BackColor = Color.FromArgb(34, 185, 126);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(608, 15);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.BackColor = Color.FromArgb(234, 67, 53);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.FromArgb(17, 24, 39);
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.Location = new Point(689, 18);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(45, 15);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total: 0";
            lblTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.FromArgb(17, 24, 39);
            lblHeader.Location = new Point(12, 14);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(117, 21);
            lblHeader.TabIndex = 6;
            lblHeader.Text = "Expense Board";
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(248, 250, 252);
            topPanel.Controls.Add(lblHeader);
            topPanel.Controls.Add(lblTotal);
            topPanel.Controls.Add(btnDelete);
            topPanel.Controls.Add(btnEdit);
            topPanel.Controls.Add(btnAdd);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Padding = new Padding(8, 8, 8, 8);
            topPanel.Size = new Size(800, 50);
            topPanel.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvExpenses);
            Controls.Add(topPanel);
            Name = "MainForm";
            Text = "Expense Tracker";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dgvExpenses;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label lblTotal;
        private Panel topPanel;
        private Label lblHeader;
    }
}
