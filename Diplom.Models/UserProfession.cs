using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplom.Models
{
    [Table("UserProfession", Schema = "dbo")]
    public class UserProfession
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
