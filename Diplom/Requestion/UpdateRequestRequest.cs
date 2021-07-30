using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diplom.Requestion
{
    public class UpdateRequestRequest
    {
        public string Id { get; set; }
        public string NewDescription { get; set; }
        public string NewPositionId { get; set; }
        public string NewStateId { get; set; }
        public string NewTypeId { get; set; }

    }
}
