using System;
using Microsoft.Data.SqlClient;
using CommonLayer.Models;
namespace DataAccesLayer
{
    public class DbConnection
    {
        public SqlConnection Cnn;
        public DbConnection()
        {
            Cnn = new SqlConnection(Connection.Connectionstr);
        }
    }
}
