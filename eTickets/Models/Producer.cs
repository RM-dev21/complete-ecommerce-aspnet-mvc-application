using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public String ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationships (one producer can have multiple movies
        public List<Movie> Movies { get; set; }
    }
}
