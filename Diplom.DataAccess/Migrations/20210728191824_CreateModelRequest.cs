using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Diplom.DataAccess.Migrations
{
    public partial class CreateModelRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Position",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Floor = table.Column<int>(nullable: false),
                    CoordX = table.Column<int>(nullable: false),
                    CoordY = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "State",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Type",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Request",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PositionId = table.Column<Guid>(nullable: false),
                    TypeId = table.Column<Guid>(nullable: false),
                    StateId = table.Column<Guid>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Request_Position_PositionId",
                        column: x => x.PositionId,
                        principalSchema: "dbo",
                        principalTable: "Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Request_State_StateId",
                        column: x => x.StateId,
                        principalSchema: "dbo",
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Request_Type_TypeId",
                        column: x => x.TypeId,
                        principalSchema: "dbo",
                        principalTable: "Type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Request_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Request_PositionId",
                schema: "dbo",
                table: "Request",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_StateId",
                schema: "dbo",
                table: "Request",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_TypeId",
                schema: "dbo",
                table: "Request",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_UserId",
                schema: "dbo",
                table: "Request",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Request",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Position",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "State",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Type",
                schema: "dbo");
        }
    }
}
