using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharpSystem.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class XMLEntitiesBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Listas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tributaMunicipioPrestador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    codigoLocalPrestacaoServio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    codigoItemListaServico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descritivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aliquotaItemListaServico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    situacaoTributaria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    valorTributavel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Listas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Prestador",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cpfcnpj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cidade = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestador", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tomador",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpfcnpj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nomeRazaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    logradouro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numeroResidencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cep = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tomador", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CFPCNPJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Itens",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    listaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itens", x => x.id);
                    table.ForeignKey(
                        name: "FK_Itens_Listas_listaId",
                        column: x => x.listaId,
                        principalTable: "Listas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotaFiscal",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    valorTotal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrestadorId = table.Column<int>(type: "int", nullable: false),
                    TomadorId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaFiscal", x => x.id);
                    table.ForeignKey(
                        name: "FK_NotaFiscal_Itens_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Itens",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotaFiscal_Prestador_PrestadorId",
                        column: x => x.PrestadorId,
                        principalTable: "Prestador",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotaFiscal_tomador_TomadorId",
                        column: x => x.TomadorId,
                        principalTable: "tomador",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Listas",
                columns: new[] { "id", "aliquotaItemListaServico", "codigoItemListaServico", "codigoLocalPrestacaoServio", "descritivo", "situacaoTributaria", "tributaMunicipioPrestador", "valorTributavel" },
                values: new object[] { 1, "5,0", "94", "12", "teste bla bla", "0", "10", "1,0" });

            migrationBuilder.InsertData(
                table: "Prestador",
                columns: new[] { "id", "cidade", "cpfcnpj" },
                values: new object[] { 1, "8357", "115.187.919-10" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "CFPCNPJ", "Email", "Login", "Nome", "Senha" },
                values: new object[] { 1, "104.752.299-23", "pedrogodri@gmail.com", "PedroGodri", "Pedro Godri", "12345" });

            migrationBuilder.InsertData(
                table: "tomador",
                columns: new[] { "id", "bairro", "cep", "cidade", "cpfcnpj", "email", "logradouro", "nomeRazaoSocial", "numeroResidencia", "tipo" },
                values: new object[] { 1, "Agua Verde", "89062712", "8357", "12.345.678/0001-00", "teste@gmail.com", "Oscar Wippel", "Empresa teste", "123", "J" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "id", "listaId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "NotaFiscal",
                columns: new[] { "id", "ItemId", "PrestadorId", "TomadorId", "valorTotal" },
                values: new object[] { 1, 1, 1, 1, "150,00" });

            migrationBuilder.CreateIndex(
                name: "IX_Itens_listaId",
                table: "Itens",
                column: "listaId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaFiscal_ItemId",
                table: "NotaFiscal",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaFiscal_PrestadorId",
                table: "NotaFiscal",
                column: "PrestadorId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaFiscal_TomadorId",
                table: "NotaFiscal",
                column: "TomadorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotaFiscal");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Itens");

            migrationBuilder.DropTable(
                name: "Prestador");

            migrationBuilder.DropTable(
                name: "tomador");

            migrationBuilder.DropTable(
                name: "Listas");
        }
    }
}
