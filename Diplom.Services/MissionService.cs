using Diplom.DataAccess;
using Diplom.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Diplom.Services
{
    public class MissionService: IMissionService
    {
        private readonly ApplicationDbContext applicationDbContext;
        public MissionService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public Mission Create(Guid userId, Guid request)
        {
            try
            {
                var mission = new Mission();
                mission.Id = Guid.NewGuid();
                mission.UserId = GetUser(userId).Id;//может возникнуть проблема
                mission.RequestId = GetRequest(request).Id;
                applicationDbContext.Missions.Add(mission);
                applicationDbContext.SaveChanges();
                return mission;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }



        public void Delete(Guid id)
        {
            try
            {
                var request = applicationDbContext.Missions.FirstOrDefault(p => p.Id == id);
                if (request == null) throw new Exception("This request not found");
                applicationDbContext.Missions.Remove(request);
                applicationDbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public Mission Get(Guid id)
        {
            try
            {
                var request = applicationDbContext.Missions.FirstOrDefault(p => p.Id == id);
                if (request == null) throw new Exception("This mission not found");
                return request;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public IEnumerable<Mission> GetAll()
        {
            try
            {
                var requests = applicationDbContext.Missions;
                IEnumerable<Mission> dto = requests;
                return dto;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        public IEnumerable<Mission> GetAll(Guid userId)
        {
            try
            {
                var states = applicationDbContext.Missions.Where(p => p.UserId == userId.ToString());
                IEnumerable<Mission> dto = states;
                return dto;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        private User GetUser(Guid id)
        {
            try
            {
                var position = applicationDbContext.Users.FirstOrDefault(p => p.Id == id.ToString());
                if (position == null) throw new Exception("User with this guid does not exist");
                return position;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        private Request GetRequest(Guid request)
        {
            try
            {
                var position = applicationDbContext.Requests.FirstOrDefault(p => p.Id == request);
                if (position == null) throw new Exception("User with this guid does not exist");
                return position;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
