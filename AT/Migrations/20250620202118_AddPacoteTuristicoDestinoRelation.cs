using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AT.Migrations
{
    /// <inheritdoc />
    public partial class AddPacoteTuristicoDestinoRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destinos_PacotesTuristicios_PacoteTuristicoId",
                table: "Destinos");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_PacotesTuristicios_PacoteTuristicoId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Destinos_PacoteTuristicoId",
                table: "Destinos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PacotesTuristicios",
                table: "PacotesTuristicios");

            migrationBuilder.DropColumn(
                name: "PacoteTuristicoId",
                table: "Destinos");

            migrationBuilder.RenameTable(
                name: "PacotesTuristicios",
                newName: "PacotesTuristicos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PacotesTuristicos",
                table: "PacotesTuristicos",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "PacoteTuristicoDestinos",
                columns: table => new
                {
                    PacoteTuristicoId = table.Column<int>(type: "INTEGER", nullable: false),
                    DestinoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacoteTuristicoDestinos", x => new { x.PacoteTuristicoId, x.DestinoId });
                    table.ForeignKey(
                        name: "FK_PacoteTuristicoDestinos_Destinos_DestinoId",
                        column: x => x.DestinoId,
                        principalTable: "Destinos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PacoteTuristicoDestinos_PacotesTuristicos_PacoteTuristicoId",
                        column: x => x.PacoteTuristicoId,
                        principalTable: "PacotesTuristicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PacoteTuristicoDestinos_DestinoId",
                table: "PacoteTuristicoDestinos",
                column: "DestinoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_PacotesTuristicos_PacoteTuristicoId",
                table: "Reservas",
                column: "PacoteTuristicoId",
                principalTable: "PacotesTuristicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_PacotesTuristicos_PacoteTuristicoId",
                table: "Reservas");

            migrationBuilder.DropTable(
                name: "PacoteTuristicoDestinos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PacotesTuristicos",
                table: "PacotesTuristicos");

            migrationBuilder.RenameTable(
                name: "PacotesTuristicos",
                newName: "PacotesTuristicios");

            migrationBuilder.AddColumn<int>(
                name: "PacoteTuristicoId",
                table: "Destinos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PacotesTuristicios",
                table: "PacotesTuristicios",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Destinos_PacoteTuristicoId",
                table: "Destinos",
                column: "PacoteTuristicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Destinos_PacotesTuristicios_PacoteTuristicoId",
                table: "Destinos",
                column: "PacoteTuristicoId",
                principalTable: "PacotesTuristicios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_PacotesTuristicios_PacoteTuristicoId",
                table: "Reservas",
                column: "PacoteTuristicoId",
                principalTable: "PacotesTuristicios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
