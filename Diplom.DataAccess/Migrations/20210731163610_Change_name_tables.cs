using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Diplom.DataAccess.Migrations
{
    public partial class Change_name_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropColumn(
                name: "Number",
                schema: "dbo",
                table: "Request");

            migrationBuilder.AddColumn<Guid>(
                name: "ProfessionId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "StateId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "UserProfession",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfession", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserState",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserState", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ProfessionId",
                table: "AspNetUsers",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_StateId",
                table: "AspNetUsers",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_UserProfession_ProfessionId",
                table: "AspNetUsers",
                column: "ProfessionId",
                principalSchema: "dbo",
                principalTable: "UserProfession",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_UserState_StateId",
                table: "AspNetUsers",
                column: "StateId",
                principalSchema: "dbo",
                principalTable: "UserState",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_UserProfession_ProfessionId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_UserState_StateId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "UserProfession",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserState",
                schema: "dbo");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ProfessionId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_StateId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfessionId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "Number",
                schema: "dbo",
                table: "Request",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });
        }
    }
}
