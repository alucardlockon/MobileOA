using MobileOA.Data.DataBaseContext;
using MobileOA.Data.IRepositories;
using MobileOA.Models.Entities;

namespace MobileOA.Data.Repositories
{
    public class AccountRepository:EntityBaseRepository<User>,IAccountRepository
    {
        public AccountRepository(AccountContext context)
            : base(context)
        { }
    }
}