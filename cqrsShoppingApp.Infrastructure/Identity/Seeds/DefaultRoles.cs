using cqrsShoppingApp.Application.Enums;
using cqrsShoppingApp.Infrastructure.Identity.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace cqrsShoppingApp.Infrastructure.Identity.Seeds
{
    public static class DefaultRoles
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole<int>> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole<int>(Roles.SuperAdmin.ToString()));
            await roleManager.CreateAsync(new IdentityRole<int>(Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole<int>(Roles.Moderator.ToString()));
            await roleManager.CreateAsync(new IdentityRole<int>(Roles.Basic.ToString()));
        }
    }
}