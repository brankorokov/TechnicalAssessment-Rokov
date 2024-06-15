using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechnicalAssessmentRokov.Migrations
{
    /// <inheritdoc />
    public partial class ChangingPubDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Myrtie Funk", "molestias", "http://lorempixel.com/640/480/sports", "Voluptas expedita suscipit autem excepturi in nulla porro quia amet non sit harum omnis qui quia pariatur ullam omnis est.", 514187047, 579, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Marquardt LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Kris Rolfson", "mollitia", "http://lorempixel.com/640/480/sports", "Aliquam veritatis error cupiditate reprehenderit voluptas rerum numquam dolor aut non minus aut reprehenderit quam maxime consequatur perferendis pariatur natus.", 356071543, 127, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "Jacobi - McKenzie" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Larry Veum", "hic", "http://lorempixel.com/640/480/nightlife", "Accusamus ducimus reiciendis voluptatibus doloremque laudantium molestias et sed et unde aspernatur a dolore molestiae adipisci aut reprehenderit harum maiores.", 812755481, 701, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), "Wolff and Sons" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Tatyana Denesik", "rerum", "http://lorempixel.com/640/480/business", "Enim sint vitae molestias rem dicta voluptatem sit beatae asperiores error blanditiis quibusdam quidem nobis soluta necessitatibus dolores et voluptates.", 954823417, 501, new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), "Parker and Sons" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Lucas Schmitt", "temporibus", "http://lorempixel.com/640/480/people", "Corporis expedita non aut architecto sequi iste ullam repellendus facilis aut ducimus rerum eius ipsa dolore recusandae repudiandae omnis in.", 884494087, 646, new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), "Klocko, Larson and Stracke" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Amaya Rodriguez", "dolorem", "http://lorempixel.com/640/480/business", "Repellendus et sed nisi nostrum et suscipit eum dignissimos voluptatibus natus laborum aut iste doloribus voluptatem sed maxime ex possimus.", 120639470, 828, new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), "Schmidt - Doyle" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Amelie Stiedemann", "odio", "http://lorempixel.com/640/480/business", "Totam doloribus hic laudantium quia omnis deserunt aut beatae exercitationem animi fugit qui id quaerat libero mollitia dolorem aut enim.", 909982199, 972, new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), "Boyer, Dach and Rogahn" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Herminio Marquardt", "dolorem", "Dolorem labore dolor rerum et temporibus consequatur accusamus neque earum hic aut eveniet aut voluptas non eaque deserunt aliquid nostrum.", 446516097, 979, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), "Hyatt LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Coty Osinski", "voluptatem", "http://lorempixel.com/640/480/fashion", "Dolorem vitae adipisci reprehenderit iure voluptate hic vel sint deleniti sapiente ut error eos ea sit soluta expedita officiis perferendis.", 202340512, 625, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "Cassin Group" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Linnie Ratke", "commodi", "http://lorempixel.com/640/480/nightlife", "Consequatur sit aut impedit quis cupiditate enim nemo dolor voluptatum sit cumque atque deserunt quia neque in consequatur consequuntur sunt.", 800329269, 326, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "Barrows LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Vella Conroy", "et", "Aut sunt nemo dolorem voluptatum quidem qui modi sed aut deleniti ex et velit debitis ea ullam voluptatem facilis perspiciatis.", 774319411, 699, new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), "Schuster Inc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Fred Kozey", "omnis", "http://lorempixel.com/640/480/sports", "Sed provident aliquam consequatur sit veritatis numquam enim sunt necessitatibus tenetur et animi dolores sunt ut itaque vero ut aut.", 960129571, 772, new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "Raynor - Bahringer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Dashawn Weissnat", "iusto", "http://lorempixel.com/640/480/food", "Quisquam magni tempora nihil doloribus accusamus ex earum eligendi est nihil vel laudantium sit non quia ut ea nam quis.", 291688035, 688, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "Feest, Bechtelar and Harvey" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Wiley Nikolaus", "saepe", "http://lorempixel.com/640/480/cats", "Rerum earum voluptatem odio et rem quis et necessitatibus aut sequi dolorum officia eos et autem veritatis ad illum molestias.", 118488235, 660, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Local), "Johnston, Connelly and Yost" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Barton McKenzie", "modi", "http://lorempixel.com/640/480/nature", "Voluptatem reprehenderit ullam neque vel explicabo et beatae voluptates praesentium neque sed tempora reiciendis amet velit autem delectus aut et.", 537150956, 566, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), "Emard LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Anthony Predovic", "non", "http://lorempixel.com/640/480/cats", "Qui delectus a aut occaecati nobis non consequatur sunt ipsum incidunt non tempore quis voluptatem laboriosam harum doloribus porro et.", 478717642, 221, new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Hansen, Haag and Koepp" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Cielo Schaefer", "magni", "http://lorempixel.com/640/480/nightlife", "Necessitatibus qui id hic eaque modi illo libero facilis molestiae maiores odit non totam impedit maiores nihil ut repellendus est.", 361173331, 75, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), "Ruecker LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Guido Feil", "vel", "http://lorempixel.com/640/480/sports", "Quia voluptatem veritatis eos temporibus exercitationem illum nesciunt sed molestias est consequatur alias sit numquam qui placeat facere explicabo qui.", 616487377, 508, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), "West LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Rhea Altenwerth", "vitae", "http://lorempixel.com/640/480/transport", "Repellendus quaerat ullam fugit id mollitia sunt ipsa ut quis quia aut fugiat a ducimus autem voluptatem modi quia provident.", 399098199, 252, new DateTime(2023, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Williamson, Brakus and Fay" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Kaylah Dach", "et", "http://lorempixel.com/640/480/transport", "Recusandae veniam et qui est sunt dignissimos amet autem vero modi cumque aspernatur possimus ut qui eos odio sint dolore.", 491672278, 153, new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), "Bosco - Emmerich" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Evie Fahey", "ratione", "http://lorempixel.com/640/480/city", "Architecto numquam et minus eveniet corrupti in omnis explicabo natus debitis repellat aut eveniet sunt eligendi minus asperiores repellat reiciendis.", 334692008, 129, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Swaniawski, Considine and Leuschke" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Jada Hand", "fugiat", "http://lorempixel.com/640/480/business", "Inventore reprehenderit soluta suscipit et impedit ea provident fugit molestiae et qui aut minima quae debitis id iusto quis consequatur.", 619268016, 232, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), "Kovacek, Becker and Ledner" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Veda Champlin", "laborum", "http://lorempixel.com/640/480/cats", "Et ea nesciunt eos accusamus occaecati minus neque quod ipsum voluptatibus ipsum officiis ducimus eius voluptatem laboriosam est quia illo.", 845764577, 307, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), "Jacobi - Wintheiser" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Duncan Marquardt", "rerum", "http://lorempixel.com/640/480/transport", "Vero quos tempore rerum dolorem officia ut et sit quas repellat facilis vel modi unde commodi incidunt voluptatem harum debitis.", 451312621, 923, new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Local), "Gutkowski - Grimes" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Weston Harvey", "voluptas", "http://lorempixel.com/640/480/cats", "Non consequatur et consequatur repellat vel sit quaerat quos in perferendis saepe rerum est quidem ea illo velit perferendis consequatur.", 208758833, 783, new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), "Heller LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Jessyca Olson", "ut", "http://lorempixel.com/640/480/business", "Aliquid porro sunt voluptatum voluptatem quam natus et quasi blanditiis ea excepturi voluptatem autem officia consequatur totam reprehenderit maiores quas.", 679090902, 652, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), "Abbott and Sons" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Gillian Considine", "eos", "http://lorempixel.com/640/480/transport", "Quia laboriosam corporis consequatur soluta in vitae expedita numquam id ut ut excepturi sapiente ea harum a minima et quaerat.", 808599163, 926, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "Gibson - Zieme" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Georgiana Hettinger", "at", "http://lorempixel.com/640/480/nature", "Reiciendis omnis provident aliquam enim id aut quia ab nemo voluptas minus quae commodi iusto id nihil nam dolorem in.", 253341151, 600, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "Heathcote, Torp and Keebler" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Jett Terry", "architecto", "http://lorempixel.com/640/480/business", "Voluptatibus et est animi ipsa officia dolores voluptate dolor qui numquam assumenda fuga aut mollitia dolorem labore odio cum laborum.", 602303897, 70, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "MacGyver - Aufderhar" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Israel Bahringer", "pariatur", "http://lorempixel.com/640/480/animals", "Dolores et facere inventore veniam quod consequuntur eum velit accusantium est rerum nihil repellendus recusandae non molestiae aut reprehenderit illum.", 203473191, 562, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Feil Inc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Lori Douglas", "omnis", "Alias aperiam reiciendis ut quia minima maxime aut est molestiae officiis rerum accusantium et sint iste necessitatibus enim dicta et.", 192215450, 556, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "Prohaska, Thompson and Fritsch" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Shaina Boyer", "velit", "http://lorempixel.com/640/480/business", "Ab quasi et tempora in dolores et facilis et atque accusantium harum et quam laboriosam ea sed quae veritatis eos.", 690702339, 858, new DateTime(2023, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), "Mayer Inc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Dock Fay", "sed", "http://lorempixel.com/640/480/city", "Est et ad nihil nostrum est voluptatem ex est nesciunt perspiciatis corporis odit similique similique nihil temporibus animi illo in.", 943338147, 960, new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), "Larson - Kozey" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Terrence Lowe", "deserunt", "http://lorempixel.com/640/480/technics", "Enim tempora molestiae et numquam ut quis occaecati repudiandae repellendus labore reprehenderit itaque alias aut sequi nam et libero qui.", 201396122, 964, new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), "Morar, Sporer and Schuppe" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Alison Luettgen", "quia", "http://lorempixel.com/640/480/nightlife", "Hic modi eos eos rerum corporis eaque neque aut harum in vero natus mollitia atque dolorem molestiae aliquid libero dolores.", 281938637, 416, new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), "O'Kon, Kertzmann and Weissnat" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Maximillia Ziemann", "qui", "http://lorempixel.com/640/480/people", "Laudantium tempora quod et dolorum dolores doloribus voluptate deserunt aut placeat error voluptatem eos quidem omnis molestiae ut dicta et.", 154831657, 538, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), "Lebsack Inc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Stefan Hoppe", "rem", "http://lorempixel.com/640/480/sports", "Officia cupiditate harum pariatur saepe asperiores enim architecto voluptates ut autem voluptatem cupiditate sed qui ea dolor sit quia quia.", 810754688, 107, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Kris, Abbott and Brown" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Zachary Davis", "ut", "Consectetur enim eos sint qui assumenda qui et voluptas et quod saepe et delectus ut earum aliquid non est omnis.", 612452714, 936, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "McCullough, Veum and Ankunding" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Willard Rath", "modi", "http://lorempixel.com/640/480/city", "Quia dolor deserunt sint qui distinctio natus et vel asperiores numquam ea ut sed saepe eos sint nulla fugit fuga.", 403588833, 864, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), "Nitzsche - Langworth" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Marisa Lindgren", "sunt", "http://lorempixel.com/640/480/abstract", "Officia est dolor iusto cumque et dolorum pariatur qui qui ut accusamus voluptatem et eligendi nam sunt eum molestiae eos.", 138399537, 739, new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), "Tremblay, Ferry and Kuhlman" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Pietro Nicolas", "minima", "http://lorempixel.com/640/480/animals", "Eos est optio expedita distinctio nihil consectetur fuga veniam consequatur voluptas provident aspernatur necessitatibus sed dolor maxime commodi et minima.", 891093629, 234, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "Macejkovic - Heaney" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Audreanne Konopelski", "enim", "http://lorempixel.com/640/480/food", "Odio vel enim provident distinctio officia tempora consequatur incidunt laboriosam consequuntur laborum earum architecto excepturi nulla iure sunt earum officia.", 873481154, 712, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), "Lemke, Hermiston and Robel" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Emelie Littel", "nihil", "http://lorempixel.com/640/480/food", "Accusantium rerum incidunt consequuntur aut rerum consequatur velit non et a et aliquam et eum iure temporibus sit quis eos.", 249070565, 501, new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "Mosciski, Deckow and Fay" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Rosalinda Kiehn", "temporibus", "http://lorempixel.com/640/480/people", "Non eos corrupti repudiandae molestiae velit tempore dolorem corporis nulla numquam consequatur ducimus porro eaque odio quas repudiandae iusto at.", 523692664, 477, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Local), "Morar Inc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Orpha Steuber", "et", "http://lorempixel.com/640/480/food", "At esse fugiat odit sit soluta in unde voluptas repellat voluptatem fugit aliquam esse itaque voluptatum adipisci adipisci ut nobis.", 701099206, 758, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Local), "Bins LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Alfred Heathcote", "illo", "http://lorempixel.com/640/480/animals", "Est voluptatem nihil excepturi vel quas asperiores magnam omnis cumque aut dignissimos iste nihil reprehenderit occaecati quos velit aut consequatur.", 507296668, 328, new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), "Jakubowski - Koch" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Marianne Nitzsche", "quis", "http://lorempixel.com/640/480/transport", "Optio est expedita rem voluptatum libero sunt suscipit ut dolorem possimus vitae occaecati laudantium expedita ipsum hic eveniet aut voluptates.", 593982012, 258, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Local), "Mosciski, Rempel and Wisozk" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Krystal Collier", "libero", "http://lorempixel.com/640/480/sports", "Non iure repellendus molestiae laudantium maxime voluptas totam vel qui nobis quia omnis ut consequatur est vel voluptas rerum velit.", 810456637, 241, new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), "McLaughlin Group" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Mitchel Yundt", "iure", "http://lorempixel.com/640/480/people", "Vel porro atque ut fuga et tempore ut sit ab perferendis repudiandae sed voluptatibus debitis asperiores hic quidem facilis nihil.", 275031763, 64, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), "Padberg Inc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Florian Wisozk", "assumenda", "http://lorempixel.com/640/480/transport", "Ipsa repudiandae eaque optio eaque aut ipsum saepe sed pariatur ab aut commodi molestiae tempora magnam voluptatem accusantium non adipisci.", 340803311, 415, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "Konopelski Group" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Tressie West", "dolor", "http://lorempixel.com/640/480/fashion", "Dolorum amet provident soluta explicabo est magnam mollitia repellendus culpa qui qui voluptatem velit qui laboriosam suscipit et doloremque commodi.", 317690954, 92, new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), "Mitchell, Labadie and Durgan" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Halle Braun", "vitae", "http://lorempixel.com/640/480/animals", "Non occaecati eos aliquam sint ut eos quia nulla unde aperiam sit quos ullam sit nihil quisquam sit sit rerum.", 476684938, 617, new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "Powlowski - Ortiz" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Arne Lynch", "qui", "http://lorempixel.com/640/480/nature", "Est dolore voluptates consequatur assumenda iusto cumque quia qui magni temporibus aut deserunt unde sequi pariatur perferendis aut maiores hic.", 492946060, 789, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), "Brown, Denesik and Stracke" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Susie D'Amore", "aut", "Quis laborum dolor deserunt nostrum nobis repudiandae sapiente vel repellendus occaecati pariatur aut nemo ipsa fugiat consequuntur id aut quibusdam.", 335641691, 113, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), "Crooks Inc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Alisa Green", "praesentium", "http://lorempixel.com/640/480/nature", "Minima aliquam tenetur natus voluptatem amet est accusamus ex esse fugiat velit repellendus a odit doloremque iure molestias pariatur debitis.", 588872371, 993, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), "McCullough, Huels and Pfeffer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Kaci Howell", "distinctio", "Sit doloremque nobis ipsum omnis non ut autem ipsam enim omnis eius architecto soluta et eligendi praesentium asperiores ut voluptatibus.", 539107635, 992, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), "Murphy, Dach and Glover" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Marques Boyer", "dolore", "Eos reprehenderit voluptas velit error nulla aut vel facere distinctio a magni deserunt voluptatibus quia quae sapiente repudiandae ex odit.", 706812473, 127, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "Steuber, Reilly and Lesch" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Vivian Reichert", "sapiente", "http://lorempixel.com/640/480/fashion", "Sed sequi aut et quis autem odio ut velit ut suscipit vel laudantium vel consectetur est in voluptatem repellat cupiditate.", 756654472, 415, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "Torp Group" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Dolores Witting", "beatae", "http://lorempixel.com/640/480/sports", "Aut qui nesciunt dolorum voluptates assumenda voluptatum aperiam atque vitae optio asperiores rerum aut suscipit velit consequatur modi doloremque hic.", 676128060, 331, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), "Considine, Green and Balistreri" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Madalyn Reinger", "omnis", "http://lorempixel.com/640/480/animals", "Dolorem vel quo neque rerum natus accusantium officia et perspiciatis aut accusantium eum commodi esse quis minus sed molestiae distinctio.", 696876316, 101, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), "Schowalter and Sons" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Aida Ryan", "facilis", "http://lorempixel.com/640/480/sports", "Quia velit qui quidem voluptatem et optio blanditiis doloremque deleniti accusamus quo eligendi quam occaecati iste maiores consequuntur aliquid qui.", 523775134, 211, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "Bailey Inc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Georgiana Goldner", "nostrum", "http://lorempixel.com/640/480/fashion", "Sunt quae et fugit id ut nihil aliquid accusantium ullam alias quis praesentium hic aspernatur quibusdam et adipisci voluptatem ipsum.", 554885586, 508, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "Hand and Sons" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Savanah Hayes", "eius", "http://lorempixel.com/640/480/nature", "Ut et officia et totam adipisci aspernatur mollitia quam vero provident fugiat expedita optio ut ut aut quo aspernatur occaecati.", 284357019, 470, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Hessel - Welch" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Delta Kshlerin", "quasi", "http://lorempixel.com/640/480/city", "Velit architecto et excepturi ratione impedit incidunt eaque nobis mollitia autem sed atque et molestias non porro quia nihil non.", 701294718, 656, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "Grimes, Walter and Stroman" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Toy Langosh", "deleniti", "http://lorempixel.com/640/480/business", "Autem amet eos reiciendis praesentium saepe est et omnis ipsum iure qui animi fugiat enim est eum omnis accusantium qui.", 568313752, 993, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "Becker and Sons" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Katheryn Anderson", "reiciendis", "http://lorempixel.com/640/480/abstract", "Facilis est id aperiam cumque placeat veritatis earum delectus fugit ad nesciunt mollitia vitae voluptatem est veniam non est consectetur.", 248466940, 453, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "Becker, Kilback and Ortiz" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Jamison Hand", "praesentium", "http://lorempixel.com/640/480/nature", "Quam blanditiis repellendus quo saepe labore officiis modi vero voluptatem incidunt sequi minima laborum ipsa modi ut magnam alias nihil.", 936365994, 868, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), "Windler Group" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Leilani Morissette", "omnis", "http://lorempixel.com/640/480/sports", "Culpa vitae blanditiis culpa debitis consequatur ut error minus voluptatem sint esse sint dolorem qui voluptas officia fuga animi modi.", 806432890, 209, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Schmeler and Sons" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Bulah Mills", "in", "http://lorempixel.com/640/480/food", "Neque voluptatem est perferendis itaque officiis sed iure cupiditate eius voluptas omnis repellendus provident repellendus veritatis culpa nihil tempora qui.", 992223471, 405, new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), "Kshlerin - Weissnat" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Regan Hane", "nostrum", "http://lorempixel.com/640/480/cats", "Perferendis labore doloribus odio dolorem sint explicabo et sapiente omnis et quam aliquid harum repudiandae molestias omnis quo a quaerat.", 632334840, 807, new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), "Sauer - Steuber" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Luella MacGyver", "quidem", "http://lorempixel.com/640/480/transport", "Corporis deleniti fugit dolorem animi incidunt aliquid dolore ex totam et vero laboriosam in deleniti qui fugit necessitatibus earum rerum.", 207619068, 547, new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Local), "Fay, Zulauf and Crona" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Simeon Kozey", "sed", "http://lorempixel.com/640/480/nature", "Odio molestiae vero dolores quis adipisci in expedita odio iusto tempora ut dolore et eum explicabo deleniti quia repudiandae laboriosam.", 181638688, 167, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Local), "Ernser Group" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Alverta Will", "deserunt", "http://lorempixel.com/640/480/sports", "Sequi ut mollitia rerum omnis omnis natus fugit aut error vel consequatur deserunt enim modi quia molestiae veniam harum ut.", 487060181, 288, new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Local), "Tremblay Inc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Tyra Boyle", "laborum", "http://lorempixel.com/640/480/food", "Excepturi eum aut autem quia molestiae ad enim laborum quae similique incidunt est autem dignissimos ut ea a id ipsum.", 830608765, 728, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "Kautzer Inc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Baron Weimann", "temporibus", "http://lorempixel.com/640/480/nature", "Qui sunt qui at incidunt amet sapiente ab temporibus sit enim sunt assumenda beatae dolor quas numquam est est sit.", 221237518, 168, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), "Howell - O'Conner" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Joan Harvey", "consectetur", "http://lorempixel.com/640/480/people", "Possimus itaque libero eum provident libero minus veniam qui voluptas ut et voluptas adipisci esse dignissimos quae dolorum debitis aspernatur.", 197759589, 397, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), "Weber, Kshlerin and Parisian" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Rex Kerluke", "nihil", "http://lorempixel.com/640/480/animals", "Quasi mollitia itaque ut nemo amet quia veritatis quo laborum hic vero aspernatur minima perspiciatis enim enim culpa perferendis est.", 723038179, 151, new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), "Smitham Group" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Adolph Cummings", "perferendis", "http://lorempixel.com/640/480/cats", "Quod dolorem harum omnis voluptatem molestiae fuga voluptas provident consequatur sit voluptate eius omnis delectus tempore veritatis odit eum id.", 909782644, 749, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "Harber - Klocko" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Luciano Pagac", "aliquam", "http://lorempixel.com/640/480/animals", "Velit nisi molestias perspiciatis sint enim consequuntur ut incidunt eligendi nulla nobis sit eos dolores vel perspiciatis commodi atque qui.", 102718140, 807, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), "O'Hara - Daniel" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Anthony Bradtke", "officiis", "http://lorempixel.com/640/480/animals", "Et architecto odit ipsum quis ad aut iusto labore voluptatem natus culpa non error et nulla enim id et qui.", 896415278, 286, new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), "Gaylord, Farrell and Fahey" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Orville Bogisich", "nesciunt", "Velit est officiis consequatur est et blanditiis officiis eum ut suscipit pariatur dolorem quis saepe voluptatem omnis consequuntur dolores at.", 567507244, 598, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), "Beer, McCullough and Pfeffer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Hubert Cronin", "architecto", "http://lorempixel.com/640/480/animals", "Atque ut commodi error blanditiis et sed magnam beatae dolorem minus corporis ut ab voluptatem facere aut tempore dolores iste.", 458794343, 349, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Local), "Jacobs Group" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Jermain Schroeder", "possimus", "http://lorempixel.com/640/480/sports", "Voluptatibus et dicta impedit saepe consequatur autem id minima sed tenetur consequuntur dicta sint blanditiis error deleniti ut optio sed.", 268655961, 390, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), "Zemlak, Price and Tromp" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Wilburn Boyle", "nulla", "http://lorempixel.com/640/480/food", "Nam veritatis vitae corporis iure veritatis quisquam et commodi dolor eos id animi ut et et modi magni ratione iusto.", 954705158, 653, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), "Boyer - Mann" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Chad Kuhn", "qui", "http://lorempixel.com/640/480/fashion", "Dolores veniam repellat consequatur molestias molestias et est culpa dolores quia iure ut aut voluptates omnis facere nostrum qui ea.", 592935523, 157, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), "Rippin - Roberts" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Bella Daniel", "veritatis", "http://lorempixel.com/640/480/cats", "Libero adipisci repellat sed ut eos sed non sint repudiandae placeat ab temporibus eos ut eum ipsam fugit et dolor.", 704159422, 565, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), "Abernathy, Swift and Oberbrunner" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Eugene Hand", "ex", "http://lorempixel.com/640/480/fashion", "Autem quod et exercitationem qui nihil iusto qui velit reiciendis ipsa est rerum unde possimus tempora assumenda dolor in labore.", 449142472, 369, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), "Romaguera Inc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Jacquelyn Hartmann", "animi", "Voluptas est modi a tenetur ullam tempore dolores quae aspernatur perferendis labore est ut cum nihil enim accusantium libero sed.", 583447334, 611, new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), "Hessel - Klein" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Polly Blick", "praesentium", "Nostrum sunt amet magni quae ipsa et perspiciatis ut neque repellendus ullam blanditiis occaecati modi reprehenderit impedit voluptates nostrum tempora.", 873926495, 930, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Stehr and Sons" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Theron Conroy", "dicta", "http://lorempixel.com/640/480/cats", "Vero et est accusamus eum eum accusantium reiciendis sed aliquid nemo quaerat numquam repellat ipsa dolore corrupti ipsam placeat nisi.", 796309189, 226, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "Swift - Lakin" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Berneice Ortiz", "a", "http://lorempixel.com/640/480/technics", "Molestiae tempora eveniet quidem qui consectetur quis est et dolores a ex nihil architecto est tempore voluptatem vel asperiores soluta.", 244112144, 557, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "Ebert, Graham and Lemke" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Abelardo Russel", "illo", "http://lorempixel.com/640/480/transport", "Itaque velit odio nesciunt eius alias reprehenderit laudantium dolores veniam et autem voluptatum asperiores quo ut fugiat iusto officia aut.", 913589488, 281, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), "Jacobson - Sanford" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Julius Ratke", "blanditiis", "http://lorempixel.com/640/480/nature", "Accusantium autem totam ut aperiam rerum in repellat aut magnam voluptatem libero qui dolores itaque ut quas aperiam voluptas hic.", 709595535, 57, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), "Jaskolski and Sons" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Mortimer Langosh", "minima", "http://lorempixel.com/640/480/food", "Repellat eius earum aspernatur ut dolorem accusantium sit laudantium minus ad aut labore dolorem amet ut officia omnis iusto delectus.", 592658102, 628, new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), "Bartell, Keebler and Sanford" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Madilyn Mosciski", "unde", "http://lorempixel.com/640/480/technics", "Ut et fugit assumenda eos voluptate reprehenderit quos minima qui et et ex est culpa dignissimos minus amet vitae voluptatem.", 368661875, 172, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Local), "Shields - Cruickshank" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Edgar Koepp", "repudiandae", "http://lorempixel.com/640/480/business", "Ut assumenda necessitatibus quas molestiae voluptas quasi suscipit voluptatem reprehenderit excepturi eos magni repellendus provident ut voluptas voluptas odio et.", 572976956, 110, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), "Schmidt, Feil and Tillman" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Chloe Bashirian", "odio", "http://lorempixel.com/640/480/abstract", "Nostrum porro aspernatur perspiciatis eos perferendis deleniti eaque et quisquam vel enim qui debitis voluptatem et et fugiat minima eligendi.", 165765343, 791, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), "Kiehn, Strosin and Treutel" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Blanche Sawayn", "iure", "http://lorempixel.com/640/480/nightlife", "Consequatur quibusdam voluptatem quo omnis necessitatibus at quam non vitae velit est ut nihil culpa officiis blanditiis corporis voluptatem quae.", 131088797, 239, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Local), "Boyle - Wyman" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Albertha Kuhn", "nisi", "http://lorempixel.com/640/480/cats", "Voluptatem placeat non non eos quo excepturi sunt sunt aperiam nulla non aut saepe aliquam rerum ipsum aliquid officia quaerat.", 112879716, 617, new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), "Gusikowski, Cummerata and Schowalter" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Willie Rogahn", "perferendis", "http://lorempixel.com/640/480/nightlife", "Non dolor esse sit corrupti nam ea aliquam dolores culpa iure minus consequatur placeat sequi suscipit fugit culpa et officiis.", 231098995, 758, new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), "Thiel Inc" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Elliott Greenholt", "non", "http://lorempixel.com/640/480/animals", "Consectetur aut eius qui excepturi voluptas fuga adipisci repellat quo autem sed voluptatibus numquam omnis magni suscipit et tempora soluta.", 224106338, 312, new DateTime(2023, 8, 15, 14, 27, 1, 79, DateTimeKind.Local).AddTicks(5146), "Hahn Group" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Halle Parisian", "qui", "http://lorempixel.com/640/480/city", "Asperiores ipsam sequi quasi aut a non dolores ullam ipsa repellendus quia harum aut vero perspiciatis totam hic occaecati illo.", 152344337, 257, new DateTime(2024, 2, 12, 7, 25, 32, 61, DateTimeKind.Local).AddTicks(2729), "Rowe LLC" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Jasen Cremin", "fugit", "Voluptas voluptas voluptatem minus id optio voluptatem similique magni odio fugiat culpa ut sed veritatis quia laudantium ut enim dolorem.", 590558325, 695, new DateTime(2023, 8, 6, 6, 10, 12, 158, DateTimeKind.Local).AddTicks(1274), "Auer - Price" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Glenda Zboncak", "fugiat", "Dicta dolores eum quo cupiditate adipisci dignissimos veniam omnis sit explicabo vel iusto eaque commodi perspiciatis non blanditiis sit porro.", 542502615, 560, new DateTime(2024, 5, 11, 6, 55, 53, 596, DateTimeKind.Local).AddTicks(1479), "Rowe - Abernathy" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Charley Kunze", "delectus", "http://lorempixel.com/640/480/business", "Iste aliquid illo voluptas eos facere ex expedita labore voluptate sunt amet molestiae cumque et omnis veritatis blanditiis provident distinctio.", 680157052, 520, new DateTime(2023, 10, 8, 17, 36, 42, 131, DateTimeKind.Local).AddTicks(2639), "Wolf, Berge and Casper" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Rowland Wunsch", "architecto", "http://lorempixel.com/640/480/nightlife", "Distinctio est iure aut voluptate debitis sed voluptas in autem qui dignissimos saepe qui aut minus et repellat distinctio dolorum.", 577314049, 928, new DateTime(2023, 9, 26, 21, 33, 32, 107, DateTimeKind.Local).AddTicks(7283), "Romaguera, Bechtelar and Ebert" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Carleton Glover", "tempore", "Asperiores ut velit deserunt nam illo repellendus culpa nam ipsam ut ut velit commodi beatae facilis repudiandae aut quia praesentium.", 455429011, 157, new DateTime(2023, 12, 19, 8, 14, 17, 56, DateTimeKind.Local).AddTicks(2205), "Windler, Davis and Renner" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Bella Cremin", "libero", "http://lorempixel.com/640/480/nature", "Corrupti impedit enim omnis et quas provident quibusdam sint aperiam amet vitae repellendus et tempore dolores animi et rem impedit.", 331564040, 877, new DateTime(2024, 6, 2, 6, 58, 5, 453, DateTimeKind.Local).AddTicks(1059), "Reilly - Walter" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Casey Orn", "dolorum", "Repellendus in voluptas eos quis quis qui officia aliquid ab ad id fugit et omnis fugit aut velit accusantium consequatur.", 925311058, 880, new DateTime(2024, 3, 12, 6, 11, 27, 104, DateTimeKind.Local).AddTicks(4282), "Murray, Stoltenberg and Gulgowski" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Earnestine Champlin", "ea", "http://lorempixel.com/640/480/cats", "Nostrum odit natus molestiae eos excepturi est laborum qui soluta et et vero quidem itaque accusantium qui odio magnam qui.", 448837080, 425, new DateTime(2024, 5, 17, 10, 11, 59, 322, DateTimeKind.Local).AddTicks(2431), "Effertz - Jacobi" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Deonte Schuster", "excepturi", "Voluptatem dolorem cupiditate dignissimos est voluptas dolores vel voluptatem harum a ea minus et dolor commodi ut quos enim in.", 963409169, 692, new DateTime(2023, 12, 29, 21, 8, 10, 772, DateTimeKind.Local).AddTicks(1353), "Lehner Inc" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Aurore Willms", "pariatur", "Voluptatum adipisci officiis excepturi repellat et veritatis nihil officiis maxime eos modi blanditiis delectus dicta aut ullam laboriosam sed harum.", 130473234, 407, new DateTime(2024, 3, 10, 12, 37, 24, 354, DateTimeKind.Local).AddTicks(3130), "Marquardt, Gleason and Lebsack" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Dee Langworth", "corporis", "Aliquam eaque consequatur commodi laudantium perferendis error dolorem saepe enim aut hic fugiat quisquam qui dolorem est qui deleniti est.", 653965727, 395, new DateTime(2023, 9, 14, 9, 39, 35, 139, DateTimeKind.Local).AddTicks(2821), "Robel - Boyer" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Alexie Auer", "consequatur", "http://lorempixel.com/640/480/nature", "Inventore consequatur facilis ut ad labore ratione earum commodi vero exercitationem velit a dolorum molestiae repellat minima doloremque id qui.", 447464380, 638, new DateTime(2023, 7, 7, 5, 54, 33, 740, DateTimeKind.Local).AddTicks(5600), "Kertzmann Inc" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Caleb Schimmel", "minima", "Cumque consequatur ut est fugit eaque id ipsam dolores eos mollitia sed officiis expedita nam magnam nihil perspiciatis et aut.", 126358431, 568, new DateTime(2023, 8, 26, 9, 24, 7, 807, DateTimeKind.Local).AddTicks(8913), "Streich LLC" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Buford Witting", "qui", "Alias rerum reprehenderit est rerum quos aut sed nisi provident dolores aut nesciunt et voluptatum reprehenderit reprehenderit alias quod vero.", 944332139, 92, new DateTime(2024, 6, 8, 17, 23, 6, 684, DateTimeKind.Local).AddTicks(5577), "Harvey LLC" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Isaiah Pacocha", "nisi", "Incidunt quibusdam beatae nihil id ipsam quo nobis et voluptas necessitatibus nam eveniet nihil qui ut in voluptatem optio suscipit.", 185049001, 857, new DateTime(2023, 9, 29, 16, 33, 23, 922, DateTimeKind.Local).AddTicks(5487), "Nienow, Becker and Renner" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Simone Collier", "voluptatibus", "http://lorempixel.com/640/480/fashion", "Atque dicta qui ut soluta vero sint autem voluptas sequi sed rerum voluptas voluptas eveniet et est porro eaque voluptas.", 640345255, 116, new DateTime(2023, 12, 24, 6, 9, 17, 358, DateTimeKind.Local).AddTicks(4100), "Brakus, Rippin and Vandervort" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Bradly Strosin", "voluptates", "http://lorempixel.com/640/480/fashion", "Praesentium deserunt qui veniam eos ratione rerum tenetur non dolores excepturi ab sit porro sint odit assumenda fuga magni assumenda.", 456636937, 658, new DateTime(2023, 6, 22, 22, 27, 28, 434, DateTimeKind.Local).AddTicks(7192), "Veum Group" });

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
    }
}
