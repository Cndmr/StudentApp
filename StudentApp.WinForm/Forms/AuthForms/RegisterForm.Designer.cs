namespace StudentApp.WinForm.Forms.AuthForms
{
    partial class RegisterForm
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
            txtName = new TextBox();
            txtLastName = new TextBox();
            label1 = new Label();
            txtPhoneNumber = new TextBox();
            cmbGender = new ComboBox();
            txtUserName = new TextBox();
            txtPass = new TextBox();
            btnRegister = new Button();
            btnCancel = new Button();
            txtStudentNumber = new TextBox();
            cmbInstructor = new ComboBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(166, 54);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Ad";
            txtName.Size = new Size(306, 34);
            txtName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(166, 94);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Soyad";
            txtLastName.Size = new Size(306, 34);
            txtLastName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 9);
            label1.Name = "label1";
            label1.Size = new Size(285, 27);
            label1.TabIndex = 5;
            label1.Text = "Kullanıcı Kayıt Formu";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(166, 134);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Telefon numarası";
            txtPhoneNumber.Size = new Size(306, 34);
            txtPhoneNumber.TabIndex = 3;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(166, 174);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(306, 35);
            cmbGender.TabIndex = 4;
            cmbGender.SelectedIndexChanged += cmbGender_SelectedIndexChanged;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(166, 215);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Kullanıcı Adı";
            txtUserName.Size = new Size(306, 34);
            txtUserName.TabIndex = 5;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(166, 255);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PlaceholderText = "Şifre";
            txtPass.Size = new Size(306, 34);
            txtPass.TabIndex = 6;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(166, 376);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(150, 44);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(322, 376);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 44);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Vazgeç";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.Location = new Point(166, 295);
            txtStudentNumber.Multiline = true;
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.PlaceholderText = "Öğrenci Numarası";
            txtStudentNumber.Size = new Size(306, 34);
            txtStudentNumber.TabIndex = 7;
            // 
            // cmbInstructor
            // 
            cmbInstructor.FormattingEnabled = true;
            cmbInstructor.Location = new Point(166, 335);
            cmbInstructor.Name = "cmbInstructor";
            cmbInstructor.Size = new Size(306, 35);
            cmbInstructor.TabIndex = 8;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 448);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(cmbInstructor);
            Controls.Add(cmbGender);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(txtStudentNumber);
            Controls.Add(txtPass);
            Controls.Add(txtUserName);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtLastName);
            Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Kayıt Formu";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtLastName;
        private Label label1;
        private TextBox txtPhoneNumber;
        private ComboBox cmbGender;
        private TextBox txtUserName;
        private TextBox txtPass;
        private Button btnRegister;
        private Button btnCancel;
        private TextBox txtStudentNumber;
        private ComboBox cmbInstructor;
    }
}