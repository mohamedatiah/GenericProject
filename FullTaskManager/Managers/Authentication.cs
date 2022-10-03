using FullTaskManager.DTO.Auth;
using FullTaskManager.Managers;
using FullTaskRepository;
using FullTaskRepository.Models;
using FullTaskRepository.Reposittory;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Web;


public class VerifyRegisterCodeViewModel
{
    //[Required(ErrorMessageResourceName = "PhoneRequired", ErrorMessageResourceType = typeof(ValidationsResources))]
    [Display(Name = "Phone number")]
    //[RegularExpression(AppConstants.MobilePhoneRex, ErrorMessageResourceName = "RegisterPhoneIsNotValed", ErrorMessageResourceType = typeof(ValidationsResources))]

    public string PhoneNumber { get; set; }

    public string Password { get; set; }
    public string Code { get; set; }

    public string UserId { get; set; }
    public bool RememberMe { get; set; }

}
public class ApplicationUserVm
{
    public string UserName { get; set; }
    public bool PhoneNumberConfirmed { get; set; }
    //public UserAccountType AccountType { get; set; }
    public string Id { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Image { get; set; }
}
public class TokenModel
{
    public string access_token { get; set; }
    public string token_type { get; set; }
    public string expires_in { get; set; }
}
public class Authentication
{

    private ApplicationUserManager _userManager;
    private ApplicationSignInManager _signInMngr;

    // private ContactProcedureLoggerManager _ContactProcedureLoggerManager;

    private IAuthenticationManager authenticationManager
    {
        get
        {
            return HttpContext.Current.GetOwinContext().Authentication;
        }
    }

    public Authentication(ApplicationUserManager a,ApplicationSignInManager b)
    {
        _userManager = a;

        _signInMngr = b;

    }

    public  async Task<SignInStatus> Login(LoginViewModel model)
    {
        return  await _signInMngr.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, shouldLockout: false);

    }
    public async Task<IdentityResult> Register( RegisterViewModel model)
    {
        var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
        var result = await _userManager.CreateAsync(user, model.Password);
        await _signInMngr.SignInAsync(user, isPersistent: false, rememberBrowser: false);

        return result;
    }
    private IAuthenticationManager AuthenticationManager
    {
        get
        {
            return HttpContext.Current.GetOwinContext().Authentication;
        }
    }
}
