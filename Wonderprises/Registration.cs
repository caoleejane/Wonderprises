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
    public partial class Registration : Form
    {

        public Registration()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lee\Documents\WonderprisesDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "" || passwordTextBox.Text == ""){
                MessageBox.Show("Please fill out all of the information.");
            }
            else {
                try {
                    con.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO UserTable(UserName, UserPassword) VALUES(@UName,@UPass)", con);
                    command.Parameters.AddWithValue("@UName", userNameTextBox.Text);
                    command.Parameters.AddWithValue("@UPass", passwordTextBox.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("New account created!");
                    con.Close();
                    Clear();
                }
                catch (Exception error){
                    MessageBox.Show(error.Message);
                }
            }
        }

        // Clears fields after user creates account
        private void Clear()
        {
            userNameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
