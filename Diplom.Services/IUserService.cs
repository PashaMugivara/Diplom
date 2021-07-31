using Diplom.Models;

using System;
using System.Collections.Generic;
using System.Text;


namespace Diplom.Services
{
    public interface IUserService
    {

        User Create(string name, string mail, string password, Guid professionId, Guid stateId, int level);
        User Update(Guid UserId, Guid newStateId);
        void Delete(Guid id);
        User Get(Guid id);
        IEnumerable<User> GetAll();
        IEnumerable<User> GetAll(Guid profession);

        IEnumerable<UserState> GetAllStates();
        IEnumerable<UserProfession> GetAllProfession();

    }
}
