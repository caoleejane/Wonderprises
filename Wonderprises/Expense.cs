using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Wonderprises
{
    public partial class Expense : Form
    {
        public Expense()
        {
            InitializeComponent();
            DisplayExpenses();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lee\Documents\WonderprisesDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplayExpenses()
        {
            try {
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT ExpensesId, ExpensesName, ExpensesCategory, ExpensesDate, ExpensesDesc FROM ExpensesTable WHERE ExpensesUser = '" + Login.userName + "'", con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                expenseGridView.DataSource = dataSet.Tables[0];
                con.Close();
            }
            catch (Exception error) {
                con.Close();
            }
        }

        private void dashboardLabel_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void incomeLabel_Click(object sender, EventArgs e)
        {
            Income income = new Income();
            income.Show();
            this.Hide();
        }

        private void addExpenseBtn_Click(object sender, EventArgs e)
        {
            AddExpense addExpense = new AddExpense();
            addExpense.Show();
            this.Hide();
        }

        private void expenseLabel_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense();
            expense.Show();
            this.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
