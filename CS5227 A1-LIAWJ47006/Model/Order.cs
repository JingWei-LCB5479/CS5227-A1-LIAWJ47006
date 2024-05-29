using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CS5227_A1_LIAWJ47006.Model
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public string UserId { get; set; }

        public DateTime OrderDate { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }

    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public int MenuId { get; set; }

        public Order Order { get; set; }

        public Menu Menu { get; set; }
    }
}
