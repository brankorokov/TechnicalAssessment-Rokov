using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechnicalAssessmentRokov.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER" },
                values: new object[,]
                {
                    { 1, "Johathan Mayert", "omnis", "http://lorempixel.com/640/480/city", "Similique voluptatem quo magni in quis voluptate doloremque rerum quia vel ut tenetur aspernatur eum tenetur repellat perspiciatis sint aliquid.", 337858267, 162, new DateTime(2023, 6, 26, 0, 42, 40, 852, DateTimeKind.Local).AddTicks(3930), "Abernathy - Murphy" },
                    { 2, "Phyllis Cremin", "aut", "http://lorempixel.com/640/480/sports", "Aliquam sit et nemo tempora natus qui itaque deleniti magni nesciunt aut dignissimos minima nihil soluta est asperiores quasi nam.", 832865458, 269, new DateTime(2023, 8, 5, 21, 32, 7, 27, DateTimeKind.Local).AddTicks(4843), "Wisoky and Sons" },
                    { 3, "Daija Collier", "temporibus", "http://lorempixel.com/640/480/business", "Eveniet quidem quia autem amet ipsam id amet minima consectetur ea laborum aliquid odio laborum dicta nemo quia et voluptates.", 120918662, 412, new DateTime(2023, 8, 14, 21, 36, 48, 195, DateTimeKind.Local).AddTicks(1517), "Fahey - Kertzmann" },
                    { 4, "Dayne Huel", "qui", "http://lorempixel.com/640/480/animals", "Repellat ut cumque veniam ea blanditiis et ipsum ut qui cum laudantium et labore est animi sed at iusto quo.", 634849498, 863, new DateTime(2024, 2, 7, 8, 5, 10, 837, DateTimeKind.Local).AddTicks(1639), "Schulist, Ward and Kemmer" },
                    { 5, "Sasha Kerluke", "porro", "http://lorempixel.com/640/480/animals", "Animi ad eum eligendi doloribus possimus dolore in amet amet beatae expedita totam incidunt quas vel molestiae eum ipsum libero.", 283181214, 496, new DateTime(2023, 8, 20, 6, 8, 42, 840, DateTimeKind.Local).AddTicks(4166), "Roob - Emmerich" },
                    { 6, "Abraham Lemke", "velit", "http://lorempixel.com/640/480/city", "Architecto doloribus dolor voluptatibus aut corrupti sed et iure facilis totam laboriosam doloribus nulla possimus distinctio ipsum non quasi ut.", 261138113, 932, new DateTime(2024, 2, 14, 7, 13, 44, 999, DateTimeKind.Local).AddTicks(3827), "Howe LLC" },
                    { 7, "Billy Cormier", "provident", "http://lorempixel.com/640/480/cats", "Est enim sint qui consequatur ea qui aperiam incidunt enim qui saepe sit et sit eos ipsam provident officia qui.", 460841448, 377, new DateTime(2023, 11, 20, 11, 31, 9, 572, DateTimeKind.Local).AddTicks(816), "Jerde, Hodkiewicz and Schamberger" },
                    { 8, "Vicky Berge", "illo", "http://lorempixel.com/640/480/animals", "Ratione et eum magnam ipsa sunt vel ut ut nostrum saepe ad earum natus adipisci eos pariatur architecto sint aut.", 787101472, 942, new DateTime(2024, 2, 21, 7, 48, 28, 156, DateTimeKind.Local).AddTicks(4542), "Mills, Schulist and Weimann" },
                    { 9, "Emil Romaguera", "quisquam", "http://lorempixel.com/640/480/animals", "Esse accusamus quidem laudantium nam a labore beatae ducimus enim culpa iure quasi enim cupiditate fugit qui repellendus dolorem odit.", 166555776, 873, new DateTime(2024, 2, 2, 6, 48, 40, 54, DateTimeKind.Local).AddTicks(9767), "Weissnat, Watsica and Hane" },
                    { 10, "Carleton Hagenes", "velit", "http://lorempixel.com/640/480/fashion", "Rem provident eius autem commodi corrupti perspiciatis quo voluptas earum rerum rerum sed voluptatem in velit facilis minima quia autem.", 343511952, 952, new DateTime(2023, 10, 31, 0, 29, 35, 966, DateTimeKind.Local).AddTicks(269), "Howell - Cremin" },
                    { 11, "Ernest Pacocha", "eaque", "http://lorempixel.com/640/480/city", "Voluptas repellendus est asperiores in iusto corporis voluptatem nemo et quis autem et ex minus aperiam debitis labore maiores sed.", 563557638, 967, new DateTime(2023, 8, 27, 17, 33, 46, 631, DateTimeKind.Local).AddTicks(799), "Harvey LLC" },
                    { 12, "Elvera Cartwright", "aut", "http://lorempixel.com/640/480/abstract", "Consequatur aperiam quibusdam unde cum et nostrum fugiat ut ea quibusdam voluptatem non expedita ut quo aliquam et rerum explicabo.", 772543864, 69, new DateTime(2023, 10, 18, 0, 54, 7, 237, DateTimeKind.Local).AddTicks(2508), "Ortiz, Bartoletti and Stanton" },
                    { 13, "Jordan Stamm", "recusandae", "http://lorempixel.com/640/480/business", "Et ullam consequatur omnis delectus molestiae eveniet earum amet voluptatem dolorem molestiae iusto ullam earum quia sed molestiae et explicabo.", 787296053, 457, new DateTime(2023, 9, 4, 0, 21, 0, 988, DateTimeKind.Local).AddTicks(2779), "Tromp and Sons" },
                    { 14, "Peter Bashirian", "ducimus", "http://lorempixel.com/640/480/nature", "Dolores non vitae et earum blanditiis vitae praesentium quos porro eveniet deleniti beatae voluptatem ad voluptatum sed qui perferendis qui.", 177169724, 517, new DateTime(2023, 8, 13, 11, 46, 15, 317, DateTimeKind.Local).AddTicks(9652), "Tillman - Gislason" },
                    { 15, "Brook Feest", "autem", "http://lorempixel.com/640/480/food", "Voluptatem fuga modi et voluptatem earum qui reiciendis totam illum itaque cupiditate aliquid vero et iste ut non ut laudantium.", 608372290, 970, new DateTime(2023, 10, 16, 2, 20, 6, 306, DateTimeKind.Local).AddTicks(1662), "Mraz, Botsford and Jaskolski" },
                    { 16, "Jevon Williamson", "corporis", "http://lorempixel.com/640/480/business", "Aut adipisci ullam est expedita vitae vel et sed adipisci est distinctio veniam voluptas iure officia eum sit est eaque.", 453956261, 419, new DateTime(2023, 8, 30, 17, 55, 31, 613, DateTimeKind.Local).AddTicks(81), "Hammes, Langosh and Wiza" },
                    { 17, "Antwan Wuckert", "veniam", "http://lorempixel.com/640/480/business", "Earum nesciunt iusto iusto id necessitatibus labore quia fugit repudiandae quisquam voluptatum fuga assumenda numquam ut non reiciendis sapiente voluptas.", 309992702, 621, new DateTime(2023, 11, 11, 12, 35, 30, 245, DateTimeKind.Local).AddTicks(221), "Reinger - Weissnat" },
                    { 18, "Angelo Walsh", "accusantium", "http://lorempixel.com/640/480/people", "Repellendus praesentium aut neque aperiam est dolorem cupiditate maxime dicta placeat aut qui aut libero quam repellat omnis iusto recusandae.", 150040109, 434, new DateTime(2023, 10, 20, 23, 32, 8, 332, DateTimeKind.Local).AddTicks(2633), "Stehr Inc" },
                    { 19, "Giles Reichert", "eligendi", "http://lorempixel.com/640/480/cats", "Eum dolorem sequi amet doloribus laboriosam sint vitae rerum harum id natus autem necessitatibus harum recusandae cumque quae neque quo.", 325349025, 913, new DateTime(2024, 3, 17, 15, 41, 26, 37, DateTimeKind.Local).AddTicks(6683), "Bernhard - Powlowski" },
                    { 20, "Elvie Monahan", "omnis", "http://lorempixel.com/640/480/city", "Labore minima est et consectetur voluptatem ullam provident ad est et nulla fugiat quaerat dolores deserunt aut explicabo ex blanditiis.", 325519142, 325, new DateTime(2024, 2, 14, 0, 6, 33, 968, DateTimeKind.Local).AddTicks(4078), "Bernier Group" },
                    { 21, "Hiram Schaefer", "fugiat", "http://lorempixel.com/640/480/animals", "Doloribus natus voluptatem sint consequatur exercitationem exercitationem commodi quia corporis fugit neque totam eos et tempore sint suscipit voluptas cumque.", 547388664, 741, new DateTime(2023, 12, 16, 23, 9, 14, 280, DateTimeKind.Local).AddTicks(1199), "Daugherty, Botsford and Altenwerth" },
                    { 22, "Laron Goldner", "quod", "http://lorempixel.com/640/480/nightlife", "Et placeat quia ea in consequatur unde optio tempora repudiandae accusamus voluptas exercitationem accusamus et voluptas a ratione ipsam earum.", 205599035, 267, new DateTime(2023, 8, 9, 19, 22, 54, 900, DateTimeKind.Local).AddTicks(7534), "Pfeffer - Hettinger" },
                    { 23, "Dejuan Waters", "neque", "http://lorempixel.com/640/480/nightlife", "Delectus magnam aut error dolor exercitationem qui debitis aut eum nostrum alias maiores repudiandae eum et nemo exercitationem recusandae sit.", 437039200, 551, new DateTime(2023, 6, 26, 22, 20, 34, 272, DateTimeKind.Local).AddTicks(7766), "Bauch - Hegmann" },
                    { 24, "Eliza Mann", "veniam", "http://lorempixel.com/640/480/nature", "Quod quas ab incidunt ea ullam reiciendis velit dignissimos corrupti repellendus error natus nam ut quidem ducimus officiis ut debitis.", 525302048, 656, new DateTime(2024, 5, 12, 16, 14, 46, 12, DateTimeKind.Local).AddTicks(9010), "Jerde LLC" },
                    { 25, "Elwyn White", "ut", "http://lorempixel.com/640/480/transport", "Possimus suscipit quia dolores sint nihil et saepe est reiciendis atque modi qui qui exercitationem hic quam eum ipsum qui.", 789992300, 933, new DateTime(2023, 9, 15, 16, 3, 7, 715, DateTimeKind.Local).AddTicks(3743), "Weissnat Inc" },
                    { 26, "Elmer Hettinger", "adipisci", "http://lorempixel.com/640/480/transport", "Ipsam fugiat ducimus omnis est aliquid quo veniam autem molestias alias repellendus quia veniam et cupiditate error enim asperiores autem.", 151794424, 649, new DateTime(2024, 4, 20, 7, 52, 12, 827, DateTimeKind.Local).AddTicks(1712), "Effertz, Nicolas and Block" },
                    { 27, "Letitia Larkin", "accusamus", "http://lorempixel.com/640/480/fashion", "Similique ab rerum quis omnis nostrum et et enim minima voluptate dolor architecto repellat ex consequatur fugiat non quod explicabo.", 817086741, 81, new DateTime(2023, 10, 16, 10, 50, 19, 297, DateTimeKind.Local).AddTicks(661), "Franecki - Grant" },
                    { 28, "Jaquan Toy", "suscipit", "http://lorempixel.com/640/480/nightlife", "Alias ipsum occaecati facere quia sit quaerat dolores qui corporis sed voluptates officiis enim quidem doloribus quia neque corporis qui.", 910346169, 151, new DateTime(2023, 12, 7, 11, 28, 43, 895, DateTimeKind.Local).AddTicks(3406), "Torp, Olson and Ledner" },
                    { 29, "Conrad Wiegand", "vero", "http://lorempixel.com/640/480/animals", "Facilis voluptatibus ipsum velit sed deserunt doloribus placeat fugit nemo nisi a eos ut quidem est harum ratione sit quia.", 779361781, 152, new DateTime(2023, 10, 29, 1, 20, 14, 216, DateTimeKind.Local).AddTicks(7561), "Shanahan - Sawayn" },
                    { 30, "Hassan Kuhn", "facilis", "http://lorempixel.com/640/480/people", "Corporis quisquam repellendus eaque voluptates id quo necessitatibus aliquid eius porro exercitationem sit aliquid vitae praesentium nisi quod sit molestias.", 381911763, 119, new DateTime(2024, 5, 13, 14, 8, 55, 813, DateTimeKind.Local).AddTicks(4462), "Rosenbaum - Howe" },
                    { 31, "Jules Wiegand", "accusantium", "http://lorempixel.com/640/480/business", "Blanditiis libero accusantium nisi possimus sequi quam molestias aliquid modi ad ut recusandae est explicabo qui consequuntur qui iusto aperiam.", 996401248, 801, new DateTime(2023, 11, 1, 17, 27, 56, 818, DateTimeKind.Local).AddTicks(7020), "Aufderhar - Gorczany" },
                    { 32, "Ruthie Howe", "aliquam", "http://lorempixel.com/640/480/nature", "Molestiae vel quibusdam voluptas accusantium sit autem velit at cumque suscipit reprehenderit illum dolor molestiae maiores omnis nostrum fugiat laudantium.", 302739295, 514, new DateTime(2023, 9, 27, 12, 17, 22, 705, DateTimeKind.Local).AddTicks(7852), "Cormier LLC" },
                    { 33, "Aniya Welch", "delectus", "http://lorempixel.com/640/480/nature", "Quasi minus adipisci iure sit est sit reiciendis voluptatem minima a quis natus magnam aliquam numquam animi exercitationem et praesentium.", 369094778, 583, new DateTime(2024, 1, 3, 22, 23, 2, 373, DateTimeKind.Local).AddTicks(1339), "Turcotte, Konopelski and Turner" },
                    { 34, "Roxanne Thompson", "repellendus", "http://lorempixel.com/640/480/people", "Sint voluptas molestias sint aut voluptatum rerum ipsa omnis quidem saepe rerum provident cumque facere sequi quasi et aut sunt.", 991058835, 684, new DateTime(2024, 2, 16, 2, 53, 9, 449, DateTimeKind.Local).AddTicks(669), "Mosciski and Sons" },
                    { 35, "Salvatore Ondricka", "qui", "http://lorempixel.com/640/480/fashion", "Aut omnis ad voluptatem et qui assumenda sed aut molestias consequuntur recusandae totam voluptatum dicta aut suscipit sequi autem dolor.", 467198733, 366, new DateTime(2024, 2, 17, 23, 20, 0, 40, DateTimeKind.Local).AddTicks(6370), "Waelchi and Sons" },
                    { 36, "Elinore Little", "optio", "http://lorempixel.com/640/480/cats", "Ullam consequatur molestias est minima laboriosam omnis similique magnam optio illum magni nesciunt sequi quasi vitae maiores corrupti et similique.", 899437181, 995, new DateTime(2023, 11, 21, 18, 56, 56, 823, DateTimeKind.Local).AddTicks(9824), "Wilderman, Wilderman and Luettgen" },
                    { 37, "Cristina Kunde", "tempore", "http://lorempixel.com/640/480/nature", "Est id quia at rem dolore enim est perspiciatis nisi in qui provident assumenda quia iure voluptates perspiciatis ullam in.", 837092921, 769, new DateTime(2023, 8, 10, 23, 16, 35, 62, DateTimeKind.Local).AddTicks(6326), "Sanford - Schiller" },
                    { 38, "Daren Denesik", "incidunt", "http://lorempixel.com/640/480/animals", "Veritatis consequuntur ut ut dicta maiores cumque exercitationem voluptas quibusdam nihil dicta odio saepe consequatur nesciunt dolor et atque molestiae.", 717883923, 538, new DateTime(2023, 8, 20, 5, 4, 20, 434, DateTimeKind.Local).AddTicks(3797), "Kessler, Simonis and Kshlerin" },
                    { 39, "Audrey Wilkinson", "enim", "http://lorempixel.com/640/480/business", "Praesentium ut nostrum consequatur quo saepe sunt aut quia ex enim alias laudantium et magni laboriosam eligendi aperiam rerum consequatur.", 328631835, 664, new DateTime(2023, 7, 22, 16, 4, 49, 934, DateTimeKind.Local).AddTicks(7671), "Jenkins - Haley" },
                    { 40, "Helmer Kuhlman", "aut", "http://lorempixel.com/640/480/cats", "Explicabo qui ducimus cupiditate rerum quia itaque accusantium quaerat rem ex odio dolor et dolorem et sit ea odio placeat.", 498607606, 923, new DateTime(2023, 9, 19, 14, 36, 19, 740, DateTimeKind.Local).AddTicks(5490), "Reinger, Green and Bins" },
                    { 41, "Veda Mraz", "eum", "http://lorempixel.com/640/480/sports", "Quasi est illum unde temporibus beatae omnis iste natus quisquam non optio voluptate quisquam maiores recusandae reiciendis dolorem qui commodi.", 818103179, 624, new DateTime(2023, 10, 30, 9, 52, 58, 141, DateTimeKind.Local).AddTicks(1337), "Legros - Effertz" },
                    { 42, "Devin Wunsch", "culpa", "http://lorempixel.com/640/480/cats", "Et ducimus ut nisi et repudiandae a assumenda consequatur cupiditate minima voluptatem laborum rerum qui sint qui totam unde ipsum.", 336758362, 197, new DateTime(2023, 11, 25, 20, 6, 36, 189, DateTimeKind.Local).AddTicks(282), "Blick, Ruecker and Mayer" },
                    { 43, "Marques Tromp", "voluptas", "http://lorempixel.com/640/480/business", "Sed voluptatem in accusantium officia voluptatem sit autem esse minus non sed atque tempora ut deleniti dolores excepturi ipsa ea.", 899316811, 161, new DateTime(2023, 12, 28, 20, 16, 10, 985, DateTimeKind.Local).AddTicks(5545), "Waters, Langosh and Wisoky" },
                    { 44, "Dejuan Tromp", "consequatur", "http://lorempixel.com/640/480/city", "Exercitationem soluta molestiae vero veritatis similique voluptatem voluptas similique rem maiores vel eos veritatis est et quis vero vel nam.", 533180930, 410, new DateTime(2023, 12, 16, 14, 43, 25, 730, DateTimeKind.Local).AddTicks(4052), "Block Inc" },
                    { 45, "Jordi Heller", "quos", "http://lorempixel.com/640/480/cats", "Quae alias officia quae laborum veniam nobis aut qui suscipit omnis exercitationem totam dolores et qui ut tempora et accusantium.", 812235245, 461, new DateTime(2024, 1, 10, 16, 29, 58, 983, DateTimeKind.Local).AddTicks(1077), "Kautzer and Sons" },
                    { 46, "Julie Rempel", "deserunt", "http://lorempixel.com/640/480/city", "Eos similique earum accusantium tempore consequatur ut debitis laborum tempora consectetur animi iure culpa unde qui est consequuntur nesciunt eos.", 905743485, 226, new DateTime(2023, 7, 2, 13, 54, 47, 327, DateTimeKind.Local).AddTicks(8577), "Hodkiewicz Inc" },
                    { 47, "Freeman Reilly", "iste", "http://lorempixel.com/640/480/sports", "Beatae minus ut repudiandae officia autem vitae beatae id culpa deleniti qui blanditiis nam dignissimos quo repellat odit nihil voluptatem.", 149516215, 996, new DateTime(2024, 3, 12, 1, 35, 0, 348, DateTimeKind.Local).AddTicks(6231), "Rempel - Murray" },
                    { 48, "Verona Kulas", "architecto", "http://lorempixel.com/640/480/business", "Voluptas itaque rerum esse soluta maiores ab quo sint consequuntur occaecati in error animi numquam sint voluptatibus est sapiente qui.", 885359883, 189, new DateTime(2023, 9, 29, 22, 30, 13, 875, DateTimeKind.Local).AddTicks(2674), "Witting, Sawayn and Christiansen" },
                    { 49, "Dameon Jacobi", "eum", "http://lorempixel.com/640/480/abstract", "Expedita ut ratione vel iure quis nesciunt ut aut delectus tenetur dolorem quibusdam eaque repellat reiciendis et nostrum quis architecto.", 443754219, 379, new DateTime(2024, 3, 23, 4, 1, 10, 665, DateTimeKind.Local).AddTicks(3492), "Nicolas and Sons" },
                    { 50, "Ivy Casper", "provident", "http://lorempixel.com/640/480/nightlife", "Sunt ipsum quis perspiciatis dolorum accusantium dolorem qui dolor et magni non asperiores saepe eos voluptatum sed recusandae est nisi.", 691729683, 694, new DateTime(2024, 4, 20, 3, 13, 37, 66, DateTimeKind.Local).AddTicks(1069), "Bahringer and Sons" },
                    { 51, "Jimmy Kling", "pariatur", "http://lorempixel.com/640/480/sports", "Sed harum laudantium cupiditate dolores laudantium eligendi et quam et reiciendis explicabo sint itaque nemo fuga et est quibusdam repudiandae.", 176426366, 588, new DateTime(2023, 6, 25, 11, 57, 45, 717, DateTimeKind.Local).AddTicks(5546), "Cartwright, Hand and Heathcote" },
                    { 52, "Stacy Stoltenberg", "cum", "http://lorempixel.com/640/480/technics", "Illum consequatur magni ducimus ab necessitatibus eius totam animi expedita optio cupiditate et rerum veritatis sint sunt et ut est.", 344861615, 476, new DateTime(2024, 1, 31, 18, 1, 35, 673, DateTimeKind.Local).AddTicks(6061), "Miller, Reilly and Feest" },
                    { 53, "Mozell Hessel", "corrupti", "http://lorempixel.com/640/480/city", "Nam voluptatem nobis ut qui et et quam consequuntur quibusdam voluptates ut in animi eum eos tenetur voluptate cum culpa.", 374689772, 831, new DateTime(2023, 8, 12, 11, 16, 29, 543, DateTimeKind.Local).AddTicks(7152), "Marquardt and Sons" },
                    { 54, "Beth Steuber", "soluta", "http://lorempixel.com/640/480/food", "Deserunt laboriosam nobis quibusdam iure nobis et similique consectetur explicabo aut et qui quo nobis distinctio fugiat error ea aut.", 734286898, 887, new DateTime(2023, 9, 27, 4, 5, 37, 353, DateTimeKind.Local).AddTicks(8654), "Jaskolski - Borer" },
                    { 55, "Heath Schulist", "quasi", "http://lorempixel.com/640/480/sports", "Aut sequi cupiditate dignissimos eum veniam et fugiat necessitatibus voluptas vitae porro voluptate velit praesentium blanditiis fugit soluta aut voluptas.", 366113326, 597, new DateTime(2024, 3, 23, 15, 57, 27, 784, DateTimeKind.Local).AddTicks(9917), "Robel - McCullough" },
                    { 56, "Bruce Ryan", "in", "http://lorempixel.com/640/480/abstract", "Repudiandae illum alias odio nulla voluptatibus voluptatum inventore ut occaecati esse mollitia natus eos quasi recusandae distinctio voluptates vel et.", 494723568, 242, new DateTime(2024, 4, 8, 20, 17, 3, 133, DateTimeKind.Local).AddTicks(8290), "Jast Group" },
                    { 57, "Alycia Cruickshank", "esse", "http://lorempixel.com/640/480/city", "Blanditiis nisi cumque dolor est consequatur eos error tempora ratione impedit quibusdam quia est unde consectetur quia nulla tempore numquam.", 676686782, 984, new DateTime(2023, 10, 18, 18, 47, 9, 771, DateTimeKind.Local).AddTicks(7750), "Hayes - Hand" },
                    { 58, "Kyler Pouros", "laboriosam", "http://lorempixel.com/640/480/fashion", "Placeat ipsam magni quia voluptates illum qui eos quisquam itaque explicabo cumque ut quisquam consequatur dicta dolor consectetur totam doloribus.", 418335231, 916, new DateTime(2023, 10, 22, 12, 0, 16, 44, DateTimeKind.Local).AddTicks(2456), "Pacocha - MacGyver" },
                    { 59, "Dewitt Hammes", "aut", "http://lorempixel.com/640/480/transport", "Voluptatem qui atque provident tempore sit perferendis sed et necessitatibus atque tempora sunt corrupti eos odit sunt voluptas repellat explicabo.", 552131495, 262, new DateTime(2023, 9, 9, 0, 38, 0, 804, DateTimeKind.Local).AddTicks(2425), "Hermiston and Sons" },
                    { 60, "Emmie Muller", "quas", "http://lorempixel.com/640/480/fashion", "Qui vero omnis ipsa labore totam eligendi reiciendis rerum rerum ab laboriosam molestiae ratione dolor est iure dolorem itaque rem.", 415776534, 554, new DateTime(2024, 1, 7, 6, 6, 8, 139, DateTimeKind.Local).AddTicks(4498), "Sauer LLC" },
                    { 61, "Cleveland Welch", "nisi", "http://lorempixel.com/640/480/animals", "Voluptate nulla quas in deleniti ex sed eum et veritatis et accusamus asperiores sapiente architecto minus libero nobis reiciendis et.", 840594304, 163, new DateTime(2024, 2, 21, 6, 58, 52, 469, DateTimeKind.Local).AddTicks(2753), "Kuhn Group" },
                    { 62, "Kendall Braun", "possimus", "http://lorempixel.com/640/480/sports", "Fugit vel sunt esse impedit eius deserunt accusantium magni ab fugiat non et qui et nihil similique dolores aliquid qui.", 436642244, 151, new DateTime(2024, 6, 3, 14, 17, 40, 462, DateTimeKind.Local).AddTicks(8050), "Lowe Inc" },
                    { 63, "Barry Monahan", "esse", "http://lorempixel.com/640/480/nightlife", "Cupiditate culpa mollitia omnis ut est facere voluptatem id dignissimos et voluptas non fugiat dignissimos mollitia expedita quidem delectus veritatis.", 614451971, 400, new DateTime(2023, 9, 3, 20, 47, 38, 593, DateTimeKind.Local).AddTicks(3824), "Barrows, Spinka and Moen" },
                    { 64, "Amelie Macejkovic", "et", "http://lorempixel.com/640/480/technics", "Atque omnis tempora molestiae odit numquam cupiditate sunt totam atque qui non vitae molestias deleniti maiores consequatur impedit non optio.", 148488973, 630, new DateTime(2023, 8, 11, 17, 56, 1, 52, DateTimeKind.Local).AddTicks(3448), "Medhurst, Dietrich and Schmeler" },
                    { 65, "Albert Wilkinson", "eaque", "http://lorempixel.com/640/480/abstract", "Distinctio et nemo doloremque pariatur sit odio enim et omnis fugiat nostrum impedit unde labore qui sit sunt quia quas.", 142893242, 863, new DateTime(2023, 7, 7, 16, 13, 56, 854, DateTimeKind.Local).AddTicks(9788), "Fadel - Mueller" },
                    { 66, "Francesco Morar", "aut", "http://lorempixel.com/640/480/nature", "Dicta omnis necessitatibus et qui facere totam quo sint aut non dolorem amet iste error odit sit perspiciatis voluptas ut.", 922446586, 915, new DateTime(2023, 10, 24, 14, 33, 37, 409, DateTimeKind.Local).AddTicks(7505), "Thiel, White and Mayert" },
                    { 67, "Vena Krajcik", "voluptatibus", "http://lorempixel.com/640/480/city", "Libero hic dolorem ea et eligendi quasi ab illum fugit quod et minima optio nihil ipsum numquam sit at laudantium.", 278040285, 313, new DateTime(2023, 9, 8, 18, 34, 29, 373, DateTimeKind.Local).AddTicks(8215), "Davis, Waters and Champlin" },
                    { 68, "Sasha Bogan", "cum", "http://lorempixel.com/640/480/fashion", "Ut pariatur consequatur ipsam nihil in velit voluptatum iste enim ut recusandae perferendis ut nihil voluptas sint laboriosam sapiente hic.", 670963916, 146, new DateTime(2023, 12, 4, 0, 35, 52, 819, DateTimeKind.Local).AddTicks(4205), "Bradtke - Bradtke" },
                    { 69, "Delphine Ondricka", "reiciendis", "http://lorempixel.com/640/480/food", "Atque corporis maxime dolorem pariatur amet labore ipsa vel velit consequatur molestias id autem accusantium sapiente vel eos deleniti cumque.", 944718754, 167, new DateTime(2023, 12, 11, 3, 47, 37, 413, DateTimeKind.Local).AddTicks(2376), "Mills - Satterfield" },
                    { 70, "Lorenza Luettgen", "doloremque", "http://lorempixel.com/640/480/business", "Nam expedita ratione similique esse autem perferendis cupiditate qui minus harum blanditiis eaque et qui recusandae dicta quasi in adipisci.", 270051331, 289, new DateTime(2023, 8, 23, 2, 49, 8, 644, DateTimeKind.Local).AddTicks(3268), "Hintz - Swaniawski" },
                    { 71, "Sylvia Herzog", "magnam", "http://lorempixel.com/640/480/cats", "Mollitia fugit quam consequatur perspiciatis maiores voluptatem corporis sunt dolores sunt magnam sapiente et impedit neque molestiae qui dolorem vitae.", 639111344, 550, new DateTime(2023, 9, 3, 8, 15, 57, 642, DateTimeKind.Local).AddTicks(4209), "Kutch - Wiegand" },
                    { 72, "Georgianna Johnston", "non", "http://lorempixel.com/640/480/cats", "Deleniti dolorem saepe magni eaque dolorem harum voluptate nostrum officia quaerat qui dolorem voluptate rerum cum qui nobis eveniet dignissimos.", 244431985, 914, new DateTime(2024, 5, 20, 17, 18, 4, 467, DateTimeKind.Local).AddTicks(4236), "Rogahn - Dare" },
                    { 73, "Cedrick Quitzon", "ea", "http://lorempixel.com/640/480/business", "Quo non exercitationem enim blanditiis rem eos assumenda facilis voluptatem velit perspiciatis fuga aliquam et sit ipsum voluptatem quia aspernatur.", 704805735, 385, new DateTime(2023, 9, 6, 0, 28, 14, 636, DateTimeKind.Local).AddTicks(4584), "Howell, Weissnat and Jones" },
                    { 74, "Lina Larkin", "amet", "http://lorempixel.com/640/480/people", "Consequatur architecto ab non iure et numquam eveniet saepe vero ut eius nisi repellat quos quas laborum consequatur porro voluptates.", 403879274, 535, new DateTime(2023, 7, 1, 23, 5, 46, 104, DateTimeKind.Local).AddTicks(5067), "Konopelski - Hartmann" },
                    { 75, "Jesse Deckow", "quis", "http://lorempixel.com/640/480/transport", "Ipsa tempora quasi temporibus voluptatibus sunt ipsam veritatis dolore maxime mollitia aliquid placeat dicta et accusantium soluta rerum officia ab.", 223688917, 534, new DateTime(2023, 8, 28, 8, 52, 18, 683, DateTimeKind.Local).AddTicks(7472), "Cole, Hayes and Veum" },
                    { 76, "Samir Turcotte", "saepe", "http://lorempixel.com/640/480/business", "Aut ut suscipit provident voluptatem esse quia unde debitis dicta minus et odio reiciendis deleniti facere qui id aut mollitia.", 175394973, 152, new DateTime(2023, 9, 19, 6, 24, 27, 994, DateTimeKind.Local).AddTicks(7479), "Hagenes - Kihn" },
                    { 77, "Brandy Murphy", "similique", "http://lorempixel.com/640/480/business", "Qui reprehenderit id est sint quae optio totam et omnis eveniet minima rerum necessitatibus consectetur sunt nisi inventore occaecati quo.", 568024228, 581, new DateTime(2023, 12, 28, 22, 8, 9, 622, DateTimeKind.Local).AddTicks(9067), "Pfannerstill, Barrows and Hessel" },
                    { 78, "Harold Collins", "aliquid", "http://lorempixel.com/640/480/nightlife", "Temporibus et et non aliquid et est et non modi aut quo pariatur et nulla ut quia quidem fugiat aliquam.", 461539763, 357, new DateTime(2023, 9, 3, 3, 40, 26, 875, DateTimeKind.Local).AddTicks(3717), "Pfeffer - Nikolaus" },
                    { 79, "Kenny Bradtke", "illum", "http://lorempixel.com/640/480/nature", "Voluptatibus et sint et commodi dolor labore libero culpa qui aperiam pariatur non quaerat nobis voluptatem voluptas explicabo et quaerat.", 641651659, 74, new DateTime(2024, 1, 12, 11, 54, 9, 311, DateTimeKind.Local).AddTicks(4653), "Grant - Wyman" },
                    { 80, "Cristina Hegmann", "odit", "http://lorempixel.com/640/480/business", "Est dolor rerum quod nisi rem repudiandae illo mollitia fugit deserunt quo aut voluptatem repellendus hic quia ut quia voluptatem.", 135728408, 301, new DateTime(2023, 9, 12, 6, 8, 16, 915, DateTimeKind.Local).AddTicks(9637), "Swaniawski Group" },
                    { 81, "Jeffrey Huel", "sint", "http://lorempixel.com/640/480/fashion", "Et nulla consequuntur quae atque eos accusantium dolor quis numquam numquam autem nihil delectus qui dolores dolores quo et autem.", 139987759, 494, new DateTime(2024, 4, 16, 21, 36, 21, 229, DateTimeKind.Local).AddTicks(9696), "Hyatt - Bergnaum" },
                    { 82, "Quentin Johns", "est", "http://lorempixel.com/640/480/technics", "Quo velit et quae totam quaerat exercitationem et rem temporibus omnis incidunt ut officia cupiditate rerum sit sed illo facilis.", 255445364, 215, new DateTime(2024, 2, 17, 16, 22, 6, 942, DateTimeKind.Local).AddTicks(1189), "Lockman, Hane and Kulas" },
                    { 83, "Betsy Gutkowski", "explicabo", "http://lorempixel.com/640/480/cats", "Sed deserunt et totam ut qui rerum praesentium autem ducimus ex quibusdam est dolorem delectus dolorem praesentium aut ea quos.", 886873545, 254, new DateTime(2023, 7, 30, 17, 12, 57, 646, DateTimeKind.Local).AddTicks(3522), "Mitchell Group" },
                    { 84, "Raymond Torphy", "quo", "http://lorempixel.com/640/480/cats", "Repudiandae quia hic rerum aliquid aspernatur nobis aut numquam rerum amet provident deserunt aut officia dicta dicta hic eius similique.", 484825689, 943, new DateTime(2023, 9, 20, 13, 43, 30, 671, DateTimeKind.Local).AddTicks(9933), "Stark, Hamill and DuBuque" },
                    { 85, "Martina Crona", "veniam", "http://lorempixel.com/640/480/fashion", "Non qui et vel est quidem voluptas voluptate harum labore corrupti nobis rem dolorum ut ut vel esse quia consequatur.", 746481693, 935, new DateTime(2023, 9, 16, 19, 36, 7, 27, DateTimeKind.Local).AddTicks(349), "Ernser, Corkery and Jast" },
                    { 86, "Faye Renner", "occaecati", "http://lorempixel.com/640/480/abstract", "Aut cupiditate facere at consequatur amet reprehenderit dolorum perspiciatis maiores totam iusto autem magni velit et vel labore magni sint.", 201512373, 505, new DateTime(2023, 6, 20, 1, 14, 42, 855, DateTimeKind.Local).AddTicks(9051), "Schinner LLC" },
                    { 87, "Jan Bergnaum", "earum", "http://lorempixel.com/640/480/people", "Unde sit velit dolor sint veniam voluptas quasi quae ea corporis qui ut cum aspernatur aut quod voluptas voluptatem totam.", 920328111, 637, new DateTime(2023, 10, 16, 12, 44, 54, 780, DateTimeKind.Local).AddTicks(2660), "Mosciski - Bailey" },
                    { 88, "Cade Bayer", "inventore", "http://lorempixel.com/640/480/abstract", "Eaque quas inventore molestias reiciendis est harum et atque voluptatem ad atque nihil quaerat optio quod dolor eaque accusantium illo.", 470325144, 971, new DateTime(2023, 12, 27, 2, 45, 18, 982, DateTimeKind.Local).AddTicks(3281), "Bernhard, Fahey and Cartwright" },
                    { 89, "Bernie Schmeler", "eligendi", "http://lorempixel.com/640/480/city", "Recusandae voluptatem rem et ipsa provident nemo aut exercitationem quaerat consequatur id expedita quaerat neque temporibus corrupti quibusdam consectetur ratione.", 248269937, 687, new DateTime(2024, 1, 13, 13, 48, 28, 289, DateTimeKind.Local).AddTicks(9859), "Hermann, Hyatt and Hyatt" },
                    { 90, "Burnice Volkman", "corrupti", "http://lorempixel.com/640/480/food", "Odit delectus omnis similique ex praesentium voluptas qui deserunt rerum excepturi odit vel et quasi molestiae saepe ea ut et.", 268647512, 862, new DateTime(2023, 9, 13, 4, 19, 21, 383, DateTimeKind.Local).AddTicks(7429), "Christiansen Group" },
                    { 91, "Jerod Nolan", "error", "http://lorempixel.com/640/480/nature", "Aut illum debitis saepe mollitia qui perspiciatis facere commodi vitae molestiae quia cum dolores autem eum omnis dolore id quia.", 568804717, 173, new DateTime(2023, 7, 15, 9, 30, 42, 998, DateTimeKind.Local).AddTicks(3659), "Kuvalis, Casper and Schaefer" },
                    { 92, "Hal Cartwright", "maxime", "http://lorempixel.com/640/480/business", "Animi et repellat quidem eos debitis eaque mollitia commodi dolorum qui eveniet molestiae debitis ut quia possimus molestiae vel ratione.", 101168636, 229, new DateTime(2024, 6, 3, 17, 43, 28, 78, DateTimeKind.Local).AddTicks(277), "Lakin, Reynolds and Parker" },
                    { 93, "Princess Legros", "voluptatibus", "http://lorempixel.com/640/480/people", "Dolores voluptatum delectus porro aut qui recusandae ea laborum expedita voluptas eaque sit et nobis et maiores optio est voluptas.", 625603896, 606, new DateTime(2024, 4, 6, 14, 36, 0, 65, DateTimeKind.Local).AddTicks(1381), "Williamson Group" },
                    { 94, "Buster Collins", "totam", "http://lorempixel.com/640/480/technics", "Ab tenetur eos nihil non minus et maiores tenetur voluptatibus eligendi laudantium et ipsum blanditiis rem molestias harum officiis dolorum.", 680140906, 597, new DateTime(2023, 10, 15, 19, 29, 59, 702, DateTimeKind.Local).AddTicks(9027), "Moen - Mosciski" },
                    { 95, "Hailey Medhurst", "magnam", "http://lorempixel.com/640/480/nature", "Voluptatem odio consequatur consequuntur temporibus voluptates sed dolor voluptatem autem vel nihil ab sed cumque inventore perferendis saepe ut doloribus.", 544175228, 581, new DateTime(2024, 1, 13, 17, 52, 50, 978, DateTimeKind.Local).AddTicks(3837), "Fahey - Kassulke" },
                    { 96, "Brook Ankunding", "distinctio", "http://lorempixel.com/640/480/cats", "Aut qui odit optio aut aut explicabo et at fuga aut placeat harum neque magni repudiandae enim sunt ducimus culpa.", 404937735, 650, new DateTime(2024, 5, 18, 1, 2, 2, 160, DateTimeKind.Local).AddTicks(8973), "Bayer - Barton" },
                    { 97, "Willis Bartell", "optio", "http://lorempixel.com/640/480/fashion", "Id quidem eveniet blanditiis porro id consequatur hic cumque unde itaque temporibus similique vitae ratione aspernatur sapiente dolorem quaerat dolor.", 722670085, 209, new DateTime(2023, 12, 7, 2, 23, 30, 55, DateTimeKind.Local).AddTicks(8598), "Armstrong Inc" },
                    { 98, "Kraig Pagac", "eligendi", "http://lorempixel.com/640/480/abstract", "Ut est asperiores esse in ea nihil amet minima facilis et enim quia quasi dolor error laborum labore ut sit.", 280544257, 989, new DateTime(2024, 4, 10, 1, 36, 11, 136, DateTimeKind.Local).AddTicks(8796), "Kerluke LLC" },
                    { 99, "Victoria Frami", "suscipit", "http://lorempixel.com/640/480/city", "Assumenda beatae ut minus voluptatum aut excepturi modi ut rerum vel nobis quo sint ut delectus eaque qui assumenda possimus.", 193000125, 731, new DateTime(2024, 6, 5, 23, 47, 40, 353, DateTimeKind.Local).AddTicks(3602), "Cruickshank, Thiel and Heller" },
                    { 100, "Rupert Oberbrunner", "nobis", "http://lorempixel.com/640/480/business", "Accusantium officia non est voluptas ut ratione est sapiente ad omnis modi ea inventore nisi debitis voluptas eveniet qui facere.", 717451259, 968, new DateTime(2024, 5, 31, 13, 30, 1, 788, DateTimeKind.Local).AddTicks(4202), "Lueilwitz, Deckow and Turcotte" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 100);
        }
    }
}
