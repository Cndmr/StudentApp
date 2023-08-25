using StudentApp.WinForm.Entities;
using StudentApp.WinForm.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentApp.WinForm.Interfaces;

namespace StudentApp.WinForm.Repositories
{
    public class GenderRepository:IGenderRepository
    {
        public List<Gender> GetGenders()
        {
            var connection = new DbConnectionHelper().Connection;

            List<Gender> genders = new List<Gender>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "select * from Genders";
            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var addedGender = new Gender();
                addedGender.Id = Convert.ToInt32(reader[0]);
                addedGender.Definition = Convert.ToString(reader[1]);
                genders.Add(addedGender);
            }
            reader.Close();
            connection.Close();
            return genders;
        }
    }
}
