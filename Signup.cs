using Invenntory_Management_System.Models.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invenntory_Management_System
{
    public partial class Signup : Form
    {
        private InventoryDataAccess dataAccess;

        public Signup()
        {
            InitializeComponent();
            dataAccess = new InventoryDataAccess();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstname.Text;
            string lastName = txtLastname.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;
            string contact = txtContact.Text;

            if (ValidateInputs(firstName, lastName, username, password, email, contact))
            {
                try
                {
                    dataAccess.AddUser(firstName, lastName, username, password, email, contact);
                    MessageBox.Show("Signup Successful!");
                    this.Hide();
                    Login loginForm = new Login();
                    loginForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInputs(string firstName, string lastName, string username, string password, string email, string contact)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(contact))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidContact(contact))
            {
                MessageBox.Show("Invalid contact number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            // Simple email validation
            return Regex.IsMatch(email,
                @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        }

        private bool IsValidContact(string contact)
        {
            // Simple contact number validation (10 digits)
            return Regex.IsMatch(contact, @"^\d{10}$");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
