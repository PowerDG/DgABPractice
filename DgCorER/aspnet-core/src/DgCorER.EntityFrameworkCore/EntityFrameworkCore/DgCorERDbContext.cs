using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DgCorER.Authorization.Roles;
using DgCorER.Authorization.Users;
using DgCorER.MultiTenancy;

namespace DgCorER.EntityFrameworkCore
{
    public class DgCorERDbContext : AbpZeroDbContext<Tenant, Role, User, DgCorERDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DgCorERDbContext(DbContextOptions<DgCorERDbContext> options)
            : base(options)
        {
        }
    }
}
