using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codenation.Challenge.Models
{
    [Table("candidate")]
    public class Candidate
    {
        [Key]
        public int Id { get; set; }       

        public User User { get; set; }
        public Acceleration Acceleration { get; set; }
        public Company Company { get; set; }

        public int Status { get; set; }
        public DateTime Created_At { get; set; }
    }
}