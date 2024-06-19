using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechnicalAssessmentRokov.Migrations
{
    /// <inheritdoc />
    public partial class RemoveLockout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_UserAccounts_CHECKED_OUT_BY",
                table: "Books");

            migrationBuilder.DropTable(
                name: "UserAccounts");

            migrationBuilder.DropIndex(
                name: "IX_Books_CHECKED_OUT_BY",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Carlo Watsica", "eveniet", "https://picsum.photos/50/50/?image=286", "Mollitia aspernatur rerum nihil vitae quo dicta ut illo molestiae nisi veritatis facilis qui in et fugiat qui autem tempora.", 180715893, 843, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), "Koss Group", "networks SCSI Tunisian Dinar" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Christina Gleichner", "qui", "https://picsum.photos/50/50/?image=709", "Sunt perferendis quos consequatur nisi hic in enim et quasi delectus vel sit assumenda explicabo nam necessitatibus reiciendis dolor incidunt.", 154829113, 276, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), "Okuneva - Stracke", "Congo Prairie analyzer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dina Murazik", "mollitia", "https://picsum.photos/50/50/?image=773", "Quisquam ratione inventore omnis incidunt consequatur et amet nulla et ipsa animi nihil voluptatem aut voluptas vitae reprehenderit quaerat enim.", 306360028, 888, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Cole, Rowe and Kiehn", "Common Fundamental Viaduct" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Elda Monahan", "pariatur", "https://picsum.photos/50/50/?image=230", "Dolorem natus qui ex ad illum labore nam illo et molestiae eos vel quo voluptatibus molestias saepe cum eos et.", 552921309, 279, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "Funk, Bernhard and Quigley", "Tasty Frozen Chips Singapore process improvement" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Adonis Wilderman", "nesciunt", "https://picsum.photos/50/50/?image=7", "Numquam quos aut architecto illo commodi harum enim quo voluptatem blanditiis optio officiis nisi rem laudantium ut quis sunt quia.", 140801651, 333, new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), "Denesik Inc", "HDD PNG Togo" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ashley Hamill", "qui", "https://picsum.photos/50/50/?image=943", "Quasi nobis id est nihil error cum temporibus voluptas aliquid doloribus officia nam magnam maiores praesentium aliquam quos repellat aut.", 388276519, 239, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "Prosacco - Leannon", "Creek Soft Ergonomic Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Grant Bartoletti", "aliquam", "https://picsum.photos/50/50/?image=352", "Fuga quam unde debitis quia doloribus aperiam non illum autem eaque magni eum nemo nihil perferendis consequatur ea aut sed.", 722140004, 530, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), "O'Hara - Pollich", "Lempira matrix Trail" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Brent Graham", "aliquam", "https://picsum.photos/50/50/?image=52", "Blanditiis doloremque deleniti a odit fuga nam repellendus dicta dolores harum minima et dolore voluptas nostrum quo est cum hic.", 482024732, 160, new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "Legros, Robel and Rolfson", "reintermediate International Tasty Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hailey Mraz", "repudiandae", "https://picsum.photos/50/50/?image=371", "Quae aliquam aliquam voluptatum et accusamus deleniti ab placeat a est eum quia consectetur dignissimos omnis dolore non labore et.", 984850256, 726, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), "Weimann, Block and Larson", "Practical Finland Garden & Sports" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Pink Buckridge", "at", "https://picsum.photos/50/50/?image=867", "Iste culpa ut itaque quo ut minima eaque minima quidem ullam voluptate reprehenderit magnam libero saepe perspiciatis impedit repudiandae suscipit.", 107166849, 566, new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), "Paucek LLC", "Tasty Credit Card Account Berkshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Wyatt Parker", "minus", "https://picsum.photos/50/50/?image=668", "Facere et cupiditate assumenda animi id dolorem dignissimos et vel sunt quia sed saepe ab et consectetur adipisci ut rerum.", 654919092, 393, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "Mayer, Feeney and Murazik", "withdrawal circuit Computers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Katharina Senger", "quasi", "https://picsum.photos/50/50/?image=557", "Quas minima est aperiam exercitationem dolor sit culpa debitis consequuntur reiciendis sint nobis natus et quaerat ab labore ut incidunt.", 179595136, 238, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "Beer, Grady and Erdman", "killer Garden Buckinghamshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lessie Williamson", "modi", "https://picsum.photos/50/50/?image=1049", "Cumque eum blanditiis aut officiis voluptas sunt minima qui asperiores est saepe deserunt at molestiae et quae ad sint sed.", 329843453, 604, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), "Koch - Stanton", "Response Dominican Peso Pa'anga" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Retha Hagenes", "corporis", "https://picsum.photos/50/50/?image=495", "Consequatur aut doloribus veniam similique esse commodi aut maxime quia suscipit totam quos et illo aut eveniet est velit maxime.", 652040350, 499, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), "Bradtke Inc", "Architect Springs PCI" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Maxie Schiller", "ea", "https://picsum.photos/50/50/?image=658", "Voluptate nesciunt quia ex molestiae eaque est odio sequi eos et aut cumque officiis unde omnis non voluptas voluptas totam.", 618970512, 133, new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), "Zboncak LLC", "Quetzal Buckinghamshire Practical Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dillon Dicki", "est", "https://picsum.photos/50/50/?image=1031", "Nihil provident consequuntur voluptatum aut doloremque veniam nihil placeat voluptatem et molestias vel dolorem magni corrupti beatae in nisi quod.", 614354956, 96, new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), "Batz Inc", "JBOD index bus" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kip McGlynn", "itaque", "https://picsum.photos/50/50/?image=449", "Consequatur laudantium non optio quas qui assumenda quia tempore neque aut aut architecto et rem sunt asperiores aut possimus amet.", 136593960, 774, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), "Windler LLC", "Handcrafted compressing Credit Card Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ramiro Turner", "magni", "https://picsum.photos/50/50/?image=946", "Velit harum voluptas eveniet et ipsa omnis nulla et et atque eveniet atque autem quo voluptatum sed nihil ratione at.", 580331529, 518, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "Runolfsson, Conn and Schroeder", "XSS input Moroccan Dirham" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "AUTHOR", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jimmy Pagac", "https://picsum.photos/50/50/?image=287", "Quas necessitatibus atque et omnis voluptas quisquam autem nam dicta ut et dicta expedita velit quos consectetur temporibus possimus reprehenderit.", 702502851, 530, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), "Daugherty, Konopelski and Jones", "Plastic Tasty Lithuanian Litas" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Leola Wolff", "doloremque", "https://picsum.photos/50/50/?image=927", "Nihil explicabo qui modi ut nulla quia eius et sed voluptatum occaecati fugit ipsa qui ut aspernatur est commodi voluptatem.", 394397332, 737, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "Daniel LLC", "Djibouti Franc Refined Granite Tuna parse" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Emery O'Kon", "impedit", "https://picsum.photos/50/50/?image=3", "Assumenda vitae expedita quo omnis architecto ullam dolorum a quasi quos commodi quod est molestiae eius vitae in est impedit.", 298741037, 467, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), "Carter - Ernser", "Michigan Manor Web" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Shirley Johnson", "consequatur", "https://picsum.photos/50/50/?image=416", "Ut neque nobis similique doloremque debitis dolore qui ex consequatur consectetur deleniti illo quasi et nulla id incidunt aut voluptatem.", 814671338, 405, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Kutch - Daniel", "Indiana Future Rustic Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Gerda O'Kon", "occaecati", "https://picsum.photos/50/50/?image=1045", "Necessitatibus quo eaque nam voluptatum aut in odio rerum placeat dolorum adipisci quis aut ullam ut quam totam velit qui.", 551382814, 652, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "Volkman, O'Kon and Brekke", "International tan stable" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Gregory Friesen", "quia", "https://picsum.photos/50/50/?image=213", "Et itaque aut pariatur perspiciatis molestias saepe quos ut provident et dolorem nobis laborum recusandae consequatur at aspernatur nihil accusantium.", 302048470, 486, new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Wolf and Sons", "Metal Compatible Throughway" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Freddy Hegmann", "esse", "https://picsum.photos/50/50/?image=1004", "Alias expedita similique non laboriosam deleniti quia explicabo velit molestiae quidem odit sed sed recusandae maxime numquam consequatur et a.", 765235469, 438, new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), "Gislason, Lubowitz and Smitham", "Alley niches Mauritania" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Freddy Conroy", "facilis", "https://picsum.photos/50/50/?image=348", "Aliquam voluptas ut ratione deserunt qui repellendus qui voluptas et eos eligendi blanditiis et et nihil non dolorem et atque.", 682773931, 643, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Local), "Kessler Group", "Refined Steel Car Handmade Rubber Computer IB" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Vesta Kshlerin", "itaque", "https://picsum.photos/50/50/?image=637", "Architecto ipsam dignissimos in occaecati quos impedit autem dolore vel iure aut ducimus quia reprehenderit fuga eligendi rerum reprehenderit ipsam.", 908185428, 859, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), "Hessel, Carter and Stiedemann", "East Caribbean Dollar protocol Corporate" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kaelyn Baumbach", "cumque", "https://picsum.photos/50/50/?image=171", "Eos eum nulla ipsam quis sit reiciendis atque perferendis sit quibusdam non et blanditiis nemo sit voluptatum recusandae accusamus et.", 932026982, 308, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "Ebert - Jacobson", "Point unleash Tools, Kids & Beauty" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Eulalia Lowe", "rerum", "https://picsum.photos/50/50/?image=199", "A eligendi numquam nihil accusantium dolore inventore ipsa et saepe exercitationem molestias sunt aperiam optio tenetur qui ut reprehenderit debitis.", 780713322, 767, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), "Champlin, Runolfsson and DuBuque", "software firewall Incredible Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Adonis Wolf", "repellat", "https://picsum.photos/50/50/?image=1061", "Neque velit consectetur maxime eum dolore perspiciatis sit sit inventore corporis porro et corrupti et doloremque nisi excepturi et amet.", 389188713, 233, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), "Paucek, Okuneva and Gulgowski", "Rustic Steel Computer blockchains toolset" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Caroline Murazik", "totam", "https://picsum.photos/50/50/?image=286", "Consequuntur dolore et nulla numquam nulla laborum praesentium et est alias sunt exercitationem et illo labore a cum fugiat fuga.", 317357590, 711, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Local), "Leffler, Howe and Lowe", "tan PNG Infrastructure" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Robyn Volkman", "sed", "https://picsum.photos/50/50/?image=934", "Est quidem officiis eveniet laudantium error vel distinctio aperiam enim aut rem dolor perferendis ut recusandae esse voluptatem voluptatibus eum.", 246954182, 719, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), "Swaniawski Group", "SMTP bypass Soft" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Saige Shanahan", "suscipit", "https://picsum.photos/50/50/?image=612", "Accusamus sit officia consectetur ea eos non aut a soluta fugit repellendus aut doloribus quae ut reiciendis maxime eveniet dicta.", 113871271, 903, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Local), "Schmitt, Heidenreich and Williamson", "Synergized Berkshire Investment Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Major Bashirian", "occaecati", "https://picsum.photos/50/50/?image=460", "Quo vel eos fugit ex inventore unde esse quia quam eveniet earum voluptas accusantium quaerat natus voluptas velit dolore dolor.", 954265200, 432, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), "Brakus - Pagac", "ROI intangible Trafficway" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lee Schaden", "accusantium", "https://picsum.photos/50/50/?image=791", "Consequatur in eaque rerum suscipit error nulla est odit sequi veniam doloribus fugit maxime repellat laborum optio omnis modi ullam.", 992579072, 139, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "Konopelski Group", "Books & Movies Uruguay deposit" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Andreane Kuhic", "quod", "https://picsum.photos/50/50/?image=308", "Quia doloribus ut sed maxime nostrum minus qui architecto sunt tempore est sed nihil deserunt distinctio sed sed repellendus veritatis.", 416828507, 93, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), "Windler, Prohaska and Haag", "primary PCI Rustic Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Vivian Grant", "aliquam", "https://picsum.photos/50/50/?image=747", "Velit labore quo dolor in doloremque quia a et praesentium commodi qui corrupti doloribus omnis tempora id et consequatur harum.", 683706703, 303, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "Ankunding - Nikolaus", "Legacy Fantastic Fresh Tuna solid state" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kasandra Klein", "qui", "https://picsum.photos/50/50/?image=630", "Quas quae neque labore doloribus consequuntur voluptas sint totam maxime accusantium maiores facere soluta ducimus omnis voluptas explicabo sit itaque.", 436378127, 240, new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), "Johns, Rath and Hahn", "Stravenue Checking Account Analyst" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Otho Fay", "veritatis", "https://picsum.photos/50/50/?image=279", "Minus vel est aut voluptatem necessitatibus rerum iusto a unde totam ab voluptas ex nulla illo impedit rerum nobis aut.", 631356311, 605, new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), "Adams LLC", "Euro Lilangeni Fantastic" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jacques Kilback", "illo", "https://picsum.photos/50/50/?image=118", "Occaecati iusto tempora dolorem incidunt sed necessitatibus debitis deserunt atque praesentium consequatur nam tempora a est atque qui molestiae ut.", 162905232, 613, new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), "Yost, Botsford and Casper", "Ergonomic Configurable Response" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Zackery Mitchell", "corrupti", "https://picsum.photos/50/50/?image=461", "Sit et repudiandae dolores ut molestiae blanditiis cum eligendi et fugiat blanditiis dicta cumque praesentium unde voluptatem repellendus non et.", 244382031, 315, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), "Little - Schroeder", "Configurable port copying" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Gregoria Rodriguez", "et", "https://picsum.photos/50/50/?image=261", "Suscipit similique quasi cupiditate dolores nobis veniam minima qui ut aut vel dolorem ab et aut molestiae perferendis natus est.", 427927498, 144, new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Donnelly - Bauch", "violet Paradigm payment" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Norberto Labadie", "aliquam", "https://picsum.photos/50/50/?image=604", "Minima quia quidem corrupti fugiat nam non blanditiis maiores ullam placeat sint facilis consequatur consequatur similique neque dolor assumenda impedit.", 917240589, 696, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Local), "Schultz Group", "Plastic transmitter Kids & Toys" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Erwin Champlin", "deleniti", "https://picsum.photos/50/50/?image=624", "Repellat iure quae magnam reprehenderit hic voluptatem rerum hic eos reprehenderit rerum blanditiis aut fugiat facere quam aut sed dolorem.", 602829269, 742, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), "Green, Torp and Feest", "magenta SMS deposit" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Destiney Conn", "veniam", "https://picsum.photos/50/50/?image=946", "Alias libero deleniti libero ipsum possimus error delectus necessitatibus ut quia suscipit magnam beatae in omnis omnis sint voluptas est.", 531433403, 621, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "Simonis - Konopelski", "Rubber Shores Square" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Brandi Prosacco", "quis", "https://picsum.photos/50/50/?image=677", "Aut quasi aliquam accusantium consectetur labore voluptas nesciunt numquam dolorem dolorem incidunt sed nisi sequi iure quam id assumenda nobis.", 923301416, 415, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), "Farrell LLC", "Producer hack Cambridgeshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Johnson Auer", "eveniet", "https://picsum.photos/50/50/?image=202", "Accusamus inventore sapiente accusantium accusantium enim id repudiandae expedita soluta omnis modi est facilis tempora aperiam sint optio et sit.", 593263178, 316, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "Lakin LLC", "Generic Concrete Gloves Tasty Directives" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Shea Cassin", "ut", "https://picsum.photos/50/50/?image=235", "Aut perferendis ea id atque quis assumenda quia a excepturi suscipit et deleniti ab voluptas quam odit assumenda illo inventore.", 604121066, 428, new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), "Gleichner - Armstrong", "impactful Gorgeous Frozen Shoes Bedfordshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Elwin Toy", "veniam", "https://picsum.photos/50/50/?image=309", "Explicabo repudiandae distinctio ullam omnis qui qui et suscipit expedita eum corporis dolor aperiam quaerat repellendus blanditiis doloremque aut error.", 474752260, 945, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), "Littel, Ondricka and Treutel", "New Hampshire Tasty Rubber Chicken Practical Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "William Reinger", "dicta", "https://picsum.photos/50/50/?image=1008", "Molestias corrupti nobis quae repellendus deleniti vel nihil dolorem fugiat accusamus iste veritatis laudantium et est excepturi deleniti aut nam.", 967834839, 633, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), "Von Group", "seamless Associate Home" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Devyn Conn", "non", "https://picsum.photos/50/50/?image=993", "Facilis accusamus odio modi sed accusamus fugiat cupiditate veritatis voluptas autem consequatur officia consequatur distinctio placeat est vero voluptatem aut.", 420021800, 141, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), "Cormier, Considine and Haley", "Savings Account expedite FTP" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Tanner Hane", "qui", "https://picsum.photos/50/50/?image=1070", "Officiis rerum quia reiciendis dolores impedit ut ut qui rem repellendus esse doloribus ipsam quis id molestiae voluptatem dolorum vel.", 680349654, 738, new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), "Torp, Stokes and Halvorson", "connecting open-source Afghani" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Tyra Brakus", "ut", "https://picsum.photos/50/50/?image=638", "Excepturi doloribus et aliquam dolores omnis et consequuntur accusamus ullam eligendi deserunt distinctio error tempora nisi magnam et est aspernatur.", 501400273, 650, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), "Keeling and Sons", "Organic Belize Credit Card Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "AUTHOR", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jonas Sanford", "https://picsum.photos/50/50/?image=386", "Sequi in et sunt facere omnis quos earum deleniti vitae ab temporibus est nihil odio et molestias amet vitae est.", 914459801, 281, new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), "Cole, Christiansen and Witting", "Nakfa Granite North Carolina" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jerad Ankunding", "culpa", "https://picsum.photos/50/50/?image=741", "Consequatur deleniti ad vel placeat doloribus libero ab dolorem perspiciatis rerum eligendi vitae accusamus temporibus nostrum eius rerum veritatis soluta.", 614022527, 558, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), "Balistreri, Moen and Upton", "Licensed program Virtual" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Caroline Legros", "ipsum", "https://picsum.photos/50/50/?image=734", "Voluptatum voluptatibus architecto rem ipsa nobis voluptatem omnis temporibus unde tempore quia est dolores ab aut quos aut molestiae tempore.", 170759354, 128, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), "Carter, Nolan and Friesen", "Concrete payment Checking Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Noemi Frami", "architecto", "https://picsum.photos/50/50/?image=321", "Voluptas et iste magnam inventore adipisci nihil dignissimos rerum aliquam qui aliquid unde at repellat magnam explicabo sed et sapiente.", 992880895, 170, new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), "Jacobi - Murazik", "Gorgeous Borders back up" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Peyton Green", "corrupti", "https://picsum.photos/50/50/?image=1011", "Et in dolores quia laboriosam totam quibusdam eos aut aut laudantium nihil magni hic et vero explicabo enim excepturi hic.", 350381402, 121, new DateTime(2023, 7, 9, 0, 0, 0, 0, DateTimeKind.Local), "Buckridge LLC", "Health & Grocery payment Field" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ethyl Dooley", "error", "https://picsum.photos/50/50/?image=674", "Eos consequatur expedita sunt est natus sed sint totam dicta atque ipsam nulla veniam iste eius rem minima tempora est.", 885511053, 336, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), "Lueilwitz - Hagenes", "bricks-and-clicks quantifying withdrawal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Eugene Adams", "quia", "https://picsum.photos/50/50/?image=220", "Rerum ut vel maxime velit dolore nulla nemo voluptatem et ut velit quis sit temporibus error accusantium consequuntur et in.", 179994623, 680, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "Rowe and Sons", "parsing Drive generate" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Esperanza Schuster", "necessitatibus", "https://picsum.photos/50/50/?image=356", "Ipsa ut error ullam praesentium dignissimos distinctio accusamus ea dolorem est delectus quasi voluptatem veniam occaecati minima earum illo aut.", 363273603, 677, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), "Jacobson - West", "Director Credit Card Account Tasty" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Quentin Hahn", "tempore", "https://picsum.photos/50/50/?image=164", "Molestiae exercitationem cupiditate deserunt id sint expedita illum fuga minus porro vel vel blanditiis labore nihil adipisci cum eligendi sed.", 519928836, 726, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), "Gerlach - Howell", "index transmit primary" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Maxwell Reilly", "dolor", "https://picsum.photos/50/50/?image=793", "Quia commodi illo quidem rerum quia vero voluptate et ut fugit odit et molestias perspiciatis commodi laboriosam dolores unde sed.", 868451266, 953, new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), "Zulauf - Wunsch", "Dynamic Granite Bedfordshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Manley O'Conner", "consequatur", "https://picsum.photos/50/50/?image=907", "Sint non eligendi natus fuga ipsum excepturi tenetur aperiam quaerat natus aut ut mollitia quis sit doloribus nemo qui in.", 649609556, 600, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), "Dickens, Spencer and Donnelly", "Toys Investment Account deliver" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jerald Mitchell", "odio", "https://picsum.photos/50/50/?image=72", "Libero harum facere nostrum sit quia sed illum dolores eaque hic eius est fugiat repellendus ratione deleniti minima aut nemo.", 612676389, 377, new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), "Steuber, Parker and Rath", "Dynamic monitor Home Loan Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kelli McClure", "vitae", "https://picsum.photos/50/50/?image=964", "Ut omnis ratione qui nihil ut sunt rerum ipsam aut et voluptates atque et assumenda recusandae ut nihil dicta aperiam.", 115477007, 541, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), "Feest - Wyman", "Concrete Balanced Washington" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Fay Block", "expedita", "https://picsum.photos/50/50/?image=186", "Maxime excepturi recusandae dignissimos sunt soluta aliquid modi tempora odit facilis consequuntur et adipisci ea sit modi incidunt illo consequatur.", 208666282, 57, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Dickens and Sons", "Rustic Rubber Shirt Director Licensed Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Stanley Hermiston", "sapiente", "https://picsum.photos/50/50/?image=453", "Quibusdam excepturi odio consequatur iste aperiam quia ut ut amet autem tempore accusantium eos ab alias reiciendis ea nihil illum.", 191632809, 199, new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), "Bradtke, Okuneva and Pouros", "Quality-focused Identity Unbranded Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Leo Stamm", "saepe", "https://picsum.photos/50/50/?image=204", "Quia id exercitationem voluptatem doloremque asperiores quo ipsam consectetur ut fugiat quaerat odit natus alias iste minus autem ipsa doloremque.", 202611587, 162, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "Welch and Sons", "Neck AI Operative" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Pansy Kulas", "soluta", "https://picsum.photos/50/50/?image=195", "Neque consequatur nihil qui nobis qui cum et nostrum voluptatum quod animi adipisci recusandae nemo consectetur qui labore quisquam totam.", 573476029, 551, new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Local), "Braun, Stark and Cruickshank", "Licensed Fresh Tuna Arkansas back up" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Selmer Bartell", "et", "https://picsum.photos/50/50/?image=927", "Ab dolores consequuntur explicabo incidunt maiores enim ratione sequi qui eos aut et deserunt aperiam autem eum labore dolorem repellendus.", 682657901, 558, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Local), "Brakus - Bernier", "connecting port National" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Caroline Klein", "quia", "https://picsum.photos/50/50/?image=217", "Ut iusto consectetur praesentium nulla ea est beatae similique id qui consequatur voluptas doloribus ut dicta ad repudiandae dicta magni.", 370788326, 110, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Baumbach Group", "Ergonomic Fresh Bacon Prairie Checking Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alphonso Swaniawski", "et", "https://picsum.photos/50/50/?image=917", "Quibusdam odio id id enim voluptatibus sint similique maxime laboriosam aspernatur aut molestias doloremque tenetur ea quia nisi aperiam excepturi.", 944866514, 269, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Local), "Stracke, Mann and Okuneva", "Rustic Wooden New Mexico" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Elisa Predovic", "nam", "https://picsum.photos/50/50/?image=479", "Expedita est pariatur consectetur perspiciatis eaque qui ut ducimus ad non excepturi quaerat et et distinctio odit dolor debitis recusandae.", 762862643, 983, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), "Kulas Inc", "payment Soft Vermont" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ali Harvey", "laboriosam", "https://picsum.photos/50/50/?image=1041", "Sed maxime in atque architecto consequatur ut modi laudantium et amet est harum ratione dolores doloremque enim quisquam corporis voluptas.", 517899193, 110, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), "Koepp Inc", "Azerbaijanian Manat transparent Indiana" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Bianka Jacobson", "neque", "https://picsum.photos/50/50/?image=869", "Molestiae perspiciatis iste repellendus quis ea maiores tempore labore incidunt omnis ex molestiae magnam repellendus voluptate recusandae iusto sit nostrum.", 195407307, 770, new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), "Hirthe - Rutherford", "Papua New Guinea withdrawal Checking Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alexane Rath", "placeat", "https://picsum.photos/50/50/?image=365", "Odio et iste quos iusto aut laudantium officiis hic quo id enim voluptas et consectetur cumque et fuga veritatis voluptatem.", 573838162, 308, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), "Murray Inc", "Avon Plains white" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mose Nikolaus", "libero", "https://picsum.photos/50/50/?image=341", "Quam molestiae non aut qui asperiores atque voluptatem voluptate at iste facere sed accusantium et enim magni consectetur id labore.", 672058720, 573, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), "Mayer and Sons", "orchid Unbranded interface" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Angie Treutel", "et", "https://picsum.photos/50/50/?image=843", "Omnis aut corporis dolor velit deleniti doloremque quasi et sapiente quos ut itaque assumenda et perspiciatis est facere nihil est.", 450664755, 202, new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), "Erdman, Monahan and Hintz", "Hollow Proactive Checking Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Emelia Carter", "aut", "https://picsum.photos/50/50/?image=66", "Unde placeat quia quia molestias in et nam omnis qui eveniet earum odit impedit doloribus tenetur non corporis voluptas quae.", 686149731, 876, new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), "Larson, Boyle and McGlynn", "red Metal Handcrafted" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dave Weber", "rerum", "https://picsum.photos/50/50/?image=859", "Veritatis odio officiis eos dolore repellat et inventore dolores amet beatae quo magni ut natus praesentium aspernatur officiis veritatis quasi.", 555635169, 145, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), "Cormier and Sons", "reboot protocol integrated" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Shad Funk", "est", "https://picsum.photos/50/50/?image=1024", "Perspiciatis voluptatem voluptatem numquam eaque voluptas debitis autem molestiae animi occaecati iure delectus quia nihil culpa pariatur rerum in odio.", 152713512, 650, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Lebsack LLC", "Producer fuchsia initiative" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Tyrel Klocko", "et", "https://picsum.photos/50/50/?image=960", "Voluptatem a qui aut distinctio et et dolorem nihil vero dolor maxime quibusdam at cum pariatur atque et non explicabo.", 176339474, 962, new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), "Abbott Group", "Trinidad and Tobago Dollar monitor Multi-lateral" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Thea Swift", "nihil", "https://picsum.photos/50/50/?image=19", "Cupiditate veritatis ab ab culpa facilis quia quisquam veritatis officia a recusandae reiciendis culpa magnam enim aliquam iure cupiditate dolores.", 139178757, 967, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), "Stamm, Roberts and Schinner", "SSL Macedonia Steel" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Juanita Anderson", "ipsa", "https://picsum.photos/50/50/?image=38", "Corrupti officia porro et tempore aliquid ipsum facilis possimus distinctio nesciunt ea eos id labore at illo ipsam numquam aliquid.", 458755951, 886, new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), "Hansen, Rolfson and Kling", "Tasty Fresh Chips Metal Small" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Otho Gutmann", "molestiae", "https://picsum.photos/50/50/?image=830", "Veritatis dignissimos sit accusantium ullam voluptas explicabo laborum cumque commodi excepturi omnis soluta dignissimos consequuntur dignissimos exercitationem nihil voluptatum minima.", 102324292, 582, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), "Runte, Hudson and Hammes", "Unbranded Granite Shirt Spring Massachusetts" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Demario Powlowski", "et", "https://picsum.photos/50/50/?image=1001", "Dolore debitis facere tenetur non enim qui totam blanditiis quis consectetur tenetur vel consequatur nostrum consequatur sequi sunt sunt commodi.", 818779701, 771, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "Kuvalis, Okuneva and Rippin", "syndicate Metrics niches" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Myrtle Russel", "autem", "https://picsum.photos/50/50/?image=144", "Distinctio provident dolores et iure eum a quia est ut odio aperiam sed dolorum vel dolore explicabo ut illum unde.", 779184198, 245, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "Rippin LLC", "Credit Card Account bi-directional orange" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Zita Kozey", "aliquid", "https://picsum.photos/50/50/?image=203", "Tempore ut itaque eligendi vero dolorem facere placeat doloribus voluptate rem consequatur eum ullam quia aut praesentium itaque laudantium at.", 278502096, 854, new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "Stroman, Rippin and Wiza", "discrete Business-focused parse" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lura Gerlach", "eos", "https://picsum.photos/50/50/?image=483", "Ut asperiores consequatur excepturi ipsam earum non modi excepturi eius tempore possimus quibusdam sit nulla voluptas molestiae veritatis debitis dolores.", 598067277, 779, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), "Willms and Sons", "Dynamic RAM compressing" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Nia Kozey", "temporibus", "https://picsum.photos/50/50/?image=392", "Laudantium et iure ut reprehenderit laudantium ipsa et iste ipsum voluptatem est ea quaerat sint explicabo et dolores sed labore.", 835488125, 717, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Jacobi Group", "initiatives Integration online" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Abby Stokes", "sapiente", "https://picsum.photos/50/50/?image=392", "Ea totam quidem fugit recusandae nihil dicta voluptatem architecto voluptatem dolorem doloremque numquam ut sed at et non repudiandae magnam.", 796318293, 990, new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), "Sawayn - Zemlak", "Berkshire Specialist recontextualize" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Green Mayert", "magni", "https://picsum.photos/50/50/?image=799", "Aspernatur sint excepturi alias dignissimos culpa aut nobis consectetur provident qui alias facere et voluptatum dolor nobis hic est possimus.", 442512604, 317, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "Paucek, Nolan and Swift", "Music, Garden & Jewelery intangible Vietnam" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jade Orn", "enim", "https://picsum.photos/50/50/?image=811", "Ut maxime officia quisquam perferendis esse autem vel ut harum tempore porro impedit tempore dolor repudiandae qui aliquam officia et.", 216682696, 236, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), "Douglas Group", "Intelligent Tools Fantastic" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Darrick Yost", "inventore", "https://picsum.photos/50/50/?image=903", "Et quibusdam temporibus optio numquam eligendi quia itaque veniam consectetur eius iure tempora ullam consectetur ratione recusandae dolorum omnis quasi.", 401437612, 89, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), "Strosin, Bednar and Hodkiewicz", "deposit Handcrafted Metal Tuna River" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Zachary Leannon", "et", "https://picsum.photos/50/50/?image=766", "Nam earum incidunt ullam quia consequuntur tempore non distinctio quisquam similique maiores cumque beatae nesciunt aperiam fuga nesciunt vero eos.", 119132240, 181, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), "Wehner - Brekke", "turquoise AGP instruction set" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kian Gerlach", "cumque", "https://picsum.photos/50/50/?image=281", "Numquam nihil ut est et sint voluptates reiciendis minus iure in suscipit suscipit soluta dolor corporis laboriosam nihil consequatur eaque.", 345284071, 228, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), "Hegmann, Welch and Russel", "withdrawal Money Market Account Bridge" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Spencer Homenick", "ipsum", "https://picsum.photos/50/50/?image=296", "Eaque et consequatur non optio mollitia fugiat minima atque commodi omnis facilis occaecati rem eum soluta aut tempora sunt nihil.", 919596258, 673, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), "Botsford, Schuster and Price", "TCP port Handmade" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Margarita Shields", "repudiandae", "https://picsum.photos/50/50/?image=760", "Aut nihil assumenda voluptas qui inventore velit eum animi inventore et sed voluptatem fuga facere nam voluptas qui aspernatur ducimus.", 203211016, 473, new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), "Schumm, Tremblay and Kuphal", "Investment Account visionary quantify" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Travon Torp", "sunt", "https://picsum.photos/50/50/?image=798", "Repellendus laboriosam deleniti modi qui id aut commodi cumque pariatur non et molestiae doloribus adipisci officia et rem hic ut.", 575079929, 604, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), "Legros - McClure", "Unbranded Granite Mouse Credit Card Account optimize" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "AspNetUsers",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserAccounts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PASSWORD = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ROLE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    USER_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccounts", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Julian Larkin", "eos", "https://picsum.photos/50/50/?image=608", "Itaque temporibus et corporis officia distinctio et rerum architecto voluptatem vitae quo alias incidunt tempore aut qui provident nisi ut.", 378302538, 335, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), "Kirlin - Kozey", "Mall sensor Rustic Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sarina Conn", "occaecati", "https://picsum.photos/50/50/?image=226", "Debitis esse inventore sed omnis sint unde molestiae beatae blanditiis quia nemo laudantium aut repellat consectetur aut illo accusantium vel.", 929327994, 202, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), "White Inc", "compress front-end pink" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mable O'Reilly", "error", "https://picsum.photos/50/50/?image=52", "Deserunt doloremque ut quo mollitia iusto fugiat qui aut sit sapiente adipisci ex minus nam modi eius sapiente omnis aliquid.", 464735430, 214, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), "Graham - Grimes", "calculate infomediaries Frozen" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ian Wisozk", "voluptas", "https://picsum.photos/50/50/?image=682", "Molestias quia omnis minima aut ipsum voluptatem facilis sed deserunt vel tempora cupiditate ut quia commodi nihil quia nulla aliquid.", 987456834, 650, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), "Bogisich - Wolff", "firewall killer Turnpike" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jayne Nienow", "omnis", "https://picsum.photos/50/50/?image=993", "Consectetur voluptatem autem qui minus vel ipsum aliquam repellat sint est alias rerum velit quia tenetur quam repellendus tempore possimus.", 184673319, 129, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), "Reichert LLC", "Island Future Land" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Meredith Heidenreich", "quia", "https://picsum.photos/50/50/?image=264", "Voluptatem rerum velit sed maiores rerum aut veniam repellendus aut in facere culpa aliquid ut nam molestias commodi est quidem.", 333902878, 318, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), "Ryan Inc", "superstructure Group Concrete" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sammie Dach", "et", "https://picsum.photos/50/50/?image=1026", "Et aut non rem explicabo ratione exercitationem mollitia maxime voluptates et aut beatae dolorum cum in iusto et ducimus nihil.", 218501139, 641, new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), "Durgan, Stokes and King", "Handmade client-driven Savings Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rose Kub", "quod", "https://picsum.photos/50/50/?image=379", "Sed eum pariatur minus explicabo maiores non eum dignissimos eius molestiae facilis ducimus consequatur odit est possimus qui ea non.", 534815811, 450, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "O'Conner, Gusikowski and Cremin", "Grocery, Sports & Clothing bypassing Chief" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Luisa Feest", "iusto", "https://picsum.photos/50/50/?image=614", "Voluptates eum totam voluptatibus non omnis quia repellat magni vel ut voluptatem sit rerum expedita est necessitatibus dignissimos modi in.", 330524164, 644, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "Braun - Jerde", "envisioneer Mississippi systemic" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Giles Shields", "corrupti", "https://picsum.photos/50/50/?image=900", "Magnam consequuntur suscipit non incidunt unde corrupti velit voluptatibus facere delectus facere voluptatibus molestias ad quos officia quibusdam tempora at.", 644586473, 434, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "Schiller - Batz", "interface Infrastructure Rue" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Clifton Wilderman", "aut", "https://picsum.photos/50/50/?image=252", "Maxime autem perferendis temporibus rerum non fuga aliquam fuga veniam omnis voluptatibus asperiores ullam voluptate ab accusantium sed quos eos.", 666294381, 98, new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Schmidt Group", "Pennsylvania tan compressing" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Maria Labadie", "quisquam", "https://picsum.photos/50/50/?image=994", "Amet dolores libero facilis quis quo veritatis est sit deleniti sit ratione repellendus nesciunt laboriosam est dolorum iure quod a.", 579623285, 125, new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "Kuhn LLC", "infomediaries Home Loan Account Small Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Myrtie McKenzie", "soluta", "https://picsum.photos/50/50/?image=853", "Provident dolores ut soluta tenetur sed vel quos voluptas ut explicabo cum sint corrupti aut eum sed harum sed doloremque.", 448895106, 168, new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Local), "Nicolas Inc", "encryption Prairie cross-platform" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Philip McGlynn", "quo", "https://picsum.photos/50/50/?image=403", "Enim rem ut debitis aut et aut ut recusandae provident et ut est at est est quidem voluptatum aliquid non.", 494114575, 460, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), "Cormier - Zemlak", "Utah reciprocal Research" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Demetrius Weimann", "rerum", "https://picsum.photos/50/50/?image=796", "Totam id animi quasi cum praesentium vero quis distinctio beatae tenetur consequatur laboriosam iste vel adipisci et cum cumque laboriosam.", 226842779, 963, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "Schamberger Inc", "Courts static alarm" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Arvilla Tromp", "aut", "https://picsum.photos/50/50/?image=621", "Omnis molestiae dolores laudantium delectus similique consequatur quaerat dolores architecto non delectus sed debitis autem consequatur qui aspernatur aut et.", 517229614, 871, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), "Greenfelder, Prosacco and Heller", "Utah customized Belize Dollar" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "May Jacobi", "hic", "https://picsum.photos/50/50/?image=899", "Ratione sequi eos ratione quae qui voluptas ex dolor ut sint repellendus earum cum et et quia omnis consectetur quod.", 296538957, 376, new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), "Jast - Miller", "integrate Garden & Health Grocery, Jewelery & Shoes" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Magdalen Gerhold", "veritatis", "https://picsum.photos/50/50/?image=733", "Rem iure neque quidem eos quo aut facilis quod nesciunt voluptates temporibus sapiente ad natus non nesciunt voluptatibus quo rerum.", 284020309, 716, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Local), "Nolan Group", "Regional Incredible Soft Chips object-oriented" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "AUTHOR", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Royal Dietrich", "https://picsum.photos/50/50/?image=14", "Vel quia eum et ea eum voluptatem enim aspernatur est mollitia quis ut id ad similique esse quo recusandae explicabo.", 757066939, 789, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "O'Keefe - Ankunding", "Granite Mobility interfaces" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dayna Buckridge", "omnis", "https://picsum.photos/50/50/?image=274", "Maxime ex distinctio eos magni et quisquam omnis nostrum nulla est optio aut sit et vel similique rerum nostrum incidunt.", 277667559, 123, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "Hackett Inc", "AI Credit Card Account hacking" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rosalyn Prosacco", "praesentium", "https://picsum.photos/50/50/?image=1051", "Voluptatum aliquid atque distinctio beatae non optio repellat itaque accusantium delectus fugiat eos neque dolor quas numquam temporibus dolor maxime.", 955494434, 291, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Kreiger - Kreiger", "France Group Refined" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sim Zemlak", "tenetur", "https://picsum.photos/50/50/?image=600", "Nihil rerum libero quaerat illo cum blanditiis explicabo nostrum quos qui suscipit molestiae pariatur eligendi maxime dicta illo hic repudiandae.", 199137979, 910, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Local), "Collier, Stiedemann and Marvin", "Island dynamic green" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Brenden Schuster", "eveniet", "https://picsum.photos/50/50/?image=324", "Velit in sit a harum enim ut magni velit enim qui optio iusto quam et excepturi aut iure animi sint.", 816890063, 571, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), "Lindgren - Ward", "open-source Beauty JSON" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rodger Zieme", "facilis", "https://picsum.photos/50/50/?image=987", "Doloremque dolorem velit sint fugiat quas praesentium pariatur saepe accusamus repudiandae officia temporibus aspernatur quas culpa dolorum qui maxime consequatur.", 143632190, 659, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), "Ankunding Group", "monitor green navigate" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mya Kassulke", "eos", "https://picsum.photos/50/50/?image=265", "Et aperiam voluptas perferendis consequatur et tenetur repudiandae itaque placeat eum et at veritatis eos sint consequatur consequuntur debitis sit.", 810216456, 274, new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "Pollich, Gutmann and Barrows", "Planner Health & Computers Bouvet Island (Bouvetoya)" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Madaline Romaguera", "magni", "https://picsum.photos/50/50/?image=302", "Accusamus incidunt quia vel rerum quidem at quae dolores officia alias tempore nesciunt consequatur explicabo provident maxime voluptatem deserunt soluta.", 782745621, 827, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Schowalter - Lehner", "Surinam Dollar connecting RSS" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Janick Brown", "quibusdam", "https://picsum.photos/50/50/?image=537", "Tempora ut est totam quisquam nihil deleniti et ullam provident et minus fugit odio impedit aut possimus possimus minima temporibus.", 573708375, 937, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "Will - Zboncak", "Village aggregate Coordinator" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Chanelle Haag", "soluta", "https://picsum.photos/50/50/?image=399", "Occaecati qui fugit consequatur enim eveniet nam voluptas in atque amet iure veniam aut quis sit repellendus animi enim aut.", 519569482, 577, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), "Labadie - Hansen", "parse Multi-tiered functionalities" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Aimee Pacocha", "eius", "https://picsum.photos/50/50/?image=618", "Adipisci aut ut quisquam rerum ut vitae praesentium consectetur dolore voluptas rerum excepturi iusto nostrum voluptas amet consequatur sint odio.", 595563017, 873, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), "Goyette - Runolfsdottir", "Checking Account Intelligent Frozen Cheese monitor" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ron Wolf", "beatae", "https://picsum.photos/50/50/?image=337", "Recusandae eum cupiditate quidem dignissimos ipsum porro quia minus quidem suscipit optio in alias consectetur nostrum dignissimos qui et ut.", 630970495, 750, new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), "Schaden, Leffler and Paucek", "Kuwait incubate Bolivia" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Edison Lindgren", "eius", "https://picsum.photos/50/50/?image=1007", "Facilis porro sit aut molestiae nihil magnam ut ullam labore nam animi ea perspiciatis et quam molestias doloremque repudiandae sunt.", 378412378, 876, new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Local), "Roberts Inc", "Central engage bypass" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Arthur Lakin", "et", "https://picsum.photos/50/50/?image=989", "Nihil tenetur quo qui autem architecto voluptatem aut itaque cumque ad maiores et ut amet repellendus delectus error facere cupiditate.", 545911813, 394, new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "Murazik - Connelly", "Awesome web-enabled monetize" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jarrod Botsford", "voluptatem", "https://picsum.photos/50/50/?image=691", "Consequuntur fugit quisquam et officiis necessitatibus quod inventore molestiae ut minima dolorum assumenda et et rerum eius est dolorem tempore.", 395169364, 746, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), "Kuhn, Leuschke and Nienow", "seize client-driven SMTP" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Treva Emard", "consequuntur", "https://picsum.photos/50/50/?image=952", "Neque sed corporis velit dolore quas earum similique dolor dicta velit quis harum minima velit quidem qui aut odio dolores.", 880662422, 322, new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Local), "Ratke - Huels", "AGP Small Cotton Chips Awesome" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lucas Mitchell", "iure", "https://picsum.photos/50/50/?image=284", "Quas eum sint voluptatibus nisi sed dolor corporis nihil dicta voluptatem molestiae voluptate delectus amet magni praesentium fuga ea enim.", 681788852, 458, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), "Mann, Kuhn and Tremblay", "XSS parallelism New Caledonia" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mitchell Vandervort", "consectetur", "https://picsum.photos/50/50/?image=212", "In non dicta dolores aliquam asperiores omnis est nam doloremque et ipsam a enim magni occaecati nulla eum inventore occaecati.", 401590970, 110, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), "Thompson - Kuphal", "Mandatory quantifying bottom-line" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Clair Donnelly", "ullam", "https://picsum.photos/50/50/?image=524", "Expedita est qui labore non cupiditate voluptatem numquam voluptatem praesentium voluptatem dolores recusandae dolores minima hic aut dolores et accusamus.", 255018820, 491, new DateTime(2024, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), "Cummings Inc", "New Israeli Sheqel olive Analyst" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alexandro Welch", "ut", "https://picsum.photos/50/50/?image=655", "Veritatis consectetur animi et perspiciatis explicabo qui est a nostrum ducimus mollitia ratione et non assumenda odit reprehenderit rerum unde.", 356697747, 112, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Local), "Jakubowski, Marvin and McLaughlin", "Sri Lanka Rupee Fantastic Wooden Shoes incremental" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jerrod Jast", "provident", "https://picsum.photos/50/50/?image=530", "Commodi assumenda porro aliquid cumque asperiores voluptatem architecto eos voluptatem numquam et et quia vitae harum impedit iste dolorum est.", 424901638, 278, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), "Kris and Sons", "Human communities silver" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Julie Hegmann", "ut", "https://picsum.photos/50/50/?image=937", "Rerum minus in eveniet necessitatibus ut sed optio quasi placeat et in hic molestiae voluptas praesentium sed dolorum quibusdam facilis.", 741816976, 470, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), "Rohan - Yost", "Home Loan Account quantify Investment Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Amos Hodkiewicz", "voluptas", "https://picsum.photos/50/50/?image=277", "Sit dolorem sit necessitatibus facilis animi quasi vero vitae ex et sit ullam eos repellat quia recusandae qui nulla qui.", 747318060, 185, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), "Halvorson Inc", "National calculating Solomon Islands" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Maeve Bins", "aut", "https://picsum.photos/50/50/?image=687", "Vel consectetur ea architecto in consequatur modi nemo nulla maiores tempora quia ut ipsa earum error voluptas quisquam inventore enim.", 243065495, 945, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "Stracke, Labadie and Bechtelar", "Handmade Fresh Soap projection copying" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Price Rohan", "maxime", "https://picsum.photos/50/50/?image=668", "Quia voluptate similique perspiciatis libero praesentium quia quas et consequatur voluptatem impedit voluptatum rerum excepturi sed eius consectetur at ad.", 195605755, 989, new DateTime(2024, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), "Rogahn, Ziemann and Fay", "well-modulated extend Analyst" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Melany Padberg", "saepe", "https://picsum.photos/50/50/?image=687", "Rerum ducimus ut sit repellat non consequuntur non possimus aut officia quia voluptas cumque quia quam facere eveniet et omnis.", 122213458, 327, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "Watsica, Hamill and Kassulke", "gold Savings Account schemas" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Vita Jaskolski", "laboriosam", "https://picsum.photos/50/50/?image=623", "Aperiam aspernatur tempora ut doloremque nesciunt velit et ab ea deleniti commodi veniam et eius quos hic consequatur rerum sed.", 880634414, 155, new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), "Dare - Hegmann", "Licensed Buckinghamshire Plastic" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sheldon Medhurst", "ut", "https://picsum.photos/50/50/?image=494", "Nisi ab vero dolor soluta et debitis quam eum illum odio mollitia nisi iure amet velit dolore tempora recusandae quo.", 223890778, 146, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "Bergnaum LLC", "quantifying 4th generation Personal Loan Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Emilio Lesch", "reprehenderit", "https://picsum.photos/50/50/?image=63", "Et eos distinctio doloremque molestiae accusamus cupiditate nulla quidem commodi quo architecto voluptas voluptate harum omnis quia ducimus voluptas aliquam.", 817876164, 437, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "Franecki and Sons", "Hawaii XML radical" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Coy Abbott", "sit", "https://picsum.photos/50/50/?image=112", "Nam necessitatibus et et assumenda modi enim impedit blanditiis dignissimos ut molestias eum id fugit quas error ipsum totam eos.", 726259145, 826, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "Strosin - Considine", "Lead Down-sized Internal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Javon Beer", "maxime", "https://picsum.photos/50/50/?image=808", "Quaerat id voluptatem cum sunt soluta perspiciatis officia ea nihil quisquam dolorem doloremque minima vel sed maiores totam impedit commodi.", 266029729, 478, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Kuhlman Inc", "silver Computers, Baby & Beauty networks" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Allan Wintheiser", "dignissimos", "https://picsum.photos/50/50/?image=1031", "Omnis corporis eveniet saepe ut facilis officiis quae repudiandae quia eos impedit vel deserunt adipisci qui ullam qui quam eligendi.", 851319794, 416, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Local), "Gerhold - Cremin", "Compatible deploy European Unit of Account 17(E.U.A.-17)" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jeromy Barrows", "et", "https://picsum.photos/50/50/?image=525", "Veritatis rerum excepturi cupiditate autem nobis quasi eligendi officiis dolore vel nostrum eos dolores reprehenderit voluptatem laboriosam aperiam laudantium ex.", 227133854, 940, new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), "Becker - Borer", "next-generation Officer Fresh" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Gail Brakus", "aut", "https://picsum.photos/50/50/?image=452", "Dolorem odio est explicabo quibusdam quos sunt a veritatis quis nihil officia dolores illum repudiandae delectus distinctio consequatur magni sint.", 372206607, 720, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "Hahn LLC", "Optimization Credit Card Account system engine" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Estella Lesch", "aut", "https://picsum.photos/50/50/?image=914", "Tempora voluptatem dicta iure ea aperiam nulla numquam velit dicta molestiae accusantium ea quia rerum dolorem aut qui rem repudiandae.", 998758096, 749, new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), "Heller, Crist and Haley", "RSS Refined Cotton Ball Steel" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "AUTHOR", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jamir Mertz", "https://picsum.photos/50/50/?image=611", "Qui atque voluptate consequatur aut sit ab temporibus quo culpa minus quasi saepe deleniti sed unde unde expedita est vitae.", 640770888, 768, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "Wolf, Schuppe and Terry", "Kina focus group Personal Loan Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kevin Nitzsche", "nihil", "https://picsum.photos/50/50/?image=924", "Quaerat explicabo id magnam id sint quia sequi et ex nobis ut tempora ut sit aut libero aperiam est pariatur.", 213056899, 308, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), "Robel, Welch and Russel", "Baby cutting-edge Awesome" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ashleigh Rice", "nulla", "https://picsum.photos/50/50/?image=277", "Mollitia omnis et facilis accusamus mollitia cupiditate suscipit accusamus maxime optio autem veniam officia doloribus recusandae beatae qui iste sit.", 581973747, 144, new DateTime(2023, 11, 24, 0, 0, 0, 0, DateTimeKind.Local), "Bauch Inc", "auxiliary Music Ferry" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Fay DuBuque", "ut", "https://picsum.photos/50/50/?image=538", "Maxime unde voluptatem culpa est unde temporibus illo sit perspiciatis et velit velit quibusdam sit voluptatem nisi dolor omnis quas.", 837777195, 418, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), "Watsica, Cummerata and Fay", "microchip New York Fantastic Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Nyasia McClure", "similique", "https://picsum.photos/50/50/?image=305", "Quibusdam quam est esse fugiat et animi veniam cumque illum qui et enim omnis aliquid eveniet voluptas totam aut dignissimos.", 618020891, 444, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), "Sporer - Smith", "input Unions payment" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Angelo Cruickshank", "nisi", "https://picsum.photos/50/50/?image=992", "Commodi ab quis numquam et maxime est ea repudiandae reiciendis quia ut dolores commodi earum et voluptas corrupti non asperiores.", 684950801, 746, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "Bogan, Sawayn and Ratke", "Fresh Synergistic program" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Georgette Harris", "quis", "https://picsum.photos/50/50/?image=873", "Eos reiciendis nobis tenetur voluptates sequi veniam aut nihil nostrum accusantium et rem et omnis quaerat dignissimos voluptatum ex tenetur.", 308250414, 625, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "Bayer - Grimes", "Rubber Shoal North Carolina" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Aaliyah Kutch", "nam", "https://picsum.photos/50/50/?image=532", "Voluptatem debitis qui est sed odit rem atque unde commodi modi dolorem occaecati sit alias velit voluptatem ipsa quidem laboriosam.", 529367694, 242, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), "Flatley - Sporer", "Wooden transition Throughway" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Bell Rippin", "sit", "https://picsum.photos/50/50/?image=307", "Quis dicta fugit est ea exercitationem optio magnam nemo animi unde repellat hic dicta nam totam debitis ut laudantium aliquid.", 718403275, 934, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "Rodriguez and Sons", "fuchsia Regional Cambridgeshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jeffrey Purdy", "excepturi", "https://picsum.photos/50/50/?image=108", "Similique omnis laudantium libero sint excepturi non vero eum fugit iure qui cupiditate inventore tempora placeat itaque rem eos dolorem.", 637885396, 515, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Local), "Mertz, Considine and Hills", "generating Data Drive" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Salma Treutel", "veritatis", "https://picsum.photos/50/50/?image=300", "Qui aut corporis rerum voluptatem officia consequatur occaecati et fuga laborum earum aut ut eaque cum atque ut dolores quidem.", 875980996, 767, new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), "Mertz - Nitzsche", "ADP didactic Tasty Steel Towels" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Reinhold Reynolds", "asperiores", "https://picsum.photos/50/50/?image=909", "Ut quis sed aut libero a eos saepe consequatur nulla quo eos magnam voluptatem sit et veniam ipsum corporis reprehenderit.", 999150930, 269, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), "Reichert - Flatley", "Nakfa hack Intelligent Cotton Mouse" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sean Zboncak", "molestias", "https://picsum.photos/50/50/?image=63", "Quo velit repellendus id mollitia rerum aperiam iusto sit nisi saepe est labore et quidem harum ut natus ab voluptatem.", 288829798, 142, new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), "Beer - Jerde", "firewall cutting-edge back-end" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kaleigh Mills", "id", "https://picsum.photos/50/50/?image=948", "Qui inventore aut debitis ad occaecati in deserunt sit nobis quia repellat voluptates tenetur nam ratione eaque dolores pariatur error.", 302353386, 151, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Local), "Zboncak, Toy and Ledner", "Awesome Rubber Chicken Diverse Ville" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Bobbie Veum", "molestias", "https://picsum.photos/50/50/?image=473", "Eum magnam saepe sint et sed fugiat distinctio quae quia illum eos explicabo doloremque incidunt ea excepturi nemo est voluptatibus.", 226104486, 602, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "VonRueden and Sons", "wireless Small Tala" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lynn Hammes", "ut", "https://picsum.photos/50/50/?image=946", "Iure omnis et rem eos asperiores libero ut sit est expedita rerum consequatur iste qui iste non dolorem dolor quas.", 240101214, 891, new DateTime(2024, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), "Abshire - Gutmann", "International Automotive, Health & Games deposit" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jamison Walter", "iusto", "https://picsum.photos/50/50/?image=375", "Ut iure sint voluptatem doloribus sed velit tempore voluptatem tempore illum consectetur reprehenderit adipisci iusto voluptas est cum reprehenderit quos.", 488836942, 496, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "Walsh and Sons", "Maldives upward-trending reinvent" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alana Hettinger", "rerum", "https://picsum.photos/50/50/?image=777", "Non consequatur velit a sequi eos ut molestias et vel qui non possimus aperiam aut qui sint est odio libero.", 401155886, 370, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), "Kerluke LLC", "Investment Account Movies orange" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hettie Ruecker", "recusandae", "https://picsum.photos/50/50/?image=847", "Assumenda blanditiis totam fugit nihil quos aut quod est recusandae dolores ex ipsum delectus soluta voluptatem maiores et hic praesentium.", 711944708, 604, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), "Reinger - Wolff", "portals bluetooth Nebraska" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alexandria Lockman", "sunt", "https://picsum.photos/50/50/?image=214", "Omnis quia nemo aliquam quasi qui corporis animi ea dolore velit qui quia ut odit nisi amet a modi quisquam.", 606474207, 586, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "Pfannerstill, Kozey and Rolfson", "Buckinghamshire web-enabled Buckinghamshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Margaretta Flatley", "quaerat", "https://picsum.photos/50/50/?image=313", "Voluptates enim neque atque libero fugit qui laudantium cupiditate rerum odit explicabo similique voluptatem neque doloribus cum occaecati aut tenetur.", 533030625, 261, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Hessel, Crist and MacGyver", "withdrawal bandwidth Belarus" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Nikolas Dibbert", "beatae", "https://picsum.photos/50/50/?image=130", "Natus minus at cupiditate nihil sint omnis voluptatem repudiandae ut delectus architecto consequatur et ut tenetur quo et harum nisi.", 498414962, 234, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), "Aufderhar - Fay", "synergies SCSI e-tailers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Annamarie Abshire", "non", "https://picsum.photos/50/50/?image=842", "Officiis sunt dolorum voluptatibus voluptatem repellat et explicabo possimus commodi eum aut ad excepturi sit sunt quia fugit voluptatem at.", 865961591, 493, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), "Greenfelder - Steuber", "multi-byte Developer Intelligent Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Viviane Bruen", "nisi", "https://picsum.photos/50/50/?image=887", "Rerum et possimus corporis cum voluptatem ratione ducimus est voluptatum fuga aut quisquam sit deserunt quia aut aut ullam quo.", 126119447, 456, new DateTime(2023, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), "Bergstrom Group", "Savings Account Wooden Generic" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jorge Fahey", "ut", "https://picsum.photos/50/50/?image=298", "Maiores consequatur fugiat id sunt voluptatem quis veritatis natus dolor quia in aut hic ipsum rerum et non et ut.", 719499635, 950, new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "Wolff - Osinski", "Liaison Unbranded Granite Tuna Unbranded" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kian Kozey", "nihil", "https://picsum.photos/50/50/?image=58", "Sit est aliquid alias quae aut id ab dolor nesciunt velit sunt ipsa minima fugit error aut autem repellendus distinctio.", 947617071, 712, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), "Okuneva, Koepp and Schamberger", "New Mexico Markets backing up" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Golda Wiza", "cumque", "https://picsum.photos/50/50/?image=446", "A laborum harum consectetur alias beatae autem blanditiis accusamus voluptatem maxime saepe qui velit amet voluptates neque et minima dolorum.", 247573154, 296, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Local), "Walter and Sons", "Web Strategist neural-net" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jessie Hilll", "quia", "https://picsum.photos/50/50/?image=60", "Corrupti dolorum harum atque aspernatur et cumque velit nulla deserunt aspernatur sed tempore maiores quas quas iusto sunt aliquid laudantium.", 892515306, 59, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "Rohan Group", "Hawaii International Steel" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Stefan Dibbert", "quidem", "https://picsum.photos/50/50/?image=922", "Qui inventore qui est optio aut voluptatibus molestias voluptatibus sint perferendis ipsum reiciendis consectetur impedit ratione qui voluptatem et praesentium.", 539583066, 728, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), "Zemlak, Konopelski and Waelchi", "CSS Multi-layered Argentine Peso" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Cameron Feest", "quaerat", "https://picsum.photos/50/50/?image=698", "Delectus exercitationem nisi amet eveniet ut eum ipsum reiciendis et voluptas quos magnam quia libero a cum rerum voluptatem debitis.", 772770043, 76, new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), "Larson LLC", "Generic Steel Chair Self-enabling Handmade Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Derrick Conn", "harum", "https://picsum.photos/50/50/?image=759", "Dicta quasi officia et voluptas amet similique dolorem rerum voluptatem ea quisquam ex voluptatibus dolorum natus et soluta delectus dolor.", 557029111, 980, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "Jakubowski Group", "Massachusetts red Checking Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lelia Welch", "dolor", "https://picsum.photos/50/50/?image=393", "Et voluptates corrupti libero ut eius voluptatem dolorem et natus sed soluta dolor enim non quo nostrum sit quia eaque.", 329114307, 493, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), "Predovic LLC", "Berkshire orchid monitor" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ethelyn McDermott", "ducimus", "https://picsum.photos/50/50/?image=1010", "Ut fugiat optio esse velit natus quo nulla qui ea ut repellat error quia illo facilis assumenda quibusdam iste perferendis.", 888895289, 413, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), "Gislason Group", "Money Market Account blockchains Digitized" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ashleigh Bailey", "aut", "https://picsum.photos/50/50/?image=537", "Molestias laborum placeat earum enim vel blanditiis nihil fugit vel eos esse dolores ipsa quis pariatur laboriosam qui ea at.", 675077053, 180, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), "Rosenbaum - Renner", "Eritrea open-source bandwidth" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mabel Adams", "voluptas", "https://picsum.photos/50/50/?image=189", "Rerum provident incidunt officiis tempore sed aliquam debitis nulla id vel fugit inventore eveniet beatae ratione sed nemo adipisci expedita.", 734827750, 394, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Local), "Ondricka, Mraz and Heidenreich", "applications 6th generation Configuration" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Amalia Stamm", "sunt", "https://picsum.photos/50/50/?image=356", "Et perferendis officia corrupti iste vel consequatur provident alias quo amet assumenda magni nihil molestias distinctio laborum consequatur perferendis quia.", 375730775, 486, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), "Morissette, Koelpin and Carter", "TCP input Swaziland" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Tito Moore", "et", "https://picsum.photos/50/50/?image=961", "Consectetur dignissimos at nobis iste ab commodi velit non tenetur perspiciatis tempore illo cum voluptatem autem deleniti ut labore quis.", 309037554, 343, new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), "Bernhard - Altenwerth", "Awesome 1080p pixel" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Carmelo Schroeder", "dignissimos", "https://picsum.photos/50/50/?image=1017", "Sapiente maxime deleniti consequatur recusandae laudantium necessitatibus maxime nam delectus aut explicabo quo quo vel explicabo ea consequatur et sequi.", 628770958, 83, new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "White, Spinka and Hodkiewicz", "Ergonomic Principal Borders" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Shannon Gislason", "quo", "https://picsum.photos/50/50/?image=513", "Est omnis rem animi hic laboriosam optio repellendus vel quidem molestiae iusto nostrum quia animi quis accusamus autem aspernatur qui.", 508022041, 641, new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Local), "Langosh, O'Kon and Streich", "sky blue hack Architect" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Emelia Gleason", "quasi", "https://picsum.photos/50/50/?image=220", "Corrupti et provident quidem consequatur sapiente dolorem earum non rerum repudiandae doloremque et ullam qui iusto et sed et quaerat.", 124461513, 285, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), "Runolfsdottir - Champlin", "mesh Unbranded Frozen Fish Berkshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ryann Considine", "voluptas", "https://picsum.photos/50/50/?image=70", "Et et dolores et consequuntur voluptas at eveniet sint unde hic facilis numquam qui autem vel quae quis aut ex.", 445667150, 935, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "Raynor - Hand", "Oklahoma Idaho green" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Bailee Legros", "veritatis", "https://picsum.photos/50/50/?image=524", "Laboriosam et non sunt et quis voluptas repudiandae et aut velit non et fuga aliquam eum quis harum totam at.", 208651134, 957, new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), "Rosenbaum, Dibbert and Towne", "withdrawal bandwidth-monitored Dong" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Daniella Gutkowski", "sit", "https://picsum.photos/50/50/?image=501", "Repellendus libero qui quia ut consectetur beatae ipsa magnam maiores ut praesentium quod qui veritatis officiis quia harum dolorem repudiandae.", 558059465, 91, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "Gaylord - Moen", "productize pricing structure Island" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Evangeline Lemke", "architecto", "https://picsum.photos/50/50/?image=810", "Qui velit velit deleniti sequi nulla consequatur fugit nesciunt voluptates laborum autem placeat corporis quia dolorem libero debitis est quae.", 699140167, 193, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Local), "Halvorson LLC", "National Architect Ohio" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Adriana Klein", "facilis", "https://picsum.photos/50/50/?image=77", "Dolores voluptates blanditiis reiciendis vitae vero et animi harum deserunt eaque molestiae ipsam architecto et in voluptate eligendi cupiditate soluta.", 930105116, 659, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "Lemke Inc", "Auto Loan Account AGP responsive" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Avis Swift", "quae", "https://picsum.photos/50/50/?image=215", "Soluta quia impedit ut aut accusamus et occaecati facere quia alias nihil est perferendis voluptatum dolore maiores iste deleniti veritatis.", 916930372, 114, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), "Lowe, Farrell and Sauer", "incubate invoice granular" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Daisha Schowalter", "in", "https://picsum.photos/50/50/?image=1071", "Qui repudiandae iusto fugit dolores non assumenda id iusto sit et neque voluptas et cupiditate consequatur a incidunt ipsam voluptate.", 413259557, 347, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "McDermott Group", "neural Checking Account Tasty" });

            migrationBuilder.CreateIndex(
                name: "IX_Books_CHECKED_OUT_BY",
                table: "Books",
                column: "CHECKED_OUT_BY");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_UserAccounts_CHECKED_OUT_BY",
                table: "Books",
                column: "CHECKED_OUT_BY",
                principalTable: "UserAccounts",
                principalColumn: "ID",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
