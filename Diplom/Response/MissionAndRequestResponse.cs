using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diplom.Response
{
    public class MissionAndRequestResponse
    {
        public IEnumerable<CreateRequestResponse> Requests { get; set; }
        public IEnumerable<CreateRequestResponse> Missions { get; set; }
    }
}
