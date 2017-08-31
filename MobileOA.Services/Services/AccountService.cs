using System.Collections.Generic;
using System.Diagnostics;
using MobileOA.Data.Repositories;
using MobileOA.Models.Entities;
using MobileOA.Services.IServices;

namespace MobileOA.Services.Services
{
    public class AccountService:IAccountService
    {
        private AccountRepository _repository;

        public AccountService(AccountRepository repository)
        {
            _repository = repository;
        }
        
        public IEnumerable<User> getUsers()
        {
            return _repository.GetAll();
        }
    }
}