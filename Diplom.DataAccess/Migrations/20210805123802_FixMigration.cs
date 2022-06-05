using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Diplom.DataAccess.Migrations
{
    public partial class FixMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("63c78982-ff08-4634-8aca-7ef3ef30f589"), "Новый" },
                    { new Guid("bde5fc81-a65f-415a-9296-0515478c3fd1"), "В процессе" },
                    { new Guid("63ce1cf5-71bf-4247-b004-bde07df6240f"), "Завершен" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Type",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("50950454-35b4-49a6-bc78-3b87c322ae56"), "Иное" },
                    { new Guid("ea9afcc0-cb5b-4b68-b271-61be427b247e"), "Требуется присутствие" },
                    { new Guid("e1ba4c93-4b01-41e3-82e9-315f5ee20ee6"), "Перевозка грузов" },
                    { new Guid("01b1bb2e-7e04-4cc2-83e4-48d98025f3ad"), "Конфликт" },
                    { new Guid("c3443392-7d55-4180-aa4e-0a5af5bd23da"), "Ремонт" },
                    { new Guid("c40a1794-de60-4445-a7ea-f2fb652322d5"), "Уборка" },
                    { new Guid("b0605dbc-1b48-496c-bfbb-0dcb02b39eef"), "Системная ошибка" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserProfession",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("d36b3f39-67fb-4f39-bd72-862c818eb4a9"), "Таможенник" },
                    { new Guid("91739976-25b5-4032-a270-e85ecd331a93"), "Техник" },
                    { new Guid("7661ebaf-dac0-45e4-888e-bfe4afe013f2"), "Механик" },
                    { new Guid("9049a62b-2b9f-4ed9-87e1-538d72c0d76d"), "Водитель" },
                    { new Guid("d3ad2c90-43a2-48ef-88b2-274ef8ac1487"), "Грузчик" },
                    { new Guid("d22ce10d-416b-47f0-9372-0c00893757e5"), "Полицейский" },
                    { new Guid("2138a928-d593-4bca-b09d-f0d5d6e6fe64"), "Диспетчер" },
                    { new Guid("d53e2bb4-faea-4cd6-90ab-e854ef8fea6f"), "Стюардесса" },
                    { new Guid("c4084429-2d75-4212-a253-0295deebb8c3"), "Пилот" },
                    { new Guid("70e82c1c-3eed-4674-9d4c-6a8c5e956268"), "Охранник" },
                    { new Guid("55cbe14a-f324-4982-b9ed-df4a843fdc95"), "Инженер" },
                    { new Guid("1bcc8489-18b6-45a5-b1a2-fbc969dec4dd"), "Сантехник" },
                    { new Guid("bc8b80ba-6f5f-460f-99f0-fefe28370482"), "Уборщица" },
                    { new Guid("f7af46c3-6794-4542-9d96-3ea55ac685f2"), "Кассир" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserState",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("ad1298c4-cc10-47b5-98d7-3f554033b8a2"), "Busy" },
                    { new Guid("bd4ff67f-b372-4207-a2f1-5ceb538c5eac"), "Available" },
                    { new Guid("cc8f829e-45b7-4541-8b37-1934af3a4b8b"), "Absent" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("63c78982-ff08-4634-8aca-7ef3ef30f589"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("63ce1cf5-71bf-4247-b004-bde07df6240f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("bde5fc81-a65f-415a-9296-0515478c3fd1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("01b1bb2e-7e04-4cc2-83e4-48d98025f3ad"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("50950454-35b4-49a6-bc78-3b87c322ae56"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("b0605dbc-1b48-496c-bfbb-0dcb02b39eef"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("c3443392-7d55-4180-aa4e-0a5af5bd23da"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("c40a1794-de60-4445-a7ea-f2fb652322d5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("e1ba4c93-4b01-41e3-82e9-315f5ee20ee6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("ea9afcc0-cb5b-4b68-b271-61be427b247e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("1bcc8489-18b6-45a5-b1a2-fbc969dec4dd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("2138a928-d593-4bca-b09d-f0d5d6e6fe64"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("55cbe14a-f324-4982-b9ed-df4a843fdc95"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("70e82c1c-3eed-4674-9d4c-6a8c5e956268"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("7661ebaf-dac0-45e4-888e-bfe4afe013f2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("9049a62b-2b9f-4ed9-87e1-538d72c0d76d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("91739976-25b5-4032-a270-e85ecd331a93"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("bc8b80ba-6f5f-460f-99f0-fefe28370482"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("c4084429-2d75-4212-a253-0295deebb8c3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("d22ce10d-416b-47f0-9372-0c00893757e5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("d36b3f39-67fb-4f39-bd72-862c818eb4a9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("d3ad2c90-43a2-48ef-88b2-274ef8ac1487"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("d53e2bb4-faea-4cd6-90ab-e854ef8fea6f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfession",
                keyColumn: "Id",
                keyValue: new Guid("f7af46c3-6794-4542-9d96-3ea55ac685f2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserState",
                keyColumn: "Id",
                keyValue: new Guid("ad1298c4-cc10-47b5-98d7-3f554033b8a2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserState",
                keyColumn: "Id",
                keyValue: new Guid("bd4ff67f-b372-4207-a2f1-5ceb538c5eac"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserState",
                keyColumn: "Id",
                keyValue: new Guid("cc8f829e-45b7-4541-8b37-1934af3a4b8b"));

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
        }
    }
}
