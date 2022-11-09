using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeTaskLog.Migrations
{
    public partial class updateJob2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Employees_EmployeeId",
                table: "Jobs");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Jobs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Employees_EmployeeId",
                table: "Jobs",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Employees_EmployeeId",
                table: "Jobs");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Jobs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Employees_EmployeeId",
                table: "Jobs",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
