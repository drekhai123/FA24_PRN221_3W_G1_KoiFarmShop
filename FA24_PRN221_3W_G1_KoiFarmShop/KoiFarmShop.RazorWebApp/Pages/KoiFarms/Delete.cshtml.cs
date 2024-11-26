using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KoiFarmShop.Repositories.Models;

namespace KoiFarmShop.RazorWebApp.Pages.KoiFarms
{
    public class DeleteModel : PageModel
    {
        private readonly KoiFarmShop.Repositories.Models.FA24_PRN221_3W_G1_KoiFarmShopContext _context;

        public DeleteModel(KoiFarmShop.Repositories.Models.FA24_PRN221_3W_G1_KoiFarmShopContext context)
        {
            _context = context;
        }

        [BindProperty]
        public KoiFarm KoiFarm { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var koifarm = await _context.KoiFarms.FirstOrDefaultAsync(m => m.Id == id);

            if (koifarm == null)
            {
                return NotFound();
            }
            else
            {
                KoiFarm = koifarm;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var koifarm = await _context.KoiFarms.FindAsync(id);
            if (koifarm != null)
            {
                KoiFarm = koifarm;
                _context.KoiFarms.Remove(KoiFarm);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
