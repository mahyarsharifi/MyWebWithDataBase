using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWeb.Models;

namespace MyWeb.Pages
{
    public class CreateBlogModel : PageModel
    {
        public CreateBlog Command;

        [TempData]
        public string ErrorMessage { get; set; }

        private readonly MyWebConext _conext;
        public CreateBlogModel(MyWebConext conext)
        {
            _conext = conext;
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost(CreateBlog command)
        {
            if (ModelState.IsValid)
            {
                var blog = new Blog(command.Title, command.Picture, command.PictureAlt, command.PictureTitle, command.ShortDescription, command.Description);
                _conext.Blogs.Add(blog);
                _conext.SaveChanges();
                return RedirectToPage("/Index");
            }
            else
            {
                ErrorMessage = "ایجاد مقاله با شکست مواجه شد";
                return Page();
            }
        }
    }
}
