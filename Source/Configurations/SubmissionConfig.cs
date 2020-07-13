using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codenation.Challenge.Models
{
    public class SubmissionConfig : IEntityTypeConfiguration<Submission>
    {
        public SubmissionConfig(EntityTypeBuilder<Submission> entityTypeBuilder)
        {
        }

        public void Configure(EntityTypeBuilder<Submission> sub)
        {
            sub.ToTable("submission");

            sub.HasKey(s => s.User.User_Id);
            sub.HasKey(s => s.Challenge.Challenge_Id);

            sub.Property(s => s.Id).HasColumnName("id").IsRequired();

            sub.Property(s => s.User.User_Id).HasColumnName("user_id").IsRequired();
            sub.Property(s => s.Challenge.Challenge_Id).HasColumnName("challenge_id").IsRequired();

            sub.Property(s => s.Score).HasColumnName("score").IsRequired();
            sub.Property(s => s.Created_At).HasColumnName("created_at").IsRequired();

            sub.HasOne(s => s.Challenge).WithMany(c => c.Submissions);
            sub.HasOne(s => s.User).WithMany(u => u.Submissions);
        }
    }
}
