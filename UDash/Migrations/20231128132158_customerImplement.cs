using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDash.Migrations
{
    /// <inheritdoc />
    public partial class customerImplement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSense = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdStarford = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cnpj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    RazaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Loja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProdutoFiscal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorMensal = table.Column<double>(type: "float", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
