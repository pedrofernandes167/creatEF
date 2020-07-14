using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codenation.Challenge.Models
{
    public class ChallengeConfig : IEntityTypeConfiguration<Challenge>
    {
        public ChallengeConfig(EntityTypeBuilder<Challenge> entityTypeBuilder)
        {
            EntityTypeBuilder = entityTypeBuilder;
        }

        public EntityTypeBuilder<Challenge> EntityTypeBuilder { get; }

        public void Configure(EntityTypeBuilder<Challenge> chal)
        {
            chal.ToTable("challenge");

            chal.HasKey(c => c.Id);

            chal.Property(c => c.Id).HasColumnName("id").IsRequired();
            chal.Property(c => c.Name).HasColumnName("Name").HasMaxLength(100).IsRequired();
            chal.Property(c => c.Slug).HasColumnName("Slug").HasMaxLength(50).IsRequired();
            chal.Property(c => c.Created_At).HasColumnName("Created_at").IsRequired();

            chal.HasMany(a => a.Accelerations).WithOne();
            chal.HasMany(a => a.Submissions).WithOne();
        }
    }
}
