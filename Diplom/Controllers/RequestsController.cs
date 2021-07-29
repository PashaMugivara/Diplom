using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Diplom.Models;
using Diplom.DataAccess;
using Microsoft.Data.SqlClient;
using Diplom.Request;
using Diplom.Response;
using Diplom.Services;

namespace DOIT.Controllers
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
        public JsonResult Update([FromBody] UpdateRequestRequest updateTicket)
        {
            try
            {
                if(!Guid.TryParse(updateTicket.Id, out Guid ticket)) throw new Exception("The ticketId is not a Guid type");
                var ticketDto = _requestService.Get(ticket);
                if (string.IsNullOrWhiteSpace(updateTicket.NewDescription)) updateTicket.NewDescription = ticketDto.Description;
                if (string.IsNullOrWhiteSpace(updateTicket.NewStateId)) updateTicket.NewStateId = ticketDto.State.Id.ToString();
                if (!Guid.TryParse(updateTicket.NewStateId, out Guid newStateId)) throw new Exception("The state is not a Guid type");
                if (string.IsNullOrWhiteSpace(updateTicket.NewTypeId)) updateTicket.NewTypeId = ticketDto.Type.Id.ToString();
                if (!Guid.TryParse(updateTicket.NewTypeId, out Guid newTypeId)) throw new Exception("The type is not a Guid type");
                return new JsonResult(TicketToUpdateResponse(_ticketService.Update(ticket, updateTicket.NewName, updateTicket.NewDescription, newStateId, newTypeId, DateTime.Now), ticketDto));
            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message);
            }
        }
        [HttpGet]
        public JsonResult Get([FromBody] GetRequestRequest getTicket)
        {
            try
            {
                if (!Guid.TryParse(getTicket.TicketId, out Guid ticket)) throw new Exception("The ticketId is not a Guid type");
                var ticketDto = _ticketService.Get(ticket);
                return new JsonResult(TicketToStandardResponse(ticketDto));
            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message);
            }
        }
        [HttpDelete]
        public JsonResult Delete([FromBody] GetTicketRequest getTicket)
        {
            try
            {
                if (!Guid.TryParse(getTicket.TicketId, out Guid ticket)) throw new Exception("The ticketId is not a Guid type");
                var ticketDto = _ticketService.Get(ticket);
                _ticketService.Delete(ticket);
                return new JsonResult(TicketToStandardResponse(ticketDto));
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
                return new JsonResult(GetAllResponse(_ticketService.GetAll()));
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
                return new JsonResult(GetAllStateResponse(_ticketService.GetAllStates()));
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
                return new JsonResult(GetAllTypeResponse(_ticketService.GetAllTypes()));
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
        private UpdateRequestResponse TicketToUpdateResponse(TicketDto newTicketDto, TicketDto oldTicketDto)
        {
            var updateTicketResponse = new UpdateRequestResponse();
            updateTicketResponse.Id = newTicketDto.Id.ToString();
            updateTicketResponse.NewName = newTicketDto.Name;
            updateTicketResponse.NewDescription = newTicketDto.Description;
            updateTicketResponse.NewState = newTicketDto.State.Name;
            updateTicketResponse.NewType = newTicketDto.Type.Name;
            updateTicketResponse.OldName = oldTicketDto.Name;
            updateTicketResponse.OldDescription = oldTicketDto.Description;
            updateTicketResponse.OldState = oldTicketDto.State.Name;
            updateTicketResponse.OldType = oldTicketDto.Type.Name;
            updateTicketResponse.Date = oldTicketDto.Date.ToString("dd.MM.yyyy");
            return updateTicketResponse;
        }
        private IEnumerable<CreateRequestResponse> GetAllResponse(IEnumerable<TicketDto> tickets)
        {
            return tickets.Select(TicketToStandardResponse);
        }
        private IEnumerable<TicketState> GetAllStateResponse(IEnumerable<StateTicketDto> states)
        {
            foreach (var ir in states)
            {
                yield return new TicketState() { Id = ir.Id, Name = ir.Name };
            }
        }
        private IEnumerable<TicketType> GetAllTypeResponse(IEnumerable<TicketTypeDto> types)
        {
            foreach (var ir in types)
            {
                yield return new TicketType() { Id = ir.Id, Name = ir.Name };
            }
        }
    }
}
