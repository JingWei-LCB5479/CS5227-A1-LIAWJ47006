using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CS5227_A1_LIAWJ47006.Areas.Identity.Data;
using CS5227_A1_LIAWJ47006.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CS5227_A1_LIAWJ47006.Pages
{
    [Authorize]
    public class CheckoutModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Menu> CartItems { get; set; }
        public decimal TotalPrice { get; set; }

        public async Task OnGetAsync()
        {
            // For demonstration, let's assume the cart items are fetched from the database
            // This would normally be managed by session or user-specific cart in the database
            CartItems = await _context.Menus.ToListAsync();
            TotalPrice = CartItems.Sum(item => (decimal)item.Price);
        }

        public async Task<IActionResult> OnPostPurchaseAsync()
        {
            // Simulate the purchase process (clear the cart and save the transaction)
            CartItems = await _context.Menus.ToListAsync();
            _context.Menus.RemoveRange(CartItems); // Clear the cart items
            await _context.SaveChangesAsync();

            // Simulate saving a purchase history
            // For simplicity, this step is not fully implemented

            return RedirectToPage("/Index");
        }
    }
}
