using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class UpdateContactDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Name_Address_addressId",
                table: "Name");

            migrationBuilder.DropForeignKey(
                name: "FK_Name_Email_emailAddressId",
                table: "Name");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_Name_NameId",
                table: "WorkExperiences");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.DropIndex(
                name: "IX_WorkExperiences_NameId",
                table: "WorkExperiences");

            migrationBuilder.DropIndex(
                name: "IX_Name_addressId",
                table: "Name");

            migrationBuilder.DropIndex(
                name: "IX_Name_emailAddressId",
                table: "Name");

            migrationBuilder.DropColumn(
                name: "NameId",
                table: "WorkExperiences");

            migrationBuilder.DropColumn(
                name: "addressId",
                table: "Name");

            migrationBuilder.DropColumn(
                name: "emailAddressId",
                table: "Name");

            migrationBuilder.AddColumn<int>(
                name: "ContactDetailsId",
                table: "WorkExperiences",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "Name",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "emailAddress",
                table: "Name",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "postCode",
                table: "Name",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "street",
                table: "Name",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperiences_ContactDetailsId",
                table: "WorkExperiences",
                column: "ContactDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_Name_ContactDetailsId",
                table: "WorkExperiences",
                column: "ContactDetailsId",
                principalTable: "Name",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_Name_ContactDetailsId",
                table: "WorkExperiences");

            migrationBuilder.DropIndex(
                name: "IX_WorkExperiences_ContactDetailsId",
                table: "WorkExperiences");

            migrationBuilder.DropColumn(
                name: "ContactDetailsId",
                table: "WorkExperiences");

            migrationBuilder.DropColumn(
                name: "city",
                table: "Name");

            migrationBuilder.DropColumn(
                name: "emailAddress",
                table: "Name");

            migrationBuilder.DropColumn(
                name: "postCode",
                table: "Name");

            migrationBuilder.DropColumn(
                name: "street",
                table: "Name");

            migrationBuilder.AddColumn<int>(
                name: "NameId",
                table: "WorkExperiences",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "addressId",
                table: "Name",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "emailAddressId",
                table: "Name",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    postCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    street = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperiences_NameId",
                table: "WorkExperiences",
                column: "NameId");

            migrationBuilder.CreateIndex(
                name: "IX_Name_addressId",
                table: "Name",
                column: "addressId");

            migrationBuilder.CreateIndex(
                name: "IX_Name_emailAddressId",
                table: "Name",
                column: "emailAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Name_Address_addressId",
                table: "Name",
                column: "addressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Name_Email_emailAddressId",
                table: "Name",
                column: "emailAddressId",
                principalTable: "Email",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_Name_NameId",
                table: "WorkExperiences",
                column: "NameId",
                principalTable: "Name",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
