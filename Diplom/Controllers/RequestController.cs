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
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Diplom.Controllers
{
    public class RequestController : Controller
    {
        private readonly IRequestService _requestService;
        private readonly UserManager<User> _userManager;

        public RequestController(UserManager<User> userManager, IRequestService requestService)
        {
            _requestService = requestService;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View(GetAll());
        }
        public IActionResult Create()
        {
            ViewBag.Types = new SelectList(_requestService.GetAllTypes(), "Id", "Name");
            ViewBag.Positions = new SelectList(_requestService.GetAllPositions(), "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateRequestRequest createResponse)
        {
            try
            {
                var userId =_userManager.GetUserId(User);
                if (!Guid.TryParse(userId, out Guid user)) throw new Exception("The user is not a Guid type");//не гуидник
                if (!Guid.TryParse(createResponse.TypeId, out Guid type)) throw new Exception("The type is not a Guid type");
                if (!Guid.TryParse(createResponse.PositionId, out Guid position)) throw new Exception("The position is not a Guid type");
                if (string.IsNullOrWhiteSpace(createResponse.Description)) createResponse.Description = "";
                _requestService.Create(user, createResponse.Description, position, type, DateTime.Now);
                return RedirectToAction("Index", "Request");//узнать про юзера
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
        public IEnumerable<CreateRequestResponse> GetAll()
        {
                return GetAllResponse(_requestService.GetAll());

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
            createRequestResponse.User = _requestService.GetUser(new Guid(request.UserId)).Email;//для этого нужен Dto класс
            createRequestResponse.Description = request.Description;
            createRequestResponse.Position = _requestService.GetPosition(request.PositionId).Name;//nлное название места надо
            createRequestResponse.State = _requestService.GetState(request.StateId).Name;
            createRequestResponse.Type = _requestService.GetType(request.TypeId).Name;
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
