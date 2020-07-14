using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codenation.Challenge.Models
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> user)
        {
            user.ToTable("user");

            user.HasKey(u => u.Id)
                .HasName("user_id");

            user.Property(u => u.Id)
                .HasColumnName("id")
                .IsRequired();

            user.Property(u => u.Full_Name)
                .HasColumnName("full_name")
                .HasMaxLength(100)
                .IsRequired();

            user.Property(u => u.Email)
                .HasColumnName("email")
                .HasMaxLength(100)
                .IsRequired();

            user.Property(u => u.Nickname)
                .HasColumnName("nickname")
                .HasMaxLength(50)
                .IsRequired();

            user.Property(u => u.Password)
                .HasColumnName("password")
                .HasMaxLength(255)
                .IsRequired();

            user.Property(u => u.Created_At)
                .HasColumnName("created_at")
                .IsRequired();

            user.HasMany(u => u.Candidates)
                .WithOne();

            user.HasMany(u => u.Submissions)
                .WithOne();
        }
    }
}
