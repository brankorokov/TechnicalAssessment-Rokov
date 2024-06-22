using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechnicalAssessmentRokov.Migrations
{
    /// <inheritdoc />
    public partial class NullableAuthor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Joesph Bayer", "quae", "https://picsum.photos/50/50/?image=393", "Qui magnam quia voluptatem deserunt porro quos qui non animi nihil impedit iure quia dolores suscipit itaque assumenda sed recusandae.", 411992869, 61, new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), "Mitchell, Cormier and Gibson", "deposit invoice Brooks" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Brendan Mann", "eaque", "https://picsum.photos/50/50/?image=262", "Quo exercitationem non quia aut corporis cum in nesciunt ex amet dolorem veritatis totam ratione et animi quam aperiam similique.", 891695270, 487, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), "Kunde and Sons", "whiteboard payment Steel" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Reba Smith", "omnis", "https://picsum.photos/50/50/?image=659", "Et fugit dolorem repudiandae incidunt sit aperiam aut optio repellat aliquid officiis et pariatur qui in culpa veritatis fugiat rerum.", 290872020, 504, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), "Jacobson and Sons", "quantifying Gorgeous application" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Eliseo Hyatt", "sunt", "https://picsum.photos/50/50/?image=1080", "Aut praesentium vero eaque itaque velit sapiente minus quaerat ex quaerat odio molestias eos ad omnis necessitatibus eius consequatur et.", 143734572, 67, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), "O'Reilly Group", "world-class Electronics & Automotive Brazilian Real" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Curt Miller", "impedit", "https://picsum.photos/50/50/?image=1007", "Corporis rem dicta eveniet esse velit harum quo illo in accusamus vel dolore perspiciatis exercitationem et sint debitis alias ratione.", 607587344, 838, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Local), "Medhurst - Greenholt", "withdrawal program Benin" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Clementine Auer", "voluptatem", "https://picsum.photos/50/50/?image=468", "Dolore repellendus facilis harum minima sit voluptas est aut dolore quasi omnis voluptates dolorem illum animi voluptate vero assumenda quis.", 982018955, 841, new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), "Bashirian, Bailey and Dach", "Tasty Concrete Pizza Granite technologies" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kaylin Jenkins", "rerum", "https://picsum.photos/50/50/?image=659", "Dolor sed et nulla a dicta ratione rerum atque doloribus nihil deserunt reiciendis et deserunt nisi libero id corrupti velit.", 888131561, 394, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "Koch LLC", "Health & Electronics back-end methodologies" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Justice Cassin", "veniam", "https://picsum.photos/50/50/?image=340", "Quo qui quas rerum sunt modi culpa dolor eum quia provident praesentium omnis alias quas in quod quae necessitatibus temporibus.", 174900407, 249, new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), "Schinner, Nicolas and Bernhard", "Som New Hampshire backing up" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Raquel Schuppe", "harum", "https://picsum.photos/50/50/?image=203", "Illum eligendi repellendus quae ullam blanditiis amet id eos nesciunt reiciendis perferendis eos et laborum corrupti enim sunt quod est.", 555392096, 933, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "Labadie, Zemlak and Buckridge", "Savings Account Silver Views" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Anissa Bartell", "ut", "https://picsum.photos/50/50/?image=487", "Minus enim et delectus pariatur deleniti ullam iure veniam exercitationem aperiam cupiditate et ut cum ab neque recusandae beatae aut.", 401305963, 605, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "Waelchi - Kerluke", "world-class e-commerce system" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sydni Gaylord", "quo", "https://picsum.photos/50/50/?image=645", "Unde facilis perferendis aut ea aut provident quasi est odit reiciendis ipsam perferendis adipisci cumque animi nulla totam et sunt.", 312450036, 150, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), "Stracke - Walker", "Bermuda Pennsylvania Handmade" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jamison Nitzsche", "occaecati", "https://picsum.photos/50/50/?image=45", "Soluta recusandae cumque est commodi eaque aut et laudantium rem neque impedit modi facere assumenda aliquid odit saepe ullam ut.", 128135748, 233, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Moore - Schmeler", "Moldovan Leu directional extranet" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Angel Gottlieb", "iusto", "https://picsum.photos/50/50/?image=66", "Consequatur commodi optio fuga est magni nam nam et ut qui aut autem ratione cumque ipsa neque et minus cum.", 301501528, 924, new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), "Hamill, Nader and Kilback", "one-to-one Japan AGP" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alta Osinski", "consequatur", "https://picsum.photos/50/50/?image=360", "Culpa praesentium cum quo aut voluptatem quia similique quia a optio consequatur voluptatem aliquam et vel quaerat voluptatem sint qui.", 970763071, 992, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "Homenick and Sons", "withdrawal Handcrafted Wooden Bacon Refined Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Van Koelpin", "sunt", "https://picsum.photos/50/50/?image=173", "Velit odio fugit nostrum aspernatur cumque temporibus accusamus omnis rerum facere et voluptatem ipsa vitae qui qui est et velit.", 994340307, 825, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), "Ledner and Sons", "South Carolina digital Persistent" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sydnie Padberg", "aliquam", "https://picsum.photos/50/50/?image=373", "Exercitationem maxime quasi quidem quibusdam soluta quidem debitis libero aut et velit aspernatur voluptas necessitatibus error nostrum quod dolor labore.", 949179475, 755, new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Local), "McLaughlin, Swaniawski and Hegmann", "digital Cambridgeshire green" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lindsey Harris", "commodi", "https://picsum.photos/50/50/?image=93", "Quod ullam tempore libero voluptatem ipsum quisquam et rerum ad doloremque delectus minima quod at ipsum qui ratione unde et.", 495288018, 665, new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), "Hartmann - Funk", "override invoice Tasty Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Paolo Stoltenberg", "illo", "https://picsum.photos/50/50/?image=73", "Est possimus fugiat adipisci aliquid et ut iure sit dolor exercitationem accusantium ex beatae quod ducimus atque id blanditiis dolorem.", 259188001, 575, new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), "Johnston and Sons", "Legacy Malta invoice" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Arvid Roob", "et", "https://picsum.photos/50/50/?image=256", "Iure vel dolores asperiores facere nobis dicta illum itaque id quis sed commodi est sapiente expedita libero deleniti porro voluptas.", 313883825, 937, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "Abernathy, Durgan and Schmidt", "Architect Borders parsing" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Darrel Cruickshank", "sunt", "https://picsum.photos/50/50/?image=873", "Odio voluptate adipisci earum quo suscipit tempora repudiandae aut et neque rem quis numquam ad consequatur impedit aspernatur atque nulla.", 713760204, 881, new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Local), "Ondricka LLC", "magenta turn-key convergence" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Addison Kunde", "porro", "https://picsum.photos/50/50/?image=488", "Quia iste amet accusantium sint distinctio eos autem beatae nemo eum et dolore veniam ut consectetur quis quaerat voluptatem nostrum.", 120483435, 755, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), "Spencer - Schaden", "Rhode Island Wooden Taka" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rashawn Goodwin", "deserunt", "https://picsum.photos/50/50/?image=465", "Et nostrum facere maiores ex omnis ipsum incidunt quia nihil vitae tempore asperiores in eos voluptatem ut sed qui non.", 296609950, 601, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "Willms LLC", "virtual pink software" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Valentine Cormier", "hic", "https://picsum.photos/50/50/?image=884", "Molestias eligendi et cum labore fuga quam officia laborum harum dolorem repellat consequatur enim quibusdam perferendis sint qui vero ducimus.", 731608420, 350, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Local), "Ruecker - Feest", "Checking Account Web Rustic" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Michale Gottlieb", "eligendi", "https://picsum.photos/50/50/?image=139", "Repellat animi quo excepturi fugiat perferendis at reprehenderit vel quod debitis inventore nihil ex non nam eveniet commodi sit voluptas.", 928573728, 699, new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), "Bins and Sons", "Handmade Plastic Salad Electronics, Jewelery & Kids Albania" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Shanie Howe", "consequatur", "https://picsum.photos/50/50/?image=703", "Et cupiditate voluptates a aliquam maxime numquam ullam dicta magni autem dolores officia sit aperiam molestiae quas ipsa et sapiente.", 650717504, 364, new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), "Howell, Fadel and Walsh", "feed Lead utilisation" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Billie Bogisich", "animi", "https://picsum.photos/50/50/?image=942", "Error eaque qui et nihil quasi dicta earum necessitatibus odio repudiandae et unde id incidunt voluptas consequatur molestiae velit officiis.", 998546288, 475, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), "Ortiz, Graham and Borer", "Secured Malawi Tasty" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ollie Harris", "qui", "https://picsum.photos/50/50/?image=266", "Corporis tenetur ipsum eos sit quasi saepe sed non nisi distinctio nemo quisquam deserunt qui reprehenderit modi id molestiae sed.", 199257027, 638, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "Borer Inc", "connect Rustic Wooden Pants copy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Tressie McLaughlin", "magni", "https://picsum.photos/50/50/?image=1046", "Placeat qui aut occaecati aut et est expedita ab quis ratione et voluptas autem sit aut qui corporis hic eos.", 229100955, 690, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), "Medhurst - Wyman", "morph Walk workforce" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Enrico Wunsch", "voluptatibus", "https://picsum.photos/50/50/?image=949", "Perferendis perferendis quia voluptatem rerum quidem et libero architecto suscipit recusandae iure hic assumenda neque ipsa rerum alias tenetur reprehenderit.", 407393473, 860, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), "Mante, Thiel and Nienow", "bandwidth Automotive & Shoes Specialist" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Betsy Trantow", "labore", "https://picsum.photos/50/50/?image=1040", "Doloribus molestiae hic illo sed enim aliquid quidem et corporis veritatis at cumque veritatis reiciendis alias fugit est alias provident.", 943305898, 404, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), "Fadel and Sons", "Spurs deposit EXE" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Willis Schowalter", "autem", "https://picsum.photos/50/50/?image=38", "Eos non possimus aliquam nihil magni suscipit est laborum quia ad inventore voluptas similique voluptatem rem nesciunt et iure et.", 712558544, 345, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Local), "Weimann, Strosin and Labadie", "Virginia transitional USB" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Osborne Jacobi", "minima", "https://picsum.photos/50/50/?image=789", "Sed animi non quos nulla repudiandae autem laudantium recusandae cum dolore cum quaerat quia esse id quis consectetur aut fugiat.", 969710111, 706, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Brakus - Moore", "contingency Investment Account Timor-Leste" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Trevor Hand", "nihil", "https://picsum.photos/50/50/?image=837", "Ut nihil eius quibusdam velit culpa consequatur est possimus reprehenderit sit necessitatibus quia qui repellendus accusamus et qui nulla id.", 130880274, 443, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Local), "Bailey, Reinger and O'Connell", "Fresh Customer Personal Loan Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Tad Kunde", "et", "https://picsum.photos/50/50/?image=679", "Itaque corporis quasi voluptas et a animi voluptatem eos praesentium quis quo ut est enim earum eaque numquam impedit corporis.", 536528425, 397, new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "Littel Inc", "Industrial Intelligent Metal Keyboard partnerships" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dimitri Jenkins", "at", "https://picsum.photos/50/50/?image=816", "Ea minus necessitatibus et aut officia quis illum molestiae ipsum dignissimos laudantium blanditiis ex incidunt delectus modi reprehenderit itaque modi.", 708409463, 789, new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), "McLaughlin Inc", "Functionality exuding Product" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dana Schmitt", "magnam", "https://picsum.photos/50/50/?image=113", "Doloremque non est temporibus aliquam et nobis debitis facilis fugiat optio laudantium ratione officiis qui fugiat cupiditate est dicta et.", 355617416, 475, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), "Bednar - Kerluke", "Parkway deposit intermediate" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Leone Kuhn", "quis", "https://picsum.photos/50/50/?image=606", "Deserunt cum provident quia velit doloribus perspiciatis quidem hic maxime aut facere amet quia velit aut recusandae temporibus aut voluptates.", 520468233, 53, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), "Lakin - Kertzmann", "Avon schemas bottom-line" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Geovanni Nader", "nisi", "https://picsum.photos/50/50/?image=945", "Adipisci ut adipisci porro sunt odit eius praesentium omnis error non non quis sed ducimus dolore qui corporis quasi quae.", 100425312, 542, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Local), "Sporer Group", "Squares Steel Personal Loan Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Wilfredo Monahan", "deserunt", "https://picsum.photos/50/50/?image=534", "Qui nisi eum nihil soluta quisquam repellendus fuga voluptas doloribus sed non cum labore cumque optio eum dolore at temporibus.", 548674819, 926, new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), "Strosin and Sons", "Run navigate disintermediate" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Herminia Barrows", "dolorem", "https://picsum.photos/50/50/?image=578", "Facere rerum quibusdam temporibus quaerat eligendi quo repellat ratione in animi omnis sint nam ut similique tempore dolor ut adipisci.", 442983871, 236, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "Mitchell, Schiller and Goldner", "Virtual Bulgaria online" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Yadira Kub", "voluptate", "https://picsum.photos/50/50/?image=228", "Cupiditate rem sint et cumque sit est impedit reprehenderit rerum sunt id ratione omnis at quis consequatur unde cumque voluptatibus.", 479433252, 69, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "Mann - Schinner", "tan iterate deploy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Fernando Glover", "sapiente", "https://picsum.photos/50/50/?image=694", "Facere eveniet quasi culpa laboriosam quos quod quod aut fuga necessitatibus mollitia illum officiis animi veniam aliquid ducimus at vitae.", 181760128, 307, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Local), "Mosciski - Sauer", "program Lebanese Pound Frozen" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Savanah Predovic", "quaerat", "https://picsum.photos/50/50/?image=643", "Praesentium voluptates ipsum iste qui doloremque laudantium rem maxime ut quia aut dicta ut voluptates est est qui sunt dignissimos.", 408249880, 79, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), "Wisoky - Stokes", "Awesome Metal Table Handmade Cotton Salad Ergonomic Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jedediah Krajcik", "est", "https://picsum.photos/50/50/?image=1060", "Voluptatem vel neque voluptatem error consectetur incidunt quae tempora omnis possimus assumenda saepe ea temporibus tenetur explicabo qui sit beatae.", 712901690, 147, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Cremin, Erdman and Funk", "Awesome Granite Mouse Codes specifically reserved for testing purposes invoice" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mike Rowe", "rerum", "https://picsum.photos/50/50/?image=438", "Ut ratione itaque reiciendis reiciendis dignissimos sit ut magni maiores excepturi nemo quas nemo non ipsum ducimus veniam dolores quasi.", 468930382, 176, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), "Wuckert, Denesik and McCullough", "Plain Designer programming" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Everett Runolfsdottir", "non", "https://picsum.photos/50/50/?image=145", "Provident eaque quia omnis animi quis qui omnis ipsum tempore temporibus reiciendis repellat exercitationem quis qui incidunt magni repellendus sint.", 387504398, 342, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Kerluke, Farrell and Yundt", "Berkshire monitor Alley" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Henri McDermott", "et", "https://picsum.photos/50/50/?image=462", "Quaerat rerum quis magni tempore harum perspiciatis quia cum aliquam voluptatibus saepe exercitationem quia ut voluptatibus sunt eos quaerat provident.", 590184724, 115, new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), "Ernser, Keeling and Padberg", "capacitor North Carolina asymmetric" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Aileen Ryan", "enim", "https://picsum.photos/50/50/?image=488", "Autem est nemo perspiciatis nam doloremque nesciunt vel non eveniet ad eum minus aperiam nulla veritatis et ab magnam sit.", 187344363, 662, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Ullrich LLC", "Road multi-byte Auto Loan Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Cade Pollich", "autem", "https://picsum.photos/50/50/?image=1073", "Et eum quos ducimus et autem perspiciatis laboriosam eos sed aliquid culpa nisi sint est optio explicabo ducimus corrupti qui.", 431301655, 942, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Local), "Trantow, Watsica and Blanda", "feed interactive robust" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Skylar Wilderman", "veniam", "https://picsum.photos/50/50/?image=287", "Omnis dolores enim repudiandae quos et facilis dicta enim aut consectetur quos eum rerum dolor nihil ea doloremque eos rerum.", 272247656, 364, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "Leuschke, Lockman and Emard", "Books, Toys & Books synthesize Zimbabwe" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Murray Brekke", "quo", "https://picsum.photos/50/50/?image=188", "Ut id eum explicabo aut aut molestiae mollitia mollitia voluptatibus nihil et beatae aut ex dolor cumque ea eveniet nostrum.", 316635278, 309, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), "Heathcote Inc", "Fully-configurable analyzing solid state" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Avery Stark", "a", "https://picsum.photos/50/50/?image=901", "Omnis nulla est numquam rerum quas ipsam expedita qui repellat debitis sequi natus qui dolores nisi qui ea hic expedita.", 258803150, 818, new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), "VonRueden, Gerhold and Koelpin", "auxiliary port maximized" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Laila Friesen", "in", "https://picsum.photos/50/50/?image=1074", "Atque aspernatur accusantium et dolore temporibus dolorem quas animi in exercitationem ad libero excepturi enim corrupti fuga sunt molestias dolor.", 528233109, 836, new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), "Runolfsdottir Inc", "auxiliary Executive coherent" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Helene Gerhold", "sunt", "https://picsum.photos/50/50/?image=1029", "Quia nulla ad quia modi blanditiis quibusdam sunt porro itaque ut dolorum aliquam quo soluta veritatis rem beatae voluptatem quo.", 615501026, 844, new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), "Purdy, Padberg and Hansen", "Intelligent Cotton Salad mint green Intelligent Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Danika Gusikowski", "consequatur", "https://picsum.photos/50/50/?image=859", "Amet ut officia rerum voluptas et dicta aliquam veritatis eos voluptas suscipit nemo non rerum et sunt sapiente doloribus ullam.", 489775738, 776, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), "Wilkinson - Fisher", "Executive intermediate Parkway" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Grant Jacobs", "corrupti", "https://picsum.photos/50/50/?image=1022", "Blanditiis impedit quia ullam vero optio et unde possimus perspiciatis quibusdam ab numquam adipisci enim labore qui quaerat est exercitationem.", 353127532, 347, new DateTime(2024, 6, 16, 0, 0, 0, 0, DateTimeKind.Local), "Stroman, Ruecker and Beer", "Stand-alone extend benchmark" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Laverna Greenholt", "molestias", "https://picsum.photos/50/50/?image=254", "Ut voluptas et iure optio harum omnis exercitationem et repudiandae aut quia culpa nulla omnis at omnis qui et sit.", 183404201, 689, new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), "Kris - Marquardt", "HDD Practical Centralized" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Shayne Rohan", "non", "https://picsum.photos/50/50/?image=574", "Ducimus reiciendis blanditiis nam omnis commodi saepe numquam quo harum magni ad doloremque iure delectus reiciendis dolor earum quam eius.", 262495602, 561, new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), "Cormier LLC", "virtual Washington sensor" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Odell Howell", "labore", "https://picsum.photos/50/50/?image=875", "Quia est dolorem et veritatis excepturi vero amet et beatae reprehenderit velit facere voluptatum hic omnis ut vel iusto est.", 628921592, 634, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), "Lynch, Ledner and Pagac", "indexing Fantastic Steel Chair Virtual" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Danika Huel", "ullam", "https://picsum.photos/50/50/?image=718", "Aut et eos rerum voluptatem saepe nam id rerum reiciendis ut porro accusamus praesentium corrupti dolore quia consectetur laboriosam quia.", 859184266, 238, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Local), "Wyman, Schumm and Oberbrunner", "schemas Avon SQL" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kyler Lynch", "corrupti", "https://picsum.photos/50/50/?image=939", "Explicabo quo velit aliquid quis sint in reiciendis quod odio enim natus eum cum ea fuga nemo facere eos nostrum.", 553038505, 108, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Local), "Sipes LLC", "withdrawal Berkshire turn-key" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Junior Flatley", "est", "https://picsum.photos/50/50/?image=32", "Earum cupiditate a rerum et optio commodi illum doloribus corrupti quidem quidem iusto vitae ut alias accusantium quo corrupti eaque.", 158991334, 951, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Local), "Nader, Murray and McKenzie", "copy ubiquitous harness" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kraig Kovacek", "impedit", "https://picsum.photos/50/50/?image=920", "Voluptatem blanditiis numquam corrupti eaque est error eligendi suscipit consectetur delectus ipsam nesciunt nobis nam perspiciatis culpa temporibus eum ut.", 195590759, 565, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "McKenzie - Bins", "holistic modular Tools, Baby & Outdoors" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Trenton Predovic", "voluptate", "https://picsum.photos/50/50/?image=500", "Quia optio et sed delectus aut veniam et saepe cupiditate rem veniam dicta voluptatem incidunt id rem at rerum quos.", 594225961, 598, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), "Weissnat and Sons", "Games, Sports & Shoes Kuwait payment" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Makayla Muller", "rerum", "https://picsum.photos/50/50/?image=278", "Est itaque nihil odio qui tempore assumenda dolorem error molestiae molestias consequatur quaerat ab dolor ea perspiciatis velit et aut.", 195489742, 993, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), "Bednar, Dare and Dach", "Music, Shoes & Sports Auto Loan Account Practical Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alvah Collier", "molestiae", "https://picsum.photos/50/50/?image=950", "Omnis iusto eligendi animi error sit qui dignissimos aut dolorum nihil nihil possimus aut odio ab qui dolore necessitatibus id.", 306648561, 231, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Local), "Greenfelder Inc", "Buckinghamshire Drive withdrawal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Florine Grimes", "debitis", "https://picsum.photos/50/50/?image=835", "Omnis ex placeat rem nisi consequatur quaerat eius natus cumque porro accusamus necessitatibus sapiente voluptate libero animi et nulla sit.", 125286106, 881, new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Hegmann, Waelchi and Littel", "Quality optical Brunei Dollar" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jayme Bode", "quia", "https://picsum.photos/50/50/?image=441", "Sint minus alias laudantium similique pariatur eos ut perferendis officiis ea consectetur et tempore libero ea molestiae quia id officia.", 729952837, 622, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Local), "Lesch - Treutel", "Industrial Ridges SDD" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Bernie Spencer", "et", "https://picsum.photos/50/50/?image=573", "Voluptatem aut et nobis doloremque deserunt aperiam et assumenda earum perspiciatis in non veritatis et veritatis iure ipsam et a.", 230344829, 273, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), "Hills Group", "Beauty, Books & Tools granular 24/365" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Domenick Yost", "ea", "https://picsum.photos/50/50/?image=495", "Repellendus velit neque omnis asperiores nam consequatur esse at voluptates aut ut impedit ut placeat rerum laboriosam quod ea quasi.", 618575137, 277, new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Rutherford Group", "Cotton framework auxiliary" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Joshuah Zieme", "rerum", "https://picsum.photos/50/50/?image=703", "Illum aut quia recusandae iste id aut accusantium repellat nemo dolorem magni vel ipsum nam sint voluptatem quis voluptas expedita.", 975835670, 459, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "O'Reilly - Mraz", "overriding architectures Developer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Julio Goodwin", "distinctio", "https://picsum.photos/50/50/?image=16", "Laboriosam natus dolores ea ut aut dolorem nesciunt necessitatibus molestias aut rerum quis laborum dolor error quo eaque et ea.", 481673166, 959, new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), "Bogan, Rosenbaum and Hickle", "interactive Mauritius Rupee Incredible Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jo Conn", "modi", "https://picsum.photos/50/50/?image=151", "Maiores nihil molestias rem sunt rerum molestias sint aut maxime eos rerum incidunt recusandae libero maiores qui id consectetur quasi.", 131188798, 807, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Kuhic, Jacobs and Blick", "HTTP Tajikistan Plastic" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Abbie Veum", "ipsa", "https://picsum.photos/50/50/?image=746", "Quae saepe id quos quis doloremque beatae et exercitationem iure non qui praesentium nobis nostrum voluptatem aut voluptate rerum et.", 653657710, 143, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), "Morar LLC", "attitude Qatar Streamlined" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Danika Feil", "sint", "https://picsum.photos/50/50/?image=966", "Commodi quos autem qui enim sunt ipsum non ab tempore praesentium eum nam voluptatibus consequatur eos consequuntur vitae odio saepe.", 886126239, 539, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), "Huel and Sons", "e-tailers Bedfordshire magnetic" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rudy Tromp", "reprehenderit", "https://picsum.photos/50/50/?image=304", "Cupiditate atque sunt neque necessitatibus doloribus est dolorem voluptas iusto ex ut consequatur fugiat officia quia ex omnis consequatur tenetur.", 242075620, 993, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "Boyer and Sons", "navigating program compress" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Nels Mills", "ut", "https://picsum.photos/50/50/?image=520", "Sint earum aliquid soluta animi adipisci sunt maiores nihil ut voluptas iusto officiis animi deserunt doloremque earum corrupti omnis itaque.", 782455140, 877, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), "Hamill LLC", "deliver withdrawal mesh" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jeanie Yost", "possimus", "https://picsum.photos/50/50/?image=409", "Iure repellat dolorem sunt rem laboriosam et voluptates magni omnis voluptatibus ipsam vel error debitis ut maiores sed voluptatem quos.", 373504972, 371, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "Christiansen Group", "Response infrastructure overriding" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Elissa Streich", "quos", "https://picsum.photos/50/50/?image=178", "Magnam hic voluptatem itaque fugiat sunt quo ullam aliquam optio qui aut voluptatem dolores itaque perferendis quaerat porro autem consequuntur.", 268836525, 69, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "Lubowitz and Sons", "Checking Account index Nigeria" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Claudie Gulgowski", "qui", "https://picsum.photos/50/50/?image=844", "Maxime ea pariatur quia minima sed id quo aspernatur blanditiis neque et velit dolor perferendis rerum quaerat at beatae doloremque.", 266660535, 859, new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), "Pfannerstill - Douglas", "tan Engineer Buckinghamshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "AUTHOR", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Chaya Roob", "https://picsum.photos/50/50/?image=565", "Est eum ipsum eius consequatur nihil rerum totam alias ut doloribus aut earum qui repudiandae veniam corrupti voluptate et repudiandae.", 440796670, 713, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), "Leannon - Schuppe", "HDD withdrawal Credit Card Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Marcelino Pfeffer", "labore", "https://picsum.photos/50/50/?image=584", "Consectetur est et eveniet ducimus quo est sequi dolor ut qui id soluta atque aut rem officia officiis sit architecto.", 531612531, 160, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), "Oberbrunner - Veum", "Home Loan Account indexing Virtual" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Casandra Walsh", "dolorem", "https://picsum.photos/50/50/?image=345", "Velit mollitia molestias est quas repellendus quo laboriosam et est quam quisquam cumque consequatur molestiae eaque consequatur eligendi facilis non.", 987965371, 378, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "Huel - Hand", "deliverables Regional Practical" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Korbin Dicki", "tenetur", "https://picsum.photos/50/50/?image=460", "Nemo recusandae earum aspernatur id enim voluptatem rerum ut illo cumque aliquid et iste tenetur reprehenderit quibusdam et ex voluptatum.", 125327951, 304, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Local), "Runolfsdottir LLC", "Mexican Peso Handcrafted Soft Chips Synchronised" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Zackery Hilpert", "quam", "https://picsum.photos/50/50/?image=714", "Sit distinctio dolorem reiciendis modi quisquam saepe ducimus incidunt rerum qui repellat mollitia saepe tempora nihil modi doloremque velit ad.", 765389698, 532, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), "Graham and Sons", "structure salmon firmware" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dayana Welch", "asperiores", "https://picsum.photos/50/50/?image=452", "Eum debitis commodi rerum impedit quibusdam id et deleniti debitis qui qui non non officia occaecati ad alias recusandae alias.", 116050398, 486, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Hirthe - Funk", "Division system-worthy Games & Automotive" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Angeline Schumm", "voluptas", "https://picsum.photos/50/50/?image=129", "Maiores sed similique velit est rem excepturi ea assumenda minus omnis non dolor ea deserunt blanditiis voluptas rerum quisquam eum.", 769939199, 162, new DateTime(2023, 7, 9, 0, 0, 0, 0, DateTimeKind.Local), "Bradtke - Nikolaus", "Borders United Kingdom compressing" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Claire Denesik", "consequatur", "https://picsum.photos/50/50/?image=720", "Aliquam expedita recusandae fuga corporis tempore debitis porro perspiciatis reiciendis eos enim rerum voluptas vero aut aliquam molestias est occaecati.", 608865782, 150, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), "Smith and Sons", "Licensed Rubber Gloves Kansas Agent" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Tatum Johns", "qui", "https://picsum.photos/50/50/?image=373", "Enim aut repudiandae qui dignissimos illum nesciunt est vel odio est aut id consequatur veniam ut qui explicabo voluptatem repellat.", 742994549, 675, new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), "Donnelly, Wolff and Johnston", "Oregon Cambridgeshire Fork" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Samson Hilpert", "sit", "https://picsum.photos/50/50/?image=525", "Laborum odio exercitationem ut possimus quia doloribus tempore vel veniam ipsam omnis eaque consequatur eveniet quo suscipit animi eum natus.", 829428456, 672, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Local), "Vandervort - Murazik", "Uruguay Swaziland Jewelery & Grocery" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alison Senger", "porro", "https://picsum.photos/50/50/?image=700", "Dolorem consectetur cupiditate accusantium harum quis natus laborum unde eum voluptatum odit nobis vitae a saepe adipisci consequatur et qui.", 197145035, 98, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "Jacobs Inc", "Global olive Sleek" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kasey Ullrich", "expedita", "https://picsum.photos/50/50/?image=253", "Perspiciatis commodi ut quisquam vitae qui sunt illo reiciendis veritatis non omnis quia reprehenderit ex doloremque ut modi in quisquam.", 357001013, 58, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), "Howe - Hackett", "GB architect Rustic Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Luisa Rohan", "dignissimos", "https://picsum.photos/50/50/?image=967", "Dolorem alias autem et officiis molestiae dicta voluptatem ut molestiae nulla eum fugiat consectetur voluptatem delectus dolorum et et voluptatem.", 146606154, 187, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), "Gutkowski - Harber", "South Dakota Estates Money Market Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Audra Casper", "voluptate", "https://picsum.photos/50/50/?image=339", "Consequatur autem minima minima nulla molestiae ut quidem error illum et cumque laboriosam recusandae mollitia reiciendis quo sed numquam dolor.", 649682307, 883, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), "Goodwin - Stiedemann", "application sensor value-added" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Bethel Padberg", "voluptas", "https://picsum.photos/50/50/?image=122", "Voluptatum sed aliquam sed qui voluptatum dicta quaerat sed iure quos libero consequuntur minima deserunt molestiae tempore debitis et deleniti.", 728386331, 838, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), "Hegmann Inc", "leading-edge Soft clicks-and-mortar" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Veda Weimann", "tenetur", "https://picsum.photos/50/50/?image=322", "Neque molestias harum eveniet ipsum veritatis sit ut reprehenderit repudiandae provident culpa dicta sint est asperiores cum dolores et illo.", 757790538, 992, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), "Bruen - McKenzie", "facilitate Glen Incredible" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Doyle Roob", "voluptatem", "https://picsum.photos/50/50/?image=793", "Iure molestiae dignissimos necessitatibus dolorem dicta quas alias quae et consectetur id non ea error sit eos tempore nesciunt voluptatibus.", 658429130, 531, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Local), "Anderson - Thiel", "HTTP 24/7 Credit Card Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Veronica Botsford", "inventore", "https://picsum.photos/50/50/?image=763", "Quo reiciendis blanditiis explicabo iure aut perferendis ab sit quia repellat aut et optio dignissimos id ex non et suscipit.", 459958894, 814, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), "Douglas - Nikolaus", "Square Borders Home" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Renee Reinger", "placeat", "https://picsum.photos/50/50/?image=1019", "Accusamus mollitia voluptatem totam totam dolorum aliquid quisquam laborum maiores possimus et similique sed est dolor quia tempora corrupti et.", 763431357, 195, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "Dicki, Farrell and Renner", "Specialist navigating ROI" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Leopold Harris", "dignissimos", "https://picsum.photos/50/50/?image=845", "Eveniet ad quas odio ea esse deserunt sed odio accusantium qui aut quos voluptas illo vitae atque aut distinctio facere.", 496418992, 687, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), "Wintheiser, Hills and Parisian", "payment Cote d'Ivoire feed" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Werner Morissette", "reprehenderit", "https://picsum.photos/50/50/?image=339", "Quas aspernatur vel harum neque non molestiae qui itaque sit perspiciatis est omnis saepe est odio totam aliquid iste veniam.", 698708640, 107, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "Beahan - Predovic", "robust Officer Home Loan Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hazel Wuckert", "aliquam", "https://picsum.photos/50/50/?image=614", "Rerum ullam velit quia deleniti aut in sint sit laudantium ut commodi rerum magnam qui perspiciatis sunt odio nulla occaecati.", 478981832, 932, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Local), "Emard, Hartmann and Bauch", "transmit Rubber Cove" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Patricia Reinger", "consequatur", "https://picsum.photos/50/50/?image=722", "Occaecati commodi et repudiandae animi recusandae illum harum ea quidem quia ipsa et quis ut ab eligendi distinctio aut et.", 535434401, 769, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), "Heidenreich - Hirthe", "deposit Ergonomic Rustic Metal Towels" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Maxime Gulgowski", "hic", "https://picsum.photos/50/50/?image=648", "Saepe vel ex eaque et nihil qui repellat corporis iusto consectetur ipsa atque vel enim et pariatur a rerum quae.", 271842738, 643, new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), "O'Reilly - Swift", "Micronesia open-source Bedfordshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Glen Herzog", "alias", "https://picsum.photos/50/50/?image=85", "Consequatur nihil et nemo earum reiciendis cum aut temporibus qui sit quos odio aliquam consequatur et molestiae non ut doloremque.", 435320443, 94, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "Johnston, Rolfson and Roob", "Croatian Kuna bluetooth Rustic" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Claire Harber", "doloremque", "https://picsum.photos/50/50/?image=180", "Repellendus dolores accusamus dolores et odit similique et fuga eos asperiores explicabo aliquam reiciendis velit blanditiis reiciendis quo eum ad.", 999774331, 80, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "Kautzer, Ankunding and O'Keefe", "Intelligent Fresh Fish Senior Face to face" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Cleve McKenzie", "quos", "https://picsum.photos/50/50/?image=802", "Harum maxime fugit consectetur ut atque sed quam asperiores nesciunt nam praesentium odit deserunt quidem perferendis ipsam sed veniam modi.", 878793946, 480, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "Mraz, Keebler and Pfannerstill", "world-class Barbados index" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Amelie Gleichner", "est", "https://picsum.photos/50/50/?image=378", "Qui ad eos rerum necessitatibus delectus nemo magni dolores temporibus inventore voluptas ut excepturi sint iusto iure rem deserunt commodi.", 640163309, 204, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), "Bradtke - Hills", "Practical Metal Pizza Functionality Refined Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lourdes Hilll", "culpa", "https://picsum.photos/50/50/?image=192", "Totam fugiat ut ex enim ex excepturi exercitationem laboriosam est cupiditate consequuntur ut repellendus error qui unde culpa repudiandae deleniti.", 701649286, 966, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), "McCullough Group", "North Dakota front-end Response" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Laurine Mann", "saepe", "https://picsum.photos/50/50/?image=721", "Nostrum omnis ex ex explicabo dolores in enim ut omnis dolorem inventore pariatur velit ea eum sint et id consequatur.", 750802986, 106, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), "Steuber, Sipes and Leannon", "Tactics Generic Frozen Bacon Rustic Wooden Keyboard" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kyleigh Prohaska", "optio", "https://picsum.photos/50/50/?image=590", "Qui id rerum ipsa rerum aut id voluptate id omnis amet iusto sed id excepturi voluptatem fugiat voluptas omnis est.", 281156152, 412, new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), "Olson, Davis and Watsica", "Pula Metrics grey" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mohammad Grimes", "qui", "https://picsum.photos/50/50/?image=1027", "Quia exercitationem non laboriosam praesentium autem eum voluptatibus facere aliquam nihil quisquam possimus dolore esse voluptas harum quae necessitatibus quia.", 821063076, 299, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "Pagac - Dare", "transform Public-key Avon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Archibald Roob", "veritatis", "https://picsum.photos/50/50/?image=748", "Expedita labore nesciunt dolorum a est harum eius sit quae provident dolorum pariatur optio quasi ducimus doloribus exercitationem laboriosam eligendi.", 575509866, 130, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), "Schneider - Lang", "invoice Gorgeous Frozen Chicken Mall" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Maurine Dickens", "sed", "https://picsum.photos/50/50/?image=965", "In quas dolorum est voluptate id rerum vel rerum exercitationem aliquam totam qui qui quis ut laudantium cum eligendi voluptate.", 360217893, 936, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), "Casper, Smith and Yost", "navigating optical middleware" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Taurean Schaden", "quos", "https://picsum.photos/50/50/?image=1062", "Magni totam explicabo aliquam voluptas voluptatem quisquam earum dolores dolorem earum impedit veritatis consequuntur veritatis nam occaecati laboriosam sed et.", 228356765, 422, new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), "McClure - Wuckert", "Convertible Marks connecting SMS" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Guadalupe Rau", "mollitia", "https://picsum.photos/50/50/?image=600", "Ut similique amet repellat sequi eaque provident eveniet aliquid ipsum impedit libero neque eius nisi autem minima fugiat accusamus dolor.", 626240072, 782, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), "Lakin Group", "Dong background teal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Aryanna Kihn", "quasi", "https://picsum.photos/50/50/?image=701", "Reprehenderit et deleniti sit velit fugiat at perspiciatis quaerat et suscipit voluptas voluptas nesciunt aliquid pariatur at qui voluptas tempore.", 969187734, 802, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Jacobson - Cremin", "web-enabled payment Incredible Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Abbie Kshlerin", "labore", "https://picsum.photos/50/50/?image=38", "Illum molestiae vel consequuntur quo occaecati tempore magnam fugit vero facilis libero quia eligendi dolorem temporibus dolores corporis animi cupiditate.", 214124313, 99, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), "Gorczany, Anderson and Schmeler", "blockchains synthesizing Inlet" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lelia Macejkovic", "dolores", "https://picsum.photos/50/50/?image=369", "Consequatur velit placeat saepe voluptatem delectus possimus molestiae dicta esse consequatur aut at id vel perspiciatis non quis sed est.", 748969112, 481, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), "Parisian LLC", "Home Loan Account Jewelery, Kids & Home Tools, Books & Sports" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Meta Orn", "dicta", "https://picsum.photos/50/50/?image=69", "Non et iusto ut sint cupiditate inventore consequatur et dolores sapiente sapiente porro natus adipisci neque ea qui sit fugiat.", 256570532, 363, new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), "Stroman, Medhurst and Bergnaum", "orchid Egypt Licensed Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jonas Heller", "sit", "https://picsum.photos/50/50/?image=613", "Culpa debitis sit perferendis est tempore aut consectetur molestiae magnam suscipit et illum quos voluptatem accusamus eos impedit omnis ipsa.", 366835925, 702, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "Bechtelar and Sons", "model Berkshire Shoes & Automotive" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jennie Hauck", "enim", "https://picsum.photos/50/50/?image=811", "Omnis eum sapiente rerum molestias consequuntur voluptates iure voluptatem et molestiae in quia dolor vero consequatur dolore animi voluptatem corporis.", 366991134, 187, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), "Weimann, Botsford and Fay", "Indian Rupee violet matrix" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Laura Ledner", "nostrum", "https://picsum.photos/50/50/?image=646", "Commodi dolores modi dolor pariatur fuga quis vero deserunt unde nulla velit sunt distinctio expedita delectus ut aliquam incidunt minus.", 171387700, 765, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), "Hudson, Morar and Kulas", "quantify Industrial Awesome Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Monica Quigley", "beatae", "https://picsum.photos/50/50/?image=927", "Et dolorem non nulla dolores vel beatae accusantium et doloribus iusto unde vero aut voluptatem ad nobis veniam incidunt ratione.", 784777191, 776, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "Macejkovic and Sons", "visionary Oval pixel" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lilla Muller", "maiores", "https://picsum.photos/50/50/?image=158", "Commodi quia blanditiis porro doloribus ad vitae rerum eveniet qui autem cupiditate distinctio laudantium et ut hic alias non aut.", 750471638, 478, new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), "Schmitt - Kuhic", "withdrawal Causeway Thailand" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Madison Hartmann", "blanditiis", "https://picsum.photos/50/50/?image=1084", "Voluptas voluptate ea eaque ullam ut dolorem laborum eveniet ratione sit harum reiciendis voluptas et natus ducimus odio perspiciatis sit.", 707358039, 153, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), "Ritchie and Sons", "standardization dynamic firewall" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Emmie Haley", "voluptas", "https://picsum.photos/50/50/?image=649", "Nisi sequi necessitatibus hic aperiam repudiandae adipisci a rerum laboriosam recusandae eum consequuntur aut fugit vel quae officiis a saepe.", 742669089, 450, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "Waelchi - Veum", "IB Communications PNG" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Edmond Bradtke", "velit", "https://picsum.photos/50/50/?image=942", "Quae vitae commodi expedita sunt maiores distinctio ducimus perferendis rerum laborum quia et sed rerum dolorem nisi laudantium est magni.", 361939646, 800, new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), "Medhurst Inc", "ubiquitous syndicate port" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rey Little", "rerum", "https://picsum.photos/50/50/?image=119", "Eum recusandae consequatur voluptatibus ducimus qui eaque laboriosam consequatur mollitia veniam deserunt qui dolores voluptatem voluptas exercitationem unde eius rem.", 649576991, 786, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Local), "Huels Group", "Isle Gorgeous Soft Bacon Borders" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kamryn Parisian", "quam", "https://picsum.photos/50/50/?image=724", "Et suscipit dolorem nam non distinctio quibusdam temporibus inventore aut mollitia in id tenetur at architecto neque sint modi est.", 259041283, 390, new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), "Conn, Raynor and Effertz", "regional Home, Tools & Sports Refined Metal Chair" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Cordia Torp", "quod", "https://picsum.photos/50/50/?image=553", "Omnis ea ea veniam id alias nobis nemo architecto nihil eum rerum aut ab voluptatem illum quis odit qui vel.", 630197287, 81, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "Lowe and Sons", "Handmade Metal Towels Planner sensor" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Theodora Bode", "ex", "https://picsum.photos/50/50/?image=502", "Consequatur impedit rerum commodi quia nostrum odio laboriosam rerum maxime et illum porro non harum repudiandae placeat odit qui debitis.", 881718036, 302, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), "Homenick, Veum and Sporer", "Plastic Concrete Dalasi" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Charles Streich", "non", "https://picsum.photos/50/50/?image=603", "Et et corporis doloremque illo perferendis eaque consequatur minus labore non cumque tempora delectus voluptates nobis id nostrum quae ea.", 589697545, 178, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), "Cronin - Schmitt", "quantify moderator input" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jerald Krajcik", "facere", "https://picsum.photos/50/50/?image=566", "Laboriosam commodi omnis vel recusandae consectetur aliquid nemo eveniet culpa fugit consequatur corporis delectus porro est id aliquid quisquam ipsam.", 308843241, 980, new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "Willms Group", "Ford teal IB" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sophia Doyle", "ut", "https://picsum.photos/50/50/?image=1036", "Eos consequatur doloremque quasi beatae deleniti voluptate sint nobis nobis voluptas perferendis iusto fugit fugit iusto ex non praesentium autem.", 429193290, 505, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), "Donnelly LLC", "Reverse-engineered white Computers, Baby & Baby" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Seth Weber", "sapiente", "https://picsum.photos/50/50/?image=392", "Qui quod sunt est cumque quod qui consequuntur beatae blanditiis facilis dolorum nihil voluptatum voluptas voluptatem amet vel consequatur omnis.", 484295136, 925, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "Bednar - Hartmann", "France parse Botswana" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Adolfo Terry", "dolore", "https://picsum.photos/50/50/?image=1052", "Eligendi nobis fugiat tempora corporis illo quos delectus dolorum cumque est exercitationem aperiam dolorem aut aut nihil quia aliquid laboriosam.", 837951220, 511, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), "Wilderman - Feest", "Tasty Frozen Bike Creative Russian Ruble" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kamron Zieme", "officia", "https://picsum.photos/50/50/?image=636", "Error unde corrupti aperiam optio eum nesciunt nostrum vel ex molestias odio et dolorem rerum similique commodi facilis dolores iusto.", 448482491, 296, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), "McKenzie Group", "Steel Sleek Metal Chips Direct" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Celia Hoeger", "quod", "https://picsum.photos/50/50/?image=755", "Consequatur quo corporis fugiat similique non et non quia quis incidunt at iure quod eveniet facere numquam et numquam repellat.", 388044111, 355, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), "Walter, Conroy and Kohler", "Generic Soft Cheese Personal Loan Account synergistic" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alexandre Orn", "cupiditate", "https://picsum.photos/50/50/?image=416", "Quibusdam recusandae ea nihil nisi dicta autem officia ipsum itaque quisquam ab exercitationem qui voluptas iure qui id voluptatem sit.", 747437248, 559, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "Ankunding - Strosin", "Director Norwegian Krone Rhode Island" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Vivienne Grant", "rerum", "https://picsum.photos/50/50/?image=439", "Quam nesciunt aliquid minima consequatur quisquam voluptatem omnis deserunt magnam est excepturi totam aperiam et modi expedita non possimus aut.", 169893884, 486, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), "Koch - Raynor", "next-generation Granite extranet" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Scarlett Treutel", "assumenda", "https://picsum.photos/50/50/?image=782", "Accusantium nobis recusandae dolorem dolorem voluptate quo consequatur molestias quo sapiente voluptas praesentium quam quis sit natus dolorum cupiditate minima.", 954033015, 743, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "Bechtelar LLC", "Handmade interactive red" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Millie Leuschke", "minus", "https://picsum.photos/50/50/?image=882", "Id et asperiores nihil quia mollitia deserunt magni et blanditiis corrupti hic nihil similique est quis et temporibus facilis atque.", 745965062, 817, new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "Thompson, Kulas and Champlin", "connect Profound Bahrain" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sigurd O'Kon", "enim", "https://picsum.photos/50/50/?image=845", "Quis sint id eos distinctio ut soluta voluptate et omnis similique tempora quasi accusamus non quae consequuntur animi ut laudantium.", 860461749, 729, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), "Shields, Waters and MacGyver", "Outdoors Small Metal Pants lime" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Martine Kovacek", "excepturi", "https://picsum.photos/50/50/?image=94", "Rem blanditiis minus nisi quos vel nisi assumenda omnis quia commodi dolorem ut cupiditate nostrum voluptatibus aut recusandae pariatur laboriosam.", 485503555, 622, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), "Miller, Nikolaus and Hirthe", "markets Guam IB" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Harmony Robel", "ducimus", "https://picsum.photos/50/50/?image=697", "Vero itaque possimus voluptatum omnis atque eum alias qui ipsa provident et praesentium id qui quo sunt ea dolores aspernatur.", 105459484, 887, new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Local), "Klein - Funk", "Stream yellow Home Loan Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Piper Baumbach", "laboriosam", "https://picsum.photos/50/50/?image=700", "Dolor quos rerum sit totam et rerum explicabo tempora veniam quis ab quia voluptatem deserunt delectus est sed occaecati sunt.", 477850791, 335, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), "Emmerich - Hammes", "PNG strategize vortals" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hans Predovic", "sit", "https://picsum.photos/50/50/?image=322", "Laudantium delectus animi eligendi facilis quibusdam ullam aut voluptas quidem aut quisquam quos commodi hic praesentium non animi fugiat voluptatum.", 492746870, 859, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), "O'Kon, Predovic and Anderson", "Nevada green Buckinghamshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Olga Rippin", "perferendis", "https://picsum.photos/50/50/?image=996", "Temporibus voluptates aut nulla et voluptas est quod voluptatem rerum rerum veritatis dolores voluptatem voluptatibus culpa nam aperiam pariatur et.", 242317835, 130, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), "Murphy, Hagenes and Kulas", "Sleek Granite Cheese Direct back up" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Wendell Raynor", "placeat", "https://picsum.photos/50/50/?image=347", "Omnis officiis qui dicta doloremque sed rerum labore illum quas amet ab aperiam voluptates officia ratione saepe voluptatem aut officia.", 358299002, 946, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), "Bayer, Ebert and Labadie", "multi-byte Gabon Home Loan Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Milton Baumbach", "accusantium", "https://picsum.photos/50/50/?image=214", "Velit ipsa quos iusto in eos nobis corporis voluptatem saepe ut distinctio omnis dolore asperiores velit quod fugiat rerum quisquam.", 570900779, 108, new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), "Stokes - Prohaska", "cyan Program panel" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Davin Welch", "laboriosam", "https://picsum.photos/50/50/?image=722", "Aliquam accusantium impedit enim ut incidunt qui sapiente omnis laborum deleniti aut excepturi soluta impedit consequatur temporibus perferendis quia suscipit.", 125676796, 911, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), "MacGyver LLC", "Borders focus group digital" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jarrett Bogan", "at", "https://picsum.photos/50/50/?image=177", "Reiciendis dignissimos ea omnis dolores dignissimos aut dignissimos quia necessitatibus fugiat et qui et cum est ex consectetur magnam non.", 171210723, 928, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), "Nikolaus - Braun", "reinvent distributed compress" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Scot Hills", "corrupti", "https://picsum.photos/50/50/?image=769", "Atque ea dicta et sit nesciunt quo ut minus perspiciatis beatae optio molestiae aut aut deserunt sed accusantium architecto qui.", 263316833, 932, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Veum - Hoeger", "quantify Ergonomic Soft Sausages Sri Lanka" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Carey Monahan", "vero", "https://picsum.photos/50/50/?image=196", "Aliquid commodi enim consequatur et quis sit doloribus ipsum maxime perspiciatis doloribus asperiores adipisci omnis maxime et quam temporibus quia.", 923853746, 632, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), "Cassin - McGlynn", "COM Grove Michigan" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kaleb Gulgowski", "molestiae", "https://picsum.photos/50/50/?image=523", "Sed qui ea et fuga ea quia sit quam quaerat reiciendis libero ipsam vitae repudiandae itaque veritatis laboriosam fugiat voluptates.", 218591830, 861, new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), "Stoltenberg - Kris", "Representative International Checking Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Marietta Friesen", "recusandae", "https://picsum.photos/50/50/?image=977", "Exercitationem dicta laudantium suscipit dolores in cum alias quas et voluptas perferendis aliquid fugit delectus repellendus nihil cum dolorem vero.", 130081666, 412, new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), "Schamberger - Wunsch", "customer loyalty Open-source withdrawal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kennith Roob", "vero", "https://picsum.photos/50/50/?image=420", "Incidunt quia nisi magni qui quasi maxime occaecati qui eos id et nesciunt magnam nam ratione dolorem nam eos reprehenderit.", 954552687, 605, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), "Hoppe Inc", "Practical mindshare Naira" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Myron Cormier", "iste", "https://picsum.photos/50/50/?image=113", "Natus est commodi occaecati reiciendis exercitationem aut quasi ex repellat sed et dolore et fugit et qui architecto dolores voluptas.", 671644475, 723, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "Hintz, Strosin and Armstrong", "generating Algeria compress" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kaylah Prohaska", "labore", "https://picsum.photos/50/50/?image=91", "Voluptatibus illum atque saepe voluptatem dicta labore exercitationem aut repudiandae nisi aut et asperiores totam sit consequatur enim qui non.", 159376873, 71, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "Hettinger - Kuvalis", "El Salvador Colon Profound calculate" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Brionna Miller", "sit", "https://picsum.photos/50/50/?image=1076", "Vel et ad pariatur voluptas possimus sed commodi itaque ullam sed eos ratione cumque quibusdam sint et consequatur quis quia.", 462412335, 533, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "Kertzmann Inc", "markets Incredible Rubber Cheese Keys" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Orval Hansen", "omnis", "https://picsum.photos/50/50/?image=871", "At eligendi voluptatem autem quae illum omnis aut iusto officia odio eaque commodi rerum voluptates dolor provident aspernatur dolores ut.", 233179769, 982, new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), "Rippin, Keebler and Abbott", "Open-architected maroon Generic Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Cheyanne Kreiger", "consequatur", "https://picsum.photos/50/50/?image=867", "Suscipit quia voluptatem error molestiae expedita sed est exercitationem odit quis repudiandae aperiam incidunt voluptate harum neque ullam laudantium dolor.", 616884774, 810, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "Carroll Group", "Fort Licensed Fresh Shirt Books, Games & Movies" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Furman Funk", "cumque", "https://picsum.photos/50/50/?image=181", "Explicabo nemo consequuntur qui placeat eum reiciendis asperiores totam veniam totam illum numquam dolorum odio quaerat voluptatem cupiditate rerum hic.", 790108337, 110, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), "Williamson Inc", "Sleek Steel Pizza New York Turkish Lira" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Nikko Terry", "cupiditate", "https://picsum.photos/50/50/?image=673", "Deleniti magnam quidem dolorem facere aperiam ut et labore aut occaecati eos consequatur rerum fugit et omnis fugiat officia sit.", 480932624, 148, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "Kiehn, Mayer and Kerluke", "Team-oriented paradigms payment" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Fred Will", "et", "https://picsum.photos/50/50/?image=981", "Vel repudiandae est soluta earum hic fugiat voluptatibus amet sunt dolores beatae aliquam tempora nihil minus ut quibusdam et et.", 438594225, 766, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "Moen Group", "matrix Hollow reintermediate" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Aisha Monahan", "repudiandae", "https://picsum.photos/50/50/?image=452", "Facere ratione ab maiores vel mollitia est omnis ullam qui exercitationem voluptatem aut praesentium non officiis ut asperiores doloribus sequi.", 131055294, 471, new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), "Hauck - Parisian", "Connecticut Legacy invoice" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Abdul Howe", "sit", "https://picsum.photos/50/50/?image=995", "Et sint ipsum non quisquam nam occaecati laborum autem eum maiores magni cumque voluptatem dolorem est dolorem voluptates natus hic.", 660712590, 458, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "Spencer, Rau and Brakus", "cyan visualize Licensed Steel Towels" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ellen Heller", "nulla", "https://picsum.photos/50/50/?image=831", "Et quia autem qui soluta odit facere exercitationem eveniet quod labore nesciunt officiis voluptatem nesciunt reiciendis nihil delectus eos veniam.", 301020195, 997, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Erdman - Hermann", "ubiquitous transitional Diverse" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lizeth Howe", "illo", "https://picsum.photos/50/50/?image=27", "Nihil quam voluptatum atque mollitia sit expedita aut ipsa dicta totam mollitia nihil nihil qui qui ipsum non at vel.", 629546110, 639, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), "Olson, Hills and Hilpert", "Rubber success proactive" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hazel Torphy", "natus", "https://picsum.photos/50/50/?image=498", "Eligendi sequi nesciunt ut magni est nisi quae id distinctio voluptas sint repellat laboriosam sint qui non id architecto sapiente.", 331172472, 948, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Becker - Armstrong", "override Avon Russian Federation" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sienna Turcotte", "officia", "https://picsum.photos/50/50/?image=1055", "Est id ipsa nam et non qui molestiae eius molestias dolorem qui aut qui veniam nihil occaecati reiciendis eum ullam.", 498257138, 461, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), "Turcotte - DuBuque", "lavender Customer Cape" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Annetta Kertzmann", "et", "https://picsum.photos/50/50/?image=934", "Ex quasi et enim dolor id et sint ratione commodi laudantium recusandae harum recusandae ipsam est ut dolores magnam inventore.", 318703531, 635, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "Bartoletti, Kihn and Wyman", "iterate Facilitator Avon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Cedrick Hammes", "culpa", "https://picsum.photos/50/50/?image=14", "Delectus aut sint temporibus minus incidunt aut nihil possimus hic architecto molestiae vel ut non nobis repellat eius sint velit.", 677800108, 442, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Local), "Cole, Koss and Lynch", "synthesizing Fantastic Practical Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jo Roberts", "illum", "https://picsum.photos/50/50/?image=135", "Eum labore est ipsam provident ipsam non animi quod et eum itaque autem dolor necessitatibus occaecati velit voluptate nobis ea.", 873467905, 250, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Vandervort - Lebsack", "Administrator reintermediate Communications" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Zachariah Ratke", "qui", "https://picsum.photos/50/50/?image=920", "Rerum enim illo voluptatum excepturi et vel tempore laudantium quae reprehenderit eos voluptatum nulla dolore laborum sint cum quis ut.", 986926352, 175, new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), "Gorczany, Fay and Greenholt", "Metal Glens Investment Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alisha Streich", "aperiam", "https://picsum.photos/50/50/?image=128", "Perferendis cumque et quia est in veritatis ipsum unde molestiae quod fuga rerum molestias consequatur alias magnam corporis molestias et.", 354474738, 826, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), "O'Kon Group", "Home Loan Account auxiliary bleeding-edge" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Verona Murazik", "recusandae", "https://picsum.photos/50/50/?image=978", "A officiis beatae ex beatae nemo aperiam et est natus dicta sequi cum molestiae aut iusto sint consequuntur delectus dolores.", 478816774, 322, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "Witting LLC", "Forge Regional protocol" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Garrett Kutch", "fugit", "https://picsum.photos/50/50/?image=369", "Et ipsa maxime occaecati delectus et non ducimus eveniet quia non sit est iure aut qui et consectetur exercitationem exercitationem.", 568617916, 447, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "Wyman, Halvorson and Spencer", "monitor neural Clothing & Computers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kavon Breitenberg", "est", "https://picsum.photos/50/50/?image=194", "Autem modi laboriosam vero ab doloremque dolores deserunt dolorem expedita corrupti ducimus qui velit sed culpa nobis et temporibus repudiandae.", 666727458, 367, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Hilll - Kris", "leading edge Cambridgeshire whiteboard" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "AUTHOR", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jon Klocko", "https://picsum.photos/50/50/?image=1081", "Soluta et illo id accusamus qui quasi vel aut non voluptas debitis et blanditiis veritatis sit aut illum deserunt ducimus.", 510072736, 264, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), "Heidenreich - Murazik", "invoice Glens Web" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hildegard Schulist", "fugit", "https://picsum.photos/50/50/?image=936", "Id praesentium ut consequatur est quia exercitationem et animi corporis placeat dicta autem perspiciatis ipsa quia perferendis iusto dolorem enim.", 936872937, 871, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Local), "Thiel, Marquardt and Keeling", "payment Facilitator Michigan" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kenya Macejkovic", "quam", "https://picsum.photos/50/50/?image=1005", "Eos qui qui ad magni nihil aliquam odit provident eum tenetur sunt et quo voluptate ut explicabo consequatur amet non.", 218116785, 189, new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), "Schamberger Group", "Multi-channelled holistic mint green" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kelvin DuBuque", "iste", "https://picsum.photos/50/50/?image=46", "Sunt laboriosam nihil rerum voluptas ipsam voluptas reiciendis voluptas assumenda eligendi reiciendis dolorem commodi est harum magnam quae rerum ut.", 294157038, 649, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), "Roberts - Welch", "Avon transmit Granite" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Daija Cremin", "dolorum", "https://picsum.photos/50/50/?image=150", "Aperiam velit provident vero ipsa dolor ut veniam ut consequatur nesciunt qui id molestiae perferendis et omnis odit sunt laboriosam.", 153150332, 392, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), "Rosenbaum - Lynch", "Checking Account Island Montana" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Myrna Feest", "repellat", "https://picsum.photos/50/50/?image=817", "Illo maiores eos libero sit dignissimos velit dolorum et veniam consequuntur reiciendis quia aut aperiam sit commodi dolor minus natus.", 200717011, 650, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Conn - Johnson", "cohesive Unbranded Wooden Shirt deposit" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Melany Gerhold", "dolorem", "https://picsum.photos/50/50/?image=247", "Reiciendis sit deleniti aut cupiditate laboriosam qui voluptas explicabo accusamus illo repellat delectus sapiente excepturi dolorum adipisci impedit sunt est.", 912798503, 206, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "Bauch - Thiel", "Credit Card Account withdrawal enhance" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rogelio Parker", "ducimus", "https://picsum.photos/50/50/?image=111", "Commodi illo magnam aliquam voluptatibus illum a odit sed quos quia pariatur suscipit ad cupiditate assumenda illum voluptatum ea ea.", 125339383, 391, new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), "Green, Carroll and Hettinger", "harness withdrawal IB" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Osbaldo Luettgen", "reiciendis", "https://picsum.photos/50/50/?image=454", "Veritatis vero sit quos harum molestiae repudiandae ut sit illo aliquid commodi et aut dolores ratione enim consequatur dolore nesciunt.", 235964837, 264, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), "Weber, Fritsch and Shields", "Personal Loan Account workforce invoice" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rickey Kuvalis", "aspernatur", "https://picsum.photos/50/50/?image=618", "Est iusto suscipit quas incidunt sit numquam voluptate earum reiciendis officia non quia et labore odit beatae rerum blanditiis quia.", 357993529, 298, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "Smith LLC", "payment Upgradable Streamlined" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rosendo Leuschke", "fugit", "https://picsum.photos/50/50/?image=339", "Dolore et et nostrum sit aliquam aut aliquid excepturi quam repellat dolore sed consequatur quod officia commodi consequatur nihil animi.", 490055087, 80, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), "Zieme Inc", "e-markets Bolivar Fuerte Enterprise-wide" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Daniela Zieme", "aut", "https://picsum.photos/50/50/?image=932", "Consectetur dolores sed fuga maiores est sed vel unde quam expedita non aut molestias doloremque deserunt et asperiores autem omnis.", 358402302, 951, new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), "Nienow, Cremin and Moore", "withdrawal firewall Eritrea" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Julius Leannon", "sed", "https://picsum.photos/50/50/?image=54", "Expedita ea ut et provident error ipsa porro dolorem omnis eveniet voluptate et et tempore placeat sit libero ut qui.", 813272652, 911, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Hand LLC", "Developer deposit New York" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Brad Fahey", "rem", "https://picsum.photos/50/50/?image=247", "Hic qui quidem quia quis maxime quo eaque nobis natus eaque exercitationem eos sit delectus incidunt assumenda repudiandae qui itaque.", 666377396, 63, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "Tillman - Stroman", "Cotton Iowa copy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Elsa Stamm", "distinctio", "https://picsum.photos/50/50/?image=902", "Iste reprehenderit quia autem qui illo reiciendis fuga et voluptatibus labore vitae quia quo id nobis iste error sed deleniti.", 837919911, 524, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), "O'Conner LLC", "Mission Macedonia world-class" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Molly Grady", "dolores", "https://picsum.photos/50/50/?image=445", "Omnis quae non adipisci molestias doloribus provident blanditiis quisquam distinctio eius distinctio velit deleniti eligendi necessitatibus eius nulla totam voluptatem.", 815039463, 204, new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), "Rosenbaum LLC", "green teal Intelligent Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Graciela Heaney", "iure", "https://picsum.photos/50/50/?image=814", "Sed quia quae id eaque aspernatur officiis odit est itaque nesciunt corporis fugiat cumque recusandae laudantium sit cumque expedita expedita.", 676121552, 315, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), "Kihn - Stanton", "bus Street navigating" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Vita Murphy", "cumque", "https://picsum.photos/50/50/?image=39", "Sed est distinctio et modi soluta enim doloribus est adipisci quae quia id asperiores voluptatum odit incidunt placeat sint dolorem.", 674608217, 500, new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), "Williamson - Hackett", "ADP lime tangible" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Amely Bergnaum", "repellendus", "https://picsum.photos/50/50/?image=579", "Est facere omnis a inventore non non in dolores aspernatur ab consequuntur sed eligendi sunt dolores vitae odit animi et.", 735914817, 285, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), "Wilderman, Abernathy and Howell", "Arizona Handmade lavender" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Delta Hauck", "dolorem", "https://picsum.photos/50/50/?image=106", "Similique qui quae nulla occaecati earum est mollitia magnam unde ut aut qui incidunt quas odit et doloremque sit incidunt.", 831566142, 254, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), "Stamm and Sons", "indigo local Algerian Dinar" });
        }
    }
}
