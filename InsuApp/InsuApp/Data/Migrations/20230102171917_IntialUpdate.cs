using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuApp1.Data.Migrations
{
    /// <inheritdoc />
    public partial class IntialUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserDetailViewModelUserDetailViewId",
                table: "UserInsurance",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserDetailViewModelUserDetailViewId",
                table: "MainInsurance",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserDetailViewModel",
                columns: table => new
                {
                    UserDetailViewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsuranceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsuranceValue = table.Column<int>(type: "int", nullable: true),
                    ObjectOfInsurane = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsuranceValidFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsuranceValidTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserDetailViewUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetailViewModel", x => x.UserDetailViewId);
                    table.ForeignKey(
                        name: "FK_UserDetailViewModel_User_UserDetailViewUserId",
                        column: x => x.UserDetailViewUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserInsurance_UserDetailViewModelUserDetailViewId",
                table: "UserInsurance",
                column: "UserDetailViewModelUserDetailViewId");

            migrationBuilder.CreateIndex(
                name: "IX_MainInsurance_UserDetailViewModelUserDetailViewId",
                table: "MainInsurance",
                column: "UserDetailViewModelUserDetailViewId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailViewModel_UserDetailViewUserId",
                table: "UserDetailViewModel",
                column: "UserDetailViewUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MainInsurance_UserDetailViewModel_UserDetailViewModelUserDetailViewId",
                table: "MainInsurance",
                column: "UserDetailViewModelUserDetailViewId",
                principalTable: "UserDetailViewModel",
                principalColumn: "UserDetailViewId");

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
                name: "FK_MainInsurance_UserDetailViewModel_UserDetailViewModelUserDetailViewId",
                table: "MainInsurance");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInsurance_UserDetailViewModel_UserDetailViewModelUserDetailViewId",
                table: "UserInsurance");

            migrationBuilder.DropTable(
                name: "UserDetailViewModel");

            migrationBuilder.DropIndex(
                name: "IX_UserInsurance_UserDetailViewModelUserDetailViewId",
                table: "UserInsurance");

            migrationBuilder.DropIndex(
                name: "IX_MainInsurance_UserDetailViewModelUserDetailViewId",
                table: "MainInsurance");

            migrationBuilder.DropColumn(
                name: "UserDetailViewModelUserDetailViewId",
                table: "UserInsurance");

            migrationBuilder.DropColumn(
                name: "UserDetailViewModelUserDetailViewId",
                table: "MainInsurance");
        }
    }
}
