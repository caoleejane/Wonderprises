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
    public partial class Income : Form
    {
        public Income()
        {
            InitializeComponent();
            DisplayIncomes();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lee\Documents\WonderprisesDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplayIncomes()
        {
            try
            {
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT IncomeId, IncomeName, IncomeCategory, IncomeDate, IncomeDesc FROM IncomeTable WHERE IncomeUser = '" + Login.userName + "'", con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                incomeGridView.DataSource = dataSet.Tables[0];
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

        private void expenseLabel_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense();
            expense.Show();
            this.Hide();
        }

        private void addIncomeBtn_Click(object sender, EventArgs e)
        {
            AddIncome addIncome = new AddIncome();
            addIncome.Show();
            this.Hide();
        }

        private void incomeLabel_Click(object sender, EventArgs e)
        {
            Income income = new Income();
            income.Show();
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
