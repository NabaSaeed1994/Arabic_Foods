﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels
{
    public class SignupModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "ارجوا ادخال الإيميل")]
        [Display(Name = "الإيميل")]
        [EmailAddress(ErrorMessage = "ارجوا ادخال الإيميل بشكل صحيح")]
        public string Email { get; set; }


        [Required(ErrorMessage = "ارجوا ادخال كلمة المرور")]
        [Compare("ConfirmPassword" , ErrorMessage ="كلمة المرور غير متطابقة ")]
        [Display(Name = "كلمة المرور")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "ارجوا ادخال كلمة المرور")]
        [Display(Name = "كلمة المرور")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
