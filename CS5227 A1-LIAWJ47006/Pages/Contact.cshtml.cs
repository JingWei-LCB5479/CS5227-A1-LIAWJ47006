using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Threading.Tasks;

namespace CS5227_A1_LIAWJ47006.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public ContactFormModel Contact { get; set; }

        public string ResultMessage { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Simulate email sending (implement your actual email sending logic here)
            try
            {
                var mailMessage = new MailMessage
                {
                    From = new MailAddress(Contact.Email),
                    Subject = "Contact Form Submission",
                    Body = $"Name: {Contact.Name}\nEmail: {Contact.Email}\nMessage: {Contact.Message}",
                    IsBodyHtml = false,
                };
                mailMessage.To.Add("your-email@gmail.com"); // Replace with your receiving email address

                using (var smtpClient = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtpClient.Credentials = new System.Net.NetworkCredential("your-email@gmail.com", "your-password-or-app-specific-password");
                    smtpClient.EnableSsl = true;
                    await smtpClient.SendMailAsync(mailMessage);
                }

                ResultMessage = "Your message has been sent successfully!";
            }
            catch
            {
                ResultMessage = "An error occurred while sending your message. Please try again later.";
            }

            return Page();
        }

    }

    public class ContactFormModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
