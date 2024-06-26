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
    public class CheckoutModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<CartItem> CartItems { get; set; } = new List<CartItem>();

        [BindProperty]
        public Checkout Checkout { get; set; } = new Checkout();

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

        public async Task<IActionResult> OnPostProcessOrderAsync()
        {
            var userId = User.Identity.Name; // Assume user is authenticated
            var cart = await _context.Carts
                .Include(c => c.CartItems)
                .ThenInclude(ci => ci.Menu)
                .FirstOrDefaultAsync(c => c.UserId == userId);

            if (cart != null)
            {
                // Here you would process the payment and create the order
                // For simplicity, this example will just save the checkout details and clear the cart

                // Save checkout details
                _context.Add(Checkout);
                await _context.SaveChangesAsync();

                // Clear the cart
                _context.CartItems.RemoveRange(cart.CartItems);
                _context.Carts.Remove(cart);
                await _context.SaveChangesAsync();

                return RedirectToPage("/OrderConfirmation");
            }

            return Page();
        }
    }
}
