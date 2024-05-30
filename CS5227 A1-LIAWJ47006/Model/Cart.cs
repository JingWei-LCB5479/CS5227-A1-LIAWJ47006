using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CS5227_A1_LIAWJ47006.Model
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public List<CartItem> CartItems { get; set; }
    }

    public class CartItem
    {
        [Key]
        public int Id { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public int CartId { get; set; }
        public Cart Cart { get; set; }
        public string ImageUrl { get; set; }
    }
}
