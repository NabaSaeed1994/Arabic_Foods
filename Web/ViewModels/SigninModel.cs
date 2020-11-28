﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels
{
    public class SigninModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage ="ارجوا ادخال الإيميل")]
        [Display(Name ="الإيميل")]
        [EmailAddress(ErrorMessage ="ارجوا ادخال الإيميل بشكل صحيح")]
        public string Email { get; set; }

        [Required(ErrorMessage = "ارجوا ادخال كلمة المرور")]
        [Display(Name = "كلمة المرور")]
        [DataType(DataType.Password)]
       
        public string Password { get; set; }

    }
}
