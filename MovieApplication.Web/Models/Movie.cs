using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApplication.Web.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public int? DirectorId { get; set; }
        public string MovieName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Director Director { get; set; } 
    }
}
