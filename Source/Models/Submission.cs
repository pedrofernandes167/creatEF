using System;

namespace Codenation.Challenge.Models
{
    public class Submission
    {
        public User User { get; set; }
        public Challenge Challenge { get; set; }

        public decimal Score { get; set; }
        public DateTime Created_At { get; set; }
    }
}