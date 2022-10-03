using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullTaskManager.DTO.Auth
{
    public class SendCodeViewModel :IBaseDto
    {
        public string SelectedProvider { get; set; }
        //public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

}
