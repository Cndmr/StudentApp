using StudentApp.WinForm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.WinForm.Interfaces
{
    public interface IAppUserRepository
    {
        void CreateUser(AppUser user);
    }
}
