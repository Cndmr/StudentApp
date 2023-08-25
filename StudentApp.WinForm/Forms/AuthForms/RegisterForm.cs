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
        private readonly IInstructorRepository instructorRepository;
        public RegisterForm()
        {
            InitializeComponent();
            var dependencyContainer = new DependencyContainer();
            genderRepository = dependencyContainer.GetGenderRepositoryInstance();
            instructorRepository = dependencyContainer.GetInstructorRepositoryInstance();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            LoadGender();
            LoadInstructor();
        }
        private void LoadGender()
        {
            var genderList = genderRepository.GetGenders();
            cmbGender.DataSource = null;
            cmbGender.DataSource = genderList;
            cmbGender.DisplayMember = "Definition";
            cmbGender.ValueMember = "Id";
        }
        private void LoadInstructor()
        {
            var instructorList = instructorRepository.GetInstructors();
            cmbInstructor.DataSource = null;
            cmbInstructor.DataSource = instructorList;
            cmbInstructor.DisplayMember = "Name";
            cmbInstructor.ValueMember = "Id";
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
