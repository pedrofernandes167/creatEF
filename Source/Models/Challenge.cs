using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Source.Models
{
    [Table("Challenge")]
    public class Challenge
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public DateTime Created_At { get; set; }
        public List<Submission> Submissions { get; set; } = new List<Submission>();
        public List<Acceleration> Accelerations { get; set; } = new List<Acceleration>();

        public Challenge()
        {
        }

        public Challenge(int id)
        {
            Id = id;
        }

        public Challenge(int id, string name, string slug, DateTime created_At)
        {
            Id = id;
            Name = name;
            Slug = slug;
            Created_At = created_At;
        }
    }
}
