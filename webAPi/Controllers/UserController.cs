using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace webAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("userInfo")]
        public ActionResult GetUserInfo()
        {
            //return new JsonResult(User.Claims.Select(
            //    c => new { c.Type, c.Value }));

            return new JsonResult(new
            {
                name = "cnblgos",
                address = "hk"
            });
        }

        [HttpGet]
        [Route("OtherInfo")]
        public ActionResult inf()
        {
            return new JsonResult(
                User.Claims.Select(c => new { c.Type, c.Value }));
        }


        [HttpGet]
        [Route("test")]
        public ActionResult infs()
        {
            return new JsonResult(new
            {
                name = "name",
                address = "address"
            });

        }
    }
}