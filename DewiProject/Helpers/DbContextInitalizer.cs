using DewiProject.Models;
using DewiProject.ViewModels.AuthViewModels;
using Microsoft.AspNetCore.Identity;

namespace DewiProject.Helpers
{
    public class DbContextInitalizer 
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly AdminVm _admin;

        public DbContextInitalizer(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _admin = _configuration.GetSection("AdminSettings").Get<AdminVm>() ?? new();
        }


        public async Task DbInit()
        {
            await CreateRoles();
            await CreateAdmin();
        }


        private async Task CreateRoles()
        {
            await _roleManager.CreateAsync(new() { Name = "Admin" });
            await _roleManager.CreateAsync(new() { Name = "Member" });
            await _roleManager.CreateAsync(new() { Name = "Moderator" });
            await _roleManager.CreateAsync(new() { Name = "Mallim" });
        }

        private async Task CreateAdmin()
        {
            var admin = new AppUser()
            {
               Email = _admin.Email,
               UserName = _admin.Username,
               FullName = _admin.FullName
            };

            var result = await _userManager.CreateAsync(admin,_admin.Password);

            if(result.Succeeded)
            {
                await _userManager.AddToRoleAsync(admin, "Admin");
            }
        }





    }
}
