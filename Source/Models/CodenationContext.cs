using Microsoft.AspNetCore.Server.Kestrel.Https.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System.Data.Entity;

namespace Codenation.Challenge.Models
{
    public class CodenationContext : DbContext
    {
        public DbSet<Acceleration> Accelerations { get; set; }
        public DbSet<Challenge> Challenges { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Submission> Submissions { get; set; }
        public DbSet<Candidate> Candidates { get; set; }

        public CodenationContext(DbSet<Acceleration> accelerations, DbSet<Challenge> challenges, DbSet<Company> companies, DbSet<Submission> submissions, DbSet<Candidate> candidates, DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Codenation;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new UserConfig(modelBuilder.Entity<User>());
            new SubmissionConfig(modelBuilder.Entity<Submission>());
            new ChallengeConfig(modelBuilder.Entity<Challenge>());
            new AccelerationConfig(modelBuilder.Entity<Acceleration>());
            new CompanyConfig(modelBuilder.Entity<Company>());
            new CandidateConfig(modelBuilder.Entity<Candidate>());
        }
    }
}