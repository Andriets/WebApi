using ClassLibrary.Entities;
using ClassLibrary.Interfaces;
using ClassLibrary.Interfaces.SQLInterfaces.ISQLRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Repositories.SQL_Repositories
{
    public class SQLProductTypeRepository : GenericRepository<ProductType, int>, ISQLProductTypeRepository
    {
        private static readonly string _tableName = "ProductType";
        public SQLProductTypeRepository(IConnectionFactory connectionFactory) : base(connectionFactory, _tableName)
        {
            // connectionFactory.SetConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }
    }
}
