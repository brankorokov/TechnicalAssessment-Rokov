using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechnicalAssessmentRokov.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAspNetUserBuilder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "EmailIndex",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "AspNetUsers");

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Royal Dietrich", "officiis", "https://picsum.photos/50/50/?image=14", "Vel quia eum et ea eum voluptatem enim aspernatur est mollitia quis ut id ad similique esse quo recusandae explicabo.", 757066939, 789, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "O'Keefe - Ankunding", "Granite Mobility interfaces" });

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
                columns: new[] { "AUTHOR", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Arthur Lakin", "https://picsum.photos/50/50/?image=989", "Nihil tenetur quo qui autem architecto voluptatem aut itaque cumque ad maiores et ut amet repellendus delectus error facere cupiditate.", 545911813, 394, new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "Murazik - Connelly", "Awesome web-enabled monetize" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jamir Mertz", "sit", "https://picsum.photos/50/50/?image=611", "Qui atque voluptate consequatur aut sit ab temporibus quo culpa minus quasi saepe deleniti sed unde unde expedita est vitae.", 640770888, 768, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "Wolf, Schuppe and Terry", "Kina focus group Personal Loan Account" });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "August Williamson", "sed", "https://picsum.photos/50/50/?image=849", "Et saepe est omnis praesentium quisquam id libero et eum maiores fugiat dolore omnis ut voluptatem facere omnis perferendis facere.", 811759703, 598, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), "Price and Sons", "feed Passage Automotive, Toys & Health" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rosalia Stamm", "dolorum", "https://picsum.photos/50/50/?image=407", "Cumque illo eaque sed nulla id officia consequatur nisi labore nostrum et nihil iusto veniam maiores odio est voluptates ratione.", 713502786, 789, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), "O'Hara - Turner", "Investor Berkshire Rest" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Idell Mertz", "voluptatem", "https://picsum.photos/50/50/?image=605", "Accusamus inventore tenetur esse quam deserunt laboriosam maiores ut nesciunt pariatur rem deserunt cupiditate voluptatum autem soluta eos ipsam est.", 509062174, 383, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), "Kihn, Marvin and Mayer", "synthesize executive magenta" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ottis Kshlerin", "in", "https://picsum.photos/50/50/?image=221", "Dolores harum incidunt perspiciatis possimus voluptatibus dolor enim similique consequatur non impedit labore incidunt hic voluptate ut quod modi minima.", 117603900, 738, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), "O'Conner and Sons", "Vietnam Frozen program" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Madisyn DuBuque", "aut", "https://picsum.photos/50/50/?image=845", "Provident commodi omnis earum ut facilis ducimus et debitis occaecati quis sed dolorum temporibus ut exercitationem numquam consequatur dolor tempore.", 937828497, 336, new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), "Klocko - Swift", "flexibility protocol Global" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Woodrow Schroeder", "dolores", "https://picsum.photos/50/50/?image=316", "Aliquam fuga deserunt quo illum ipsum exercitationem enim laborum est eligendi voluptas quisquam aspernatur soluta ea adipisci sit enim ut.", 673474417, 637, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), "Stark - Rempel", "AGP Fiji help-desk" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Freddie Jones", "reprehenderit", "https://picsum.photos/50/50/?image=688", "Numquam deserunt similique perferendis ea beatae atque est ipsam sint error iure quod facere numquam necessitatibus voluptatem ut praesentium hic.", 240977366, 527, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), "Corwin, Batz and Schinner", "Small Soft Fish Spurs Virgin Islands, U.S." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "June Pfannerstill", "delectus", "https://picsum.photos/50/50/?image=303", "Eum velit libero rem debitis nisi voluptatum temporibus neque sit ullam sequi libero iste dignissimos animi ullam libero accusamus sunt.", 461368916, 64, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), "Dooley Group", "Fiji Dollar heuristic Operations" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Aric Parker", "soluta", "https://picsum.photos/50/50/?image=895", "Ut blanditiis quia nam repellat voluptas quidem maiores aliquid a pariatur eos deserunt enim sed minus id et illo a.", 137018155, 520, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "Hintz - Tillman", "hacking teal Brooks" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jamir Turcotte", "id", "https://picsum.photos/50/50/?image=562", "A sint consequuntur neque nisi velit et ipsa qui quod magni qui sed eum corrupti iure ipsam repellendus sed odio.", 144351803, 445, new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Local), "Weissnat, Morar and Wiegand", "Ergonomic Dynamic quantifying" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rogelio Walter", "sed", "https://picsum.photos/50/50/?image=684", "Qui error voluptatem non et consectetur veritatis dolores et aut provident quasi vitae recusandae labore qui hic odio sequi laudantium.", 498091011, 101, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), "Sipes - Goyette", "Handmade Metal Shoes Wisconsin India" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Vernie McCullough", "provident", "https://picsum.photos/50/50/?image=687", "Accusamus natus odio voluptates perferendis illum et neque qui quibusdam sint occaecati est autem beatae ut et nobis vel cumque.", 306606636, 486, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), "Murazik LLC", "Bond Markets Units European Composite Unit (EURCO) productivity EXE" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Elva Brown", "voluptatem", "https://picsum.photos/50/50/?image=944", "Quia ut aut molestiae repellat tempora et culpa nihil dicta fuga temporibus similique quae et dolores cupiditate repudiandae doloremque vel.", 228954485, 577, new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "Larkin, Kozey and Pacocha", "Tasty primary Music" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Madelynn Becker", "nulla", "https://picsum.photos/50/50/?image=739", "Sint quidem non dolorem est nostrum aliquam beatae enim omnis qui impedit labore exercitationem blanditiis asperiores eos consequatur rerum qui.", 923721207, 994, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), "Emmerich - Zulauf", "Outdoors & Industrial web services Fiji" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alana Howell", "repudiandae", "https://picsum.photos/50/50/?image=312", "Maxime rem est consectetur perspiciatis ut et sed in impedit eos omnis culpa dicta consequatur dolore fugiat itaque libero est.", 745497602, 293, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Rath, Metz and Spencer", "Uzbekistan Team-oriented Buckinghamshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jennifer Luettgen", "nulla", "https://picsum.photos/50/50/?image=1061", "Laboriosam pariatur et repellat distinctio voluptas vel et et laborum recusandae vel quidem corporis iusto sit voluptatibus minima nesciunt officia.", 118770992, 530, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), "Upton Inc", "Officer metrics Manager" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Elyssa O'Reilly", "numquam", "https://picsum.photos/50/50/?image=754", "Autem fugit eveniet sed tempora sint a voluptatibus quaerat autem distinctio aliquid recusandae occaecati aliquam rerum aut architecto qui sunt.", 873898871, 617, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), "Torp - Kertzmann", "Unbranded Fresh Car Sleek Metal Ball Sports & Home" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ron Hilll", "dolorem", "https://picsum.photos/50/50/?image=613", "Quam quia molestias rem repellendus itaque eius excepturi reiciendis deserunt commodi qui possimus voluptate qui laudantium vitae quam esse sed.", 870513634, 501, new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), "Dare and Sons", "Baby, Electronics & Books cross-platform payment" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lauriane Kovacek", "qui", "https://picsum.photos/50/50/?image=477", "Deleniti aut rem hic minus est saepe earum minima qui expedita et delectus perspiciatis rerum totam ea sunt enim aut.", 669767204, 837, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), "Ondricka, Veum and Stokes", "Chief out-of-the-box connect" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jeanne Yundt", "maiores", "https://picsum.photos/50/50/?image=970", "Asperiores omnis reprehenderit dolor omnis excepturi ut facilis saepe eum rerum ea nostrum laborum sed quos aliquid alias ut qui.", 958486964, 241, new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), "Schultz, Cummerata and Walter", "initiative Garden & Sports overriding" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Maci Gleason", "aspernatur", "https://picsum.photos/50/50/?image=596", "Labore culpa ut doloremque velit qui maiores sed voluptas at et consectetur molestias sit sed sed quo praesentium et voluptate.", 162659864, 496, new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), "Haley, Parisian and Russel", "Avon platforms Berkshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Frances Pollich", "optio", "https://picsum.photos/50/50/?image=17", "Tempora consequuntur ex suscipit ad quis quidem incidunt voluptas provident perferendis amet et omnis quidem est voluptas rerum maxime fugit.", 940802196, 681, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), "Marquardt LLC", "Home Loan Account Small Dale" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Vergie Farrell", "veritatis", "https://picsum.photos/50/50/?image=836", "Eos sed vero molestias sit quis atque occaecati velit voluptas et et maiores et delectus rerum ipsum omnis maiores id.", 980285823, 718, new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "Powlowski Inc", "Auto Loan Account Handmade moderator" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Colt Jast", "ratione", "https://picsum.photos/50/50/?image=408", "Unde ut libero consequuntur est distinctio voluptates cupiditate iste culpa debitis ex voluptatibus ratione tempore quibusdam praesentium ratione repellat et.", 434048234, 724, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), "Turcotte - Terry", "Fresh Cambridgeshire Hawaii" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Herbert Stokes", "aliquam", "https://picsum.photos/50/50/?image=880", "Quasi et aliquid saepe eos consequatur iste assumenda rerum debitis non possimus illo odio id pariatur sunt et placeat fugit.", 122962841, 675, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), "Olson - Hauck", "Small Soft Sausages Dynamic Licensed" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Fernando Frami", "natus", "https://picsum.photos/50/50/?image=767", "Debitis eum rerum fugit sunt et ut hic sunt eligendi voluptate esse et unde nulla voluptas perspiciatis quas itaque saepe.", 535691872, 478, new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "Simonis - Beier", "exploit Court Pula" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Art Lebsack", "odit", "https://picsum.photos/50/50/?image=947", "Non voluptas dolores eligendi veniam ab mollitia consectetur ut fuga sunt eum porro quia corrupti non molestiae repudiandae vel et.", 361522772, 577, new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "Lemke - Haley", "deposit Profit-focused Trace" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kaylin Kshlerin", "aliquam", "https://picsum.photos/50/50/?image=260", "Aut magni est autem veniam consequatur autem illo eveniet aut in non rerum tempora delectus odio nihil placeat sunt dolores.", 704907321, 298, new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "Carroll Inc", "azure Russian Federation sky blue" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kellen Jenkins", "tenetur", "https://picsum.photos/50/50/?image=709", "Quia voluptatibus itaque sed dicta qui vitae dolorem temporibus ad reprehenderit ducimus repudiandae veritatis ut earum fugit et eveniet officia.", 597731566, 447, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), "Tillman, Witting and Bauch", "markets Toys, Electronics & Clothing Plastic" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jasen Carter", "quas", "https://picsum.photos/50/50/?image=702", "Id iusto placeat pariatur explicabo in repellendus facere hic libero voluptatibus et debitis aut porro voluptas rerum voluptatem neque omnis.", 265313039, 765, new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "Leffler, Kassulke and Schowalter", "4th generation Junction 3rd generation" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alison Spinka", "a", "https://picsum.photos/50/50/?image=108", "Qui aut accusantium quae animi cum maxime sed asperiores quia voluptates quibusdam qui sed incidunt quia et sit quae quam.", 672423045, 740, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "Koelpin and Sons", "flexibility hacking Customer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "AUTHOR", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jo Beahan", "https://picsum.photos/50/50/?image=648", "Occaecati modi quas adipisci enim consectetur distinctio repudiandae asperiores modi dolor ab dolor illum omnis et ut et illum est.", 260040629, 520, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "Konopelski, Streich and Cormier", "Group models artificial intelligence" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Gayle Parisian", "non", "https://picsum.photos/50/50/?image=8", "Et dolores beatae blanditiis eaque ducimus et nobis ab eum ea qui sed et doloribus aliquam officia et est sequi.", 624004155, 573, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "Blick Group", "payment dynamic Home & Industrial" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Napoleon Dooley", "voluptatum", "https://picsum.photos/50/50/?image=865", "Eveniet dolorem officia ut voluptatibus et eos at velit quae vel maxime voluptates et ut praesentium molestiae qui sunt explicabo.", 115879802, 525, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), "Johnston, Rippin and Tremblay", "Analyst Frozen Program" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Telly Kerluke", "deserunt", "https://picsum.photos/50/50/?image=894", "Eos esse qui maxime quis deserunt tempora deserunt eligendi animi laudantium itaque eos et maxime rerum deserunt itaque a ex.", 300704993, 874, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Roberts, Kihn and Lynch", "emulation e-markets Botswana" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Nayeli Hane", "velit", "https://picsum.photos/50/50/?image=243", "Fuga eius voluptas voluptatem dignissimos deserunt rerum rerum non doloribus voluptatem ea dolorem dolore laboriosam sit accusantium ut natus voluptas.", 902742485, 733, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "Torp - Kertzmann", "Pre-emptive Tools & Kids hacking" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Cole White", "ut", "https://picsum.photos/50/50/?image=856", "Esse perspiciatis quis sed sunt quo ab doloremque rem voluptas omnis omnis necessitatibus amet velit atque possimus porro quis consequatur.", 209565571, 397, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Local), "Douglas - Bradtke", "Gardens back-end Open-architected" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Astrid Schaden", "nihil", "https://picsum.photos/50/50/?image=784", "Quidem consequatur hic est aut corrupti doloremque atque et et sit temporibus est nesciunt cupiditate sunt voluptates ut laboriosam alias.", 872581745, 473, new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), "Conroy Group", "New Hampshire compress synthesizing" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Nigel Metz", "consequuntur", "https://picsum.photos/50/50/?image=944", "Quod distinctio temporibus minus dolor laborum ducimus eos repudiandae nulla cupiditate eos quidem nam molestiae debitis enim inventore dolor esse.", 166609664, 690, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), "Wilkinson Inc", "Hawaii Regional front-end" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Daniela Upton", "consequatur", "https://picsum.photos/50/50/?image=908", "Est ipsam repudiandae et quam reprehenderit eveniet est voluptatum voluptate at nulla et sint error iste vel sapiente corporis cum.", 969027041, 92, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), "Johns, Swift and King", "Frozen Polarised teal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ryder Windler", "aut", "https://picsum.photos/50/50/?image=804", "Rem voluptatem et enim quo perferendis soluta consequatur ea et ea dicta amet rerum voluptas necessitatibus impedit et quaerat dicta.", 300310118, 302, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "Yost - Prosacco", "Investment Account Quality Awesome Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Llewellyn Mertz", "aspernatur", "https://picsum.photos/50/50/?image=490", "Distinctio eum quia esse ea mollitia rerum aut dicta perspiciatis et reprehenderit repudiandae eius itaque accusantium et iusto porro eum.", 862208820, 558, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), "Daugherty - Dietrich", "Auto Loan Account Concrete Practical Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Janessa Casper", "voluptate", "https://picsum.photos/50/50/?image=240", "Aspernatur consectetur nam quia et hic ipsum quae possimus numquam dolores quia cupiditate corrupti totam est quidem ex corrupti dolor.", 703187273, 529, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "Gerlach - Osinski", "proactive Brand THX" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jayne Kuvalis", "ea", "https://picsum.photos/50/50/?image=176", "Natus et voluptatum doloribus quia aut vel sit aut rem quis cumque rerum est est facilis nihil minima sequi recusandae.", 868334221, 215, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "Hirthe - Kunze", "Ghana COM copy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ottilie Nitzsche", "quibusdam", "https://picsum.photos/50/50/?image=300", "Earum sunt quae reiciendis voluptatibus voluptates qui quaerat cupiditate fugiat sed a incidunt est nesciunt ut porro qui nisi suscipit.", 979939888, 764, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), "Brakus LLC", "incentivize connecting compress" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Erica Beer", "sunt", "https://picsum.photos/50/50/?image=117", "Pariatur ut quo quisquam ullam qui repudiandae quasi dolorum saepe fuga eaque non placeat possimus rerum enim alias non rem.", 264834620, 895, new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Local), "Lang - Rath", "Samoa 24/7 Solomon Islands Dollar" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rhea Schumm", "rerum", "https://picsum.photos/50/50/?image=751", "Iusto quae eos sapiente corrupti accusamus et vel consequatur voluptas cum non architecto eligendi sint quidem sunt consequatur et ut.", 353162843, 847, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), "Lubowitz, Donnelly and Jast", "Palladium object-oriented bluetooth" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Macey Moore", "veritatis", "https://picsum.photos/50/50/?image=223", "Voluptas ad dolorem et odit officiis aliquam repudiandae fugit dolor consectetur veritatis non voluptatem non quibusdam porro sed sint dicta.", 119515245, 703, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), "Schoen LLC", "Unbranded Cotton Soap Avon Clothing & Games" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Bartholome Kohler", "perspiciatis", "https://picsum.photos/50/50/?image=339", "Accusantium delectus ipsam repellendus vel ipsam minima eum asperiores aspernatur sint velit pariatur sit exercitationem ut omnis quaerat sit accusamus.", 130419437, 660, new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), "Feil Group", "Tennessee executive deliverables" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lincoln Leffler", "minima", "https://picsum.photos/50/50/?image=950", "Hic aut molestiae quasi autem qui nulla maxime quia nemo soluta accusantium consequatur et adipisci quis nihil sed voluptatem debitis.", 782225762, 995, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), "Schoen, Parisian and Sauer", "uniform engineer Awesome" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Virginie Turner", "voluptatem", "https://picsum.photos/50/50/?image=978", "Eveniet iure voluptate sapiente asperiores tempora sed ut culpa dolor fugiat necessitatibus nihil at asperiores reprehenderit nisi autem suscipit dolorem.", 258545499, 943, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), "Greenholt Inc", "Checking Account Programmable time-frame" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Eino Bradtke", "quam", "https://picsum.photos/50/50/?image=649", "Assumenda est veniam laborum aut praesentium doloribus molestiae officiis dolor maxime necessitatibus fugit non repellat atque aut ducimus consequatur consectetur.", 716823238, 583, new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Kuhic Group", "Shoal Borders Horizontal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Aric Bartell", "voluptatem", "https://picsum.photos/50/50/?image=489", "Quo sit laborum nesciunt totam quia dolore molestias illum et provident soluta omnis facilis nostrum quae enim commodi delectus necessitatibus.", 856433998, 894, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), "Murray Inc", "Savings Account invoice repurpose" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Cali Collins", "provident", "https://picsum.photos/50/50/?image=569", "Architecto deleniti dicta quis velit quaerat assumenda reprehenderit explicabo est assumenda id iure ducimus illum corrupti dicta voluptatem consequuntur non.", 556915533, 906, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), "Dickinson - Armstrong", "Decentralized copy cross-platform" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jocelyn Runolfsson", "architecto", "https://picsum.photos/50/50/?image=750", "Blanditiis quia aliquid sed ipsa exercitationem vero vero eius culpa ipsa vero enim tenetur ratione natus enim in quisquam velit.", 978007072, 63, new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), "Bergnaum and Sons", "embrace Health District" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Arnulfo Tromp", "voluptates", "https://picsum.photos/50/50/?image=818", "Quia delectus laborum porro voluptas facere sit qui perspiciatis impedit qui molestiae est quidem blanditiis rerum dolor molestias dicta omnis.", 633325981, 294, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Pfeffer LLC", "non-volatile Ports Producer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kaylah Gleichner", "qui", "https://picsum.photos/50/50/?image=661", "Modi in odit sequi qui qui placeat mollitia dolorem sed neque nulla molestias molestiae facere ut ut similique nostrum distinctio.", 651146178, 359, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "Feest - Erdman", "Sleek Plastic Hat flexibility interface" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alena Ernser", "non", "https://picsum.photos/50/50/?image=959", "Nulla nemo dicta facilis distinctio facilis ratione doloremque labore iure consectetur deserunt asperiores illo autem consequatur dicta quo est eos.", 354928925, 906, new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), "Labadie - Quitzon", "Concrete Gorgeous Fresh Shoes transmit" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Imani Botsford", "voluptatem", "https://picsum.photos/50/50/?image=769", "Incidunt a necessitatibus dignissimos explicabo sit ipsa dolores voluptas facere eum rerum dolorem maxime accusamus aut quia delectus vero explicabo.", 732805629, 644, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), "Sanford, Muller and Cronin", "payment intuitive override" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Eleanore Howe", "dolor", "https://picsum.photos/50/50/?image=967", "Pariatur ut ea veritatis voluptatem consequatur eum sequi suscipit quia suscipit qui impedit et dolor assumenda laboriosam et est dolorem.", 813970129, 212, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), "Blick, Littel and Rice", "Avon withdrawal Belarussian Ruble" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dimitri Kassulke", "veritatis", "https://picsum.photos/50/50/?image=136", "Error totam repellendus consequatur qui velit non voluptas saepe laborum nihil minus rerum quidem voluptatem fuga perferendis facilis repudiandae nemo.", 497562511, 714, new DateTime(2023, 6, 21, 0, 0, 0, 0, DateTimeKind.Local), "Marvin Group", "Shore infrastructure Lakes" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Veda Smitham", "ratione", "https://picsum.photos/50/50/?image=782", "Itaque rerum omnis fugit inventore blanditiis repellendus vel inventore qui harum tempora consectetur ut omnis facere consequatur dolore et commodi.", 813535702, 747, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), "Runolfsdottir Group", "Handcrafted Granite Mouse Loop Integration" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Adolfo Marquardt", "sequi", "https://picsum.photos/50/50/?image=680", "Est eius ut placeat deleniti minima iste qui architecto voluptas laudantium exercitationem et blanditiis ipsum debitis inventore vitae aliquid magnam.", 296017923, 142, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), "Parisian Group", "secured line Florida mobile" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Shad Durgan", "perspiciatis", "https://picsum.photos/50/50/?image=705", "Consequatur aut vel ut temporibus explicabo ipsa dolorem minima voluptatum quia quidem quia et perspiciatis earum aliquam omnis minus voluptatem.", 993745361, 143, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), "Kunde - Schmeler", "Health, Shoes & Automotive Personal Loan Account markets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Oswald Ebert", "perspiciatis", "https://picsum.photos/50/50/?image=621", "Sapiente rerum necessitatibus impedit similique odit eum voluptatem aut repudiandae sequi ut et voluptates reprehenderit iusto beatae non dolore et.", 867664326, 220, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "Schuster, Goodwin and Nikolaus", "alarm functionalities Gorgeous Steel Fish" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Gerhard Armstrong", "enim", "https://picsum.photos/50/50/?image=35", "Assumenda quo similique ut distinctio eum culpa ullam dolores iure consequuntur voluptatem ea expedita labore quo eligendi aliquam corporis est.", 383824806, 847, new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Local), "Buckridge - Feeney", "portals Island Incredible Metal Mouse" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Matilde Kshlerin", "ullam", "https://picsum.photos/50/50/?image=764", "Vel ipsum velit reiciendis eveniet facere qui libero qui nostrum id fuga dolorem sapiente dignissimos nulla autem eligendi laborum perferendis.", 378454809, 486, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), "Ebert, Wisozk and Bashirian", "red Convertible Marks Granite" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Llewellyn Gaylord", "quod", "https://picsum.photos/50/50/?image=110", "Itaque omnis eaque odio sit aut optio optio sed sed alias non quaerat ut ipsa sed quas quam rerum quo.", 317397988, 416, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), "Gorczany Inc", "reboot Legacy reciprocal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dakota Mills", "sapiente", "https://picsum.photos/50/50/?image=561", "Maiores est beatae nihil officia et porro qui est minus nostrum vitae accusantium ea distinctio id ipsum tempore corrupti at.", 912311729, 764, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), "Tromp, Lindgren and Pfeffer", "Euro Spur Money Market Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Haley Gaylord", "minima", "https://picsum.photos/50/50/?image=477", "Quaerat omnis labore quod rerum repellendus quibusdam tenetur tenetur et a et quo praesentium dolorem cum amet vero maxime et.", 760607071, 704, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Pacocha, Armstrong and Kirlin", "clear-thinking Up-sized National" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rosendo Luettgen", "dolor", "https://picsum.photos/50/50/?image=244", "Magni quo cum ex deserunt modi ut quasi vel maiores qui optio minima fuga voluptatibus voluptas rerum maiores est culpa.", 930566760, 348, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), "Botsford Inc", "Beauty & Beauty Licensed black" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ross Schuster", "ullam", "https://picsum.photos/50/50/?image=921", "Rerum assumenda eius dolor sunt repudiandae quia et temporibus dignissimos soluta nisi fugiat ipsam voluptatem minus itaque et velit veniam.", 490707727, 712, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), "Stehr, Bins and Lueilwitz", "attitude-oriented deposit Small" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Don Gaylord", "aspernatur", "https://picsum.photos/50/50/?image=473", "Enim impedit reiciendis cum ipsum deleniti ipsum assumenda illum voluptatem aliquam aut dolorem sequi sunt molestiae doloremque id praesentium itaque.", 610731621, 524, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), "Kertzmann and Sons", "Syrian Pound Sleek Concrete Pants Investment Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Omari Boyle", "quod", "https://picsum.photos/50/50/?image=150", "Rerum unde natus voluptatem consequatur facilis et perferendis reprehenderit quibusdam veniam quos non sint facere accusamus quaerat quia repellat accusantium.", 723604374, 422, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "Pouros - Gleason", "Toys & Outdoors azure e-markets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dangelo Mohr", "quasi", "https://picsum.photos/50/50/?image=709", "Tempore qui velit adipisci aliquid explicabo nemo et et omnis laboriosam voluptatibus necessitatibus est aut dolor autem et asperiores veritatis.", 218085064, 796, new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), "Hermann, Keebler and Zboncak", "Gorgeous Granite Shirt multi-tasking Handmade Frozen Soap" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Micaela Cartwright", "laudantium", "https://picsum.photos/50/50/?image=183", "Vitae modi reiciendis doloribus ut quo cum qui dignissimos aliquam a dolores aspernatur voluptas id autem cum nemo animi reiciendis.", 568928806, 617, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Heathcote - Wiza", "invoice Myanmar Frozen" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Stuart Ondricka", "voluptatum", "https://picsum.photos/50/50/?image=851", "Recusandae aperiam natus et eveniet doloribus ea non voluptatibus explicabo tempore natus et pariatur vitae ea porro iusto ipsa minus.", 270639098, 887, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), "Huel - Davis", "SCSI programming Squares" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jaclyn Altenwerth", "iusto", "https://picsum.photos/50/50/?image=100", "Nihil voluptatem vitae possimus voluptatem asperiores accusamus ea tenetur distinctio repudiandae aut occaecati quia cumque quam eos qui aspernatur vel.", 425326078, 819, new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "Rolfson, Lang and Fadel", "Uganda Shilling Handcrafted Cotton Gloves Credit Card Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ursula Lynch", "explicabo", "https://picsum.photos/50/50/?image=521", "Veniam iste nam ut quia aliquid qui explicabo dolores laudantium fugit dolor labore sunt at temporibus similique dolores maxime voluptatem.", 368940880, 604, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Local), "Zemlak, Wiza and Nader", "Metal Central optimizing" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Damion Blanda", "consectetur", "https://picsum.photos/50/50/?image=723", "In aliquid temporibus eos quia incidunt omnis voluptatem rerum ducimus neque quibusdam ea fuga voluptas accusamus deserunt natus neque cum.", 520648836, 703, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Local), "Morissette - Mertz", "exploit Technician mesh" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Curtis Dietrich", "tempora", "https://picsum.photos/50/50/?image=706", "Error voluptatem alias vitae et eveniet dolore consequatur harum laborum ex temporibus nobis molestiae aut aut aut sed qui autem.", 962359313, 217, new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "Kohler, Tillman and Ryan", "turn-key Chief convergence" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Keith Bahringer", "delectus", "https://picsum.photos/50/50/?image=496", "Qui voluptates nam sed at animi recusandae autem hic quibusdam harum assumenda ea aliquid consequatur labore itaque consequatur blanditiis enim.", 355632273, 190, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), "Shanahan - Morar", "e-tailers synthesize Credit Card Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Eleanora Johnson", "recusandae", "https://picsum.photos/50/50/?image=499", "Alias ratione consequatur sint autem laboriosam minima numquam molestiae reprehenderit rem quaerat qui quis dolores veritatis eos enim non consequatur.", 913776839, 173, new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Moen Group", "Intelligent Soft Ball bandwidth-monitored Incredible Soft Pizza" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Garrison Huels", "minus", "https://picsum.photos/50/50/?image=938", "Quis esse molestiae deleniti minima dicta est in quaerat ea dicta rerum fugit maiores magni corrupti ea autem temporibus amet.", 600921904, 638, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), "Emmerich, Ward and Bradtke", "Horizontal deposit Avon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kieran Schamberger", "mollitia", "https://picsum.photos/50/50/?image=197", "Itaque repudiandae explicabo facere aperiam dolorem ullam ut qui quibusdam porro numquam aut cum temporibus non voluptatibus est et aut.", 439308196, 389, new DateTime(2024, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), "Zulauf - Hettinger", "Tasty Right-sized Station" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Cletus Beer", "illo", "https://picsum.photos/50/50/?image=355", "Nobis numquam qui ut cum repellat adipisci laboriosam atque consequuntur ipsam tenetur sunt nemo praesentium quia sed nesciunt qui explicabo.", 655434943, 247, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "Orn - Rath", "connect Switchable Avon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Christelle McDermott", "minima", "https://picsum.photos/50/50/?image=128", "Aliquid voluptas quibusdam excepturi aut molestiae asperiores ad similique ut delectus quam et ut molestiae aut non praesentium numquam et.", 825261859, 526, new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), "Goodwin, Schoen and Abshire", "1080p Producer reboot" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Danielle Torphy", "molestias", "https://picsum.photos/50/50/?image=757", "Id repudiandae repellat voluptas ex magni perspiciatis aspernatur quam sapiente quidem saepe in rerum ipsum sit dicta explicabo iste voluptatum.", 591563780, 406, new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "Schoen and Sons", "Future revolutionize violet" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Elise Walter", "in", "https://picsum.photos/50/50/?image=704", "Ut cum in porro adipisci vero expedita sapiente sed nihil officiis nulla iusto earum est magni maxime sequi doloribus est.", 379945519, 409, new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), "Konopelski - Crist", "Generic Fresh Sausages Mountain Rufiyaa" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lane Greenfelder", "cumque", "https://picsum.photos/50/50/?image=716", "Dolore minima et iusto consequuntur ea earum deserunt in nihil ducimus iusto quas qui rerum laudantium ducimus sed tempora et.", 146684420, 408, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "Dooley Inc", "payment Canyon bypass" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dagmar Simonis", "a", "https://picsum.photos/50/50/?image=284", "Consequatur deserunt laudantium laudantium doloribus et non nihil laudantium magni dignissimos in ad quidem ab dolor sunt blanditiis consectetur accusantium.", 781439484, 711, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), "Lockman - Kessler", "Fresh Summit Rustic" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Nikita Hagenes", "nam", "https://picsum.photos/50/50/?image=884", "Non officia id reprehenderit et consequuntur dolorum nostrum iure eos esse deserunt sunt ex dolores rerum iste nobis ut illum.", 907129570, 276, new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), "Veum - Berge", "Tasty Small Metal Shoes explicit" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Haven Hettinger", "ea", "https://picsum.photos/50/50/?image=745", "Veniam fugit et ea et optio ut autem nobis nihil magnam vero id quam dolores vitae vero perspiciatis quo occaecati.", 252807620, 51, new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), "Okuneva LLC", "Associate payment Fundamental" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Preston Considine", "aut", "https://picsum.photos/50/50/?image=535", "Voluptatem necessitatibus sunt quidem dolorum laboriosam quia odio accusantium expedita nihil velit ea est molestiae et maiores est ad dicta.", 204262018, 63, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), "Gislason, Torp and Marks", "Fresh Rubber JBOD" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Denis Upton", "illo", "https://picsum.photos/50/50/?image=1014", "Sint velit et et perspiciatis est et corporis quibusdam omnis perspiciatis deleniti possimus deserunt soluta quaerat unde et repellat neque.", 599143518, 369, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "O'Conner Inc", "Clothing Plaza connecting" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Myrtle Koss", "fugiat", "https://picsum.photos/50/50/?image=124", "Aut repellat nostrum excepturi saepe velit porro dicta et nihil voluptates dolores numquam sint saepe asperiores aperiam blanditiis ipsa laborum.", 748834024, 900, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), "Jacobson, Bosco and Schuppe", "withdrawal fresh-thinking Avon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ralph Cummerata", "eos", "https://picsum.photos/50/50/?image=330", "Quis est et dolores accusantium quia in ut non iste consequuntur ad voluptatibus et nisi aut eos adipisci sint blanditiis.", 453515022, 403, new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), "Leannon LLC", "Bedfordshire Licensed Steel Keyboard Paraguay" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Edison Cummings", "rerum", "https://picsum.photos/50/50/?image=552", "Maiores non in vitae saepe atque voluptate consequatur pariatur voluptatem molestiae odio eum pariatur laborum dolorem aut et aspernatur non.", 118799532, 758, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), "Marvin - Howe", "Investment Account invoice magnetic" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rafaela Berge", "iusto", "https://picsum.photos/50/50/?image=917", "Tempore est magnam quisquam fugit mollitia occaecati accusamus ut ut ex cum recusandae nam repellendus consequatur expedita quia odit ipsa.", 784634167, 429, new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "Gulgowski Group", "Borders South Carolina sexy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Geoffrey Schuppe", "voluptatem", "https://picsum.photos/50/50/?image=564", "In quia explicabo culpa iusto dolore et esse animi dolorum quo laboriosam iure sit reprehenderit cumque quam amet perferendis non.", 184143294, 481, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Local), "Reinger - Kemmer", "Montana Handmade multi-byte" });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");
        }
    }
}
