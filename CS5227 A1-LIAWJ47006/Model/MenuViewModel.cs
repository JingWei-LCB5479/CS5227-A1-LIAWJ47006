using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace CS5227_A1_LIAWJ47006.Model
{
    public class MenuViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public float Price { get; set; }

        public IFormFile Image { get; set; }

        public string Category { get; set; }
    }
}
