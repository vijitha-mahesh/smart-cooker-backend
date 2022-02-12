using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace smartCooker.Models
{
    public class ApplicationUserRole : IdentityRole<int>
    {
        public DateTime Created { get; set; } = DateTime.Now;

        public DateTime LastUpdated { get; set; } = DateTime.Now;

        public bool IsDeleted { get; set; } = false;

        public DateTime? Deleted { get; set; }

        public IList<UserRole> UserRoles {get;set;}
    }
}
