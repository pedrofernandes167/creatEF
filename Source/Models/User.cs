using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codenation.Challenge.Models
{
    [Table("user")]
    public class User
    {
        [Key]
        public int User_Id { get; set; }

        public string Full_Name { get; set; }
        public string Email { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public DateTime Created_At { get; set; }


        public ICollection<Candidate> Candidates { get; set; }
        public ICollection<Submission> Submissions { get; set; }
    }
}