using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Diplom.Models;
using Diplom.DataAccess;
using Microsoft.Data.SqlClient;
using Diplom.Requestion;
using Diplom.Response;
using Diplom.Services;

namespace Diplom.Controllers
{
    public class RequestsController : Controller
    {
        private readonly IRequestService _requestService;

        public RequestsController(IRequestService requestService)
        {
            _requestService = requestService;
        }
        [HttpPost]
        public JsonResult Create([FromBody] CreateRequestRequest createResponse)
        {
            try
            {
                if (!Guid.TryParse(createResponse.UserId, out Guid user)) throw new Exception("The user is not a Guid type");//не гуидник
                if (!Guid.TryParse(createResponse.StateId, out Guid state)) throw new Exception("The state is not a Guid type");
                if (!Guid.TryParse(createResponse.TypeId, out Guid type)) throw new Exception("The type is not a Guid type");
                if (!Guid.TryParse(createResponse.PositionId, out Guid position)) throw new Exception("The position is not a Guid type");
                if (string.IsNullOrWhiteSpace(createResponse.Description)) createResponse.Description = "";
                return new JsonResult(RequestToStandardResponse(_requestService.Create(null, createResponse.Description, position, state, type, DateTime.Now)));//узнать про юзера
            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message);
            }

            
        }
        [HttpPost]
        public JsonResult Update([FromBody] UpdateRequestRequest updateRequest)
        {
            try
            {
                if(!Guid.TryParse(updateRequest.Id, out Guid requestId)) throw new Exception("The ticketId is not a Guid type");
                var request = _requestService.Get(requestId);
                if (string.IsNullOrWhiteSpace(updateRequest.NewDescription)) updateRequest.NewDescription = request.Description;
                if (string.IsNullOrWhiteSpace(updateRequest.NewPositionId)) updateRequest.NewPositionId = request.Position.Id.ToString();
                if (!Guid.TryParse(updateRequest.NewPositionId, out Guid newPositionId)) throw new Exception("The state is not a Guid type");
                if (string.IsNullOrWhiteSpace(updateRequest.NewStateId)) updateRequest.NewStateId = request.State.Id.ToString();
                if (!Guid.TryParse(updateRequest.NewStateId, out Guid newStateId)) throw new Exception("The state is not a Guid type");
                if (string.IsNullOrWhiteSpace(updateRequest.NewTypeId)) updateRequest.NewTypeId = request.Type.Id.ToString();
                if (!Guid.TryParse(updateRequest.NewTypeId, out Guid newTypeId)) throw new Exception("The type is not a Guid type");
                return new JsonResult(RequestToUpdateResponse(_requestService.Update(requestId, updateRequest.NewDescription, newPositionId, newStateId, newTypeId, DateTime.Now), request));
            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message);
            }
        }
        [HttpGet]
        public JsonResult Get([FromBody] GetRequestRequest getRequest)
        {
            try
            {
                if (!Guid.TryParse(getRequest.RequestId, out Guid requestId)) throw new Exception("The requestId is not a Guid type");
                var request = _requestService.Get(requestId);
                return new JsonResult(request);
            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message);
            }
        }
        [HttpDelete]
        public JsonResult Delete([FromBody] GetRequestRequest getRequest)
        {
            try
            {
                if (!Guid.TryParse(getRequest.RequestId, out Guid requestId)) throw new Exception("The requestId is not a Guid type");
                var request = _requestService.Get(requestId);
                _requestService.Delete(requestId);
                return new JsonResult(request);
            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message);
            }
        }
        [HttpGet]
        public JsonResult GetAll()
        {
            try
            {
                return new JsonResult(GetAllResponse(_requestService.GetAll()));
            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message);
            }
        }
        [HttpGet]
        public JsonResult GetAllPositions()
        {
            try
            {
                return new JsonResult(_requestService.GetAllPositions());
            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message);
            }
        }
        [HttpGet]
        public JsonResult GetAllStates()
        {
            try
            {
                return new JsonResult(_requestService.GetAllStates());
            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message);
            }
        }
        [HttpGet]
        public JsonResult GetAllTypes()
        {
            try
            {
                return new JsonResult(_requestService.GetAllTypes());
            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message);
            }
        }
        private CreateRequestResponse RequestToStandardResponse(Request request)
        {
            var createRequestResponse = new CreateRequestResponse();
            createRequestResponse.Id = request.Id.ToString();
            createRequestResponse.User = request.User.UserName;
            createRequestResponse.Description = request.Description;
            createRequestResponse.State = request.Position.Name;
            createRequestResponse.State = request.State.Name;
            createRequestResponse.Type = request.Type.Name;
            createRequestResponse.Date = request.Data.ToString("dd.MM.yyyy");
            return createRequestResponse;
        }
        private UpdateRequestResponse RequestToUpdateResponse(Request newRequest, Request oldRequest)
        {
            var updateRequestResponse = new UpdateRequestResponse();
            updateRequestResponse.Id = newRequest.Id.ToString();
            updateRequestResponse.NewPosition = newRequest.Position.Name;
            updateRequestResponse.NewDescription = newRequest.Description;
            updateRequestResponse.NewState = newRequest.State.Name;
            updateRequestResponse.NewType = newRequest.Type.Name;
            updateRequestResponse.OldPosition = oldRequest.Position.Name;
            updateRequestResponse.OldDescription = oldRequest.Description;
            updateRequestResponse.OldState = oldRequest.State.Name;
            updateRequestResponse.OldType = oldRequest.Type.Name;
            updateRequestResponse.Date = oldRequest.Data.ToString("dd.MM.yyyy");
            return updateRequestResponse;
        }
        private IEnumerable<CreateRequestResponse> GetAllResponse(IEnumerable<Request> requests)
        {
            return requests.Select(RequestToStandardResponse);
        }
    }
}
