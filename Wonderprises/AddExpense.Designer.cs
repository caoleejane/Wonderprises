
namespace Wonderprises
{
    partial class AddExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExpense));
            this.expenseDetailsLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.categoriesComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.expenseNameLabel = new System.Windows.Forms.Label();
            this.expenseNameTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.totalExpenseAmount = new System.Windows.Forms.Label();
            this.phpLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Label();
            this.expenseLabel = new System.Windows.Forms.Label();
            this.incomeLabel = new System.Windows.Forms.Label();
            this.dashboardLabel = new System.Windows.Forms.Label();
            this.appTitle = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.addExpenseBtn = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalExpenseLabel = new System.Windows.Forms.Label();
            this.addExpenseLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.NumericUpDown();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // expenseDetailsLabel
            // 
            this.expenseDetailsLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expenseDetailsLabel.Location = new System.Drawing.Point(399, 72);
            this.expenseDetailsLabel.Name = "expenseDetailsLabel";
            this.expenseDetailsLabel.Size = new System.Drawing.Size(135, 18);
            this.expenseDetailsLabel.TabIndex = 38;
            this.expenseDetailsLabel.Text = "EXPENSE DETAILS";
            this.expenseDetailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.Location = new System.Drawing.Point(243, 290);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(119, 18);
            this.dateLabel.TabIndex = 36;
            this.dateLabel.Text = "DATE:";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(243, 310);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 35;
            // 
            // categoriesLabel
            // 
            this.categoriesLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoriesLabel.Location = new System.Drawing.Point(470, 290);
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
            this.categoriesComboBox.Items.AddRange(new object[] {
            "Food",
            "Shopping",
            "Medical",
            "Household",
            "Travel",
            "Vehicle",
            "Others"});
            this.categoriesComboBox.Location = new System.Drawing.Point(470, 310);
            this.categoriesComboBox.Name = "categoriesComboBox";
            this.categoriesComboBox.Size = new System.Drawing.Size(200, 24);
            this.categoriesComboBox.TabIndex = 33;
            this.categoriesComboBox.Text = "Choose expense type..";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.Location = new System.Drawing.Point(470, 170);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(119, 18);
            this.descriptionLabel.TabIndex = 31;
            this.descriptionLabel.Text = "DESCRIPTION:";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionTextBox.Location = new System.Drawing.Point(470, 190);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 81);
            this.descriptionTextBox.TabIndex = 32;
            // 
            // amountLabel
            // 
            this.amountLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountLabel.Location = new System.Drawing.Point(243, 230);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(119, 18);
            this.amountLabel.TabIndex = 29;
            this.amountLabel.Text = "AMOUNT:";
            this.amountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // expenseNameLabel
            // 
            this.expenseNameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expenseNameLabel.Location = new System.Drawing.Point(243, 170);
            this.expenseNameLabel.Name = "expenseNameLabel";
            this.expenseNameLabel.Size = new System.Drawing.Size(119, 18);
            this.expenseNameLabel.TabIndex = 23;
            this.expenseNameLabel.Text = "EXPENSE NAME:";
            this.expenseNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // expenseNameTextBox
            // 
            this.expenseNameTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expenseNameTextBox.Location = new System.Drawing.Point(243, 190);
            this.expenseNameTextBox.Name = "expenseNameTextBox";
            this.expenseNameTextBox.Size = new System.Drawing.Size(200, 21);
            this.expenseNameTextBox.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.totalExpenseAmount);
            this.panel3.Controls.Add(this.phpLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(227, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 55);
            this.panel3.TabIndex = 0;
            // 
            // totalExpenseAmount
            // 
            this.totalExpenseAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalExpenseAmount.ForeColor = System.Drawing.Color.Crimson;
            this.totalExpenseAmount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.totalExpenseAmount.Location = new System.Drawing.Point(64, 20);
            this.totalExpenseAmount.Name = "totalExpenseAmount";
            this.totalExpenseAmount.Size = new System.Drawing.Size(140, 18);
            this.totalExpenseAmount.TabIndex = 7;
            this.totalExpenseAmount.Text = "1920843";
            this.totalExpenseAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // addExpenseBtn
            // 
            this.addExpenseBtn.BackColor = System.Drawing.Color.Crimson;
            this.addExpenseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addExpenseBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addExpenseBtn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.addExpenseBtn.Location = new System.Drawing.Point(401, 372);
            this.addExpenseBtn.Name = "addExpenseBtn";
            this.addExpenseBtn.Size = new System.Drawing.Size(123, 30);
            this.addExpenseBtn.TabIndex = 37;
            this.addExpenseBtn.Text = "ADD";
            this.addExpenseBtn.UseVisualStyleBackColor = false;
            this.addExpenseBtn.Click += new System.EventHandler(this.addExpenseBtn_Click);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.totalExpenseLabel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(239, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 55);
            this.panel2.TabIndex = 27;
            // 
            // totalExpenseLabel
            // 
            this.totalExpenseLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalExpenseLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.totalExpenseLabel.Location = new System.Drawing.Point(20, 20);
            this.totalExpenseLabel.Name = "totalExpenseLabel";
            this.totalExpenseLabel.Size = new System.Drawing.Size(119, 18);
            this.totalExpenseLabel.TabIndex = 6;
            this.totalExpenseLabel.Text = "TOTAL EXPENSE:";
            this.totalExpenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addExpenseLabel
            // 
            this.addExpenseLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addExpenseLabel.Location = new System.Drawing.Point(239, 29);
            this.addExpenseLabel.Name = "addExpenseLabel";
            this.addExpenseLabel.Size = new System.Drawing.Size(119, 18);
            this.addExpenseLabel.TabIndex = 26;
            this.addExpenseLabel.Text = "ADD EXPENSE";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountTextBox.Location = new System.Drawing.Point(243, 250);
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
            this.amountTextBox.TabIndex = 39;
            this.amountTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.expenseDetailsLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.categoriesLabel);
            this.Controls.Add(this.categoriesComboBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.expenseNameLabel);
            this.Controls.Add(this.expenseNameTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addExpenseBtn);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.addExpenseLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddExpense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddExpense";
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.amountTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label expenseDetailsLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label categoriesLabel;
        private System.Windows.Forms.ComboBox categoriesComboBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label expenseNameLabel;
        private System.Windows.Forms.TextBox expenseNameTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label totalExpenseAmount;
        private System.Windows.Forms.Label phpLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label logout;
        private System.Windows.Forms.Label expenseLabel;
        private System.Windows.Forms.Label incomeLabel;
        private System.Windows.Forms.Label dashboardLabel;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Button addExpenseBtn;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label totalExpenseLabel;
        private System.Windows.Forms.Label addExpenseLabel;
        private System.Windows.Forms.NumericUpDown amountTextBox;
    }
}