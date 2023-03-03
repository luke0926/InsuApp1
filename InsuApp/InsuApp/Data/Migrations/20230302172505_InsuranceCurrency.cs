using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuApp1.Data.Migrations
{
    /// <inheritdoc />
    public partial class InsuranceCurrency : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InsuranceCurrency",
                table: "UserInsurance",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InsuranceCurrency",
                table: "UserDetailViewModelEvent",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InsuranceCurrency",
                table: "UserDetailViewModel",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InsuranceCurrency",
                table: "UserInsurance");

            migrationBuilder.DropColumn(
                name: "InsuranceCurrency",
                table: "UserDetailViewModelEvent");

            migrationBuilder.DropColumn(
                name: "InsuranceCurrency",
                table: "UserDetailViewModel");
        }
    }
}
