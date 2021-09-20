
namespace Wonderprises
{
    partial class Income
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Income));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.incomeDetailsLabel = new System.Windows.Forms.Label();
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.categoriesComboBox = new System.Windows.Forms.ComboBox();
            this.incomeNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Label();
            this.expenseLabel = new System.Windows.Forms.Label();
            this.incomeLabel = new System.Windows.Forms.Label();
            this.dashboardLabel = new System.Windows.Forms.Label();
            this.appTitle = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.incomeLabel2 = new System.Windows.Forms.Label();
            this.incomeNameTextBox = new System.Windows.Forms.TextBox();
            this.incomeGridView = new System.Windows.Forms.DataGridView();
            this.addIncomeBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // incomeDetailsLabel
            // 
            this.incomeDetailsLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incomeDetailsLabel.Location = new System.Drawing.Point(399, 72);
            this.incomeDetailsLabel.Name = "incomeDetailsLabel";
            this.incomeDetailsLabel.Size = new System.Drawing.Size(135, 18);
            this.incomeDetailsLabel.TabIndex = 38;
            this.incomeDetailsLabel.Text = "INCOME DETAILS";
            this.incomeDetailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoriesLabel
            // 
            this.categoriesLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoriesLabel.Location = new System.Drawing.Point(493, 93);
            this.categoriesLabel.Name = "categoriesLabel";
            this.categoriesLabel.Size = new System.Drawing.Size(119, 18);
            this.categoriesLabel.TabIndex = 34;
            this.categoriesLabel.Text = "CATEGORIES:";
            this.categoriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // categoriesComboBox
            // 
            this.categoriesComboBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoriesComboBox.FormattingEnabled = true;
            this.categoriesComboBox.Location = new System.Drawing.Point(493, 112);
            this.categoriesComboBox.Name = "categoriesComboBox";
            this.categoriesComboBox.Size = new System.Drawing.Size(200, 24);
            this.categoriesComboBox.TabIndex = 33;
            // 
            // incomeNameLabel
            // 
            this.incomeNameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incomeNameLabel.Location = new System.Drawing.Point(246, 93);
            this.incomeNameLabel.Name = "incomeNameLabel";
            this.incomeNameLabel.Size = new System.Drawing.Size(119, 18);
            this.incomeNameLabel.TabIndex = 23;
            this.incomeNameLabel.Text = "INCOME NAME:";
            this.incomeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.panel1.TabIndex = 24;
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
            this.incomeLabel.ForeColor = System.Drawing.Color.SandyBrown;
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
            // closeButton
            // 
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(657, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(35, 35);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 25;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // incomeLabel2
            // 
            this.incomeLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incomeLabel2.Location = new System.Drawing.Point(239, 29);
            this.incomeLabel2.Name = "incomeLabel2";
            this.incomeLabel2.Size = new System.Drawing.Size(119, 18);
            this.incomeLabel2.TabIndex = 26;
            this.incomeLabel2.Text = "INCOME";
            // 
            // incomeNameTextBox
            // 
            this.incomeNameTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incomeNameTextBox.Location = new System.Drawing.Point(246, 114);
            this.incomeNameTextBox.Name = "incomeNameTextBox";
            this.incomeNameTextBox.Size = new System.Drawing.Size(200, 21);
            this.incomeNameTextBox.TabIndex = 28;
            // 
            // incomeGridView
            // 
            this.incomeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.incomeGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.incomeGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.incomeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incomeGridView.GridColor = System.Drawing.Color.White;
            this.incomeGridView.Location = new System.Drawing.Point(239, 151);
            this.incomeGridView.Name = "incomeGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.incomeGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.incomeGridView.RowHeadersVisible = false;
            this.incomeGridView.RowTemplate.Height = 25;
            this.incomeGridView.Size = new System.Drawing.Size(454, 257);
            this.incomeGridView.TabIndex = 39;
            // 
            // addIncomeBtn
            // 
            this.addIncomeBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.addIncomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addIncomeBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addIncomeBtn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.addIncomeBtn.Location = new System.Drawing.Point(239, 50);
            this.addIncomeBtn.Name = "addIncomeBtn";
            this.addIncomeBtn.Size = new System.Drawing.Size(123, 30);
            this.addIncomeBtn.TabIndex = 40;
            this.addIncomeBtn.Text = "ADD";
            this.addIncomeBtn.UseVisualStyleBackColor = false;
            this.addIncomeBtn.Click += new System.EventHandler(this.addIncomeBtn_Click);
            // 
            // Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.addIncomeBtn);
            this.Controls.Add(this.incomeGridView);
            this.Controls.Add(this.incomeDetailsLabel);
            this.Controls.Add(this.categoriesLabel);
            this.Controls.Add(this.categoriesComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.incomeNameTextBox);
            this.Controls.Add(this.incomeLabel2);
            this.Controls.Add(this.incomeNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Income";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Income";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label incomeDetailsLabel;
        private System.Windows.Forms.Label categoriesLabel;
        private System.Windows.Forms.ComboBox categoriesComboBox;
        private System.Windows.Forms.Label incomeNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label logout;
        private System.Windows.Forms.Label expenseLabel;
        private System.Windows.Forms.Label incomeLabel;
        private System.Windows.Forms.Label dashboardLabel;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label incomeLabel2;
        private System.Windows.Forms.TextBox incomeNameTextBox;
        private System.Windows.Forms.DataGridView incomeGridView;
        private System.Windows.Forms.Button addIncomeBtn;
    }
}