using Evidenta.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Evidenta.Repository;
using Evidenta.Models;
using Microsoft.EntityFrameworkCore;


namespace Evidenta.Services
{
    public class AuthentificationServices : IAuthentificationServices
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public AuthentificationServices(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IdentityUser CreateUser(string username)
        {
            return new IdentityUser { UserName = username };
        }
        public async Task<IdentityResult> Register(IdentityUser user, string password)
        {
            return await _userManager.CreateAsync(user, password);
        }

        public async Task<SignInResult> Login(string username, string password, bool rememberMe)
        {
            return await _signInManager.PasswordSignInAsync(username, password, rememberMe, lockoutOnFailure: false);
        }

        public async Task LogOut()
        {
            await _signInManager.SignOutAsync();
        }


    }
}
