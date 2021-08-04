using Diplom.Models;
using Diplom.Requestion;
using Diplom.Response;
using Diplom.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diplom.Controllers
{
    public class MissionController : Controller
    {
        private readonly IMissionService _missionService;
        private readonly IUserService _userService;
        private readonly IRequestService _requestService;

        public MissionController(IMissionService missionService, IUserService userService, IRequestService requestService)
        {
            _missionService = missionService;
            _userService = userService;
            _requestService = requestService;
        }
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Index(СhoiceUserViewModel сhoiceUserViewModel)
        {
            if (сhoiceUserViewModel.idS != null) сhoiceUserViewModel.id = new Guid(сhoiceUserViewModel.idS);
            сhoiceUserViewModel.CreateRequestResponse = RequestToStandardResponse(_requestService.Get(сhoiceUserViewModel.id));
            if (сhoiceUserViewModel.ProfessionId!=null) сhoiceUserViewModel.Users = _userService.GetAll(new Guid(сhoiceUserViewModel.ProfessionId)).ToList();
            ViewBag.Professions = new SelectList(_userService.GetAllProfession(), "Id", "Name");
            return View(сhoiceUserViewModel);
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
    }
}
