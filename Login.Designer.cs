namespace Invenntory_Management_System
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            txtPass = new TextBox();
            txtUser = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            btnSignup = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(62, 142);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 183);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSignup);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(362, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(520, 294);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(177, 219);
            button1.Name = "button1";
            button1.Size = new Size(110, 42);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(207, 151);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(253, 31);
            txtPass.TabIndex = 3;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(207, 62);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(253, 31);
            txtUser.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(66, 150);
            label2.Name = "label2";
            label2.Size = new Size(112, 30);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(66, 61);
            label1.Name = "label1";
            label1.Size = new Size(117, 30);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(339, 21);
            label3.Name = "label3";
            label3.Size = new Size(212, 48);
            label3.TabIndex = 2;
            label3.Text = "Login Form";
            // 
            // btnSignup
            // 
            btnSignup.BackColor = SystemColors.Info;
            btnSignup.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignup.Location = new Point(323, 219);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(112, 42);
            btnSignup.TabIndex = 5;
            btnSignup.Text = "Signup";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(956, 475);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button1;
        private TextBox txtPass;
        private TextBox txtUser;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button btnSignup;
    }
}