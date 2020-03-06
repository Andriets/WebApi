using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Interfaces;
using ClassLibrary.Entities.EntityInterface;
using Dapper;
using System.Data;
using System.Linq;

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

        public TEntity Get(int Id)
        {
            var query = "ReadById";

            using (var db = _connectionFactory.GetSqlConnection)
            {
                return db.Query<TEntity>(query,
                    new { id = Id },
                    commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }


    }
}
