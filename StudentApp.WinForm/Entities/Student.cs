using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.WinForm.Entities
{
    public class Student : AppUser
    {
        public int Id { get; set; }
        public int StudentNumber { get; set; }
        public int InstructorId { get; set; }
        public int UserId { get; set; }
    }
}
