using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invenntory_Management_System.Models.DataLayer
{
    internal class InventoryDataAccess
    {
        private string ConnectionString =>
        ConfigurationManager.ConnectionStrings["Inventory"].ConnectionString;

        internal void AddProduct(Product newProduct, DataGridView dataGridView)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "INSERT INTO product (ProductId, ProductName, Price, Quantity) VALUES (@ProductId, @ProductName, @Price, @Quantity)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductId", newProduct.ProductId);
                    command.Parameters.AddWithValue("@ProductName", newProduct.ProductName);
                    command.Parameters.AddWithValue("@Price", newProduct.Price);
                    command.Parameters.AddWithValue("@Quantity", newProduct.Quantity);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            UpdateDataGridView(dataGridView);
        }

        private void UpdateDataGridView(DataGridView dataGridView)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT ProductId, ProductName, Price, Quantity FROM product";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView.DataSource = dataTable;
                }
            }
        }

        internal void DeleteProduct(int productId, DataGridView dataGridView)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "DELETE FROM product WHERE ProductId = @ProductId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductId", productId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            UpdateDataGridView(dataGridView);
        }
        internal void UpdateProduct(Product updatedProduct, DataGridView dataGridView)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "UPDATE product SET ProductName = @ProductName, Price = @Price, Quantity = @Quantity WHERE ProductId = @ProductId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductId", updatedProduct.ProductId);
                    command.Parameters.AddWithValue("@ProductName", updatedProduct.ProductName);
                    command.Parameters.AddWithValue("@Price", updatedProduct.Price);
                    command.Parameters.AddWithValue("@Quantity", updatedProduct.Quantity);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            UpdateDataGridView(dataGridView);
        }

        internal void GenerateInvoice(int productId, int quantity, DataGridView dgInvoice)
{
    using (SqlConnection connection = new SqlConnection(ConnectionString))
    {
        string query = "SELECT ProductName, Price, Quantity FROM product WHERE ProductId = @ProductId";

        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@ProductId", productId);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                int availableQuantity = Convert.ToInt32(reader["Quantity"]);
                
                // Handle possible null values
                string productName = reader["ProductName"] as string ?? "Unknown";
                decimal price = reader["Price"] != DBNull.Value ? Convert.ToDecimal(reader["Price"]) : 0m;

                if (quantity <= availableQuantity && quantity > 0)
                {
                    decimal subtotal = price * quantity;
                    decimal total = subtotal * 1.13m; // Assuming 13% tax rate

                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Product Name");
                    dataTable.Columns.Add("Price");
                    dataTable.Columns.Add("Quantity");
                    dataTable.Columns.Add("Subtotal");
                    dataTable.Columns.Add("Total");

                    dataTable.Rows.Add(productName, price, quantity, subtotal, total);

                    dgInvoice.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Error: Enter correct quantity or product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Product ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


        internal void DisplayAllProducts(DataGridView dgInvoice)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT ProductId, ProductName, Price, Quantity FROM product";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgInvoice.DataSource = dataTable;
                }
            }
        }

        internal void SearchProduct(int productId, DataGridView dgInvoice)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT ProductId, ProductName, Price, Quantity FROM product WHERE ProductId = @ProductId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductId", productId);

                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Product ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dgInvoice.DataSource = dataTable;
                    }
                }
            }
        }

        internal bool ValidateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT COUNT(*) FROM registration WHERE username = @username AND password = @password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    connection.Open();

                    int count = (int)command.ExecuteScalar();

                    return count > 0; // Returns true if user exists with the provided credentials
                }
            }
        }

        internal void AddUser(string firstName, string lastName, string username, string password, string email, string contact)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "INSERT INTO registration (FirstName, LastName, Username, Password, Email, Contact) VALUES (@FirstName, @LastName, @Username, @Password, @Email, @Contact)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Contact", contact);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
