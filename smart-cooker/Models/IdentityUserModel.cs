using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace smartCooker.Models
{
    public class IdentityUserModel : IdentityUser<int>
    {
        public string NIC { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfilePictureUrl { get; set; }


        public DateTime Created { get; set; } = DateTime.Now;

        public DateTime LastUpdated { get; set; } = DateTime.Now;

        public bool IsDeleted { get; set; } = false;

        public DateTime? Deleted { get; set; }


        public IList<UserWorksInOutlet> userWorksInOutlets { get; set; }
        public IList<UserAddress> UserAddress { get; set; }
        public IList<Order> Orders { get; set; }
        public IList<UserRole> UserRoles { get; set; }

    }
}
