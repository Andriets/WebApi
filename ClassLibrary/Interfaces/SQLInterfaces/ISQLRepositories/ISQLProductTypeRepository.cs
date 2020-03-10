using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Interfaces.SQLInterfaces.ISQLRepositories
{
    public interface ISQLProductTypeRepository : IGenericRepository<ProductType, int>
    {
       /* int Add(ProductType productType);
        void Update(ProductType productType);*/
    }
}
