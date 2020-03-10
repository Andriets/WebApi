using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Entities;

namespace ClassLibrary.Interfaces.SQLInterfaces.ISQLRepositories
{
    public interface ISQLProductRepository : IGenericRepository<Product, int>
    {
        //int Add(Product product);
        //void Update(Product product);
    }
}
