using FullTaskRepository.Models;

using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FullTaskManager.Managers
{
    public class ApplicationSignInManager : SignInManager<ApplicationUser, string>
    {
      //  private ApplicationSignInManager _signInManager;

        public ApplicationSignInManager(ApplicationUserManager userManager, IAuthenticationManager authenticationManager)
            : base(userManager, authenticationManager)
        {
        }


        public override Task<ClaimsIdentity> CreateUserIdentityAsync(ApplicationUser user)
        {
            return user.GenerateUserIdentityAsync((ApplicationUserManager)UserManager);
        }

        public static ApplicationSignInManager Create(IdentityFactoryOptions<ApplicationSignInManager> options, IOwinContext context)
        {
            return new ApplicationSignInManager(context.GetUserManager<ApplicationUserManager>(), context.Authentication);
        }
        //public async Task<SignInStatus>  PasswordSignInAsyncManager(string userName, string password, bool isPersistent, bool shouldLockout)
        //{
        //    return await _signInManager.PasswordSignInAsync(userName, password, isPersistent, shouldLockout);
        //}
        //public async void SignInAsyncManager(ApplicationUser user, bool isPersistent, bool rememberBrowser)
        //{
        //     await _signInManager.SignInAsync(user, isPersistent,rememberBrowser);
        //}
        
        //public async Task<bool> HasBeenVerifiedAsyncManager()
        //{
        //    return await _signInManager.HasBeenVerifiedAsync();
        //}
        
    }

    }

