using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NesCollectorWebUI.ViewModels
{
    public class RegisterViewModel
    {

        [Required, EmailAddress, Display(Prompt = "Email Address")]
        public string Email { get; set; }
        [DataType(DataType.Password), Required, Display(Prompt = "Password")]
        public string Password { get; set; }
        [DataType(DataType.Password),Compare("Password", ErrorMessage = "Your passwords don't match!"), Required, Display(Prompt = "Confirm Password")]
        public string ConfirmPassword { get; set; }
        //[Required, Display(Name = "Select a Role")]
        public string Role = "User";
        public SelectList Roles { get; set; }
    }
}
