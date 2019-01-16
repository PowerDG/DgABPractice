#	ABP之PGSql
## 使用EntityFrameworkCore的CodeFirst方式创建数据库
### 添加相关依赖项

```csharp
PM> Install-Package Npgsql.EntityFrameworkCore.PostgreSQL
PM> Install-Package Npgsql.EntityFrameworkCore.PostgreSQL.Design
PM> Install-Package Microsoft.EntityFrameworkCore.Tools
```

```csharp
Install-Package Npgsql.EntityFrameworkCore.PostgreSQL
Install-Package Npgsql.EntityFrameworkCore.PostgreSQL.Design
Install-Package Microsoft.EntityFrameworkCore.Tools
```

### 增加appsettings.json配置文件

```json
{
  "ConnectionStrings": {
    "Default": "User ID=DGCore;Password=123456;Host=localhost;
    Port=5432;Database=DGCore;Pooling=true;"
  }
}


```
###  ABP 项目-DbContextConfigurer

```csharp
 public static class DgCorERDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DgCorERDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
            builder.UseNpgsql(connectionString);
            //options.UseNpgsql(sqlConnectionString)
        }

        public static void Configure(DbContextOptionsBuilder<DgCorERDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            builder.UseNpgsql(connection);
        }
 }
```

###  MVC项目 ConfigureServices

```csharp
public void ConfigureServices(IServiceCollection services)
{
    //获取数据库连接字符串
    var sqlConnectionString = Configuration.GetConnectionString("Default");

//添加数据上下文
services.AddDbContext<DGCoreDbContext>(options =>
    options.UseNpgsql(sqlConnectionString)
		);

services.AddMvc();
}
```

### 迁移文件+更新


```csharp
Add-Migration Init
Update-Database

```



> 参考
>
> 1.https://www.cnblogs.com/fonour/p/5886292.html
>
> Asp.Net Core 项目实战之权限管理系统（3） 通过EntityFramework Core使用PostgreSQL
>
> 2.(https://www.cnblogs.com/lanwilliam/p/5663931.html)
>
> [Asp.net Core基于MVC框架实现PostgreSQL操作]
>
> 3.https://beigang.iteye.com/blog/1812744
>
> PostgreSQL的用户、角色和权限管理
>
> 4.https://www.cnblogs.com/ryanzheng/p/9575902.html
>
> psql 工具详细使用介绍
>
> 5.(https://www.cnblogs.com/freebird911/p/9401840.html)
>
> [PostgreSQL 10 安装与启动 win10]
>
> 6
>
> 6.https://www.cnblogs.com/freebird911/p/9402652.html
>
> Asp.NET Core2.0 EF ABP Postgresql 数据迁移

