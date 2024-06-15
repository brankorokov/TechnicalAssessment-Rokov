using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechnicalAssessmentRokov.Migrations
{
    /// <inheritdoc />
    public partial class BookTitle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TITLE",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Chaya Ebert", "voluptatem", "http://lorempixel.com/640/480/nightlife", "Velit libero et ea quia atque omnis illum id voluptatem in id est sunt qui porro ducimus ut qui facere.", 719112186, 285, new DateTime(2023, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), "Schinner and Sons", "SMS Future Fantastic Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Toni Dibbert", "est", "Ducimus reprehenderit eligendi consequuntur ut minima incidunt facere ducimus tempora et quis asperiores sed assumenda quasi est iste doloribus veritatis.", 620981663, 709, new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), "Reichert, Rice and Fay", "North Korean Won Assistant Triple-buffered" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Cecilia Toy", "tempora", "http://lorempixel.com/640/480/animals", "Hic est possimus quo sunt magni nostrum non asperiores illum rem porro illum iure quia neque nihil sequi saepe corporis.", 156016180, 664, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "Lakin LLC", "Synchronised Customer generate" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rebeka Feeney", "ab", "http://lorempixel.com/640/480/cats", "Voluptas eum quam quis cupiditate quos itaque quia temporibus molestiae eligendi eius alias dolorem laboriosam quis aliquid quos necessitatibus quae.", 186794475, 565, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), "Schaefer, Fritsch and Wehner", "Washington synthesizing capacitor" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kay Hirthe", "et", "http://lorempixel.com/640/480/cats", "Voluptate sed dolores inventore consequatur autem modi velit fugiat praesentium assumenda qui iste minus est sint dolorem voluptatibus hic necessitatibus.", 447083779, 781, new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), "Schmitt, Mosciski and Daugherty", "International Borders Checking Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Shany Schamberger", "est", "http://lorempixel.com/640/480/nature", "Nihil in sint ea rerum dolorem dolorum et ut et consequuntur autem accusamus omnis sequi odio laborum sed asperiores sit.", 832943868, 273, new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), "Raynor and Sons", "Myanmar ability Tasty Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Arturo Bednar", "odit", "http://lorempixel.com/640/480/transport", "Minus dicta eius illum maiores assumenda repellendus corporis molestias enim molestiae qui velit ipsa tenetur itaque molestiae perferendis sit eligendi.", 703592172, 592, new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "Kutch, Harvey and Little", "Corners Regional Home & Industrial" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ulises Lockman", "expedita", "Dolor sint sit enim sit facilis fuga consequatur magni tenetur inventore ipsum eius est sed distinctio nostrum quia ab dolorem.", 478710962, 451, new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), "Kuphal - McGlynn", "metrics Neck violet" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Berneice Runolfsdottir", "distinctio", "http://lorempixel.com/640/480/animals", "Reiciendis et repudiandae sed repellendus debitis alias consequuntur et exercitationem et cum molestiae officiis dignissimos et vel in accusantium et.", 407407585, 436, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), "Gorczany - Kuphal", "Awesome Concrete Shirt Refined open-source" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Geovanni Stokes", "ab", "http://lorempixel.com/640/480/fashion", "Temporibus suscipit sit iure vitae ipsa veritatis non magni aut corporis nam autem natus aut totam dolore sunt non fuga.", 820533879, 501, new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), "Johnson, Krajcik and Breitenberg", "Zimbabwe Stand-alone Producer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mathias King", "unde", "Necessitatibus dolorem inventore similique in quaerat adipisci fugit saepe quia sit placeat distinctio molestiae repellendus quam vero saepe in natus.", 814037030, 125, new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), "Hansen, Legros and Jerde", "Fork card Group" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Viviane Emard", "ut", "http://lorempixel.com/640/480/city", "Dolor omnis praesentium est aut possimus iste tenetur nemo nostrum aut ab deleniti repellendus sint odio qui voluptas eos eligendi.", 716425415, 686, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "Goyette, Will and Fay", "Cliffs functionalities overriding" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Britney Parker", "impedit", "http://lorempixel.com/640/480/nature", "Voluptas magnam eos consequatur quisquam perferendis eaque eveniet quos voluptatem et eum iste aut voluptatem modi ut tempora et est.", 724375439, 91, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "Ziemann LLC", "generate programming Ways" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ulices Keeling", "quia", "http://lorempixel.com/640/480/transport", "Culpa et est asperiores eum dolorum dignissimos veniam expedita repellat reiciendis fuga reiciendis aut autem quasi at neque est est.", 553362131, 988, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "Parker - Prohaska", "Cape Verde Escudo uniform Rupiah" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Neha Cartwright", "suscipit", "http://lorempixel.com/640/480/transport", "Debitis culpa neque ducimus deleniti quis perspiciatis occaecati temporibus et non occaecati a voluptas eum maiores cum et et cum.", 291730208, 827, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Walter Group", "productize SMS Implementation" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jarred Durgan", "facere", "http://lorempixel.com/640/480/business", "Qui saepe est eum iure dignissimos nam facilis sequi odio praesentium rerum soluta deleniti ut hic consequatur distinctio ex eum.", 540684635, 849, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "Batz and Sons", "4th generation Turnpike Home & Outdoors" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLISHER", "TITLE" },
                values: new object[] { "Mattie Bayer", "voluptate", "http://lorempixel.com/640/480/nature", "Maiores in sit ad et doloribus eveniet dicta iusto et eaque delectus ut non quidem numquam dolorem eaque dolore voluptates.", 676104445, 189, "Beier Inc", "Course open-source Chief" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Heber Balistreri", "veritatis", "http://lorempixel.com/640/480/nightlife", "Aut nulla facilis quas quae doloremque est soluta aperiam qui provident aut asperiores ab optio consequatur numquam maxime nihil illo.", 536269419, 273, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), "Donnelly, Torphy and Bogisich", "ADP synergize seize" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Delia Considine", "quisquam", "http://lorempixel.com/640/480/technics", "Sunt est numquam est aut voluptas fuga tempora repellat deleniti impedit asperiores similique a corrupti ullam sit labore debitis illo.", 717254092, 74, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), "Gerlach Inc", "technologies Borders e-business" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Brianne Goodwin", "quo", "http://lorempixel.com/640/480/technics", "Itaque totam dicta vel harum dicta occaecati beatae quisquam veritatis accusantium ipsum dolorem facilis dolore id porro nobis quis architecto.", 710968872, 720, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "Fritsch, Farrell and Weimann", "Handcrafted Plastic Gloves Supervisor Rustic Soft Shirt" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Chelsie Anderson", "reiciendis", "http://lorempixel.com/640/480/nightlife", "Minima voluptate aut esse aut ut voluptate accusamus sed et ducimus vitae et excepturi corrupti magnam explicabo est et quia.", 379662337, 810, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), "Becker, Schiller and Schinner", "International Switchable Ranch" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Berneice Strosin", "aut", "http://lorempixel.com/640/480/people", "Non sequi quia qui fugit explicabo facilis impedit ut harum nisi eum eos quae unde accusantium qui laborum est necessitatibus.", 805785502, 313, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "Bergnaum Inc", "Industrial, Sports & Music Organic Intelligent Concrete Bacon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Yoshiko Herzog", "exercitationem", "http://lorempixel.com/640/480/animals", "Tempore deleniti ut similique qui ex totam vel laboriosam fugit sint beatae laborum saepe sit et non laborum ipsum quia.", 802578984, 893, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "Armstrong, Strosin and Hamill", "firewall Intelligent Rubber Soap Borders" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Turner Kirlin", "laboriosam", "http://lorempixel.com/640/480/cats", "Quo tenetur et porro et autem cum cum ea quia labore voluptatibus corrupti id vitae voluptatibus molestias ad vitae distinctio.", 176480398, 925, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Local), "Langworth, Swift and Pfeffer", "COM Regional THX" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Juliet Collins", "minima", "http://lorempixel.com/640/480/fashion", "Tempore repellat harum sequi non beatae corporis reiciendis hic corrupti odio corrupti laboriosam doloribus soluta et dolore molestiae laudantium provident.", 676026729, 123, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Local), "Kunde - Schimmel", "Buckinghamshire out-of-the-box SQL" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Madeline Grady", "doloribus", "http://lorempixel.com/640/480/city", "Et praesentium voluptatem et sit id quasi beatae dignissimos provident occaecati aut enim consequuntur at error beatae maiores aut culpa.", 520297380, 88, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), "Lesch, Reinger and McLaughlin", "deposit Customer bluetooth" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Deven Smith", "saepe", "Esse aut et et consequuntur suscipit similique qui aperiam voluptate fugiat sed illum rerum blanditiis asperiores iure eum dolorum et.", 428713386, 877, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "McKenzie - Donnelly", "sensor 24/365 cyan" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lourdes Boyer", "sed", "http://lorempixel.com/640/480/nightlife", "A optio praesentium ducimus consequatur esse tempora velit ab aut ex veritatis quia unde voluptatibus ullam labore accusantium exercitationem suscipit.", 117226115, 807, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), "Trantow, Schmitt and Tromp", "white Handmade Plastic" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Bart Borer", "vero", "http://lorempixel.com/640/480/transport", "Error iusto ex dolores autem dolores doloremque rerum officiis ipsam corrupti dicta cum sed a ab aut delectus id ex.", 698019180, 870, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Boyer LLC", "maroon Money Market Account Gorgeous" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Gayle Watsica", "minus", "http://lorempixel.com/640/480/abstract", "Dolorem laboriosam aperiam accusamus molestias hic hic quo reprehenderit et laborum dolores velit et vero rerum voluptatem quisquam aspernatur voluptatem.", 535610386, 358, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Local), "Nader LLC", "connect Sierra Leone Berkshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rene Lakin", "officia", "http://lorempixel.com/640/480/city", "Illum tempora iusto veritatis provident ipsa optio sint quia quo nesciunt magnam ea praesentium illo sed perspiciatis eum sint aut.", 396372741, 913, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Local), "Kautzer - Gerhold", "Tenge scalable Garden" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Deron Konopelski", "praesentium", "http://lorempixel.com/640/480/food", "Quia illum et asperiores iste corporis et et quia doloremque nam eos culpa dolor molestias temporibus natus veniam sunt magni.", 807562640, 559, new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), "Schamberger, Trantow and Flatley", "recontextualize wireless platforms" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jasper Rolfson", "cumque", "http://lorempixel.com/640/480/sports", "Dolore dolores commodi voluptate nisi cumque quia dolorem illum odio molestiae saepe est iure et necessitatibus consequatur eveniet unde et.", 763292021, 111, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), "Terry, Kerluke and Emmerich", "Cambridgeshire Kids, Music & Electronics Rubber" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Tianna Balistreri", "nam", "http://lorempixel.com/640/480/food", "Ullam inventore quod mollitia qui non veritatis consectetur corporis sit in non tempore doloremque maiores eum adipisci optio fugit nobis.", 349484663, 463, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), "Pouros - Klein", "application Unbranded Cotton Car Freeway" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lucinda Paucek", "veniam", "http://lorempixel.com/640/480/fashion", "Dicta minus quia maiores iusto sapiente est dolores deserunt ut veniam qui ut qui magnam libero rem quae dolorem sunt.", 239865901, 764, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "Dooley - Klein", "bottom-line Awesome Wooden Shoes Buckinghamshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Vince Zieme", "necessitatibus", "Sequi temporibus consequatur omnis eos atque consequatur earum ut qui ut similique quo aut et incidunt et totam quod laboriosam.", 114993966, 266, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "Schneider - Wolf", "Sleek Steel Chips Reactive Monitored" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Moises Cronin", "corrupti", "http://lorempixel.com/640/480/nightlife", "Id temporibus quam delectus natus expedita aut eos eos nihil asperiores laborum minima dolorem quos enim deleniti velit debitis laboriosam.", 556990950, 479, new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), "Metz - Lubowitz", "Cotton Small Cotton Pizza Re-engineered" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Bianka O'Hara", "necessitatibus", "http://lorempixel.com/640/480/cats", "Tempora fuga sapiente quia quia quia nihil qui quae eveniet sint et autem quo enim non voluptatem excepturi expedita sint.", 463273859, 487, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Schaden and Sons", "calculating Naira Viaduct" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Oliver Abshire", "a", "http://lorempixel.com/640/480/sports", "Qui facilis alias aut sit quae voluptas quo animi incidunt vel voluptates rem alias est qui natus nobis in sequi.", 754517515, 963, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Carter Group", "Architect capability disintermediate" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jaquelin Heidenreich", "qui", "http://lorempixel.com/640/480/cats", "Consequatur fuga quia commodi consequatur quos asperiores et nobis velit doloribus error voluptas expedita hic natus totam ut animi et.", 317043668, 188, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), "Ward, Tillman and Bogisich", "Incredible Rubber Cheese reboot Yuan Renminbi" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sierra Marvin", "sed", "http://lorempixel.com/640/480/sports", "Aliquid molestiae ut commodi voluptatem pariatur dignissimos aut officia iure mollitia doloremque qui rerum ea pariatur vel in voluptatem aut.", 907083923, 909, new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), "Gerlach - Reinger", "deliver seize olive" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Samara Jacobs", "eaque", "http://lorempixel.com/640/480/transport", "Asperiores ut natus aspernatur repudiandae enim voluptas ut illum aut in rerum ut tenetur necessitatibus reprehenderit modi rem rerum aut.", 232775405, 903, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "Gutkowski, Roberts and Schaden", "Director Rupiah Architect" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Zelda Braun", "et", "http://lorempixel.com/640/480/cats", "Facere ducimus perferendis quia eius odio molestiae maxime cumque sint error dolore vitae enim dignissimos omnis tenetur soluta eveniet sapiente.", 163841941, 66, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Local), "Kunze Group", "interface Automotive ADP" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Isaac Beahan", "cupiditate", "http://lorempixel.com/640/480/nature", "Ab quisquam et error et ipsa odit id quia omnis voluptas deleniti dolorem tenetur et iure dicta reiciendis voluptas amet.", 549325615, 223, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), "Braun - Vandervort", "empowering Reactive clear-thinking" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hallie Jaskolski", "deserunt", "http://lorempixel.com/640/480/cats", "Qui labore voluptas autem cupiditate occaecati debitis consectetur voluptatem corrupti consequatur voluptatibus eaque quo numquam nesciunt odio fugiat quidem quia.", 222289591, 159, new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "Auer - Hintz", "withdrawal hack Lempira" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lauretta Bergnaum", "neque", "http://lorempixel.com/640/480/sports", "Perspiciatis doloribus fugiat esse et voluptatem voluptas et dolore eos libero quos accusantium commodi qui perferendis numquam nesciunt aut aut.", 616903458, 469, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), "Torphy - Braun", "Security Stravenue Intelligent" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Winifred Lockman", "ducimus", "http://lorempixel.com/640/480/nature", "Quasi animi sit maxime labore blanditiis fugiat tenetur aliquid error dolores aliquid odit dolorum saepe adipisci fuga quia corporis earum.", 652168087, 886, new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), "Jacobson, Rohan and Roberts", "Home Loan Account payment Dong" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Quinten Boehm", "corporis", "http://lorempixel.com/640/480/abstract", "Consequatur laudantium eveniet fugit necessitatibus ut reiciendis aut perferendis velit a adipisci autem mollitia nam placeat quae ut vero hic.", 674175642, 673, new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), "Fay, Hilll and Muller", "migration orchid Kansas" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Estella Wisoky", "dolore", "http://lorempixel.com/640/480/fashion", "Est voluptate enim sint culpa dolores sit quas est dignissimos dolor sint quia possimus inventore ipsam molestiae nobis reiciendis fuga.", 114120102, 641, new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), "Lynch, O'Reilly and Klocko", "Brazil core New Zealand Dollar" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Stanley Collins", "dignissimos", "Numquam minima quos voluptate ea quaerat pariatur earum maxime voluptatem et non nostrum eveniet et natus velit nam id voluptas.", 786641385, 711, new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "Fadel, Skiles and Schmeler", "Handcrafted Rubber Fish Progressive North Dakota" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lucas Herzog", "laudantium", "http://lorempixel.com/640/480/nightlife", "Sint eaque et dolor qui deleniti aut nulla quia quos aut officia alias odit eaque voluptatem esse eum veniam dolorem.", 445282609, 900, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Local), "Macejkovic LLC", "Tenge mobile Factors" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Amelia Satterfield", "impedit", "http://lorempixel.com/640/480/people", "Doloremque in quo praesentium non velit soluta in aut nemo est autem temporibus dignissimos iusto eum beatae laudantium amet qui.", 863811214, 532, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), "Zulauf - Prosacco", "quantify Licensed Fresh Tuna Buckinghamshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Saul Metz", "sapiente", "http://lorempixel.com/640/480/nightlife", "Et eaque omnis inventore quia quis rem facilis explicabo non illo adipisci corrupti dolorem soluta architecto enim ut ullam blanditiis.", 951528129, 143, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), "Jacobson and Sons", "Shoes bandwidth Jewelery & Sports" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Deontae Franecki", "placeat", "http://lorempixel.com/640/480/abstract", "Voluptas voluptas et nobis ut iste corrupti tempora adipisci nesciunt enim omnis nesciunt sit alias nisi officia cupiditate ab quos.", 715762020, 104, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), "Huel - Brown", "TCP Handmade Wooden Computer Uganda" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Leo Bartoletti", "fugiat", "http://lorempixel.com/640/480/fashion", "Eum iure rerum eos quia laudantium dolores et ut cupiditate quis qui et necessitatibus quis nihil iusto ut dolorem ratione.", 613588416, 92, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "Hagenes - Kris", "envisioneer Architect Fresh" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Maude Koss", "sed", "http://lorempixel.com/640/480/abstract", "Aut omnis consequatur et officiis a sit et tempore laudantium quia qui non odio tempora quia aut et deleniti tempore.", 656550390, 523, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Local), "Grant, Weimann and Beatty", "intermediate Spur interfaces" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLISHER", "TITLE" },
                values: new object[] { "Norris Miller", "quam", "A qui doloribus voluptates ipsa quisquam provident vel minus illum voluptatibus impedit voluptatum dolor praesentium libero et est voluptates quia.", 318921706, 735, "Nitzsche - Cruickshank", "Money Market Account calculating Home" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Nyasia Barrows", "quam", "http://lorempixel.com/640/480/nature", "Dolores nulla qui expedita dolor dolorem id quisquam dolores doloremque id dolore sint assumenda quod quas consequatur quam et nostrum.", 627748767, 317, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), "Paucek LLC", "Sleek Granite Keyboard calculating Garden & Shoes" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ian Wiza", "dolores", "http://lorempixel.com/640/480/food", "Ut quaerat placeat quo unde non eaque delectus laudantium officiis consequatur vel aut nemo explicabo dolorem consectetur qui dolor nostrum.", 395841452, 961, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "Ferry, Hickle and Weimann", "Division gold optical" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Keeley Hayes", "rerum", "http://lorempixel.com/640/480/people", "Omnis est animi aut est rem veniam accusamus aliquid hic quibusdam error ad commodi necessitatibus vel culpa soluta magni beatae.", 465684500, 793, new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Local), "Bergnaum - Heaney", "e-services Reunion mission-critical" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Marcellus Leuschke", "voluptas", "http://lorempixel.com/640/480/animals", "Eveniet eum est quasi ullam assumenda ab delectus cum voluptatem aspernatur quo sunt mollitia voluptates iste et illum asperiores voluptatum.", 263578942, 937, new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), "Weimann LLC", "Generic Concrete Mouse Grocery, Garden & Outdoors invoice" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Cody Crist", "et", "http://lorempixel.com/640/480/cats", "Molestiae numquam laboriosam fugiat aut tempora vero excepturi quas commodi molestiae dolores perferendis eos eaque culpa sed deserunt itaque accusantium.", 481227787, 338, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), "Dickens, Raynor and Walsh", "frictionless Tuvalu Visionary" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ignacio Moore", "perferendis", "http://lorempixel.com/640/480/food", "Enim occaecati est labore quia nihil modi qui voluptatibus assumenda et asperiores ut quidem libero est molestiae ad praesentium facere.", 836350094, 487, new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Local), "Gleason LLC", "Kids, Computers & Beauty monitor Regional" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hollie Farrell", "rem", "http://lorempixel.com/640/480/nightlife", "Molestiae reiciendis blanditiis ut totam fuga soluta debitis omnis aliquid quo aut officia a excepturi et pariatur sit nulla excepturi.", 779508067, 336, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "Cormier - D'Amore", "6th generation Dynamic quantify" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Delbert Erdman", "aut", "Officia hic totam quia ipsam earum vel saepe unde molestiae recusandae saepe ratione enim voluptas ab laborum quia excepturi possimus.", 340443796, 906, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), "Schinner - Breitenberg", "strategic Intelligent purple" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Verna Blick", "ratione", "http://lorempixel.com/640/480/city", "Excepturi sed sed voluptatem maiores doloremque tempora nam iusto pariatur aperiam qui ullam sunt sunt tempore itaque vel aperiam praesentium.", 686344468, 147, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "Crist and Sons", "Health action-items complexity" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ruthe Gusikowski", "consequuntur", "http://lorempixel.com/640/480/abstract", "Aliquam quis dolore sint esse non facilis optio nobis saepe consequuntur voluptas itaque consequuntur sapiente et eum nobis quas ducimus.", 265981181, 118, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), "Beahan, Hyatt and Smitham", "Nebraska emulation Squares" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Burdette Weimann", "odit", "http://lorempixel.com/640/480/city", "Quibusdam beatae totam pariatur dignissimos quisquam ut ut reprehenderit quae qui corrupti qui labore doloremque optio in sed quidem et.", 453820603, 607, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "Schimmel - Kuhic", "Licensed Soft Shoes Cape Verde Escudo Unbranded" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Manley Schoen", "reiciendis", "http://lorempixel.com/640/480/people", "Dolor neque dolorem nihil nam non quam sunt qui provident illum quas porro optio natus sequi ad ipsam ipsam minus.", 274544916, 622, new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "Hills, Lang and Botsford", "convergence auxiliary Bedfordshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Vincenza Bayer", "quos", "http://lorempixel.com/640/480/technics", "Veniam numquam eos fugit voluptatum repudiandae dolore eaque doloribus eum officiis excepturi alias non explicabo et cupiditate harum qui ducimus.", 679078032, 501, new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), "Nader, Lebsack and Fritsch", "Curve Delaware Camp" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Emilia Dickinson", "ut", "http://lorempixel.com/640/480/nightlife", "Nesciunt aut maiores velit aut rerum occaecati nostrum repudiandae enim doloremque enim nihil laboriosam vero voluptas ipsam vel officia ipsum.", 713521141, 589, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), "Barton, Dibbert and Mayer", "Florida approach Plastic" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dillon Jacobi", "praesentium", "http://lorempixel.com/640/480/people", "Eveniet consequatur id quidem sunt et incidunt et deserunt esse enim maiores odit inventore explicabo laboriosam voluptatem nemo eaque unde.", 205164007, 293, new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), "Yost Group", "Licensed Intelligent Concrete Chair Factors" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ryder Kilback", "soluta", "Iusto mollitia numquam laborum autem molestiae voluptatem et doloremque tempora enim voluptatem non officia sint rem pariatur itaque sed voluptatum.", 960753123, 486, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "Barrows Group", "compressing interfaces alarm" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kenya Weissnat", "odio", "http://lorempixel.com/640/480/sports", "Qui explicabo harum qui non repudiandae numquam quasi reiciendis ullam consectetur ut ab in nam velit aut praesentium doloribus excepturi.", 516007143, 845, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), "Conn LLC", "Research Unbranded parsing" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Pablo Wuckert", "et", "http://lorempixel.com/640/480/people", "Sint omnis qui ipsam est aut optio est maxime explicabo eum temporibus qui dolore tempora eum rerum et dolorum alias.", 530839004, 423, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), "Bernhard - Gerhold", "Home Loan Account Lead Computers & Computers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Zoila Marvin", "sapiente", "http://lorempixel.com/640/480/cats", "Accusamus distinctio saepe cupiditate corrupti et est totam quibusdam molestias qui qui sint dolor itaque ipsa voluptas odio iusto repudiandae.", 452921682, 819, new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), "Hirthe LLC", "International Fantastic Cotton Fish wireless" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hilario Douglas", "inventore", "http://lorempixel.com/640/480/nightlife", "Et rerum eligendi quisquam quo aliquam est ipsam reiciendis blanditiis sequi eius eum est iusto saepe beatae ut et dolores.", 878992635, 595, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), "Christiansen, Little and Schumm", "repurpose Extensions systematic" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Neil Prosacco", "laudantium", "http://lorempixel.com/640/480/animals", "Tempore nulla quaerat voluptatibus voluptate consequatur dolores omnis eum expedita modi quis molestiae id ipsum placeat quis nihil omnis culpa.", 630589943, 343, new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Kiehn LLC", "Health & Toys Creative blue" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLISHER", "TITLE" },
                values: new object[] { "Loyal Rempel", "nemo", "http://lorempixel.com/640/480/cats", "Delectus atque qui quidem recusandae numquam at dolorum nisi dolor ipsum ab eos veritatis delectus qui dolor corporis incidunt corporis.", 299409901, 883, "Price Group", "Cove virtual benchmark" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sophia McDermott", "hic", "http://lorempixel.com/640/480/nature", "Et autem voluptates in itaque quisquam repellat quia quibusdam pariatur maxime iste aut esse odit sed in et est esse.", 226502370, 917, new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Local), "Wisoky, Hand and Sawayn", "Personal Loan Account Graphical User Interface Legacy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jamar O'Connell", "in", "http://lorempixel.com/640/480/nature", "Voluptas labore iure aspernatur provident fugiat et molestias corrupti sunt dicta voluptates hic ullam odit est rerum accusantium quo sapiente.", 553140621, 827, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), "Swaniawski, Marks and Wolff", "card service-desk Handcrafted" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jody Lowe", "eveniet", "Quas maiores error unde reprehenderit facilis soluta fuga in sint doloribus ipsam cum natus alias aut voluptate occaecati dolores dolor.", 260630870, 468, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Local), "Renner, Satterfield and Brown", "Guyana Dollar synthesize Division" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Reynold Langworth", "a", "http://lorempixel.com/640/480/animals", "Optio et ex doloribus vel atque nobis tempora libero explicabo ut aut id voluptatem aliquid numquam eum qui quod eaque.", 427086821, 950, new DateTime(2024, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), "Kessler and Sons", "Rustic payment Research" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Beverly Hilll", "aut", "Incidunt sed ducimus sit sit iste non fuga soluta repudiandae odit adipisci earum aut reiciendis voluptatem molestiae labore eaque officia.", 532070236, 470, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), "Frami, Zemlak and Ullrich", "Supervisor Sleek Concrete Ball Port" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Timmothy Lindgren", "hic", "http://lorempixel.com/640/480/business", "Eos atque est excepturi est veritatis culpa quos minima aliquam dicta id beatae asperiores commodi eum consequatur nam rerum nesciunt.", 110730983, 514, new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "Kirlin Inc", "withdrawal Lodge Solutions" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Izabella Russel", "dolorem", "http://lorempixel.com/640/480/nature", "Perferendis vel possimus aut quia exercitationem cupiditate aut dicta omnis nihil repellendus voluptas officia qui facere laborum qui quis est.", 329213297, 269, new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "Hammes - Windler", "Money Market Account International navigating" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Minnie Gislason", "nihil", "http://lorempixel.com/640/480/technics", "Eius reprehenderit cupiditate eum qui vel sequi quis neque animi accusamus id molestiae adipisci porro nisi magni quia esse nesciunt.", 523053116, 859, new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), "Grant and Sons", "Georgia Som Turkey" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Domenico Mueller", "non", "http://lorempixel.com/640/480/city", "Porro non qui aut eos dolores incidunt delectus doloremque ab eos labore est saepe similique est accusantium ipsum illum qui.", 697743226, 666, new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), "Lueilwitz, Macejkovic and Koch", "Awesome Plastic Keyboard Developer plug-and-play" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Judson Sporer", "et", "http://lorempixel.com/640/480/cats", "Eligendi est aut amet laborum numquam eos ea autem rem sit molestias tempore doloribus eligendi voluptatibus qui numquam expedita laborum.", 184651025, 754, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Local), "Pagac LLC", "web services Checking Account Awesome" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Tierra Crist", "repudiandae", "http://lorempixel.com/640/480/business", "Maiores necessitatibus eum possimus in omnis suscipit praesentium doloremque nisi optio dolorum perferendis sed cum et sunt consequatur hic similique.", 384304442, 251, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), "Steuber - Cartwright", "Savings Account Books & Home strategy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kurt Robel", "aut", "http://lorempixel.com/640/480/transport", "Dolores officia aut quidem cum et nihil dolorem soluta et quae eos placeat laborum dolores consequatur ad voluptatum debitis nemo.", 946533462, 555, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), "Rempel Inc", "Investment Account quantify violet" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lia Runolfsson", "quia", "http://lorempixel.com/640/480/fashion", "Voluptas earum rerum commodi consequatur molestiae illo debitis est odio excepturi voluptas dolorem quia eos hic molestiae rem recusandae nemo.", 213797872, 76, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Conn - Tremblay", "Optimized Personal Loan Account Automotive & Beauty" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jose McGlynn", "nam", "http://lorempixel.com/640/480/abstract", "Ut officiis id aspernatur error expedita et pariatur iusto eligendi provident labore velit vel reprehenderit aut mollitia suscipit ut illum.", 973088440, 139, new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), "Bosco LLC", "Virgin Islands, British clicks-and-mortar needs-based" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alejandrin Schoen", "aspernatur", "http://lorempixel.com/640/480/city", "Labore id natus est nesciunt architecto dignissimos rerum voluptas consequuntur aut qui aspernatur et dolor ad ad et voluptatem accusamus.", 390685149, 544, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Reichert, O'Keefe and Rolfson", "Practical Handmade Frozen Mouse Licensed Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Elyssa Haley", "nisi", "http://lorempixel.com/640/480/business", "Eveniet minus quam veritatis eaque omnis enim eaque et adipisci corporis ipsam in voluptatem ab facilis quidem sunt accusamus in.", 225201544, 220, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), "Mayert, Goyette and Mraz", "digital Analyst Junction" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alf Keebler", "quis", "http://lorempixel.com/640/480/city", "Ea est ullam qui incidunt quaerat aperiam quibusdam aliquam et molestiae harum tenetur qui incidunt eligendi voluptatem dolores temporibus enim.", 388546645, 996, new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Local), "Sauer - Fay", "monitor virtual Solutions" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Madonna Hintz", "distinctio", "http://lorempixel.com/640/480/business", "Officiis libero repellat sint modi ea veritatis ullam quo praesentium autem ullam consequatur rerum voluptas ratione aspernatur magni qui provident.", 580229814, 769, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "Conroy - Smitham", "Refined Steel Mouse Games, Clothing & Electronics engineer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Felton Wintheiser", "dicta", "http://lorempixel.com/640/480/food", "Voluptatum ipsum ratione reiciendis facere quia ea sed fugiat sit sequi vero sequi officiis error et qui eius molestias rem.", 481081967, 584, new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), "Spencer - Ankunding", "Outdoors approach Tasty" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kaitlin Zulauf", "pariatur", "http://lorempixel.com/640/480/transport", "Et magni autem quia est praesentium natus officia at officiis maiores error quia molestiae et amet alias vel soluta fuga.", 353139407, 498, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Towne Inc", "Forward Granite Security" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Nigel Crona", "dicta", "http://lorempixel.com/640/480/food", "Expedita corporis sit perferendis ut eum aut ea architecto quasi et aut ut quisquam assumenda est est a consectetur et.", 200273540, 801, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), "Lowe, Rohan and Dickens", "Spur New Hampshire Jersey" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TITLE",
                table: "Books");

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
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Kris Rolfson", "mollitia", "Aliquam veritatis error cupiditate reprehenderit voluptas rerum numquam dolor aut non minus aut reprehenderit quam maxime consequatur perferendis pariatur natus.", 356071543, 127, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "Jacobi - McKenzie" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLISHER" },
                values: new object[] { "Cielo Schaefer", "magni", "http://lorempixel.com/640/480/nightlife", "Necessitatibus qui id hic eaque modi illo libero facilis molestiae maiores odit non totam impedit maiores nihil ut repellendus est.", 361173331, 75, "Ruecker LLC" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Gillian Considine", "eos", "Quia laboriosam corporis consequatur soluta in vitae expedita numquam id ut ut excepturi sapiente ea harum a minima et quaerat.", 808599163, 926, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "Gibson - Zieme" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Lori Douglas", "omnis", "http://lorempixel.com/640/480/sports", "Alias aperiam reiciendis ut quia minima maxime aut est molestiae officiis rerum accusantium et sint iste necessitatibus enim dicta et.", 192215450, 556, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "Prohaska, Thompson and Fritsch" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Maximillia Ziemann", "qui", "Laudantium tempora quod et dolorum dolores doloribus voluptate deserunt aut placeat error voluptatem eos quidem omnis molestiae ut dicta et.", 154831657, 538, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), "Lebsack Inc" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Zachary Davis", "ut", "http://lorempixel.com/640/480/nature", "Consectetur enim eos sint qui assumenda qui et voluptas et quod saepe et delectus ut earum aliquid non est omnis.", 612452714, 936, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "McCullough, Veum and Ankunding" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Florian Wisozk", "assumenda", "Ipsa repudiandae eaque optio eaque aut ipsum saepe sed pariatur ab aut commodi molestiae tempora magnam voluptatem accusantium non adipisci.", 340803311, 415, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "Konopelski Group" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Susie D'Amore", "aut", "http://lorempixel.com/640/480/city", "Quis laborum dolor deserunt nostrum nobis repudiandae sapiente vel repellendus occaecati pariatur aut nemo ipsa fugiat consequuntur id aut quibusdam.", 335641691, 113, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), "Crooks Inc" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Kaci Howell", "distinctio", "http://lorempixel.com/640/480/sports", "Sit doloremque nobis ipsum omnis non ut autem ipsam enim omnis eius architecto soluta et eligendi praesentium asperiores ut voluptatibus.", 539107635, 992, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), "Murphy, Dach and Glover" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLISHER" },
                values: new object[] { "Marques Boyer", "dolore", "Eos reprehenderit voluptas velit error nulla aut vel facere distinctio a magni deserunt voluptatibus quia quae sapiente repudiandae ex odit.", 706812473, 127, "Steuber, Reilly and Lesch" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Toy Langosh", "deleniti", "Autem amet eos reiciendis praesentium saepe est et omnis ipsum iure qui animi fugiat enim est eum omnis accusantium qui.", 568313752, 993, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "Becker and Sons" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Alverta Will", "deserunt", "Sequi ut mollitia rerum omnis omnis natus fugit aut error vel consequatur deserunt enim modi quia molestiae veniam harum ut.", 487060181, 288, new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Local), "Tremblay Inc" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLISHER" },
                values: new object[] { "Luciano Pagac", "aliquam", "http://lorempixel.com/640/480/animals", "Velit nisi molestias perspiciatis sint enim consequuntur ut incidunt eligendi nulla nobis sit eos dolores vel perspiciatis commodi atque qui.", 102718140, 807, "O'Hara - Daniel" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Orville Bogisich", "nesciunt", "http://lorempixel.com/640/480/business", "Velit est officiis consequatur est et blanditiis officiis eum ut suscipit pariatur dolorem quis saepe voluptatem omnis consequuntur dolores at.", 567507244, 598, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), "Beer, McCullough and Pfeffer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Hubert Cronin", "architecto", "Atque ut commodi error blanditiis et sed magnam beatae dolorem minus corporis ut ab voluptatem facere aut tempore dolores iste.", 458794343, 349, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Local), "Jacobs Group" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Wilburn Boyle", "nulla", "Nam veritatis vitae corporis iure veritatis quisquam et commodi dolor eos id animi ut et et modi magni ratione iusto.", 954705158, 653, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), "Boyer - Mann" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Jacquelyn Hartmann", "animi", "http://lorempixel.com/640/480/animals", "Voluptas est modi a tenetur ullam tempore dolores quae aspernatur perferendis labore est ut cum nihil enim accusantium libero sed.", 583447334, 611, new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), "Hessel - Klein" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[] { "Polly Blick", "praesentium", "http://lorempixel.com/640/480/transport", "Nostrum sunt amet magni quae ipsa et perspiciatis ut neque repellendus ullam blanditiis occaecati modi reprehenderit impedit voluptates nostrum tempora.", 873926495, 930, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Stehr and Sons" });

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
    }
}
