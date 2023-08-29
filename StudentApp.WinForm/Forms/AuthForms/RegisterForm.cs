using StudentApp.WinForm.Conteainer;
using StudentApp.WinForm.Dtos;
using StudentApp.WinForm.Entities;
using StudentApp.WinForm.Helpers;
using StudentApp.WinForm.Interfaces;

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
            var list = ConverToInstructorDtoList(instructorList);
            cmbInstructor.DataSource = null;
            cmbInstructor.DataSource = instructorList;
            cmbInstructor.DisplayMember = "Fullname";
            cmbInstructor.ValueMember = "Id";
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //auto mapper
        private List<InstructorListDto> ConverToInstructorDtoList(List<Instructor> instructors)
        {
            var list = new List<InstructorListDto>();
            foreach (var instructor in instructors)
            {
                var dto = new InstructorListDto();
                dto.Id = instructor.Id;
                dto.UserId = instructor.UserId;
                dto.PhoneNumber = instructor.PhoneNumber;
                dto.Fullname = instructor.Name + " " + instructor.Surname;
                dto.Salary = instructor.Salary;
                dto.GenderId = instructor.GenderId;
                dto.Password = instructor.Password;
                dto.UserName = instructor.UserName;
                list.Add(dto);

            }
            return list;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var hashHelper = new HashHelper();
            var hashedString = hashHelper.HashString("can");
            if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtName.Text) &&
                !string.IsNullOrEmpty(txtLastName.Text) && !string.IsNullOrEmpty(txtPass.Text) &&
                !string.IsNullOrEmpty(txtPhoneNumber.Text) && !string.IsNullOrEmpty(txtStudentNumber.Text))
            {

            }
            else 
            {
                MessageBox.Show("Alanları Boş Bırakmayınız.");
            
            }
        }
    }
}
