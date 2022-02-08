using Microsoft.AspNetCore.Identity;

namespace smartCooker.Models
{
    public class UserModel : IdentityUser<int>
    {
        public string Role { get; set; }
    }
}
