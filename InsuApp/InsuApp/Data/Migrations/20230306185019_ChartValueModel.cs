using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuApp1.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChartValueModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChartValueId",
                table: "UserInsurance",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InsuranceCurrency",
                table: "UserDetailViewModelEvent",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ChartValue",
                columns: table => new
                {
                    ChartValueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChartValueName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChartValueTotal = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChartValue", x => x.ChartValueId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserInsurance_ChartValueId",
                table: "UserInsurance",
                column: "ChartValueId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInsurance_ChartValue_ChartValueId",
                table: "UserInsurance",
                column: "ChartValueId",
                principalTable: "ChartValue",
                principalColumn: "ChartValueId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInsurance_ChartValue_ChartValueId",
                table: "UserInsurance");

            migrationBuilder.DropTable(
                name: "ChartValue");

            migrationBuilder.DropIndex(
                name: "IX_UserInsurance_ChartValueId",
                table: "UserInsurance");

            migrationBuilder.DropColumn(
                name: "ChartValueId",
                table: "UserInsurance");

            migrationBuilder.AlterColumn<int>(
                name: "InsuranceCurrency",
                table: "UserDetailViewModelEvent",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
