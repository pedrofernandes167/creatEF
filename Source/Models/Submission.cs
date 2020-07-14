using System;

namespace Codenation.Challenge.Models
{
    public class Submission
    {
        public int Id { get; set; }

        public int User_Id { get; set; }
        public User User { get; set; }
        public int Challenge_Id { get; set; }
        public Challenge Challenge { get; set; }

        public decimal Score { get; set; }
        public DateTime Created_At { get; set; }
    }
}