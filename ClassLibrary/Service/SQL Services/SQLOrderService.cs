using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Entities;
using ClassLibrary.Interfaces;
using ClassLibrary.Interfaces.SQLInterfaces.ISQLServices;

namespace ClassLibrary.Service.SQL_Services
{
    public class SQLOrderService : ISQLOrderService
    {
        ISQLUnitOfWork _sqluow;

        public SQLOrderService(ISQLUnitOfWork ouw)
        {
            _sqluow = ouw;
        }

        public int AddOrder(Order order)
        {
            return _sqluow.SQLOrderRepository.Add(order);
        }

        public void DeleteOrder(int id)
        {
            _sqluow.SQLOrderRepository.Delete(id);
        }

        public IEnumerable<Order> GetAll()
        {
            return _sqluow.SQLOrderRepository.GetAll();
        }

        public Order GetOrderById(int id)
        {
            return _sqluow.SQLOrderRepository.Get(id);
        }

        public void UpdateOrder(Order order)
        {
            _sqluow.SQLOrderRepository.Update(order);
        }
    }
}
