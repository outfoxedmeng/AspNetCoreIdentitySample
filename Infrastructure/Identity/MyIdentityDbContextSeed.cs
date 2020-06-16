using Infrastructure.Utils;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    public class MyIdentityDbContextSeed
    {
        public static async Task SeedAsync(UserManager<MyUser> userManager)
        {

            var adminName = ConfigurationHelper.GetConfigValueByKey("DefaultAdmin:Name") ?? "TxclAdmin";
            var userE = await userManager.FindByNameAsync(adminName);
            if (userE == null)
            {
                var psw = ConfigurationHelper.GetConfigValueByKey("DefaultAdmin:PSW") ?? "Pass@word1";
                var user = new MyUser
                {
                    UserName = $"{adminName}@1.com",
                    Email = $"{adminName}@1.com",
                    IsAdmin = true,
                };
                await userManager.CreateAsync(user, psw);
            }
        }
    }
}
