﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class UpdateRental
    {
        public int Id { get; set; }
        public int SeyahatId { get; set; }
        public string UserId { get; set; }
    }
}
