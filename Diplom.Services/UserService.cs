using Diplom.DataAccess;
using Diplom.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Diplom.Services
{
    public class UserService: IUserService
    {
        private readonly ApplicationDbContext applicationDbContext;
        public UserService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public IEnumerable<User> GetAll(Guid profession)
        {
            try
            {
                var states = applicationDbContext.Users.Where(p => Guid.Parse(p.Id) == profession);
                IEnumerable<User> dto = states;
                return dto;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public IEnumerable<UserState> GetAllStates()
        {
            try
            {
                var states = applicationDbContext.UserStates;
                IEnumerable<UserState> dto = states;
                return dto;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public IEnumerable<UserProfession> GetAllProfession()
        {
            try
            {
                var states = applicationDbContext.UserProfessions;
                IEnumerable<UserProfession> dto = states;
                return dto;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
