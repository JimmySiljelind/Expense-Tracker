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
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            SuspendLayout();
            // 
            // dgvExpenses
            // 
            dgvExpenses.AllowUserToOrderColumns = true;
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenses.Dock = DockStyle.Fill;
            dgvExpenses.Location = new Point(0, 0);
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.Size = new Size(800, 450);
            dgvExpenses.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(12, 9);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(45, 15);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total: 0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotal);
            Controls.Add(dgvExpenses);
            Name = "MainForm";
            Text = "Expense Tracker";
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dgvExpenses;
        private Label lblTotal;
    }
}
