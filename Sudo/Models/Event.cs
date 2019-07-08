﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sudo.Models
{
    public class Event
    {
        public Guid Id { get; set; }
        public Guid ImageId { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public DateTime Time { get; set; }
        public string Description { get; set; }

    }
}
