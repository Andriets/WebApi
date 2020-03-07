using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Interfaces.SQLInterfaces;
using ClassLibrary.Interfaces;
using ClassLibrary.Entities;
using System.Configuration;
using Dapper;
using System.Data;
using System.Linq;

namespace ClassLibrary.Repositories.SQL_Repositories
{
    public class SQLOrderRepository : GenericRepository<Order, int> ,ISQLOrderRepository
    {
        private static readonly string _tableName = "Orders";
        public SQLOrderRepository(IConnectionFactory connectionFactory) : base(connectionFactory, _tableName)
        {
           // connectionFactory.SetConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }

        public int Add(Order order)
        {
            var query = "AddOrder";
            using (var db = _connectionFactory.GetSqlConnection)
            {
                var InsertionStatement = db.Query<string>(
                    sql: query,
                    param: new { Prodid = order.ProductId, count = order.CountOfProduct, user = order.UserId, date = order.DateOfOrder },
                    commandType: CommandType.StoredProcedure).FirstOrDefault();

                var InsertedEntityId = db.Execute(
                    sql: InsertionStatement,
                    param: order,
                    commandType: CommandType.Text);

                return InsertedEntityId;
            }
        }

        public void Update(Order order)
        {
            using (var db = _connectionFactory.GetSqlConnection)
            {
                var query = "UpdateOrder";

                var UpdateStatement = db.Query<string>(
                    sql: query,
                    param: new { OrderId = order.Id, ProdId = order.ProductId, count = order.CountOfProduct, user = order.UserId, date = order.DateOfOrder },
                    commandType: CommandType.StoredProcedure).FirstOrDefault();

                db.Execute(
                    sql: UpdateStatement,
                    param: order,
                    commandType: CommandType.Text);
            }
        }

/*        public void Delete(int Id)
        {
            using (var db = _connectionFactory.GetSqlConnection)
            {
                var query = "DeleteById";

                var UnActivateStatement = db.Query<string>(
                    sql: query,
                    param: new { id = Id },
                    commandType: CommandType.StoredProcedure).FirstOrDefault();

                db.Execute(
                    sql: UnActivateStatement,
                    param: Id,
                    commandType: CommandType.Text);
            }
        }*/
    }
}
