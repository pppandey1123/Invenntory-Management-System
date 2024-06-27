namespace Invenntory_Management_System
{
    partial class InventoryItem
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
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnInvoice = new Button();
            btnDelete = new Button();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            btnDisplayProd = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(43, 96);
            label1.Name = "label1";
            label1.Size = new Size(113, 28);
            label1.TabIndex = 0;
            label1.Text = "Product ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 155);
            label2.Name = "label2";
            label2.Size = new Size(148, 28);
            label2.TabIndex = 1;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(91, 216);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(60, 273);
            label4.Name = "label4";
            label4.Size = new Size(95, 28);
            label4.TabIndex = 3;
            label4.Text = "Quantity";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(157, 152);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(157, 216);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(157, 267);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Info;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(80, 328);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 34);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Info;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(217, 328);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 34);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInvoice
            // 
            btnInvoice.BackColor = SystemColors.Info;
            btnInvoice.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnInvoice.Location = new Point(217, 393);
            btnInvoice.Name = "btnInvoice";
            btnInvoice.Size = new Size(90, 34);
            btnInvoice.TabIndex = 10;
            btnInvoice.Text = "Invoice";
            btnInvoice.UseVisualStyleBackColor = false;
            btnInvoice.Click += btnInvoice_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Info;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(80, 393);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 34);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(266, 27);
            label5.Name = "label5";
            label5.Size = new Size(153, 45);
            label5.TabIndex = 12;
            label5.Text = "Products";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(336, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(706, 331);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnDisplayProd
            // 
            btnDisplayProd.BackColor = SystemColors.Info;
            btnDisplayProd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDisplayProd.Location = new Point(80, 451);
            btnDisplayProd.Name = "btnDisplayProd";
            btnDisplayProd.Size = new Size(92, 34);
            btnDisplayProd.TabIndex = 14;
            btnDisplayProd.Text = "Display";
            btnDisplayProd.UseVisualStyleBackColor = false;
            btnDisplayProd.Click += btnDisplayProd_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.Info;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(217, 451);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 34);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // InventoryItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1088, 525);
            Controls.Add(btnExit);
            Controls.Add(btnDisplayProd);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(btnDelete);
            Controls.Add(btnInvoice);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InventoryItem";
            Text = "InventoryItem";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnInvoice;
        private Button btnDelete;
        private Label label5;
        private DataGridView dataGridView1;
        private Button btnDisplayProd;
        private Button btnExit;
    }
}