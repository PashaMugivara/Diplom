using Diplom.Models;

using System;
using System.Collections.Generic;
using System.Text;


namespace Diplom.Services
{
    public interface IRequestService
    {

        Request Create(Guid applicationUser, string requestDescription, Guid requestPosition, Guid requestTypeId, DateTime requestDate);
        Request Update(Guid requestId, string newDescription, Guid newPosition, Guid newStateId, Guid newTypeId, DateTime newDate);
        void Delete(Guid id);
        //void DeleteGroup(string filter);
        Request Get(Guid id);
        //IEnumerable<requestDto> GetFiltered(IEnumerable<requestDto> requests, string filter);
        public User GetUser(Guid id);
        public RequestPosition GetPosition(Guid id);
        public RequestState GetState(string name);
        public RequestState GetState(Guid id);
        public RequestType GetType(Guid id);
        IEnumerable<Request> GetAll();

        IEnumerable<RequestState> GetAllStates();
        IEnumerable<RequestType> GetAllTypes();
        IEnumerable<RequestPosition> GetAllPositions();

    }
}
