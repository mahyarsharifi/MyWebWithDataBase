using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MyWeb.Models
{
    public class CreateContactMe
    {
        [Required(ErrorMessage = "لطفا نام خود را وارد کنید")]
        [Display(Name = "نام")]
        public string Name { get; set; }

        [Required(ErrorMessage = "لطفا ایمیل خود را وارد کنید")]
        [Display(Name = "ایمیل")]
        public string Email { get; set; }

        [Required(ErrorMessage = "لطفا پیغام خود را وارد کنید")]
        [Display(Name = "پیغام")]
        public string Message { get; set; }
    }
}
