using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codenation.Challenge.Models
{
    [Table("acceleration")]
    public class Acceleration
    {
        [Key]
        public int Acceleration_Id { get; set; }

        public string Name { get; set; }
        public string Slug { get; set; }
        public DateTime Created_At { get; set; }

        public Challenge Challenge { get; }
        public ICollection<Candidate> Candidates { get; set; }
    }
}