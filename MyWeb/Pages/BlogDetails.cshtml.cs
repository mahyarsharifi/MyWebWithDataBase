using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWeb.Models;

namespace MyWeb.Pages
{
    public class BlogDetailsModel : PageModel
    {
        public BlogViewModel Blog;
        private readonly MyWebConext _conext;
        public BlogDetailsModel(MyWebConext conext)
        {
            _conext = conext;
        }

        public void OnGet(int id)
        {
            Blog = _conext.Blogs.Select(x => new BlogViewModel
            {
                Id = x.Id,
                Description = x.Description,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Title = x.Title,
            }).FirstOrDefault(x => x.Id == id);
        }
    }
}
