using System;
using System.Collections.Generic;

namespace Codenation.Challenge.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public DateTime Created_At { get; set; }

        public ICollection<Candidate> Candidates { get; set; }
    }
}