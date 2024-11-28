using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KoiFarmShop.Repositories.Models;
using KoiFarmShop.Services;

namespace KoiFarmShop.RazorWebApp.Pages.KoiFarms
{
    public class IndexModel : PageModel
    {
        private readonly KoiFarmService _koiFarmService;
        private readonly AccountService _accountService;
        public IndexModel(KoiFarmService koiFarmService, AccountService accountService)
        {
            _koiFarmService = koiFarmService;
            _accountService = accountService;
        }

        public IList<KoiFarm> KoiFarm { get;set; } = default!;

        public async Task OnGetAsync()
        {
            //KoiFarm = await _context.KoiFarms
            //    .Include(k => k.Owner).ToListAsync();

            KoiFarm = await _koiFarmService.GetAll();
            
        }
    }
}
