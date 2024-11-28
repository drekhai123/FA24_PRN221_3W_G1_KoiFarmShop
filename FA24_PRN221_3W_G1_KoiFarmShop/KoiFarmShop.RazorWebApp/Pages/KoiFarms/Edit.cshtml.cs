using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KoiFarmShop.Repositories.Models;
using KoiFarmShop.Services;

namespace KoiFarmShop.RazorWebApp.Pages.KoiFarms
{
    public class EditModel : PageModel
    {
        //private readonly KoiFarmShop.Repositories.Models.FA24_PRN221_3W_G1_KoiFarmShopContext _context;

        //public EditModel(KoiFarmShop.Repositories.Models.FA24_PRN221_3W_G1_KoiFarmShopContext context)
        //{
        //    _context = context;
        //}

        private readonly KoiFarmService _koiFarmService;
        private readonly AccountService _accountService;
        public EditModel(KoiFarmService koiFarmService, AccountService accountService)
        {
            _koiFarmService = koiFarmService;
            _accountService = accountService;
        }
        [BindProperty]
        public KoiFarm KoiFarm { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var koifarm =  await _koiFarmService.GetById((int)id);
            if (koifarm == null)
            {
                return NotFound();
            }
            KoiFarm = koifarm;
            ViewData["OwnerId"] = new SelectList(await _accountService.GetAll(), "Id", "FullName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //_context.Attach(KoiFarm).State = EntityState.Modified;
            try
            {
                await _koiFarmService.Update(KoiFarm);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KoiFarmExists(KoiFarm.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool KoiFarmExists(int id)
        {
            //return _context.KoiFarms.Any(e => e.Id == id);
            return _koiFarmService.GetById(id) != null;
        }
    }
}
