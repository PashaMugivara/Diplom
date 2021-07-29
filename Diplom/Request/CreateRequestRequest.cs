using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diplom.Request
{
    public class CreateRequestRequest
    {
        public string UserId { get; set; }
        public string Description { get; set; }
        public string PositionId { get; set; }
        public string StateId { get; set; }
        public string TypeId { get; set; }
    }
}
