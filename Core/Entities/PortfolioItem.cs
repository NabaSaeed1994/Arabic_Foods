using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class PortfolioItem : EntityBase
    {
        [Required(ErrorMessage = "الرجاء إضافة اسم الصنف")]
        [Display(Name = "اسم الصنف")]
        public string ProjectName { get; set; }

        [Required(ErrorMessage = "الرجاء إضافة وصف للصنف")]
        [Display(Name = "وصف الصنف")]
        public string Description { get; set; }

        
        [Display(Name = "صورة الصنف")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "الرجاء إضافة طريقة التواصل")]
        [Display(Name = "طريقة التواصل")]
        public string Contact { get; set; }

    }
}
