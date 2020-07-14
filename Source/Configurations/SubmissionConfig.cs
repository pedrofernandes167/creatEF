using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codenation.Challenge.Models
{
    public class SubmissionConfig : IEntityTypeConfiguration<Submission>
    {
        public void Configure(EntityTypeBuilder<Submission> sub)
        {
            sub.ToTable("submission");

            sub.HasKey(s => s.Id)
                .HasName("submission_id");

            sub.Property(s => s.Score)
                .HasColumnName("score")
                .IsRequired();

            sub.Property(s => s.Created_At)
                .HasColumnName("created_at")
                .IsRequired();

            sub.Property(s => s.User_Id)
                .HasColumnName("user_id")
                .IsRequired();

            sub.Property(s => s.Challenge_Id)
                .HasColumnName("challenge_id")
                .IsRequired();

            sub.HasOne(s => s.Challenge)
                .WithMany(c => c.Submissions)
                .HasForeignKey("challenge_id");

            sub.HasOne(s => s.User)
                .WithMany(u => u.Submissions)
                .HasForeignKey("user_id");
        }
    }
}
