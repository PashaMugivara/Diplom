﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Diplom.Models
{
    [Table("UserState", Schema = "dbo")]
    public class UserState
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
