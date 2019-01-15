using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DgCorER.Migrations
{
    public partial class BalancesAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result",
                table: "AbpUserLoginAttempts",
                newName: "IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Res~");

            migrationBuilder.RenameIndex(
                name: "IX_AbpNotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId",
                table: "AbpNotificationSubscriptions",
                newName: "IX_AbpNotificationSubscriptions_TenantId_NotificationName_Enti~");

            migrationBuilder.RenameIndex(
                name: "IX_AbpNotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId",
                table: "AbpNotificationSubscriptions",
                newName: "IX_AbpNotificationSubscriptions_NotificationName_EntityTypeNam~");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpUserTokens",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpUsers",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpUserRoles",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpUserOrganizationUnits",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpUserLogins",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpUserLoginAttempts",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpUserClaims",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpUserAccounts",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpTenants",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpSettings",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpRoles",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpRoleClaims",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpPermissions",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpOrganizationUnits",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpLanguageTexts",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpLanguages",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpFeatures",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpEntityPropertyChanges",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpEntityChangeSets",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpEntityChanges",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpEditions",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpBackgroundJobs",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpAuditLogs",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Res~",
                table: "AbpUserLoginAttempts",
                newName: "IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result");

            migrationBuilder.RenameIndex(
                name: "IX_AbpNotificationSubscriptions_TenantId_NotificationName_Enti~",
                table: "AbpNotificationSubscriptions",
                newName: "IX_AbpNotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpNotificationSubscriptions_NotificationName_EntityTypeNam~",
                table: "AbpNotificationSubscriptions",
                newName: "IX_AbpNotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpUserTokens",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpUsers",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpUserRoles",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpUserOrganizationUnits",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpUserLogins",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpUserLoginAttempts",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpUserClaims",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpUserAccounts",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpTenants",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpSettings",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpRoles",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpRoleClaims",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpPermissions",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpOrganizationUnits",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpLanguageTexts",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpLanguages",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpFeatures",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpEntityPropertyChanges",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpEntityChangeSets",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpEntityChanges",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpEditions",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpBackgroundJobs",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AbpAuditLogs",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);
        }
    }
}
