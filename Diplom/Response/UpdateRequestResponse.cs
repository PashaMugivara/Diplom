using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diplom.Response
{
    public class UpdateRequestResponse
    {
        public string Id { get; set; }
        public string NewDescription { get; set; }
        public string NewPosition { get; set; }
        public string NewState { get; set; }
        public string NewType { get; set; }
        public string OldDescription { get; set; }
        public string OldPosition { get; set; }
        public string OldState { get; set; }
        public string OldType { get; set; }
        public string Date { get; set; }
    }
}
