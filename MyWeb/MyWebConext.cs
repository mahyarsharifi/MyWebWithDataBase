using Microsoft.EntityFrameworkCore;
using MyWeb.Mapping;
using MyWeb.Models;

namespace MyWeb
{
    public class MyWebConext : DbContext
    {
        public DbSet<ContactMe> ContactMes { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public MyWebConext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContactMeMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
