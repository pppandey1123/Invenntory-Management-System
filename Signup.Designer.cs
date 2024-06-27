namespace Invenntory_Management_System
{
    partial class Signup
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
            label5 = new Label();
            label6 = new Label();
            txtFirstname = new TextBox();
            txtLastname = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            label7 = new Label();
            button1 = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(117, 96);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(119, 138);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(123, 185);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(127, 237);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(160, 293);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(141, 342);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 5;
            label6.Text = "Contact";
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(234, 93);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(304, 31);
            txtFirstname.TabIndex = 6;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(234, 138);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(304, 31);
            txtLastname.TabIndex = 7;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(234, 185);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(304, 31);
            txtUsername.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(234, 237);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(304, 31);
            txtPassword.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(234, 293);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(304, 31);
            txtEmail.TabIndex = 10;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(234, 342);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(304, 31);
            txtContact.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(272, 21);
            label7.Name = "label7";
            label7.Size = new Size(217, 45);
            label7.TabIndex = 12;
            label7.Text = "SignUp Form";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(246, 395);
            button1.Name = "button1";
            button1.Size = new Size(112, 43);
            button1.TabIndex = 13;
            button1.Text = "SignUp";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.Info;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(395, 395);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 43);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(txtContact);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtLastname);
            Controls.Add(txtFirstname);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Signup";
            Text = "Signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtFirstname;
        private TextBox txtLastname;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtContact;
        private Label label7;
        private Button button1;
        private Button btnCancel;
    }
}