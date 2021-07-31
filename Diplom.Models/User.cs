using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Diplom.Models
{
    public class User : IdentityUser
    {
        [Key]
        public new Guid Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public Guid ProfessionId { get; set; }
        public UserProfession Profession { get; set; }
        public UserState StateId { get; set; }
        public UserState State { get; set; }

    }
}
