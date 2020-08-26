using Microsoft.EntityFrameworkCore.Migrations;

namespace Crud_App.Migrations
{
    public partial class updatenames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "phonenumber",
                table: "User",
                newName: "Phonenumber");

            migrationBuilder.RenameColumn(
                name: "notes",
                table: "User",
                newName: "Notes");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "User",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "User",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "domain",
                table: "User",
                newName: "Domain");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "User",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "User",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Domain",
                table: "User",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phonenumber",
                table: "User",
                newName: "phonenumber");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "User",
                newName: "notes");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "User",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "User",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Domain",
                table: "User",
                newName: "domain");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "domain",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
