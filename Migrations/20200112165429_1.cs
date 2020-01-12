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
                    Id_parkingu = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ilosc_Miejsc_Parkingowych = table.Column<int>(nullable: false),
                    Ilosc_Przypisanych_Miejsc = table.Column<int>(nullable: false),
                    Ilosc_Miejsc_Dla_Inwalidow = table.Column<int>(nullable: false),
                    Lb_Miejsc_Nie_Przypis = table.Column<int>(nullable: false, computedColumnSql: "[Ilosc_Miejsc_Parkingowych]-[Ilosc_Przypisanych_Miejsc]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parking", x => x.Id_parkingu);
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
                        principalColumn: "Id_parkingu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Blok",
                columns: table => new
                {
                    Id_bloku = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numer_bloku = table.Column<int>(nullable: false),
                    Ulica = table.Column<string>(nullable: false),
                    Id_osiedla = table.Column<int>(nullable: true),
                    Zarobki = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blok", x => x.Id_bloku);
                });

            migrationBuilder.CreateTable(
                name: "Zarządca",
                columns: table => new
                {
                    Id_zarządcy = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imię = table.Column<string>(nullable: false),
                    Nazwisko = table.Column<string>(nullable: false),
                    Id_osiedla = table.Column<int>(nullable: true),
                    Zarobki = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zarządca", x => x.Id_zarządcy);
                });

            migrationBuilder.CreateTable(
                name: "Osiedle",
                columns: table => new
                {
                    Id_osiedla = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa_osiedla = table.Column<string>(nullable: false),
                    Liczba_mieszkańców = table.Column<int>(nullable: false),
                    Id_zarządcy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osiedle", x => x.Id_osiedla);
                    table.ForeignKey(
                        name: "FK_Osiedle_Zarządca_Id_zarządcy",
                        column: x => x.Id_zarządcy,
                        principalTable: "Zarządca",
                        principalColumn: "Id_zarządcy",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Blok",
                columns: new[] { "Id_bloku", "Id_osiedla", "Numer_bloku", "Ulica", "Zarobki" },
                values: new object[,]
                {
                    { 1, null, 1, "Siemianowicka", 46715m },
                    { 2, null, 2, "Balonowa", 57673m },
                    { 3, null, 3, "Wiedźmińska", 14975m },
                    { 4, null, 4, "Dworcowa", 4036m },
                    { 5, null, 5, "Garbarska", 44008m }
                });

            migrationBuilder.InsertData(
                table: "Osiedle",
                columns: new[] { "Id_osiedla", "Id_zarządcy", "Liczba_mieszkańców", "Nazwa_osiedla" },
                values: new object[,]
                {
                    { 4, null, 9304, "Batorego" },
                    { 3, null, 5889, "Szombierki" },
                    { 5, null, 5280, "Witosa" },
                    { 1, null, 10984, "Wojkowice" },
                    { 2, null, 4402, "Wojkowice" }
                });

            migrationBuilder.InsertData(
                table: "Parking",
                columns: new[] { "Id_parkingu", "Ilosc_Miejsc_Dla_Inwalidow", "Ilosc_Miejsc_Parkingowych", "Ilosc_Przypisanych_Miejsc" },
                values: new object[,]
                {
                    { 1, 2, 25, 10 },
                    { 2, 4, 56, 7 },
                    { 3, 3, 92, 15 },
                    { 4, 4, 99, 54 },
                    { 5, 3, 34, 22 }
                });

            migrationBuilder.InsertData(
                table: "Zarządca",
                columns: new[] { "Id_zarządcy", "Id_osiedla", "Imię", "Nazwisko", "Zarobki" },
                values: new object[,]
                {
                    { 4, null, "Krystyna", "Warius", 4750m },
                    { 1, null, "Zygmunt", "Kowal", 6940m },
                    { 2, null, "Władysław", "Kowal", 14850m },
                    { 3, null, "Wilhelm", "Jabłkowski", 14520m },
                    { 5, null, "Krystyna", "Fikus", 9710m }
                });

            migrationBuilder.InsertData(
                table: "Blok_Parking",
                columns: new[] { "Id", "IdBlok", "IdParking" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 5, 5, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blok_Id_osiedla",
                table: "Blok",
                column: "Id_osiedla");

            migrationBuilder.CreateIndex(
                name: "IX_Blok_Parking_IdBlok",
                table: "Blok_Parking",
                column: "IdBlok");

            migrationBuilder.CreateIndex(
                name: "IX_Blok_Parking_IdParking",
                table: "Blok_Parking",
                column: "IdParking");

            migrationBuilder.CreateIndex(
                name: "IX_Osiedle_Id_zarządcy",
                table: "Osiedle",
                column: "Id_zarządcy");

            migrationBuilder.CreateIndex(
                name: "IX_Zarządca_Id_osiedla",
                table: "Zarządca",
                column: "Id_osiedla");

            migrationBuilder.AddForeignKey(
                name: "FK_Blok_Parking_Blok_IdBlok",
                table: "Blok_Parking",
                column: "IdBlok",
                principalTable: "Blok",
                principalColumn: "Id_bloku",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Blok_Osiedle_Id_osiedla",
                table: "Blok",
                column: "Id_osiedla",
                principalTable: "Osiedle",
                principalColumn: "Id_osiedla",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Zarządca_Osiedle_Id_osiedla",
                table: "Zarządca",
                column: "Id_osiedla",
                principalTable: "Osiedle",
                principalColumn: "Id_osiedla",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zarządca_Osiedle_Id_osiedla",
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
