
namespace Wonderprises
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutLabel = new System.Windows.Forms.Label();
            this.expenseLabel = new System.Windows.Forms.Label();
            this.incomeLabel = new System.Windows.Forms.Label();
            this.dashboardLabel = new System.Windows.Forms.Label();
            this.appTitle = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bestExpenseLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.bestIncomeLabel = new System.Windows.Forms.Label();
            this.minExpenseLabel = new System.Windows.Forms.Label();
            this.maxExpenseLabel = new System.Windows.Forms.Label();
            this.minIncomeLabel = new System.Windows.Forms.Label();
            this.maxIncomeLabel = new System.Windows.Forms.Label();
            this.totalExpense = new System.Windows.Forms.Label();
            this.lastTransactionDateLabel = new System.Windows.Forms.Label();
            this.transactionNumLabel = new System.Windows.Forms.Label();
            this.totalIncomeLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lastExpenseTransDate = new System.Windows.Forms.Label();
            this.expenseTotalTrans = new System.Windows.Forms.Label();
            this.bestExpenseText = new System.Windows.Forms.Label();
            this.balanceAmount = new System.Windows.Forms.Label();
            this.phpLabel9 = new System.Windows.Forms.Label();
            this.bestIncomeText = new System.Windows.Forms.Label();
            this.minExpenseAmount = new System.Windows.Forms.Label();
            this.phpLabel6 = new System.Windows.Forms.Label();
            this.maxExpenseAmount = new System.Windows.Forms.Label();
            this.phpLabel5 = new System.Windows.Forms.Label();
            this.minIncomeAmount = new System.Windows.Forms.Label();
            this.phpLabel4 = new System.Windows.Forms.Label();
            this.maxIncomeAmount = new System.Windows.Forms.Label();
            this.phpLabel3 = new System.Windows.Forms.Label();
            this.totalExpenseAmount = new System.Windows.Forms.Label();
            this.phpLabel2 = new System.Windows.Forms.Label();
            this.lastIncomeTransDate = new System.Windows.Forms.Label();
            this.incomeTotalTrans = new System.Windows.Forms.Label();
            this.totalIncomeAmount = new System.Windows.Forms.Label();
            this.phpLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.logoutLabel);
            this.panel1.Controls.Add(this.expenseLabel);
            this.panel1.Controls.Add(this.incomeLabel);
            this.panel1.Controls.Add(this.dashboardLabel);
            this.panel1.Controls.Add(this.appTitle);
            this.panel1.Controls.Add(this.icon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 441);
            this.panel1.TabIndex = 0;
            // 
            // logoutLabel
            // 
            this.logoutLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logoutLabel.Location = new System.Drawing.Point(12, 414);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(119, 18);
            this.logoutLabel.TabIndex = 5;
            this.logoutLabel.Text = "LOGOUT";
            this.logoutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutLabel.Click += new System.EventHandler(this.logoutLabel_Click);
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
            this.dashboardLabel.ForeColor = System.Drawing.Color.SandyBrown;
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
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(230, 29);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(119, 18);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "DASHBOARD";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.bestExpenseLabel);
            this.panel2.Controls.Add(this.balanceLabel);
            this.panel2.Controls.Add(this.bestIncomeLabel);
            this.panel2.Controls.Add(this.minExpenseLabel);
            this.panel2.Controls.Add(this.maxExpenseLabel);
            this.panel2.Controls.Add(this.minIncomeLabel);
            this.panel2.Controls.Add(this.maxIncomeLabel);
            this.panel2.Controls.Add(this.totalExpense);
            this.panel2.Controls.Add(this.lastTransactionDateLabel);
            this.panel2.Controls.Add(this.transactionNumLabel);
            this.panel2.Controls.Add(this.totalIncomeLabel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(230, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 315);
            this.panel2.TabIndex = 7;
            // 
            // bestExpenseLabel
            // 
            this.bestExpenseLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bestExpenseLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bestExpenseLabel.Location = new System.Drawing.Point(20, 240);
            this.bestExpenseLabel.Name = "bestExpenseLabel";
            this.bestExpenseLabel.Size = new System.Drawing.Size(201, 18);
            this.bestExpenseLabel.TabIndex = 18;
            this.bestExpenseLabel.Text = "BEST EXPENSE:";
            this.bestExpenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // balanceLabel
            // 
            this.balanceLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balanceLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.balanceLabel.Location = new System.Drawing.Point(20, 280);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(201, 18);
            this.balanceLabel.TabIndex = 17;
            this.balanceLabel.Text = "BALANCE:";
            this.balanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bestIncomeLabel
            // 
            this.bestIncomeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bestIncomeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bestIncomeLabel.Location = new System.Drawing.Point(20, 220);
            this.bestIncomeLabel.Name = "bestIncomeLabel";
            this.bestIncomeLabel.Size = new System.Drawing.Size(201, 18);
            this.bestIncomeLabel.TabIndex = 16;
            this.bestIncomeLabel.Text = "BEST INCOME:";
            this.bestIncomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // minExpenseLabel
            // 
            this.minExpenseLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minExpenseLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minExpenseLabel.Location = new System.Drawing.Point(20, 177);
            this.minExpenseLabel.Name = "minExpenseLabel";
            this.minExpenseLabel.Size = new System.Drawing.Size(201, 18);
            this.minExpenseLabel.TabIndex = 13;
            this.minExpenseLabel.Text = "MINIMUM EXPENSE:";
            this.minExpenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maxExpenseLabel
            // 
            this.maxExpenseLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxExpenseLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maxExpenseLabel.Location = new System.Drawing.Point(20, 157);
            this.maxExpenseLabel.Name = "maxExpenseLabel";
            this.maxExpenseLabel.Size = new System.Drawing.Size(201, 18);
            this.maxExpenseLabel.TabIndex = 12;
            this.maxExpenseLabel.Text = "MAXIMUM EXPENSE:";
            this.maxExpenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // minIncomeLabel
            // 
            this.minIncomeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minIncomeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minIncomeLabel.Location = new System.Drawing.Point(20, 137);
            this.minIncomeLabel.Name = "minIncomeLabel";
            this.minIncomeLabel.Size = new System.Drawing.Size(201, 18);
            this.minIncomeLabel.TabIndex = 11;
            this.minIncomeLabel.Text = "MINIMUM INCOME:";
            this.minIncomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maxIncomeLabel
            // 
            this.maxIncomeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxIncomeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maxIncomeLabel.Location = new System.Drawing.Point(20, 117);
            this.maxIncomeLabel.Name = "maxIncomeLabel";
            this.maxIncomeLabel.Size = new System.Drawing.Size(201, 18);
            this.maxIncomeLabel.TabIndex = 10;
            this.maxIncomeLabel.Text = "MAXIMUM INCOME:";
            this.maxIncomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalExpense
            // 
            this.totalExpense.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalExpense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.totalExpense.Location = new System.Drawing.Point(20, 80);
            this.totalExpense.Name = "totalExpense";
            this.totalExpense.Size = new System.Drawing.Size(119, 18);
            this.totalExpense.TabIndex = 9;
            this.totalExpense.Text = "TOTAL EXPENSE:";
            this.totalExpense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lastTransactionDateLabel
            // 
            this.lastTransactionDateLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastTransactionDateLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lastTransactionDateLabel.Location = new System.Drawing.Point(20, 60);
            this.lastTransactionDateLabel.Name = "lastTransactionDateLabel";
            this.lastTransactionDateLabel.Size = new System.Drawing.Size(201, 18);
            this.lastTransactionDateLabel.TabIndex = 8;
            this.lastTransactionDateLabel.Text = "LAST TRANSACTION DATE:";
            this.lastTransactionDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // transactionNumLabel
            // 
            this.transactionNumLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transactionNumLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactionNumLabel.Location = new System.Drawing.Point(20, 40);
            this.transactionNumLabel.Name = "transactionNumLabel";
            this.transactionNumLabel.Size = new System.Drawing.Size(201, 18);
            this.transactionNumLabel.TabIndex = 7;
            this.transactionNumLabel.Text = "TRANSACTIONS:";
            this.transactionNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.lastExpenseTransDate);
            this.panel3.Controls.Add(this.expenseTotalTrans);
            this.panel3.Controls.Add(this.bestExpenseText);
            this.panel3.Controls.Add(this.balanceAmount);
            this.panel3.Controls.Add(this.phpLabel9);
            this.panel3.Controls.Add(this.bestIncomeText);
            this.panel3.Controls.Add(this.minExpenseAmount);
            this.panel3.Controls.Add(this.phpLabel6);
            this.panel3.Controls.Add(this.maxExpenseAmount);
            this.panel3.Controls.Add(this.phpLabel5);
            this.panel3.Controls.Add(this.minIncomeAmount);
            this.panel3.Controls.Add(this.phpLabel4);
            this.panel3.Controls.Add(this.maxIncomeAmount);
            this.panel3.Controls.Add(this.phpLabel3);
            this.panel3.Controls.Add(this.totalExpenseAmount);
            this.panel3.Controls.Add(this.phpLabel2);
            this.panel3.Controls.Add(this.lastIncomeTransDate);
            this.panel3.Controls.Add(this.incomeTotalTrans);
            this.panel3.Controls.Add(this.totalIncomeAmount);
            this.panel3.Controls.Add(this.phpLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(227, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 315);
            this.panel3.TabIndex = 0;
            // 
            // lastExpenseTransDate
            // 
            this.lastExpenseTransDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastExpenseTransDate.ForeColor = System.Drawing.Color.Crimson;
            this.lastExpenseTransDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lastExpenseTransDate.Location = new System.Drawing.Point(122, 60);
            this.lastExpenseTransDate.Name = "lastExpenseTransDate";
            this.lastExpenseTransDate.Size = new System.Drawing.Size(102, 18);
            this.lastExpenseTransDate.TabIndex = 29;
            this.lastExpenseTransDate.Text = "June 26, 1997";
            this.lastExpenseTransDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // expenseTotalTrans
            // 
            this.expenseTotalTrans.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expenseTotalTrans.ForeColor = System.Drawing.Color.Crimson;
            this.expenseTotalTrans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expenseTotalTrans.Location = new System.Drawing.Point(122, 37);
            this.expenseTotalTrans.Name = "expenseTotalTrans";
            this.expenseTotalTrans.Size = new System.Drawing.Size(102, 18);
            this.expenseTotalTrans.TabIndex = 28;
            this.expenseTotalTrans.Text = "14";
            this.expenseTotalTrans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bestExpenseText
            // 
            this.bestExpenseText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bestExpenseText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bestExpenseText.Location = new System.Drawing.Point(18, 240);
            this.bestExpenseText.Name = "bestExpenseText";
            this.bestExpenseText.Size = new System.Drawing.Size(206, 18);
            this.bestExpenseText.TabIndex = 27;
            this.bestExpenseText.Text = "None";
            this.bestExpenseText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // balanceAmount
            // 
            this.balanceAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balanceAmount.ForeColor = System.Drawing.Color.DarkGreen;
            this.balanceAmount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.balanceAmount.Location = new System.Drawing.Point(64, 280);
            this.balanceAmount.Name = "balanceAmount";
            this.balanceAmount.Size = new System.Drawing.Size(140, 18);
            this.balanceAmount.TabIndex = 26;
            this.balanceAmount.Text = "1920843";
            this.balanceAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phpLabel9
            // 
            this.phpLabel9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phpLabel9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.phpLabel9.Location = new System.Drawing.Point(18, 280);
            this.phpLabel9.Name = "phpLabel9";
            this.phpLabel9.Size = new System.Drawing.Size(40, 18);
            this.phpLabel9.TabIndex = 25;
            this.phpLabel9.Text = "PHP:";
            this.phpLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bestIncomeText
            // 
            this.bestIncomeText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bestIncomeText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bestIncomeText.Location = new System.Drawing.Point(18, 220);
            this.bestIncomeText.Name = "bestIncomeText";
            this.bestIncomeText.Size = new System.Drawing.Size(206, 18);
            this.bestIncomeText.TabIndex = 24;
            this.bestIncomeText.Text = "None";
            this.bestIncomeText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // minExpenseAmount
            // 
            this.minExpenseAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minExpenseAmount.ForeColor = System.Drawing.Color.Crimson;
            this.minExpenseAmount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minExpenseAmount.Location = new System.Drawing.Point(64, 177);
            this.minExpenseAmount.Name = "minExpenseAmount";
            this.minExpenseAmount.Size = new System.Drawing.Size(140, 18);
            this.minExpenseAmount.TabIndex = 19;
            this.minExpenseAmount.Text = "6000";
            this.minExpenseAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phpLabel6
            // 
            this.phpLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phpLabel6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.phpLabel6.Location = new System.Drawing.Point(18, 177);
            this.phpLabel6.Name = "phpLabel6";
            this.phpLabel6.Size = new System.Drawing.Size(40, 18);
            this.phpLabel6.TabIndex = 18;
            this.phpLabel6.Text = "PHP:";
            this.phpLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maxExpenseAmount
            // 
            this.maxExpenseAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxExpenseAmount.ForeColor = System.Drawing.Color.Crimson;
            this.maxExpenseAmount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maxExpenseAmount.Location = new System.Drawing.Point(64, 157);
            this.maxExpenseAmount.Name = "maxExpenseAmount";
            this.maxExpenseAmount.Size = new System.Drawing.Size(140, 18);
            this.maxExpenseAmount.TabIndex = 17;
            this.maxExpenseAmount.Text = "6000";
            this.maxExpenseAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phpLabel5
            // 
            this.phpLabel5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phpLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.phpLabel5.Location = new System.Drawing.Point(18, 157);
            this.phpLabel5.Name = "phpLabel5";
            this.phpLabel5.Size = new System.Drawing.Size(40, 18);
            this.phpLabel5.TabIndex = 16;
            this.phpLabel5.Text = "PHP:";
            this.phpLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // minIncomeAmount
            // 
            this.minIncomeAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minIncomeAmount.ForeColor = System.Drawing.Color.DarkGreen;
            this.minIncomeAmount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minIncomeAmount.Location = new System.Drawing.Point(64, 137);
            this.minIncomeAmount.Name = "minIncomeAmount";
            this.minIncomeAmount.Size = new System.Drawing.Size(140, 18);
            this.minIncomeAmount.TabIndex = 15;
            this.minIncomeAmount.Text = "6000";
            this.minIncomeAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phpLabel4
            // 
            this.phpLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phpLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.phpLabel4.Location = new System.Drawing.Point(18, 137);
            this.phpLabel4.Name = "phpLabel4";
            this.phpLabel4.Size = new System.Drawing.Size(40, 18);
            this.phpLabel4.TabIndex = 14;
            this.phpLabel4.Text = "PHP:";
            this.phpLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maxIncomeAmount
            // 
            this.maxIncomeAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxIncomeAmount.ForeColor = System.Drawing.Color.DarkGreen;
            this.maxIncomeAmount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maxIncomeAmount.Location = new System.Drawing.Point(64, 117);
            this.maxIncomeAmount.Name = "maxIncomeAmount";
            this.maxIncomeAmount.Size = new System.Drawing.Size(140, 18);
            this.maxIncomeAmount.TabIndex = 13;
            this.maxIncomeAmount.Text = "84292";
            this.maxIncomeAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phpLabel3
            // 
            this.phpLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phpLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.phpLabel3.Location = new System.Drawing.Point(18, 117);
            this.phpLabel3.Name = "phpLabel3";
            this.phpLabel3.Size = new System.Drawing.Size(40, 18);
            this.phpLabel3.TabIndex = 12;
            this.phpLabel3.Text = "PHP:";
            this.phpLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalExpenseAmount
            // 
            this.totalExpenseAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalExpenseAmount.ForeColor = System.Drawing.Color.Crimson;
            this.totalExpenseAmount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.totalExpenseAmount.Location = new System.Drawing.Point(64, 80);
            this.totalExpenseAmount.Name = "totalExpenseAmount";
            this.totalExpenseAmount.Size = new System.Drawing.Size(140, 18);
            this.totalExpenseAmount.TabIndex = 10;
            this.totalExpenseAmount.Text = "0";
            this.totalExpenseAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phpLabel2
            // 
            this.phpLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phpLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.phpLabel2.Location = new System.Drawing.Point(18, 80);
            this.phpLabel2.Name = "phpLabel2";
            this.phpLabel2.Size = new System.Drawing.Size(40, 18);
            this.phpLabel2.TabIndex = 11;
            this.phpLabel2.Text = "PHP:";
            this.phpLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lastIncomeTransDate
            // 
            this.lastIncomeTransDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastIncomeTransDate.ForeColor = System.Drawing.Color.DarkGreen;
            this.lastIncomeTransDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lastIncomeTransDate.Location = new System.Drawing.Point(18, 60);
            this.lastIncomeTransDate.Name = "lastIncomeTransDate";
            this.lastIncomeTransDate.Size = new System.Drawing.Size(102, 18);
            this.lastIncomeTransDate.TabIndex = 9;
            this.lastIncomeTransDate.Text = "June 26, 1997";
            this.lastIncomeTransDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // incomeTotalTrans
            // 
            this.incomeTotalTrans.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incomeTotalTrans.ForeColor = System.Drawing.Color.DarkGreen;
            this.incomeTotalTrans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.incomeTotalTrans.Location = new System.Drawing.Point(18, 40);
            this.incomeTotalTrans.Name = "incomeTotalTrans";
            this.incomeTotalTrans.Size = new System.Drawing.Size(102, 18);
            this.incomeTotalTrans.TabIndex = 8;
            this.incomeTotalTrans.Text = "14";
            this.incomeTotalTrans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // closeButton
            // 
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(657, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(35, 35);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 6;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WONDERPRISES";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label expenseLabel;
        private System.Windows.Forms.Label incomeLabel;
        private System.Windows.Forms.Label dashboardLabel;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label totalIncomeLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label totalIncomeAmount;
        private System.Windows.Forms.Label phpLabel;
        private System.Windows.Forms.Label transactionNumLabel;
        private System.Windows.Forms.Label incomeTotalTrans;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label lastTransactionDateLabel;
        private System.Windows.Forms.Label lastIncomeTransDate;
        private System.Windows.Forms.Label totalExpense;
        private System.Windows.Forms.Label totalExpenseAmount;
        private System.Windows.Forms.Label phpLabel2;
        private System.Windows.Forms.Label maxIncomeLabel;
        private System.Windows.Forms.Label maxIncomeAmount;
        private System.Windows.Forms.Label phpLabel3;
        private System.Windows.Forms.Label minIncomeLabel;
        private System.Windows.Forms.Label minIncomeAmount;
        private System.Windows.Forms.Label phpLabel4;
        private System.Windows.Forms.Label minExpenseLabel;
        private System.Windows.Forms.Label maxExpenseLabel;
        private System.Windows.Forms.Label minExpenseAmount;
        private System.Windows.Forms.Label phpLabel6;
        private System.Windows.Forms.Label maxExpenseAmount;
        private System.Windows.Forms.Label phpLabel5;
        private System.Windows.Forms.Label bestIncomeLabel;
        private System.Windows.Forms.Label bestIncomeText;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label balanceAmount;
        private System.Windows.Forms.Label phpLabel9;
        private System.Windows.Forms.Label bestExpenseLabel;
        private System.Windows.Forms.Label bestExpenseText;
        private System.Windows.Forms.Label expenseTotalTrans;
        private System.Windows.Forms.Label lastExpenseTransDate;
        private System.Windows.Forms.Label logoutLabel;
    }
}

