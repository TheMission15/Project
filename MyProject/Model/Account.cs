using Microsoft.AspNetCore.Identity;

namespace MyProject.Model
{
    public class Account : IdentityUser
    {
        public string ProfilePicture { get; set; }

        public int NumberOfListings { get; set; }

    }
}
