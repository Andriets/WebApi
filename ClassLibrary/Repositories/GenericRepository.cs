using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Interfaces;
using ClassLibrary.Entities.EntityInterface;
using Dapper;
using System.Data;

namespace ClassLibrary.Repositories
{
    public class GenericRepository<TEntity, TId> : IGenericRepository<TEntity, TId> where TEntity : IEntity<TId>
    {
        protected IConnectionFactory _connectionFactory;
        private readonly string _tableName;

        public GenericRepository(IConnectionFactory connectionFactory, string tableName)
        {
            _connectionFactory = connectionFactory;
            _tableName = tableName; 
        }

        public IEnumerable<TEntity> GetAll()
        {
            var query = "GetAll";

            using(var db = _connectionFactory.GetSqlConnection)
            {
                return db.Query<TEntity>(query,
                    new { TableName = _tableName },
                    commandType: CommandType.StoredProcedure);
            }
        }


    }
}
