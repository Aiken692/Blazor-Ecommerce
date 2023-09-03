using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class Categories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("18177dd9-3e05-4f08-b567-8b8921478c04"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4841d2af-c405-480b-8986-609d8a2980c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb8ba409-8bd9-4d09-8981-49001746d5a7"));

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Products",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Url = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { new Guid("4a1074aa-ce6c-4bb0-9a92-f7065ee25d01"), "Books", "books" },
                    { new Guid("8e398bf9-471d-4810-aec8-0a92f615622a"), "Video Games", "video-games" },
                    { new Guid("bb180ee4-9333-4b87-89f9-dd0b6a015173"), "Movies", "movies" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("37b807cb-eb5a-4935-8589-fe12d88830e0"), new Guid("4a1074aa-ce6c-4bb0-9a92-f7065ee25d01"), "Ready Player One is a 2018 American science fiction film based on Ernest Cline's novel of the same name. Directed by Steven Spielberg from a screenplay by Zak Penn and Cline, it stars Tye Sheridan, Olivia Cooke, Ben Mendelsohn, Lena Waithe, T.J. Miller, Simon Pegg, and Mark Rylance. The film is set in 2045, where much of humanity uses the OASIS, a virtual reality simulation, to escape the real world. A teenage orphan finds clues to a contest that promises ownership of the OASIS to the winner, and he and his allies try to complete it before an evil corporation can do so.", "https://upload.wikimedia.org/wikipedia/en/7/74/Ready_Player_One_%28film%29.png", 7.9900000000000002, "Ready Player One" },
                    { new Guid("3c8929f0-7a3f-4706-80fa-92f6572f8c7b"), new Guid("4a1074aa-ce6c-4bb0-9a92-f7065ee25d01"), "Gods and Generals is a novel which serves as a prequel to Michael Shaara's 1974 Pulitzer Prize–winning work about the Battle of Gettysburg, The Killer Angels. Written by Jeffrey Shaara after his father Michael's death in 1988, the novel relates events from 1858 through 1863, during the American Civil War, ending just as the two armies march toward Gettysburg. Shaara also wrote The Last Full Measure, published in 2000, which follows the events presented in The Killer Angels.", "https://upload.wikimedia.org/wikipedia/en/6/65/GandGbook.jpg", 8.9900000000000002, "Gods and Generals " },
                    { new Guid("b7676d3b-e45f-48c4-8a71-9bf88cde491b"), new Guid("4a1074aa-ce6c-4bb0-9a92-f7065ee25d01"), "The Hitchhiker's Guide to the Galaxy adalah buku pertama dari lima seri trilogi komedi fiksi ilmiah Hitchhiker's Guide to the Galaxy karya Douglas Adams (buku keenam ditulis oleh Eoin Colfer). Novel ini merupakan adaptasi dari empat bagian pertama seri radio dengan nama yang sama. Novel ini pertama diterbitkan di London tanggal 12 Oktober 1979.[2] Buku ini terjual 250.000 eksemplar dalam kurun tiga bulan setelah diluncurkan.[3]Judul novel ini diambil dari The Hitchhiker's Guide to the Galaxy,", "https://upload.wikimedia.org/wikipedia/id/b/bd/H2G2_UK_front_cover.jpg?20130311090701", 9.9900000000000002, "The Hitchhiker's Guide to the Galaxy" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37b807cb-eb5a-4935-8589-fe12d88830e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c8929f0-7a3f-4706-80fa-92f6572f8c7b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b7676d3b-e45f-48c4-8a71-9bf88cde491b"));

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("18177dd9-3e05-4f08-b567-8b8921478c04"), "The Hitchhiker's Guide to the Galaxy adalah buku pertama dari lima seri trilogi komedi fiksi ilmiah Hitchhiker's Guide to the Galaxy karya Douglas Adams (buku keenam ditulis oleh Eoin Colfer). Novel ini merupakan adaptasi dari empat bagian pertama seri radio dengan nama yang sama. Novel ini pertama diterbitkan di London tanggal 12 Oktober 1979.[2] Buku ini terjual 250.000 eksemplar dalam kurun tiga bulan setelah diluncurkan.[3]Judul novel ini diambil dari The Hitchhiker's Guide to the Galaxy,", "https://upload.wikimedia.org/wikipedia/id/b/bd/H2G2_UK_front_cover.jpg?20130311090701", 9.9900000000000002, "The Hitchhiker's Guide to the Galaxy" },
                    { new Guid("4841d2af-c405-480b-8986-609d8a2980c4"), "Ready Player One is a 2018 American science fiction film based on Ernest Cline's novel of the same name. Directed by Steven Spielberg from a screenplay by Zak Penn and Cline, it stars Tye Sheridan, Olivia Cooke, Ben Mendelsohn, Lena Waithe, T.J. Miller, Simon Pegg, and Mark Rylance. The film is set in 2045, where much of humanity uses the OASIS, a virtual reality simulation, to escape the real world. A teenage orphan finds clues to a contest that promises ownership of the OASIS to the winner, and he and his allies try to complete it before an evil corporation can do so.", "https://upload.wikimedia.org/wikipedia/en/7/74/Ready_Player_One_%28film%29.png", 7.9900000000000002, "Ready Player One" },
                    { new Guid("cb8ba409-8bd9-4d09-8981-49001746d5a7"), "Gods and Generals is a novel which serves as a prequel to Michael Shaara's 1974 Pulitzer Prize–winning work about the Battle of Gettysburg, The Killer Angels. Written by Jeffrey Shaara after his father Michael's death in 1988, the novel relates events from 1858 through 1863, during the American Civil War, ending just as the two armies march toward Gettysburg. Shaara also wrote The Last Full Measure, published in 2000, which follows the events presented in The Killer Angels.", "https://upload.wikimedia.org/wikipedia/en/6/65/GandGbook.jpg", 8.9900000000000002, "Gods and Generals " }
                });
        }
    }
}
