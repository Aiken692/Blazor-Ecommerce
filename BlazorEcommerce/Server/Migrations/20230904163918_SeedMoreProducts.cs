using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class SeedMoreProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("09810593-9d89-4dde-8348-0b5d01361b33"), new Guid("4a1074aa-ce6c-4bb0-9a92-f7065ee25d01"), "Gods and Generals is a novel which serves as a prequel to Michael Shaara's 1974 Pulitzer Prize–winning work about the Battle of Gettysburg, The Killer Angels. Written by Jeffrey Shaara after his father Michael's death in 1988, the novel relates events from 1858 through 1863, during the American Civil War, ending just as the two armies march toward Gettysburg. Shaara also wrote The Last Full Measure, published in 2000, which follows the events presented in The Killer Angels.", "https://upload.wikimedia.org/wikipedia/en/6/65/GandGbook.jpg", 8.9900000000000002, "Gods and Generals " },
                    { new Guid("09be40fb-b889-4215-9d8b-c16de8cdf681"), new Guid("8e398bf9-471d-4810-aec8-0a92f615622a"), "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", 159.99000000000001, "Xbox" },
                    { new Guid("0e566652-12cf-47ac-9fdb-616ed9b0113d"), new Guid("8e398bf9-471d-4810-aec8-0a92f615622a"), "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", 14.99, "Day of the Tentacle" },
                    { new Guid("12cf6c7f-66d9-4f11-91ce-a6f3edf5ef22"), new Guid("bb180ee4-9333-4b87-89f9-dd0b6a015173"), "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.", "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg", 4.9900000000000002, "The Matrix" },
                    { new Guid("15f708d5-b07d-44bb-9b27-ebb78e1ffe6e"), new Guid("8e398bf9-471d-4810-aec8-0a92f615622a"), "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", 79.989999999999995, "Super Nintendo Entertainment System" },
                    { new Guid("18b2526a-0cd9-4831-82b2-524facbecee6"), new Guid("8e398bf9-471d-4810-aec8-0a92f615622a"), "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", 49.990000000000002, "Half-Life 2" },
                    { new Guid("49d6aa40-e33b-4519-87cd-2c5b88d6e48d"), new Guid("bb180ee4-9333-4b87-89f9-dd0b6a015173"), "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.", "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg", 3.9900000000000002, "Back to the Future" },
                    { new Guid("5bacf33f-683e-4561-9790-296261ee7a96"), new Guid("4a1074aa-ce6c-4bb0-9a92-f7065ee25d01"), "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.", "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg", 6.9900000000000002, "Nineteen Eighty-Four" },
                    { new Guid("6ff06d6c-02c8-4351-a5f9-6dad4ed4a634"), new Guid("4a1074aa-ce6c-4bb0-9a92-f7065ee25d01"), "The Hitchhiker's Guide to the Galaxy adalah buku pertama dari lima seri trilogi komedi fiksi ilmiah Hitchhiker's Guide to the Galaxy karya Douglas Adams (buku keenam ditulis oleh Eoin Colfer). Novel ini merupakan adaptasi dari empat bagian pertama seri radio dengan nama yang sama. Novel ini pertama diterbitkan di London tanggal 12 Oktober 1979.[2] Buku ini terjual 250.000 eksemplar dalam kurun tiga bulan setelah diluncurkan.[3]Judul novel ini diambil dari The Hitchhiker's Guide to the Galaxy,", "https://upload.wikimedia.org/wikipedia/id/b/bd/H2G2_UK_front_cover.jpg?20130311090701", 9.9900000000000002, "The Hitchhiker's Guide to the Galaxy" },
                    { new Guid("8bd3af64-168f-4e1e-85f7-28d35871939f"), new Guid("4a1074aa-ce6c-4bb0-9a92-f7065ee25d01"), "Ready Player One is a 2018 American science fiction film based on Ernest Cline's novel of the same name. Directed by Steven Spielberg from a screenplay by Zak Penn and Cline, it stars Tye Sheridan, Olivia Cooke, Ben Mendelsohn, Lena Waithe, T.J. Miller, Simon Pegg, and Mark Rylance. The film is set in 2045, where much of humanity uses the OASIS, a virtual reality simulation, to escape the real world. A teenage orphan finds clues to a contest that promises ownership of the OASIS to the winner, and he and his allies try to complete it before an evil corporation can do so.", "https://upload.wikimedia.org/wikipedia/en/7/74/Ready_Player_One_%28film%29.png", 7.9900000000000002, "Ready Player One" },
                    { new Guid("d713290e-e205-41f4-a765-a5cb453dc51a"), new Guid("8e398bf9-471d-4810-aec8-0a92f615622a"), "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", 9.9900000000000002, "Diablo II" },
                    { new Guid("fa064d8c-c511-412e-b550-87ac549519c6"), new Guid("bb180ee4-9333-4b87-89f9-dd0b6a015173"), "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.", "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg", 2.9900000000000002, "Toy Story" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09810593-9d89-4dde-8348-0b5d01361b33"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09be40fb-b889-4215-9d8b-c16de8cdf681"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e566652-12cf-47ac-9fdb-616ed9b0113d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12cf6c7f-66d9-4f11-91ce-a6f3edf5ef22"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15f708d5-b07d-44bb-9b27-ebb78e1ffe6e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("18b2526a-0cd9-4831-82b2-524facbecee6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("49d6aa40-e33b-4519-87cd-2c5b88d6e48d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5bacf33f-683e-4561-9790-296261ee7a96"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ff06d6c-02c8-4351-a5f9-6dad4ed4a634"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8bd3af64-168f-4e1e-85f7-28d35871939f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d713290e-e205-41f4-a765-a5cb453dc51a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fa064d8c-c511-412e-b550-87ac549519c6"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("37b807cb-eb5a-4935-8589-fe12d88830e0"), new Guid("4a1074aa-ce6c-4bb0-9a92-f7065ee25d01"), "Ready Player One is a 2018 American science fiction film based on Ernest Cline's novel of the same name. Directed by Steven Spielberg from a screenplay by Zak Penn and Cline, it stars Tye Sheridan, Olivia Cooke, Ben Mendelsohn, Lena Waithe, T.J. Miller, Simon Pegg, and Mark Rylance. The film is set in 2045, where much of humanity uses the OASIS, a virtual reality simulation, to escape the real world. A teenage orphan finds clues to a contest that promises ownership of the OASIS to the winner, and he and his allies try to complete it before an evil corporation can do so.", "https://upload.wikimedia.org/wikipedia/en/7/74/Ready_Player_One_%28film%29.png", 7.9900000000000002, "Ready Player One" },
                    { new Guid("3c8929f0-7a3f-4706-80fa-92f6572f8c7b"), new Guid("4a1074aa-ce6c-4bb0-9a92-f7065ee25d01"), "Gods and Generals is a novel which serves as a prequel to Michael Shaara's 1974 Pulitzer Prize–winning work about the Battle of Gettysburg, The Killer Angels. Written by Jeffrey Shaara after his father Michael's death in 1988, the novel relates events from 1858 through 1863, during the American Civil War, ending just as the two armies march toward Gettysburg. Shaara also wrote The Last Full Measure, published in 2000, which follows the events presented in The Killer Angels.", "https://upload.wikimedia.org/wikipedia/en/6/65/GandGbook.jpg", 8.9900000000000002, "Gods and Generals " },
                    { new Guid("b7676d3b-e45f-48c4-8a71-9bf88cde491b"), new Guid("4a1074aa-ce6c-4bb0-9a92-f7065ee25d01"), "The Hitchhiker's Guide to the Galaxy adalah buku pertama dari lima seri trilogi komedi fiksi ilmiah Hitchhiker's Guide to the Galaxy karya Douglas Adams (buku keenam ditulis oleh Eoin Colfer). Novel ini merupakan adaptasi dari empat bagian pertama seri radio dengan nama yang sama. Novel ini pertama diterbitkan di London tanggal 12 Oktober 1979.[2] Buku ini terjual 250.000 eksemplar dalam kurun tiga bulan setelah diluncurkan.[3]Judul novel ini diambil dari The Hitchhiker's Guide to the Galaxy,", "https://upload.wikimedia.org/wikipedia/id/b/bd/H2G2_UK_front_cover.jpg?20130311090701", 9.9900000000000002, "The Hitchhiker's Guide to the Galaxy" }
                });
        }
    }
}
