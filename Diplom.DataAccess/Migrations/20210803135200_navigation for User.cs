using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Diplom.DataAccess.Migrations
{
    public partial class navigationforUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "State",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("fa00ba20-32cc-4fee-b6b5-321450d1babd"), "New" },
                    { new Guid("55051c09-1801-4201-9df5-cd4ca91e367e"), "In progress" },
                    { new Guid("a0db2754-bcbf-4a7a-9694-4f115ab7006a"), "Finished" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Type",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("31218c05-9ca2-4da5-bd93-49b6c17399e5"), "Other" },
                    { new Guid("ab667a74-e731-4068-8f14-51bdb5d047f0"), "Need an employee" },
                    { new Guid("8c084f7d-9ea8-4985-a0c2-7a437f652721"), "Cargo transfer" },
                    { new Guid("c29c276a-954f-42f7-893b-47669242bb8b"), "Conflict" },
                    { new Guid("f3751341-56f7-41b8-9339-8c5351808bc0"), "Repair" },
                    { new Guid("8963b488-f9f7-4c3d-9de0-bd1d41fe6e5b"), "Cleaning" },
                    { new Guid("a4e37db9-489d-40c1-976f-1d1cf251b6e7"), "System failure" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserProfession",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1d026e3c-2771-4a18-9601-5079d39f49aa"), "Customs officer" },
                    { new Guid("f8c99607-b9c1-45c6-a238-c5a65649c545"), "Technician" },
                    { new Guid("f96eaf07-db32-460b-81a7-ca0c4607d480"), "Mechanic" },
                    { new Guid("f9c13c4e-6f3d-4233-ac3d-5180a84cae1a"), "Driver" },
                    { new Guid("267c9cc6-cffc-4139-8b3d-6c197acdc169"), "Loader" },
                    { new Guid("b4ddc1ba-3954-442e-b49d-b7fb8b31df51"), "Policeman" },
                    { new Guid("a7542bda-4eae-4a95-8eb0-ccb0496393d2"), "Dispatcher" },
                    { new Guid("f8359631-50ce-49c5-8076-cb43c70ffae2"), "Stewardess" },
                    { new Guid("29dcd7fd-0d89-4dbc-b477-9d47486d4162"), "Pilot" },
                    { new Guid("973a3cc5-2f19-4f23-8573-902c699933a9"), "Security" },
                    { new Guid("4451afb5-21b6-41c9-bd28-f7d8d277b333"), "Engineer" },
                    { new Guid("5be7eb35-2219-4dfa-a3ee-b954ca6f1d48"), "Plumber" },
                    { new Guid("8bd8887e-6e1d-4f8d-a7cc-5baf9ebfb7bb"), "Сleaning lady" },
                    { new Guid("02ca01c6-163f-4a7e-9df1-c445da83df8c"), "Cashier" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserState",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("9a75469b-5bee-41b8-aa3d-51c59f37a8ca"), "Busy" },
                    { new Guid("5f9db00d-5a49-4e00-814d-34ed136c41ae"), "Available" },
                    { new Guid("b0c9e384-9028-4cf1-abf0-5dd5c7fde994"), "Absent" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("55051c09-1801-4201-9df5-cd4ca91e367e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("a0db2754-bcbf-4a7a-9694-4f115ab7006a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("fa00ba20-32cc-4fee-b6b5-321450d1babd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("31218c05-9ca2-4da5-bd93-49b6c17399e5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("8963b488-f9f7-4c3d-9de0-bd1d41fe6e5b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("8c084f7d-9ea8-4985-a0c2-7a437f652721"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("a4e37db9-489d-40c1-976f-1d1cf251b6e7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("ab667a74-e731-4068-8f14-51bdb5d047f0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("c29c276a-954f-42f7-893b-47669242bb8b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("f3751341-56f7-41b8-9339-8c5351808bc0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("02ca01c6-163f-4a7e-9df1-c445da83df8c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("1d026e3c-2771-4a18-9601-5079d39f49aa"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("267c9cc6-cffc-4139-8b3d-6c197acdc169"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("29dcd7fd-0d89-4dbc-b477-9d47486d4162"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("4451afb5-21b6-41c9-bd28-f7d8d277b333"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("5be7eb35-2219-4dfa-a3ee-b954ca6f1d48"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("8bd8887e-6e1d-4f8d-a7cc-5baf9ebfb7bb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("973a3cc5-2f19-4f23-8573-902c699933a9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("a7542bda-4eae-4a95-8eb0-ccb0496393d2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("b4ddc1ba-3954-442e-b49d-b7fb8b31df51"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("f8359631-50ce-49c5-8076-cb43c70ffae2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("f8c99607-b9c1-45c6-a238-c5a65649c545"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("f96eaf07-db32-460b-81a7-ca0c4607d480"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("f9c13c4e-6f3d-4233-ac3d-5180a84cae1a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserState",
                keyColumn: "Id",
                keyValue: new Guid("5f9db00d-5a49-4e00-814d-34ed136c41ae"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserState",
                keyColumn: "Id",
                keyValue: new Guid("9a75469b-5bee-41b8-aa3d-51c59f37a8ca"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserState",
                keyColumn: "Id",
                keyValue: new Guid("b0c9e384-9028-4cf1-abf0-5dd5c7fde994"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

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
    }
}
