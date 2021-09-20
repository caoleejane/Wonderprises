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
    public partial class Login : Form
    {
        public static string userName;

        public Login()
        {
            InitializeComponent();
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void incomeNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void signUp_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lee\Documents\WonderprisesDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "" || passwordTextBox.Text == "") {
                MessageBox.Show("Please fill out missing field(s)!");
            }
            else {
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT COUNT(*) FROM UserTable WHERE UserName ='" + userNameTextBox.Text + " 'AND UserPassword = '" + passwordTextBox.Text + "'", con);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows[0][0].ToString() == "1")
                {
                    userName = userNameTextBox.Text;
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong user name or password!");
                    userNameTextBox.Text = "";
                    passwordTextBox.Text = "";
                }
                con.Close();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
