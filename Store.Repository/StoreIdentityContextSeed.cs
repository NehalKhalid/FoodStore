using Microsoft.AspNetCore.Identity;
using Store.Data.Entities.IdentityEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Repository
{
    public class StoreIdentityContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Nehal Khaled",
                    Email = "nehal@gmail.com",
                    UserName = "nehalkhaled",
                    Address = new Address
                    {
                        FirstName = "Nehal",
                        LastName = "Khaled",
                        City = "ShebeenElkom",
                        State = "Menofia",
                        Street = "1",
                        PostalCode = "1234",
                    }
                };
                await userManager.CreateAsync(user,"Password123!");
            }
        } 
    }
}
