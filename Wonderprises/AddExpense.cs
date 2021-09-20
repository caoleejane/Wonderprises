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
    public partial class AddExpense : Form
    {
        public AddExpense()
        {
            InitializeComponent();
            GetTotalExpenses();
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

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lee\Documents\WonderprisesDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void addExpenseBtn_Click(object sender, EventArgs e)
        {
            if (expenseNameTextBox.Text == "" || descriptionTextBox.Text == "" || amountTextBox.Text == "" || categoriesComboBox.SelectedIndex == -1 || descriptionTextBox.Text == "")
            {
                MessageBox.Show("Please fill out all of the information.");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO ExpensesTable(ExpensesName, ExpensesAmount, ExpensesCategory, ExpensesDate, ExpensesDesc, ExpensesUser) VALUES(@ExpenseName,@ExpenseAmount,@ExpenseCategory,@ExpenseDate,@ExpenseDesc,@ExpenseUser)", con);
                    command.Parameters.AddWithValue("@ExpenseName", expenseNameTextBox.Text);
                    command.Parameters.AddWithValue("@ExpenseAmount", amountTextBox.Text);
                    command.Parameters.AddWithValue("@ExpenseCategory", categoriesComboBox.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@ExpenseDate", dateTimePicker.Value.Date);
                    command.Parameters.AddWithValue("@ExpenseDesc", descriptionTextBox.Text);
                    command.Parameters.AddWithValue("@ExpenseUser", Login.userName);
                    command.ExecuteNonQuery();
                    MessageBox.Show("New expense added!");
                    con.Close();
                    GetTotalExpenses();
                    Clear();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void GetTotalExpenses()
        {
            try
            {
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT SUM(ExpensesAmount) FROM ExpensesTable WHERE ExpensesUser = '" + Login.userName + "'", con);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                //expenses = Convert.ToInt32(dataTable.Rows[0][0].ToString());
                totalExpenseAmount.Text = dataTable.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception error)
            {
                con.Close();
            }
        }

        // Clears fields after user creates account
        private void Clear()
        {
            expenseNameTextBox.Text = "";
            amountTextBox.Text = "";
            categoriesComboBox.SelectedIndex = -1;
            dateTimePicker.Text = "";
            descriptionTextBox.Text = "";
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
