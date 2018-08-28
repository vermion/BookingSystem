using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BookingSystem.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Address { get; set; }
    }
}