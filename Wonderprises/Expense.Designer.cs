
namespace Wonderprises
{
    partial class Expense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expense));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.expenseDetailsLabel = new System.Windows.Forms.Label();
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.categoriesComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Label();
            this.expenseLabel = new System.Windows.Forms.Label();
            this.incomeLabel = new System.Windows.Forms.Label();
            this.dashboardLabel = new System.Windows.Forms.Label();
            this.appTitle = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.expenseNameLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.incomeNameTextBox = new System.Windows.Forms.TextBox();
            this.incomeLabel2 = new System.Windows.Forms.Label();
            this.addExpenseBtn = new System.Windows.Forms.Button();
            this.expenseGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // expenseDetailsLabel
            // 
            this.expenseDetailsLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expenseDetailsLabel.Location = new System.Drawing.Point(401, 72);
            this.expenseDetailsLabel.Name = "expenseDetailsLabel";
            this.expenseDetailsLabel.Size = new System.Drawing.Size(135, 18);
            this.expenseDetailsLabel.TabIndex = 47;
            this.expenseDetailsLabel.Text = "EXPENSE DETAILS";
            this.expenseDetailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoriesLabel
            // 
            this.categoriesLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoriesLabel.Location = new System.Drawing.Point(495, 93);
            this.categoriesLabel.Name = "categoriesLabel";
            this.categoriesLabel.Size = new System.Drawing.Size(119, 18);
            this.categoriesLabel.TabIndex = 46;
            this.categoriesLabel.Text = "CATEGORIES:";
            this.categoriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // categoriesComboBox
            // 
            this.categoriesComboBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoriesComboBox.FormattingEnabled = true;
            this.categoriesComboBox.Location = new System.Drawing.Point(495, 112);
            this.categoriesComboBox.Name = "categoriesComboBox";
            this.categoriesComboBox.Size = new System.Drawing.Size(200, 24);
            this.categoriesComboBox.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.expenseLabel);
            this.panel1.Controls.Add(this.incomeLabel);
            this.panel1.Controls.Add(this.dashboardLabel);
            this.panel1.Controls.Add(this.appTitle);
            this.panel1.Controls.Add(this.icon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 441);
            this.panel1.TabIndex = 41;
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logout.Location = new System.Drawing.Point(12, 414);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(119, 18);
            this.logout.TabIndex = 5;
            this.logout.Text = "LOG OUT";
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // expenseLabel
            // 
            this.expenseLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.expenseLabel.ForeColor = System.Drawing.Color.SandyBrown;
            this.expenseLabel.Location = new System.Drawing.Point(12, 190);
            this.expenseLabel.Name = "expenseLabel";
            this.expenseLabel.Size = new System.Drawing.Size(119, 18);
            this.expenseLabel.TabIndex = 4;
            this.expenseLabel.Text = "EXPENSE";
            this.expenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expenseLabel.Click += new System.EventHandler(this.expenseLabel_Click);
            // 
            // incomeLabel
            // 
            this.incomeLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.incomeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.incomeLabel.Location = new System.Drawing.Point(12, 160);
            this.incomeLabel.Name = "incomeLabel";
            this.incomeLabel.Size = new System.Drawing.Size(119, 18);
            this.incomeLabel.TabIndex = 3;
            this.incomeLabel.Text = "INCOME";
            this.incomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.incomeLabel.Click += new System.EventHandler(this.incomeLabel_Click);
            // 
            // dashboardLabel
            // 
            this.dashboardLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dashboardLabel.Location = new System.Drawing.Point(12, 130);
            this.dashboardLabel.Name = "dashboardLabel";
            this.dashboardLabel.Size = new System.Drawing.Size(119, 18);
            this.dashboardLabel.TabIndex = 2;
            this.dashboardLabel.Text = "DASHBOARD";
            this.dashboardLabel.Click += new System.EventHandler(this.dashboardLabel_Click);
            // 
            // appTitle
            // 
            this.appTitle.AutoSize = true;
            this.appTitle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.appTitle.Location = new System.Drawing.Point(68, 29);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(119, 18);
            this.appTitle.TabIndex = 1;
            this.appTitle.Text = "WONDERPRISES";
            // 
            // icon
            // 
            this.icon.Image = global::Wonderprises.Properties.Resources.Icon;
            this.icon.Location = new System.Drawing.Point(12, 12);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(50, 50);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 1;
            this.icon.TabStop = false;
            // 
            // expenseNameLabel
            // 
            this.expenseNameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expenseNameLabel.Location = new System.Drawing.Point(248, 93);
            this.expenseNameLabel.Name = "expenseNameLabel";
            this.expenseNameLabel.Size = new System.Drawing.Size(119, 18);
            this.expenseNameLabel.TabIndex = 40;
            this.expenseNameLabel.Text = "EXPENSE NAME:";
            this.expenseNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeButton
            // 
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(657, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(35, 35);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 42;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // incomeNameTextBox
            // 
            this.incomeNameTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incomeNameTextBox.Location = new System.Drawing.Point(248, 114);
            this.incomeNameTextBox.Name = "incomeNameTextBox";
            this.incomeNameTextBox.Size = new System.Drawing.Size(200, 21);
            this.incomeNameTextBox.TabIndex = 44;
            // 
            // incomeLabel2
            // 
            this.incomeLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incomeLabel2.Location = new System.Drawing.Point(241, 29);
            this.incomeLabel2.Name = "incomeLabel2";
            this.incomeLabel2.Size = new System.Drawing.Size(119, 18);
            this.incomeLabel2.TabIndex = 43;
            this.incomeLabel2.Text = "EXPENSE";
            this.incomeLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addExpenseBtn
            // 
            this.addExpenseBtn.BackColor = System.Drawing.Color.Crimson;
            this.addExpenseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addExpenseBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addExpenseBtn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.addExpenseBtn.Location = new System.Drawing.Point(241, 50);
            this.addExpenseBtn.Name = "addExpenseBtn";
            this.addExpenseBtn.Size = new System.Drawing.Size(123, 30);
            this.addExpenseBtn.TabIndex = 49;
            this.addExpenseBtn.Text = "ADD";
            this.addExpenseBtn.UseVisualStyleBackColor = false;
            this.addExpenseBtn.Click += new System.EventHandler(this.addExpenseBtn_Click);
            // 
            // expenseGridView
            // 
            this.expenseGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.expenseGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expenseGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.expenseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expenseGridView.GridColor = System.Drawing.Color.White;
            this.expenseGridView.Location = new System.Drawing.Point(239, 151);
            this.expenseGridView.Name = "expenseGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expenseGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.expenseGridView.RowHeadersVisible = false;
            this.expenseGridView.RowTemplate.Height = 25;
            this.expenseGridView.Size = new System.Drawing.Size(454, 257);
            this.expenseGridView.TabIndex = 50;
            // 
            // Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.expenseGridView);
            this.Controls.Add(this.addExpenseBtn);
            this.Controls.Add(this.expenseDetailsLabel);
            this.Controls.Add(this.categoriesLabel);
            this.Controls.Add(this.categoriesComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.expenseNameLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.incomeNameTextBox);
            this.Controls.Add(this.incomeLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Expense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label expenseDetailsLabel;
        private System.Windows.Forms.Label categoriesLabel;
        private System.Windows.Forms.ComboBox categoriesComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label logout;
        private System.Windows.Forms.Label expenseLabel;
        private System.Windows.Forms.Label incomeLabel;
        private System.Windows.Forms.Label dashboardLabel;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label expenseNameLabel;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.TextBox incomeNameTextBox;
        private System.Windows.Forms.Label incomeLabel2;
        private System.Windows.Forms.Button addExpenseBtn;
        private System.Windows.Forms.DataGridView expenseGridView;
    }
}