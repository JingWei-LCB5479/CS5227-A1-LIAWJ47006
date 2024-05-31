using System.ComponentModel.DataAnnotations;

namespace CS5227_A1_LIAWJ47006.Model
{
    public class ContactModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Message")]
        public string Message { get; set; }
    }
}
