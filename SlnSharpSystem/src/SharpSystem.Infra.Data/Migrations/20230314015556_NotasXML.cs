using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharpSystem.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class NotasXML : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
/*            migrationBuilder.DropTable(
                name: "Listas");

            migrationBuilder.DropTable(
                name: "Itens");

            migrationBuilder.DropTable(
                name: "NotasFiscais");

            migrationBuilder.DropTable(
                name: "Prestadores");

            migrationBuilder.DropTable(
                name: "Tomadores");*/

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Login",
                table: "Usuarios");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Prestadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CpfCnpj = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tomadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CpfCnpj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeRazaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroResidencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tomadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotasFiscais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrestadorId = table.Column<int>(type: "int", nullable: false),
                    TomadorId = table.Column<int>(type: "int", nullable: false),
                    ValorTotal = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotasFiscais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotasFiscais_Prestadores_PrestadorId",
                        column: x => x.PrestadorId,
                        principalTable: "Prestadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotasFiscais_Tomadores_TomadorId",
                        column: x => x.TomadorId,
                        principalTable: "Tomadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Itens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotaFiscalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Itens_NotasFiscais_NotaFiscalId",
                        column: x => x.NotaFiscalId,
                        principalTable: "NotasFiscais",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Listas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AliquotaItemListaServico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoItemListaServico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoLocalPrestacaoServico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descritivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItensId = table.Column<int>(type: "int", nullable: true),
                    SituacaoTributaria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TributaMunicipioPrestador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorTributavel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Listas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Listas_Itens_ItensId",
                        column: x => x.ItensId,
                        principalTable: "Itens",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "Id", "NotaFiscalId" },
                values: new object[] { 1, null });

            migrationBuilder.InsertData(
                table: "Listas",
                columns: new[] { "Id", "AliquotaItemListaServico", "CodigoItemListaServico", "CodigoLocalPrestacaoServico", "Descritivo", "ItensId", "SituacaoTributaria", "TributaMunicipioPrestador", "ValorTributavel" },
                values: new object[] { 1, "0", "94", "12", "teste bla bla", null, "0", "10", "0" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Cidade", "CpfCnpj" },
                values: new object[] { 1, "Blumenau", "115.187.919-10" });

            migrationBuilder.InsertData(
                table: "Tomadores",
                columns: new[] { "Id", "Bairro", "Cep", "Cidade", "CpfCnpj", "Email", "Logradouro", "NomeRazaoSocial", "NumeroResidencia", "Tipo" },
                values: new object[] { 1, "Agua Verde", "89062712", "Blumenau", "12.345.678/0001-00", "teste@gmail.com", "Oscar Wippel", "Empresa teste", "123", "1" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Login" },
                values: new object[] { "pedrogodri@gmail.com", "PedroGodri" });

            migrationBuilder.InsertData(
                table: "NotasFiscais",
                columns: new[] { "Id", "PrestadorId", "TomadorId", "ValorTotal" },
                values: new object[] { 1, 1, 1, "150,00" });

            migrationBuilder.CreateIndex(
                name: "IX_Itens_NotaFiscalId",
                table: "Itens",
                column: "NotaFiscalId");

            migrationBuilder.CreateIndex(
                name: "IX_Listas_ItensId",
                table: "Listas",
                column: "ItensId");

            migrationBuilder.CreateIndex(
                name: "IX_NotasFiscais_PrestadorId",
                table: "NotasFiscais",
                column: "PrestadorId");

            migrationBuilder.CreateIndex(
                name: "IX_NotasFiscais_TomadorId",
                table: "NotasFiscais",
                column: "TomadorId");
        }
    }
}
