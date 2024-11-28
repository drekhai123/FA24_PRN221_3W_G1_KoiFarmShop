using KoiFarmShop.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiFarmShop.Repositories
{
    public class KoiFarmRepository : GenericRepository<KoiFarm>
    {
        //private FA24_PRN221_3W_G1_KoiFarmShopContext? _context;

        //public KoiFarmRepository(FA24_PRN221_3W_G1_KoiFarmShopContext context) 
        //{
        //    _context = context;
        //}
        public KoiFarmRepository()
        {
            
        }
        public async Task<List<KoiFarm>> GetAllAsync()
        {
            //NHU THE NAY LA SAI NHA.
            //var koiFarmList = await _context.KoiFarms.Include(a => a.Owner.Id == a.OwnerId)
            //    .ToListAsync();
            var koiFarmList = await _context.KoiFarms.Include(k => k.Owner)
                .ToListAsync();
            return koiFarmList;
        }
        public async Task<KoiFarm> GetByIdAsync(int id)
        {
            var koiFarm = await _context.KoiFarms.FindAsync(id);
            return koiFarm;
        }
    }




}
