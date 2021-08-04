using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Diplom.DataAccess.Migrations
{
    public partial class CreateMission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Mission",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    RequestId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mission_Request_RequestId",
                        column: x => x.RequestId,
                        principalSchema: "dbo",
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mission_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "State",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("91c4ffdd-31b5-4d56-a671-03af04bb7edb"), "New" },
                    { new Guid("c67b0dda-1e45-4514-94b9-f1c6b79b4b8d"), "In progress" },
                    { new Guid("f4124b2b-bf90-47dd-9690-e8f37f6724eb"), "Finished" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Type",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("93387b01-22a3-4ba5-9274-7078a0721749"), "Other" },
                    { new Guid("4d6f9dd2-ae65-40b2-bc8b-85f4d43019dc"), "Need an employee" },
                    { new Guid("f19e2f86-a08a-490c-b5c9-fbe9664c5c9a"), "Cargo transfer" },
                    { new Guid("6b145e80-0f4d-4132-947c-bb4f38ce0c8a"), "Conflict" },
                    { new Guid("1df9acdd-645d-4fe9-9139-41b3ec654377"), "Repair" },
                    { new Guid("632ba6b6-f635-47a0-aa38-7fa19ffd03e6"), "Cleaning" },
                    { new Guid("a6ff2224-ce50-4dd6-a21a-106a4e301d2a"), "System failure" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserProfession",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("095fe0de-e13b-430a-9cc3-913f7c2e7a73"), "Customs officer" },
                    { new Guid("23cca6f9-e3bc-4e7b-9d1b-837f90fd8563"), "Technician" },
                    { new Guid("2e599c0d-b31d-4f19-b10d-896adf747f4d"), "Mechanic" },
                    { new Guid("780fdcc9-458b-4be4-89ea-6abb4dc22947"), "Driver" },
                    { new Guid("2694b7d2-0cd4-460f-adce-d81f608fad82"), "Loader" },
                    { new Guid("7d048b98-a2f8-4ffc-9f89-dad94de653f1"), "Policeman" },
                    { new Guid("57de9b41-d450-4ec3-862d-cfd88db38731"), "Dispatcher" },
                    { new Guid("c1d74985-dbdb-4501-8a96-04ccca633ada"), "Stewardess" },
                    { new Guid("1ed4ed69-af89-4202-b1be-7024d7f433d9"), "Pilot" },
                    { new Guid("775e9c44-6051-45c9-9924-61eec4e15c52"), "Security" },
                    { new Guid("f9688d0e-15c5-496c-9dc2-f2738b9bd8d5"), "Engineer" },
                    { new Guid("fb531ab3-3837-471f-a1b3-680b36186523"), "Plumber" },
                    { new Guid("a9584d90-64cb-44cd-bfc0-d5d26af7be53"), "Сleaning lady" },
                    { new Guid("c030467f-fb00-42e6-8940-b87984db2280"), "Cashier" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserState",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("51d871d1-fd66-40f1-958c-71f944def0dd"), "Busy" },
                    { new Guid("d8c966f3-1b51-419b-aa63-952e170ad899"), "Available" },
                    { new Guid("7a28bdde-100a-4413-a39c-f375bb2835c2"), "Absent" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mission_RequestId",
                schema: "dbo",
                table: "Mission",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Mission_UserId",
                schema: "dbo",
                table: "Mission",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mission",
                schema: "dbo");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("91c4ffdd-31b5-4d56-a671-03af04bb7edb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("c67b0dda-1e45-4514-94b9-f1c6b79b4b8d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("f4124b2b-bf90-47dd-9690-e8f37f6724eb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("1df9acdd-645d-4fe9-9139-41b3ec654377"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("4d6f9dd2-ae65-40b2-bc8b-85f4d43019dc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("632ba6b6-f635-47a0-aa38-7fa19ffd03e6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("6b145e80-0f4d-4132-947c-bb4f38ce0c8a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("93387b01-22a3-4ba5-9274-7078a0721749"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("a6ff2224-ce50-4dd6-a21a-106a4e301d2a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("f19e2f86-a08a-490c-b5c9-fbe9664c5c9a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("095fe0de-e13b-430a-9cc3-913f7c2e7a73"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("1ed4ed69-af89-4202-b1be-7024d7f433d9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("23cca6f9-e3bc-4e7b-9d1b-837f90fd8563"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("2694b7d2-0cd4-460f-adce-d81f608fad82"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("2e599c0d-b31d-4f19-b10d-896adf747f4d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("57de9b41-d450-4ec3-862d-cfd88db38731"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("775e9c44-6051-45c9-9924-61eec4e15c52"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("780fdcc9-458b-4be4-89ea-6abb4dc22947"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("7d048b98-a2f8-4ffc-9f89-dad94de653f1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("a9584d90-64cb-44cd-bfc0-d5d26af7be53"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("c030467f-fb00-42e6-8940-b87984db2280"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("c1d74985-dbdb-4501-8a96-04ccca633ada"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("f9688d0e-15c5-496c-9dc2-f2738b9bd8d5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("fb531ab3-3837-471f-a1b3-680b36186523"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserState",
                keyColumn: "Id",
                keyValue: new Guid("51d871d1-fd66-40f1-958c-71f944def0dd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserState",
                keyColumn: "Id",
                keyValue: new Guid("7a28bdde-100a-4413-a39c-f375bb2835c2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserState",
                keyColumn: "Id",
                keyValue: new Guid("d8c966f3-1b51-419b-aa63-952e170ad899"));

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
    }
}
