using StudentApp.WinForm.Conteainer;
using StudentApp.WinForm.Forms.AuthForms;
using StudentApp.WinForm.Helpers;
using StudentApp.WinForm.Interfaces;
using StudentApp.WinForm.Repositories;

namespace StudentApp.WinForm
{
    public partial class LoginForm : Form
    {
        private readonly IGenderRepository genderRepository;
        public LoginForm()
        {
            InitializeComponent();
            genderRepository = new DependencyContainer().GetGenderRepositoryInstance(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var connection = new DbConnectionHelper().Connection;
            connection.Open();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm form = new();
            form.ShowDialog();
        }
    }
}