using StudentApp.WinForm.Conteainer;
using StudentApp.WinForm.Entities;
using StudentApp.WinForm.Helpers;
using StudentApp.WinForm.Interfaces;
using StudentApp.WinForm.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp.WinForm.Forms.AuthForms
{
    public partial class RegisterForm : Form
    {
        private readonly IGenderRepository genderRepository;
        public RegisterForm()
        {
            InitializeComponent();
            genderRepository = new DependencyContainer().GetGenderRepositoryInstance();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            LoadGender();
        }
        private void LoadGender()
        {
            var genderList = genderRepository.GetGenders();
            cmbGender.DataSource = null;
            cmbGender.DataSource = genderList;
            cmbGender.DisplayMember = "Definition";
            cmbGender.ValueMember = "Id";
        }


    }
}
