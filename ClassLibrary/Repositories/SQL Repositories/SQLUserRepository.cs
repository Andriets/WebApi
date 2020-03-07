using ClassLibrary.Entities;
using ClassLibrary.Interfaces;
using ClassLibrary.Interfaces.SQLInterfaces.ISQLRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Repositories.SQL_Repositories
{
    public class SQLUserRepository : GenericRepository<User, int>, ISQLUserRepository
    {
        private static readonly string _tableName = "Users";

        public SQLUserRepository(IConnectionFactory connectionFactory) : base(connectionFactory, _tableName)
        {
            // connectionFactory.SetConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }


        
    }
}
