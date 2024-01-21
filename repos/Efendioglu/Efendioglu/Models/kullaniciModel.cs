using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Efendioglu.Models
{
    public class LoginModel
        {
    [Required]// gririlmesi zorunlu olan bilgileri belirtir
    public string Username { get; set; }
    
    [Required]
    public string password { get; set; }
}
    public class Register
    {
        [Required]// gririlmesi zorunlu olan bilgileri belirtir
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string password { get; set; }
    }
}