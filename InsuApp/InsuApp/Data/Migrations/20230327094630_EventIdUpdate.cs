using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuApp1.Data.Migrations
{
    /// <inheritdoc />
    public partial class EventIdUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MainInsuredEventId",
                table: "UserInsuredEvent",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserInsuredEvent_MainInsuredEventId",
                table: "UserInsuredEvent",
                column: "MainInsuredEventId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInsuredEvent_MainInsuredEvent_MainInsuredEventId",
                table: "UserInsuredEvent",
                column: "MainInsuredEventId",
                principalTable: "MainInsuredEvent",
                principalColumn: "MainInsuredEventId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInsuredEvent_MainInsuredEvent_MainInsuredEventId",
                table: "UserInsuredEvent");

            migrationBuilder.DropIndex(
                name: "IX_UserInsuredEvent_MainInsuredEventId",
                table: "UserInsuredEvent");

            migrationBuilder.DropColumn(
                name: "MainInsuredEventId",
                table: "UserInsuredEvent");
        }
    }
}
