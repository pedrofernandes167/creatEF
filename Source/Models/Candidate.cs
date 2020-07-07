using Codenation.Challenge.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Source.Models
{
    [Table("candidate")]
    public class Candidate
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public Acceleration Acceleration_Id { get; set; }
        public Company Company_Id { get; set; }
        public int Status { get; set; }
        public DateTime Created_At { get; set; }

        public Candidate()
        {
        }

        public Candidate(int id, Acceleration acceleration_Id, Company company_Id, int status, DateTime created_At)
        {
            Id = id;
            Acceleration_Id = acceleration_Id;
            Company_Id = company_Id;
            Status = status;
            Created_At = created_At;
        }
    }
}
