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
    public partial class AddIncome : Form
    {
        public AddIncome()
        {
            InitializeComponent();
            GetTotalIncome();
        }

        private void Income_Load(object sender, EventArgs e)
        {

        }

        private void incomeLabel_Click(object sender, EventArgs e)
        {
            Income income = new Income();
            income.Show();
            this.Hide();
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

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lee\Documents\WonderprisesDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void addIncomeBtn_Click(object sender, EventArgs e)
        {
            if (incomeNameTextBox.Text == "" || descriptionTextBox.Text == "" || amountTextBox.Text == "" || categoriesComboBox.SelectedIndex == -1 || descriptionTextBox.Text == "")
            {
                MessageBox.Show("Please fill out all of the information.");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO IncomeTable(IncomeName, IncomeAmount, IncomeCategory, IncomeDate, IncomeDesc, IncomeUser) VALUES(@IncomeName,@IncomeAmount,@IncomeCategory,@IncomeDate,@IncomeDesc,@IncomeUser)", con);
                    command.Parameters.AddWithValue("@IncomeName", incomeNameTextBox.Text);
                    command.Parameters.AddWithValue("@IncomeAmount", amountTextBox.Text);
                    command.Parameters.AddWithValue("@IncomeCategory", categoriesComboBox.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@IncomeDate", dateTimePicker.Value.Date);
                    command.Parameters.AddWithValue("@IncomeDesc", descriptionTextBox.Text);
                    command.Parameters.AddWithValue("@IncomeUser", Login.userName);
                    command.ExecuteNonQuery();
                    MessageBox.Show("New income added!");
                    con.Close();
                    GetTotalIncome();
                    Clear();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void GetTotalIncome()
        {
            try
            {
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT SUM(IncomeAmount) FROM IncomeTable WHERE IncomeUser = '" + Login.userName + "'", con);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                //income = Convert.ToInt32(dataTable.Rows[0][0].ToString());
                totalIncomeAmount.Text = dataTable.Rows[0][0].ToString();
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
            incomeNameTextBox.Text = "";
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
