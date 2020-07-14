using System;
using System.Collections.Generic;

namespace Codenation.Challenge.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Full_Name { get; set; }
        public string Email { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public DateTime Created_At { get; set; }

        public List<Candidate> Candidates { get; set; }
        public List<Submission> Submissions { get; set; }
    }
}