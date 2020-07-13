using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codenation.Challenge.Models
{
    [Table("company")]
    public class Company
    {
        [Key]
        public int Company_Id { get; set; }

        public string Name { get; set; }
        public string Slug { get; set; }
        public DateTime Created_At { get; set; }

        public ICollection<Candidate> Candidates { get; set; }
    }
}