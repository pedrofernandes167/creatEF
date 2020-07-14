using System;

namespace Codenation.Challenge.Models
{
    public class Candidate
    {
        public int Id { get; set; }

        public int User_Id { get; set; }
        public User User { get; set; }

        public int Acceleration_Id { get; set; }
        public Acceleration Acceleration { get; set; }

        public int Company_Id { get; set; }
        public Company Company { get; set; }

        public int Status { get; set; }
        public DateTime Created_At { get; set; }
    }
}