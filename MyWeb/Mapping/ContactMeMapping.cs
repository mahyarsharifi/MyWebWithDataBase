using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWeb.Models;

namespace MyWeb.Mapping
{
    public class ContactMeMapping : IEntityTypeConfiguration<ContactMe>
    {
        public void Configure(EntityTypeBuilder<ContactMe> builder)
        {
            builder.ToTable("ContactMe");
            builder.HasKey(x => x.Id);
        }
    }
}
