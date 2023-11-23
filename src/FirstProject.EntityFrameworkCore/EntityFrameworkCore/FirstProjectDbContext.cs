using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using FirstProject.Authorization.Roles;
using FirstProject.Authorization.Users;
using FirstProject.MultiTenancy;
using Abp.Domain.Entities;

namespace FirstProject.EntityFrameworkCore
{
    public class Person : Entity<long>
    {
        public string Name { get; set; }
        public string Family { get; set; }
    }
    public class FirstProjectDbContext : AbpZeroDbContext<Tenant, Role, User, FirstProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<Person> Persons { get; set; }
        public FirstProjectDbContext(DbContextOptions<FirstProjectDbContext> options)
            : base(options)
        {
        }
    }
}
