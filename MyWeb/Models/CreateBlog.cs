using System.ComponentModel.DataAnnotations;

namespace MyWeb.Models
{
    public class CreateBlog
    {
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [Display(Name = "عنوان")]
        public string Title { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        [Display(Name = "مسیر عکس")]
        public string Picture { get; set; }

        [Display(Name = "Alt عکس")]
        public string PictureAlt { get; set; }

        [Display(Name = "Title عکس")]
        public string PictureTitle { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        [Display(Name = "توضیحات کوتاه")]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        [Display(Name = "توضیحات")]
        public string Description { get; set; }
    }
}
