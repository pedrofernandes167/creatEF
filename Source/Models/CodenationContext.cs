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
            base.OnModelCreating(mb);
            new UserConfig(mb.Entity<User>());
            new SubmissionConfig(mb.Entity<Submission>());
            new ChallengeConfig(mb.Entity<Challenge>());
            new AccelerationConfig(mb.Entity<Acceleration>());
            new CompanyConfig(mb.Entity<Company>());
            new CandidateConfig(mb.Entity<Candidate>());
        }
    }
}