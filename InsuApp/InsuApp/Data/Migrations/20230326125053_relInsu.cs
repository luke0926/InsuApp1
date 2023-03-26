using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuApp1.Data.Migrations
{
    /// <inheritdoc />
    public partial class relInsu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInsurance_ChartValue_ChartValueId",
                table: "UserInsurance");

            migrationBuilder.RenameColumn(
                name: "ChartValueId",
                table: "UserInsurance",
                newName: "MainInsuranceId");

            migrationBuilder.RenameIndex(
                name: "IX_UserInsurance_ChartValueId",
                table: "UserInsurance",
                newName: "IX_UserInsurance_MainInsuranceId");

            migrationBuilder.RenameColumn(
                name: "ChartValueName",
                table: "ChartValue",
                newName: "UserInsuranceName");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInsurance_MainInsurance_MainInsuranceId",
                table: "UserInsurance",
                column: "MainInsuranceId",
                principalTable: "MainInsurance",
                principalColumn: "MainInsuranceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInsurance_MainInsurance_MainInsuranceId",
                table: "UserInsurance");

            migrationBuilder.RenameColumn(
                name: "MainInsuranceId",
                table: "UserInsurance",
                newName: "ChartValueId");

            migrationBuilder.RenameIndex(
                name: "IX_UserInsurance_MainInsuranceId",
                table: "UserInsurance",
                newName: "IX_UserInsurance_ChartValueId");

            migrationBuilder.RenameColumn(
                name: "UserInsuranceName",
                table: "ChartValue",
                newName: "ChartValueName");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInsurance_ChartValue_ChartValueId",
                table: "UserInsurance",
                column: "ChartValueId",
                principalTable: "ChartValue",
                principalColumn: "ChartValueId");
        }
    }
}
