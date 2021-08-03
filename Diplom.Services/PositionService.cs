using Diplom.DataAccess;
using Diplom.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Diplom.Services
{
    public class PositionService: IPositionService
    {
        private readonly ApplicationDbContext applicationDbContext;
        public PositionService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public RequestPosition Create(string name, int floor, int coordX, int coordY)
        {
            try
            {
                var request = new RequestPosition();
                request.Id = Guid.NewGuid();
                request.Name = name;
                request.Floor = floor;
                request.CoordX = coordX;
                request.CoordY = coordY;
                applicationDbContext.RequestPositions.Add(request);
                applicationDbContext.SaveChanges();
                return request;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public RequestPosition Update(Guid positionId, string name, int floor, int coordX, int coordY)
        {
            try
            {
                var request = applicationDbContext.RequestPositions.FirstOrDefault(p => p.Id == positionId);
                if (name != null)
                    request.Name = name;
                request.Floor = floor;
                request.CoordX = coordX;
                request.CoordY = coordY;

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
                var request = applicationDbContext.RequestPositions.FirstOrDefault(p => p.Id == id);
                if (request == null) throw new Exception("This request not found");
                applicationDbContext.RequestPositions.Remove(request);
                applicationDbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public RequestPosition Get(Guid id)
        {
            try
            {
                var request = applicationDbContext.RequestPositions.FirstOrDefault(p => p.Id == id);
                if (request == null) throw new Exception("This request not found");
                return request;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        //IEnumerable<requestDto> GetFiltered(IEnumerable<requestDto> requests, string filter);

        public IEnumerable<RequestPosition> GetAll()
        {

            try
            {
                var requests = applicationDbContext.RequestPositions;
                IEnumerable<RequestPosition> dto = requests;
                return dto;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
