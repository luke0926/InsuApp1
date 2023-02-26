using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuApp1.Data.Migrations
{
    /// <inheritdoc />
    public partial class PokusPokus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserDetailViewModelUserDetailViewId",
                table: "UserInsuredEvent",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserInsuredEventId",
                table: "UserDetailViewModel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserInsuredEvent_UserDetailViewModelUserDetailViewId",
                table: "UserInsuredEvent",
                column: "UserDetailViewModelUserDetailViewId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailViewModel_UserInsuredEventId",
                table: "UserDetailViewModel",
                column: "UserInsuredEventId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetailViewModel_UserInsuredEvent_UserInsuredEventId",
                table: "UserDetailViewModel",
                column: "UserInsuredEventId",
                principalTable: "UserInsuredEvent",
                principalColumn: "UserInsuredEventId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInsuredEvent_UserDetailViewModel_UserDetailViewModelUserDetailViewId",
                table: "UserInsuredEvent",
                column: "UserDetailViewModelUserDetailViewId",
                principalTable: "UserDetailViewModel",
                principalColumn: "UserDetailViewId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserDetailViewModel_UserInsuredEvent_UserInsuredEventId",
                table: "UserDetailViewModel");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInsuredEvent_UserDetailViewModel_UserDetailViewModelUserDetailViewId",
                table: "UserInsuredEvent");

            migrationBuilder.DropIndex(
                name: "IX_UserInsuredEvent_UserDetailViewModelUserDetailViewId",
                table: "UserInsuredEvent");

            migrationBuilder.DropIndex(
                name: "IX_UserDetailViewModel_UserInsuredEventId",
                table: "UserDetailViewModel");

            migrationBuilder.DropColumn(
                name: "UserDetailViewModelUserDetailViewId",
                table: "UserInsuredEvent");

            migrationBuilder.DropColumn(
                name: "UserInsuredEventId",
                table: "UserDetailViewModel");
        }
    }
}
