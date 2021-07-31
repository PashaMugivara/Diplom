using Diplom.DataAccess;
using Diplom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diplom.Services
{
    public class RequestService : IRequestService
    {
        private readonly ApplicationDbContext applicationDbContext;
        public RequestService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public Request Create(User applicationUser, string requestDescription, Guid requestPositionId, Guid requestStateId, Guid requestTypeId, DateTime requestDate)
        {
            try
            {
                var request = new Request();
                request.Id = Guid.NewGuid();
                request.User = applicationUser;
                request.Description = requestDescription;
                request.PositionId = GetPosition(requestPositionId).Id;
                request.StateId = GetState(requestStateId).Id;
                request.TypeId = GetType(requestTypeId).Id;
                request.Data = requestDate;
                applicationDbContext.Requests.Add(request);
                applicationDbContext.SaveChanges();
                return request;
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
                var request = applicationDbContext.Requests.FirstOrDefault(p => p.Id == id);
                if (request == null) throw new Exception("This request not found");
                applicationDbContext.Requests.Remove(request);
                applicationDbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private RequestState GetState(Guid id)
        {
            try
            {
                var state = applicationDbContext.RequestStates.FirstOrDefault(p => p.Id == id);//try-case
                if (state == null) throw new Exception("State with this guid does not exist");
                return state;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        private RequestPosition GetPosition(Guid id)
        {
            try
            {
                var position = applicationDbContext.RequestPositions.FirstOrDefault(p => p.Id == id);
                if (position == null) throw new Exception("State with this guid does not exist");
                return position;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }



        private RequestType GetType(Guid id)
        {
            try
            {
                var type = applicationDbContext.RequestTypes.FirstOrDefault(p => p.Id == id);
                if (type == null) throw new Exception("Type with this guid does not exist");
                return type;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
           
        }


        public Request Get(Guid id)
        {
            try
            {
                var request = applicationDbContext.Requests.FirstOrDefault(p => p.Id == id);
                if (request == null) throw new Exception("This request not found");
                return request;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
          
        }

        public IEnumerable<Request> GetAll() {
            try
            {
                var requests = applicationDbContext.Requests;
                IEnumerable<Request> dto = requests;
                return dto;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
           
        }
        
       

        public Request Update(Guid Id, string newDescription, Guid newStateId, Guid newTypeId, Guid newPositionId, DateTime newDate)
        {

            try
            {
                var request = applicationDbContext.Requests.FirstOrDefault(p => p.Id == Id);
                if (newDescription != null)
                    request.Description = newDescription;
                if (newStateId != Guid.Empty)
                    request.StateId = GetState(newStateId).Id;
                if (newStateId != Guid.Empty)
                    request.TypeId = GetType(newTypeId).Id;
                if (newPositionId != Guid.Empty)
                    request.TypeId = GetPosition(newPositionId).Id;
                request.Data = newDate;

                applicationDbContext.SaveChanges();

                return request;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

           
        }

        public IEnumerable<RequestState> GetAllStates()
        {
            try
            {
                var states = applicationDbContext.RequestStates;
                IEnumerable<RequestState> dto = states;
                return dto;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public IEnumerable<RequestType> GetAllTypes()
        {
            try
            {
                var types = applicationDbContext.RequestTypes;
                IEnumerable<RequestType> dto = types;
                return dto;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public IEnumerable<RequestPosition> GetAllPositions()
        {
            try
            {
                var positions = applicationDbContext.RequestPositions;
                IEnumerable<RequestPosition> dto = positions;
                return dto;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
