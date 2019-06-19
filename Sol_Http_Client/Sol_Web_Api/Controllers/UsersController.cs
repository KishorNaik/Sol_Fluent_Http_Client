using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sol_Web_Api.Models;

// https://github.com/Pathoschild/FluentHttpClient
namespace Sol_Web_Api.Controllers
{
    [Produces("application/json")]
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // Http Post
        [HttpPost("postdemo")]
        public IActionResult PostDemo([FromBody] UserModel userModel)
        {
            if (userModel == null) return base.BadRequest();
            else
            {
                return
                    base
                    .Ok((Object)userModel);
            }
        }

        [HttpPost("postdemoarray")]
        public IActionResult PostDemoArray()
        {
            var userModelList = new List<UserModel>()
            {
                new UserModel()
                {
                    FirstName="Kishor",
                    LastName="Naik"
                },
                new UserModel()
                {
                    FirstName="Eshaan",
                    LastName="Naik"
                }
            };

            return
                base
                .Ok((Object)userModelList);
        }

        [HttpGet("getdemo/{id}")]
        public IActionResult GetDemo(int id)
        {
            return
                base
                    .Ok((Object)id);
        }
    }
}