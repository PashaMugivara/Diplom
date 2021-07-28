using Diplom.Models;

using System;
using System.Collections.Generic;
using System.Text;


namespace DOIT.Services
{
    public interface IRequestService
    {

        Request Create(int requestNumber, string requestDescription, Guid requestStateId, Guid requestTypeId, DateTime requestDate);
        Request Update(Guid requestDto, string newDescription, Guid newStateId, Guid newTypeId, Guid position, DateTime newDate);

        void Delete(Guid id);


        //void DeleteGroup(string filter);
        Request Get(Guid id);

      

        //IEnumerable<requestDto> GetFiltered(IEnumerable<requestDto> requests, string filter);

        IEnumerable<Request> GetAll();

        IEnumerable<RequestState> GetAllStates();
        IEnumerable<RequestType> GetAllTypes();

    }
}
