using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CS5227_A1_LIAWJ47006.Areas.Identity.Data;
using CS5227_A1_LIAWJ47006.Model;
using System.IO;
using System.Threading.Tasks;

namespace CS5227_A1_LIAWJ47006.Pages.Admin
{
    [Authorize(Roles = "admin")]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CreateModel(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        [BindProperty]
        public MenuViewModel MenuViewModel { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var fileName = string.Empty;
            if (MenuViewModel.Image != null)
            {
                var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                fileName = Guid.NewGuid().ToString() + "_" + MenuViewModel.Image.FileName;
                var filePath = Path.Combine(uploadsFolder, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await MenuViewModel.Image.CopyToAsync(fileStream);
                }
            }

            var menu = new Menu
            {
                Name = MenuViewModel.Name,
                Description = MenuViewModel.Description,
                Price = MenuViewModel.Price,
                ImageUrl = fileName,
                Category = MenuViewModel.Category // Add this assignment
            };

            _context.Menus.Add(menu);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Admin/Admin");
        }
    }
}
