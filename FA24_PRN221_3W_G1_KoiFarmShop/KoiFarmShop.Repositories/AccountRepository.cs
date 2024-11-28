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
    public class AccountRepository:GenericRepository<Account>
    {
        public AccountRepository()
        {
              
        }
    }
}
