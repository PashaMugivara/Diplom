using Diplom.Models;

using System;
using System.Collections.Generic;
using System.Text;


namespace Diplom.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAll(Guid profession);
        IEnumerable<UserState> GetAllStates();
        IEnumerable<UserProfession> GetAllProfession();

    }
}
