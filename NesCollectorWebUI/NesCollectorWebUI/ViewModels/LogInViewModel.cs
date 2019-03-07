﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NesCollectorWebUI.ViewModels
{
    public class LogInViewModel
    {
        [Required, EmailAddress, Display(Prompt = "Email Address")]
        public string Email { get; set; }
        [Required, DataType(DataType.Password), Display(Prompt = "Password")]
        public string Password { get; set; }
        [Display(Name = "Remember Me?")]
        public bool RememberMe { get; set; }
    }
}
