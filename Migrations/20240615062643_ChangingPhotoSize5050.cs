using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechnicalAssessmentRokov.Migrations
{
    /// <inheritdoc />
    public partial class ChangingPhotoSize5050 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Francesco Koch", "sequi", "https://picsum.photos/50/50/?image=552", "Dolores rem accusamus architecto hic molestiae ut ex et minus quis et et doloremque exercitationem sed rerum deserunt sequi suscipit.", 805102479, 711, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), "Willms, Cummings and Braun", "withdrawal Creative Cambridgeshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Vincent Miller", "laborum", "https://picsum.photos/50/50/?image=131", "Eum aut omnis accusantium voluptates enim officia rerum omnis quo vel sit est nulla tempore odit et dignissimos vero aliquid.", 272028493, 347, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), "Kiehn and Sons", "withdrawal Bulgarian Lev Music" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Tia Hyatt", "aspernatur", "https://picsum.photos/50/50/?image=987", "Modi officia quis libero aut nisi culpa est quia dolore autem consequatur dicta qui optio nostrum incidunt unde tempore illum.", 228854494, 417, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), "Funk - Mohr", "adapter Parkways Tasty Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Vernon Murray", "ducimus", "https://picsum.photos/50/50/?image=23", "Voluptate architecto sint modi earum saepe ratione iure est labore quia blanditiis voluptatem deserunt aperiam tempora velit aut dolorem in.", 517404011, 259, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), "Bauch, Schoen and Hand", "well-modulated FTP JBOD" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Murphy Dietrich", "nemo", "https://picsum.photos/50/50/?image=486", "Ut pariatur consequatur consequatur laborum dolorem omnis magni soluta doloribus facere quae totam omnis accusamus veritatis enim fuga laboriosam ea.", 174974112, 324, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), "Haag - Stiedemann", "Bedfordshire Secured Checking Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Tyrese Von", "facere", "https://picsum.photos/50/50/?image=851", "Quos eveniet reiciendis autem optio ex exercitationem aut deserunt et voluptatum vel enim rerum pariatur eos omnis a illo modi.", 398541406, 676, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "Gislason Group", "Fresh Haven out-of-the-box" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hardy Altenwerth", "sit", "https://picsum.photos/50/50/?image=1050", "Blanditiis numquam sit ut nisi numquam molestiae debitis laudantium consequatur blanditiis modi corporis qui sit fugit deleniti rerum earum repellat.", 828162371, 638, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), "Miller LLC", "Books, Kids & Computers card Manat" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Franz Mohr", "doloribus", "https://picsum.photos/50/50/?image=667", "Rerum consectetur quos rem reprehenderit nam sunt sunt quidem ut autem id quo rerum vero nesciunt dicta perferendis modi cumque.", 580806137, 204, new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Local), "Emmerich, Douglas and Hand", "fault-tolerant invoice Buckinghamshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Don Ullrich", "omnis", "https://picsum.photos/50/50/?image=752", "Doloribus dolor ut sunt dolor laudantium sunt molestias similique ut adipisci odit facilis voluptas repudiandae consequatur dolorum dolorum sint placeat.", 571209478, 264, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), "Williamson - Hegmann", "visionary Kenyan Shilling EXE" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mayra Powlowski", "sed", "https://picsum.photos/50/50/?image=417", "Quisquam odio ducimus ducimus quis aspernatur architecto ipsum qui voluptatem eveniet et minima rem maiores a quisquam voluptatem aliquam accusantium.", 233225757, 750, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Rosenbaum, Douglas and Waters", "Unbranded programming Uzbekistan Sum" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jennings Macejkovic", "quae", "https://picsum.photos/50/50/?image=1012", "Id velit sunt deleniti molestiae ab nam omnis explicabo iure molestias laudantium aut et aliquid sed laboriosam ducimus nihil incidunt.", 916885146, 509, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), "DuBuque - Harber", "New York Money Market Account AI" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Larue Hilll", "quaerat", "https://picsum.photos/50/50/?image=563", "Delectus consectetur impedit voluptatibus minus voluptatem quo ut quas necessitatibus ut fugit qui nisi ipsa accusamus non dignissimos labore aut.", 763839340, 727, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "Schowalter Group", "bricks-and-clicks e-enable Metal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Khalid Funk", "molestiae", "https://picsum.photos/50/50/?image=449", "Facere temporibus rem optio qui praesentium et iure odio praesentium rem optio et et modi tenetur dicta qui est eius.", 373267719, 919, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "Ratke - Abernathy", "Sri Lanka Rupee optimize input" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Eriberto Ortiz", "perferendis", "https://picsum.photos/50/50/?image=220", "Eum voluptatem amet et a eaque at nobis sed vero et temporibus consequatur earum in molestias corrupti qui eos autem.", 751333764, 690, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "Reilly Inc", "Avon Supervisor Isle" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Bernard Strosin", "a", "https://picsum.photos/50/50/?image=66", "Magni accusamus sequi quia nemo dolorem aut quia ad reiciendis velit nobis quis corrupti illum et nihil vero similique asperiores.", 579259910, 796, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Local), "Bergstrom - Crist", "Japan reciprocal collaboration" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Suzanne Graham", "beatae", "https://picsum.photos/50/50/?image=8", "Veritatis quod earum qui eos recusandae perspiciatis non qui ut et id est velit sunt consequuntur incidunt deleniti molestiae et.", 971447249, 63, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "Rath, Ledner and Friesen", "Practical Metal Chips Intranet port" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rebecca Padberg", "placeat", "https://picsum.photos/50/50/?image=511", "Reiciendis porro sunt id ab dignissimos architecto est excepturi voluptas facilis debitis non laborum sint et quia et quidem ut.", 613795195, 384, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Schoen and Sons", "HDD Holy See (Vatican City State) Sports" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Marcellus Kuhn", "odio", "https://picsum.photos/50/50/?image=224", "Nobis quia dolorem dolores molestiae veritatis ut accusamus dolores quasi numquam laboriosam distinctio alias quaerat consequuntur sunt sint dolorum debitis.", 293206881, 690, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), "Greenfelder - Runte", "Multi-lateral Future Ford" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Damaris Tromp", "a", "https://picsum.photos/50/50/?image=515", "Voluptate vel nam et ea explicabo rerum et qui voluptatem aut aut nemo quaerat facilis necessitatibus aspernatur nihil magnam inventore.", 797974447, 926, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "Feeney, Hintz and Botsford", "Brand Data withdrawal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Vidal Kunze", "eos", "https://picsum.photos/50/50/?image=1043", "Ipsum nihil debitis quod alias et occaecati dignissimos non numquam blanditiis doloremque molestias numquam repellat rem expedita omnis voluptas maxime.", 177619022, 236, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), "Kling - Spinka", "integrated Practical Concrete Table compress" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Gerson Bartoletti", "corrupti", "https://picsum.photos/50/50/?image=548", "Id officiis laudantium excepturi quibusdam sequi sit pariatur fugiat aut sequi soluta aut sed quo quia labore ad suscipit nihil.", 751745803, 348, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Local), "Lueilwitz LLC", "Investor transmit next-generation" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Tyree Rowe", "aut", "https://picsum.photos/50/50/?image=810", "Eligendi suscipit laudantium placeat ipsa hic natus autem maiores exercitationem deleniti et vel error qui dolorum est voluptatem est ea.", 455574855, 410, new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), "Koelpin, Littel and MacGyver", "Afghani reboot incremental" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Stephany Schiller", "sequi", "https://picsum.photos/50/50/?image=29", "Corrupti iste sed est unde in omnis quas enim suscipit magni ut ut et eveniet earum non aspernatur officiis hic.", 838033749, 850, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), "Hoppe - Rau", "transmitter architectures RSS" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Esmeralda Pollich", "similique", "https://picsum.photos/50/50/?image=91", "Quia cumque enim earum quisquam nihil molestiae labore perferendis ut ratione maiores ut molestiae totam odit enim odio rerum exercitationem.", 405085464, 938, new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), "McKenzie, Will and Wisoky", "Netherlands Antilles generating Lead" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Gabriella Corwin", "repellendus", "https://picsum.photos/50/50/?image=454", "Maiores ut nihil est cum incidunt dolores nemo tempora natus et pariatur nemo repellendus harum dicta temporibus recusandae qui perspiciatis.", 452647274, 509, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "Doyle - Fritsch", "Bedfordshire Analyst auxiliary" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ora Gulgowski", "aliquam", "https://picsum.photos/50/50/?image=261", "Aut aut id doloremque eos consequatur vero quo magnam placeat illo voluptate laboriosam minima ex unde magnam itaque voluptatum ipsam.", 673692148, 782, new DateTime(2023, 6, 21, 0, 0, 0, 0, DateTimeKind.Local), "Roberts, Grady and Hane", "generate Unbranded Soft Pants microchip" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Janis Fay", "cum", "https://picsum.photos/50/50/?image=697", "Atque nobis illo est est repellendus deleniti ut beatae dolorum reprehenderit dolores eos rerum ipsa eligendi consequatur rerum similique nostrum.", 398808720, 292, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "Deckow, Gislason and Schroeder", "support directional Managed" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Declan Cummerata", "facilis", "https://picsum.photos/50/50/?image=512", "Eius illo quos voluptatem consequatur commodi eligendi provident accusantium alias voluptatem ut expedita sit officiis quae pariatur ut ipsam fuga.", 455158235, 145, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), "Smith - Rath", "Singapore Dollar mobile Orchestrator" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ivory Wintheiser", "repellendus", "https://picsum.photos/50/50/?image=296", "Facilis blanditiis facilis est ducimus voluptas laboriosam molestiae enim eius magni molestiae quidem id omnis quibusdam eius quasi sit quo.", 208366746, 205, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Dickens and Sons", "AI human-resource Haven" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Macy Kshlerin", "eos", "https://picsum.photos/50/50/?image=329", "Eos minima dicta mollitia praesentium harum quod natus eum beatae expedita provident deserunt cum ut fugit dolores quidem accusantium non.", 384105863, 242, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), "Homenick, Wisozk and Bogisich", "invoice grid-enabled Lead" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Nyasia Abshire", "distinctio", "https://picsum.photos/50/50/?image=848", "Quia et sed sint aut iste vero vel iste minima perspiciatis ea maiores alias nesciunt voluptatum laboriosam voluptas veritatis deserunt.", 311176868, 356, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Block, Johns and Lebsack", "Plastic transmitting back up" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rossie Abshire", "ipsum", "https://picsum.photos/50/50/?image=877", "Dicta sint magni voluptatem dolores et quia ut rerum dignissimos aut minima quia libero nihil magnam ut voluptatibus tempore possimus.", 237805092, 461, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "Oberbrunner LLC", "Incredible Steel Bike COM Industrial, Clothing & Movies" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Nestor Bashirian", "repellat", "https://picsum.photos/50/50/?image=506", "Hic illo voluptatem sint ipsum dolore qui quam dolorem et quaerat unde fuga consequatur tenetur commodi eius animi impedit consequatur.", 748185433, 538, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), "Johnson - Green", "e-business cyan USB" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alexis Botsford", "sequi", "https://picsum.photos/50/50/?image=510", "Beatae veniam nisi rerum distinctio qui quia sapiente non quia earum et et qui assumenda dignissimos reiciendis asperiores fugiat porro.", 388880054, 944, new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Local), "Schiller Group", "withdrawal tan Security" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Brycen Rosenbaum", "aut", "https://picsum.photos/50/50/?image=805", "In perferendis consequuntur dolores et praesentium amet ullam maxime numquam eos veniam vitae veniam excepturi ad cupiditate aspernatur necessitatibus nam.", 383403765, 143, new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "Lakin - Ritchie", "quantify alarm encryption" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Demario Klein", "odit", "https://picsum.photos/50/50/?image=481", "Sint eos vel assumenda totam rerum numquam et necessitatibus blanditiis asperiores molestiae sed nesciunt dolorem ducimus commodi qui quia molestias.", 954988953, 293, new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), "Shields Group", "out-of-the-box Developer extend" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Arne Hane", "nobis", "https://picsum.photos/50/50/?image=1068", "Voluptatum repudiandae sunt cumque reprehenderit aliquid consequatur velit beatae et illum eos facere neque illum officiis recusandae harum qui hic.", 861095716, 111, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "Beer, Tremblay and Wyman", "Fantastic Cotton Cheese methodologies contextually-based" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Wilber Bradtke", "adipisci", "https://picsum.photos/50/50/?image=1065", "Nam quasi unde qui necessitatibus mollitia repudiandae culpa dolore in quo minima iure aut consequatur aut reprehenderit non non iure.", 582931949, 332, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Shields and Sons", "Hryvnia strategic Gorgeous Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Johnny Murazik", "eligendi", "https://picsum.photos/50/50/?image=956", "Provident qui sint excepturi provident temporibus quia aut illo maiores numquam adipisci aperiam perspiciatis saepe eos inventore ea est eos.", 656616885, 670, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Von Group", "Orchestrator transitional Iraq" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Tevin Schamberger", "saepe", "https://picsum.photos/50/50/?image=360", "Cupiditate fuga est consequatur provident ipsum sint sequi aut tempora perferendis ipsum eum molestiae repudiandae ut voluptatum et tempora modi.", 683922366, 62, new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), "Jerde - Olson", "Investor e-tailers Oman" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Emmet Powlowski", "pariatur", "https://picsum.photos/50/50/?image=601", "Enim sit ullam eum repudiandae libero adipisci adipisci ut consequatur cupiditate vel quis molestiae libero possimus quam sit magnam ratione.", 495941456, 463, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "Kling - McClure", "PNG Investment Account Intelligent" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mortimer Veum", "enim", "https://picsum.photos/50/50/?image=124", "Assumenda est magni ut iure doloribus dolor quia quaerat culpa autem doloremque nam reprehenderit possimus ut distinctio sit qui culpa.", 879393402, 530, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Local), "Altenwerth - Kozey", "panel generate Granite" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Quinn Adams", "aperiam", "https://picsum.photos/50/50/?image=309", "Delectus fuga quasi quas quisquam et nam non error facere quia laboriosam dolore sed voluptas ipsum sit tempore harum deserunt.", 715893772, 181, new DateTime(2023, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), "Baumbach, Parker and Green", "SQL Ways alliance" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Tremaine Murphy", "et", "https://picsum.photos/50/50/?image=867", "Maiores corrupti omnis velit quibusdam repellendus et quasi minima nesciunt et eos perspiciatis nemo incidunt non velit aperiam est ullam.", 155078104, 826, new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), "Terry Inc", "tan world-class ubiquitous" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Norval O'Kon", "velit", "https://picsum.photos/50/50/?image=181", "Amet id nesciunt laborum et nulla aut quasi ut quidem dolorem in quae eum sed doloremque aliquam similique eum aut.", 856482012, 166, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "Brown Group", "Fresh Estate Unbranded Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Anabelle Cartwright", "aliquid", "https://picsum.photos/50/50/?image=489", "Esse saepe amet eligendi qui dolores aut reiciendis ea nesciunt libero reprehenderit velit itaque odit sit laudantium libero aut eum.", 136360751, 466, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), "Ondricka and Sons", "payment generate redundant" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Helena Murphy", "iste", "https://picsum.photos/50/50/?image=824", "Quod qui enim non accusantium aut repudiandae delectus animi sit veniam perferendis aspernatur officia ipsum occaecati facere sint ea harum.", 514710215, 682, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "Wolf LLC", "invoice scale Games" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Roberto Waelchi", "non", "https://picsum.photos/50/50/?image=478", "Vitae voluptatum rem eos exercitationem ratione dolores et sed soluta sapiente facere amet dolorem et dolore quia repellendus consequatur quas.", 885665456, 961, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Little LLC", "overriding Virgin Islands, British panel" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Garry Senger", "vel", "https://picsum.photos/50/50/?image=120", "Voluptate at consectetur voluptatum itaque ad et ullam repudiandae omnis libero nisi id quia dolor beatae optio non est minus.", 493495945, 763, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "Runte Group", "Uganda Shilling Central Music & Music" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Noel Kautzer", "cupiditate", "https://picsum.photos/50/50/?image=684", "Impedit similique quia molestias hic rerum est quia ipsa quae repellat quo qui quod sapiente doloremque numquam commodi repellendus et.", 109455612, 108, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), "Mills - Bogisich", "Arkansas Generic Steel Soap maroon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Demetris Bauch", "impedit", "https://picsum.photos/50/50/?image=280", "Sint velit incidunt aspernatur et sit fuga explicabo dolore hic ut et et vel sit necessitatibus nostrum nisi labore iusto.", 632932273, 277, new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), "Gaylord, Mraz and Lindgren", "scale transform compressing" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Nona Barrows", "optio", "https://picsum.photos/50/50/?image=20", "Corporis vel ullam rem necessitatibus quo placeat ullam voluptas consequuntur voluptas dolore sit tempore earum autem officiis ut eum temporibus.", 488719969, 420, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), "Raynor, Weber and Pacocha", "Incredible Steel Keyboard Triple-buffered Sleek Fresh Keyboard" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Anne Tillman", "error", "https://picsum.photos/50/50/?image=709", "Tenetur cumque esse soluta illum ex dolores neque molestias ad sit vero ipsam ut reiciendis voluptatibus itaque et repellendus impedit.", 209913515, 356, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), "Leffler Group", "withdrawal Security microchip" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Yasmin Botsford", "et", "https://picsum.photos/50/50/?image=1020", "Amet ut est aspernatur atque autem laborum dolores quos id rem odit totam ipsum voluptatum ullam asperiores animi ut dolores.", 110701354, 371, new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Local), "Heidenreich, Dach and Fay", "port orange Kenya" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rashad Jenkins", "iure", "https://picsum.photos/50/50/?image=348", "Amet at ea corporis numquam est iure minima necessitatibus molestiae saepe aspernatur consequatur omnis voluptatum numquam facere deleniti aliquam non.", 714495643, 297, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), "Rolfson - Adams", "Fresh magnetic Island" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Santino Jacobson", "iusto", "https://picsum.photos/50/50/?image=308", "Reprehenderit sit distinctio nostrum architecto ex aut quis dolorum rerum eum pariatur tempore saepe architecto ducimus assumenda et ea nihil.", 391740420, 204, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "Blick, Medhurst and Prosacco", "Ecuador auxiliary Metrics" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Terence Daniel", "qui", "https://picsum.photos/50/50/?image=612", "Facere voluptatem cumque pariatur eius sequi non ut consequatur esse veritatis aut aut itaque unde perspiciatis modi possimus qui beatae.", 103695549, 242, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "Rolfson, Vandervort and Sipes", "back-end Garden synergistic" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Shanna Walter", "numquam", "https://picsum.photos/50/50/?image=865", "Error odio ex odio est omnis quia eos repellendus est enim labore ut vel doloribus reprehenderit sit nam quaerat labore.", 258811784, 205, new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), "Terry - Luettgen", "JBOD generate vortals" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Savanah Crooks", "facere", "https://picsum.photos/50/50/?image=676", "Commodi quaerat ea perferendis sed est aut dolorem vero aliquid voluptatem modi cumque aut beatae voluptas quibusdam enim cum minima.", 258800303, 311, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), "Hahn LLC", "AI deposit Future" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alberto Mosciski", "rerum", "https://picsum.photos/50/50/?image=252", "Distinctio debitis voluptatem omnis amet tempore totam sunt cum distinctio animi laudantium rerum sed eligendi dolore saepe error et consequatur.", 833455866, 615, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), "Hirthe - Heller", "Lodge firewall Synergistic" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lauryn Raynor", "maiores", "https://picsum.photos/50/50/?image=975", "Aliquid quia non natus ex amet sequi sit quos doloremque est aut consequuntur earum enim laudantium inventore sequi officiis aliquid.", 713202894, 780, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), "Connelly Group", "Seamless Savings Account supply-chains" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Aurelie Hackett", "rerum", "https://picsum.photos/50/50/?image=601", "Distinctio ut soluta suscipit vitae aperiam sit quia est itaque quis officia voluptatum illum quia deleniti vel assumenda illum non.", 541589828, 758, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "Dibbert, Pouros and Ruecker", "Direct invoice Florida" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Raleigh Schimmel", "velit", "https://picsum.photos/50/50/?image=840", "Soluta quod et est et ut pariatur et id odit et distinctio ut eos sit aut dicta tempora natus sed.", 493309497, 265, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "Carroll - Wisoky", "quantify Gibraltar Pound Implemented" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Peggie Oberbrunner", "molestiae", "https://picsum.photos/50/50/?image=956", "Et explicabo veritatis rerum eligendi qui aut ducimus laborum sit omnis aut cumque necessitatibus vitae dolores doloremque magni sit quia.", 416618982, 359, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "Konopelski Group", "payment Money Market Account Cliffs" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Bailey Jacobs", "eos", "https://picsum.photos/50/50/?image=167", "Libero ab cumque maiores dicta voluptas voluptas et exercitationem ipsa excepturi ut autem quaerat nulla qui laborum nemo voluptas sunt.", 878014356, 970, new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), "Hand - Walsh", "functionalities Lebanon Soft" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Gene Padberg", "quisquam", "https://picsum.photos/50/50/?image=698", "Voluptas doloremque cupiditate sequi atque ut aut quia eius itaque rerum qui dicta sed iure debitis numquam eos repellendus enim.", 241890828, 497, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), "Bednar LLC", "brand Technician Factors" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ceasar Champlin", "dolore", "https://picsum.photos/50/50/?image=590", "Animi voluptatem suscipit ea ipsum sed ea odit debitis eligendi reiciendis nam laboriosam ipsam saepe asperiores nihil laudantium nihil et.", 659573345, 905, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), "Grimes and Sons", "Games Fresh Summit" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Tyrel Mitchell", "repellat", "https://picsum.photos/50/50/?image=912", "Totam eum adipisci dolor ipsa natus nam eos alias eveniet ipsa facere maiores ipsum aut ut enim aperiam molestias neque.", 894000876, 276, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), "Kling, Kris and Bergstrom", "Lesotho Loti emulation blue" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Laurie Littel", "ab", "https://picsum.photos/50/50/?image=785", "Facilis quidem sapiente provident quia dolores neque accusamus porro nam dolores quo et corporis est autem recusandae ex quas in.", 643967347, 789, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), "McGlynn - Mitchell", "Generic Steel Hat leverage experiences" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Darius Emmerich", "et", "https://picsum.photos/50/50/?image=1", "Nihil et provident dolor aut provident veniam sequi odio doloribus sit laborum ut rerum quisquam ducimus ut vel voluptatem natus.", 744504062, 854, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "Fahey, Wunsch and McGlynn", "Fort payment Bedfordshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Micheal Jones", "vel", "https://picsum.photos/50/50/?image=1006", "Ratione ab animi reiciendis qui facere non corrupti perspiciatis aperiam aut vel provident odio itaque hic veritatis eius impedit doloremque.", 782426868, 743, new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Local), "Zboncak LLC", "Cambridgeshire override communities" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jarvis Waelchi", "dolorem", "https://picsum.photos/50/50/?image=336", "Soluta officia voluptatem doloremque non qui fuga illum reprehenderit laudantium deserunt debitis modi numquam eum ea sed excepturi voluptas vitae.", 670817228, 990, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), "Jakubowski, Cartwright and Casper", "Ergonomic Granite Computer Auto Loan Account JSON" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lillie Gusikowski", "quidem", "https://picsum.photos/50/50/?image=14", "Et ut sunt et autem repellendus rerum architecto dignissimos quos delectus id nemo fuga aut autem quisquam aperiam autem facilis.", 913317450, 80, new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "Nikolaus Group", "Grocery, Shoes & Books relationships Liaison" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Bernita Weber", "voluptate", "https://picsum.photos/50/50/?image=265", "Aut possimus laudantium ad quaerat dolorum cum id molestiae mollitia aut animi et beatae amet alias omnis repudiandae perferendis doloribus.", 147076638, 151, new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), "Cartwright Group", "Underpass human-resource Soft" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Weldon Sanford", "aliquid", "https://picsum.photos/50/50/?image=934", "At quibusdam porro id iure unde non voluptas rerum totam ut porro voluptas voluptates sit sit perspiciatis optio ipsam perspiciatis.", 947251289, 276, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Dibbert Group", "connect Generic Practical" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Skye Torp", "dicta", "https://picsum.photos/50/50/?image=741", "Minus ad ut nulla dolor repellat minima consequatur quis dolorem quibusdam consequatur nesciunt et ut consequatur iure sed repellat nam.", 115182493, 225, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "Lockman - Sanford", "Cambridgeshire info-mediaries Belarus" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ressie Kling", "ea", "https://picsum.photos/50/50/?image=150", "Et labore molestiae dolor doloremque odio deleniti vel voluptatem omnis maiores consequuntur est rem voluptatum et amet consequatur est deleniti.", 842560532, 739, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "McKenzie and Sons", "Buckinghamshire Outdoors, Toys & Books Vista" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lemuel Swaniawski", "sed", "https://picsum.photos/50/50/?image=617", "Dolore et cum consequatur consequatur velit aliquid accusamus aut dolore et ea soluta explicabo blanditiis ut blanditiis qui ad temporibus.", 649289405, 200, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "Lebsack - Monahan", "Producer calculating invoice" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Laney Grady", "perferendis", "https://picsum.photos/50/50/?image=1052", "Dicta magnam hic voluptas ipsa minus suscipit aut eaque velit aut ea laboriosam accusamus ut corporis repudiandae omnis officiis sunt.", 831374744, 75, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), "Wunsch - Goldner", "Gorgeous Soft Sausages calculating local" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Blanche Collier", "dolorem", "https://picsum.photos/50/50/?image=644", "Vel perspiciatis nihil reiciendis eos sequi inventore reprehenderit natus voluptas labore numquam quaerat dignissimos qui quidem nisi fugiat dolorem reiciendis.", 388064223, 688, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "Olson, Hilll and Torphy", "North Dakota Qatari Rial out-of-the-box" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alexis Stroman", "sit", "https://picsum.photos/50/50/?image=477", "Qui sed molestiae mollitia qui voluptas sed ut dolorem dolor dolorem odio occaecati dolor sequi exercitationem quo est cum nihil.", 127471384, 201, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "Strosin - Cummings", "Handcrafted Lari Junction" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sid Stanton", "sequi", "https://picsum.photos/50/50/?image=616", "Et nemo asperiores aut illo totam tenetur ea neque qui corrupti ut esse autem minima cumque dolor quos quo est.", 809167909, 395, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "McClure - Harvey", "capacitor Dynamic Drive" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Nelle Schamberger", "nobis", "https://picsum.photos/50/50/?image=450", "Cum saepe ducimus aut veritatis est sed quia maiores aut molestiae est et fugiat illum aperiam ea accusamus sunt pariatur.", 899603553, 317, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Harber, Pagac and Brakus", "Plains Handmade Granite Car attitude" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jillian McClure", "voluptate", "https://picsum.photos/50/50/?image=129", "Porro ab sit unde occaecati exercitationem sit ut quas ut itaque in voluptatum ab quos labore voluptatem in ab error.", 810217803, 179, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Lebsack, Welch and Nienow", "empowering Practical Fresh Chicken Steel" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Brady Rempel", "consequuntur", "https://picsum.photos/50/50/?image=1045", "Quasi ab quibusdam hic earum sapiente non sed est minus saepe rem dolorem repudiandae facilis illo nihil assumenda officiis unde.", 217309177, 83, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), "Smith, Olson and Jones", "Tasty Checking Account cross-platform" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Chaim Gerhold", "mollitia", "https://picsum.photos/50/50/?image=677", "Voluptatibus deleniti officia autem numquam inventore aperiam quos totam qui nulla nostrum molestiae nihil accusantium in officiis fuga sit placeat.", 205428124, 677, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), "Toy - Leffler", "groupware ivory Legacy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Albert Jakubowski", "est", "https://picsum.photos/50/50/?image=1037", "Ex reiciendis error minima deleniti quis et culpa molestiae delectus odit quibusdam repudiandae rem et numquam labore ut delectus sequi.", 459517336, 503, new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), "Shanahan, Schamberger and Stanton", "Fresh withdrawal Idaho" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Florida Blanda", "magnam", "https://picsum.photos/50/50/?image=708", "Mollitia modi numquam perferendis id quam facere doloremque consequatur et eius quibusdam nisi ipsa placeat sint asperiores voluptas consequatur non.", 840236921, 232, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), "Simonis, Kozey and Bartoletti", "action-items Pa'anga Investment Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kiana Rolfson", "quod", "https://picsum.photos/50/50/?image=881", "Debitis omnis suscipit culpa accusantium reprehenderit accusantium fuga maiores et necessitatibus repudiandae quas molestiae voluptate ipsa distinctio occaecati quidem odit.", 756818428, 527, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "O'Conner and Sons", "Kina Rustic Concrete Soap Licensed Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Tatyana Goldner", "modi", "https://picsum.photos/50/50/?image=187", "Aperiam esse quibusdam quisquam enim alias id mollitia eaque quisquam quod quia et eaque id hic est eum dignissimos qui.", 812444280, 274, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "Feest and Sons", "Frozen Pitcairn Islands Egypt" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dalton Wunsch", "dolore", "https://picsum.photos/50/50/?image=851", "Deleniti eveniet rerum asperiores voluptatem omnis beatae amet sint ducimus numquam qui molestiae natus temporibus laudantium unde quibusdam temporibus fugiat.", 214772525, 354, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Mills Group", "Colombia PCI Berkshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Herminia Padberg", "facilis", "https://picsum.photos/50/50/?image=740", "In sit aut aut est ut dolore fuga ut quia est corporis mollitia inventore et laudantium hic mollitia aut debitis.", 678472836, 942, new DateTime(2023, 7, 9, 0, 0, 0, 0, DateTimeKind.Local), "Mraz - Fisher", "mindshare North Korean Won Division" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Marc Wuckert", "beatae", "https://picsum.photos/50/50/?image=427", "Et ea facilis ad laboriosam at nam reiciendis qui voluptates quis omnis quam molestiae eaque laudantium eveniet vitae veritatis quam.", 232774762, 594, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Local), "Buckridge, Kshlerin and Mohr", "Granite Developer leverage" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Leopoldo Cummerata", "ut", "https://picsum.photos/50/50/?image=368", "Eos quia autem voluptatem quia aliquam distinctio exercitationem debitis sunt mollitia mollitia doloribus consequatur exercitationem vel molestiae consequatur ut ipsa.", 872517718, 322, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "Keebler - Rempel", "Generic Rubber Hat drive client-server" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Willard Miller", "velit", "https://picsum.photos/50/50/?image=684", "Dolorem aut facilis facere aliquam nihil harum unde aut eum et qui maxime voluptate consequatur enim nesciunt aut voluptatum sint.", 139290563, 475, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "Willms - Bernier", "Savings Account Practical Metal Gloves tan" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Vaughn Reynolds", "officiis", "https://picsum.photos/50/50/?image=27", "Rerum sint suscipit iure porro nulla sequi cum alias eum dolore numquam rerum explicabo at laboriosam aliquid veritatis ducimus error.", 557816635, 545, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "Walsh - Ferry", "GB bus instruction set" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Gerardo Kovacek", "ut", "https://picsum.photos/50/50/?image=634", "Cumque facilis consequatur quo quaerat voluptas quibusdam mollitia eaque officia voluptatem delectus ducimus aliquid rem minus eum rem autem eligendi.", 665327116, 742, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "Torphy, Kutch and Kozey", "schemas Frozen olive" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Geovanni Koch", "et", "https://picsum.photos/50/50/?image=706", "Molestiae quisquam quos sint dolorem molestiae eos dolor velit nobis dolores autem doloremque et totam laudantium repellat labore inventore iste.", 251259249, 791, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), "Kunze, Dickens and Blanda", "bypassing dedicated Handcrafted" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Elinor Zulauf", "expedita", "https://picsum.photos/50/50/?image=1063", "Mollitia adipisci culpa rem dolor reprehenderit deserunt debitis laboriosam facere id quia sint ipsam rerum id quidem maiores molestias qui.", 876033747, 795, new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), "Yost - King", "reciprocal structure Kansas" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Darrick Hauck", "natus", "https://picsum.photos/50/50/?image=26", "Et nam voluptatem qui repellendus nobis aut quia laboriosam ratione voluptas aut et sed tempora enim nihil autem quia animi.", 837330246, 450, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), "Wehner, McGlynn and Towne", "turn-key Human Beauty & Computers" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lauren Effertz", "expedita", "https://picsum.photos/100/100/?image=325", "Velit consequuntur quam facilis possimus id doloribus eligendi laborum quas labore non debitis molestiae omnis dolorem libero non deserunt laboriosam.", 854184678, 893, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "Nader - Olson", "Ergonomic Wooden Salad Soft index" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Randal Ryan", "optio", "https://picsum.photos/100/100/?image=707", "Velit a neque praesentium saepe error ea sed incidunt in velit non officiis facere quo provident optio facilis blanditiis iure.", 202856164, 858, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), "Luettgen - Bogisich", "seize digital Unbranded" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kristin Jakubowski", "sit", "https://picsum.photos/100/100/?image=217", "Amet laborum dolorum architecto nisi perspiciatis voluptatem eos aut dolorum ipsum cupiditate voluptatem corrupti quia rerum ut et deserunt magni.", 295789280, 443, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "Smith, Wilkinson and Fay", "gold Orchestrator Baby & Electronics" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Chandler Hirthe", "consectetur", "https://picsum.photos/100/100/?image=330", "Et aut et ut repellat tempore dolor nam delectus officia totam quia sequi quos accusamus et aspernatur repellendus rerum repellat.", 381217569, 501, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "Walsh - MacGyver", "Books & Automotive array grey" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kirk Hilpert", "quae", "https://picsum.photos/100/100/?image=415", "Amet molestias qui molestiae ut voluptas quam molestiae et voluptas provident enim maxime occaecati recusandae quisquam assumenda cum rem aut.", 185501464, 100, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), "Effertz Inc", "North Dakota SCSI well-modulated" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alexander Beier", "quis", "https://picsum.photos/100/100/?image=203", "Dolore itaque a exercitationem voluptatem rem vero harum in quisquam dignissimos voluptas inventore id mollitia tempore expedita quod in quos.", 479478091, 601, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Local), "Mertz, Stoltenberg and Kris", "SDR Mobility open-source" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rhianna Wilderman", "porro", "https://picsum.photos/100/100/?image=107", "Magnam ut facere maxime sit nihil ut laborum qui nisi et ullam doloribus ducimus saepe fugiat corrupti laudantium expedita aliquam.", 408386516, 99, new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "Schimmel, Feest and Jacobson", "website Borders initiative" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Orlando Collins", "assumenda", "https://picsum.photos/100/100/?image=949", "Culpa fuga laborum vel aperiam eos eum recusandae cum veritatis reiciendis impedit explicabo temporibus in ut et et quisquam minus.", 622414607, 510, new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), "Brakus - Olson", "solid state Steel Avon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jerod McCullough", "ducimus", "https://picsum.photos/100/100/?image=203", "Sunt eum deleniti omnis nostrum sunt sunt et non assumenda nemo voluptatibus est nemo nam id eligendi exercitationem vel aut.", 875525736, 81, new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Local), "Gislason Inc", "Borders out-of-the-box open-source" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Adrain Blanda", "ea", "https://picsum.photos/100/100/?image=779", "Culpa aut nesciunt ea omnis iure provident architecto consequatur iusto facere nisi recusandae beatae nostrum molestiae perspiciatis a commodi vitae.", 730193301, 262, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), "Block - Watsica", "Ergonomic action-items Reduced" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hassie Zulauf", "non", "https://picsum.photos/100/100/?image=919", "Velit veritatis labore ad cumque facere eligendi qui quo mollitia aliquam harum facilis non consequatur rerum accusamus itaque rerum et.", 917113617, 339, new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), "Parisian, Collier and Nienow", "Tasty program payment" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Erik Wintheiser", "maiores", "https://picsum.photos/100/100/?image=398", "Recusandae quia itaque similique est ex non dolorem unde et velit dolores distinctio dolorem sunt ex ut repellendus et atque.", 506497453, 618, new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), "Feil, O'Reilly and Ledner", "SSL technologies firewall" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Marco Konopelski", "eum", "https://picsum.photos/100/100/?image=808", "Ipsum maxime nisi dolorum non ut possimus mollitia error atque voluptates minima aut rerum cupiditate nisi eaque nam omnis rerum.", 861877503, 311, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), "Murray Inc", "EXE Integration monetize" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Tyshawn Crona", "quia", "https://picsum.photos/100/100/?image=12", "Vel saepe iusto fugiat eaque velit placeat asperiores consequuntur animi nulla eius ea aperiam et nemo sit facere sit at.", 749698201, 319, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), "Abshire, Lakin and Zemlak", "Functionality object-oriented Configurable" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Geoffrey Homenick", "maiores", "https://picsum.photos/100/100/?image=373", "Fugiat non cupiditate itaque dolorum excepturi eaque temporibus saepe error exercitationem nulla optio consequatur dolorum quia quos reiciendis aut aut.", 447469960, 183, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), "Sporer and Sons", "capability Boliviano boliviano Planner" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Tamia McLaughlin", "incidunt", "https://picsum.photos/100/100/?image=434", "Laboriosam cum consequatur voluptatem quo unde est corporis reprehenderit sint voluptas sed beatae harum dolor eum possimus nulla non deleniti.", 566268689, 837, new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Local), "Beier Inc", "compressing real-time Incredible Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lafayette Lockman", "illo", "https://picsum.photos/100/100/?image=914", "Et quia laudantium eaque ducimus aut non dolorem ut quis sunt omnis aperiam ut quis consectetur laudantium molestiae dignissimos aspernatur.", 114086842, 824, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Kiehn LLC", "matrix invoice Up-sized" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Harmon Little", "occaecati", "https://picsum.photos/100/100/?image=128", "Id repudiandae non quo dolores ducimus eaque dignissimos repellendus aut rem animi sit itaque quas sed sunt illum doloremque recusandae.", 721261869, 812, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), "Waelchi, Leuschke and Schowalter", "eyeballs Brunei Dollar background" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Keira Homenick", "facilis", "https://picsum.photos/100/100/?image=694", "Est molestias dolorem omnis ullam aut quia est doloribus ut aut eaque et nesciunt repudiandae aperiam magnam amet suscipit et.", 713072743, 859, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), "Gaylord - Hartmann", "generate moderator Circle" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Curt Jacobs", "aliquid", "https://picsum.photos/100/100/?image=858", "Explicabo perspiciatis deleniti nesciunt accusamus nihil veritatis molestiae optio voluptatem aut unde modi aliquid quaerat doloribus nulla illum accusamus alias.", 202693042, 235, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), "Hickle LLC", "Health, Home & Baby Infrastructure sky blue" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Bruce Johnson", "adipisci", "https://picsum.photos/100/100/?image=181", "Vel omnis est sint ea illo distinctio voluptas enim eum beatae commodi nihil cum atque voluptatem et sequi culpa ea.", 243194655, 862, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), "Hammes, Bailey and Schultz", "Credit Card Account interface Administrator" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ubaldo Stiedemann", "odit", "https://picsum.photos/100/100/?image=776", "Sequi illum quod fugiat tempore rerum nihil quis ut iusto quaerat in voluptatibus illo amet illo et eius minima itaque.", 126460643, 711, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "Dicki Group", "card Orchestrator out-of-the-box" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mia Johnston", "commodi", "https://picsum.photos/100/100/?image=444", "Tenetur non optio consequatur omnis magnam cum qui quos minima quisquam tempore dolor voluptas amet voluptatem totam eligendi quos non.", 214635541, 691, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Considine, Kuhic and Borer", "supply-chains Metal Baby, Kids & Automotive" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Gustave Lind", "ducimus", "https://picsum.photos/100/100/?image=307", "Asperiores minima illo possimus omnis iste amet tempore mollitia officiis odit minus quo non tempora autem voluptas beatae aperiam minima.", 853702088, 185, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "Fadel - Runolfsdottir", "composite Practical grid-enabled" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jayda Prohaska", "reiciendis", "https://picsum.photos/100/100/?image=585", "Non quo provident ratione impedit eos et quo veritatis fugiat eveniet omnis ut quis numquam et doloremque qui laudantium repellendus.", 496925047, 119, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), "Corkery, Langworth and Sawayn", "Associate Shores Checking Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Una Homenick", "repellat", "https://picsum.photos/100/100/?image=673", "Itaque cumque sunt voluptatem in aut nostrum quasi est repudiandae sit necessitatibus blanditiis sit consequatur facere molestias sed ratione quo.", 108916795, 115, new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Local), "Bailey, Padberg and Ledner", "Chief East Caribbean Dollar synergistic" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alan Cronin", "doloribus", "https://picsum.photos/100/100/?image=971", "Qui ut qui deleniti qui fugit quo quo quis aut dolore deserunt et nemo qui eaque a est nam cupiditate.", 548204454, 477, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Local), "Rowe, Kshlerin and Streich", "Assurance copying Fantastic Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Betty Auer", "ducimus", "https://picsum.photos/100/100/?image=668", "Et doloribus omnis facere ut et natus vel quibusdam sed ducimus maiores ut voluptas odit veritatis repellat modi perspiciatis voluptatem.", 791732715, 119, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), "Hilpert - Corwin", "paradigms Cuban Peso Borders" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jeremy Balistreri", "culpa", "https://picsum.photos/100/100/?image=724", "Ut sed rerum nihil magni tenetur consequatur laboriosam nisi quaerat ex repudiandae consequatur dolorem quos reiciendis possimus earum ut suscipit.", 693505486, 746, new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "Mohr - Pouros", "Harbors Music Bedfordshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Chyna Hackett", "dolorem", "https://picsum.photos/100/100/?image=481", "In et accusamus commodi tenetur nam aut et rerum recusandae qui nobis nesciunt tenetur eum consequatur sed quibusdam eos eum.", 105869106, 109, new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), "Welch, Lesch and Wolff", "Markets quantifying Industrial" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Nyasia Moen", "molestiae", "https://picsum.photos/100/100/?image=954", "Laudantium alias doloremque ducimus quod ad facilis eos rerum laudantium est cupiditate omnis voluptas repellendus sed qui itaque magnam provident.", 452141516, 399, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Bins LLC", "extensible IB Kansas" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Melyssa McGlynn", "et", "https://picsum.photos/100/100/?image=576", "Quisquam eum at iure voluptatem repellat quis architecto maiores et delectus illo inventore eaque dolor ea deleniti voluptatibus vero dolores.", 980964879, 848, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), "Predovic LLC", "Front-line Concrete indexing" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sadye Bednar", "sed", "https://picsum.photos/100/100/?image=56", "Neque provident ullam nisi quis esse voluptatem omnis magnam tenetur temporibus dolor nisi aut nulla et consequatur saepe a eum.", 249282975, 780, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Local), "Lueilwitz Inc", "Codes specifically reserved for testing purposes Cambridgeshire Synchronised" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Nigel Lockman", "id", "https://picsum.photos/100/100/?image=1032", "Illum eligendi et rerum molestias aut consequatur rerum excepturi minus corrupti eius ut qui harum dolores porro nihil quis eum.", 546557868, 413, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Donnelly, Kuhlman and Marquardt", "Jewelery Soft multi-byte" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Anita Satterfield", "nisi", "https://picsum.photos/100/100/?image=544", "Error ratione laborum ea sint veniam aspernatur hic numquam inventore blanditiis magni modi et nostrum suscipit quasi similique adipisci quasi.", 148086947, 972, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), "Hessel Inc", "Realigned Berkshire Personal Loan Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Erling Mohr", "expedita", "https://picsum.photos/100/100/?image=1068", "Et explicabo accusantium sed eos voluptatem ipsa natus optio iusto velit voluptatem nihil voluptatibus quia quisquam natus explicabo unde deserunt.", 751840757, 348, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), "Durgan, Mraz and Hodkiewicz", "Steel Awesome Cotton Table COM" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Talia Witting", "sunt", "https://picsum.photos/100/100/?image=386", "Doloribus similique incidunt qui molestias id sint quidem alias et asperiores consequatur laborum sequi unde et sunt qui laudantium consequuntur.", 918329037, 558, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), "Johnston and Sons", "maximize optical withdrawal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Earline Nikolaus", "eos", "https://picsum.photos/100/100/?image=290", "Officia amet nulla voluptatibus in suscipit in commodi magni et ut ut animi unde voluptas doloremque quasi harum voluptas quia.", 657690317, 207, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), "Auer LLC", "orchid input compress" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Clotilde Keeling", "qui", "https://picsum.photos/100/100/?image=831", "Non doloremque est omnis delectus in alias consequatur ut in nihil quidem est veritatis vitae consequatur aut sit delectus repudiandae.", 746224556, 976, new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), "Jacobs Inc", "Gorgeous Cotton Chair withdrawal turn-key" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Florine Nader", "at", "https://picsum.photos/100/100/?image=824", "Ea eligendi blanditiis aliquam ut nulla quia unde illum sit dolore debitis optio distinctio similique deserunt sit et rerum id.", 822535114, 682, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), "Schmitt, Medhurst and Beahan", "Frozen cohesive Lodge" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Santiago Macejkovic", "assumenda", "https://picsum.photos/100/100/?image=1015", "Ut enim aut cupiditate ut provident at iste et culpa perferendis quo voluptas voluptas ullam molestias eos mollitia dolorem cupiditate.", 380288364, 806, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Schimmel - Labadie", "directional programming Fantastic Wooden Table" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Otho Bernier", "qui", "https://picsum.photos/100/100/?image=1042", "Asperiores eligendi sit deserunt et et qui animi aut voluptatem perspiciatis ducimus eum voluptas sint id dolorem eos sit unde.", 433307146, 422, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Local), "Stark Group", "Kansas Internal Awesome Granite Salad" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jeanne Crooks", "quisquam", "https://picsum.photos/100/100/?image=308", "Beatae numquam officia totam repellat vero eos est consequatur aliquid autem odit voluptatem libero fugit repellendus omnis blanditiis exercitationem quis.", 628605632, 530, new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), "Turcotte, Stanton and Little", "Data Configuration quantifying" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Brayan Torp", "sapiente", "https://picsum.photos/100/100/?image=289", "Deserunt voluptas et pariatur facere rerum at sunt quasi perferendis quaerat qui natus sunt laboriosam omnis praesentium et error eos.", 606175369, 171, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), "Bashirian Group", "Ergonomic Granite Mouse Borders Equatorial Guinea" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Toney Funk", "et", "https://picsum.photos/100/100/?image=839", "Maiores sapiente autem id labore sit ullam nulla soluta et fugiat qui error laboriosam sit ea voluptatem quos aperiam alias.", 588840060, 102, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Sporer - Kiehn", "Incredible Rubber Ball JBOD hard drive" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Gillian Kertzmann", "exercitationem", "https://picsum.photos/100/100/?image=194", "Saepe odio voluptate consequatur voluptas harum maiores tenetur ex asperiores cumque consectetur fuga inventore est ducimus voluptates adipisci sequi fugiat.", 536127784, 852, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), "Schamberger - Bernier", "calculate Points Forward" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Carter Corkery", "id", "https://picsum.photos/100/100/?image=522", "Neque consectetur sit odit cupiditate at id eligendi aut hic vel aliquid accusamus cumque consequatur eos eveniet aut quidem est.", 624019908, 605, new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "Rowe, Dicki and Kuhn", "Tasty product Human" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Antonietta Feest", "dicta", "https://picsum.photos/100/100/?image=658", "Est ullam quidem maxime quas neque officiis minima illum veniam eos exercitationem occaecati ratione quia quae ipsa est consectetur ipsam.", 437256262, 514, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "Muller and Sons", "paradigms Frozen HDD" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Moses Morissette", "deleniti", "https://picsum.photos/100/100/?image=152", "Magni est libero illum et porro molestiae eos quis quia consequuntur voluptas modi placeat voluptatem distinctio rerum commodi sed beatae.", 407665762, 158, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), "Howe, Barton and Bayer", "overriding architecture Connecticut" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Brigitte Lockman", "doloremque", "https://picsum.photos/100/100/?image=492", "Enim assumenda eum animi at nesciunt sint labore dolor maxime et atque id voluptates autem nulla quam odio possimus autem.", 723089505, 268, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "Funk, Ratke and Gleichner", "Representative Trafficway architecture" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ara Lueilwitz", "harum", "https://picsum.photos/100/100/?image=787", "Quam eum ipsam necessitatibus modi laborum exercitationem illum omnis non eum nesciunt nihil rem suscipit doloribus eos molestiae ullam eveniet.", 259441581, 613, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), "Bernier - Terry", "markets Meadows hard drive" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Natasha Buckridge", "nisi", "https://picsum.photos/100/100/?image=973", "Voluptatem natus reprehenderit porro eos inventore nisi consequatur quam sit iste qui quaerat eum esse ratione doloribus voluptas deleniti eum.", 468023521, 443, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "Von - Schmitt", "Refined Steel Chair Missouri relationships" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Camylle Hayes", "et", "https://picsum.photos/100/100/?image=263", "Officia pariatur impedit itaque delectus dolor itaque nisi aliquam aspernatur et voluptates ut sed est id et fuga nam praesentium.", 722076819, 168, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Local), "Lueilwitz - Zulauf", "capacitor Rustic Steel Pizza Parks" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Laron West", "est", "https://picsum.photos/100/100/?image=992", "Eum optio sit sed veritatis ea quidem harum assumenda autem repellendus corporis fugiat dolore culpa culpa facere cupiditate aut culpa.", 827894289, 624, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "Shanahan - Reilly", "mobile invoice IB" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Stanton Klein", "consequatur", "https://picsum.photos/100/100/?image=823", "Laboriosam suscipit voluptatem dolor recusandae quisquam ut sequi reprehenderit ullam ea eum ipsum sint ut nam sapiente fuga consequatur veniam.", 191720357, 530, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), "Hintz - Schmeler", "Decentralized GB turquoise" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Eliezer Cummerata", "veniam", "https://picsum.photos/100/100/?image=472", "Voluptatem molestiae omnis quaerat nulla distinctio ipsum et dolor dolorem aut enim aut officia velit saepe est et provident voluptatem.", 299144380, 625, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Local), "Connelly and Sons", "Intelligent Metal Salad Utah Rial Omani" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Carroll Abbott", "occaecati", "https://picsum.photos/100/100/?image=168", "Magnam qui et accusantium corrupti nesciunt sunt est officiis ut non atque laboriosam similique qui dicta corrupti impedit similique dolorem.", 989919717, 447, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), "Bednar - Emard", "hard drive Path SSL" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Nelda Schmitt", "asperiores", "https://picsum.photos/100/100/?image=222", "Minus omnis provident totam aut possimus quos sed occaecati corrupti deleniti nihil amet omnis sunt perferendis est reiciendis ab qui.", 555958591, 352, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Local), "Breitenberg, Stark and Goodwin", "open-source solid state Handmade Steel Towels" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Drake Gutmann", "rerum", "https://picsum.photos/100/100/?image=608", "Qui quidem est aut quia non sed esse modi enim et aut est hic quis odio aspernatur sit temporibus rem.", 649204216, 818, new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Local), "Stiedemann - Dickinson", "bandwidth Generic Plastic Shirt deposit" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Moses Kerluke", "unde", "https://picsum.photos/100/100/?image=697", "Aut laudantium explicabo cupiditate et deleniti nemo est eaque quisquam consequuntur labore nam unde repudiandae perferendis illum architecto magnam ratione.", 691942627, 979, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), "Green, Marvin and Pagac", "Borders Netherlands Antilles Berkshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Chris Oberbrunner", "tempora", "https://picsum.photos/100/100/?image=961", "Ut eum et architecto doloribus laborum at et velit quaerat laboriosam similique hic temporibus tenetur voluptates autem consequatur molestias ipsum.", 264591474, 822, new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), "Ritchie, Gutkowski and Heaney", "multi-tasking invoice AGP" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Brionna Hartmann", "nihil", "https://picsum.photos/100/100/?image=662", "Perspiciatis eaque recusandae minus sed eveniet sed similique ea et numquam aut temporibus non consequuntur soluta temporibus quis dicta ut.", 602128724, 963, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), "Nienow, Ferry and Monahan", "Virginia Profound Forest" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Brenna Mraz", "nihil", "https://picsum.photos/100/100/?image=25", "Praesentium et ut aut sunt ut sint molestiae dolorem minima omnis doloribus sequi est dolor molestiae autem in et voluptatem.", 418560629, 778, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), "Stanton Group", "programming Causeway Sports & Shoes" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jarrell Walsh", "enim", "https://picsum.photos/100/100/?image=500", "Harum inventore ratione possimus provident molestiae aut quas quos quisquam et veniam dolor odit pariatur aut repellat incidunt itaque ut.", 943356523, 172, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "Conn, Bechtelar and Bashirian", "sky blue hybrid European Monetary Unit (E.M.U.-6)" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Yazmin Kuvalis", "dolores", "https://picsum.photos/100/100/?image=32", "Labore dolores vel soluta nihil distinctio dolor porro molestiae sit architecto et beatae consequatur fugiat optio perspiciatis itaque distinctio rerum.", 254824428, 249, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), "Dietrich, Roob and Bailey", "cutting-edge Wooden Illinois" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kaden Rau", "sint", "https://picsum.photos/100/100/?image=176", "Eos officiis ipsum eum nisi aspernatur repudiandae debitis occaecati et officia molestiae commodi dolore repellendus quidem et quidem eaque alias.", 795157452, 513, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "Heidenreich, Nicolas and Hauck", "Bedfordshire Personal Loan Account South Georgia and the South Sandwich Islands" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kobe Haag", "neque", "https://picsum.photos/100/100/?image=556", "Et unde et voluptas quisquam unde quae consequatur dignissimos iure illo maiores velit necessitatibus harum sit et sint incidunt reiciendis.", 473794088, 442, new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "Johnston - Mann", "IB navigating card" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alford Klein", "odio", "https://picsum.photos/100/100/?image=917", "Praesentium quo sunt amet aliquid quo ratione nobis vero ut neque aut autem accusantium delectus ut voluptatem voluptatem hic quis.", 498470006, 228, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "Jones LLC", "Garden & Sports Personal Loan Account withdrawal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dashawn Crist", "laboriosam", "https://picsum.photos/100/100/?image=373", "Eos corporis aut porro ut qui magni corporis eos sit in molestias sint vitae quae aperiam aut nihil quo sit.", 277895049, 80, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Local), "O'Conner, Bednar and Funk", "Checking Account withdrawal Guinea" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Anastasia Adams", "doloremque", "https://picsum.photos/100/100/?image=940", "Velit voluptas iste voluptate ratione voluptatem debitis nostrum dicta aut molestiae distinctio quasi aliquam quo non aut autem quia neque.", 689782800, 436, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "Huel - Morissette", "Personal Loan Account Fantastic Fresh Sausages Shoals" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lulu Schumm", "ut", "https://picsum.photos/100/100/?image=130", "Libero tempore quidem ex aut delectus deleniti ea recusandae vel est aliquid laborum ut fugiat et possimus sit natus quia.", 963775153, 578, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "Klocko - Lind", "bypassing Maryland deploy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Burley Nitzsche", "dicta", "https://picsum.photos/100/100/?image=559", "Cumque laborum cum consequatur tempore eveniet in occaecati esse architecto molestias aspernatur doloribus assumenda optio aspernatur est dolores et quia.", 919130108, 173, new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), "Beahan, Okuneva and Stoltenberg", "deposit Identity Buckinghamshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Norberto Hauck", "quibusdam", "https://picsum.photos/100/100/?image=1047", "Et sequi enim non cupiditate commodi magnam sed voluptatum aut numquam accusamus libero et nesciunt voluptas veritatis vel et aperiam.", 708431472, 153, new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), "Quitzon Inc", "Rustic Concrete Chips Unbranded Rubber Tuna HDD" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jodie Erdman", "quo", "https://picsum.photos/100/100/?image=797", "Nobis id qui culpa eos porro qui accusamus reiciendis nihil delectus officia ducimus cupiditate dolorem nemo in quam eaque nesciunt.", 871514059, 506, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), "Witting - Feil", "Savings Account grey transform" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Heidi O'Kon", "sit", "https://picsum.photos/100/100/?image=236", "Quam omnis voluptas quis dicta possimus qui porro quos fuga ullam porro alias molestiae doloremque sit autem eius doloremque qui.", 987490466, 464, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), "Pfannerstill LLC", "synthesizing SMS revolutionary" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Everett Kilback", "iusto", "https://picsum.photos/100/100/?image=484", "In vero iusto tempora impedit voluptatibus voluptatem et iure rerum qui distinctio qui laboriosam et quis nemo reiciendis laboriosam et.", 892827448, 518, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "Kirlin - Marquardt", "wireless Solomon Islands sensor" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lurline Buckridge", "autem", "https://picsum.photos/100/100/?image=901", "Omnis occaecati adipisci doloremque et voluptatem vitae autem minima explicabo magni qui delectus in dolor consequatur eveniet nesciunt qui at.", 850462170, 789, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "Kassulke - Roberts", "Reactive Gorgeous synergies" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jermaine Halvorson", "et", "https://picsum.photos/100/100/?image=606", "Odio ducimus iste sit et et rem incidunt inventore et provident quasi fuga distinctio ipsa ipsum et sint perferendis eaque.", 708029777, 719, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), "Kuhic, Ratke and Von", "indexing intuitive synthesize" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Frederic Bruen", "neque", "https://picsum.photos/100/100/?image=778", "Perferendis est consectetur vitae consequatur repudiandae nulla soluta molestiae recusandae molestiae sint eligendi sunt aut est quos vel tenetur aut.", 556437620, 935, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), "Hettinger - Walker", "indexing Croatia Buckinghamshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jalon Batz", "non", "https://picsum.photos/100/100/?image=406", "Est ut et expedita assumenda est porro non repudiandae et architecto nihil soluta esse occaecati optio dolore dolor nihil quis.", 504960079, 556, new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), "Mante - Friesen", "lime paradigm Auto Loan Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Winona Schowalter", "sint", "https://picsum.photos/100/100/?image=500", "Eos voluptatem consequuntur facilis similique necessitatibus quia sed dolores blanditiis enim magnam minima quisquam ab et qui dicta numquam soluta.", 579131481, 54, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), "Stracke, Hyatt and Jenkins", "Clothing, Shoes & Grocery Arkansas Trail" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "King Farrell", "reprehenderit", "https://picsum.photos/100/100/?image=459", "Non nam cum voluptates est quis delectus velit in autem odio laudantium neque voluptatem non aperiam deserunt assumenda accusantium odio.", 411452133, 184, new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Local), "Mraz - Kassulke", "world-class Adaptive Investor" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rosa Yost", "vero", "https://picsum.photos/100/100/?image=88", "Qui tenetur qui consequuntur vero et voluptas nulla aut reprehenderit a praesentium et ducimus quo sed tenetur veritatis id vero.", 188836918, 414, new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), "Goyette - Heathcote", "Accountability methodologies Tasty Granite Towels" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Terrance Volkman", "aliquid", "https://picsum.photos/100/100/?image=679", "Veritatis ut et odio nihil est sit quia quasi ut sed dolor nesciunt fugit minus ipsum minima aliquam voluptas sint.", 143209836, 223, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), "Ratke and Sons", "programming Checking Account American Samoa" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Forest Hagenes", "aut", "https://picsum.photos/100/100/?image=67", "In porro harum praesentium alias maxime aliquam quia exercitationem qui commodi laboriosam reiciendis impedit a at quia officiis deserunt soluta.", 438875504, 491, new DateTime(2024, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), "Pacocha and Sons", "deposit Tasty Cotton" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jacinto Ullrich", "fugiat", "https://picsum.photos/100/100/?image=583", "Eum dolor eaque ut quaerat nemo cupiditate consequuntur veniam molestiae laboriosam aut repudiandae neque eius repellendus et officia nesciunt earum.", 661990730, 481, new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), "Langosh, Kling and Shanahan", "Awesome Awesome Steel Bike synergies" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Gilda Roberts", "quam", "https://picsum.photos/100/100/?image=526", "Placeat suscipit officiis fugiat consequatur quibusdam corrupti sed tempore quasi quas ipsa fugiat incidunt impedit est expedita sit autem et.", 328790873, 427, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), "Dibbert, Little and Watsica", "hard drive red AGP" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Camden Ziemann", "consequuntur", "https://picsum.photos/100/100/?image=727", "Perspiciatis animi corrupti voluptate quo labore nihil et nam maxime distinctio reiciendis consectetur modi sapiente dicta nam laboriosam provident aut.", 498983047, 995, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), "Kozey, Connelly and Padberg", "Unbranded Concrete Sausages Licensed synthesize" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rolando Price", "itaque", "https://picsum.photos/100/100/?image=714", "Laboriosam ea hic reiciendis optio laudantium quia nihil aut quasi eaque similique sed adipisci tenetur assumenda deleniti dolores blanditiis cumque.", 231574762, 626, new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), "Dickinson LLC", "Lithuania Avon silver" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Verner Nicolas", "distinctio", "https://picsum.photos/100/100/?image=236", "Dicta minima est vel ea officia magni vero voluptatem voluptatibus molestiae amet quis illum tenetur possimus neque et ullam est.", 337746180, 675, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "Pouros Group", "Pines Shoals transmitting" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Leila Kuphal", "et", "https://picsum.photos/100/100/?image=200", "Non architecto dolores quia odio autem reiciendis quo iste ab quibusdam mollitia rerum officiis est velit molestiae itaque necessitatibus aut.", 678761261, 138, new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), "Pfeffer and Sons", "Home, Computers & Sports SMTP Corporate" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Bertrand Pfannerstill", "commodi", "https://picsum.photos/100/100/?image=459", "Quam esse repudiandae et et aut explicabo necessitatibus qui voluptas est corrupti commodi modi cum rerum et sint et quibusdam.", 707278929, 845, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "Auer, Trantow and Bartell", "Visionary Incredible Plastic Towels supply-chains" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Eda Harvey", "impedit", "https://picsum.photos/100/100/?image=567", "Qui quis ut quibusdam qui voluptate error voluptatum et vel praesentium est corporis culpa et aut quaerat at id quidem.", 979173381, 333, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), "Cartwright and Sons", "Intelligent Plastic Mouse driver Small" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Carrie Mann", "beatae", "https://picsum.photos/100/100/?image=919", "Est accusantium soluta deleniti natus porro harum ducimus velit assumenda dignissimos soluta voluptas voluptatem iusto nihil voluptatem est assumenda officiis.", 765492018, 923, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "Yost, Hodkiewicz and Murray", "Tunnel Money Market Account index" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Myrna Walsh", "cum", "https://picsum.photos/100/100/?image=102", "Omnis voluptas et est sint beatae fugit atque et sit tempora qui explicabo molestiae quo in omnis esse beatae laborum.", 606770834, 524, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "Graham - Franecki", "Toys invoice Generic Soft Hat" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ashley Boyle", "eius", "https://picsum.photos/100/100/?image=257", "Blanditiis sit quasi et aspernatur dolorum rerum dolor voluptatem qui in rerum mollitia architecto odio assumenda odio facilis eius dolore.", 700646231, 307, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Local), "Keeling - Kuhic", "Rustic Metal Towels Practical withdrawal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lance Kutch", "nemo", "https://picsum.photos/100/100/?image=1020", "Qui nisi officiis architecto temporibus adipisci modi est sequi odio rerum officia iusto debitis aliquam minima magni dolore nihil enim.", 590250071, 438, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), "Bechtelar - Kuvalis", "multi-tasking withdrawal Cambridgeshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Marcellus Effertz", "sunt", "https://picsum.photos/100/100/?image=960", "Laboriosam animi deserunt dolor eos expedita qui reiciendis est itaque et illo rerum corrupti mollitia ex omnis quia labore dolorum.", 790618178, 127, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Weber LLC", "Licensed Cambridgeshire override" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Liliane Von", "fugiat", "https://picsum.photos/100/100/?image=893", "Possimus voluptatibus harum velit assumenda esse voluptatibus et quod quam sit modi rerum molestias deleniti odit vel consequatur ducimus et.", 467821258, 800, new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Local), "Spencer - Schroeder", "Personal Loan Account Wooden Steel" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hipolito Feest", "sit", "https://picsum.photos/100/100/?image=975", "Qui saepe dolores dolor voluptatem sed provident dolorum eaque rerum omnis recusandae rerum expedita perferendis delectus aut qui qui aspernatur.", 439789999, 860, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), "Kuhic - Breitenberg", "online Gorgeous Plastic Towels Chief" });
        }
    }
}
