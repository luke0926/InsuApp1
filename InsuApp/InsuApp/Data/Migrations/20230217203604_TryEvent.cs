using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuApp1.Data.Migrations
{
    /// <inheritdoc />
    public partial class TryEvent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserDetailViewModelEventUserDetailEventId",
                table: "UserInsuredEvent",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserDetailViewModelEvent",
                columns: table => new
                {
                    UserDetailEventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainInsuredEventName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsuredEventValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObjectOfInsuredEvent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsuredEventDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserDetailEventViewUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetailViewModelEvent", x => x.UserDetailEventId);
                    table.ForeignKey(
                        name: "FK_UserDetailViewModelEvent_User_UserDetailEventViewUserId",
                        column: x => x.UserDetailEventViewUserId,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserInsuredEvent_UserDetailViewModelEventUserDetailEventId",
                table: "UserInsuredEvent",
                column: "UserDetailViewModelEventUserDetailEventId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailViewModelEvent_UserDetailEventViewUserId",
                table: "UserDetailViewModelEvent",
                column: "UserDetailEventViewUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInsuredEvent_UserDetailViewModelEvent_UserDetailViewModelEventUserDetailEventId",
                table: "UserInsuredEvent",
                column: "UserDetailViewModelEventUserDetailEventId",
                principalTable: "UserDetailViewModelEvent",
                principalColumn: "UserDetailEventId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInsuredEvent_UserDetailViewModelEvent_UserDetailViewModelEventUserDetailEventId",
                table: "UserInsuredEvent");

            migrationBuilder.DropTable(
                name: "UserDetailViewModelEvent");

            migrationBuilder.DropIndex(
                name: "IX_UserInsuredEvent_UserDetailViewModelEventUserDetailEventId",
                table: "UserInsuredEvent");

            migrationBuilder.DropColumn(
                name: "UserDetailViewModelEventUserDetailEventId",
                table: "UserInsuredEvent");
        }
    }
}
