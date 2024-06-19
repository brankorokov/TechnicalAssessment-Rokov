using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechnicalAssessmentRokov.Migrations
{
    /// <inheritdoc />
    public partial class AddingStatusInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CHECKED_OUT_BY",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CHECKED_OUT_DATE",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DUE_DATE",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Johnpaul Moore", "qui", null, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=837", "Et reiciendis delectus exercitationem voluptatem laborum at adipisci maiores et dignissimos libero quasi quaerat illum quis deleniti cum sapiente sed.", new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Local), 786961622, 766, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), "Rempel - O'Hara", "invoice Summit workforce" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Erling Hermiston", "consequuntur", null, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=1064", "Iste et ad quas eligendi voluptas eaque voluptatem autem quod tempora fugiat sint assumenda officiis temporibus cumque quam suscipit aperiam.", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), 683007736, 843, new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Konopelski Group", "explicit New Mexico Multi-lateral" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kylie Hauck", "fugiat", null, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=388", "Ut rerum sint tenetur esse animi nobis repellendus libero omnis iste et id amet cum reprehenderit tempora nesciunt omnis et.", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), 212295032, 314, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), "Hickle, Kunde and Schamberger", "Creative Generic Fresh Chips Executive" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AUTHOR", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Palma Koss", null, new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=845", "Perspiciatis distinctio laborum itaque debitis quibusdam rem quos facere ab reprehenderit ipsum illum natus voluptatem assumenda et reiciendis eaque sit.", new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), 805483662, 921, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), "Maggio LLC", "architectures Valleys Legacy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mekhi Brakus", "doloremque", null, new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=706", "Iure officia dolores praesentium odit soluta autem omnis rerum qui tempore reprehenderit est voluptatem quod dolor atque quos dignissimos eveniet.", new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), 372573685, 829, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "Murphy, McCullough and Carroll", "redundant convergence Course" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Garnet Veum", "vero", null, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=94", "Doloremque maiores quo consequuntur sit ea illo nobis commodi velit sit unde neque ratione et eum in voluptatibus tempore molestias.", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), 956880373, 147, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), "Sawayn, Toy and Rutherford", "algorithm facilitate Central" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Oleta Berge", "id", null, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=370", "Quidem autem magnam natus reprehenderit sed nisi qui autem quas labore repellendus delectus et quam voluptas dolorem adipisci voluptas sit.", new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Local), 148609132, 499, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "Dooley, Bartoletti and Rolfson", "Tunisian Dinar fuchsia indigo" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jordane Tromp", "explicabo", null, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=432", "In consequatur quod tempore ipsa non id aliquid quia quis temporibus exercitationem necessitatibus voluptas veniam quo quo non ipsum porro.", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 574154299, 169, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), "Zemlak - Conroy", "teal Investment Account Rustic" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sydni Dare", "excepturi", null, new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=697", "Vel dolorum qui voluptas dolorem voluptatem non aut eveniet excepturi est dolor distinctio quia ipsa ex cum est culpa non.", new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), 784132636, 368, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), "Hills - Morar", "Outdoors Intranet Planner" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Molly Kunze", "inventore", null, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=385", "Voluptas repellat ipsum quo voluptate rerum praesentium et et pariatur accusamus cum sunt consequatur voluptatum earum sit numquam voluptatem voluptas.", new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), 273730644, 799, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), "Rippin Inc", "Research Courts ADP" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Wendell Bahringer", "sed", null, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=588", "Doloremque beatae fugiat nihil ducimus culpa enim velit quia a error quia vitae repudiandae ut natus quod cupiditate pariatur aliquid.", new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Local), 288294544, 451, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), "Turcotte Inc", "Georgia protocol port" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Casandra Lind", "eligendi", null, new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=914", "Fugit expedita beatae consequatur itaque sit voluptates est alias quidem hic rerum sint et voluptatibus atque est doloribus magnam eveniet.", new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), 661415381, 846, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), "Zulauf - Runolfsson", "Refined Refined Plastic Chicken Incredible Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Erling Windler", "vero", null, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=163", "Natus sit itaque iusto fugit laboriosam eum voluptas expedita aut id qui ex assumenda voluptatem nemo facere sapiente cupiditate veritatis.", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), 999484002, 277, new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "Macejkovic, Trantow and Hagenes", "invoice monetize Idaho" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Emmanuelle Fisher", "eveniet", null, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=59", "Debitis ullam mollitia ut atque rem sit quam quia voluptatem quis dolor ut autem repudiandae non nihil hic qui aperiam.", new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), 310405193, 543, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Doyle, Larkin and Kilback", "deploy green parsing" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Colin Heller", "eum", null, new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=102", "Doloribus dolore illo assumenda aliquam rerum fugit vel modi odit incidunt totam minima possimus consequatur veritatis voluptates quaerat consequatur quia.", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), 177122434, 870, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), "Oberbrunner - Muller", "Money Market Account compressing hacking" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Anthony Gerhold", "modi", null, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=882", "Voluptatem et nobis voluptas provident qui sint dolor repudiandae sunt rerum perferendis eum est nemo eius vel quia facere nihil.", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), 385307914, 127, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), "Stiedemann - Leffler", "Innovative context-sensitive Washington" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Cullen Douglas", "quod", null, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=621", "Quis quo occaecati ea ducimus non et quasi vel accusantium et aperiam ducimus quia quae asperiores eveniet ut neque architecto.", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), 980488860, 543, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Local), "Jenkins, Ratke and Gorczany", "optical complexity Guatemala" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jamarcus Feeney", "sed", null, new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=446", "Enim quam laudantium qui voluptatibus accusamus et eum earum cumque eos facilis est autem fugiat ut fuga sapiente quo a.", new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), 235722980, 170, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Rath, Auer and Thiel", "bandwidth Pula Stravenue" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Emmett Beer", "ullam", null, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=577", "Minima ut necessitatibus dolorem possimus quia molestiae delectus reiciendis quos sed debitis autem et est iure voluptatum id eum quas.", new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), 869418177, 894, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "Rau Group", "Multi-layered Berkshire Tactics" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Oren Schoen", "eius", null, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=933", "Odio a autem dicta mollitia quasi ut aperiam dolor sed cum eos quam perspiciatis asperiores esse porro facilis quisquam excepturi.", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), 515560370, 217, new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), "Glover and Sons", "Trail GB Isle" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hillard Brekke", "voluptate", null, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=28", "Similique nemo est placeat et cupiditate et non dicta aut ut doloribus et aliquam aliquid ea velit commodi recusandae velit.", new DateTime(2023, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), 790340205, 218, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Gottlieb, Hamill and Marks", "Nuevo Sol Cambridgeshire applications" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dolores Simonis", "soluta", null, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=96", "Distinctio voluptatem et nihil aut necessitatibus voluptatibus corporis sunt voluptatem qui harum est delectus dignissimos cum ut quisquam magni enim.", new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Local), 672273723, 996, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), "Reilly - Lowe", "Infrastructure Skyway Senior" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dallas Langosh", "mollitia", null, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=1019", "Enim laudantium eaque et consequuntur voluptatem modi qui veniam occaecati aut vitae nihil ut est eligendi voluptas qui quia ut.", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), 647201397, 163, new DateTime(2024, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), "Hodkiewicz, Beer and Weimann", "Fantastic Plastic Mouse XML Tasty Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Maudie Russel", "magnam", null, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=813", "Reprehenderit aut assumenda deserunt veniam voluptatem excepturi exercitationem in quae quam enim modi voluptatem qui ab voluptatem minima facere beatae.", new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), 538548189, 272, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), "Kunde, Schowalter and O'Conner", "Handmade Soft Chips reintermediate Port" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Angelita Mueller", "tempore", null, new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=1019", "Mollitia occaecati laboriosam sunt cupiditate inventore aut et dolorem esse quibusdam sit modi recusandae et nemo delectus qui accusantium molestiae.", new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Local), 867574740, 258, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), "D'Amore - Greenfelder", "primary Unbranded Rubber Ball Zimbabwe Dollar" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Audie McCullough", "voluptas", null, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=672", "Quo assumenda et autem ut saepe omnis sint nulla ea sit quo illum consequatur aperiam maxime eum dolores aut nisi.", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), 352784262, 490, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Runte Group", "ubiquitous synthesizing Handcrafted Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Irwin Corwin", "sit", null, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=87", "Incidunt impedit voluptatem dolore quo est expedita error sit nihil qui aut magnam repellat est voluptate recusandae velit error facere.", new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), 156521018, 475, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "Romaguera - Greenholt", "payment bypass hack" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Cali Ruecker", "ut", null, new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=237", "Blanditiis suscipit vitae eos et odio non minus aliquam aut eligendi rem quo laboriosam qui veniam vel qui totam alias.", new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), 660109563, 448, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), "Reynolds and Sons", "optical Cote d'Ivoire streamline" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Theresia Runolfsson", "minima", null, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=205", "Tempora accusantium quos praesentium facilis eaque quia dolorem et voluptatibus provident ex quam eaque qui dolores quia aut laborum voluptates.", new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), 965812759, 366, new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Local), "Toy, Daniel and Hills", "AGP Dalasi enable" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Wanda Paucek", "consequuntur", null, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=230", "Ea voluptatem fuga occaecati autem rem est aspernatur rerum in dolorem ipsa et repudiandae unde corporis eaque consequuntur tempore non.", new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), 192505453, 391, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Local), "Mertz, Rowe and Daniel", "Strategist Future-proofed grey" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jody McLaughlin", "itaque", null, new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=776", "Fugiat quia quidem rerum dolorem nam quia nostrum sunt id illum ab iure autem natus earum architecto esse tempora inventore.", new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), 337770147, 619, new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "Abshire, Rath and Durgan", "Avon compressing Officer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Leone Koepp", "suscipit", null, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=118", "Velit omnis eos laborum accusantium alias esse ut praesentium quidem a omnis totam eos nulla eaque ducimus maxime est quibusdam.", new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), 277834678, 686, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Local), "Von, Toy and Abshire", "Regional target compress" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Skylar Abbott", "vel", null, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=305", "Sed voluptas qui iusto dolorum impedit nostrum voluptate optio sed repellat pariatur totam sapiente possimus vero dolor dolor eius a.", new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), 556676871, 772, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), "Mayert - Haag", "calculate vortals RSS" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Aurelio Morissette", "corrupti", null, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=320", "Quia provident ipsa numquam tenetur alias ad quaerat quidem voluptatem officiis vel est commodi ullam et et illo suscipit necessitatibus.", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), 110681685, 126, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), "Wintheiser - Upton", "Awesome Cotton Bacon user-centric Designer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Gust Schaefer", "quas", null, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=993", "Voluptatum quae aut qui voluptatem consectetur sed quasi sequi vitae et architecto vero quos voluptatum non odit voluptate qui sed.", new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Local), 487937784, 589, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), "Turcotte, Williamson and Larson", "mission-critical Rubber scale" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sydnie Grady", "labore", null, new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=206", "Omnis vel sapiente fugiat harum architecto magnam et dolores tempore hic consequatur corporis autem deserunt atque aut et ut quia.", new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), 696060459, 494, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "Hahn, Murray and Conroy", "syndicate lavender flexibility" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Chandler Rau", "sint", null, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=524", "Nulla eligendi temporibus maiores assumenda ut recusandae explicabo aut ea illum suscipit ipsum asperiores dolorem est et esse dignissimos omnis.", new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), 629406162, 398, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), "Rau - Rice", "convergence Representative bandwidth" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Carroll Strosin", "at", null, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=727", "Dolor cumque perferendis optio nihil consequatur aliquam laboriosam omnis est vel at rerum mollitia non culpa optio vel quia inventore.", new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Local), 329099144, 779, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Local), "Schowalter, Kovacek and Boyle", "Kyat silver Fresh" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Earline Koch", "repellat", null, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=539", "Consequuntur nemo reprehenderit praesentium tempore fugiat iure quae itaque et quis maxime harum in in voluptatem praesentium impedit impedit id.", new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), 311310261, 764, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), "Lemke - Kutch", "bypassing Ergonomic Unbranded Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Geovany Moen", "culpa", null, new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=446", "Commodi et qui aut ut aliquam consequuntur rem dolorem sed sit eos quibusdam perspiciatis ut labore iste est voluptas fugiat.", new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), 173604268, 832, new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "Langosh and Sons", "Small Concrete Computer calculate Kids" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Shyanne Feeney", "ducimus", null, new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=196", "Tenetur et sunt iusto rerum vel doloremque nam eius voluptatem praesentium est ut corporis inventore sunt incidunt rerum qui ad.", new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), 485269178, 788, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), "Buckridge - Cruickshank", "quantifying Refined Fields" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Brady Bauch", "quia", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=265", "Minima dolores perferendis odio hic labore dolorum quia enim sequi qui qui qui veritatis similique rerum et laudantium pariatur magnam.", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), 737856687, 729, new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), "Fritsch, Kris and Price", "Strategist New Zealand Dollar Officer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Beau Gutkowski", "impedit", null, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=797", "Sed aut nam voluptatem voluptas et consequuntur molestiae aspernatur sunt et aliquam velit voluptas aut quis modi magni et rerum.", new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 674466611, 404, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "Herzog, Hilpert and Steuber", "Practical Rubber Bacon Drives Street" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Barry Kling", "iure", null, new DateTime(2023, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=894", "Possimus voluptatibus est fugiat numquam aut repudiandae rerum nulla beatae nostrum debitis recusandae culpa distinctio perferendis placeat qui tempora eos.", new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), 386611192, 749, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "Hauck and Sons", "Rhode Island payment sky blue" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Deontae Ullrich", "laboriosam", null, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=825", "Hic qui facere perspiciatis commodi ipsam mollitia illo minima quisquam fugit velit id reiciendis qui dolores voluptatem quos voluptate corporis.", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), 695302823, 857, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "Abbott - O'Reilly", "Baht quantifying Sleek" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Colin Prosacco", "in", null, new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=569", "Voluptatum laudantium ipsa magni itaque molestiae omnis cupiditate fuga facilis quia veniam sapiente nostrum qui sunt dignissimos quasi sit aliquid.", new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), 146001292, 153, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), "Walker - Fritsch", "Forward Tennessee multi-byte" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Terrell Ratke", "modi", null, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=880", "Ea blanditiis officiis sunt suscipit sed voluptatem reprehenderit blanditiis voluptas sapiente amet distinctio a nostrum quibusdam unde id sint molestiae.", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), 439905347, 929, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), "Stroman, Dickinson and Abshire", "monetize payment web services" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Randal Willms", "nemo", null, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=557", "Harum perspiciatis ipsum facilis at totam ex occaecati est officiis iure qui perspiciatis ut consequatur reprehenderit sunt qui est a.", new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Local), 236850911, 320, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), "Wilderman LLC", "Concrete connecting Club" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Darren Wisoky", "excepturi", null, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=1072", "Dolorem ipsum id eius harum ex odit animi exercitationem temporibus iste est necessitatibus ut rerum omnis et dolor sed aspernatur.", new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), 229153592, 214, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "Jacobi - Feil", "Metal pink Nakfa" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Houston Mosciski", "est", null, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=424", "Magnam at aut qui error explicabo ipsum aut dolorem laborum aliquid quasi tenetur eius reprehenderit quidem ea ut blanditiis perspiciatis.", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), 542706290, 781, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "Renner, Armstrong and Morar", "Handcrafted Metal Keyboard leverage back-end" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Judge Crona", "cupiditate", null, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=942", "Sequi totam explicabo sint quasi quia sequi dolor odit iusto iste et architecto ut quia quis eaque aut ex maiores.", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), 458339536, 183, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "Schoen and Sons", "Fantastic Wooden Pants black port" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Wilfredo Cartwright", "rerum", null, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=1025", "Cum cum voluptas nemo dolorum neque nesciunt nihil neque laborum velit asperiores officia dolores aut soluta eum molestias quisquam tempore.", new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Local), 604245900, 330, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "Hudson - Simonis", "Locks ADP collaborative" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Yadira Krajcik", "quia", null, new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=69", "Sed consequatur totam velit qui sequi ducimus velit dolorem voluptatibus quia mollitia asperiores veritatis aut exercitationem eum dolorem veritatis ratione.", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), 485139112, 860, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), "Ziemann - Mills", "Agent New Mexico Tennessee" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Tia Mills", "iste", null, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=651", "Dicta nobis nostrum nulla rerum quis ducimus soluta ut omnis dolor et eveniet harum quasi corporis vitae quo iure nihil.", new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), 738548757, 976, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), "Schumm Group", "indexing Granite Intelligent" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sidney Torphy", "alias", null, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=393", "Ipsam id voluptatem et modi ipsam dolores perspiciatis modi ducimus delectus dolorem eos est in exercitationem hic iure consequatur quo.", new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), 204550108, 397, new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), "Gerlach - Stroman", "connect killer Rubber" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Erna Monahan", "veritatis", null, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=135", "Omnis consequatur ipsa fugiat culpa ab debitis veritatis officiis dolor neque quas repellendus et aut molestiae eaque debitis voluptatibus animi.", new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), 733917117, 610, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), "Ortiz - Windler", "Moroccan Dirham US Dollar Checking Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ceasar Littel", "repudiandae", null, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=119", "Nostrum quibusdam non et maxime earum molestiae inventore rerum eligendi fugit neque aut delectus minus maiores sunt blanditiis est enim.", new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), 510914022, 448, new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), "Bins Group", "Handmade Soft Towels paradigms Tasty Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Deron West", "quis", null, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=674", "Laudantium eum est ea labore sapiente praesentium cupiditate suscipit repudiandae sed natus sed ex assumenda sed minima qui inventore fuga.", new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Local), 783292910, 871, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), "Brakus Inc", "Massachusetts online throughput" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Veda Robel", "corrupti", null, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=967", "Debitis sunt est nam dolores ratione error enim incidunt esse cum rerum fugiat rerum accusamus quis in modi distinctio voluptas.", new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), 757377143, 899, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Reichel Group", "Communications Guam synthesize" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Genesis Zemlak", "doloremque", null, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=528", "Eum error sit quis in quidem adipisci assumenda voluptatem non possimus dolore quae aperiam repellat quod ex quo labore rerum.", new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Local), 297153617, 461, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "Grimes and Sons", "redundant deposit Re-contextualized" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Johnpaul Ferry", "consectetur", null, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=935", "Debitis aliquam earum quasi ut quo eos sunt quod illum ab ipsum debitis et quidem et molestias nemo eos dolorem.", new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Local), 374858752, 425, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Koch Inc", "e-services TCP mission-critical" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Quincy Hickle", "nesciunt", null, new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=53", "Sapiente quod suscipit facilis consequuntur tenetur et ad odit fugit enim non eos corporis ex distinctio accusantium nemo eos voluptate.", new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), 356192010, 912, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), "Grimes - Hauck", "Operative olive PCI" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Maxwell Lebsack", "et", null, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=730", "Quo et consequatur aliquam distinctio eveniet molestias reprehenderit aliquid unde iste excepturi error in illum optio ex omnis debitis voluptas.", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), 426606039, 463, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), "Von, Metz and Kuvalis", "digital systems Latvian Lats" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Braden Connelly", "in", null, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=335", "Ea hic et ut sit quidem voluptates reprehenderit dolorem inventore qui non adipisci repellendus dolore eum dolorem aspernatur corrupti odit.", new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), 319704483, 773, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "Monahan, Koelpin and Howe", "Checking Account leading edge synergies" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Anissa Mohr", "rem", null, new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=330", "Tempora sit aspernatur qui iusto vitae cumque laudantium eos explicabo perferendis voluptatem repudiandae dolor quas quasi corporis molestiae dignissimos ea.", new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Local), 650899800, 761, new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), "Upton, Reynolds and Little", "Bridge deposit Plaza" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ressie Rohan", "architecto", null, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=686", "Maxime ut velit iure qui in quasi laboriosam totam quas assumenda neque vel assumenda laudantium vel possimus doloribus aut asperiores.", new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), 955812091, 213, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "Wolf Inc", "Directives bus copying" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Monroe Ernser", "et", null, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=929", "Est aut debitis tempora totam quae similique omnis temporibus consectetur iusto omnis sit quis pariatur provident doloribus vel consequatur velit.", new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Local), 813298511, 766, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "Fadel - Klocko", "Cambridgeshire Jersey human-resource" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Daisha Bahringer", "autem", null, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=671", "Et dolor optio temporibus incidunt et possimus distinctio minus ut eum laudantium eveniet corrupti similique aut et nobis velit incidunt.", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 861699634, 905, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), "Labadie, Walker and Hickle", "alarm systematic Singapore" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kay Gorczany", "explicabo", null, new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=239", "Aut et qui numquam incidunt sit atque porro incidunt natus vel aperiam est sint qui ducimus aperiam est qui doloremque.", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), 344251671, 996, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), "Treutel Inc", "Guinea-Bissau circuit process improvement" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Arianna Pouros", "qui", null, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=909", "Facere exercitationem cum ut consequuntur consectetur commodi temporibus quia quod aspernatur est ut quo sint saepe enim omnis debitis exercitationem.", new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), 160514272, 646, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), "Torphy Group", "next generation Egypt Fantastic Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Orlo Kessler", "magnam", null, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=56", "Temporibus dolor laborum blanditiis amet sunt esse nulla illum doloremque at sed omnis sunt est consectetur aut ducimus recusandae voluptas.", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 231100379, 838, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "Ziemann - Schaden", "Refined Steel Hat value-added sky blue" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Domingo Waters", "quibusdam", null, new DateTime(2023, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=535", "Veniam porro nulla vitae perferendis architecto eos possimus beatae eveniet et quia veniam sit nemo dolor non sit quia magni.", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), 837895749, 789, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), "Rodriguez LLC", "Russian Ruble Zloty knowledge base" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Moises Toy", "ullam", null, new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=652", "Sequi laborum dolor voluptas voluptas maxime alias deleniti quo facilis aut et pariatur non officia quasi omnis pariatur sequi eveniet.", new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 280028078, 912, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), "Kassulke Group", "Zloty Tanzania circuit" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Danial Larkin", "necessitatibus", null, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=952", "Dolorem suscipit odit officia ut dolor sed quibusdam voluptates asperiores sapiente aspernatur voluptatem rem praesentium optio aut odit ea quo.", new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), 631824437, 280, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), "Swift Group", "quantify AGP transmitter" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dakota Miller", "nobis", null, new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=981", "Eos labore officia enim est omnis est eveniet pariatur aut amet veniam omnis libero neque aut unde dolore beatae voluptatibus.", new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), 167253441, 408, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), "Lakin - Emard", "Bridge Cotton Awesome" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Stefanie Lindgren", "enim", null, new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=748", "Necessitatibus ut eos aut est rem atque voluptatem quia repellendus unde praesentium maxime saepe pariatur fugiat dolorem nam rerum dicta.", new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), 941705037, 875, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "Mraz, Dach and Muller", "input Singapore back-end" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alphonso Connelly", "nesciunt", null, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=1", "Maxime sapiente accusantium quia officia minima rem porro error vitae minus beatae magni reiciendis ut consectetur ea dolorem libero animi.", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), 537620031, 678, new DateTime(2023, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), "Lynch - Cole", "lavender Road system" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dayna Hettinger", "eum", null, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=472", "Autem aut veritatis est in sunt iure eius iure odit autem dicta itaque dolorem enim modi culpa accusantium illum quia.", new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), 965276157, 821, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), "Rosenbaum Inc", "Money Market Account Tasty Fresh Cheese Administrator" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Adrianna Lowe", "ea", null, new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=389", "Ea veniam dolorum est eum iste aliquid similique aliquam aut magni eveniet voluptas autem velit id aut labore minus perferendis.", new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), 230299895, 353, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), "Gorczany - Lindgren", "Manager Small Producer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Easter Hand", "iste", null, new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=486", "Omnis aut dignissimos delectus quis qui in qui nisi ipsum harum minus architecto maxime ea sit expedita doloremque sed pariatur.", new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), 415915823, 111, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Local), "Prohaska, Roob and Boyle", "Auto Loan Account XML Isle" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Henriette Altenwerth", "quasi", null, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=469", "Soluta sequi quasi inventore qui natus ut officia voluptatibus nihil at aperiam id nihil aspernatur enim occaecati excepturi beatae neque.", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), 413035921, 197, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), "Franecki - Stark", "Iceland 24 hour Consultant" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Elenor Brekke", "dolor", null, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=964", "Quia quia explicabo dolores ab omnis itaque quidem porro nemo ut repellendus id consectetur consequuntur facilis aspernatur illo porro non.", new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), 697584086, 747, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), "Howe - Hermann", "Field Fantastic Soft Keyboard Terrace" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Tremayne Collins", "eius", null, new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=377", "Laborum assumenda temporibus possimus nihil nobis reiciendis ipsa voluptatem aspernatur eaque fugiat dolores placeat voluptas et vel possimus labore dolor.", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), 763852516, 804, new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), "Kemmer, Bernier and Hauck", "engineer communities Virginia" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Madyson Nicolas", "voluptatibus", null, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=78", "At ut veritatis expedita ipsum fugiat harum vel aliquid rem aut sint ratione veritatis eius eaque placeat quia ut asperiores.", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), 548590148, 106, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), "Carroll, Hirthe and Trantow", "Awesome hack Home Loan Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Shania Hartmann", "quia", null, new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=831", "Occaecati deleniti placeat sint consectetur quo aut saepe quod eos sunt pariatur quos possimus minima hic qui ducimus perspiciatis animi.", new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), 401717504, 90, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), "Sawayn Group", "strategic Handmade Court" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mireya Bernier", "nostrum", null, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=982", "Accusantium natus aut ipsa impedit accusamus consequatur sint non molestiae eaque illum nobis corrupti earum dolorum ut aliquid consequatur sequi.", new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), 223965866, 222, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Local), "Padberg Inc", "Iowa optimal Delaware" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Timmy Fay", "est", null, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=850", "Velit est vero eveniet dolor et libero est nobis voluptate adipisci illo eligendi libero aspernatur minima eum quis animi quo.", new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), 272539720, 279, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), "Rau - Hessel", "PNG Avon EXE" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Shanon Reynolds", "in", null, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=890", "Est maiores mollitia optio velit et distinctio at sint sed enim velit voluptas et velit natus aliquid autem tempora cum.", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), 276326390, 563, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Kutch, Hirthe and Crist", "Configurable Administrator Architect" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hollis Haag", "nam", null, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=833", "Autem quia iusto iste eveniet eos natus sequi dolorem ipsam quia necessitatibus cumque nobis deleniti enim placeat aut aliquid aut.", new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 353715171, 101, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), "Dibbert, Moore and Satterfield", "Factors Handmade Soft Fish Borders" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Bo Borer", "excepturi", null, new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=1010", "Recusandae sit illum omnis impedit voluptatibus et aut in quasi pariatur totam consequuntur est ab dolores enim nihil velit illum.", new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), 300551401, 750, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), "Frami, Spencer and Monahan", "payment alarm syndicate" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jessy Braun", "dolore", null, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=766", "Libero eos quo deleniti aliquam officia est soluta reiciendis aut ut magnam error fugiat sit excepturi dolorem quos unde tempore.", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), 549994793, 895, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "Wunsch, Towne and O'Reilly", "Extensions model Handcrafted Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Harrison Schneider", "tenetur", null, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=161", "Officiis fugiat sit suscipit tempora eaque distinctio rerum eligendi perspiciatis dolorem omnis quo velit sint exercitationem expedita aliquid et itaque.", new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), 499989026, 234, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "Wyman - Denesik", "Fantastic Metal Shoes Gorgeous Granite Car firewall" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sunny Kreiger", "ut", null, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=390", "Ut quos autem quasi reprehenderit laborum eum est velit quasi maxime libero labore excepturi sed qui corrupti et inventore fugiat.", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 132611011, 523, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), "Hettinger, Ratke and Collins", "panel calculate orchid" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Aliyah Miller", "vitae", null, new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=649", "Est dolorum aut sint molestiae eius optio pariatur sunt rerum qui id vel quia cumque recusandae nihil voluptate et ipsum.", new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), 790375345, 783, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "Brown Inc", "multi-byte Extended Michigan" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Amelia Harris", "quisquam", null, new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=321", "Ut sequi nostrum facilis voluptas et labore maxime animi quod autem illum porro est sunt hic voluptatibus vitae praesentium doloremque.", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 204346782, 904, new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Local), "Kerluke Group", "Lithuanian Litas grow Lane" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Milton Terry", "officiis", null, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=168", "Provident sed id nostrum vitae aliquam ea corrupti amet iure odit voluptatibus est sunt est ut et dolorem aut similique.", new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), 334585602, 249, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), "Hettinger, O'Keefe and Maggio", "Direct Savings Account Canyon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Oswald Cruickshank", "nihil", null, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=205", "Eum veritatis repellat architecto praesentium eveniet labore quia sed quas iure sunt officia velit quia quam placeat mollitia velit aliquam.", new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), 286586073, 619, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Local), "Weissnat - Leuschke", "panel Cambridgeshire Sri Lanka Rupee" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Marshall Jenkins", "culpa", null, new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=956", "Voluptatem repellendus ut est officia ut accusamus distinctio consequatur laborum voluptas exercitationem est mollitia in neque omnis voluptas animi id.", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), 617376439, 65, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Keebler - Mann", "New Jersey Solomon Islands Dollar neural" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jeffrey Towne", "voluptates", null, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=116", "Molestiae sequi aut eligendi voluptatem voluptas ut aut rerum vitae iure dolor et perferendis et qui tempora enim tenetur recusandae.", new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), 808800576, 672, new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), "Tromp - Mraz", "cyan Central Sleek Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_BY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Brennon Hintz", "ipsum", null, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=451", "Pariatur vel veniam dolorum quam ea reprehenderit eum at delectus nostrum vero repellendus nostrum praesentium ea voluptas quos dolorum vitae.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), 987756071, 470, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "Bosco LLC", "El Salvador Colon methodologies JSON" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_UserAccounts_CHECKED_OUT_BY",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_CHECKED_OUT_BY",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CHECKED_OUT_BY",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CHECKED_OUT_DATE",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "DUE_DATE",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Madge Lang", "totam", "https://picsum.photos/50/50/?image=516", "Aliquid eum laborum quis sunt non eligendi ullam deleniti debitis doloremque unde perspiciatis laudantium voluptas molestiae ad odio quasi voluptatem.", 371573908, 521, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "Leuschke - Cormier", "Electronics & Tools bypassing California" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mireya McCullough", "laudantium", "https://picsum.photos/50/50/?image=438", "Enim distinctio quia commodi dolores consequuntur nisi consequuntur doloribus deleniti quidem qui qui saepe iusto eum est sequi molestias reiciendis.", 743899247, 403, new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "Berge - Terry", "communities withdrawal Frozen" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kayla Halvorson", "nulla", "https://picsum.photos/50/50/?image=365", "Doloremque possimus atque quam sunt inventore vel quibusdam nemo iure culpa quo eligendi sed rerum saepe sit quaerat sint vel.", 204433492, 62, new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), "Morar, Willms and Schowalter", "infrastructures web-readiness protocol" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AUTHOR", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Edward Kiehn", "https://picsum.photos/50/50/?image=553", "Dolorem praesentium occaecati necessitatibus voluptas repellendus dolore sed temporibus quod ut qui repellat voluptatem labore et molestiae accusantium maxime alias.", 146470699, 664, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), "Glover - Hermann", "payment integrated Home Loan Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Bettye Wisozk", "aut", "https://picsum.photos/50/50/?image=795", "Est quos voluptatem dolores adipisci sapiente dolorum corporis recusandae laudantium et possimus nisi autem et amet beatae unde in tempora.", 702131600, 176, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), "Daugherty, Shanahan and Lebsack", "pixel Avon holistic" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Malcolm Shields", "hic", "https://picsum.photos/50/50/?image=223", "Molestias ut alias et qui reprehenderit ducimus qui odio non illo quas dolores neque consequatur quam quia quis delectus non.", 707457854, 321, new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), "Connelly, Kerluke and Nikolaus", "Personal Loan Account Pitcairn Islands Forge" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Emilie Swaniawski", "accusamus", "https://picsum.photos/50/50/?image=783", "Illo in sit in pariatur voluptatem enim tempora rerum pariatur voluptatum quia in asperiores deleniti possimus maxime iste repellendus officiis.", 790781708, 467, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), "Mayer, Quigley and Rippin", "Plastic Pike ubiquitous" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Luis Krajcik", "aut", "https://picsum.photos/50/50/?image=699", "Repellat rerum molestiae est qui sint et et assumenda aut corrupti minima veniam fuga est fuga vero cupiditate eaque voluptatem.", 902883336, 356, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), "Wiza, Cummerata and Weber", "overriding deliver Chief" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Odell Schimmel", "corporis", "https://picsum.photos/50/50/?image=747", "Adipisci libero est distinctio maiores nesciunt sint facilis beatae facilis rem voluptatum aperiam reprehenderit voluptatem unde ut quaerat molestiae magnam.", 979979712, 565, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "Keeling, McKenzie and Gorczany", "National white quantify" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Paige Feeney", "est", "https://picsum.photos/50/50/?image=842", "Non quas omnis ducimus consequatur deleniti quod labore asperiores quia magni atque voluptatem rerum neque odio sed esse ea aut.", 735164012, 340, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), "Bailey and Sons", "Liechtenstein withdrawal software" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Cleta Price", "commodi", "https://picsum.photos/50/50/?image=386", "Incidunt adipisci inventore voluptatem amet non sit aliquid facere maiores voluptatem et facilis eius culpa iusto sit odio libero iure.", 494481323, 994, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), "Boehm - Glover", "Handcrafted Rubber Mouse Cotton matrix" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alyson Walter", "fugiat", "https://picsum.photos/50/50/?image=403", "Ut officiis a perferendis qui veniam molestias harum qui dolorum temporibus quis asperiores culpa id ducimus recusandae nulla veniam fuga.", 129015943, 484, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), "Langworth and Sons", "SSL Liaison Gorgeous" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Catalina Emard", "aut", "https://picsum.photos/50/50/?image=379", "Aperiam a ut similique placeat voluptates sequi deleniti quisquam ratione est velit impedit consequuntur et quia cupiditate qui quod voluptatum.", 418736660, 501, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), "Little, O'Kon and Willms", "Rustic Metal Gloves Cotton Metrics" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Shania Pacocha", "voluptate", "https://picsum.photos/50/50/?image=137", "Facilis quia possimus modi animi et voluptas harum natus quidem doloremque sint temporibus corrupti non autem facilis autem iste quia.", 770407573, 292, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), "Kshlerin and Sons", "alarm Buckinghamshire backing up" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Marie Feeney", "ut", "https://picsum.photos/50/50/?image=1049", "Consequatur sunt quos sit sapiente soluta deleniti blanditiis et quidem architecto consectetur ut vitae omnis in sit ad voluptate molestiae.", 411179307, 601, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Jaskolski, Hirthe and Keeling", "optical bluetooth cyan" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lane Bartoletti", "quam", "https://picsum.photos/50/50/?image=841", "Asperiores corporis aut ut et perspiciatis odio deserunt eveniet quod impedit numquam ut voluptatem fugiat excepturi et autem laborum asperiores.", 715948820, 225, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "Abbott, Jones and Schaefer", "Credit Card Account Movies Virginia" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Tressa Streich", "voluptas", "https://picsum.photos/50/50/?image=471", "Deleniti qui ut accusamus quasi non dolores possimus et eos doloribus odit omnis nihil nam repellendus ullam aliquid praesentium aperiam.", 297886920, 588, new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), "Gorczany Group", "Chief Personal Loan Account Mississippi" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ebony Dicki", "repudiandae", "https://picsum.photos/50/50/?image=95", "Earum quam eum consequatur unde blanditiis temporibus magni et fugit adipisci rerum quibusdam aperiam sed iusto animi quidem voluptatibus eos.", 890654102, 912, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), "Cummerata - Franecki", "Ports Station synergies" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Elmore Nicolas", "adipisci", "https://picsum.photos/50/50/?image=155", "Aperiam cupiditate est veniam inventore tempora ipsa et qui consequatur qui quis similique explicabo odit ea rerum consequatur eos similique.", 539165734, 830, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), "Goodwin, McClure and Langosh", "Street pixel Fantastic Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Vivien Leffler", "aspernatur", "https://picsum.photos/50/50/?image=1011", "Est eum dolorem voluptatem excepturi eum molestiae laborum doloremque inventore fuga in qui eum illum unde praesentium officia ad aut.", 333451232, 634, new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "Bergnaum and Sons", "Court strategic Garden & Garden" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Cindy Adams", "ipsum", "https://picsum.photos/50/50/?image=438", "Consequatur quam corrupti voluptates debitis cupiditate dolorum quia neque et ut ea in velit porro qui asperiores omnis et qui.", 473914166, 560, new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), "Romaguera, Bruen and McCullough", "Lebanese Pound Sports & Health Berkshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Geoffrey Huels", "vero", "https://picsum.photos/50/50/?image=711", "In consequatur perspiciatis qui fuga et quo molestiae et consequatur esse iste sed atque magnam nihil asperiores voluptatem voluptas sed.", 479846557, 376, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), "Kuvalis, Herman and Lynch", "Rustic Fresh Shirt Haiti XSS" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Barney Windler", "vel", "https://picsum.photos/50/50/?image=226", "Enim fugiat eveniet in sapiente rerum qui id id expedita libero voluptate et molestias quis deleniti fugiat nisi minus autem.", 149570147, 875, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "Pfeffer - Nolan", "Serbia parse Directives" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Chauncey Jones", "eveniet", "https://picsum.photos/50/50/?image=777", "Qui est quae beatae quia unde sit voluptas rem voluptatem voluptatum voluptas ut et voluptatum occaecati dicta et qui aut.", 760666234, 461, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), "Steuber, Murazik and Kshlerin", "River Papua New Guinea Circle" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Cayla Witting", "assumenda", "https://picsum.photos/50/50/?image=560", "Est sed repellendus sint et et corporis possimus illo dolores saepe sequi eum quas repellendus cumque velit error quos earum.", 857676432, 392, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Stark - Hermiston", "silver interactive architecture" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Everardo Ullrich", "dolorem", "https://picsum.photos/50/50/?image=437", "Corporis ut enim veniam et dolore et velit ad distinctio quidem qui vel ab error similique dolorum aperiam voluptatem neque.", 428495078, 238, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "Schinner - Batz", "visualize intuitive program" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Juliana Haag", "eaque", "https://picsum.photos/50/50/?image=72", "Culpa exercitationem vel dolores assumenda et inventore quam delectus minus dicta aliquid ut dolores repudiandae eveniet sit in ab accusamus.", 561983063, 421, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), "Walsh LLC", "Dong SSL Ukraine" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Milford Schroeder", "reiciendis", "https://picsum.photos/50/50/?image=710", "Quia sint iste voluptatem minus qui odit qui iusto sunt exercitationem odio et dignissimos consectetur ullam placeat aperiam doloremque qui.", 216229626, 806, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), "Berge, Jacobs and Botsford", "Texas magenta Awesome Soft Pizza" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kathryn Bode", "explicabo", "https://picsum.photos/50/50/?image=851", "Alias corrupti ea unde modi aut voluptas quia est nulla et nulla qui nihil ullam qui harum voluptatem dolorem et.", 112829357, 338, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), "Schroeder, Schuster and Mills", "parsing e-markets Human" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rusty Yost", "sint", "https://picsum.photos/50/50/?image=5", "Rerum laudantium sit rem velit vel ex et autem sed fuga doloribus laborum animi omnis et fuga ex eligendi ex.", 784882285, 290, new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), "Reichert Inc", "Plastic Paradigm Horizontal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Karen Feest", "quibusdam", "https://picsum.photos/50/50/?image=914", "Accusantium fugiat amet libero molestiae quos accusamus quos fuga iste ducimus enim sint veniam nam et magnam odio recusandae et.", 509052475, 858, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Satterfield, Labadie and Hamill", "Fantastic Rubber Pants Beauty process improvement" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alejandrin Lubowitz", "quaerat", "https://picsum.photos/50/50/?image=170", "Dolores veniam est rerum atque temporibus aliquam aliquam illo quasi debitis non nihil et facilis et quis id laborum voluptatem.", 167597620, 930, new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), "Block, Kulas and Bosco", "Sleek Credit Card Account compressing" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Marley McCullough", "aut", "https://picsum.photos/50/50/?image=940", "Non et repellendus temporibus et minima consequatur soluta consequuntur culpa cum facilis quae ipsum rem ut nobis non deserunt ut.", 903590152, 441, new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), "Rice - Nikolaus", "Ergonomic Cameroon Developer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Danielle Cole", "officiis", "https://picsum.photos/50/50/?image=794", "Occaecati itaque nulla repellat ut non incidunt vero sint repellat consequatur eum similique explicabo eaque temporibus et et autem voluptatem.", 542005903, 558, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), "Pagac, Blanda and Walker", "Checking Account Granite Unbranded" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Eula Conn", "nihil", "https://picsum.photos/50/50/?image=901", "Qui vel occaecati voluptatem occaecati sint architecto qui dolorem quae optio cum autem nulla sed non nesciunt nisi quae eos.", 624722456, 339, new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), "Dooley, Ward and Schinner", "bluetooth Ergonomic Regional" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Nyah Homenick", "exercitationem", "https://picsum.photos/50/50/?image=193", "Totam quas debitis voluptas adipisci atque commodi molestiae nisi quam qui natus dolore pariatur aperiam et aut deleniti aut dolorem.", 847386727, 884, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), "Gulgowski - Hilpert", "SDD synthesizing success" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Shaylee Hane", "tempora", "https://picsum.photos/50/50/?image=7", "Excepturi eveniet quibusdam optio amet enim repudiandae non officia id aspernatur maxime sed repudiandae officiis delectus accusamus dolor vel ut.", 155619421, 731, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), "Beatty LLC", "brand end-to-end Analyst" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rylee Stroman", "nemo", "https://picsum.photos/50/50/?image=139", "Enim aut repudiandae exercitationem a maiores voluptas consequatur minus consequatur amet quia mollitia dolor laborum reiciendis amet voluptas nihil excepturi.", 924892285, 929, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), "Bashirian and Sons", "back up Accountability payment" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Bradford Berge", "molestiae", "https://picsum.photos/50/50/?image=377", "Corrupti omnis tempora totam consequatur impedit praesentium nesciunt eaque consequatur rerum reprehenderit odio error eaque est voluptatem distinctio in et.", 967572328, 283, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), "Hane, Weissnat and Ullrich", "Berkshire optical haptic" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Easton Witting", "tenetur", "https://picsum.photos/50/50/?image=305", "Vel quaerat ea reiciendis nulla enim quia quae a sed eum dignissimos omnis vel aspernatur doloremque earum minima molestiae nam.", 689345858, 954, new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "Daugherty and Sons", "Points Executive frictionless" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dashawn Windler", "architecto", "https://picsum.photos/50/50/?image=920", "Voluptate ab ad incidunt tempore illo consequatur temporibus sapiente quia mollitia veritatis ut et omnis est dolor ea fugiat sunt.", 652908508, 661, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "Ruecker, Schamberger and Kerluke", "Steel Court back-end" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lauryn Bode", "doloremque", "https://picsum.photos/50/50/?image=472", "Est blanditiis distinctio dolores deleniti perferendis asperiores vero cupiditate quidem aut qui voluptatem et aut et est nam velit quibusdam.", 456006965, 239, new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "Schumm Inc", "value-added Mississippi Networked" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rozella Volkman", "adipisci", "https://picsum.photos/50/50/?image=126", "Rerum rerum laboriosam quia mollitia ipsum et et et nisi occaecati quibusdam sed est eveniet incidunt doloremque ratione veritatis ea.", 385814869, 114, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), "Hilpert - Emmerich", "driver mobile Russian Ruble" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Timothy Lakin", "non", "https://picsum.photos/50/50/?image=251", "Deserunt voluptatem voluptatum aperiam quod sit beatae consequuntur sunt magni dicta repudiandae omnis voluptatum perspiciatis consequatur laudantium ut officiis ad.", 278229548, 775, new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), "Koss, Williamson and Marks", "Enhanced Loaf deposit" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jayne Boehm", "reiciendis", "https://picsum.photos/50/50/?image=1083", "Doloremque quia ad fugiat in quod tenetur aut est voluptates cumque et quidem repellat aspernatur similique eligendi ex consequuntur aliquam.", 966961663, 118, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Local), "Kassulke, Murphy and Swaniawski", "SQL core withdrawal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jaycee Walker", "harum", "https://picsum.photos/50/50/?image=425", "Animi rerum doloremque non nobis et qui ea aut omnis et quidem sit et aut minima quia debitis beatae omnis.", 326673108, 128, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "Adams - Dach", "El Salvador haptic Garden" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Marjory Morissette", "atque", "https://picsum.photos/50/50/?image=1054", "Sint dolores numquam enim repudiandae quia optio minima magnam numquam ut tempora explicabo id eum mollitia officia voluptas minima rerum.", 942689508, 632, new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), "Thompson Group", "Island Small Rubber Pants Plains" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ed Nolan", "dicta", "https://picsum.photos/50/50/?image=657", "Reprehenderit commodi aut repellat iure velit esse sunt impedit rem neque et alias harum ipsam rem repellat omnis quidem quod.", 528054998, 286, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Corkery, Batz and Blick", "Licensed Plastic Tuna sexy Communications" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Constance Harris", "aut", "https://picsum.photos/50/50/?image=733", "Consequatur voluptatum praesentium perferendis dolorem laboriosam velit sed veritatis minima commodi placeat nostrum aspernatur quia qui voluptas corporis sed est.", 295601123, 51, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), "Legros, Gerlach and Blick", "Agent matrix deploy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Brice Ebert", "qui", "https://picsum.photos/50/50/?image=441", "Debitis voluptatem eos minima voluptas quos aut sed maxime hic hic magni atque in labore veritatis sed omnis in eum.", 315042982, 129, new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), "Ward, Terry and Moen", "parsing Guinea Fundamental" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "April Thompson", "odit", "https://picsum.photos/50/50/?image=1073", "Voluptatem quam ullam ipsa itaque velit sunt deleniti repellendus ullam sit vitae quos dolor repellendus numquam molestiae qui eligendi maiores.", 750123590, 513, new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "Kulas - McCullough", "Practical Fresh Gloves Berkshire black" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Baron Cole", "voluptatem", "https://picsum.photos/50/50/?image=757", "Nemo quia sit cupiditate et debitis explicabo non saepe expedita perferendis consequatur dolores qui autem cum ea nam voluptas ad.", 603272044, 187, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Local), "Medhurst LLC", "Investment Account auxiliary Money Market Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Amy Cronin", "ea", "https://picsum.photos/50/50/?image=213", "Est accusantium maiores nihil consectetur illum nam fuga aut vero non tempora nesciunt nesciunt dolores quam doloremque temporibus voluptas soluta.", 623227603, 61, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), "Bahringer - Turner", "channels card Optimization" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Cordell Crona", "laboriosam", "https://picsum.photos/50/50/?image=844", "Accusamus ad sit vel est eum cum recusandae numquam aut culpa tempore quisquam amet harum quaerat dolores delectus accusantium sint.", 822988323, 196, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), "Vandervort Group", "Auto Loan Account mobile bandwidth-monitored" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Afton Armstrong", "dignissimos", "https://picsum.photos/50/50/?image=311", "Ut dolor quo accusamus quidem accusantium modi ea alias quia exercitationem eligendi dolorem cum assumenda vitae aut beatae quo libero.", 617796888, 476, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Local), "Balistreri LLC", "dynamic Unbranded Rubber Salad Bahamian Dollar" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Vincent Hyatt", "voluptas", "https://picsum.photos/50/50/?image=505", "Asperiores voluptatem aut sapiente rem omnis corrupti facere veritatis veniam sint fuga placeat officiis in necessitatibus rerum sint odio rerum.", 308002227, 801, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Local), "Bogan - Moore", "challenge Parkway Berkshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Maurine Krajcik", "ea", "https://picsum.photos/50/50/?image=148", "Nam non qui enim veniam quibusdam modi facilis reprehenderit et recusandae nam et molestias ipsa et cum neque aut magni.", 451720544, 805, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "Bradtke, Turcotte and Carroll", "fuchsia Face to face Savings Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Merritt Skiles", "in", "https://picsum.photos/50/50/?image=89", "Quaerat possimus tenetur blanditiis eveniet eius inventore totam officia nemo aut atque vel at quia aut laboriosam sit temporibus quis.", 205008178, 577, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), "Howell and Sons", "Cambridgeshire Organic International" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Myrl Wuckert", "voluptas", "https://picsum.photos/50/50/?image=242", "Perspiciatis molestias omnis sapiente perferendis vitae placeat qui sit porro atque blanditiis ab doloribus ut perspiciatis maxime repellat mollitia dolorem.", 251374798, 531, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), "Stokes - Koss", "leverage National conglomeration" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Oswald Streich", "nobis", "https://picsum.photos/50/50/?image=706", "Qui molestias eveniet ut voluptatem occaecati eum distinctio sit at cupiditate labore quod totam velit rerum sint deserunt quaerat dicta.", 999142781, 288, new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), "Murray - Terry", "deposit Refined Principal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alec Bailey", "et", "https://picsum.photos/50/50/?image=423", "Provident et aut porro molestias sed ea officiis excepturi quasi cupiditate vitae at rerum suscipit dolores similique sint minus aut.", 884050470, 746, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "Klein - Botsford", "backing up Australia Legacy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Justus Cronin", "sequi", "https://picsum.photos/50/50/?image=658", "Porro laboriosam placeat est modi quia aperiam totam omnis eveniet voluptas qui asperiores culpa ex ut nisi quibusdam fugit nobis.", 385354171, 352, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), "Kozey, Vandervort and Yost", "Director hack National" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Arely Heaney", "accusantium", "https://picsum.photos/50/50/?image=473", "Reiciendis porro quas quia dicta voluptatibus ducimus impedit maxime corporis dolores voluptate illum aut ut perspiciatis ipsum quae rerum cum.", 101846816, 320, new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Local), "Crooks, Kshlerin and Bernier", "Tasty Frozen Fish leverage deliverables" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kelton Collins", "molestiae", "https://picsum.photos/50/50/?image=406", "Et voluptate vero consequatur et maxime itaque qui nulla quam voluptatem qui veritatis nihil similique autem qui a sit nostrum.", 923539324, 771, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), "Hills Inc", "Rubber Checking Account District" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Curtis Rath", "enim", "https://picsum.photos/50/50/?image=841", "Aut numquam mollitia omnis ex sint provident ut est consequatur itaque quasi hic quae ipsam fugiat ea numquam nobis nihil.", 387070785, 994, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), "Rodriguez - Larkin", "Borders Svalbard & Jan Mayen Islands Robust" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Emanuel Collier", "incidunt", "https://picsum.photos/50/50/?image=3", "Sit numquam sequi placeat quas sit officiis vel ea ducimus molestiae qui est ut qui cupiditate dignissimos tempore sunt est.", 458188196, 602, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), "Armstrong, Feil and Gutkowski", "Awesome Metal Sleek Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Charley Balistreri", "ullam", "https://picsum.photos/50/50/?image=136", "Eum libero quam dolorem repellendus quibusdam numquam nostrum ratione qui corrupti et voluptatem qui recusandae quo ipsam eum voluptatibus aspernatur.", 218111320, 298, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "McKenzie, Barrows and Smith", "dot-com connecting program" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Oliver Sporer", "odit", "https://picsum.photos/50/50/?image=106", "Debitis ut iste neque cupiditate quam consequatur tempora facere perferendis odit qui cum perferendis qui et molestiae a autem voluptatem.", 906122695, 781, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), "Mitchell Inc", "Auto Loan Account Auto Loan Account local" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ova Wiegand", "qui", "https://picsum.photos/50/50/?image=545", "Rerum culpa dolor repudiandae quia necessitatibus et error illo blanditiis minima quis sint voluptates rerum natus et fugiat ut ut.", 731376239, 448, new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), "Cassin LLC", "hack efficient end-to-end" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hal Blick", "provident", "https://picsum.photos/50/50/?image=546", "Quibusdam non consectetur itaque error quis porro voluptatem ipsam aut consequatur rerum voluptas non ut iure sequi reprehenderit tempora sit.", 239911048, 797, new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "Rowe, Yundt and Vandervort", "Specialist Investment Account Alley" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jeanette Schneider", "assumenda", "https://picsum.photos/50/50/?image=416", "Aut expedita omnis aut molestias sequi aut est tempore enim sit debitis et libero quis maxime iure eius veniam velit.", 439987411, 824, new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), "Harvey - Muller", "Money Market Account Mission Incredible Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mossie Rice", "et", "https://picsum.photos/50/50/?image=646", "Tempora ut autem accusamus ea dicta nostrum non deleniti eum quibusdam ab in illum enim dolorem dolor amet ut non.", 267924791, 881, new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), "Runte LLC", "communities withdrawal Qatari Rial" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Nathen Goodwin", "fuga", "https://picsum.photos/50/50/?image=460", "Praesentium ullam est aut aut hic sequi beatae voluptate et enim possimus non cupiditate ut quia expedita reiciendis reiciendis eum.", 862807061, 774, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), "Flatley Inc", "Virginia override Kansas" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Elvie McDermott", "voluptates", "https://picsum.photos/50/50/?image=286", "Rerum itaque voluptas id accusamus quae animi optio amet ut et quo veritatis veritatis quo quia aperiam laborum praesentium labore.", 326749860, 841, new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), "Lebsack, Rippin and Padberg", "Product Plastic Licensed Frozen Car" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Johnny Bernier", "aut", "https://picsum.photos/50/50/?image=400", "Iusto voluptatibus dolor non eius nobis iure assumenda velit aut sed totam quae quia voluptatem qui vel cum autem reprehenderit.", 270883989, 331, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "Sawayn LLC", "Gorgeous Concrete Keyboard Infrastructure ADP" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Easton Sawayn", "nulla", "https://picsum.photos/50/50/?image=704", "Quis assumenda aut ut numquam et ut deserunt assumenda nulla culpa eius consequatur cum nostrum sed quo vitae ipsa voluptas.", 609953850, 746, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), "Schowalter Inc", "leading-edge Analyst Upgradable" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rylan Kirlin", "quasi", "https://picsum.photos/50/50/?image=651", "Non nobis quod aut quos perferendis quo maiores debitis expedita architecto sit dolor doloremque incidunt quo ut quos quo aut.", 729782788, 570, new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), "Jacobi, Harris and Monahan", "Unbranded functionalities Auto Loan Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Luisa Quigley", "quod", "https://picsum.photos/50/50/?image=1041", "Corporis amet soluta et et a maxime doloremque voluptatem et aut asperiores dolorem natus doloremque repellendus perferendis vel esse sunt.", 867671170, 490, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Vandervort, Daugherty and Barrows", "Bedfordshire contingency UIC-Franc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mikayla Boyer", "cum", "https://picsum.photos/50/50/?image=631", "Repellat labore omnis mollitia dicta nostrum eos minima quia quibusdam non distinctio fuga libero a aut ratione molestiae sed dolorem.", 952348641, 252, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "O'Hara, Batz and Schulist", "quantifying streamline National" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Barrett Sipes", "quaerat", "https://picsum.photos/50/50/?image=501", "Id recusandae id vero perferendis est voluptate illum reiciendis omnis molestiae architecto voluptatem exercitationem officiis quia neque aperiam veritatis dolorem.", 827775810, 209, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Morissette, Huels and Roob", "Accounts Credit Card Account Metal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Leonardo Zemlak", "et", "https://picsum.photos/50/50/?image=937", "Atque dolorem praesentium dicta et quod et nostrum dignissimos explicabo quod eum sunt sit rerum suscipit dolor enim unde at.", 448230623, 797, new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Rippin - Keeling", "Frozen Credit Card Account communities" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mittie Powlowski", "occaecati", "https://picsum.photos/50/50/?image=43", "Sapiente ratione sint maiores maiores dolores maiores dolor rerum quia nihil perferendis cupiditate quis aspernatur eveniet aut est in ipsum.", 676743446, 343, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "Williamson and Sons", "portals Ouguiya Central" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Chaim Schultz", "aut", "https://picsum.photos/50/50/?image=671", "Illum et aperiam et et nam omnis eum ab consequatur facere ea ducimus est modi qui nulla illo qui eum.", 199478769, 579, new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), "Kautzer - Robel", "Investor Rustic Metal Gloves Industrial, Grocery & Toys" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Queen Barrows", "libero", "https://picsum.photos/50/50/?image=213", "Dolores sit aliquid qui sed illum non sed sequi ut eos necessitatibus vel aut ratione consequuntur culpa earum ab aperiam.", 957440822, 266, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), "Lebsack, Nienow and Rutherford", "Specialist Synergized PNG" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Chadrick Thompson", "tempore", "https://picsum.photos/50/50/?image=565", "Eum dolore debitis eos voluptatem aperiam reprehenderit provident enim amet officiis modi culpa blanditiis totam alias eos ea consequuntur omnis.", 252166184, 977, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), "Hickle, Roob and Jerde", "e-services pink Soft" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Megane Feest", "sint", "https://picsum.photos/50/50/?image=526", "Dolor eos consequatur officia numquam eaque nulla natus ut veritatis debitis occaecati placeat ad at in tempora sapiente numquam iusto.", 969590767, 96, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "King, Windler and Lockman", "Avon Auto Loan Account Terrace" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lon Will", "asperiores", "https://picsum.photos/50/50/?image=80", "Laboriosam molestias et veritatis quia praesentium et eum nihil dolores ab aut est quo hic sint itaque eos molestiae qui.", 853135604, 671, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), "Johnston Group", "Utah virtual program" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Haven Conroy", "beatae", "https://picsum.photos/50/50/?image=548", "Consectetur quo consequatur dignissimos in nesciunt consequatur dolor atque saepe vel perspiciatis eius id dolor placeat optio nihil atque sunt.", 458988991, 287, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), "Funk Group", "magenta Investor hard drive" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Roxanne Carter", "aut", "https://picsum.photos/50/50/?image=1036", "Aliquam pariatur voluptas autem asperiores omnis saepe ut ex alias soluta eos in sit ullam voluptatem corrupti sint omnis provident.", 836110580, 265, new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), "Kuhic - Lueilwitz", "generating content killer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Declan Schulist", "possimus", "https://picsum.photos/50/50/?image=514", "Adipisci asperiores rerum atque fugiat architecto aut qui et dignissimos officiis sed suscipit ab et est temporibus atque est voluptatem.", 733239327, 856, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Local), "Kertzmann Inc", "SCSI interactive Isle" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Randal Gerlach", "aliquid", "https://picsum.photos/50/50/?image=49", "Necessitatibus odit totam odio et vitae doloribus voluptatem nulla quis distinctio accusamus ut rem modi laboriosam porro eveniet aliquid sed.", 391118516, 600, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "Lang, Weissnat and Bartell", "Overpass coherent niches" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sanford Tromp", "omnis", "https://picsum.photos/50/50/?image=164", "Fugiat minima consequatur incidunt explicabo ut at labore aut facere accusamus eveniet ut quod voluptas ut dolores nihil placeat alias.", 321545648, 439, new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), "Fadel Inc", "navigating Tasty circuit" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ivy VonRueden", "accusantium", "https://picsum.photos/50/50/?image=878", "Fugit reprehenderit sequi et qui ad consequatur ducimus consectetur consequatur eaque et vel placeat ab autem ipsa aperiam aut saepe.", 388769637, 58, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), "Olson and Sons", "Via bandwidth pixel" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ezequiel Kemmer", "explicabo", "https://picsum.photos/50/50/?image=792", "Minus autem asperiores alias dolores eum veniam quo sit atque dignissimos alias velit temporibus id officiis expedita ut repudiandae rerum.", 884444004, 955, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), "Kilback and Sons", "SQL Forges yellow" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Matteo Goldner", "rerum", "https://picsum.photos/50/50/?image=350", "In aut sequi iste dicta ea quia et excepturi ducimus autem aperiam qui aliquid laboriosam nam placeat qui non accusamus.", 553284259, 634, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "Bergnaum - Kshlerin", "deposit Human Unbranded Steel Bacon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Breanna Anderson", "quis", "https://picsum.photos/50/50/?image=810", "Aut vel unde officia modi non dolores saepe quod ut quaerat quis adipisci occaecati dolores voluptate aut eligendi pariatur rerum.", 844180651, 411, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), "Considine Group", "Peru cutting-edge Principal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Eloise Koss", "id", "https://picsum.photos/50/50/?image=277", "Ut quia natus amet et quam porro commodi sunt ex culpa ex aut modi magnam enim eum eligendi omnis ipsum.", 732461167, 552, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), "McLaughlin, Prosacco and Satterfield", "Denar Synchronised overriding" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Colton Jaskolski", "est", "https://picsum.photos/50/50/?image=81", "Occaecati eos illo quo tenetur quo aut qui iure eveniet ex nam hic voluptas porro officia est incidunt sapiente quidem.", 386064541, 986, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "Howe, Halvorson and Cronin", "AI Ohio aggregate" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Braden Kertzmann", "beatae", "https://picsum.photos/50/50/?image=689", "Est consequatur facilis rerum ducimus quas in aut sit velit in deserunt quia est ipsum similique consequatur nam necessitatibus ipsam.", 863253150, 894, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), "Lindgren LLC", "South Carolina Jersey Rustic Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Donnie Schinner", "magni", "https://picsum.photos/50/50/?image=271", "Voluptatum necessitatibus vel facilis est velit maiores libero sunt ducimus voluptatem velit enim quia repellat ut totam voluptatibus autem sint.", 591758949, 250, new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), "Botsford and Sons", "5th generation 24 hour Cuban Peso" });
        }
    }
}
