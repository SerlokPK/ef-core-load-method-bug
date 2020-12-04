using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositories.Migrations
{
    public partial class CycleReviewerAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CycleEmployees_Users_UserId",
                table: "CycleEmployees");

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

            migrationBuilder.CreateTable(
                name: "CycleReviewer",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CycleEmployeeId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CycleReviewer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CycleReviewer_CycleEmployees_CycleEmployeeId",
                        column: x => x.CycleEmployeeId,
                        principalTable: "CycleEmployees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CycleReviewer_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Cycle",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("f980fbda-2d7e-43c2-84cd-5ae162a63912"), "name-0" },
                    { new Guid("5b1a103c-e83a-4337-ab98-b7929a30462d"), "name-8" },
                    { new Guid("8bbd2fc8-dd50-4642-b276-7c7ba044011b"), "name-7" },
                    { new Guid("ea1b0584-ab9e-448e-84b9-58448833d489"), "name-6" },
                    { new Guid("dbfb5b3c-ff5c-4fc8-a3e7-1ba2a68a80a7"), "name-5" },
                    { new Guid("1549b876-e789-4de9-be1d-6315a716a018"), "name-9" },
                    { new Guid("1fb7db84-0dcf-4b3a-90db-509db3a17c7b"), "name-3" },
                    { new Guid("b902950e-1690-4f89-919d-898670c64780"), "name-2" },
                    { new Guid("f0e4f1ad-bd88-4612-9ede-2b605c18b18b"), "name-1" },
                    { new Guid("37767d47-f4f2-4c9d-9435-4604a23295c2"), "name-4" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("d04da23c-4a4c-4228-952a-93f4088597d1"), "8@gmail.com", true },
                    { new Guid("42054507-aa28-4355-bd34-3864bba4dcc5"), "0@gmail.com", true },
                    { new Guid("ae70e283-d0d4-4469-a5b4-d558970a2824"), "1@gmail.com", false },
                    { new Guid("6e872f74-a484-4612-9834-449c10a41465"), "2@gmail.com", true },
                    { new Guid("cccb1389-d66c-48b6-99b5-d2c13a4ae38f"), "3@gmail.com", false },
                    { new Guid("e7570a77-53e5-461b-b7ab-cf2b74ae66fd"), "4@gmail.com", true },
                    { new Guid("48e76bb4-faef-45ec-af10-d2504c849d10"), "5@gmail.com", false },
                    { new Guid("258df23e-4b47-4947-bc67-6a618d99de5c"), "6@gmail.com", true },
                    { new Guid("87ef3eb0-b52b-4e03-af21-14cd8bf7c90e"), "7@gmail.com", false },
                    { new Guid("ce9de159-d7e4-4464-89d7-af37a6feb827"), "9@gmail.com", false }
                });

            migrationBuilder.InsertData(
                table: "CycleEmployees",
                columns: new[] { "Id", "CycleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("f1b9e3e6-c632-45b0-8afd-08574acff7a7"), new Guid("f980fbda-2d7e-43c2-84cd-5ae162a63912"), new Guid("42054507-aa28-4355-bd34-3864bba4dcc5") },
                    { new Guid("81807042-fb9f-4189-9a08-9c09c907607c"), new Guid("f980fbda-2d7e-43c2-84cd-5ae162a63912"), new Guid("ae70e283-d0d4-4469-a5b4-d558970a2824") },
                    { new Guid("24695590-d278-4920-a5fa-3c51ae992d87"), new Guid("f0e4f1ad-bd88-4612-9ede-2b605c18b18b"), new Guid("ae70e283-d0d4-4469-a5b4-d558970a2824") },
                    { new Guid("784ed426-44b7-4491-a4c2-3c1a2d7e282c"), new Guid("f980fbda-2d7e-43c2-84cd-5ae162a63912"), new Guid("6e872f74-a484-4612-9834-449c10a41465") },
                    { new Guid("f8ec40a6-715a-435c-b792-e7329cab4e39"), new Guid("b902950e-1690-4f89-919d-898670c64780"), new Guid("6e872f74-a484-4612-9834-449c10a41465") },
                    { new Guid("b99ca52a-f8e8-426f-a1b6-cbcc7b49c4c2"), new Guid("f980fbda-2d7e-43c2-84cd-5ae162a63912"), new Guid("cccb1389-d66c-48b6-99b5-d2c13a4ae38f") },
                    { new Guid("dd76dfb1-727a-44a9-bd89-407dd9613fb9"), new Guid("f980fbda-2d7e-43c2-84cd-5ae162a63912"), new Guid("e7570a77-53e5-461b-b7ab-cf2b74ae66fd") },
                    { new Guid("3722d0fc-df76-494e-8327-13a35e4677ff"), new Guid("b902950e-1690-4f89-919d-898670c64780"), new Guid("e7570a77-53e5-461b-b7ab-cf2b74ae66fd") },
                    { new Guid("6d4bac0c-e63e-479c-ac0f-901d0db9343d"), new Guid("f0e4f1ad-bd88-4612-9ede-2b605c18b18b"), new Guid("258df23e-4b47-4947-bc67-6a618d99de5c") },
                    { new Guid("ca997a5f-f1b4-40f5-940a-7f748446d2d8"), new Guid("b902950e-1690-4f89-919d-898670c64780"), new Guid("258df23e-4b47-4947-bc67-6a618d99de5c") },
                    { new Guid("7273f6f3-b800-422c-a9a2-bd016740d076"), new Guid("f0e4f1ad-bd88-4612-9ede-2b605c18b18b"), new Guid("87ef3eb0-b52b-4e03-af21-14cd8bf7c90e") }
                });

            migrationBuilder.InsertData(
                table: "CycleReviewer",
                columns: new[] { "Id", "CycleEmployeeId", "UserId" },
                values: new object[] { new Guid("197e04c6-bd0d-407e-aa5c-bf0ec86a6e1b"), new Guid("f1b9e3e6-c632-45b0-8afd-08574acff7a7"), new Guid("42054507-aa28-4355-bd34-3864bba4dcc5") });

            migrationBuilder.CreateIndex(
                name: "IX_CycleReviewer_CycleEmployeeId",
                table: "CycleReviewer",
                column: "CycleEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CycleReviewer_UserId",
                table: "CycleReviewer",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CycleEmployees_Users_UserId",
                table: "CycleEmployees",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CycleEmployees_Users_UserId",
                table: "CycleEmployees");

            migrationBuilder.DropTable(
                name: "CycleReviewer");

            migrationBuilder.DeleteData(
                table: "Cycle",
                keyColumn: "Id",
                keyValue: new Guid("1549b876-e789-4de9-be1d-6315a716a018"));

            migrationBuilder.DeleteData(
                table: "Cycle",
                keyColumn: "Id",
                keyValue: new Guid("1fb7db84-0dcf-4b3a-90db-509db3a17c7b"));

            migrationBuilder.DeleteData(
                table: "Cycle",
                keyColumn: "Id",
                keyValue: new Guid("37767d47-f4f2-4c9d-9435-4604a23295c2"));

            migrationBuilder.DeleteData(
                table: "Cycle",
                keyColumn: "Id",
                keyValue: new Guid("5b1a103c-e83a-4337-ab98-b7929a30462d"));

            migrationBuilder.DeleteData(
                table: "Cycle",
                keyColumn: "Id",
                keyValue: new Guid("8bbd2fc8-dd50-4642-b276-7c7ba044011b"));

            migrationBuilder.DeleteData(
                table: "Cycle",
                keyColumn: "Id",
                keyValue: new Guid("dbfb5b3c-ff5c-4fc8-a3e7-1ba2a68a80a7"));

            migrationBuilder.DeleteData(
                table: "Cycle",
                keyColumn: "Id",
                keyValue: new Guid("ea1b0584-ab9e-448e-84b9-58448833d489"));

            migrationBuilder.DeleteData(
                table: "CycleEmployees",
                keyColumn: "Id",
                keyValue: new Guid("24695590-d278-4920-a5fa-3c51ae992d87"));

            migrationBuilder.DeleteData(
                table: "CycleEmployees",
                keyColumn: "Id",
                keyValue: new Guid("3722d0fc-df76-494e-8327-13a35e4677ff"));

            migrationBuilder.DeleteData(
                table: "CycleEmployees",
                keyColumn: "Id",
                keyValue: new Guid("6d4bac0c-e63e-479c-ac0f-901d0db9343d"));

            migrationBuilder.DeleteData(
                table: "CycleEmployees",
                keyColumn: "Id",
                keyValue: new Guid("7273f6f3-b800-422c-a9a2-bd016740d076"));

            migrationBuilder.DeleteData(
                table: "CycleEmployees",
                keyColumn: "Id",
                keyValue: new Guid("784ed426-44b7-4491-a4c2-3c1a2d7e282c"));

            migrationBuilder.DeleteData(
                table: "CycleEmployees",
                keyColumn: "Id",
                keyValue: new Guid("81807042-fb9f-4189-9a08-9c09c907607c"));

            migrationBuilder.DeleteData(
                table: "CycleEmployees",
                keyColumn: "Id",
                keyValue: new Guid("b99ca52a-f8e8-426f-a1b6-cbcc7b49c4c2"));

            migrationBuilder.DeleteData(
                table: "CycleEmployees",
                keyColumn: "Id",
                keyValue: new Guid("ca997a5f-f1b4-40f5-940a-7f748446d2d8"));

            migrationBuilder.DeleteData(
                table: "CycleEmployees",
                keyColumn: "Id",
                keyValue: new Guid("dd76dfb1-727a-44a9-bd89-407dd9613fb9"));

            migrationBuilder.DeleteData(
                table: "CycleEmployees",
                keyColumn: "Id",
                keyValue: new Guid("f1b9e3e6-c632-45b0-8afd-08574acff7a7"));

            migrationBuilder.DeleteData(
                table: "CycleEmployees",
                keyColumn: "Id",
                keyValue: new Guid("f8ec40a6-715a-435c-b792-e7329cab4e39"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("48e76bb4-faef-45ec-af10-d2504c849d10"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("ce9de159-d7e4-4464-89d7-af37a6feb827"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("d04da23c-4a4c-4228-952a-93f4088597d1"));

            migrationBuilder.DeleteData(
                table: "Cycle",
                keyColumn: "Id",
                keyValue: new Guid("b902950e-1690-4f89-919d-898670c64780"));

            migrationBuilder.DeleteData(
                table: "Cycle",
                keyColumn: "Id",
                keyValue: new Guid("f0e4f1ad-bd88-4612-9ede-2b605c18b18b"));

            migrationBuilder.DeleteData(
                table: "Cycle",
                keyColumn: "Id",
                keyValue: new Guid("f980fbda-2d7e-43c2-84cd-5ae162a63912"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("258df23e-4b47-4947-bc67-6a618d99de5c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("42054507-aa28-4355-bd34-3864bba4dcc5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("6e872f74-a484-4612-9834-449c10a41465"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("87ef3eb0-b52b-4e03-af21-14cd8bf7c90e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("ae70e283-d0d4-4469-a5b4-d558970a2824"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("cccb1389-d66c-48b6-99b5-d2c13a4ae38f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("e7570a77-53e5-461b-b7ab-cf2b74ae66fd"));

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

            migrationBuilder.AddForeignKey(
                name: "FK_CycleEmployees_Users_UserId",
                table: "CycleEmployees",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
