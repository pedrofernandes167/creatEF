using Source.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codenation.Challenge.Models
{
    [Table("company")]
    public class Company
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public DateTime Created_At { get; set; }
        public List<Candidate> Candidates { get; set; } = new List<Candidate>();

        public Company()
        {
        }

        public Company(int id, string name, string slug, DateTime created_At)
        {
            Id = id;
            Name = name;
            Slug = slug;
            Created_At = created_At;
        }
    }
}