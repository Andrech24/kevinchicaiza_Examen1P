using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kevinchicaiza_Examen1P.Migrations
{
    /// <inheritdoc />
    public partial class AddMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KcGymshark",
                columns: table => new
                {
                    KCRopaid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KCName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KCtallas = table.Column<bool>(type: "bit", nullable: false),
                    KCPrecio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Emaildelusuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KCFechadeEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KCFechadeSalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KCColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KCGenero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KcTipodegenero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KCDescripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KcGymshark", x => x.KCRopaid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KcGymshark");
        }
    }
}
