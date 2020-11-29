using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAdmin2
{
    [Route("/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> Login([FromForm] string password)
        {
            if(password == "password")
            {
                List<Claim> claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Role, "admin")
                };

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "auth");
                ClaimsPrincipal claimsprincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsprincipal);

            }
            return Redirect("/");
        }
    }
}
