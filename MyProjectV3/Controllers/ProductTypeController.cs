using ClassLibrary.Entities;
using ClassLibrary.Interfaces.SQLInterfaces.ISQLServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProjectV3.Controllers
{
    public class ProductTypeController : ControllerBase
    {
        #region Propertirs
        ISQLProductTypeService _sqlProductTypeService;
        #endregion

        #region Constructors
        public ProductTypeController(ISQLProductTypeService sqlProductTypeService)
        {
            _sqlProductTypeService = sqlProductTypeService;
        }
        #endregion

        #region APIs
        [Route("ProductsType")]
        [HttpGet]
        public IEnumerable<ProductType> Get()
        {
            return _sqlProductTypeService.GetAll();
        }

        [Route("ProductType/{Id}")]
        [HttpGet]
        public ProductType Get(int Id)
        {
            return _sqlProductTypeService.GetProductTypeById(Id);
        }

        /*        [Route("ProductType")]
                [HttpPost]
                public long Post([FromBody]ProductType productType)
                {
                    return _sqlProductTypeService.AddProductType(prouctType);
                }*/

        [Route("ProductType/{Id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            _sqlProductTypeService.DeleteProductType(id);
        }

        #endregion
    }
}
