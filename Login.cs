using Invenntory_Management_System.Models.DataLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Invenntory_Management_System
{
    public partial class Login : Form
    {
        private InventoryDataAccess dataAccess;
        public Login()
        {
            InitializeComponent();
            dataAccess = new InventoryDataAccess();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;

            try
            {
                bool isValidUser = dataAccess.ValidateUser(username, password);

                if (isValidUser)
                {
                    MessageBox.Show("Login successful!");
                    this.Hide();
                    InventoryItem item = new InventoryItem();
                    item.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error logging in: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
        }
    }
}
