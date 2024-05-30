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
    public class CartModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CartModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<CartItem> CartItems { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var userId = User.Identity.Name; // Assume user is authenticated
            var cart = await _context.Carts
                .Include(c => c.CartItems)
                .ThenInclude(ci => ci.Menu)
                .FirstOrDefaultAsync(c => c.UserId == userId);

            if (cart == null)
            {
                CartItems = new List<CartItem>();
            }
            else
            {
                CartItems = cart.CartItems;
            }

            return Page();
        }

        public async Task<IActionResult> OnPostUpdateQuantityAsync(int id, string operation)
        {
            var cartItem = await _context.CartItems.FindAsync(id);

            if (cartItem != null)
            {
                if (operation == "increase")
                {
                    cartItem.Quantity++;
                }
                else if (operation == "decrease" && cartItem.Quantity > 1)
                {
                    cartItem.Quantity--;
                }

                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostRemoveItemAsync(int id)
        {
            var cartItem = await _context.CartItems.FindAsync(id);

            if (cartItem != null)
            {
                _context.CartItems.Remove(cartItem);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostCheckoutAsync()
        {
            var userId = User.Identity.Name; // Assume user is authenticated
            var cart = await _context.Carts
                .Include(c => c.CartItems)
                .ThenInclude(ci => ci.Menu)
                .FirstOrDefaultAsync(c => c.UserId == userId);

            if (cart != null)
            {
                // Redirect to the Checkout page
                return RedirectToPage("/Checkout");
            }

            return Page();
        }
    }
}
