using ClassLibrary.Interfaces.SQLInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Interfaces
{
    public interface ISQLUnitOfWork
    {
        ISQLOrderRepository SQLOrderRepository { get; }
        void Complete();
    }
}
