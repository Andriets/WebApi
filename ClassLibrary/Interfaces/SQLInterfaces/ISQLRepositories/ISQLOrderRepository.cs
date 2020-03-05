using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Entities;

namespace ClassLibrary.Interfaces.SQLInterfaces
{
    public interface ISQLOrderRepository : IGenericRepository<Order, int>
    {
        Order Get(int id);  
        int Add(Order order);
        void Update(Order order);
        void Delete(int id);
    }
}
