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
        private readonly ISQLProductTypeRepository _sqlProductTypeRepository;
        private readonly ISQLProductRepository _sqlProductRepository;
   
        public UnitOfWork(ISQLOrderRepository sqlorderRepository, 
            ISQLUserRepository sQLUserRepository,
            ISQLProductTypeRepository sQLProductTypeRepository,
            ISQLProductRepository sQLProductRepository)
        {
            _sqlOrderRepository = sqlorderRepository;
            _sqlUserRepository = sQLUserRepository;
            _sqlProductTypeRepository = sQLProductTypeRepository;
            _sqlProductRepository = sQLProductRepository;
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

        public ISQLProductTypeRepository SQLProductTypeRepository
        {
            get
            {
                return _sqlProductTypeRepository;
            }
        }
        public ISQLProductRepository SQLProductRepository
        {
            get
            {
                return _sqlProductRepository;
            }
        }


        public void Complete()
        {
            throw new NotImplementedException();
        }
    }
}
