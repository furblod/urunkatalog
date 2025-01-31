﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abc.MvvWebUI.Models
{
    public class Login
    {
        [Required]
        [Display(Name = "Kullanıcı Adınız")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Şifre")]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Beni Hatırla")]
        public bool RememberMe { get; set; }
    }
}