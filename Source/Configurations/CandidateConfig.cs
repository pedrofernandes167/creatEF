using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codenation.Challenge.Models
{
    public class CandidateConfig : IEntityTypeConfiguration<Candidate>
    {
        public CandidateConfig(EntityTypeBuilder<Candidate> entityTypeBuilder)
        {
            EntityTypeBuilder = entityTypeBuilder;
        }

        public EntityTypeBuilder<Candidate> EntityTypeBuilder { get; }

        public void Configure(EntityTypeBuilder<Candidate> cand)
        {
            cand.ToTable("candidate");

            //cand.HasKey(c => c.User.Id);
            //cand.HasKey(c => c.Acceleration.Id);
            //cand.HasKey(c => c.Company.Id);

            cand.Property(c => c.User.Id).HasColumnName("user_id").IsRequired();
            cand.Property(c => c.Acceleration.Id).HasColumnName("acceleration_id").IsRequired();
            cand.Property(c => c.Company.Id).HasColumnName("company_id").IsRequired();

            cand.Property(c => c.Status).HasColumnName("status").IsRequired();
            cand.Property(c => c.Created_At).HasColumnName("created_at").IsRequired();

            cand.HasOne(c => c.User).WithMany(u => u.Candidates).HasForeignKey(u => u.User.Id);
            cand.HasOne(c => c.Acceleration).WithMany(a => a.Candidates).HasForeignKey(a => a.Acceleration.Id);
            cand.HasOne(c => c.Company).WithMany(y => y.Candidates).HasForeignKey(c => c.Company.Id);
        }
    }
}
