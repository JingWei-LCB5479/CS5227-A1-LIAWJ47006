using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CS5227_A1_LIAWJ47006.Areas.Identity.Data;
using CS5227_A1_LIAWJ47006.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS5227_A1_LIAWJ47006.Pages
{
    public class MenuModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public MenuModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Menu> Menus { get; set; }

        public async Task OnGetAsync()
        {
            Menus = await _context.Menus.ToListAsync();

            if (Menus == null || !Menus.Any())
            {
                ModelState.AddModelError(string.Empty, "No menu items found.");
            }
        }

        public async Task<IActionResult> OnPostAddToCartAsync(int id)
        {
            var menuItem = await _context.Menus.FindAsync(id);
            if (menuItem == null)
            {
                return NotFound();
            }

            List<int> cart;
            if (HttpContext.Session.GetObject<List<int>>("Cart") == null)
            {
                cart = new List<int>();
            }
            else
            {
                cart = HttpContext.Session.GetObject<List<int>>("Cart");
            }

            cart.Add(menuItem.Id);
            HttpContext.Session.SetObject("Cart", cart);

            return RedirectToPage();
        }
    }
}
