using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codenation.Challenge.Models
{
    [Table("submission")]
    public class Submission
    {
        [Key]
        public int Id { get; set; }

        public User User { get; set; }
        public Challenge Challenge { get; set; }


        public decimal Score { get; set; }
        public DateTime Created_At { get; set; }
    }
}