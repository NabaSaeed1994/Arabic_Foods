﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels
{
    public class PortfolioViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "الرجاء إضافة اسم الصنف")]
        [Display (Name ="اسم الصنف")]
        public string ProjectName { get; set; }

        [Required(ErrorMessage = "الرجاء إضافة وصف للصنف")]
        [Display(Name = "وصف الصنف")]
        public string Description { get; set; }

        
        [Display(Name = "صورة الصنف")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "الرجاء إضافة طريقة التواصل")]
        [Display(Name = "طريقة التواصل")]
        public string Contact { get; set; }


        public IFormFile File { get; set; }
    }
}
