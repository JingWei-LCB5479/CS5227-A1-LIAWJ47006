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

        public IList<Menu> Appetizers { get; set; }
        public IList<Menu> MainCourses { get; set; }
        public IList<Menu> SideDishes { get; set; }
        public IList<Menu> Desserts { get; set; }
        public IList<Menu> Beverages { get; set; }

        public async Task OnGetAsync()
        {
            var allMenus = await _context.Menus.ToListAsync();

            Appetizers = allMenus.Where(m => m.Category == "Appetizers").ToList();
            MainCourses = allMenus.Where(m => m.Category == "Main Courses").ToList();
            SideDishes = allMenus.Where(m => m.Category == "Side Dishes").ToList();
            Desserts = allMenus.Where(m => m.Category == "Desserts").ToList();
            Beverages = allMenus.Where(m => m.Category == "Beverages").ToList();
        }
    }
}
