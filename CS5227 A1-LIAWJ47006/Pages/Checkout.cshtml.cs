using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CS5227_A1_LIAWJ47006.Areas.Identity.Data;
using CS5227_A1_LIAWJ47006.Model;
using System;
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
        private readonly UserManager<ApplicationUser> _userManager;

        public CheckoutModel(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IList<Menu> CartItems { get; set; }
        public decimal TotalPrice { get; set; }

        public async Task OnGetAsync()
        {
            List<int> cart = HttpContext.Session.GetObject<List<int>>("Cart") ?? new List<int>();
            CartItems = await _context.Menus.Where(m => cart.Contains(m.Id)).ToListAsync();
            TotalPrice = CartItems.Sum(item => (decimal)item.Price);
        }

        public async Task<IActionResult> OnPostPurchaseAsync()
        {
            var userId = _userManager.GetUserId(User);
            var order = new Order
            {
                UserId = userId,
                OrderDate = DateTime.Now,
                OrderItems = new List<OrderItem>()
            };

            List<int> cart = HttpContext.Session.GetObject<List<int>>("Cart") ?? new List<int>();
            foreach (var menuId in cart)
            {
                order.OrderItems.Add(new OrderItem { MenuId = menuId });
            }

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            // Clear the session cart
            HttpContext.Session.Remove("Cart");

            return RedirectToPage("/Index");
        }
    }
}
