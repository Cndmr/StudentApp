namespace StudentApp.WinForm
{
    partial class LoginForm
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
            btnLogin = new Button();
            btnClose = new Button();
            txtPass = new TextBox();
            txtUserName = new TextBox();
            btnRegister = new Button();
            lblConnection = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(12, 241);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(140, 68);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(158, 241);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(154, 68);
            btnClose.TabIndex = 4;
            btnClose.Text = "Kapat";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(12, 192);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PlaceholderText = "Şifre:";
            txtPass.Size = new Size(300, 34);
            txtPass.TabIndex = 2;
            txtPass.TextChanged += textBox1_TextChanged;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(12, 152);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Kullanıcı Adı:";
            txtUserName.Size = new Size(300, 34);
            txtUserName.TabIndex = 1;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(12, 315);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(295, 43);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "KAYIT OL";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblConnection
            // 
            lblConnection.AutoSize = true;
            lblConnection.Location = new Point(12, 361);
            lblConnection.Name = "lblConnection";
            lblConnection.Size = new Size(0, 23);
            lblConnection.TabIndex = 5;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 389);
            Controls.Add(lblConnection);
            Controls.Add(txtUserName);
            Controls.Add(txtPass);
            Controls.Add(btnClose);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnClose;
        private TextBox txtPass;
        private TextBox txtUserName;
        private Button btnRegister;
        private Label lblConnection;
    }
}