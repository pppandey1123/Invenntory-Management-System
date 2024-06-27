namespace Invenntory_Management_System
{
    partial class GetInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtProd = new TextBox();
            txtQuant = new TextBox();
            btnGetInvoice = new Button();
            btnExit = new Button();
            dgInvoice = new DataGridView();
            btnDisplay = new Button();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgInvoice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(435, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 45);
            label1.TabIndex = 0;
            label1.Text = "Invoice";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 89);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 1;
            label2.Text = "Product ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(44, 150);
            label3.Name = "label3";
            label3.Size = new Size(95, 28);
            label3.TabIndex = 2;
            label3.Text = "Quantity";
            // 
            // txtProd
            // 
            txtProd.Location = new Point(184, 89);
            txtProd.Name = "txtProd";
            txtProd.Size = new Size(100, 31);
            txtProd.TabIndex = 3;
            // 
            // txtQuant
            // 
            txtQuant.Location = new Point(184, 150);
            txtQuant.Name = "txtQuant";
            txtQuant.Size = new Size(100, 31);
            txtQuant.TabIndex = 4;
            // 
            // btnGetInvoice
            // 
            btnGetInvoice.BackColor = SystemColors.Info;
            btnGetInvoice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGetInvoice.Location = new Point(26, 251);
            btnGetInvoice.Name = "btnGetInvoice";
            btnGetInvoice.Size = new Size(132, 34);
            btnGetInvoice.TabIndex = 5;
            btnGetInvoice.Text = "Get Invoice";
            btnGetInvoice.UseVisualStyleBackColor = false;
            btnGetInvoice.Click += btnGetInvoice_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.Info;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(174, 251);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 34);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // dgInvoice
            // 
            dgInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgInvoice.Location = new Point(315, 79);
            dgInvoice.Name = "dgInvoice";
            dgInvoice.RowHeadersWidth = 62;
            dgInvoice.RowTemplate.Height = 33;
            dgInvoice.Size = new Size(693, 332);
            dgInvoice.TabIndex = 7;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = SystemColors.Info;
            btnDisplay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDisplay.Location = new Point(174, 310);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(110, 34);
            btnDisplay.TabIndex = 8;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Info;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(27, 310);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(131, 34);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // GetInvoice
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1057, 450);
            Controls.Add(btnSearch);
            Controls.Add(btnDisplay);
            Controls.Add(dgInvoice);
            Controls.Add(btnExit);
            Controls.Add(btnGetInvoice);
            Controls.Add(txtQuant);
            Controls.Add(txtProd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GetInvoice";
            Text = "GetInvoice";
            ((System.ComponentModel.ISupportInitialize)dgInvoice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtProd;
        private TextBox txtQuant;
        private Button btnGetInvoice;
        private Button btnExit;
        private DataGridView dgInvoice;
        private Button btnDisplay;
        private Button btnSearch;
    }
}