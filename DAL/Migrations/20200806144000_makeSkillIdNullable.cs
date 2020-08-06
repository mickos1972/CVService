using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class makeSkillIdNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Skills_SkillId",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Contact_ContactId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_ContactId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Skills");

            migrationBuilder.AlterColumn<int>(
                name: "SkillId",
                table: "Contact",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Skills_SkillId",
                table: "Contact",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Skills_SkillId",
                table: "Contact");

            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "Skills",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SkillId",
                table: "Contact",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_ContactId",
                table: "Skills",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Skills_SkillId",
                table: "Contact",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Contact_ContactId",
                table: "Skills",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "ContactId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
