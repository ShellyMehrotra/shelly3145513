using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserAPI.Model;
using UserAPI.Repository;

namespace UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserBusiness _userService;
        public UserController(IUserBusiness userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public User Get()
        {
            return _userService.GetUser();
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public User Get(int id)
        {
            return _userService.GetUser();
        }

    }


}