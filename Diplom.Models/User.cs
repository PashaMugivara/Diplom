using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Diplom.Models
{
    public class User : IdentityUser
    {
        public Guid ProfessionId { get; set; }
        public UserProfession Profession { get; set; }
        public Guid StateId { get; set; }
        public UserState State { get; set; }


    }
}
