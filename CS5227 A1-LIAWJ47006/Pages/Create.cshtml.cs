using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CS5227_A1_LIAWJ47006.Areas.Identity.Data;
using CS5227_A1_LIAWJ47006.Model;
using System.Threading.Tasks;

namespace CS5227_A1_LIAWJ47006.Pages.Admin
{
    [Authorize(Roles = "admin")]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Menu Menu { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Menus.Add(Menu);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Admin/Admin");
        }
    }
}
