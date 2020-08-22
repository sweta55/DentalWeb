﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DentalWeb.Models
{
    public class Login
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="Username")]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
    }
}