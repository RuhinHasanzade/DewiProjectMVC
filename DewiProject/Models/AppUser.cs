using Microsoft.AspNetCore.Identity;

namespace DewiProject.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;
    }
}
