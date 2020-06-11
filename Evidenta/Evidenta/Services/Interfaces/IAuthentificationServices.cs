using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evidenta.Services.Interfaces
{
    public interface IAuthentificationServices
    {
        public IdentityUser CreateUser(String username);
        public Task<IdentityResult> Register(IdentityUser user, string password);
        public Task<SignInResult> Login(string username, string password, bool rememberMe);
        public Task LogOut();
    }
}
