using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_Contact_ContactId",
                table: "WorkExperiences");

            migrationBuilder.AlterColumn<int>(
                name: "ContactId",
                table: "WorkExperiences",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "Skills",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_ContactId",
                table: "Skills",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Contact_ContactId",
                table: "Skills",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "ContactId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_Contact_ContactId",
                table: "WorkExperiences",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "ContactId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Contact_ContactId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_Contact_ContactId",
                table: "WorkExperiences");

            migrationBuilder.DropIndex(
                name: "IX_Skills_ContactId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Skills");

            migrationBuilder.AlterColumn<int>(
                name: "ContactId",
                table: "WorkExperiences",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_Contact_ContactId",
                table: "WorkExperiences",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "ContactId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
