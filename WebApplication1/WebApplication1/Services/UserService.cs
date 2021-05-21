using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebApplication1.Services
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public UserService(IHttpContextAccessor _httpContextAccessor)
        {
            httpContextAccessor = _httpContextAccessor;
        }
        public string getUserID()
        {
            return httpContextAccessor.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        }
        public bool IsAuthenticaed()
        {
            return httpContextAccessor.HttpContext.User.Identity.IsAuthenticated;
        }
    }


}
