using StudentApp.WinForm.Entities;
using StudentApp.WinForm.Helpers;
using StudentApp.WinForm.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.WinForm.Repositories
{
    public class AppUserRepository : IAppUserRepository
    {
        public void CreateUser(AppUser user)
        {
            var connection = new DbConnectionHelper().Connection;
            SqlCommand command=new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "insert into Users values(@name,@surname,@genderId,@phoneNumber,@username,@password)";
            command.Connection=connection;
            command.Parameters.AddWithValue("@name", user.Name);
            command.Parameters.AddWithValue("@surname", user.Surname);
            command.Parameters.AddWithValue("@genderId", user.GenderId);
            command.Parameters.AddWithValue("@phoneNumber", user.PhoneNumber);
            command.Parameters.AddWithValue("@username", user.UserName);
            command.Parameters.AddWithValue("@password", user.Password);
            connection.Open();
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.Close();

        }
    }
}
