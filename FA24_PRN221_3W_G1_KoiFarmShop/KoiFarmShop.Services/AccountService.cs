using KoiFarmShop.Repositories;
using KoiFarmShop.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiFarmShop.Services
{
    public class AccountService
    {
        private AccountRepository _accountRepository;

        public AccountService()
        {
             _accountRepository = new AccountRepository();
        }

        public async Task<List<Account>> GetAll()
        {
            return await _accountRepository.GetAllAsync();
        }
    }
}
