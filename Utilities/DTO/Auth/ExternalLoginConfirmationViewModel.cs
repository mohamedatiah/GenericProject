using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullTaskManager.DTO.Auth
{
    public class ExternalLoginConfirmationViewModel :IBaseDto
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

}
