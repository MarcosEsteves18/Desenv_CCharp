using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIExemplo.Migrations
{
    /// <inheritdoc />
    public partial class depois : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Placa",
                table: "Veiculos",
                type: "longtext",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Placa",
                table: "Veiculos");
        }
    }
}
