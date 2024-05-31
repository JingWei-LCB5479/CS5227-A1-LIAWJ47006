using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CS5227_A1_LIAWJ47006.Areas.Identity.Data;
using CS5227_A1_LIAWJ47006.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace CS5227_A1_LIAWJ47006.Pages
{
    public class MenuModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public MenuModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Menu> Appetizers { get; set; }
        public IList<Menu> MainCourses { get; set; }
        public IList<Menu> SideDishes { get; set; }
        public IList<Menu> Desserts { get; set; }
        public IList<Menu> Beverages { get; set; }
        
        [TempData]
        public string ErrorMessage { get; set; } // Ensure this property is public and accessible

        public async Task OnGetAsync()
        {
            var allMenus = await _context.Menus.ToListAsync();

            Appetizers = allMenus.Where(m => m.Category == "Appetizers").ToList();
            MainCourses = allMenus.Where(m => m.Category == "Main Courses").ToList();
            SideDishes = allMenus.Where(m => m.Category == "Side Dishes").ToList();
            Desserts = allMenus.Where(m => m.Category == "Desserts").ToList();
            Beverages = allMenus.Where(m => m.Category == "Beverages").ToList();
        }

        public async Task<IActionResult> OnPostAddToCartAsync(int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                TempData["ErrorMessage"] = "You need to log in first to add items to the cart.";
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }

            var menu = await _context.Menus.FindAsync(id);
            if (menu == null)
            {
                return NotFound();
            }

            var userId = User.Identity.Name; // Assume user is authenticated
            var cart = await _context.Carts.Include(c => c.CartItems).FirstOrDefaultAsync(c => c.UserId == userId);

            if (cart == null)
            {
                cart = new Cart
                {
                    UserId = userId,
                    CartItems = new List<CartItem>()
                };
                _context.Carts.Add(cart);
            }

            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.MenuId == id);
            if (cartItem != null)
            {
                cartItem.Quantity++;
            }
            else
            {
                cartItem = new CartItem
                {
                    MenuId = id,
                    Menu = menu,
                    Price = menu.Price, // Assume Menu has a Price property
                    Quantity = 1,
                    ImageUrl = menu.ImageUrl // Set ImageUrl here
                };
                cart.CartItems.Add(cartItem);
            }

            await _context.SaveChangesAsync();
            return RedirectToPage();
        }
    }
}
