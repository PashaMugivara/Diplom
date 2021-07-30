using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diplom.Response
{
    public class CreateRequestResponse
    {
        public string Id { get; set; }
        public string User { get; set; }
        public string Description { get; set; }
        public string Position { get; set; }
        public string State { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }
    }
}
