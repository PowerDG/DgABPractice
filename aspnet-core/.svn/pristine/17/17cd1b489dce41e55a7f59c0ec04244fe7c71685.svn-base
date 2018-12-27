using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RQCore.Migrations
{
    public partial class updatemysql2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BillInfos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BillNo = table.Column<int>(nullable: false),
                    IsCandidate = table.Column<bool>(nullable: false),
                    Version = table.Column<int>(nullable: false),
                    SendBranchID = table.Column<string>(nullable: true),
                    BillCheck = table.Column<bool>(nullable: false),
                    BillStateID = table.Column<int>(nullable: false),
                    ExpressBillNo = table.Column<int>(nullable: true),
                    ExpressNo = table.Column<string>(nullable: true),
                    Secondary_contact = table.Column<string>(nullable: true),
                    Secondary_Tel = table.Column<int>(nullable: false),
                    MerchandiserName = table.Column<string>(nullable: true),
                    CompanyAbbreviation = table.Column<string>(nullable: true),
                    ShipperCompanyName = table.Column<string>(nullable: true),
                    ShipperAccount_No = table.Column<string>(nullable: true),
                    ShipperName = table.Column<string>(nullable: true),
                    ShipperTel = table.Column<string>(nullable: true),
                    ShipperPostCode = table.Column<string>(nullable: true),
                    ShipperCity = table.Column<string>(nullable: true),
                    ShipperProvince = table.Column<string>(nullable: true),
                    ShipperAddress = table.Column<string>(nullable: true),
                    ReceiversCompanyName = table.Column<string>(nullable: true),
                    ReceiversAccount_No = table.Column<string>(nullable: true),
                    ReceiversName = table.Column<string>(nullable: true),
                    ReceivingTel = table.Column<string>(nullable: true),
                    ReceivingPostCode = table.Column<string>(nullable: true),
                    ReceivingCity = table.Column<string>(nullable: true),
                    ReceivingProvince = table.Column<string>(nullable: true),
                    ReceivingAddress = table.Column<string>(nullable: true),
                    Totalnumberofpackages = table.Column<string>(nullable: true),
                    Totalweight = table.Column<string>(nullable: true),
                    Volume = table.Column<string>(nullable: true),
                    Measurementrules = table.Column<string>(nullable: true),
                    Volume_weight = table.Column<string>(nullable: true),
                    Chargeableweight = table.Column<string>(nullable: true),
                    Has_return = table.Column<bool>(nullable: false),
                    SERVICELEVEL = table.Column<string>(nullable: true),
                    TransportationMode = table.Column<string>(nullable: true),
                    Receivingdates = table.Column<string>(nullable: true),
                    CONTENT = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    HasInsured = table.Column<bool>(nullable: false),
                    PaymentType = table.Column<string>(nullable: true),
                    CHARGES = table.Column<string>(nullable: true),
                    TRANSPORTATION = table.Column<string>(nullable: true),
                    OTHER = table.Column<string>(nullable: true),
                    Tax_point = table.Column<bool>(nullable: false),
                    Distribution = table.Column<string>(nullable: true),
                    Delivery = table.Column<string>(nullable: true),
                    Transfer = table.Column<string>(nullable: true),
                    Packing = table.Column<string>(nullable: true),
                    Pallet = table.Column<string>(nullable: true),
                    Upstairs = table.Column<string>(nullable: true),
                    Other_fees = table.Column<bool>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    TOTAL_CHARGES = table.Column<string>(nullable: true),
                    The_cost = table.Column<string>(nullable: true),
                    BillImgUrl = table.Column<string>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillInfos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillInfos");
        }
    }
}
