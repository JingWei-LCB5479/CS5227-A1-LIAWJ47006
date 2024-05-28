using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CS5227_A1_LIAWJ47006.Areas.Identity.Data;
using CS5227_A1_LIAWJ47006.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CS5227_A1_LIAWJ47006.Pages.Admin
{
    [Authorize(Roles = "admin")]
    public class AdminModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public AdminModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Menu> Menus { get; set; }

        public async Task OnGetAsync()
        {
            Menus = await _context.Menus.ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var menu = await _context.Menus.FindAsync(id);
            if (menu != null)
            {
                _context.Menus.Remove(menu);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}
