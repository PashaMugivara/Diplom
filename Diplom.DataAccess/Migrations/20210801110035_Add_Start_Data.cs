using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Diplom.DataAccess.Migrations
{
    public partial class Add_Start_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "State",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("40fef3f4-3c91-412e-8acc-50d9da5a260c"), "New" },
                    { new Guid("ba3e686e-dccf-43ee-bf8c-96752022401a"), "In progress" },
                    { new Guid("a455cbb0-2eb7-4853-ac70-a2a745352ce4"), "Finished" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Type",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6db3c78a-5777-4828-b29d-696217f1a039"), "Other" },
                    { new Guid("f8467a92-7892-42a6-9a41-1744bffd42b7"), "Need an employee" },
                    { new Guid("f3137045-f3fe-4f4a-b044-3cd92c6cf93c"), "Cargo transfer" },
                    { new Guid("2510d9b3-273d-4279-aeab-f3dbaa354300"), "Conflict" },
                    { new Guid("59733b54-376d-461c-ae90-9dc4bc607451"), "Repair" },
                    { new Guid("1ca550a7-8991-4cbe-a691-c151e3fe4cc0"), "Cleaning" },
                    { new Guid("60e328e1-64dd-4798-860d-161eb6aca2a3"), "System failure" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserProfession",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("06052d98-3633-4049-b429-6bd627ae78db"), "Customs officer" },
                    { new Guid("bf3ed7e3-a7dc-45b3-9a10-133221bf1934"), "Technician" },
                    { new Guid("8e787257-ad6c-4470-b9bd-ba0bf594cc3c"), "Mechanic" },
                    { new Guid("27c66a20-9fb2-465f-8e42-15fa20feb2f1"), "Driver" },
                    { new Guid("e5d59f97-bb27-495a-82f8-7b3eafab992b"), "Loader" },
                    { new Guid("c15afb2c-0d88-4d0c-983b-a6c6f7baca02"), "Policeman" },
                    { new Guid("a0452614-81de-4a75-88e0-e87956a2189e"), "Dispatcher" },
                    { new Guid("339fc2c0-6ecf-48e2-a076-aeab62b30275"), "Stewardess" },
                    { new Guid("516fe2cb-14cc-4273-8457-ca822f1cafa0"), "Pilot" },
                    { new Guid("c904ad13-ed03-430e-ae6b-05efd6c0bc31"), "Security" },
                    { new Guid("f11c0c83-5a91-44a6-af03-ea3222919ef5"), "Engineer" },
                    { new Guid("ad90bcfc-0e5a-4bb3-b013-f08e801a1933"), "Plumber" },
                    { new Guid("90aceb66-9981-4e71-a886-9a84170dc047"), "Сleaning lady" },
                    { new Guid("ecc35211-08d9-43bc-8f5d-44a8d246a773"), "Cashier" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserState",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("69403fa2-506b-43b5-90d2-f296d071cf36"), "Busy" },
                    { new Guid("7d2a6178-37fb-4c73-9000-f443d471a228"), "Available" },
                    { new Guid("ec974cdf-2592-4b67-b858-a43832284441"), "Absent" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("40fef3f4-3c91-412e-8acc-50d9da5a260c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("a455cbb0-2eb7-4853-ac70-a2a745352ce4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("ba3e686e-dccf-43ee-bf8c-96752022401a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("1ca550a7-8991-4cbe-a691-c151e3fe4cc0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("2510d9b3-273d-4279-aeab-f3dbaa354300"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("59733b54-376d-461c-ae90-9dc4bc607451"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("60e328e1-64dd-4798-860d-161eb6aca2a3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("6db3c78a-5777-4828-b29d-696217f1a039"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("f3137045-f3fe-4f4a-b044-3cd92c6cf93c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("f8467a92-7892-42a6-9a41-1744bffd42b7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("06052d98-3633-4049-b429-6bd627ae78db"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("27c66a20-9fb2-465f-8e42-15fa20feb2f1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("339fc2c0-6ecf-48e2-a076-aeab62b30275"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("516fe2cb-14cc-4273-8457-ca822f1cafa0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("8e787257-ad6c-4470-b9bd-ba0bf594cc3c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("90aceb66-9981-4e71-a886-9a84170dc047"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("a0452614-81de-4a75-88e0-e87956a2189e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("ad90bcfc-0e5a-4bb3-b013-f08e801a1933"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("bf3ed7e3-a7dc-45b3-9a10-133221bf1934"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("c15afb2c-0d88-4d0c-983b-a6c6f7baca02"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("c904ad13-ed03-430e-ae6b-05efd6c0bc31"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("e5d59f97-bb27-495a-82f8-7b3eafab992b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("ecc35211-08d9-43bc-8f5d-44a8d246a773"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("f11c0c83-5a91-44a6-af03-ea3222919ef5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserState",
                keyColumn: "Id",
                keyValue: new Guid("69403fa2-506b-43b5-90d2-f296d071cf36"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserState",
                keyColumn: "Id",
                keyValue: new Guid("7d2a6178-37fb-4c73-9000-f443d471a228"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserState",
                keyColumn: "Id",
                keyValue: new Guid("ec974cdf-2592-4b67-b858-a43832284441"));
        }
    }
}
