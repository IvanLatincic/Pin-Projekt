using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicStore.Migrations.AppDb
{
    public partial class ProductsMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "CD" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Vinyl" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Kazeta" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Artist", "CategoryId", "Code", "DiscountPercent", "Genre", "Name", "Price", "Year" },
                values: new object[,]
                {
                    { 1, "Adele", 1, "30_CD", 0m, "Pop", "30", 124.99m, 2021 },
                    { 9, "Taylor Swift", 3, "Evermore_C", 0m, "Pop", "Evermore", 124.99m, 2020 },
                    { 19, "Billie Marten", 2, "FloraFauna_VINYL", 0m, "Alternative", "Flora Fauna", 249.99m, 2021 },
                    { 18, "Lucy Dacus", 2, "HomeVideo_VINYL", 0m, "Alternative", "Home Video", 124.99m, 2018 },
                    { 17, "Phoebe Bridgers", 2, "Punisher_VINYL", 0m, "Alternative", "Punisher", 249.99m, 2020 },
                    { 15, "Joni Mitchell", 2, "Shine_VINYL", 0m, "Alternative", "Shine", 249.99m, 1979 },
                    { 14, "Dua Lipa", 2, "FutureNostalgia_VINYL", 0m, "Pop", "Future Nostalgia", 249.99m, 2020 },
                    { 8, "Taylor Swift", 2, "Evermore_Vinyl", 0m, "Pop", "Evermore", 249.99m, 2020 },
                    { 6, "Taylor Swift", 2, "Folklore_VINYL", 0m, "Pop", "Folklore", 249.99m, 2020 },
                    { 3, "Taylor Swift", 2, "Red_VINYL", 0m, "Pop", "Red (Taylor's Version)", 249.99m, 2021 },
                    { 16, "Phoebe Bridgers", 1, "Punisher_CD", 0m, "Alternative", "Punisher", 124.99m, 2020 },
                    { 13, "Doja Cat", 1, "PlanetHer_CD", 0m, "Pop", "Planet Her", 124.99m, 2021 },
                    { 12, "Nirvana", 1, "Bleach_CD", 0m, "Rock", "Bleach", 249.99m, 1991 },
                    { 11, "Tyler the Creator", 1, "BecauseTheInternet_CD", 0m, "Hip Hop", "Because The Internet", 124.99m, 2011 },
                    { 7, "Taylor Swift", 1, "Evermore_CD", 0m, "Pop", "Evermore", 124.99m, 2020 },
                    { 5, "Taylor Swift", 1, "Folklore_CD", 0m, "Pop", "Folklore", 124.99m, 2020 },
                    { 4, "Olivia Rodrigo", 1, "Sour_CD", 0m, "Pop", "Sour", 124.99m, 2021 },
                    { 2, "Taylor Swift", 1, "Red_CD", 0m, "Pop", "Red (Taylor's Version)", 124.99m, 2021 },
                    { 10, "The Strokes", 3, "IsThisIt_C", 0m, "Alternative", "Is This It?", 149.99m, 2001 },
                    { 20, "Billie Marten", 3, "FloraFauna_Cassette", 0m, "Alternative", "Flora Fauna", 149.99m, 2021 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
