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
                var states = applicationDbContext.Users.Where(p => p.ProfessionId == profession);
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
        public UserState GetState()
        {
            try
            {
                var state = applicationDbContext.UserStates.FirstOrDefault(p => p.Name == "Absent");//try-case
                if (state == null) throw new Exception("State with this guid does not exist");
                return state;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public UserState GetState(Guid id)
        {
            try
            {
                var state = applicationDbContext.UserStates.FirstOrDefault(p => p.Id == id);//try-case
                if (state == null) throw new Exception("State with this guid does not exist");
                return state;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public UserProfession GetProfession(Guid id)
        {
            try
            {
                var position = applicationDbContext.UserProfessions.FirstOrDefault(p => p.Id == id);
                if (position == null) throw new Exception("State with this guid does not exist");
                return position;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

    }
}
