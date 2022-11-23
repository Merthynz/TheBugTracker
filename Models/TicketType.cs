﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace TheBugTracker.Models
{
    public class TicketType
    {
        public int Id { get; set; }

        [DisplayName("Type Name")]
        public string Name { get; set; }
    }
}
