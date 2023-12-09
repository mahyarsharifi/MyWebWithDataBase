using System.ComponentModel.DataAnnotations;

namespace MyWeb.Models
{
    public class CreateProject
    {
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [Display(Name = "نام پروژه")]
        public string Name { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        [Display(Name = "عکس")]
        public string Picture { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        [Display(Name = "Alt عکس")]
        public string PictureAlt { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        [Display(Name = "Title عکس")]
        public string PictureTitle { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        [Display(Name = "توضیحات")]
        public string Description { get; set; }
    }
}
