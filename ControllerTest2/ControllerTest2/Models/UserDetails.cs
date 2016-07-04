using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControllerTest2.Models
{
    public class UserDetails
    {
        [StringLength(7,MinimumLength=2, ErrorMessage = "Username 2-7")]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}