using ClassLibrary.Interfaces.SQLInterfaces;
using ClassLibrary.Interfaces.SQLInterfaces.ISQLRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Interfaces
{
    public interface ISQLUnitOfWork
    {
        ISQLOrderRepository SQLOrderRepository { get; }
        ISQLUserRepository SQLUserRepository { get; }
        ISQLProductTypeRepository SQLProductTypeRepository { get; }
        ISQLProductRepository SQLProductRepository { get; }
        void Complete();
    }
}
