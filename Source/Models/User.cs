using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Source.Models
{
    [Table ("User")]
    public class User
    {
        [Key]
        [Column ("id")]
        public int Id { get; set; }
        public string Full_Name { get; set; }
        public string Email { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public DateTime Created_At { get; set; }
        public List<Candidate> Candidates { get; set; } = new List<Candidate>();
        public List<Submission> Submissions { get; set; } = new List<Submission>();

        public User()
        {
        }

        public User(int id, string full_Name, string email, string nickname, string password, DateTime created_At)
        {
            Id = id;
            Full_Name = full_Name;
            Email = email;
            Nickname = nickname;
            Password = password;
            Created_At = created_At;
        }
    }
}
