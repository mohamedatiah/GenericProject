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

namespace FullTaskRepository.Reposittory
{
    public class ApplicationSignInRepository : SignInManager<ApplicationUser, string>
    {
        private ApplicationUserRepository _currentUserRepository;

        public ApplicationSignInRepository(ApplicationUserRepository userManager, IAuthenticationManager authenticationManager)
            :
            base(userManager, authenticationManager)
        {
            _currentUserRepository = userManager;
        }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(ApplicationUser user)
        {
            return _currentUserRepository.GenerateUserIdentityAsync(user);
        }

        public static ApplicationSignInRepository Create(IdentityFactoryOptions<ApplicationSignInRepository> options, IOwinContext context)
        {
            return new ApplicationSignInRepository(context.GetUserManager<ApplicationUserRepository>(), context.Authentication);
        }

    }
}
