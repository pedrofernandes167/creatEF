using System;
using System.Collections.Generic;

namespace Codenation.Challenge.Models
{
    public class Acceleration
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public DateTime Created_At { get; set; }

        public int Challenge_Id { get; set; }
        public Challenge Challenge { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}