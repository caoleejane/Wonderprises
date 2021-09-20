
namespace Wonderprises
{
    partial class AddIncome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIncome));
            this.totalIncomeLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.totalIncomeAmount = new System.Windows.Forms.Label();
            this.phpLabel = new System.Windows.Forms.Label();
            this.addIncomeLabel = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Label();
            this.expenseLabel = new System.Windows.Forms.Label();
            this.incomeLabel = new System.Windows.Forms.Label();
            this.dashboardLabel = new System.Windows.Forms.Label();
            this.appTitle = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.incomeNameTextBox = new System.Windows.Forms.TextBox();
            this.incomeNameLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.categoriesComboBox = new System.Windows.Forms.ComboBox();
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.addIncomeBtn = new System.Windows.Forms.Button();
            this.incomeDetailsLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // totalIncomeLabel
            // 
            this.totalIncomeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalIncomeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.totalIncomeLabel.Location = new System.Drawing.Point(20, 20);
            this.totalIncomeLabel.Name = "totalIncomeLabel";
            this.totalIncomeLabel.Size = new System.Drawing.Size(119, 18);
            this.totalIncomeLabel.TabIndex = 6;
            this.totalIncomeLabel.Text = "TOTAL INCOME:";
            this.totalIncomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeButton
            // 
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(657, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(35, 35);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 9;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.totalIncomeLabel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(236, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 55);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.totalIncomeAmount);
            this.panel3.Controls.Add(this.phpLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(227, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 55);
            this.panel3.TabIndex = 0;
            // 
            // totalIncomeAmount
            // 
            this.totalIncomeAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalIncomeAmount.ForeColor = System.Drawing.Color.DarkGreen;
            this.totalIncomeAmount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.totalIncomeAmount.Location = new System.Drawing.Point(64, 20);
            this.totalIncomeAmount.Name = "totalIncomeAmount";
            this.totalIncomeAmount.Size = new System.Drawing.Size(140, 18);
            this.totalIncomeAmount.TabIndex = 7;
            this.totalIncomeAmount.Text = "0";
            this.totalIncomeAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phpLabel
            // 
            this.phpLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phpLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.phpLabel.Location = new System.Drawing.Point(18, 20);
            this.phpLabel.Name = "phpLabel";
            this.phpLabel.Size = new System.Drawing.Size(40, 18);
            this.phpLabel.TabIndex = 7;
            this.phpLabel.Text = "PHP:";
            this.phpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addIncomeLabel
            // 
            this.addIncomeLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addIncomeLabel.Location = new System.Drawing.Point(236, 29);
            this.addIncomeLabel.Name = "addIncomeLabel";
            this.addIncomeLabel.Size = new System.Drawing.Size(119, 18);
            this.addIncomeLabel.TabIndex = 10;
            this.addIncomeLabel.Text = "ADD INCOME";
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
            this.panel1.TabIndex = 8;
            // 
            // incomeNameTextBox
            // 
            this.incomeNameTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incomeNameTextBox.Location = new System.Drawing.Point(240, 190);
            this.incomeNameTextBox.Name = "incomeNameTextBox";
            this.incomeNameTextBox.Size = new System.Drawing.Size(200, 21);
            this.incomeNameTextBox.TabIndex = 12;
            // 
            // incomeNameLabel
            // 
            this.incomeNameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incomeNameLabel.Location = new System.Drawing.Point(240, 170);
            this.incomeNameLabel.Name = "incomeNameLabel";
            this.incomeNameLabel.Size = new System.Drawing.Size(119, 18);
            this.incomeNameLabel.TabIndex = 7;
            this.incomeNameLabel.Text = "INCOME NAME:";
            this.incomeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // amountLabel
            // 
            this.amountLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountLabel.Location = new System.Drawing.Point(240, 230);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(119, 18);
            this.amountLabel.TabIndex = 13;
            this.amountLabel.Text = "AMOUNT:";
            this.amountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.Location = new System.Drawing.Point(467, 170);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(119, 18);
            this.descriptionLabel.TabIndex = 15;
            this.descriptionLabel.Text = "DESCRIPTION:";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionTextBox.Location = new System.Drawing.Point(467, 190);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 81);
            this.descriptionTextBox.TabIndex = 16;
            // 
            // categoriesComboBox
            // 
            this.categoriesComboBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoriesComboBox.FormattingEnabled = true;
            this.categoriesComboBox.Items.AddRange(new object[] {
            "Salary",
            "Business",
            "Others"});
            this.categoriesComboBox.Location = new System.Drawing.Point(467, 310);
            this.categoriesComboBox.Name = "categoriesComboBox";
            this.categoriesComboBox.Size = new System.Drawing.Size(200, 24);
            this.categoriesComboBox.TabIndex = 17;
            this.categoriesComboBox.Text = "Choose income type..";
            // 
            // categoriesLabel
            // 
            this.categoriesLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoriesLabel.Location = new System.Drawing.Point(467, 290);
            this.categoriesLabel.Name = "categoriesLabel";
            this.categoriesLabel.Size = new System.Drawing.Size(119, 18);
            this.categoriesLabel.TabIndex = 18;
            this.categoriesLabel.Text = "CATEGORIES:";
            this.categoriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(240, 310);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 19;
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.Location = new System.Drawing.Point(240, 290);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(119, 18);
            this.dateLabel.TabIndex = 20;
            this.dateLabel.Text = "DATE:";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addIncomeBtn
            // 
            this.addIncomeBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.addIncomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addIncomeBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addIncomeBtn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.addIncomeBtn.Location = new System.Drawing.Point(398, 372);
            this.addIncomeBtn.Name = "addIncomeBtn";
            this.addIncomeBtn.Size = new System.Drawing.Size(123, 30);
            this.addIncomeBtn.TabIndex = 21;
            this.addIncomeBtn.Text = "ADD";
            this.addIncomeBtn.UseVisualStyleBackColor = false;
            this.addIncomeBtn.Click += new System.EventHandler(this.addIncomeBtn_Click);
            // 
            // incomeDetailsLabel
            // 
            this.incomeDetailsLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incomeDetailsLabel.Location = new System.Drawing.Point(396, 72);
            this.incomeDetailsLabel.Name = "incomeDetailsLabel";
            this.incomeDetailsLabel.Size = new System.Drawing.Size(135, 18);
            this.incomeDetailsLabel.TabIndex = 22;
            this.incomeDetailsLabel.Text = "INCOME DETAILS";
            this.incomeDetailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountTextBox.Location = new System.Drawing.Point(241, 250);
            this.amountTextBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.amountTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(200, 22);
            this.amountTextBox.TabIndex = 23;
            this.amountTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.incomeDetailsLabel);
            this.Controls.Add(this.addIncomeBtn);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.categoriesLabel);
            this.Controls.Add(this.categoriesComboBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.incomeNameLabel);
            this.Controls.Add(this.incomeNameTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.addIncomeLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddIncome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Income";
            this.Load += new System.EventHandler(this.Income_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label totalIncomeLabel;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label addIncomeLabel;
        private System.Windows.Forms.Label logout;
        private System.Windows.Forms.Label expenseLabel;
        private System.Windows.Forms.Label incomeLabel;
        private System.Windows.Forms.Label dashboardLabel;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label totalIncomeAmount;
        private System.Windows.Forms.Label phpLabel;
        private System.Windows.Forms.TextBox incomeNameTextBox;
        private System.Windows.Forms.Label incomeNameLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox categoriesComboBox;
        private System.Windows.Forms.Label categoriesLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button addIncomeBtn;
        private System.Windows.Forms.Label incomeDetailsLabel;
        private System.Windows.Forms.NumericUpDown amountTextBox;
    }
}