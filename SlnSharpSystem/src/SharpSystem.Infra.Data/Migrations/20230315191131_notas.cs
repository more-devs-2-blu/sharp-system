using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharpSystem.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class notas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Listas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TributaMunicipioPrestador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoLocalPrestacaoServico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoItemListaServico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descritivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AliquotaItemListaServico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SituacaoTributaria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorTributavel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Listas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotaFiscals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorTotal = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaFiscals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prestador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CpfCnpj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestador", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tomador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CpfCnpj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeRazaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroResidencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tomador", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Itens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    listaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Itens_Listas_listaId",
                        column: x => x.listaId,
                        principalTable: "Listas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NFSEs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotaFiscalId = table.Column<int>(type: "int", nullable: false),
                    PrestadorId = table.Column<int>(type: "int", nullable: false),
                    TomadorId = table.Column<int>(type: "int", nullable: false),
                    ItensId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NFSEs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NFSEs_Itens_ItensId",
                        column: x => x.ItensId,
                        principalTable: "Itens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NFSEs_NotaFiscals_NotaFiscalId",
                        column: x => x.NotaFiscalId,
                        principalTable: "NotaFiscals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NFSEs_Prestador_PrestadorId",
                        column: x => x.PrestadorId,
                        principalTable: "Prestador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NFSEs_Tomador_TomadorId",
                        column: x => x.TomadorId,
                        principalTable: "Tomador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Itens_listaId",
                table: "Itens",
                column: "listaId");

            migrationBuilder.CreateIndex(
                name: "IX_NFSEs_ItensId",
                table: "NFSEs",
                column: "ItensId");

            migrationBuilder.CreateIndex(
                name: "IX_NFSEs_NotaFiscalId",
                table: "NFSEs",
                column: "NotaFiscalId");

            migrationBuilder.CreateIndex(
                name: "IX_NFSEs_PrestadorId",
                table: "NFSEs",
                column: "PrestadorId");

            migrationBuilder.CreateIndex(
                name: "IX_NFSEs_TomadorId",
                table: "NFSEs",
                column: "TomadorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NFSEs");

            migrationBuilder.DropTable(
                name: "Itens");

            migrationBuilder.DropTable(
                name: "NotaFiscals");

            migrationBuilder.DropTable(
                name: "Prestador");

            migrationBuilder.DropTable(
                name: "Tomador");

            migrationBuilder.DropTable(
                name: "Listas");
        }
    }
}
