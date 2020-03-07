using ClassLibrary.Interfaces;
using ClassLibrary.Interfaces.SQLInterfaces;
using ClassLibrary.Interfaces.SQLInterfaces.ISQLRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.UOW
{
    public class UnitOfWork : ISQLUnitOfWork
    {
        private readonly ISQLOrderRepository _sqlOrderRepository;
        private readonly ISQLUserRepository _sqlUserRepository;
   
        public UnitOfWork(ISQLOrderRepository sqlorderRepository, ISQLUserRepository sQLUserRepository)
        {
            _sqlOrderRepository = sqlorderRepository;
            _sqlUserRepository = sQLUserRepository;
        }

        public ISQLOrderRepository SQLOrderRepository
        {
            get
            {
                return _sqlOrderRepository;
            }
        }

        public ISQLUserRepository SQLUserRepository
        {
            get
            {
                return _sqlUserRepository;
            }
        }


        public void Complete()
        {
            throw new NotImplementedException();
        }
    }
}
