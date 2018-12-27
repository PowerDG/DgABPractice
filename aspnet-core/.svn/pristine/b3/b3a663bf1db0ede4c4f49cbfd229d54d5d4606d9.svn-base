using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using RQCore.Authorization.Roles;
using RQCore.Authorization.Users;
using RQCore.MultiTenancy;
using RQCore.RQEnitity;

namespace RQCore.EntityFrameworkCore
{
    public class RQCoreDbContext : AbpZeroDbContext<Tenant, Role, User, RQCoreDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<TruckInfo> TruckInfos { get; set; }

        public DbSet<TruckModel> TruckModels { get; set; }

        public DbSet<BranchInfo> BranchInfos { get; set; }

        public DbSet<CargoInfo> CargoInfos { get; set; }
        public DbSet<CargoVector> CargoVectors { get; set; }
        public DbSet<BillInfo> BillInfos { get; set; }
        public DbSet<CustomerInfo> CustomerInfos { get; set; }
  //      public DbSet<DepartmentInfo> DepartmentInfos { get; set; }
        public DbSet<T_GoodsImg> T_GoodsImgs { get; set; }
        public DbSet<Plu> Plus { get; set; }
        public DbSet<Inspection> Inspections { get; set; }
        public RQCoreDbContext(DbContextOptions<RQCoreDbContext> options)
            : base(options)
        {
        }
    }
}
