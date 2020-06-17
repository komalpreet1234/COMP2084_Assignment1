using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApplication.Web.Models
{
    public class Director
    {
        [Key]
        public int DirectorId { get; set; }
        public string DirectorName { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
