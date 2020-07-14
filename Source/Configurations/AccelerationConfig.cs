using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codenation.Challenge.Models
{
    public class AccelerationConfig : IEntityTypeConfiguration<Acceleration>
    {
        public AccelerationConfig(EntityTypeBuilder<Acceleration> entityTypeBuilder)
        {
            EntityTypeBuilder = entityTypeBuilder;
        }

        public EntityTypeBuilder<Acceleration> EntityTypeBuilder { get; }

        public void Configure(EntityTypeBuilder<Acceleration> acel)
        {
            acel.ToTable("acceleration");

            acel.HasKey(a => a.Id);

            acel.Property(a => a.Id).HasColumnName("id").IsRequired();
            acel.Property(a => a.Name).HasColumnName("name").HasMaxLength(100).IsRequired();
            acel.Property(a => a.Slug).HasColumnName("slug").HasMaxLength(50).IsRequired();
            acel.Property(a => a.Created_At).HasColumnName("created_at").IsRequired();

            acel.HasMany(a => a.Candidates).WithOne();
            acel.HasOne(a => a.Challenge).WithMany(c => c.Accelerations).HasForeignKey(c => c.Challenge.Id);
        }
    }
}
