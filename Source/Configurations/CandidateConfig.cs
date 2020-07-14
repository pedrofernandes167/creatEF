using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codenation.Challenge.Models
{
    public class CandidateConfig : IEntityTypeConfiguration<Candidate>
    {
        public void Configure(EntityTypeBuilder<Candidate> cand)
        {
            cand.ToTable("candidate");

            cand.HasKey(c => c.Id)
                .HasName("candidate_id");

            cand.Property(c => c.User_Id)
                .HasColumnName("user_id")
                .IsRequired();

            cand.Property(c => c.Acceleration_Id)
                .HasColumnName("acceleration_id")
                .IsRequired();

            cand.Property(c => c.Company_Id)
                .HasColumnName("company_id")
                .IsRequired();

            cand.Property(c => c.Status)
                .HasColumnName("status")
                .IsRequired();

            cand.Property(c => c.Created_At)
                .HasColumnName("created_at")
                .IsRequired();

            cand.HasOne(c => c.Acceleration)
                .WithMany(a => a.Candidates)
                .HasForeignKey("acceleration_id");

            cand.HasOne(c => c.Company)
                .WithMany(y => y.Candidates)
                .HasForeignKey("company_id");

            cand.HasOne(c => c.User)
                .WithMany(u => u.Candidates)
                .HasForeignKey("user_id");
        }
    }
}
