using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class MovieDto
    {

        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        [Required(ErrorMessage = "Release Date field is required")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage = "Genre field is required")]
        [Range(1, 20)]
        public int NumberInStock { get; set; }

        public byte GenreId { get; set; }
    }
}