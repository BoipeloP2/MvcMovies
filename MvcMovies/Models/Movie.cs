using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovies.Models
{
    public class Movie
    {
        public int id { get; set; }

        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }


        public string Genre { get; set; }

        //[Column(TypeName = "decimal(18, 2)")]
        public  int Price { get; set; }

        [Display(Name = "Rating(5 out of 7 is best!)")]
        public string Rating { get; set; }


    }
}
