using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codenation.Challenge.Models
{
    public class SubmissionConfig : IEntityTypeConfiguration<Submission>
    {
        public SubmissionConfig(EntityTypeBuilder<Submission> entityTypeBuilder)
        {
            EntityTypeBuilder = entityTypeBuilder;
        }

        public EntityTypeBuilder<Submission> EntityTypeBuilder { get; }

        public void Configure(EntityTypeBuilder<Submission> sub)
        {
            sub.ToTable("submission");

            //sub.HasKey(s => s.User.Id);
            //sub.HasKey(s => s.Challenge.Id);

            sub.Property(s => s.User.Id).HasColumnName("user_id").IsRequired();
            sub.Property(s => s.Challenge.Id).HasColumnName("challenge_id").IsRequired();

            sub.Property(s => s.Score).HasColumnName("score").IsRequired();
            sub.Property(s => s.Created_At).HasColumnName("created_at").IsRequired();

            sub.HasOne(s => s.Challenge).WithMany(c => c.Submissions).HasForeignKey(c => c.Challenge.Id);
            sub.HasOne(s => s.User).WithMany(u => u.Submissions).HasForeignKey(u => u.User.Id);
        }
    }
}
