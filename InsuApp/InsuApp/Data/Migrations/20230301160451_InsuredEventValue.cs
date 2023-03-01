using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuApp1.Data.Migrations
{
    /// <inheritdoc />
    public partial class InsuredEventValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "InsuredEventValue",
                table: "UserInsuredEvent",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "InsuredEventValue",
                table: "UserDetailViewModelEvent",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "InsuredEventValue",
                table: "UserInsuredEvent",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "InsuredEventValue",
                table: "UserDetailViewModelEvent",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
