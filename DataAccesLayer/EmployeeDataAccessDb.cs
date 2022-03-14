using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using CommonLayer.Models;

namespace DataAccesLayer
{
    public class EmployeeDataAccessDb
    {
        private DbConnection db = new DbConnection();

        public List<Employees> GetEmployees()
        {
            string query = "Select * from Employees";
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Connection = db.Cnn;
            if (db.Cnn.State == System.Data.ConnectionState.Closed)
                db.Cnn.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Employees> employees = new List<Employees>();
            while(reader.Read())
            {
                Employees emp = new Employees();
                emp.Id = (int)reader["Id"];
                emp.Name = reader["Name"].ToString();
                emp.Email = reader["Email"].ToString();
                emp.Mobile = reader["Mobile"].ToString();
                emp.Address = reader["Address"].ToString();
            }
            db.Cnn.Close();
            return employees;
        }

    }
}
