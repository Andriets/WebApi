using ClassLibrary.Entities;
using ClassLibrary.Interfaces.SQLInterfaces.ISQLServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProjectV3.Controllers
{
    public class ProductController : ControllerBase
    {
        #region Propertirs
        ISQLProductsService _sqlProductsService;
        #endregion

        #region Constructors
        public ProductController(ISQLProductsService sqlProductService)
        {
            _sqlProductsService = sqlProductService;
        }
        #endregion

        #region APIs
        [Route("Products")]
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _sqlProductsService.GetAll();
        }

        [Route("Product/{Id}")]
        [HttpGet]
        public Product Get(int Id)
        {
            return _sqlProductsService.GetProductById(Id);
        }

        /*        [Route("Product")]
                [HttpPost]
                public long Post([FromBody]Product product)
                {
                    return _sqlProductService.AddProduct(prouct);
                }*/

        [Route("Product/{Id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            _sqlProductsService.DeleteProduct(id);
        }

        #endregion
    }
}
