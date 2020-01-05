using Microsoft.EntityFrameworkCore.Migrations;

namespace DBPractise.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parking",
                columns: table => new
                {
                    Idparkingu = table.Column<int>(name: "Id parkingu", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IloscMiejscParkingowych = table.Column<int>(name: "Ilosc Miejsc Parkingowych", nullable: false),
                    IloscPrzypisanychMiejsc = table.Column<int>(name: "Ilosc Przypisanych Miejsc", nullable: false),
                    IloscMiejscDlaInwalidow = table.Column<int>(name: "Ilosc Miejsc Dla Inwalidow", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parking", x => x.Idparkingu);
                });

            migrationBuilder.CreateTable(
                name: "Blok_Parking",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdBlok = table.Column<int>(nullable: false),
                    IdParking = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blok_Parking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blok_Parking_Parking_IdParking",
                        column: x => x.IdParking,
                        principalTable: "Parking",
                        principalColumn: "Id parkingu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Blok",
                columns: table => new
                {
                    Idbloku = table.Column<int>(name: "Id bloku", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numerbloku = table.Column<int>(name: "Numer bloku", nullable: false),
                    Ulica = table.Column<string>(nullable: false),
                    Idosiedla = table.Column<int>(name: "Id osiedla", nullable: true),
                    Zarobki = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blok", x => x.Idbloku);
                });

            migrationBuilder.CreateTable(
                name: "Zarządca",
                columns: table => new
                {
                    Idzarządcy = table.Column<int>(name: "Id zarządcy", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imię = table.Column<string>(nullable: false),
                    Nazwisko = table.Column<string>(nullable: false),
                    Idosiedla = table.Column<int>(name: "Id osiedla", nullable: true),
                    Zarobki = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zarządca", x => x.Idzarządcy);
                });

            migrationBuilder.CreateTable(
                name: "Osiedle",
                columns: table => new
                {
                    Idosiedla = table.Column<int>(name: "Id osiedla", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwaosiedla = table.Column<string>(name: "Nazwa osiedla", nullable: false),
                    Liczbamieszkańców = table.Column<int>(name: "Liczba mieszkańców", nullable: false),
                    Idzarządcy = table.Column<int>(name: "Id zarządcy", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osiedle", x => x.Idosiedla);
                    table.ForeignKey(
                        name: "FK_Osiedle_Zarządca_Id zarządcy",
                        column: x => x.Idzarządcy,
                        principalTable: "Zarządca",
                        principalColumn: "Id zarządcy",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blok_Id osiedla",
                table: "Blok",
                column: "Id osiedla");

            migrationBuilder.CreateIndex(
                name: "IX_Blok_Parking_IdBlok",
                table: "Blok_Parking",
                column: "IdBlok");

            migrationBuilder.CreateIndex(
                name: "IX_Blok_Parking_IdParking",
                table: "Blok_Parking",
                column: "IdParking");

            migrationBuilder.CreateIndex(
                name: "IX_Osiedle_Id zarządcy",
                table: "Osiedle",
                column: "Id zarządcy");

            migrationBuilder.CreateIndex(
                name: "IX_Zarządca_Id osiedla",
                table: "Zarządca",
                column: "Id osiedla");

            migrationBuilder.AddForeignKey(
                name: "FK_Blok_Parking_Blok_IdBlok",
                table: "Blok_Parking",
                column: "IdBlok",
                principalTable: "Blok",
                principalColumn: "Id bloku",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Blok_Osiedle_Id osiedla",
                table: "Blok",
                column: "Id osiedla",
                principalTable: "Osiedle",
                principalColumn: "Id osiedla",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Zarządca_Osiedle_Id osiedla",
                table: "Zarządca",
                column: "Id osiedla",
                principalTable: "Osiedle",
                principalColumn: "Id osiedla",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zarządca_Osiedle_Id osiedla",
                table: "Zarządca");

            migrationBuilder.DropTable(
                name: "Blok_Parking");

            migrationBuilder.DropTable(
                name: "Blok");

            migrationBuilder.DropTable(
                name: "Parking");

            migrationBuilder.DropTable(
                name: "Osiedle");

            migrationBuilder.DropTable(
                name: "Zarządca");
        }
    }
}
