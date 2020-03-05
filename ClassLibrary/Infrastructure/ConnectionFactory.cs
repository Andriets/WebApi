using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ClassLibrary.Interfaces;
using System.Data.SqlClient;
using System.Configuration;

namespace ClassLibrary.Infrastructure
{
    public class ConnectionFactory : IConnectionFactory
    {
        private static string _connectionString = "Data Source=LAPTOP-AL4E2RNV\\SQLEXPRESS01;Initial Catalog=Company;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void SetConnection(string connectioonString)
        {
            _connectionString = connectioonString;
        }

        public IDbConnection GetSqlConnection
        {
            get
            {
                SqlConnection connection;

                //if (!string.IsNullOrEmpty(_connectionString))
                    connection = new SqlConnection(_connectionString);
                //else
                 //   connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

                connection.Open();

                return connection;
            }
        }
    }
}
