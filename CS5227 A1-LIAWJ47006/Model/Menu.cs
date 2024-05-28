using System.ComponentModel.DataAnnotations;

namespace CS5227_A1_LIAWJ47006.Model
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public float Price { get; set; }
        public string? ImageUrl { get; set; }

    }
}
