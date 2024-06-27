using Invenntory_Management_System.Models.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invenntory_Management_System
{
    public partial class InventoryItem : Form
    {
        private InventoryDataAccess dataAccess;

        public InventoryItem()
        {
            InitializeComponent();
            dataAccess = new InventoryDataAccess();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(textBox1.Text, out int productId) ||
                !decimal.TryParse(textBox3.Text, out decimal price) ||
                !int.TryParse(textBox4.Text, out int quantity))
            {
                MessageBox.Show("Invalid input format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string productName = textBox2.Text;

            Product newProduct = new Product
            {
                ProductId = productId,
                ProductName = productName,
                Price = price,
                Quantity = quantity
            };
            try
            {
                dataAccess.AddProduct(newProduct, dataGridView1);
                MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int productId) ||
       string.IsNullOrWhiteSpace(textBox2.Text) ||
       !decimal.TryParse(textBox3.Text, out decimal price) ||
       !int.TryParse(textBox4.Text, out int quantity))
            {
                MessageBox.Show("Invalid input format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string productName = textBox2.Text;

            Product updatedProduct = new Product
            {
                ProductId = productId,
                ProductName = productName,
                Price = price,
                Quantity = quantity
            };

            try
            {
                dataAccess.UpdateProduct(updatedProduct, dataGridView1);
                MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int productId))
            {
                MessageBox.Show("Invalid Product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                dataAccess.DeleteProduct(productId, dataGridView1);
                MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            GetInvoice inv = new GetInvoice();
            inv.Show();
        }

        private void btnDisplayProd_Click(object sender, EventArgs e)
        {
            try
            {
                dataAccess.DisplayAllProducts(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
