using System.Collections.Generic;
using CoreAngular4DemoApp.Server.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreAngular4DemoApp.Server.Controllers.api
{
    public class AppUtils
    {
        internal static IActionResult SignIn(ApplicationUser user, IList<string> roles)
        {
            var userResult = new { User = new { DisplayName = user.UserName, Roles = roles } };
            return new ObjectResult(userResult);
        }
    }
}