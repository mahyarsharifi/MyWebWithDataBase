using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWeb.Models;

namespace MyWeb.Pages
{
    public class CreateProjectModel : PageModel
    {
        public CreateProject Command;

        [TempData]
        public string ErrorMessage { get; set; }

        private readonly MyWebConext _conext;

        public CreateProjectModel(MyWebConext conext)
        {
            _conext = conext;
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost(CreateProject command)
        {
            if (ModelState.IsValid)
            {
                var project = new Project(command.Name, command.Picture, command.PictureAlt, command.PictureTitle, command.Description);
                _conext.Projects.Add(project);
                _conext.SaveChanges();
                return RedirectToPage("/Index");
            }
            else
            {
                ErrorMessage = "ثبت پروژه با خطا مواجه شد";
                return Page();
            }
        }
    }
}
