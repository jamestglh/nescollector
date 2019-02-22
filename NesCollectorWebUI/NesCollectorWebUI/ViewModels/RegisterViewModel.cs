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
        [EmailAddress, Required]
        public string Email { get; set; }
        [DataType(DataType.Password), Required]
        public string Password { get; set; }
        [DataType(DataType.Password),Compare("Password", ErrorMessage = "Your passwords don't match!"), Required]
        public string ConfirmPassword { get; set; }
        public string RoleId { get; set; }
        public SelectList Roles { get; set; }
    }
}
