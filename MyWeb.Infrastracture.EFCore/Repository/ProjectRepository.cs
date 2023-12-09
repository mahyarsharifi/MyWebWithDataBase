using MyWeb.Domain.ProjectAgg;
using MyWeb.Infrastructure_EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.Infrastracture.EFCore.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly MyWebContext _context;

        public ProjectRepository(MyWebContext context)
        {
            _context = context;
        }

        public void Create(Project project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
