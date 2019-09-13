using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomAuthAuthorizationSession.Models
{
    public class Account
    {
        [Display(Name ="UserName")]
        public string Username { get; set; }
        [Display(Name = "Password")]
        public string Password { get; set; }
        public string[] Roles { get; set; }
    }
}