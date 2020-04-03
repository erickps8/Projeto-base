using Microsoft.AspNetCore.Identity;

namespace Template.Identity.Data
{
    public class CustomIdentity : IdentityUser
    {
        public string Nome { get; set; }
    }
}
