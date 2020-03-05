using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Interfaces;
using ClassLibrary.Interfaces.SQLInterfaces.ISQLServices;
using ClassLibrary.Entities;

namespace WebApiProject.Controllers
{
    public class OrderController : ControllerBase
    {
        #region Propertirs
        ISQLOrderService _sqlOrderService;
        #endregion

        #region Constructors
        public OrderController(ISQLOrderService sqlOrderService)
        {
            _sqlOrderService = sqlOrderService;
        }
        #endregion

        #region APIs
        [Route("Orders")]
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return _sqlOrderService.GetAll();
        }

        [Route("Order/{Id}")]
        [HttpGet]
        public Order Get(int Id)
        {
            return _sqlOrderService.GetOrderById(Id);
        }

        [Route("Order")]
        [HttpPost]
        public long Post([FromBody]Order order)
        {
            return _sqlOrderService.AddOrder(order);
        }

        [Route("Order/{Id}")]
        [HttpDelete]
        public void Delete([FromBody]int id)
        {
            _sqlOrderService.DeleteOrder(id);
        }

        #endregion
    }
}
