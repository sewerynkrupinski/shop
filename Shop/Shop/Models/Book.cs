using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Book title is required")]
        [StringLength(100)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Author is required")]
        [StringLength(100)]
        public string Author { get; set; }
        public DateTime Date { get; set; }
        [StringLength(100)]
        public string ImgFilename { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Bestseller { get; set; }
        public bool Hidden { get; set; }

        public virtual Category Category { get; set; }

    }
}