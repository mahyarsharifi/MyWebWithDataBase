using Microsoft.EntityFrameworkCore;
using MyWeb.Domain.ProjectAgg;

namespace MyWeb.Infrastructure_EFCore
{
    public class MyWebContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public MyWebContext(DbContextOptions options) : base(options)
        {
        }
    }
}
