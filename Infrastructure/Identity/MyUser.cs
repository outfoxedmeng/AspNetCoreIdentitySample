using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Identity
{
    public class MyUser : IdentityUser<int>
    {
        [DefaultValue(false)]
        public bool IsAdmin { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }
    }
}
