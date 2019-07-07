using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace client.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            string scheme = "oidc"; //ConfigureServices中注册的服务是oidc
            string schemeTe = "oidc";
            scheme = OpenIdConnectDefaults.DisplayName;

            //var userResult = await HttpContext.AuthenticateAsync(scheme);
            //var user = userResult.Principal;
            //var props1 = userResult.Properties;
            //userResult.Properties.GetTokenValue("access_token");

            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            //var userResult = await HttpContext.AuthenticateAsync(scheme);

            //var user = userResult.Principal;
            //var props1 = userResult.Properties;


            var props = new AuthenticationProperties
            {
                //指定授权成功后回调的Action
                RedirectUri = Url.Action(nameof(Callback)),
                /*
                 可以传些额外信息，回调会传回来
                 可以通过
                  var result = await HttpContext.AuthenticateAsync("oidc");
                  result.Properties.Items["returnUrl"]
                 */
                //Items =
                //    {
                //        { "returnUrl", returnUrl },
                //        { "scheme", provider },
                //    }
            };

            return Challenge(props, scheme);


            /*
             如果这样，授权服务器回调就是当前Action
             */
            //return Challenge(scheme);


            //await HttpContext.ChallengeAsync(scheme);
            //return await ProcessWindowsLoginAsync("/Account/Authorize");
            return View();
        }
        /// <summary>
        /// 回调方法
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Callback(int a)
        {
            var result1 = await HttpContext.AuthenticateAsync();
            var result = await HttpContext.AuthenticateAsync(OpenIdConnectDefaults.DisplayName);
            //var result = await HttpContext.AuthenticateAsync("oidc");
            if (result?.Succeeded != true)
            {
                //throw new Exception("External authentication error");
            }
            var id_token = result.Properties.GetTokenValue("id_token");
            var access_token = result.Properties.GetTokenValue("access_token");

            //  var returnUrl = result.Properties.Items["returnUrl"] ?? "~/";

            return RedirectToAction("UserInfo", "Account");
        }
    }
}