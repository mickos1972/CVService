using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "SkillId", "Description" },
                values: new object[] { 1, "C++" });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "ContactId", "SkillId", "city", "emailAddress", "firstName", "lastName", "postCode", "street" },
                values: new object[] { 1, 1, null, "bounter@hunters.com", "bobba", "fett", null, null });

            migrationBuilder.InsertData(
                table: "WorkExperiences",
                columns: new[] { "Id", "ContactId", "duties", "from", "to" },
                values: new object[] { 1, 1, "hunting smugglers", new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 8, 14, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WorkExperiences",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 1);
        }
    }
}
