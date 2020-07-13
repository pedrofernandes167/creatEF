using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codenation.Challenge.Models
{
    [Table("challenge")]
    public class Challenge
    {
        [Key]
        public int Challenge_Id { get; set; }

        public string Name { get; set; }
        public string Slug { get; set; }
        public DateTime Created_At { get; set; }

        public ICollection<Acceleration> Accelerations { get; set; }
        public ICollection<Submission> Submissions { get; set; }
    }
}