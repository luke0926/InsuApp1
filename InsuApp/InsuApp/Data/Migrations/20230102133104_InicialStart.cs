using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuApp1.Data.Migrations
{
    /// <inheritdoc />
    public partial class InicialStart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "MainInsurance",
                columns: table => new
                {
                    MainInsuranceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainInsuranceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserMainInsuranceUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainInsurance", x => x.MainInsuranceId);
                    table.ForeignKey(
                        name: "FK_MainInsurance_User_UserMainInsuranceUserId",
                        column: x => x.UserMainInsuranceUserId,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "UserInsurance",
                columns: table => new
                {
                    UserInsuranceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsuranceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsuranceValue = table.Column<int>(type: "int", nullable: true),
                    ObjectOfInsurance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsuranceValidFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsuranceValidTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserUserInsuranceUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInsurance", x => x.UserInsuranceId);
                    table.ForeignKey(
                        name: "FK_UserInsurance_User_UserUserInsuranceUserId",
                        column: x => x.UserUserInsuranceUserId,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MainInsurance_UserMainInsuranceUserId",
                table: "MainInsurance",
                column: "UserMainInsuranceUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInsurance_UserUserInsuranceUserId",
                table: "UserInsurance",
                column: "UserUserInsuranceUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MainInsurance");

            migrationBuilder.DropTable(
                name: "UserInsurance");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
