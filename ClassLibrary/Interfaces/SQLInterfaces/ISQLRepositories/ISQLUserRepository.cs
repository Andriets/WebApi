using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Interfaces.SQLInterfaces.ISQLRepositories
{
    public interface ISQLUserRepository : IGenericRepository<User, int>
    {
        //int Add(User user);
        //void Update(User user);
    }
}
