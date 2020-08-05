using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class oneotone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactDetails_Skills_skillsId",
                table: "ContactDetails");

            migrationBuilder.DropIndex(
                name: "IX_ContactDetails_skillsId",
                table: "ContactDetails");

            migrationBuilder.DropColumn(
                name: "skillsId",
                table: "ContactDetails");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_ContactsDetailsId",
                table: "Skills",
                column: "ContactsDetailsId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_ContactDetails_ContactsDetailsId",
                table: "Skills",
                column: "ContactsDetailsId",
                principalTable: "ContactDetails",
                principalColumn: "ContactsDetailsId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_ContactDetails_ContactsDetailsId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_ContactsDetailsId",
                table: "Skills");

            migrationBuilder.AddColumn<int>(
                name: "skillsId",
                table: "ContactDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactDetails_skillsId",
                table: "ContactDetails",
                column: "skillsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactDetails_Skills_skillsId",
                table: "ContactDetails",
                column: "skillsId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
