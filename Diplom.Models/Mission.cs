using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Diplom.Models
{
    [Table("Mission", Schema = "dbo")]
    public class Mission
    {
        [Key]
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public Guid RequestId { get; set; }
        public Request Request { get; set; }
    }
}
