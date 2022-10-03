using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FullTaskManager.DTO.Auth
{
    public class ConfigureTwoFactorViewModel: IBaseDto
    {
        public string SelectedProvider { get; set; }
       // public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
    }
}
