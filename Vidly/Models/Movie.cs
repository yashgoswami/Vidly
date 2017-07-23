using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        [Required(ErrorMessage = "Release Date field is required")]
        [Display(Name ="Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage ="Genre field is required")]
        [Range(1, 20)]
        [Display(Name ="Number in Stock")]
        public int NumberInStock { get; set; }
        
        // Navigation property
        public Genre Genre { get; set; }

        // Foreign key

        [Display(Name = "Genre")]
        public byte GenreId { get; set; }
    }

    // /movies/random
}