using Microsoft.AspNetCore.Identity;

namespace SOLID.CleanArchitecture_.NET.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
