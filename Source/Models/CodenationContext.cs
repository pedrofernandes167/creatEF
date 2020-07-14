using Microsoft.EntityFrameworkCore;

namespace Codenation.Challenge.Models
{
    public class CodenationContext : DbContext
    {
        public DbSet<Acceleration> Accelerations { get; set; }
        public DbSet<Challenge> Challenges { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Submission> Submissions { get; set; }
        public DbSet<Candidate> Candidates { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Codenation;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.ApplyConfiguration(new UserConfig());
            mb.ApplyConfiguration(new SubmissionConfig());
            mb.ApplyConfiguration(new ChallengeConfig());
            mb.ApplyConfiguration(new AccelerationConfig());
            mb.ApplyConfiguration(new CompanyConfig());
            mb.ApplyConfiguration(new CandidateConfig());
        }
    }
}