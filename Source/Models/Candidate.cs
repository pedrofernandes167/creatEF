using System;

namespace Codenation.Challenge.Models
{
    public class Candidate
    {   
        public User User { get; set; }
        public Acceleration Acceleration { get; set; }
        public Company Company { get; set; }

        public int Status { get; set; }
        public DateTime Created_At { get; set; }
    }
}