using ClassLibrary.Entities;
using ClassLibrary.Interfaces;
using ClassLibrary.Interfaces.SQLInterfaces.ISQLServices;
using ClassLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Service.SQL_Services
{
    public class SQLUserService : ISQLUserService
    {
        ISQLUnitOfWork _sqluow;

        public SQLUserService(ISQLUnitOfWork uow)
        {
            _sqluow = uow;
        }

/*        public int AddUser(User user)
        {
            return _sqluow.SQLUserRepository.Add(user);
        }*/

        public void DeleteUser(int id)
        {
            _sqluow.SQLUserRepository.Delete(id);
        }

/*        public void Update(User user)
        {
            _sqluow.SQLUserRepository.Update(user);
        }*/

        public IEnumerable<User> GetAll()
        {
            return _sqluow.SQLUserRepository.GetAll();
        }

        public User GetUserById(int id)
        {
            return _sqluow.SQLUserRepository.Get(id);
        }
    }
}
