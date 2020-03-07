using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Interfaces.SQLInterfaces.ISQLServices
{
    public interface ISQLUserService
    {
        public User GetUserById(int id);
        IEnumerable<User> GetAll();
        public void DeleteUser(int id);
    }
}
