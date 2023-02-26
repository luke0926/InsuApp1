using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuApp1.Data.Migrations
{
    /// <inheritdoc />
    public partial class MainInsu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserDetailViewModel_MainInsurance_MainInsuranceId",
                table: "UserDetailViewModel");

            migrationBuilder.DropIndex(
                name: "IX_UserDetailViewModel_MainInsuranceId",
                table: "UserDetailViewModel");

            migrationBuilder.DropColumn(
                name: "MainInsuranceId",
                table: "UserDetailViewModel");

            migrationBuilder.AlterColumn<string>(
                name: "InsuranceName",
                table: "UserDetailViewModel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "MainInsuranceName",
                table: "UserDetailViewModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MainInsurancedwMainInsuranceId",
                table: "UserDetailViewModel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailViewModel_MainInsurancedwMainInsuranceId",
                table: "UserDetailViewModel",
                column: "MainInsurancedwMainInsuranceId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetailViewModel_MainInsurance_MainInsurancedwMainInsuranceId",
                table: "UserDetailViewModel",
                column: "MainInsurancedwMainInsuranceId",
                principalTable: "MainInsurance",
                principalColumn: "MainInsuranceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserDetailViewModel_MainInsurance_MainInsurancedwMainInsuranceId",
                table: "UserDetailViewModel");

            migrationBuilder.DropIndex(
                name: "IX_UserDetailViewModel_MainInsurancedwMainInsuranceId",
                table: "UserDetailViewModel");

            migrationBuilder.DropColumn(
                name: "MainInsuranceName",
                table: "UserDetailViewModel");

            migrationBuilder.DropColumn(
                name: "MainInsurancedwMainInsuranceId",
                table: "UserDetailViewModel");

            migrationBuilder.AlterColumn<string>(
                name: "InsuranceName",
                table: "UserDetailViewModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MainInsuranceId",
                table: "UserDetailViewModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailViewModel_MainInsuranceId",
                table: "UserDetailViewModel",
                column: "MainInsuranceId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetailViewModel_MainInsurance_MainInsuranceId",
                table: "UserDetailViewModel",
                column: "MainInsuranceId",
                principalTable: "MainInsurance",
                principalColumn: "MainInsuranceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
