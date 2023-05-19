using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dough.Migrations
{
    /// <inheritdoc />
    public partial class TotalOutcolumnaddedtobankaccountstable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "TotalOut",
                table: "BankAccounts",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalOut",
                table: "BankAccounts");
        }
    }
}
