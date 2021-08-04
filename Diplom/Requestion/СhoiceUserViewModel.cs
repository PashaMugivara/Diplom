using Diplom.Models;
using Diplom.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diplom.Requestion
{
    public class СhoiceUserViewModel
    {
        public CreateRequestResponse CreateRequestResponse { get; set; }
        public string ProfessionId { get; set; }
        public Guid id { get; set; }
        public List<User> Users { get; set; } = new List<User>();
    }
}
