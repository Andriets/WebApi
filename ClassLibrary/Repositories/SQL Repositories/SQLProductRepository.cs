using ClassLibrary.Entities;
using ClassLibrary.Interfaces;
using ClassLibrary.Interfaces.SQLInterfaces.ISQLRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Repositories.SQL_Repositories
{
    public class SQLProductRepository : GenericRepository<Product, int>, ISQLProductRepository
    {
        private static readonly string _tableName = "Products";
        public SQLProductRepository(IConnectionFactory connectionFactory) : base(connectionFactory, _tableName)
        {
            // connectionFactory.SetConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }
    }
}
