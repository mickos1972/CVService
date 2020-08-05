using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class UpdateName2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Name_Skills_skillsId",
                table: "Name");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_Name_ContactDetailsId",
                table: "WorkExperiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Name",
                table: "Name");

            migrationBuilder.RenameTable(
                name: "Name",
                newName: "ContactDetails");

            migrationBuilder.RenameIndex(
                name: "IX_Name_skillsId",
                table: "ContactDetails",
                newName: "IX_ContactDetails_skillsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactDetails",
                table: "ContactDetails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactDetails_Skills_skillsId",
                table: "ContactDetails",
                column: "skillsId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_ContactDetails_ContactDetailsId",
                table: "WorkExperiences",
                column: "ContactDetailsId",
                principalTable: "ContactDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactDetails_Skills_skillsId",
                table: "ContactDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_ContactDetails_ContactDetailsId",
                table: "WorkExperiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactDetails",
                table: "ContactDetails");

            migrationBuilder.RenameTable(
                name: "ContactDetails",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_ContactDetails_skillsId",
                table: "Name",
                newName: "IX_Name_skillsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Name",
                table: "Name",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Name_Skills_skillsId",
                table: "Name",
                column: "skillsId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_Name_ContactDetailsId",
                table: "WorkExperiences",
                column: "ContactDetailsId",
                principalTable: "Name",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
