using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using FirstProject.Authorization.Roles;
using FirstProject.Authorization.Users;
using FirstProject.MultiTenancy;

namespace FirstProject.EntityFrameworkCore
{
    public class FirstProjectDbContext : AbpZeroDbContext<Tenant, Role, User, FirstProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public FirstProjectDbContext(DbContextOptions<FirstProjectDbContext> options)
            : base(options)
        {
        }
    }
}
