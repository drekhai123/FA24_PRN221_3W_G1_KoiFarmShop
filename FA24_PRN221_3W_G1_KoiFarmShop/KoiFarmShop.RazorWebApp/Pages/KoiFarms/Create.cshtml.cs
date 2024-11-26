using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KoiFarmShop.Repositories.Models;

namespace KoiFarmShop.RazorWebApp.Pages.KoiFarms
{
    public class CreateModel : PageModel
    {
        private readonly KoiFarmShop.Repositories.Models.FA24_PRN221_3W_G1_KoiFarmShopContext _context;

        public CreateModel(KoiFarmShop.Repositories.Models.FA24_PRN221_3W_G1_KoiFarmShopContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public KoiFarm KoiFarm { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.KoiFarms.Add(KoiFarm);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
