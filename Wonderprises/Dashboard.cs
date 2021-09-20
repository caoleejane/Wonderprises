using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Wonderprises
{
    public partial class Dashboard : Form
    {

        private int income, expenses;

        public Dashboard()
        {
            InitializeComponent();
            GetTotalIncome();
            GetTotalExpenses();
            GetIncomeTotalTransactions();
            GetExpensesTotalTransactions();
            GetLastExpenseTransDate();
            GetLastIncomeTransDate();
            GetMaxIncome();
            GetMinIncome();
            GetMaxExpense();
            GetMinExpense();
            GetBalance();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void incomeLabel_Click(object sender, EventArgs e)
        {
            Income income = new Income();
            income.Show();
            this.Hide();
        }

        private void expenseLabel_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense();
            expense.Show();
            this.Hide();
        }

        private void dashboardLabel_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lee\Documents\WonderprisesDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        // Dashboard displays
        private void GetTotalIncome()
        {
            try {
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT SUM(IncomeAmount) FROM IncomeTable WHERE IncomeUser = '" + Login.userName + "'", con);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                income = Convert.ToInt32(dataTable.Rows[0][0].ToString());
                totalIncomeAmount.Text = dataTable.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception error){ 
                con.Close();
            }
        }
        private void GetTotalExpenses()
        {
            try {
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT SUM(ExpensesAmount) FROM ExpensesTable WHERE ExpensesUser = '" + Login.userName + "'", con);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                expenses = Convert.ToInt32(dataTable.Rows[0][0].ToString());
                totalExpenseAmount.Text = dataTable.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception error) {
                con.Close();
            }
        }
        private void GetIncomeTotalTransactions()
        {
            try {
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT COUNT(*) FROM IncomeTable WHERE IncomeUser = '" + Login.userName + "'", con);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                incomeTotalTrans.Text = dataTable.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception error){
                con.Close();
            }
        }
        private void GetExpensesTotalTransactions()
        {
            try {
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT COUNT(*) FROM ExpensesTable WHERE ExpensesUser = '" + Login.userName + "'", con);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                expenseTotalTrans.Text = dataTable.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception error){
                con.Close();
            }
        }
        private void GetLastExpenseTransDate()
        {
            try {
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT MAX(ExpensesDate) FROM ExpensesTable WHERE ExpensesUser = '" + Login.userName + "'", con);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                lastExpenseTransDate.Text = dataTable.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception error) {
                con.Close();
            }
        }
        private void GetLastIncomeTransDate()
        {
            try {
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT MAX(IncomeDate) FROM IncomeTable WHERE IncomeUser = '" + Login.userName + "'", con);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                lastIncomeTransDate.Text = dataTable.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception error) {
                con.Close();
            }
        }
        private void GetMaxIncome()
        {
            try {
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT MAX(IncomeAmount) FROM IncomeTable WHERE IncomeUser = '" + Login.userName + "'", con);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                maxIncomeAmount.Text = dataTable.Rows[0][0].ToString();

                // Getting best category
                SqlDataAdapter dataAdapter2 = new SqlDataAdapter("SELECT IncomeCategory FROM IncomeTable WHERE IncomeAmount = '" + maxIncomeAmount.Text + "'", con);
                DataTable dataTable2 = new DataTable();
                dataAdapter2.Fill(dataTable2);
                bestIncomeText.Text = dataTable2.Rows[0][0].ToString();

                con.Close();
            }
            catch (Exception error){
                con.Close();
            }
        }
        private void GetMinIncome()
        {
            try {
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT MIN(IncomeAmount) FROM IncomeTable WHERE IncomeUser = '" + Login.userName + "'", con);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                minIncomeAmount.Text = dataTable.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception error) {
                con.Close();
            }
        }
        private void GetMaxExpense()
        {
            try {
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT MAX(ExpensesAmount) FROM ExpensesTable WHERE ExpensesUser = '" + Login.userName + "'", con);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                maxExpenseAmount.Text = dataTable.Rows[0][0].ToString();

                // Getting best category
                SqlDataAdapter dataAdapter2 = new SqlDataAdapter("SELECT ExpensesCategory FROM ExpensesTable WHERE ExpensesAmount = '" + maxExpenseAmount.Text + "'", con);
                DataTable dataTable2 = new DataTable();
                dataAdapter2.Fill(dataTable2);
                bestExpenseText.Text = dataTable2.Rows[0][0].ToString();

                con.Close();
            }
            catch (Exception error){
                con.Close();
            }
        }
        private void GetMinExpense()
        {
            try {
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT MIN(ExpensesAmount) FROM ExpensesTable WHERE ExpensesUser = '" + Login.userName + "'", con);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                minExpenseAmount.Text = dataTable.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception error){
                con.Close();
            }
        }

        private void logoutLabel_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();
        }

        private void GetBalance()
        {
            double balance = income - expenses;
            balanceAmount.Text = Convert.ToString(balance);
        }
    }
}
