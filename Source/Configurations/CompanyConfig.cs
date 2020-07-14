using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codenation.Challenge.Models
{
    public class CompanyConfig : IEntityTypeConfiguration<Company>
    {
        public CompanyConfig(EntityTypeBuilder<Company> entityTypeBuilder)
        {
            EntityTypeBuilder = entityTypeBuilder;
        }

        public EntityTypeBuilder<Company> EntityTypeBuilder { get; }

        public void Configure(EntityTypeBuilder<Company> comp)
        {
            comp.ToTable("company");

            comp.HasKey(c => c.Id);

            comp.Property(c => c.Id).HasColumnName("id").IsRequired();
            comp.Property(c => c.Name).HasColumnName("name").HasMaxLength(100).IsRequired();
            comp.Property(c => c.Slug).HasColumnName("slug").HasMaxLength(50).IsRequired();
            comp.Property(c => c.Created_At).HasColumnName("created_at").IsRequired();

            comp.HasMany(c => c.Candidates).WithOne();
        }
    }
}
