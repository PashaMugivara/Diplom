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
    public class PositionController : Controller
    {
        private readonly IPositionService _positionService;

        public PositionController(IPositionService positionService)
        {
            _positionService = positionService;
        }
        public IActionResult Index()
        {
            return View(GetAll());
        }
        [HttpPost]
        public IActionResult Create(PositionRequest createResponse)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(createResponse.Name)) throw new Exception("No name");
                if (!int.TryParse(createResponse.Floor, out int floor)) throw new Exception("The floor is not a int type");
                if (!int.TryParse(createResponse.CoordX, out int coordX)) throw new Exception("The coord is not a int type");
                if (!int.TryParse(createResponse.CoordY, out int coordY)) throw new Exception("The coord is not a int type");
                _positionService.Create(createResponse.Name, floor, coordX, coordY);
                return View();//узнать про юзера
            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message);
            }


        }
        public IEnumerable<PositionResponse> GetAll()
        {
            return GetAllResponse(_positionService.GetAll());

        }

        private IEnumerable<PositionResponse> GetAllResponse(IEnumerable<RequestPosition> requests)
        {
            return requests.Select(StandardResponse);
        }
        private PositionResponse StandardResponse(RequestPosition request)
        {
            var createRequestResponse = new PositionResponse();
            createRequestResponse.Name = request.Name;
            createRequestResponse.Floor = request.Floor.ToString();
            createRequestResponse.CoordX = request.CoordX.ToString();
            createRequestResponse.CoordY = request.CoordY.ToString();

            return createRequestResponse;
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
