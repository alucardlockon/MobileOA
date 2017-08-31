using Microsoft.EntityFrameworkCore;
using MobileOA.Models.Entities;

namespace MobileOA.Data.DataBaseContext
{
    public class AccountContext : DbContext
    {
        public AccountContext(DbContextOptions options) : base(options) { }
        
        public DbSet<User> Users { get; set; }

    }
}