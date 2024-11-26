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
        //private readonly KoiFarmShop.Repositories.Models.FA24_PRN221_3W_G1_KoiFarmShopContext _context;
        //public IndexModel(KoiFarmShop.Repositories.Models.FA24_PRN221_3W_G1_KoiFarmShopContext context)
        //{
        //    _context = context;
        //}
        private readonly KoiFarmService _koiFarmService;

        public IndexModel(KoiFarmService koiFarmService)
        {
            _koiFarmService = koiFarmService;
        }
        public IList<KoiFarm> KoiFarm { get;set; } = default!;

        public async Task OnGetAsync()
        {
            KoiFarm = await _koiFarmService.GetAll();
        }

        //public async Task OnGetAsync()
        //{
        //    KoiFarm = await _context.KoiFarms.ToListAsync();
        //}
    }
}
