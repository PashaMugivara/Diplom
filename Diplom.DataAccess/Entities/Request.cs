using Diplom.DataAccess.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplom.DataAccess.Entities
{
    [Table("Request", Schema = "dbo")]
    public class Request
    {
        [Key]
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public Guid PositionId { get; set; }
        public RequestPosition Position { get; set; }
        public Guid TypeId { get; set; }
        public RequestType Type { get; set; }
        public Guid StateId { get; set; }
        public RequestState State { get; set; }
        public DateTime Data { get; set; }
    }
}
