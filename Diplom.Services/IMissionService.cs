using Diplom.Models;

using System;
using System.Collections.Generic;
using System.Text;


namespace Diplom.Services
{
    public interface IMissionService
    {
        Mission Create(Guid userId, Guid request);
        void Delete(Guid id);
        //void DeleteGroup(string filter);
        Mission Get(Guid id);
        //IEnumerable<requestDto> GetFiltered(IEnumerable<requestDto> requests, string filter);
        IEnumerable<Mission> GetAll();
        IEnumerable<Mission> GetAll(Guid userId);
    }
}
