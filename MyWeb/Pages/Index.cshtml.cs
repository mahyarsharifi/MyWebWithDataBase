using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWeb.Models;

namespace MyWeb.Pages
{
    public class IndexModel : PageModel
    {
        public List<ProjectViewModel> Projects;
        public List<BlogViewModel> Blogs;

        private readonly MyWebConext _conext;
        public IndexModel(MyWebConext conext)
        {
            _conext = conext;
        }

        public void OnGet()
        {
            Projects = _conext.Projects.Select(p => new ProjectViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Picture = p.Picture,
                PictureAlt = p.PictureAlt,
                PictureTitle = p.PictureTitle
            }).OrderByDescending(x => x.Id).ToList();

            Blogs = _conext.Blogs.Select(p => new BlogViewModel
            {
                Id = p.Id,
                Title = p.Title,
                Description = p.Description,
                Picture = p.Picture,
                PictureAlt = p.PictureAlt,
                PictureTitle = p.PictureTitle,
                ShortDescription = p.ShortDescription
            }).OrderByDescending(x => x.Id).ToList();
        }
    }
}