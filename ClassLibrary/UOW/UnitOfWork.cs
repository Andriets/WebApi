using ClassLibrary.Interfaces;
using ClassLibrary.Interfaces.SQLInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.UOW
{
    public class UnitOfWork : ISQLUnitOfWork
    {
        private readonly ISQLOrderRepository _sqlOrderRepository;
   
        public UnitOfWork(ISQLOrderRepository sqlorderRepository)
        {
            _sqlOrderRepository = sqlorderRepository;
        }

        public ISQLOrderRepository SQLOrderRepository
        {
            get
            {
                return _sqlOrderRepository;
            }
        }

        public void Complete()
        {
            throw new NotImplementedException();
        }
    }
}
