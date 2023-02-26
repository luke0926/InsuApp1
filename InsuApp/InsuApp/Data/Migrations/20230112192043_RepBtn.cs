using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuApp1.Data.Migrations
{
    /// <inheritdoc />
    public partial class RepBtn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInsurance_UserDetailViewModel_UserBackIdUserDetailViewId",
                table: "UserInsurance");

            migrationBuilder.RenameColumn(
                name: "UserBackIdUserDetailViewId",
                table: "UserInsurance",
                newName: "UserDetailViewModelUserDetailViewId");

            migrationBuilder.RenameIndex(
                name: "IX_UserInsurance_UserBackIdUserDetailViewId",
                table: "UserInsurance",
                newName: "IX_UserInsurance_UserDetailViewModelUserDetailViewId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInsurance_UserDetailViewModel_UserDetailViewModelUserDetailViewId",
                table: "UserInsurance",
                column: "UserDetailViewModelUserDetailViewId",
                principalTable: "UserDetailViewModel",
                principalColumn: "UserDetailViewId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInsurance_UserDetailViewModel_UserDetailViewModelUserDetailViewId",
                table: "UserInsurance");

            migrationBuilder.RenameColumn(
                name: "UserDetailViewModelUserDetailViewId",
                table: "UserInsurance",
                newName: "UserBackIdUserDetailViewId");

            migrationBuilder.RenameIndex(
                name: "IX_UserInsurance_UserDetailViewModelUserDetailViewId",
                table: "UserInsurance",
                newName: "IX_UserInsurance_UserBackIdUserDetailViewId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInsurance_UserDetailViewModel_UserBackIdUserDetailViewId",
                table: "UserInsurance",
                column: "UserBackIdUserDetailViewId",
                principalTable: "UserDetailViewModel",
                principalColumn: "UserDetailViewId");
        }
    }
}
