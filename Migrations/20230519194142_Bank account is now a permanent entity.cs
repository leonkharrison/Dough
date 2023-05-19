using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dough.Migrations
{
    /// <inheritdoc />
    public partial class Bankaccountisnowapermanententity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "BankAccounts",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "BankAccounts");
        }
    }
}
