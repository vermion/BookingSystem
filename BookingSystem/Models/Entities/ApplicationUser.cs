﻿using Microsoft.AspNetCore.Identity;

namespace BookingSystem.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Address { get; set; }
    }
}
