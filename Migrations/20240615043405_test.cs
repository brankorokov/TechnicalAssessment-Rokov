using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechnicalAssessmentRokov.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Ward Stark", "nostrum", "http://lorempixel.com/640/480/nature", "Dolorem aut vero ratione sunt rem veritatis placeat quis adipisci aut ipsam et officia qui quis at quia a molestiae.", 417940919, 89, new DateTime(2024, 2, 2, 5, 49, 28, 599, DateTimeKind.Local).AddTicks(2021), "Corkery - Langosh" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Shawna Mitchell", "quaerat", "http://lorempixel.com/640/480/animals", "Odio amet qui corporis architecto inventore vitae mollitia sapiente rerum perferendis tempore qui enim qui blanditiis autem dolor nihil vel.", 732318362, 605, new DateTime(2023, 10, 28, 10, 11, 43, 968, DateTimeKind.Local).AddTicks(3236), "Turner Group" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Parker Heidenreich", "ullam", "http://lorempixel.com/640/480/transport", "Qui explicabo vel labore ex praesentium deserunt eum laboriosam at beatae recusandae tempore repellat necessitatibus nostrum laborum voluptas voluptatem quisquam.", 444355471, 835, new DateTime(2023, 7, 20, 23, 53, 29, 382, DateTimeKind.Local).AddTicks(1785), "Schneider Group" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Elliott Greenholt", "non", "Consectetur aut eius qui excepturi voluptas fuga adipisci repellat quo autem sed voluptatibus numquam omnis magni suscipit et tempora soluta.", 224106338, 312, new DateTime(2023, 8, 15, 14, 27, 1, 79, DateTimeKind.Local).AddTicks(5146), "Hahn Group" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Claude Emard", "et", "http://lorempixel.com/640/480/abstract", "Placeat eum quas est consectetur reiciendis repudiandae autem vel aspernatur ut alias reprehenderit velit recusandae aspernatur asperiores et sequi assumenda.", 569007471, 802, new DateTime(2023, 11, 8, 5, 2, 46, 223, DateTimeKind.Local).AddTicks(5913), "Prohaska Group" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Halle Parisian", "qui", "Asperiores ipsam sequi quasi aut a non dolores ullam ipsa repellendus quia harum aut vero perspiciatis totam hic occaecati illo.", 152344337, 257, new DateTime(2024, 2, 12, 7, 25, 32, 61, DateTimeKind.Local).AddTicks(2729), "Rowe LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Scarlett Shields", "maxime", "http://lorempixel.com/640/480/food", "Similique numquam rem doloribus architecto dolor quibusdam est qui cum consequatur quas iusto ut aut explicabo nesciunt a recusandae harum.", 615678970, 553, new DateTime(2024, 2, 12, 19, 24, 57, 167, DateTimeKind.Local).AddTicks(1192), "Harris - Hauck" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Jasen Cremin", "fugit", "http://lorempixel.com/640/480/nightlife", "Voluptas voluptas voluptatem minus id optio voluptatem similique magni odio fugiat culpa ut sed veritatis quia laudantium ut enim dolorem.", 590558325, 695, new DateTime(2023, 8, 6, 6, 10, 12, 158, DateTimeKind.Local).AddTicks(1274), "Auer - Price" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Jan Schulist", "sit", "http://lorempixel.com/640/480/technics", "Totam accusamus nulla ut in dolor atque rerum ut sunt perspiciatis velit mollitia veritatis debitis velit et quam vero sed.", 818298558, 755, new DateTime(2023, 12, 23, 22, 33, 4, 110, DateTimeKind.Local).AddTicks(6251), "Jenkins - McDermott" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Taylor Mraz", "accusamus", "http://lorempixel.com/640/480/technics", "Quas aut accusamus molestias omnis alias sint excepturi est consequatur vel perferendis iure assumenda nihil quisquam sequi iusto velit numquam.", 915480645, 777, new DateTime(2023, 11, 8, 23, 33, 35, 88, DateTimeKind.Local).AddTicks(6962), "Kling, Blanda and Skiles" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Glenda Zboncak", "fugiat", "http://lorempixel.com/640/480/cats", "Dicta dolores eum quo cupiditate adipisci dignissimos veniam omnis sit explicabo vel iusto eaque commodi perspiciatis non blanditiis sit porro.", 542502615, 560, new DateTime(2024, 5, 11, 6, 55, 53, 596, DateTimeKind.Local).AddTicks(1479), "Rowe - Abernathy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Darrell Jacobson", "sed", "http://lorempixel.com/640/480/fashion", "Reprehenderit voluptas eum autem perspiciatis dolor mollitia velit eaque esse et aut animi ducimus repellat voluptas rerum vero et voluptas.", 406754309, 992, new DateTime(2023, 8, 22, 1, 2, 31, 891, DateTimeKind.Local).AddTicks(4902), "Denesik - Gorczany" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Francisco Cormier", "dicta", "http://lorempixel.com/640/480/sports", "Repudiandae cupiditate ea ea qui quidem eius qui in omnis in maiores quia officiis sit beatae explicabo laborum debitis id.", 431806095, 801, new DateTime(2023, 10, 5, 3, 53, 47, 1, DateTimeKind.Local).AddTicks(6654), "Rempel and Sons" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Noelia Kutch", "tempore", "http://lorempixel.com/640/480/business", "Temporibus rerum nihil quam ut aut ut iusto tenetur quam dolor dolorum ducimus incidunt earum quibusdam nemo qui eligendi et.", 698952760, 77, new DateTime(2023, 8, 28, 6, 36, 49, 746, DateTimeKind.Local).AddTicks(747), "Nikolaus LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Jerad Hudson", "voluptatem", "http://lorempixel.com/640/480/abstract", "Est et dignissimos minus libero est molestiae dignissimos quis pariatur iste vel sint non ea doloremque occaecati aut ut fuga.", 846458550, 565, new DateTime(2024, 6, 2, 19, 48, 23, 816, DateTimeKind.Local).AddTicks(6157), "Wuckert, Schuppe and Daugherty" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Gudrun Kuhn", "et", "http://lorempixel.com/640/480/sports", "Vero fugiat ipsam ratione sed tempora eaque fuga quibusdam dolores nulla enim saepe sint harum tempore sed dolores illo doloribus.", 742066613, 295, new DateTime(2023, 11, 19, 12, 7, 53, 811, DateTimeKind.Local).AddTicks(6318), "Senger LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Charley Kunze", "delectus", "Iste aliquid illo voluptas eos facere ex expedita labore voluptate sunt amet molestiae cumque et omnis veritatis blanditiis provident distinctio.", 680157052, 520, new DateTime(2023, 10, 8, 17, 36, 42, 131, DateTimeKind.Local).AddTicks(2639), "Wolf, Berge and Casper" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Cielo Upton", "minus", "http://lorempixel.com/640/480/nightlife", "Enim laudantium sed omnis nemo aut ad repudiandae asperiores saepe at ipsam laboriosam consectetur culpa et quia dolorem porro itaque.", 212394613, 631, new DateTime(2023, 9, 4, 19, 54, 41, 373, DateTimeKind.Local).AddTicks(8151), "Aufderhar - Tromp" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Torey Hagenes", "ducimus", "http://lorempixel.com/640/480/food", "Aliquam fugiat sed quam dolorem aut est quaerat est dolorem vitae eius et dolores recusandae ullam ipsam corporis aliquid nihil.", 906524123, 683, new DateTime(2024, 2, 28, 14, 0, 41, 530, DateTimeKind.Local).AddTicks(3959), "Maggio - Hills" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Amir Breitenberg", "eum", "http://lorempixel.com/640/480/cats", "Est harum sed dolor quis ad accusamus non aut iusto quaerat blanditiis tenetur odit id rerum molestiae qui asperiores aperiam.", 880716617, 975, new DateTime(2024, 5, 27, 23, 10, 26, 380, DateTimeKind.Local).AddTicks(9776), "McGlynn, Jerde and Kessler" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Myrtis Hauck", "at", "http://lorempixel.com/640/480/fashion", "Doloremque laboriosam tempora dolore et et quis aut neque ad fugit rerum exercitationem corporis laborum sed facere odit laborum quis.", 646933286, 755, new DateTime(2023, 11, 4, 18, 44, 24, 110, DateTimeKind.Local).AddTicks(2772), "Reichert and Sons" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Godfrey Marquardt", "iste", "http://lorempixel.com/640/480/animals", "Laborum voluptatibus ut autem tempora et corrupti ipsum neque eaque odit perferendis maxime repellendus ut reiciendis blanditiis inventore quia suscipit.", 925398969, 306, new DateTime(2023, 7, 17, 11, 10, 55, 287, DateTimeKind.Local).AddTicks(5623), "Pouros LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Mckenna Abernathy", "sunt", "http://lorempixel.com/640/480/transport", "Ut tempore molestiae omnis placeat quidem consequatur nihil eius ea vitae molestiae laudantium quo maxime quod eum fuga accusamus ea.", 882101320, 335, new DateTime(2024, 1, 11, 4, 59, 17, 820, DateTimeKind.Local).AddTicks(8373), "Harber, McClure and Treutel" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Lauryn Mosciski", "deleniti", "http://lorempixel.com/640/480/business", "Perferendis quia voluptatum quibusdam dolore ratione distinctio minus et autem voluptatem eum quia id voluptates impedit sint voluptatibus sit dolores.", 879163314, 687, new DateTime(2024, 2, 19, 3, 20, 23, 697, DateTimeKind.Local).AddTicks(3814), "Davis, Mohr and Willms" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Suzanne Ward", "recusandae", "http://lorempixel.com/640/480/nightlife", "Quos debitis provident explicabo dolor et at dolore repudiandae sunt harum suscipit sit deserunt nihil ut ullam est sed hic.", 841248482, 255, new DateTime(2023, 9, 6, 9, 37, 51, 185, DateTimeKind.Local).AddTicks(3848), "Schaden - Daniel" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Allison Cronin", "veniam", "http://lorempixel.com/640/480/animals", "Autem assumenda corporis quae molestias et aut vel et distinctio et velit nam sed qui quos quos ab doloremque voluptatibus.", 230450530, 454, new DateTime(2023, 10, 5, 15, 30, 7, 11, DateTimeKind.Local).AddTicks(3543), "Hayes LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Stacey Kunze", "et", "http://lorempixel.com/640/480/sports", "Eum id qui aut nemo illum eos repellat dolorem velit quo eius eos inventore et sit ut repellendus tempore voluptas.", 325417939, 485, new DateTime(2024, 3, 25, 12, 55, 6, 328, DateTimeKind.Local).AddTicks(1422), "Turcotte - Cartwright" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Rowland Wunsch", "architecto", "Distinctio est iure aut voluptate debitis sed voluptas in autem qui dignissimos saepe qui aut minus et repellat distinctio dolorum.", 577314049, 928, new DateTime(2023, 9, 26, 21, 33, 32, 107, DateTimeKind.Local).AddTicks(7283), "Romaguera, Bechtelar and Ebert" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Karli Streich", "ullam", "http://lorempixel.com/640/480/sports", "Assumenda voluptas fugit voluptatum aut eum architecto neque distinctio placeat officiis omnis omnis pariatur natus accusantium sit blanditiis et est.", 579228917, 71, new DateTime(2024, 3, 24, 20, 23, 36, 778, DateTimeKind.Local).AddTicks(8289), "Okuneva, Marvin and Bergnaum" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Cornelius Kessler", "sit", "http://lorempixel.com/640/480/technics", "Omnis deserunt aut omnis eum neque doloribus provident qui non molestiae quos hic repudiandae in vel sit odio odio ducimus.", 490849452, 676, new DateTime(2023, 11, 15, 14, 31, 14, 546, DateTimeKind.Local).AddTicks(7490), "Fahey, Smitham and Cummerata" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Carleton Glover", "tempore", "http://lorempixel.com/640/480/sports", "Asperiores ut velit deserunt nam illo repellendus culpa nam ipsam ut ut velit commodi beatae facilis repudiandae aut quia praesentium.", 455429011, 157, new DateTime(2023, 12, 19, 8, 14, 17, 56, DateTimeKind.Local).AddTicks(2205), "Windler, Davis and Renner" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Shayna Wintheiser", "qui", "http://lorempixel.com/640/480/cats", "Temporibus maiores sapiente ullam vero eos quod nesciunt libero assumenda repudiandae quod dolores sit pariatur asperiores deserunt quibusdam tenetur iusto.", 951956282, 805, new DateTime(2023, 11, 25, 5, 6, 52, 868, DateTimeKind.Local).AddTicks(702), "McGlynn Inc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Bella Cremin", "libero", "Corrupti impedit enim omnis et quas provident quibusdam sint aperiam amet vitae repellendus et tempore dolores animi et rem impedit.", 331564040, 877, new DateTime(2024, 6, 2, 6, 58, 5, 453, DateTimeKind.Local).AddTicks(1059), "Reilly - Walter" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Kyler Brown", "commodi", "http://lorempixel.com/640/480/nature", "Ut excepturi eaque nostrum incidunt aut aut sequi reprehenderit quia laboriosam esse qui doloribus deserunt eos doloremque molestias veniam error.", 845312056, 265, new DateTime(2024, 2, 20, 17, 3, 54, 244, DateTimeKind.Local).AddTicks(297), "Mayert - Bergnaum" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Cassidy Gorczany", "quis", "http://lorempixel.com/640/480/cats", "Magnam animi quo nemo velit consectetur perspiciatis soluta ex repellat sed impedit sed voluptas sunt porro consequatur inventore sint tempora.", 222927099, 908, new DateTime(2023, 8, 31, 17, 20, 18, 595, DateTimeKind.Local).AddTicks(4551), "Schroeder - Gibson" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Desiree Kreiger", "commodi", "http://lorempixel.com/640/480/sports", "Consequatur dolor voluptatem voluptate porro corporis est ad culpa maiores mollitia nihil architecto dolorem maiores et ipsam dolorem omnis omnis.", 491901033, 625, new DateTime(2024, 4, 29, 13, 18, 13, 988, DateTimeKind.Local).AddTicks(1514), "Stamm Group" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Hulda Kozey", "dolor", "http://lorempixel.com/640/480/nightlife", "Animi quos ab similique sed non odio cupiditate aut dolorem culpa similique distinctio sunt aliquid sit nemo suscipit quia quasi.", 582527370, 574, new DateTime(2023, 8, 1, 21, 46, 1, 318, DateTimeKind.Local).AddTicks(784), "Paucek - Wolff" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Casey Orn", "dolorum", "http://lorempixel.com/640/480/nature", "Repellendus in voluptas eos quis quis qui officia aliquid ab ad id fugit et omnis fugit aut velit accusantium consequatur.", 925311058, 880, new DateTime(2024, 3, 12, 6, 11, 27, 104, DateTimeKind.Local).AddTicks(4282), "Murray, Stoltenberg and Gulgowski" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Tara Runolfsdottir", "et", "http://lorempixel.com/640/480/transport", "Omnis possimus et incidunt voluptatum animi enim asperiores reiciendis eligendi repudiandae possimus cupiditate sed consequatur corrupti dignissimos dolor id et.", 714289519, 568, new DateTime(2023, 7, 7, 6, 16, 9, 422, DateTimeKind.Local).AddTicks(4077), "Parisian - Waters" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Owen Willms", "et", "http://lorempixel.com/640/480/sports", "Quo repellat sapiente repudiandae optio voluptas quos et et consequuntur rerum ratione ullam ut quidem facilis odio et cum ab.", 755694841, 189, new DateTime(2024, 3, 12, 6, 6, 45, 271, DateTimeKind.Local).AddTicks(2650), "Torp, Murazik and Waters" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Martin Abernathy", "quo", "http://lorempixel.com/640/480/abstract", "Sed animi asperiores assumenda corrupti corporis consequatur sit vero architecto iusto nihil officia est iusto dolore ad aut cupiditate temporibus.", 839311989, 877, new DateTime(2023, 10, 26, 12, 11, 55, 114, DateTimeKind.Local).AddTicks(6641), "Haag Inc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Buster Daugherty", "est", "http://lorempixel.com/640/480/technics", "Tenetur et ratione nihil corrupti beatae est provident quasi reiciendis ducimus et et reiciendis velit saepe hic harum natus omnis.", 780294791, 996, new DateTime(2024, 1, 28, 22, 15, 9, 42, DateTimeKind.Local).AddTicks(5961), "Waters LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Lou Gerlach", "repellat", "http://lorempixel.com/640/480/people", "Facere ut aut dolore nulla eaque assumenda nobis a ut nihil est et pariatur ex autem eum aut porro quisquam.", 459365403, 122, new DateTime(2024, 5, 17, 17, 48, 41, 356, DateTimeKind.Local).AddTicks(7383), "Heaney - Leffler" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Louie Gaylord", "est", "http://lorempixel.com/640/480/cats", "Sunt qui amet sequi quis corrupti ipsum commodi natus eveniet et aut porro sunt rem enim velit sit reprehenderit dolores.", 994944345, 684, new DateTime(2023, 10, 21, 6, 36, 41, 40, DateTimeKind.Local).AddTicks(1368), "Lehner, Dach and Powlowski" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Earnestine Champlin", "ea", "Nostrum odit natus molestiae eos excepturi est laborum qui soluta et et vero quidem itaque accusantium qui odio magnam qui.", 448837080, 425, new DateTime(2024, 5, 17, 10, 11, 59, 322, DateTimeKind.Local).AddTicks(2431), "Effertz - Jacobi" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Eugenia Zboncak", "quo", "http://lorempixel.com/640/480/technics", "Id adipisci officia eum voluptatem praesentium veniam accusantium voluptate quod rerum voluptatibus animi quis non quia tempore iure omnis velit.", 926999087, 492, new DateTime(2024, 3, 1, 15, 39, 49, 38, DateTimeKind.Local).AddTicks(5334), "Stoltenberg Inc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Aurelie Tremblay", "vitae", "http://lorempixel.com/640/480/nature", "Odio necessitatibus numquam dicta sit architecto odio delectus dolores fuga tenetur consequatur et tenetur illo enim quo sit nihil aut.", 443161278, 976, new DateTime(2024, 4, 16, 22, 8, 41, 615, DateTimeKind.Local).AddTicks(7499), "Morar - Rau" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Asha Feeney", "harum", "http://lorempixel.com/640/480/city", "Id nesciunt non est sunt labore magnam non sunt unde adipisci labore accusamus fuga ut expedita sit atque magnam optio.", 135399083, 67, new DateTime(2023, 7, 31, 17, 41, 45, 274, DateTimeKind.Local).AddTicks(9409), "Howell, Deckow and Goyette" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Chloe Feil", "inventore", "http://lorempixel.com/640/480/nature", "In nihil sint facere odit vero modi dolorum minus sequi rerum labore eum doloremque quidem commodi est eligendi corrupti nihil.", 878028270, 723, new DateTime(2023, 11, 28, 17, 51, 29, 451, DateTimeKind.Local).AddTicks(3752), "Legros Group" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Donavon Huels", "consequatur", "http://lorempixel.com/640/480/fashion", "Aspernatur ipsam harum quia saepe nostrum at et magnam ea et voluptas mollitia deserunt in ut omnis omnis dicta praesentium.", 957111513, 846, new DateTime(2024, 2, 28, 5, 8, 24, 202, DateTimeKind.Local).AddTicks(8985), "Murazik and Sons" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Chaya Volkman", "alias", "http://lorempixel.com/640/480/abstract", "Magni aut iusto facilis et accusantium ut sit nulla culpa odit minus sit rerum dolores voluptatem sit molestias consequuntur eius.", 323313939, 718, new DateTime(2024, 4, 14, 3, 58, 53, 444, DateTimeKind.Local).AddTicks(9446), "Waelchi, Graham and Rempel" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Aubrey Gibson", "quaerat", "http://lorempixel.com/640/480/nightlife", "Et labore quisquam inventore omnis dignissimos et qui commodi repudiandae natus fugit cum unde ipsa cum nemo et voluptates est.", 751644864, 51, new DateTime(2024, 5, 7, 6, 42, 14, 292, DateTimeKind.Local).AddTicks(382), "Gottlieb LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Alysson O'Hara", "et", "http://lorempixel.com/640/480/sports", "Minima placeat non quo animi sed nihil ea occaecati optio occaecati quasi doloremque officiis et laboriosam vitae consequatur soluta pariatur.", 741311237, 755, new DateTime(2023, 7, 24, 16, 26, 26, 414, DateTimeKind.Local).AddTicks(6915), "Ward - Jerde" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Deonte Schuster", "excepturi", "http://lorempixel.com/640/480/city", "Voluptatem dolorem cupiditate dignissimos est voluptas dolores vel voluptatem harum a ea minus et dolor commodi ut quos enim in.", 963409169, 692, new DateTime(2023, 12, 29, 21, 8, 10, 772, DateTimeKind.Local).AddTicks(1353), "Lehner Inc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Gideon Aufderhar", "consectetur", "http://lorempixel.com/640/480/cats", "Eius nam nihil natus possimus ex omnis qui ut veritatis eligendi dolor corporis doloremque dolor aut eum cum esse quia.", 249386844, 477, new DateTime(2024, 4, 11, 10, 12, 42, 401, DateTimeKind.Local).AddTicks(5561), "Mueller Inc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Aurore Willms", "pariatur", "http://lorempixel.com/640/480/sports", "Voluptatum adipisci officiis excepturi repellat et veritatis nihil officiis maxime eos modi blanditiis delectus dicta aut ullam laboriosam sed harum.", 130473234, 407, new DateTime(2024, 3, 10, 12, 37, 24, 354, DateTimeKind.Local).AddTicks(3130), "Marquardt, Gleason and Lebsack" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Dee Langworth", "corporis", "http://lorempixel.com/640/480/sports", "Aliquam eaque consequatur commodi laudantium perferendis error dolorem saepe enim aut hic fugiat quisquam qui dolorem est qui deleniti est.", 653965727, 395, new DateTime(2023, 9, 14, 9, 39, 35, 139, DateTimeKind.Local).AddTicks(2821), "Robel - Boyer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Garrison Cassin", "libero", "http://lorempixel.com/640/480/food", "Tempore soluta corporis quos quam dicta rerum alias nam laborum voluptatibus non excepturi quam sunt sit ut non voluptatem consequatur.", 597557184, 608, new DateTime(2024, 1, 12, 15, 34, 57, 666, DateTimeKind.Local).AddTicks(2674), "Hilll Inc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Krystina Hessel", "quis", "http://lorempixel.com/640/480/fashion", "Quis nulla natus quas nesciunt ut quibusdam eveniet excepturi ad sit et ipsam cum itaque debitis similique non voluptatibus quia.", 705740303, 537, new DateTime(2023, 10, 8, 20, 46, 56, 380, DateTimeKind.Local).AddTicks(3803), "Carroll - Terry" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Glenna Douglas", "saepe", "http://lorempixel.com/640/480/technics", "Aut ipsa molestias iure saepe est quidem quaerat voluptatem fugit quia autem eum aperiam quae consequatur doloribus voluptatem quaerat dolor.", 498699046, 697, new DateTime(2023, 7, 14, 19, 5, 53, 377, DateTimeKind.Local).AddTicks(7148), "Gerhold - Pfannerstill" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Howard Hoeger", "et", "http://lorempixel.com/640/480/nature", "Ut et et consectetur itaque eos magni totam illum voluptatem quasi quia ut aliquam cumque unde consequatur nobis sint iste.", 512566138, 911, new DateTime(2023, 12, 10, 20, 40, 58, 886, DateTimeKind.Local).AddTicks(6103), "Cronin and Sons" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Kurt Gusikowski", "sit", "http://lorempixel.com/640/480/business", "Quod occaecati aut delectus qui hic veritatis voluptatum illo porro nisi repellendus sed facilis rerum est eius unde sit nisi.", 880502010, 664, new DateTime(2023, 11, 18, 10, 26, 15, 798, DateTimeKind.Local).AddTicks(3644), "Jenkins, Kuhn and Wiegand" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Zella Gorczany", "libero", "http://lorempixel.com/640/480/abstract", "Repellat quas distinctio et cumque et est ullam accusamus ducimus expedita natus ex perferendis ut adipisci omnis totam cum molestias.", 974567026, 396, new DateTime(2024, 6, 11, 23, 2, 5, 111, DateTimeKind.Local).AddTicks(9321), "Hansen Group" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Lacey O'Conner", "cumque", "http://lorempixel.com/640/480/transport", "Aut quam eum aut ex unde neque ut voluptatem id eos incidunt quia et sed atque quis voluptatem dolore hic.", 636498759, 347, new DateTime(2024, 1, 16, 19, 8, 20, 633, DateTimeKind.Local).AddTicks(9204), "Walsh, Lakin and Goyette" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Franz Abernathy", "pariatur", "http://lorempixel.com/640/480/nature", "Repellat itaque dolor ut cupiditate eveniet et tenetur ratione rem incidunt placeat sunt ipsa laudantium omnis asperiores vero ea iusto.", 874618322, 241, new DateTime(2023, 7, 30, 22, 4, 2, 738, DateTimeKind.Local).AddTicks(3974), "Gleichner Group" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Alexie Auer", "consequatur", "Inventore consequatur facilis ut ad labore ratione earum commodi vero exercitationem velit a dolorum molestiae repellat minima doloremque id qui.", 447464380, 638, new DateTime(2023, 7, 7, 5, 54, 33, 740, DateTimeKind.Local).AddTicks(5600), "Kertzmann Inc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Vaughn Botsford", "sed", "http://lorempixel.com/640/480/nightlife", "Iusto reiciendis dolores qui nihil quo quas sint architecto et aut qui ut est quia impedit et dolorem inventore facere.", 716419734, 792, new DateTime(2024, 4, 2, 11, 47, 16, 850, DateTimeKind.Local).AddTicks(9643), "Lebsack LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Collin Daniel", "similique", "http://lorempixel.com/640/480/cats", "Molestiae possimus sit in totam dignissimos aut eos quibusdam est enim vel maxime quam error voluptas est aspernatur ea ea.", 125273102, 485, new DateTime(2023, 9, 1, 5, 4, 41, 885, DateTimeKind.Local).AddTicks(3183), "Moen and Sons" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Reese Crist", "id", "http://lorempixel.com/640/480/technics", "Voluptates nobis blanditiis sapiente sit quo qui nostrum quis quam quia ex minima nisi nisi a voluptatibus placeat sunt deserunt.", 241016126, 684, new DateTime(2024, 2, 20, 14, 24, 43, 511, DateTimeKind.Local).AddTicks(9966), "Wunsch - Bogisich" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Vincenzo Mraz", "labore", "http://lorempixel.com/640/480/transport", "Aut doloribus blanditiis distinctio voluptates illo facilis eum nihil sed sed reprehenderit quas hic eos culpa aspernatur rerum ratione qui.", 351228631, 213, new DateTime(2024, 5, 2, 20, 35, 31, 205, DateTimeKind.Local).AddTicks(8336), "Legros and Sons" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Glenda Sporer", "labore", "http://lorempixel.com/640/480/fashion", "Tempora impedit quia ipsum sequi odio doloremque sed ut quidem aut iusto eveniet laudantium sequi provident possimus cupiditate voluptates fugit.", 419617548, 506, new DateTime(2024, 6, 3, 11, 20, 35, 803, DateTimeKind.Local).AddTicks(3612), "Grady and Sons" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Herbert Hansen", "recusandae", "http://lorempixel.com/640/480/abstract", "Beatae qui fuga nemo odit est ratione sunt qui ut accusantium maxime nesciunt assumenda tempore sit doloremque ea aut rerum.", 326969415, 373, new DateTime(2024, 1, 28, 12, 16, 15, 314, DateTimeKind.Local).AddTicks(7356), "Witting, Torp and Hagenes" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Carlos Simonis", "qui", "http://lorempixel.com/640/480/city", "Perferendis voluptatem aut nobis quas eos dolorem iusto nobis asperiores debitis sint totam saepe sint laudantium tempore cupiditate vero qui.", 563979765, 417, new DateTime(2023, 11, 9, 16, 16, 40, 680, DateTimeKind.Local).AddTicks(3475), "Davis - Jacobi" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Alek Jerde", "corporis", "http://lorempixel.com/640/480/city", "Deleniti quam voluptatum non est reiciendis quasi repellat sit nesciunt qui reprehenderit amet consequatur natus voluptatem quia non alias maxime.", 480202390, 369, new DateTime(2023, 9, 9, 20, 10, 58, 844, DateTimeKind.Local).AddTicks(8871), "Langworth - Lesch" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Patience Ferry", "odio", "http://lorempixel.com/640/480/business", "Velit nobis rerum iste rerum eum nesciunt totam rerum et ipsum autem non voluptatum quis molestias deserunt et eligendi ipsam.", 732908069, 772, new DateTime(2024, 2, 18, 13, 57, 52, 317, DateTimeKind.Local).AddTicks(1696), "Padberg - Boyer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Makayla Reinger", "voluptatum", "http://lorempixel.com/640/480/city", "Amet deleniti sit soluta quia distinctio praesentium commodi deleniti enim veritatis quia quo asperiores ut tenetur autem blanditiis adipisci voluptatem.", 149191478, 875, new DateTime(2024, 2, 14, 9, 9, 35, 46, DateTimeKind.Local).AddTicks(2914), "Stehr LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Rosamond Wuckert", "sint", "http://lorempixel.com/640/480/technics", "Saepe qui quibusdam quia sit sint tempore ex ex necessitatibus eum officiis placeat possimus sit tempore sit dolores assumenda amet.", 114863359, 81, new DateTime(2024, 5, 8, 13, 33, 1, 497, DateTimeKind.Local).AddTicks(3123), "McGlynn LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Jessie Emard", "voluptatem", "http://lorempixel.com/640/480/animals", "Vitae minima eum dolorem impedit soluta debitis vel sit voluptatibus ut cumque atque explicabo sunt qui dolorem numquam ut necessitatibus.", 903169412, 674, new DateTime(2023, 7, 24, 4, 25, 4, 891, DateTimeKind.Local).AddTicks(3505), "Gleason, Strosin and Ebert" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Orlando Treutel", "doloribus", "http://lorempixel.com/640/480/nightlife", "Autem repellendus enim aperiam odit nobis dolores suscipit dolorum nobis dolores maxime rem quas eum qui voluptas sed et aut.", 113616278, 419, new DateTime(2024, 3, 12, 23, 26, 21, 230, DateTimeKind.Local).AddTicks(8571), "Homenick - Wintheiser" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Elsa Maggio", "atque", "http://lorempixel.com/640/480/sports", "Soluta natus vel quia optio nulla et iste illo perspiciatis corrupti id alias voluptas vel maxime dolore aut eligendi qui.", 876567426, 702, new DateTime(2024, 3, 18, 2, 3, 41, 752, DateTimeKind.Local).AddTicks(2180), "Hane - Monahan" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Caleb Schimmel", "minima", "http://lorempixel.com/640/480/business", "Cumque consequatur ut est fugit eaque id ipsam dolores eos mollitia sed officiis expedita nam magnam nihil perspiciatis et aut.", 126358431, 568, new DateTime(2023, 8, 26, 9, 24, 7, 807, DateTimeKind.Local).AddTicks(8913), "Streich LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Jessy Waters", "officiis", "http://lorempixel.com/640/480/sports", "Dolores nesciunt totam dolores enim deleniti fuga iusto quia et sequi quisquam veritatis necessitatibus non dicta tempore aut laborum natus.", 478851603, 483, new DateTime(2023, 6, 24, 10, 2, 10, 903, DateTimeKind.Local).AddTicks(6576), "Shanahan, Stracke and Bernier" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Gordon Maggio", "quisquam", "http://lorempixel.com/640/480/city", "A aut ad porro est quibusdam occaecati et fugit aut explicabo modi culpa ut blanditiis accusamus quia et velit tenetur.", 663477765, 799, new DateTime(2024, 1, 18, 5, 20, 32, 847, DateTimeKind.Local).AddTicks(1441), "Schmidt, Simonis and Armstrong" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Darrin Gulgowski", "ad", "http://lorempixel.com/640/480/fashion", "Quod maxime laudantium omnis dolor et suscipit laboriosam dolorem ab rerum rerum occaecati quisquam eum libero nisi sunt error porro.", 173387023, 475, new DateTime(2023, 10, 31, 18, 34, 47, 502, DateTimeKind.Local).AddTicks(6700), "Hane - Abernathy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Fatima Stehr", "vel", "http://lorempixel.com/640/480/abstract", "Doloribus qui eveniet maiores eveniet sapiente qui voluptatem autem perspiciatis necessitatibus consequatur tempore doloribus dolore eius dolor rerum ab reiciendis.", 947978349, 745, new DateTime(2024, 3, 20, 20, 54, 42, 298, DateTimeKind.Local).AddTicks(3995), "Collins, Balistreri and Schulist" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Lon Boehm", "ut", "http://lorempixel.com/640/480/business", "Recusandae molestiae error qui vel id et impedit maxime rerum est occaecati praesentium earum et laboriosam nisi quis rerum consequuntur.", 564836539, 230, new DateTime(2024, 2, 1, 5, 22, 11, 303, DateTimeKind.Local).AddTicks(5301), "Ryan, Thiel and Fritsch" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Bartholome Shields", "officiis", "http://lorempixel.com/640/480/animals", "Aliquid esse sint vero recusandae dolores perspiciatis deserunt est omnis quisquam accusamus praesentium ullam distinctio dicta sit aut beatae pariatur.", 617897275, 80, new DateTime(2024, 2, 13, 23, 55, 28, 578, DateTimeKind.Local).AddTicks(946), "Schinner Group" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Buford Witting", "qui", "http://lorempixel.com/640/480/animals", "Alias rerum reprehenderit est rerum quos aut sed nisi provident dolores aut nesciunt et voluptatum reprehenderit reprehenderit alias quod vero.", 944332139, 92, new DateTime(2024, 6, 8, 17, 23, 6, 684, DateTimeKind.Local).AddTicks(5577), "Harvey LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Isaiah Pacocha", "nisi", "http://lorempixel.com/640/480/transport", "Incidunt quibusdam beatae nihil id ipsam quo nobis et voluptas necessitatibus nam eveniet nihil qui ut in voluptatem optio suscipit.", 185049001, 857, new DateTime(2023, 9, 29, 16, 33, 23, 922, DateTimeKind.Local).AddTicks(5487), "Nienow, Becker and Renner" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Alba Wiegand", "quia", "http://lorempixel.com/640/480/nightlife", "Sit quisquam qui corporis explicabo non quam suscipit odit pariatur quos officiis et architecto qui porro sit ab eligendi dolore.", 135782617, 415, new DateTime(2023, 8, 26, 13, 9, 12, 186, DateTimeKind.Local).AddTicks(8359), "Kovacek - Kuhn" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Hester Gleason", "hic", "http://lorempixel.com/640/480/food", "Repellat doloremque aperiam aperiam qui numquam est magnam sequi blanditiis quas atque veniam eos ex et aut ad adipisci fugit.", 162274900, 820, new DateTime(2023, 12, 26, 20, 35, 6, 264, DateTimeKind.Local).AddTicks(2756), "Watsica Inc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Asia Rice", "et", "http://lorempixel.com/640/480/sports", "Facere autem facilis sunt ducimus ipsam ab maiores est libero a rerum sit perspiciatis et perspiciatis enim et reprehenderit sit.", 551985507, 942, new DateTime(2023, 7, 30, 10, 34, 54, 526, DateTimeKind.Local).AddTicks(9184), "Champlin, Rau and Stamm" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "AUTHOR", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Simone Collier", "http://lorempixel.com/640/480/fashion", "Atque dicta qui ut soluta vero sint autem voluptas sequi sed rerum voluptas voluptas eveniet et est porro eaque voluptas.", 640345255, 116, new DateTime(2023, 12, 24, 6, 9, 17, 358, DateTimeKind.Local).AddTicks(4100), "Brakus, Rippin and Vandervort" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Joaquin Harvey", "repellendus", "http://lorempixel.com/640/480/cats", "Amet dolores accusantium excepturi rerum eaque ab omnis exercitationem cum ea eaque quam et omnis ut quaerat illo et laudantium.", 605138990, 779, new DateTime(2024, 4, 25, 5, 4, 21, 29, DateTimeKind.Local).AddTicks(2190), "Emard Inc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Lorenz Fisher", "ratione", "http://lorempixel.com/640/480/cats", "Odio illo error dolore magnam error est et porro consectetur cupiditate eius dolorem optio ut voluptatem architecto quia eos quia.", 153594386, 911, new DateTime(2024, 3, 13, 13, 30, 28, 983, DateTimeKind.Local).AddTicks(2538), "Baumbach - Kling" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Ahmad Jacobs", "at", "http://lorempixel.com/640/480/transport", "Tempore culpa adipisci esse nesciunt quia sunt ut delectus expedita veritatis nam excepturi vel perferendis voluptate corrupti est voluptatem sed.", 540808666, 768, new DateTime(2023, 10, 20, 1, 28, 36, 377, DateTimeKind.Local).AddTicks(2415), "Rodriguez - Turcotte" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Bradly Strosin", "voluptates", "Praesentium deserunt qui veniam eos ratione rerum tenetur non dolores excepturi ab sit porro sint odit assumenda fuga magni assumenda.", 456636937, 658, new DateTime(2023, 6, 22, 22, 27, 28, 434, DateTimeKind.Local).AddTicks(7192), "Veum Group" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Katrine Klocko", "quis", "http://lorempixel.com/640/480/fashion", "Rerum pariatur rem occaecati voluptatem ut doloribus at atque aliquid ut laboriosam vel laudantium dolores ut ullam aut voluptas id.", 330727913, 817, new DateTime(2024, 1, 27, 13, 0, 26, 401, DateTimeKind.Local).AddTicks(2505), "Bosco - Roob" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Jordi Nikolaus", "earum", "http://lorempixel.com/640/480/abstract", "Exercitationem fugiat voluptates quo et fugit ipsam culpa ipsa alias voluptates eligendi minus incidunt placeat eius omnis aut et odit.", 589509510, 262, new DateTime(2023, 11, 3, 4, 28, 54, 288, DateTimeKind.Local).AddTicks(510), "Gibson - Sipes" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Victor Marvin", "atque", "http://lorempixel.com/640/480/nature", "Consequatur repellendus ratione ad voluptas vel illo quisquam qui iusto cumque quae dignissimos et consequatur quasi perspiciatis qui aspernatur debitis.", 160857403, 677, new DateTime(2024, 1, 1, 2, 5, 44, 946, DateTimeKind.Local).AddTicks(4345), "Wyman, Gleichner and Predovic" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Johathan Mayert", "omnis", "http://lorempixel.com/640/480/city", "Similique voluptatem quo magni in quis voluptate doloremque rerum quia vel ut tenetur aspernatur eum tenetur repellat perspiciatis sint aliquid.", 337858267, 162, new DateTime(2023, 6, 26, 0, 42, 40, 852, DateTimeKind.Local).AddTicks(3930), "Abernathy - Murphy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Phyllis Cremin", "aut", "http://lorempixel.com/640/480/sports", "Aliquam sit et nemo tempora natus qui itaque deleniti magni nesciunt aut dignissimos minima nihil soluta est asperiores quasi nam.", 832865458, 269, new DateTime(2023, 8, 5, 21, 32, 7, 27, DateTimeKind.Local).AddTicks(4843), "Wisoky and Sons" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Daija Collier", "temporibus", "http://lorempixel.com/640/480/business", "Eveniet quidem quia autem amet ipsam id amet minima consectetur ea laborum aliquid odio laborum dicta nemo quia et voluptates.", 120918662, 412, new DateTime(2023, 8, 14, 21, 36, 48, 195, DateTimeKind.Local).AddTicks(1517), "Fahey - Kertzmann" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Dayne Huel", "qui", "Repellat ut cumque veniam ea blanditiis et ipsum ut qui cum laudantium et labore est animi sed at iusto quo.", 634849498, 863, new DateTime(2024, 2, 7, 8, 5, 10, 837, DateTimeKind.Local).AddTicks(1639), "Schulist, Ward and Kemmer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Sasha Kerluke", "porro", "http://lorempixel.com/640/480/animals", "Animi ad eum eligendi doloribus possimus dolore in amet amet beatae expedita totam incidunt quas vel molestiae eum ipsum libero.", 283181214, 496, new DateTime(2023, 8, 20, 6, 8, 42, 840, DateTimeKind.Local).AddTicks(4166), "Roob - Emmerich" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Abraham Lemke", "velit", "Architecto doloribus dolor voluptatibus aut corrupti sed et iure facilis totam laboriosam doloribus nulla possimus distinctio ipsum non quasi ut.", 261138113, 932, new DateTime(2024, 2, 14, 7, 13, 44, 999, DateTimeKind.Local).AddTicks(3827), "Howe LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Billy Cormier", "provident", "http://lorempixel.com/640/480/cats", "Est enim sint qui consequatur ea qui aperiam incidunt enim qui saepe sit et sit eos ipsam provident officia qui.", 460841448, 377, new DateTime(2023, 11, 20, 11, 31, 9, 572, DateTimeKind.Local).AddTicks(816), "Jerde, Hodkiewicz and Schamberger" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Vicky Berge", "illo", "http://lorempixel.com/640/480/animals", "Ratione et eum magnam ipsa sunt vel ut ut nostrum saepe ad earum natus adipisci eos pariatur architecto sint aut.", 787101472, 942, new DateTime(2024, 2, 21, 7, 48, 28, 156, DateTimeKind.Local).AddTicks(4542), "Mills, Schulist and Weimann" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Emil Romaguera", "quisquam", "http://lorempixel.com/640/480/animals", "Esse accusamus quidem laudantium nam a labore beatae ducimus enim culpa iure quasi enim cupiditate fugit qui repellendus dolorem odit.", 166555776, 873, new DateTime(2024, 2, 2, 6, 48, 40, 54, DateTimeKind.Local).AddTicks(9767), "Weissnat, Watsica and Hane" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Carleton Hagenes", "velit", "http://lorempixel.com/640/480/fashion", "Rem provident eius autem commodi corrupti perspiciatis quo voluptas earum rerum rerum sed voluptatem in velit facilis minima quia autem.", 343511952, 952, new DateTime(2023, 10, 31, 0, 29, 35, 966, DateTimeKind.Local).AddTicks(269), "Howell - Cremin" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Ernest Pacocha", "eaque", "http://lorempixel.com/640/480/city", "Voluptas repellendus est asperiores in iusto corporis voluptatem nemo et quis autem et ex minus aperiam debitis labore maiores sed.", 563557638, 967, new DateTime(2023, 8, 27, 17, 33, 46, 631, DateTimeKind.Local).AddTicks(799), "Harvey LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Elvera Cartwright", "aut", "http://lorempixel.com/640/480/abstract", "Consequatur aperiam quibusdam unde cum et nostrum fugiat ut ea quibusdam voluptatem non expedita ut quo aliquam et rerum explicabo.", 772543864, 69, new DateTime(2023, 10, 18, 0, 54, 7, 237, DateTimeKind.Local).AddTicks(2508), "Ortiz, Bartoletti and Stanton" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Jordan Stamm", "recusandae", "http://lorempixel.com/640/480/business", "Et ullam consequatur omnis delectus molestiae eveniet earum amet voluptatem dolorem molestiae iusto ullam earum quia sed molestiae et explicabo.", 787296053, 457, new DateTime(2023, 9, 4, 0, 21, 0, 988, DateTimeKind.Local).AddTicks(2779), "Tromp and Sons" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Peter Bashirian", "ducimus", "http://lorempixel.com/640/480/nature", "Dolores non vitae et earum blanditiis vitae praesentium quos porro eveniet deleniti beatae voluptatem ad voluptatum sed qui perferendis qui.", 177169724, 517, new DateTime(2023, 8, 13, 11, 46, 15, 317, DateTimeKind.Local).AddTicks(9652), "Tillman - Gislason" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Brook Feest", "autem", "http://lorempixel.com/640/480/food", "Voluptatem fuga modi et voluptatem earum qui reiciendis totam illum itaque cupiditate aliquid vero et iste ut non ut laudantium.", 608372290, 970, new DateTime(2023, 10, 16, 2, 20, 6, 306, DateTimeKind.Local).AddTicks(1662), "Mraz, Botsford and Jaskolski" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Jevon Williamson", "corporis", "http://lorempixel.com/640/480/business", "Aut adipisci ullam est expedita vitae vel et sed adipisci est distinctio veniam voluptas iure officia eum sit est eaque.", 453956261, 419, new DateTime(2023, 8, 30, 17, 55, 31, 613, DateTimeKind.Local).AddTicks(81), "Hammes, Langosh and Wiza" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Antwan Wuckert", "veniam", "Earum nesciunt iusto iusto id necessitatibus labore quia fugit repudiandae quisquam voluptatum fuga assumenda numquam ut non reiciendis sapiente voluptas.", 309992702, 621, new DateTime(2023, 11, 11, 12, 35, 30, 245, DateTimeKind.Local).AddTicks(221), "Reinger - Weissnat" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Angelo Walsh", "accusantium", "http://lorempixel.com/640/480/people", "Repellendus praesentium aut neque aperiam est dolorem cupiditate maxime dicta placeat aut qui aut libero quam repellat omnis iusto recusandae.", 150040109, 434, new DateTime(2023, 10, 20, 23, 32, 8, 332, DateTimeKind.Local).AddTicks(2633), "Stehr Inc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Giles Reichert", "eligendi", "http://lorempixel.com/640/480/cats", "Eum dolorem sequi amet doloribus laboriosam sint vitae rerum harum id natus autem necessitatibus harum recusandae cumque quae neque quo.", 325349025, 913, new DateTime(2024, 3, 17, 15, 41, 26, 37, DateTimeKind.Local).AddTicks(6683), "Bernhard - Powlowski" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Elvie Monahan", "omnis", "http://lorempixel.com/640/480/city", "Labore minima est et consectetur voluptatem ullam provident ad est et nulla fugiat quaerat dolores deserunt aut explicabo ex blanditiis.", 325519142, 325, new DateTime(2024, 2, 14, 0, 6, 33, 968, DateTimeKind.Local).AddTicks(4078), "Bernier Group" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Hiram Schaefer", "fugiat", "http://lorempixel.com/640/480/animals", "Doloribus natus voluptatem sint consequatur exercitationem exercitationem commodi quia corporis fugit neque totam eos et tempore sint suscipit voluptas cumque.", 547388664, 741, new DateTime(2023, 12, 16, 23, 9, 14, 280, DateTimeKind.Local).AddTicks(1199), "Daugherty, Botsford and Altenwerth" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Laron Goldner", "quod", "http://lorempixel.com/640/480/nightlife", "Et placeat quia ea in consequatur unde optio tempora repudiandae accusamus voluptas exercitationem accusamus et voluptas a ratione ipsam earum.", 205599035, 267, new DateTime(2023, 8, 9, 19, 22, 54, 900, DateTimeKind.Local).AddTicks(7534), "Pfeffer - Hettinger" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Dejuan Waters", "neque", "http://lorempixel.com/640/480/nightlife", "Delectus magnam aut error dolor exercitationem qui debitis aut eum nostrum alias maiores repudiandae eum et nemo exercitationem recusandae sit.", 437039200, 551, new DateTime(2023, 6, 26, 22, 20, 34, 272, DateTimeKind.Local).AddTicks(7766), "Bauch - Hegmann" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Eliza Mann", "veniam", "http://lorempixel.com/640/480/nature", "Quod quas ab incidunt ea ullam reiciendis velit dignissimos corrupti repellendus error natus nam ut quidem ducimus officiis ut debitis.", 525302048, 656, new DateTime(2024, 5, 12, 16, 14, 46, 12, DateTimeKind.Local).AddTicks(9010), "Jerde LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Elwyn White", "ut", "http://lorempixel.com/640/480/transport", "Possimus suscipit quia dolores sint nihil et saepe est reiciendis atque modi qui qui exercitationem hic quam eum ipsum qui.", 789992300, 933, new DateTime(2023, 9, 15, 16, 3, 7, 715, DateTimeKind.Local).AddTicks(3743), "Weissnat Inc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Elmer Hettinger", "adipisci", "http://lorempixel.com/640/480/transport", "Ipsam fugiat ducimus omnis est aliquid quo veniam autem molestias alias repellendus quia veniam et cupiditate error enim asperiores autem.", 151794424, 649, new DateTime(2024, 4, 20, 7, 52, 12, 827, DateTimeKind.Local).AddTicks(1712), "Effertz, Nicolas and Block" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Letitia Larkin", "accusamus", "http://lorempixel.com/640/480/fashion", "Similique ab rerum quis omnis nostrum et et enim minima voluptate dolor architecto repellat ex consequatur fugiat non quod explicabo.", 817086741, 81, new DateTime(2023, 10, 16, 10, 50, 19, 297, DateTimeKind.Local).AddTicks(661), "Franecki - Grant" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Jaquan Toy", "suscipit", "Alias ipsum occaecati facere quia sit quaerat dolores qui corporis sed voluptates officiis enim quidem doloribus quia neque corporis qui.", 910346169, 151, new DateTime(2023, 12, 7, 11, 28, 43, 895, DateTimeKind.Local).AddTicks(3406), "Torp, Olson and Ledner" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Conrad Wiegand", "vero", "http://lorempixel.com/640/480/animals", "Facilis voluptatibus ipsum velit sed deserunt doloribus placeat fugit nemo nisi a eos ut quidem est harum ratione sit quia.", 779361781, 152, new DateTime(2023, 10, 29, 1, 20, 14, 216, DateTimeKind.Local).AddTicks(7561), "Shanahan - Sawayn" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Hassan Kuhn", "facilis", "http://lorempixel.com/640/480/people", "Corporis quisquam repellendus eaque voluptates id quo necessitatibus aliquid eius porro exercitationem sit aliquid vitae praesentium nisi quod sit molestias.", 381911763, 119, new DateTime(2024, 5, 13, 14, 8, 55, 813, DateTimeKind.Local).AddTicks(4462), "Rosenbaum - Howe" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Jules Wiegand", "accusantium", "http://lorempixel.com/640/480/business", "Blanditiis libero accusantium nisi possimus sequi quam molestias aliquid modi ad ut recusandae est explicabo qui consequuntur qui iusto aperiam.", 996401248, 801, new DateTime(2023, 11, 1, 17, 27, 56, 818, DateTimeKind.Local).AddTicks(7020), "Aufderhar - Gorczany" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Ruthie Howe", "aliquam", "http://lorempixel.com/640/480/nature", "Molestiae vel quibusdam voluptas accusantium sit autem velit at cumque suscipit reprehenderit illum dolor molestiae maiores omnis nostrum fugiat laudantium.", 302739295, 514, new DateTime(2023, 9, 27, 12, 17, 22, 705, DateTimeKind.Local).AddTicks(7852), "Cormier LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Aniya Welch", "delectus", "Quasi minus adipisci iure sit est sit reiciendis voluptatem minima a quis natus magnam aliquam numquam animi exercitationem et praesentium.", 369094778, 583, new DateTime(2024, 1, 3, 22, 23, 2, 373, DateTimeKind.Local).AddTicks(1339), "Turcotte, Konopelski and Turner" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Roxanne Thompson", "repellendus", "http://lorempixel.com/640/480/people", "Sint voluptas molestias sint aut voluptatum rerum ipsa omnis quidem saepe rerum provident cumque facere sequi quasi et aut sunt.", 991058835, 684, new DateTime(2024, 2, 16, 2, 53, 9, 449, DateTimeKind.Local).AddTicks(669), "Mosciski and Sons" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Salvatore Ondricka", "qui", "http://lorempixel.com/640/480/fashion", "Aut omnis ad voluptatem et qui assumenda sed aut molestias consequuntur recusandae totam voluptatum dicta aut suscipit sequi autem dolor.", 467198733, 366, new DateTime(2024, 2, 17, 23, 20, 0, 40, DateTimeKind.Local).AddTicks(6370), "Waelchi and Sons" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Elinore Little", "optio", "http://lorempixel.com/640/480/cats", "Ullam consequatur molestias est minima laboriosam omnis similique magnam optio illum magni nesciunt sequi quasi vitae maiores corrupti et similique.", 899437181, 995, new DateTime(2023, 11, 21, 18, 56, 56, 823, DateTimeKind.Local).AddTicks(9824), "Wilderman, Wilderman and Luettgen" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Cristina Kunde", "tempore", "http://lorempixel.com/640/480/nature", "Est id quia at rem dolore enim est perspiciatis nisi in qui provident assumenda quia iure voluptates perspiciatis ullam in.", 837092921, 769, new DateTime(2023, 8, 10, 23, 16, 35, 62, DateTimeKind.Local).AddTicks(6326), "Sanford - Schiller" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Daren Denesik", "incidunt", "http://lorempixel.com/640/480/animals", "Veritatis consequuntur ut ut dicta maiores cumque exercitationem voluptas quibusdam nihil dicta odio saepe consequatur nesciunt dolor et atque molestiae.", 717883923, 538, new DateTime(2023, 8, 20, 5, 4, 20, 434, DateTimeKind.Local).AddTicks(3797), "Kessler, Simonis and Kshlerin" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Audrey Wilkinson", "enim", "http://lorempixel.com/640/480/business", "Praesentium ut nostrum consequatur quo saepe sunt aut quia ex enim alias laudantium et magni laboriosam eligendi aperiam rerum consequatur.", 328631835, 664, new DateTime(2023, 7, 22, 16, 4, 49, 934, DateTimeKind.Local).AddTicks(7671), "Jenkins - Haley" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Helmer Kuhlman", "aut", "http://lorempixel.com/640/480/cats", "Explicabo qui ducimus cupiditate rerum quia itaque accusantium quaerat rem ex odio dolor et dolorem et sit ea odio placeat.", 498607606, 923, new DateTime(2023, 9, 19, 14, 36, 19, 740, DateTimeKind.Local).AddTicks(5490), "Reinger, Green and Bins" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Veda Mraz", "eum", "http://lorempixel.com/640/480/sports", "Quasi est illum unde temporibus beatae omnis iste natus quisquam non optio voluptate quisquam maiores recusandae reiciendis dolorem qui commodi.", 818103179, 624, new DateTime(2023, 10, 30, 9, 52, 58, 141, DateTimeKind.Local).AddTicks(1337), "Legros - Effertz" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Devin Wunsch", "culpa", "http://lorempixel.com/640/480/cats", "Et ducimus ut nisi et repudiandae a assumenda consequatur cupiditate minima voluptatem laborum rerum qui sint qui totam unde ipsum.", 336758362, 197, new DateTime(2023, 11, 25, 20, 6, 36, 189, DateTimeKind.Local).AddTicks(282), "Blick, Ruecker and Mayer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Marques Tromp", "voluptas", "http://lorempixel.com/640/480/business", "Sed voluptatem in accusantium officia voluptatem sit autem esse minus non sed atque tempora ut deleniti dolores excepturi ipsa ea.", 899316811, 161, new DateTime(2023, 12, 28, 20, 16, 10, 985, DateTimeKind.Local).AddTicks(5545), "Waters, Langosh and Wisoky" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Dejuan Tromp", "consequatur", "http://lorempixel.com/640/480/city", "Exercitationem soluta molestiae vero veritatis similique voluptatem voluptas similique rem maiores vel eos veritatis est et quis vero vel nam.", 533180930, 410, new DateTime(2023, 12, 16, 14, 43, 25, 730, DateTimeKind.Local).AddTicks(4052), "Block Inc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Jordi Heller", "quos", "Quae alias officia quae laborum veniam nobis aut qui suscipit omnis exercitationem totam dolores et qui ut tempora et accusantium.", 812235245, 461, new DateTime(2024, 1, 10, 16, 29, 58, 983, DateTimeKind.Local).AddTicks(1077), "Kautzer and Sons" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Julie Rempel", "deserunt", "http://lorempixel.com/640/480/city", "Eos similique earum accusantium tempore consequatur ut debitis laborum tempora consectetur animi iure culpa unde qui est consequuntur nesciunt eos.", 905743485, 226, new DateTime(2023, 7, 2, 13, 54, 47, 327, DateTimeKind.Local).AddTicks(8577), "Hodkiewicz Inc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Freeman Reilly", "iste", "http://lorempixel.com/640/480/sports", "Beatae minus ut repudiandae officia autem vitae beatae id culpa deleniti qui blanditiis nam dignissimos quo repellat odit nihil voluptatem.", 149516215, 996, new DateTime(2024, 3, 12, 1, 35, 0, 348, DateTimeKind.Local).AddTicks(6231), "Rempel - Murray" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Verona Kulas", "architecto", "http://lorempixel.com/640/480/business", "Voluptas itaque rerum esse soluta maiores ab quo sint consequuntur occaecati in error animi numquam sint voluptatibus est sapiente qui.", 885359883, 189, new DateTime(2023, 9, 29, 22, 30, 13, 875, DateTimeKind.Local).AddTicks(2674), "Witting, Sawayn and Christiansen" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Dameon Jacobi", "eum", "http://lorempixel.com/640/480/abstract", "Expedita ut ratione vel iure quis nesciunt ut aut delectus tenetur dolorem quibusdam eaque repellat reiciendis et nostrum quis architecto.", 443754219, 379, new DateTime(2024, 3, 23, 4, 1, 10, 665, DateTimeKind.Local).AddTicks(3492), "Nicolas and Sons" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Ivy Casper", "provident", "http://lorempixel.com/640/480/nightlife", "Sunt ipsum quis perspiciatis dolorum accusantium dolorem qui dolor et magni non asperiores saepe eos voluptatum sed recusandae est nisi.", 691729683, 694, new DateTime(2024, 4, 20, 3, 13, 37, 66, DateTimeKind.Local).AddTicks(1069), "Bahringer and Sons" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Jimmy Kling", "pariatur", "http://lorempixel.com/640/480/sports", "Sed harum laudantium cupiditate dolores laudantium eligendi et quam et reiciendis explicabo sint itaque nemo fuga et est quibusdam repudiandae.", 176426366, 588, new DateTime(2023, 6, 25, 11, 57, 45, 717, DateTimeKind.Local).AddTicks(5546), "Cartwright, Hand and Heathcote" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Stacy Stoltenberg", "cum", "http://lorempixel.com/640/480/technics", "Illum consequatur magni ducimus ab necessitatibus eius totam animi expedita optio cupiditate et rerum veritatis sint sunt et ut est.", 344861615, 476, new DateTime(2024, 1, 31, 18, 1, 35, 673, DateTimeKind.Local).AddTicks(6061), "Miller, Reilly and Feest" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Mozell Hessel", "corrupti", "http://lorempixel.com/640/480/city", "Nam voluptatem nobis ut qui et et quam consequuntur quibusdam voluptates ut in animi eum eos tenetur voluptate cum culpa.", 374689772, 831, new DateTime(2023, 8, 12, 11, 16, 29, 543, DateTimeKind.Local).AddTicks(7152), "Marquardt and Sons" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Beth Steuber", "soluta", "http://lorempixel.com/640/480/food", "Deserunt laboriosam nobis quibusdam iure nobis et similique consectetur explicabo aut et qui quo nobis distinctio fugiat error ea aut.", 734286898, 887, new DateTime(2023, 9, 27, 4, 5, 37, 353, DateTimeKind.Local).AddTicks(8654), "Jaskolski - Borer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Heath Schulist", "quasi", "http://lorempixel.com/640/480/sports", "Aut sequi cupiditate dignissimos eum veniam et fugiat necessitatibus voluptas vitae porro voluptate velit praesentium blanditiis fugit soluta aut voluptas.", 366113326, 597, new DateTime(2024, 3, 23, 15, 57, 27, 784, DateTimeKind.Local).AddTicks(9917), "Robel - McCullough" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Bruce Ryan", "in", "http://lorempixel.com/640/480/abstract", "Repudiandae illum alias odio nulla voluptatibus voluptatum inventore ut occaecati esse mollitia natus eos quasi recusandae distinctio voluptates vel et.", 494723568, 242, new DateTime(2024, 4, 8, 20, 17, 3, 133, DateTimeKind.Local).AddTicks(8290), "Jast Group" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Alycia Cruickshank", "esse", "http://lorempixel.com/640/480/city", "Blanditiis nisi cumque dolor est consequatur eos error tempora ratione impedit quibusdam quia est unde consectetur quia nulla tempore numquam.", 676686782, 984, new DateTime(2023, 10, 18, 18, 47, 9, 771, DateTimeKind.Local).AddTicks(7750), "Hayes - Hand" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Kyler Pouros", "laboriosam", "http://lorempixel.com/640/480/fashion", "Placeat ipsam magni quia voluptates illum qui eos quisquam itaque explicabo cumque ut quisquam consequatur dicta dolor consectetur totam doloribus.", 418335231, 916, new DateTime(2023, 10, 22, 12, 0, 16, 44, DateTimeKind.Local).AddTicks(2456), "Pacocha - MacGyver" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Dewitt Hammes", "aut", "http://lorempixel.com/640/480/transport", "Voluptatem qui atque provident tempore sit perferendis sed et necessitatibus atque tempora sunt corrupti eos odit sunt voluptas repellat explicabo.", 552131495, 262, new DateTime(2023, 9, 9, 0, 38, 0, 804, DateTimeKind.Local).AddTicks(2425), "Hermiston and Sons" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Emmie Muller", "quas", "http://lorempixel.com/640/480/fashion", "Qui vero omnis ipsa labore totam eligendi reiciendis rerum rerum ab laboriosam molestiae ratione dolor est iure dolorem itaque rem.", 415776534, 554, new DateTime(2024, 1, 7, 6, 6, 8, 139, DateTimeKind.Local).AddTicks(4498), "Sauer LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Cleveland Welch", "nisi", "http://lorempixel.com/640/480/animals", "Voluptate nulla quas in deleniti ex sed eum et veritatis et accusamus asperiores sapiente architecto minus libero nobis reiciendis et.", 840594304, 163, new DateTime(2024, 2, 21, 6, 58, 52, 469, DateTimeKind.Local).AddTicks(2753), "Kuhn Group" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Kendall Braun", "possimus", "http://lorempixel.com/640/480/sports", "Fugit vel sunt esse impedit eius deserunt accusantium magni ab fugiat non et qui et nihil similique dolores aliquid qui.", 436642244, 151, new DateTime(2024, 6, 3, 14, 17, 40, 462, DateTimeKind.Local).AddTicks(8050), "Lowe Inc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Barry Monahan", "esse", "http://lorempixel.com/640/480/nightlife", "Cupiditate culpa mollitia omnis ut est facere voluptatem id dignissimos et voluptas non fugiat dignissimos mollitia expedita quidem delectus veritatis.", 614451971, 400, new DateTime(2023, 9, 3, 20, 47, 38, 593, DateTimeKind.Local).AddTicks(3824), "Barrows, Spinka and Moen" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Amelie Macejkovic", "et", "http://lorempixel.com/640/480/technics", "Atque omnis tempora molestiae odit numquam cupiditate sunt totam atque qui non vitae molestias deleniti maiores consequatur impedit non optio.", 148488973, 630, new DateTime(2023, 8, 11, 17, 56, 1, 52, DateTimeKind.Local).AddTicks(3448), "Medhurst, Dietrich and Schmeler" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Albert Wilkinson", "eaque", "http://lorempixel.com/640/480/abstract", "Distinctio et nemo doloremque pariatur sit odio enim et omnis fugiat nostrum impedit unde labore qui sit sunt quia quas.", 142893242, 863, new DateTime(2023, 7, 7, 16, 13, 56, 854, DateTimeKind.Local).AddTicks(9788), "Fadel - Mueller" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Francesco Morar", "aut", "Dicta omnis necessitatibus et qui facere totam quo sint aut non dolorem amet iste error odit sit perspiciatis voluptas ut.", 922446586, 915, new DateTime(2023, 10, 24, 14, 33, 37, 409, DateTimeKind.Local).AddTicks(7505), "Thiel, White and Mayert" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Vena Krajcik", "voluptatibus", "http://lorempixel.com/640/480/city", "Libero hic dolorem ea et eligendi quasi ab illum fugit quod et minima optio nihil ipsum numquam sit at laudantium.", 278040285, 313, new DateTime(2023, 9, 8, 18, 34, 29, 373, DateTimeKind.Local).AddTicks(8215), "Davis, Waters and Champlin" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Sasha Bogan", "cum", "http://lorempixel.com/640/480/fashion", "Ut pariatur consequatur ipsam nihil in velit voluptatum iste enim ut recusandae perferendis ut nihil voluptas sint laboriosam sapiente hic.", 670963916, 146, new DateTime(2023, 12, 4, 0, 35, 52, 819, DateTimeKind.Local).AddTicks(4205), "Bradtke - Bradtke" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Delphine Ondricka", "reiciendis", "http://lorempixel.com/640/480/food", "Atque corporis maxime dolorem pariatur amet labore ipsa vel velit consequatur molestias id autem accusantium sapiente vel eos deleniti cumque.", 944718754, 167, new DateTime(2023, 12, 11, 3, 47, 37, 413, DateTimeKind.Local).AddTicks(2376), "Mills - Satterfield" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Lorenza Luettgen", "doloremque", "http://lorempixel.com/640/480/business", "Nam expedita ratione similique esse autem perferendis cupiditate qui minus harum blanditiis eaque et qui recusandae dicta quasi in adipisci.", 270051331, 289, new DateTime(2023, 8, 23, 2, 49, 8, 644, DateTimeKind.Local).AddTicks(3268), "Hintz - Swaniawski" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Sylvia Herzog", "magnam", "http://lorempixel.com/640/480/cats", "Mollitia fugit quam consequatur perspiciatis maiores voluptatem corporis sunt dolores sunt magnam sapiente et impedit neque molestiae qui dolorem vitae.", 639111344, 550, new DateTime(2023, 9, 3, 8, 15, 57, 642, DateTimeKind.Local).AddTicks(4209), "Kutch - Wiegand" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Georgianna Johnston", "non", "http://lorempixel.com/640/480/cats", "Deleniti dolorem saepe magni eaque dolorem harum voluptate nostrum officia quaerat qui dolorem voluptate rerum cum qui nobis eveniet dignissimos.", 244431985, 914, new DateTime(2024, 5, 20, 17, 18, 4, 467, DateTimeKind.Local).AddTicks(4236), "Rogahn - Dare" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Cedrick Quitzon", "ea", "http://lorempixel.com/640/480/business", "Quo non exercitationem enim blanditiis rem eos assumenda facilis voluptatem velit perspiciatis fuga aliquam et sit ipsum voluptatem quia aspernatur.", 704805735, 385, new DateTime(2023, 9, 6, 0, 28, 14, 636, DateTimeKind.Local).AddTicks(4584), "Howell, Weissnat and Jones" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Lina Larkin", "amet", "http://lorempixel.com/640/480/people", "Consequatur architecto ab non iure et numquam eveniet saepe vero ut eius nisi repellat quos quas laborum consequatur porro voluptates.", 403879274, 535, new DateTime(2023, 7, 1, 23, 5, 46, 104, DateTimeKind.Local).AddTicks(5067), "Konopelski - Hartmann" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Jesse Deckow", "quis", "http://lorempixel.com/640/480/transport", "Ipsa tempora quasi temporibus voluptatibus sunt ipsam veritatis dolore maxime mollitia aliquid placeat dicta et accusantium soluta rerum officia ab.", 223688917, 534, new DateTime(2023, 8, 28, 8, 52, 18, 683, DateTimeKind.Local).AddTicks(7472), "Cole, Hayes and Veum" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Samir Turcotte", "saepe", "http://lorempixel.com/640/480/business", "Aut ut suscipit provident voluptatem esse quia unde debitis dicta minus et odio reiciendis deleniti facere qui id aut mollitia.", 175394973, 152, new DateTime(2023, 9, 19, 6, 24, 27, 994, DateTimeKind.Local).AddTicks(7479), "Hagenes - Kihn" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Brandy Murphy", "similique", "http://lorempixel.com/640/480/business", "Qui reprehenderit id est sint quae optio totam et omnis eveniet minima rerum necessitatibus consectetur sunt nisi inventore occaecati quo.", 568024228, 581, new DateTime(2023, 12, 28, 22, 8, 9, 622, DateTimeKind.Local).AddTicks(9067), "Pfannerstill, Barrows and Hessel" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Harold Collins", "aliquid", "http://lorempixel.com/640/480/nightlife", "Temporibus et et non aliquid et est et non modi aut quo pariatur et nulla ut quia quidem fugiat aliquam.", 461539763, 357, new DateTime(2023, 9, 3, 3, 40, 26, 875, DateTimeKind.Local).AddTicks(3717), "Pfeffer - Nikolaus" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Kenny Bradtke", "illum", "http://lorempixel.com/640/480/nature", "Voluptatibus et sint et commodi dolor labore libero culpa qui aperiam pariatur non quaerat nobis voluptatem voluptas explicabo et quaerat.", 641651659, 74, new DateTime(2024, 1, 12, 11, 54, 9, 311, DateTimeKind.Local).AddTicks(4653), "Grant - Wyman" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Cristina Hegmann", "odit", "http://lorempixel.com/640/480/business", "Est dolor rerum quod nisi rem repudiandae illo mollitia fugit deserunt quo aut voluptatem repellendus hic quia ut quia voluptatem.", 135728408, 301, new DateTime(2023, 9, 12, 6, 8, 16, 915, DateTimeKind.Local).AddTicks(9637), "Swaniawski Group" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Jeffrey Huel", "sint", "http://lorempixel.com/640/480/fashion", "Et nulla consequuntur quae atque eos accusantium dolor quis numquam numquam autem nihil delectus qui dolores dolores quo et autem.", 139987759, 494, new DateTime(2024, 4, 16, 21, 36, 21, 229, DateTimeKind.Local).AddTicks(9696), "Hyatt - Bergnaum" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Quentin Johns", "est", "http://lorempixel.com/640/480/technics", "Quo velit et quae totam quaerat exercitationem et rem temporibus omnis incidunt ut officia cupiditate rerum sit sed illo facilis.", 255445364, 215, new DateTime(2024, 2, 17, 16, 22, 6, 942, DateTimeKind.Local).AddTicks(1189), "Lockman, Hane and Kulas" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Betsy Gutkowski", "explicabo", "http://lorempixel.com/640/480/cats", "Sed deserunt et totam ut qui rerum praesentium autem ducimus ex quibusdam est dolorem delectus dolorem praesentium aut ea quos.", 886873545, 254, new DateTime(2023, 7, 30, 17, 12, 57, 646, DateTimeKind.Local).AddTicks(3522), "Mitchell Group" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Raymond Torphy", "quo", "http://lorempixel.com/640/480/cats", "Repudiandae quia hic rerum aliquid aspernatur nobis aut numquam rerum amet provident deserunt aut officia dicta dicta hic eius similique.", 484825689, 943, new DateTime(2023, 9, 20, 13, 43, 30, 671, DateTimeKind.Local).AddTicks(9933), "Stark, Hamill and DuBuque" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Martina Crona", "veniam", "http://lorempixel.com/640/480/fashion", "Non qui et vel est quidem voluptas voluptate harum labore corrupti nobis rem dolorum ut ut vel esse quia consequatur.", 746481693, 935, new DateTime(2023, 9, 16, 19, 36, 7, 27, DateTimeKind.Local).AddTicks(349), "Ernser, Corkery and Jast" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Faye Renner", "occaecati", "http://lorempixel.com/640/480/abstract", "Aut cupiditate facere at consequatur amet reprehenderit dolorum perspiciatis maiores totam iusto autem magni velit et vel labore magni sint.", 201512373, 505, new DateTime(2023, 6, 20, 1, 14, 42, 855, DateTimeKind.Local).AddTicks(9051), "Schinner LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Jan Bergnaum", "earum", "http://lorempixel.com/640/480/people", "Unde sit velit dolor sint veniam voluptas quasi quae ea corporis qui ut cum aspernatur aut quod voluptas voluptatem totam.", 920328111, 637, new DateTime(2023, 10, 16, 12, 44, 54, 780, DateTimeKind.Local).AddTicks(2660), "Mosciski - Bailey" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Cade Bayer", "inventore", "http://lorempixel.com/640/480/abstract", "Eaque quas inventore molestias reiciendis est harum et atque voluptatem ad atque nihil quaerat optio quod dolor eaque accusantium illo.", 470325144, 971, new DateTime(2023, 12, 27, 2, 45, 18, 982, DateTimeKind.Local).AddTicks(3281), "Bernhard, Fahey and Cartwright" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Bernie Schmeler", "eligendi", "http://lorempixel.com/640/480/city", "Recusandae voluptatem rem et ipsa provident nemo aut exercitationem quaerat consequatur id expedita quaerat neque temporibus corrupti quibusdam consectetur ratione.", 248269937, 687, new DateTime(2024, 1, 13, 13, 48, 28, 289, DateTimeKind.Local).AddTicks(9859), "Hermann, Hyatt and Hyatt" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Burnice Volkman", "corrupti", "http://lorempixel.com/640/480/food", "Odit delectus omnis similique ex praesentium voluptas qui deserunt rerum excepturi odit vel et quasi molestiae saepe ea ut et.", 268647512, 862, new DateTime(2023, 9, 13, 4, 19, 21, 383, DateTimeKind.Local).AddTicks(7429), "Christiansen Group" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Jerod Nolan", "error", "http://lorempixel.com/640/480/nature", "Aut illum debitis saepe mollitia qui perspiciatis facere commodi vitae molestiae quia cum dolores autem eum omnis dolore id quia.", 568804717, 173, new DateTime(2023, 7, 15, 9, 30, 42, 998, DateTimeKind.Local).AddTicks(3659), "Kuvalis, Casper and Schaefer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Hal Cartwright", "maxime", "http://lorempixel.com/640/480/business", "Animi et repellat quidem eos debitis eaque mollitia commodi dolorum qui eveniet molestiae debitis ut quia possimus molestiae vel ratione.", 101168636, 229, new DateTime(2024, 6, 3, 17, 43, 28, 78, DateTimeKind.Local).AddTicks(277), "Lakin, Reynolds and Parker" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "AUTHOR", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Princess Legros", "http://lorempixel.com/640/480/people", "Dolores voluptatum delectus porro aut qui recusandae ea laborum expedita voluptas eaque sit et nobis et maiores optio est voluptas.", 625603896, 606, new DateTime(2024, 4, 6, 14, 36, 0, 65, DateTimeKind.Local).AddTicks(1381), "Williamson Group" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Buster Collins", "totam", "http://lorempixel.com/640/480/technics", "Ab tenetur eos nihil non minus et maiores tenetur voluptatibus eligendi laudantium et ipsum blanditiis rem molestias harum officiis dolorum.", 680140906, 597, new DateTime(2023, 10, 15, 19, 29, 59, 702, DateTimeKind.Local).AddTicks(9027), "Moen - Mosciski" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Hailey Medhurst", "magnam", "http://lorempixel.com/640/480/nature", "Voluptatem odio consequatur consequuntur temporibus voluptates sed dolor voluptatem autem vel nihil ab sed cumque inventore perferendis saepe ut doloribus.", 544175228, 581, new DateTime(2024, 1, 13, 17, 52, 50, 978, DateTimeKind.Local).AddTicks(3837), "Fahey - Kassulke" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Brook Ankunding", "distinctio", "http://lorempixel.com/640/480/cats", "Aut qui odit optio aut aut explicabo et at fuga aut placeat harum neque magni repudiandae enim sunt ducimus culpa.", 404937735, 650, new DateTime(2024, 5, 18, 1, 2, 2, 160, DateTimeKind.Local).AddTicks(8973), "Bayer - Barton" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Willis Bartell", "optio", "Id quidem eveniet blanditiis porro id consequatur hic cumque unde itaque temporibus similique vitae ratione aspernatur sapiente dolorem quaerat dolor.", 722670085, 209, new DateTime(2023, 12, 7, 2, 23, 30, 55, DateTimeKind.Local).AddTicks(8598), "Armstrong Inc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Kraig Pagac", "eligendi", "http://lorempixel.com/640/480/abstract", "Ut est asperiores esse in ea nihil amet minima facilis et enim quia quasi dolor error laborum labore ut sit.", 280544257, 989, new DateTime(2024, 4, 10, 1, 36, 11, 136, DateTimeKind.Local).AddTicks(8796), "Kerluke LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Victoria Frami", "suscipit", "http://lorempixel.com/640/480/city", "Assumenda beatae ut minus voluptatum aut excepturi modi ut rerum vel nobis quo sint ut delectus eaque qui assumenda possimus.", 193000125, 731, new DateTime(2024, 6, 5, 23, 47, 40, 353, DateTimeKind.Local).AddTicks(3602), "Cruickshank, Thiel and Heller" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Rupert Oberbrunner", "nobis", "http://lorempixel.com/640/480/business", "Accusantium officia non est voluptas ut ratione est sapiente ad omnis modi ea inventore nisi debitis voluptas eveniet qui facere.", 717451259, 968, new DateTime(2024, 5, 31, 13, 30, 1, 788, DateTimeKind.Local).AddTicks(4202), "Lueilwitz, Deckow and Turcotte" });
        }
    }
}
