using Diplom.Models;

using System;
using System.Collections.Generic;
using System.Text;


namespace Diplom.Services
{
    public interface IPositionService
    {
        RequestPosition Create(string name, int floor, int coordX, int coordY);
        RequestPosition Update(Guid positionId, string name, int floor, int coordX, int coordY);
        void Delete(Guid id);
        //void DeleteGroup(string filter);
        RequestPosition Get(Guid id);
        //IEnumerable<requestDto> GetFiltered(IEnumerable<requestDto> requests, string filter);

        IEnumerable<RequestPosition> GetAll();
    }
}
