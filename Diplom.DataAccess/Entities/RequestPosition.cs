using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Diplom.DataAccess.Entities
{
    [Table("Position", Schema = "dbo")]
    public class RequestPosition
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Floor { get; set; }
        public int CoordX { get; set; }
        public int CoordY { get; set; }

    }
}
