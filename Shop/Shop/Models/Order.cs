using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        [Required(ErrorMessage = "First name is required")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Street is required")]
        [StringLength(100)]
        public string Street { get; set; }
        [Required(ErrorMessage = "City is required")]
        [StringLength(100)]
        public string City { get; set; }
        [Required(ErrorMessage = "Post code is required")]
        [StringLength(6)]
        public string PostCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public decimal Value { get; set; }

        List<OrderPosition> OrderPositions { get; set; }


    }
}