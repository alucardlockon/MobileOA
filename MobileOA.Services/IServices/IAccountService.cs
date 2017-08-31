using System.Collections.Generic;
using MobileOA.Models.Entities;

namespace MobileOA.Services.IServices
{
    public interface IAccountService
    {
        IEnumerable<User> getUsers();

    }
}