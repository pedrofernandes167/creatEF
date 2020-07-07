using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Source.Models
{
    [Table("Acceleration")]
    public class Acceleration
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public DateTime Created_At { get; set; }
        public Challenge Challenge_Id { get; } = new Challenge();
        public List<Candidate> Candidates { get; set; } = new List<Candidate>();

        public Acceleration()
        {
        }

        public Acceleration(int id, string name, string slug, DateTime created_At, Challenge challenge)
        {
            Id = id;
            Name = name;
            Slug = slug;
            Created_At = created_At;
            Challenge_Id = challenge;
        }
    }
}
