using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginWithVerify.Models
{
    public class UserLogin
    {
        [Display(Name ="Email")]
        [Required(AllowEmptyStrings = false, ErrorMessage ="Email is Required")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings =false, ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }

    }
}