using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Source.Models
{
    [Table ("Submission")]
    public class Submission
    {
        public int User_Id { get; set; };
        public Challenge Challenge_Id { get; set; } = new Challenge();
        public float Score { get; set; }
        public DateTime Created_At { get; set; }

        public Submission()
        {
        }

        public Submission(float score, DateTime created_At)
        {
            Score = score;
            Created_At = created_At;
        }
    }
}
