using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentalApp.Models
{
    public class Movie
    {
        [StringLength(255),Required]
        public string Name { get; set; }
        public int Id { get; set; }
        public Genre Genre { get; set; }
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }
        [Display(Name = "Date Of Release"),Required,DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Number Of Stock"), Range(1, 20)]
        public byte NumberInStock { get; set; }
        public byte NumberAvailable { get; set; }
    }
}
