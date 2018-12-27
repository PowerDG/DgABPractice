using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RQCore.Migrations
{
    public partial class updatemysql5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BranchInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BranchID = table.Column<int>(nullable: false),
                    BranchName = table.Column<string>(maxLength: 255, nullable: false),
                    BranchLinkMan = table.Column<string>(maxLength: 255, nullable: false),
                    BranchPhone = table.Column<string>(maxLength: 255, nullable: false),
                    BranchAddress = table.Column<string>(nullable: false),
                    BranchEmail = table.Column<string>(maxLength: 255, nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchInfos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BranchInfos");
        }
    }
}
