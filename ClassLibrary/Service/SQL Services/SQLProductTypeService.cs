using ClassLibrary.Entities;
using ClassLibrary.Interfaces;
using ClassLibrary.Interfaces.SQLInterfaces.ISQLServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Service.SQL_Services
{
    public class SQLProductTypeService : ISQLProductTypeService
    {
        ISQLUnitOfWork _sqluow;

        public SQLProductTypeService(ISQLUnitOfWork uow)
        {
            _sqluow = uow;
        }

        /*        public int AddProductType(ProductType productType)
                {
                    return _sqluow.SQLProductTypeRepository.Add(productType);
                }*/

        public void DeleteProductType(int id)
        {
            _sqluow.SQLProductTypeRepository.Delete(id);
        }

        /*        public void Update(ProductType productType)
                {
                    _sqluow.SQLProductTypeRepository.Update(productType);
                }*/

        public IEnumerable<ProductType> GetAll()
        {
            return _sqluow.SQLProductTypeRepository.GetAll();
        }

        public ProductType GetProductTypeById(int id)
        {
            return _sqluow.SQLProductTypeRepository.Get(id);
        }
    }
}
