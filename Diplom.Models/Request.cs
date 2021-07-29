using Diplom.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplom.Models
{
    [Table("Request", Schema = "dbo")]
    public class Request
    {
        [Key]
        public Guid Id { get; set; }
        public ApplicationUser User { get; set; }
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
