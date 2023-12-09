using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWeb.Models;

namespace MyWeb.Pages
{
    public class ContactMeModel : PageModel
    {
        public CreateContactMe Command;

        [TempData]
        public string SuccessMessage { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        private readonly MyWebConext _conext;

        public ContactMeModel(MyWebConext conext)
        {
            _conext = conext;
        }

        public void OnGet()
        {
        }
        public void OnPost(CreateContactMe command)
        {
            if (ModelState.IsValid)
            {
                var contactMe = new ContactMe(command.Name, command.Email, command.Message);
                _conext.ContactMes.Add(contactMe);
                _conext.SaveChanges();

                ModelState.Clear();
                SuccessMessage = "پیام شما با موفقیت ارسال شد";

            }
            else
            {
                ErrorMessage = "لطفا مقادیر خواسته شده را تکمیل نمایید";
            }
        }
    }
}
