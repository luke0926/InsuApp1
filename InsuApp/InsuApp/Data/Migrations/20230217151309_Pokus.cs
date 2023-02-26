using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuApp1.Data.Migrations
{
    /// <inheritdoc />
    public partial class Pokus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserInsuredEvent",
                columns: table => new
                {
                    UserInsuredEventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsuredEventName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsuredEventValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObjectOfInsuredEvent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsuredEventDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserUserInsuredEventUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInsuredEvent", x => x.UserInsuredEventId);
                    table.ForeignKey(
                        name: "FK_UserInsuredEvent_User_UserUserInsuredEventUserId",
                        column: x => x.UserUserInsuredEventUserId,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserInsuredEvent_UserUserInsuredEventUserId",
                table: "UserInsuredEvent",
                column: "UserUserInsuredEventUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserInsuredEvent");
        }
    }
}
