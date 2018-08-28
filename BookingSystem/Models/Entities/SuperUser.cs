using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingSystem.Models.Entities
{
    public class SuperUser
    {
        public int SuperUserId { get; set; }
        public string IdentityId { get; set; }
        public Company Company { get; set; }
    }
}
