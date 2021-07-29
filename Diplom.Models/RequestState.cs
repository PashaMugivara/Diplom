using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplom.Models
{
    [Table("State", Schema = "dbo")]
    public class RequestState
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
