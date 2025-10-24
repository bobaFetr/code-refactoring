using Microsoft.AspNetCore.Identity;

namespace User.Models
{
    public class Potrebitel : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}