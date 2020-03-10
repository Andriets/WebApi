using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Interfaces.SQLInterfaces.ISQLServices
{
    public interface ISQLProductsService
    {
        public Product GetProductById(int id);
        IEnumerable<Product> GetAll();
        public void DeleteProduct(int id);
    }
}
