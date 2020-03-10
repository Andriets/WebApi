using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Interfaces;
using ClassLibrary.Interfaces.SQLInterfaces.ISQLServices;
using ClassLibrary.Entities;

namespace MyProjectV3.Controllers
{
    public class UserController : ControllerBase
    {
        #region Propertirs
        ISQLUserService _sqlUserService;
        #endregion

        #region Constructors
        public UserController(ISQLUserService sqlUserService)
        {
            _sqlUserService = sqlUserService;
        }
        #endregion

        #region APIs
        [Route("Users")]
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _sqlUserService.GetAll();
        }

        [Route("User/{Id}")]
        [HttpGet]
        public User Get(int Id)
        {
            return _sqlUserService.GetUserById(Id);
        }

/*        [Route("User")]
        [HttpPost]
        public long Post([FromBody]User user)
        {
            return _sqlUserService.AddUser(user);
        }*/

        [Route("User/{Id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            _sqlUserService.DeleteUser(id);
        }

        #endregion
    }
}
