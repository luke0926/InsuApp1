using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuApp1.Data.Migrations
{
    /// <inheritdoc />
    public partial class insuranceValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "InsuranceValue",
                table: "UserInsurance",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "UserCategory",
                table: "UserDetailViewModelEvent",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InsuranceValue",
                table: "UserDetailViewModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "UserCategory",
                table: "UserDetailViewModel",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MainInsuredEventName",
                table: "MainInsuredEvent",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MainInsuranceName",
                table: "MainInsurance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserCategory",
                table: "UserDetailViewModelEvent");

            migrationBuilder.DropColumn(
                name: "UserCategory",
                table: "UserDetailViewModel");

            migrationBuilder.AlterColumn<string>(
                name: "InsuranceValue",
                table: "UserInsurance",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "InsuranceValue",
                table: "UserDetailViewModel",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "MainInsuredEventName",
                table: "MainInsuredEvent",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MainInsuranceName",
                table: "MainInsurance",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
