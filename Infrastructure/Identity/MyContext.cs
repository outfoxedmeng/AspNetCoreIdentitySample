using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Identity
{
    public class MyContext : IdentityDbContext<MyUser, IdentityRole<int>, int>
    {
    }
}
