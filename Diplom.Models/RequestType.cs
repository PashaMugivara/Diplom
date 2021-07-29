using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplom.Models
{
    [Table("Type", Schema = "dbo")]
    public class RequestType
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
