using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CS5227_A1_LIAWJ47006.Areas.Identity.Data;
using CS5227_A1_LIAWJ47006.Model;
using System.Collections.Generic;
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
        }
    }
}
