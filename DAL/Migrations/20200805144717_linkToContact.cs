using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class linkToContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_ContactDetails_ContactDetailsId",
                table: "WorkExperiences");

            migrationBuilder.DropIndex(
                name: "IX_WorkExperiences_ContactDetailsId",
                table: "WorkExperiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactDetails",
                table: "ContactDetails");

            migrationBuilder.DropColumn(
                name: "ContactDetailsId",
                table: "WorkExperiences");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ContactDetails");

            migrationBuilder.AddColumn<int>(
                name: "ContactDetailsContactsDetailsId",
                table: "WorkExperiences",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContactsDetailsId",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ContactsDetailsId",
                table: "ContactDetails",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactDetails",
                table: "ContactDetails",
                column: "ContactsDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperiences_ContactDetailsContactsDetailsId",
                table: "WorkExperiences",
                column: "ContactDetailsContactsDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_ContactDetails_ContactDetailsContactsDetailsId",
                table: "WorkExperiences",
                column: "ContactDetailsContactsDetailsId",
                principalTable: "ContactDetails",
                principalColumn: "ContactsDetailsId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_ContactDetails_ContactDetailsContactsDetailsId",
                table: "WorkExperiences");

            migrationBuilder.DropIndex(
                name: "IX_WorkExperiences_ContactDetailsContactsDetailsId",
                table: "WorkExperiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactDetails",
                table: "ContactDetails");

            migrationBuilder.DropColumn(
                name: "ContactDetailsContactsDetailsId",
                table: "WorkExperiences");

            migrationBuilder.DropColumn(
                name: "ContactsDetailsId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ContactsDetailsId",
                table: "ContactDetails");

            migrationBuilder.AddColumn<int>(
                name: "ContactDetailsId",
                table: "WorkExperiences",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ContactDetails",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactDetails",
                table: "ContactDetails",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperiences_ContactDetailsId",
                table: "WorkExperiences",
                column: "ContactDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_ContactDetails_ContactDetailsId",
                table: "WorkExperiences",
                column: "ContactDetailsId",
                principalTable: "ContactDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
