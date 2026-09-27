namespace Cafe_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            btnGuest = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(105, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(53, 260);
            label1.Name = "label1";
            label1.Size = new Size(114, 30);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 371);
            label2.Name = "label2";
            label2.Size = new Size(107, 30);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.CustomizableEdges = customizableEdges1;
            txtUsername.DefaultText = "";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Black;
            txtUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Location = new Point(56, 303);
            txtUsername.Margin = new Padding(5, 6, 5, 6);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter Username";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtUsername.Size = new Size(333, 50);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.CustomizableEdges = customizableEdges3;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Location = new Point(56, 414);
            txtPassword.Margin = new Padding(5, 6, 5, 6);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter Password";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtPassword.Size = new Size(333, 47);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BorderRadius = 26;
            btnLogin.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            btnLogin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            btnLogin.CheckedState.FillColor = Color.White;
            btnLogin.CheckedState.ForeColor = Color.FromArgb(30, 90, 255);
            btnLogin.CustomizableEdges = customizableEdges5;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.FromArgb(30, 90, 255);
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(105, 487);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnLogin.Size = new Size(232, 49);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // btnGuest
            // 
            btnGuest.AutoSize = true;
            btnGuest.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuest.LinkColor = Color.Lime;
            btnGuest.Location = new Point(129, 553);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(187, 30);
            btnGuest.TabIndex = 6;
            btnGuest.TabStop = true;
            btnGuest.Text = "Continue as Guest";
            btnGuest.LinkClicked += btnGuest_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(440, 649);
            Controls.Add(btnGuest);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private LinkLabel btnGuest;
    }
}
