using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositories.Migrations
{
    public partial class DbSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cycle",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("b3f6717d-7479-4019-b6d5-060b12787652"), "name-0" },
                    { new Guid("e09ec1f3-7732-413d-b408-b1aca190a9cc"), "name-8" },
                    { new Guid("2a3ff6a1-f3d8-4944-8b22-6f9391796cf8"), "name-7" },
                    { new Guid("b0db237f-0805-40bc-9c89-a059c4c9a2bf"), "name-6" },
                    { new Guid("d01c5646-add0-49e8-94eb-5c730ab27445"), "name-5" },
                    { new Guid("8bde7b32-fa03-45ee-ad73-5c470d29dd1d"), "name-9" },
                    { new Guid("654669a6-db39-4c02-95d9-caa4578cf715"), "name-3" },
                    { new Guid("3882eaa8-647d-4cef-863b-f8aa0ae04b49"), "name-2" },
                    { new Guid("b3f633c6-fa6c-47a9-9ffa-e749fa3b77bb"), "name-1" },
                    { new Guid("963110e4-a6f1-4811-bc0f-91eee0a7d459"), "name-4" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("4bf1eb57-ddd9-472c-a33e-0ba3330d13e1"), "8@gmail.com", true },
                    { new Guid("7dee2681-8c8f-452b-9e65-6dbf80989ae8"), "0@gmail.com", true },
                    { new Guid("ad3e8f84-68b5-4b19-a038-7df592bdb02c"), "1@gmail.com", false },
                    { new Guid("e3e4187e-3cda-45bd-a8a3-8ea1800c92db"), "2@gmail.com", true },
                    { new Guid("cb7ff5c5-3d33-4c58-88f8-f737ac56b5a0"), "3@gmail.com", false },
                    { new Guid("a2de8e3c-95ce-4f06-8925-c5a4db998c83"), "4@gmail.com", true },
                    { new Guid("1b363cdc-a52e-4709-a282-ab5c58ea5ae2"), "5@gmail.com", false },
                    { new Guid("3dd712af-7292-4d7f-beb6-278a3d8b7c7e"), "6@gmail.com", true },
                    { new Guid("ef8eb889-0473-4be8-a75a-fbcfafca0260"), "7@gmail.com", false },
                    { new Guid("31a1dabb-5587-4e5b-94c5-b08e9a963d31"), "9@gmail.com", false }
                });

            migrationBuilder.InsertData(
                table: "CycleEmployees",
                columns: new[] { "Id", "CycleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("14e14201-7631-4d1a-a2f6-744622abe695"), new Guid("b3f6717d-7479-4019-b6d5-060b12787652"), new Guid("7dee2681-8c8f-452b-9e65-6dbf80989ae8") },
                    { new Guid("b5e668ad-dec5-4f69-ad40-428615aa616a"), new Guid("b3f6717d-7479-4019-b6d5-060b12787652"), new Guid("ad3e8f84-68b5-4b19-a038-7df592bdb02c") },
                    { new Guid("b5d43481-5c49-4576-a527-20744ef48913"), new Guid("b3f633c6-fa6c-47a9-9ffa-e749fa3b77bb"), new Guid("ad3e8f84-68b5-4b19-a038-7df592bdb02c") },
                    { new Guid("9ca1d954-b0e7-4550-9c31-a3e5e8df9915"), new Guid("b3f6717d-7479-4019-b6d5-060b12787652"), new Guid("e3e4187e-3cda-45bd-a8a3-8ea1800c92db") },
                    { new Guid("2c10bae4-5d5f-45d9-bd7c-68e8a3c6d859"), new Guid("3882eaa8-647d-4cef-863b-f8aa0ae04b49"), new Guid("e3e4187e-3cda-45bd-a8a3-8ea1800c92db") },
                    { new Guid("cb068945-2793-4689-9291-4bafbd21d631"), new Guid("b3f6717d-7479-4019-b6d5-060b12787652"), new Guid("cb7ff5c5-3d33-4c58-88f8-f737ac56b5a0") },
                    { new Guid("3ec5d09e-3e21-467d-b784-63e802419ca5"), new Guid("b3f6717d-7479-4019-b6d5-060b12787652"), new Guid("a2de8e3c-95ce-4f06-8925-c5a4db998c83") },
                    { new Guid("4ef170e4-eb06-4253-9cd3-7783df16c81e"), new Guid("3882eaa8-647d-4cef-863b-f8aa0ae04b49"), new Guid("a2de8e3c-95ce-4f06-8925-c5a4db998c83") },
                    { new Guid("ef1460a1-fa3c-461c-9e13-58534ce3e24f"), new Guid("b3f633c6-fa6c-47a9-9ffa-e749fa3b77bb"), new Guid("3dd712af-7292-4d7f-beb6-278a3d8b7c7e") },
                    { new Guid("28e4a5b7-104d-47dc-97a6-8d35f8e3e4ca"), new Guid("3882eaa8-647d-4cef-863b-f8aa0ae04b49"), new Guid("3dd712af-7292-4d7f-beb6-278a3d8b7c7e") },
                    { new Guid("5c98ea2d-63b4-4f49-be75-0c16c7d4fd1c"), new Guid("b3f633c6-fa6c-47a9-9ffa-e749fa3b77bb"), new Guid("ef8eb889-0473-4be8-a75a-fbcfafca0260") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cycle",
                keyColumn: "Id",
                keyValue: new Guid("2a3ff6a1-f3d8-4944-8b22-6f9391796cf8"));

            migrationBuilder.DeleteData(
                table: "Cycle",
                keyColumn: "Id",
                keyValue: new Guid("654669a6-db39-4c02-95d9-caa4578cf715"));

            migrationBuilder.DeleteData(
                table: "Cycle",
                keyColumn: "Id",
                keyValue: new Guid("8bde7b32-fa03-45ee-ad73-5c470d29dd1d"));

            migrationBuilder.DeleteData(
                table: "Cycle",
                keyColumn: "Id",
                keyValue: new Guid("963110e4-a6f1-4811-bc0f-91eee0a7d459"));

            migrationBuilder.DeleteData(
                table: "Cycle",
                keyColumn: "Id",
                keyValue: new Guid("b0db237f-0805-40bc-9c89-a059c4c9a2bf"));

            migrationBuilder.DeleteData(
                table: "Cycle",
                keyColumn: "Id",
                keyValue: new Guid("d01c5646-add0-49e8-94eb-5c730ab27445"));

            migrationBuilder.DeleteData(
                table: "Cycle",
                keyColumn: "Id",
                keyValue: new Guid("e09ec1f3-7732-413d-b408-b1aca190a9cc"));

            migrationBuilder.DeleteData(
                table: "CycleEmployees",
                keyColumn: "Id",
                keyValue: new Guid("14e14201-7631-4d1a-a2f6-744622abe695"));

            migrationBuilder.DeleteData(
                table: "CycleEmployees",
                keyColumn: "Id",
                keyValue: new Guid("28e4a5b7-104d-47dc-97a6-8d35f8e3e4ca"));

            migrationBuilder.DeleteData(
                table: "CycleEmployees",
                keyColumn: "Id",
                keyValue: new Guid("2c10bae4-5d5f-45d9-bd7c-68e8a3c6d859"));

            migrationBuilder.DeleteData(
                table: "CycleEmployees",
                keyColumn: "Id",
                keyValue: new Guid("3ec5d09e-3e21-467d-b784-63e802419ca5"));

            migrationBuilder.DeleteData(
                table: "CycleEmployees",
                keyColumn: "Id",
                keyValue: new Guid("4ef170e4-eb06-4253-9cd3-7783df16c81e"));

            migrationBuilder.DeleteData(
                table: "CycleEmployees",
                keyColumn: "Id",
                keyValue: new Guid("5c98ea2d-63b4-4f49-be75-0c16c7d4fd1c"));

            migrationBuilder.DeleteData(
                table: "CycleEmployees",
                keyColumn: "Id",
                keyValue: new Guid("9ca1d954-b0e7-4550-9c31-a3e5e8df9915"));

            migrationBuilder.DeleteData(
                table: "CycleEmployees",
                keyColumn: "Id",
                keyValue: new Guid("b5d43481-5c49-4576-a527-20744ef48913"));

            migrationBuilder.DeleteData(
                table: "CycleEmployees",
                keyColumn: "Id",
                keyValue: new Guid("b5e668ad-dec5-4f69-ad40-428615aa616a"));

            migrationBuilder.DeleteData(
                table: "CycleEmployees",
                keyColumn: "Id",
                keyValue: new Guid("cb068945-2793-4689-9291-4bafbd21d631"));

            migrationBuilder.DeleteData(
                table: "CycleEmployees",
                keyColumn: "Id",
                keyValue: new Guid("ef1460a1-fa3c-461c-9e13-58534ce3e24f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("1b363cdc-a52e-4709-a282-ab5c58ea5ae2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("31a1dabb-5587-4e5b-94c5-b08e9a963d31"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("4bf1eb57-ddd9-472c-a33e-0ba3330d13e1"));

            migrationBuilder.DeleteData(
                table: "Cycle",
                keyColumn: "Id",
                keyValue: new Guid("3882eaa8-647d-4cef-863b-f8aa0ae04b49"));

            migrationBuilder.DeleteData(
                table: "Cycle",
                keyColumn: "Id",
                keyValue: new Guid("b3f633c6-fa6c-47a9-9ffa-e749fa3b77bb"));

            migrationBuilder.DeleteData(
                table: "Cycle",
                keyColumn: "Id",
                keyValue: new Guid("b3f6717d-7479-4019-b6d5-060b12787652"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("3dd712af-7292-4d7f-beb6-278a3d8b7c7e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("7dee2681-8c8f-452b-9e65-6dbf80989ae8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("a2de8e3c-95ce-4f06-8925-c5a4db998c83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("ad3e8f84-68b5-4b19-a038-7df592bdb02c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("cb7ff5c5-3d33-4c58-88f8-f737ac56b5a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("e3e4187e-3cda-45bd-a8a3-8ea1800c92db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("ef8eb889-0473-4be8-a75a-fbcfafca0260"));
        }
    }
}
