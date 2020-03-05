using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Entities;

namespace ClassLibrary.Interfaces.SQLInterfaces.ISQLServices
{
    public interface ISQLOrderService
    {
         public int AddOrder(Order order);

         public void UpdateOrder(Order order);

         public void DeleteOrder(int order);
         public Order GetOrderById(int Id);
         IEnumerable<Order> GetAll();
    }
}
