using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codenation.Challenge.Models
{
    public class ChallengeConfig : IEntityTypeConfiguration<Challenge>
    {
        public void Configure(EntityTypeBuilder<Challenge> chal)
        {
            chal.ToTable("challenge");

            chal.HasKey(c => c.Id)
                .HasName("challenge_id");

            chal.Property(c => c.Id)
                .HasColumnName("id")
                .IsRequired();

            chal.Property(c => c.Name)
                .HasColumnName("name")
                .HasMaxLength(100)
                .IsRequired();

            chal.Property(c => c.Slug)
                .HasColumnName("slug")
                .HasMaxLength(50)
                .IsRequired();

            chal.Property(c => c.Created_At)
                .HasColumnName("created_at")
                .IsRequired();

            chal.HasMany(a => a.Accelerations)
                .WithOne();

            chal.HasMany(a => a.Submissions)
                .WithOne();
        }
    }
}
