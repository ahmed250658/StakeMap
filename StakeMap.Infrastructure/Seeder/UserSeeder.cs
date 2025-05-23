using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StakeMap.Infrastructure.Entities.Identity;



namespace WastedFood.Infrastructure.Seeder
{
    public static class UserSeeder
    {
        public static async Task SeedAsync(UserManager<Users> _userManager)
        {
            var usercount = await _userManager.Users.CountAsync();
            if (usercount <= 0)
            {
                var defaultUser = new Users
                {
                    UserName = "Manager",
                    Email = "ah6734735@gmail.com",
                };
                await _userManager.CreateAsync(defaultUser, "M123_m");
                await _userManager.AddToRoleAsync(defaultUser, "Admin");
            }
        }
    }
}
