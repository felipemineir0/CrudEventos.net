using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Eventos.AcessoADados.Migrations
{
    public partial class AdicionadoTableEventos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    IdEvento = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Data = table.Column<string>(nullable: false),
                    Local = table.Column<string>(nullable: false),
                    HoraInicio = table.Column<int>(nullable: false),
                    HoraFinal = table.Column<int>(nullable: false),
                    OpenBar = table.Column<bool>(nullable: false),
                    QuantidadeDeAmbientes = table.Column<string>(nullable: false),
                    FaixaEtaria = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.IdEvento);
                });
        }
        
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eventos");
        }
    }
}
