using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuApp1.Data.Migrations
{
    /// <inheritdoc />
    public partial class Identity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MainInsurance_UserDetailViewModel_UserDetailViewModelUserDetailViewId",
                table: "MainInsurance");

            migrationBuilder.DropForeignKey(
                name: "FK_MainInsurance_User_UserMainInsuranceUserId",
                table: "MainInsurance");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDetailViewModel_MainInsurance_MainInsurancedwMainInsuranceId",
                table: "UserDetailViewModel");

            migrationBuilder.DropIndex(
                name: "IX_UserDetailViewModel_MainInsurancedwMainInsuranceId",
                table: "UserDetailViewModel");

            migrationBuilder.DropIndex(
                name: "IX_MainInsurance_UserDetailViewModelUserDetailViewId",
                table: "MainInsurance");

            migrationBuilder.DropIndex(
                name: "IX_MainInsurance_UserMainInsuranceUserId",
                table: "MainInsurance");

            migrationBuilder.DropColumn(
                name: "UserUserInsuranceName",
                table: "UserInsurance");

            migrationBuilder.DropColumn(
                name: "MainInsurancedwMainInsuranceId",
                table: "UserDetailViewModel");

            migrationBuilder.DropColumn(
                name: "ReturnUrl",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UserDetailViewModelUserDetailViewId",
                table: "MainInsurance");

            migrationBuilder.DropColumn(
                name: "UserMainInsuranceUserId",
                table: "MainInsurance");

            migrationBuilder.AlterColumn<string>(
                name: "ObjectOfInsurance",
                table: "UserInsurance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InsuranceValue",
                table: "UserInsurance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InsuranceName",
                table: "UserInsurance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ObjectOfInsurane",
                table: "UserDetailViewModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MainInsuranceName",
                table: "UserDetailViewModel",
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
            migrationBuilder.AlterColumn<string>(
                name: "ObjectOfInsurance",
                table: "UserInsurance",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "InsuranceValue",
                table: "UserInsurance",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "InsuranceName",
                table: "UserInsurance",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "UserUserInsuranceName",
                table: "UserInsurance",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ObjectOfInsurane",
                table: "UserDetailViewModel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MainInsuranceName",
                table: "UserDetailViewModel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "MainInsurancedwMainInsuranceId",
                table: "UserDetailViewModel",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReturnUrl",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserDetailViewModelUserDetailViewId",
                table: "MainInsurance",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserMainInsuranceUserId",
                table: "MainInsurance",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailViewModel_MainInsurancedwMainInsuranceId",
                table: "UserDetailViewModel",
                column: "MainInsurancedwMainInsuranceId");

            migrationBuilder.CreateIndex(
                name: "IX_MainInsurance_UserDetailViewModelUserDetailViewId",
                table: "MainInsurance",
                column: "UserDetailViewModelUserDetailViewId");

            migrationBuilder.CreateIndex(
                name: "IX_MainInsurance_UserMainInsuranceUserId",
                table: "MainInsurance",
                column: "UserMainInsuranceUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MainInsurance_UserDetailViewModel_UserDetailViewModelUserDetailViewId",
                table: "MainInsurance",
                column: "UserDetailViewModelUserDetailViewId",
                principalTable: "UserDetailViewModel",
                principalColumn: "UserDetailViewId");

            migrationBuilder.AddForeignKey(
                name: "FK_MainInsurance_User_UserMainInsuranceUserId",
                table: "MainInsurance",
                column: "UserMainInsuranceUserId",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetailViewModel_MainInsurance_MainInsurancedwMainInsuranceId",
                table: "UserDetailViewModel",
                column: "MainInsurancedwMainInsuranceId",
                principalTable: "MainInsurance",
                principalColumn: "MainInsuranceId");
        }
    }
}
