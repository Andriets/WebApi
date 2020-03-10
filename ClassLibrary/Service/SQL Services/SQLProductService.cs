using ClassLibrary.Entities;
using ClassLibrary.Interfaces;
using ClassLibrary.Interfaces.SQLInterfaces.ISQLServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Service.SQL_Services
{
    public class SQLProductService : ISQLProductsService
    {
        ISQLUnitOfWork _sqluow;

        public SQLProductService(ISQLUnitOfWork uow)
        {
            _sqluow = uow;
        }

        /*        public int AddProduct(Product product)
                {
                    return _sqluow.SQLProductRepository.Add(product);
                }*/

        public void DeleteProduct(int id)
        {
            _sqluow.SQLProductRepository.Delete(id);
        }

        /*        public void Update(Product product)
                {
                    _sqluow.SQLProductRepository.Update(product);
                }*/

        public IEnumerable<Product> GetAll()
        {
            return _sqluow.SQLProductRepository.GetAll();
        }

        public Product GetProductById(int id)
        {
            return _sqluow.SQLProductRepository.Get(id);
        }
    }
}
