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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Invenntory_Management_System
{
    public partial class GetInvoice : Form
    {
        private InventoryDataAccess dataAccess;
        public GetInvoice()
        {
            InitializeComponent();
            dataAccess = new InventoryDataAccess();
        }

        private void btnGetInvoice_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProd.Text, out int productId) ||
        !int.TryParse(txtQuant.Text, out int quantity))
            {
                MessageBox.Show("Invalid input format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                dataAccess.GenerateInvoice(productId, quantity, dgInvoice);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating invoice: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                dataAccess.DisplayAllProducts(dgInvoice);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtProd.Text, out int productId))
            {
                MessageBox.Show("Invalid Product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                dataAccess.SearchProduct(productId, dgInvoice);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying product details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
