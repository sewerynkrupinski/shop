using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Category name is required")]
        [StringLength(100)]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Category description is required")]
        [StringLength(100)]
        public string CategoryDescription { get; set; }
        public string IconFileName { get; set; }

        public virtual ICollection<Book> Books { get; set; }


    }
}