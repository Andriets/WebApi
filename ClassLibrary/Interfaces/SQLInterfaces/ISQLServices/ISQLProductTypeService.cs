using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Interfaces.SQLInterfaces.ISQLServices
{
    public interface ISQLProductTypeService
    {
        public ProductType GetProductTypeById(int id);
        IEnumerable<ProductType> GetAll();
        public void DeleteProductType(int id);
    }
}
