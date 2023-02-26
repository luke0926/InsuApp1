using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuApp1.Data.Migrations
{
    /// <inheritdoc />
    public partial class ReturnUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserUserInsuranceName",
                table: "UserInsurance");

            migrationBuilder.AddColumn<string>(
                name: "ReturnUrl",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReturnUrl",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "UserUserInsuranceName",
                table: "UserInsurance",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
