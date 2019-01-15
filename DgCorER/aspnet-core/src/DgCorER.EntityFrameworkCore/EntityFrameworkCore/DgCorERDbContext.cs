using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DgCorER.Authorization.Roles;
using DgCorER.Authorization.Users;
using DgCorER.MultiTenancy;
using RQCore.RQEnitity;
using DgCorER.DgEntity;

namespace DgCorER.EntityFrameworkCore
{
    public class DgCorERDbContext : AbpZeroDbContext<Tenant, Role, User, DgCorERDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<ABB> ABBs { get; set; }

        //public DbSet<Invoice> Invoices { get; set; }
        //Invoice
        public DgCorERDbContext(DbContextOptions<DgCorERDbContext> options)
            : base(options)
        {
        }
    }
}
