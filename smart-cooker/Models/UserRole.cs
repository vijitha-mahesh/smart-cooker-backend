using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace smartCooker.Models
{
    public class UserRole:IdentityUserRole<int>
    {
        public DateTime Created { get; set; } = DateTime.Now;

        public DateTime LastUpdated { get; set; } = DateTime.Now;

        public bool IsDeleted { get; set; } = false;

        public DateTime? Deleted { get; set; }



        public IdentityUserModel identityUserModels { get; set; }
        public ApplicationUserRole applicationUserRoles  { get; set; }
    }
}
