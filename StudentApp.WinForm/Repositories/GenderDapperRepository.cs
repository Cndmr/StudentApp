using Dapper;
using StudentApp.WinForm.Entities;
using StudentApp.WinForm.Helpers;
using StudentApp.WinForm.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.WinForm.Repositories
{
    public class GenderDapperRepository : IGenderRepository
    {
        public List<Gender> GetGenders()
        {
            var connection = new DbConnectionHelper().Connection;
            var genderList=connection.Query<Gender>("select * from Genders").ToList();
            return genderList;
        }
    }
}
