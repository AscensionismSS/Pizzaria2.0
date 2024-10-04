using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pizzaria2._0.Migrations
{
    /// <inheritdoc />
    public partial class DadoUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Sobrenome = table.Column<string>(type: "varchar(50)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    Senha = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cep = table.Column<string>(type: "varchar(10)", nullable: false),
                    Estado = table.Column<string>(type: "varchar(50)", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(50)", nullable: false),
                    Bairro = table.Column<string>(type: "varchar(50)", nullable: false),
                    Rua = table.Column<string>(type: "varchar(100)", nullable: false),
                    Numero = table.Column<string>(type: "varchar(10)", nullable: false),
                    Complemento = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserIdentification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cpf = table.Column<string>(type: "varchar(14)", nullable: false),
                    AccountID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserIdentification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserIdentification_Account_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccountAddresses",
                columns: table => new
                {
                    AccountID = table.Column<int>(type: "int", nullable: false),
                    AddressID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountAddresses", x => new { x.AccountID, x.AddressID });
                    table.ForeignKey(
                        name: "FK_AccountAddresses_Account_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountAddresses_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountAddresses_AddressID",
                table: "AccountAddresses",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_UserIdentification_AccountID",
                table: "UserIdentification",
                column: "AccountID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountAddresses");

            migrationBuilder.DropTable(
                name: "UserIdentification");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Account");
        }
    }
}
