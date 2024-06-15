using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechnicalAssessmentRokov.Migrations
{
    /// <inheritdoc />
    public partial class ChangePhotoSize2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "AUTHOR", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Erik Wintheiser", "https://picsum.photos/100/100/?image=398", "Recusandae quia itaque similique est ex non dolorem unde et velit dolores distinctio dolorem sunt ex ut repellendus et atque.", 506497453, 618, new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), "Feil, O'Reilly and Ledner", "SSL technologies firewall" });

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
                columns: new[] { "AUTHOR", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Otho Bernier", "https://picsum.photos/100/100/?image=1042", "Asperiores eligendi sit deserunt et et qui animi aut voluptatem perspiciatis ducimus eum voluptas sint id dolorem eos sit unde.", 433307146, 422, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Local), "Stark Group", "Kansas Internal Awesome Granite Salad" });

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
                columns: new[] { "AUTHOR", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Camylle Hayes", "https://picsum.photos/100/100/?image=263", "Officia pariatur impedit itaque delectus dolor itaque nisi aliquam aspernatur et voluptates ut sed est id et fuga nam praesentium.", 722076819, 168, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Local), "Lueilwitz - Zulauf", "capacitor Rustic Steel Pizza Parks" });

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
                columns: new[] { "AUTHOR", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Drake Gutmann", "https://picsum.photos/100/100/?image=608", "Qui quidem est aut quia non sed esse modi enim et aut est hic quis odio aspernatur sit temporibus rem.", 649204216, 818, new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Local), "Stiedemann - Dickinson", "bandwidth Generic Plastic Shirt deposit" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Trey Hodkiewicz", "alias", "https://picsum.photos/200/200/?image=282", "Iste veniam perferendis consequuntur odio autem asperiores et harum maiores nihil voluptas libero consequatur exercitationem optio id ipsum fugit exercitationem.", 508865799, 191, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "Herman, Bergnaum and Mills", "Beauty Bedfordshire Berkshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Russ Predovic", "a", "https://picsum.photos/200/200/?image=32", "Reprehenderit aut omnis et quia labore velit nulla maxime deserunt similique omnis non cumque et consequatur corrupti fugiat et minus.", 256341433, 651, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Local), "Koss LLC", "Savings Account maroon Pre-emptive" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Phoebe Ziemann", "est", "https://picsum.photos/200/200/?image=401", "Itaque qui eligendi delectus corrupti laborum amet sequi nihil quaerat corporis est sed repudiandae quia in illo provident aperiam voluptas.", 261738518, 529, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), "Dietrich, Gerhold and Bartell", "Generic payment Versatile" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Stephen Gusikowski", "hic", "https://picsum.photos/200/200/?image=893", "Optio esse velit maiores rerum enim dolor quam veniam aut maxime et recusandae veniam mollitia rerum consequatur est voluptas commodi.", 829233773, 876, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "Farrell - McKenzie", "radical silver Tasty" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kellen Bashirian", "rerum", "https://picsum.photos/200/200/?image=81", "Pariatur provident libero corporis illum nihil perferendis porro necessitatibus animi aliquid enim et ullam qui tempora quo dolor pariatur eos.", 514717234, 474, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Volkman Inc", "tan Optional networks" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Elizabeth Mohr", "fugit", "https://picsum.photos/200/200/?image=796", "Quia magni autem voluptatum quia voluptatem odit soluta voluptatibus et quia iure adipisci nulla est rerum voluptatem et ex incidunt.", 708622471, 350, new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), "Wisozk - Christiansen", "Industrial, Automotive & Garden De-engineered Street" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Cortney Von", "non", "https://picsum.photos/200/200/?image=917", "Incidunt temporibus dignissimos eveniet exercitationem modi et nobis perspiciatis voluptas id non dolor maxime dignissimos vel placeat consequatur sint doloribus.", 733408721, 549, new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), "Lueilwitz - Howe", "Electronics, Kids & Kids transition structure" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Tomasa Schultz", "ipsum", "https://picsum.photos/200/200/?image=904", "Quia voluptas quos et eum minus fuga labore velit excepturi ipsam numquam harum et et eos vitae voluptatem et non.", 582066170, 979, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), "Schneider, Gleason and Hessel", "Synergistic Money Market Account South Georgia and the South Sandwich Islands" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Eva Emard", "eos", "https://picsum.photos/200/200/?image=132", "Sapiente nobis corrupti qui reiciendis ut et iure natus doloremque error aut quia qui earum quos sed modi aut molestiae.", 305868745, 260, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), "Frami - Wehner", "Pennsylvania infomediaries Intranet" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kaitlin Beatty", "aperiam", "https://picsum.photos/200/200/?image=284", "Illo veritatis dignissimos dolorem molestiae quasi animi qui necessitatibus dolor quia vero iusto consectetur nihil minima aut fugit error optio.", 270502582, 974, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), "Renner, Pouros and Rempel", "Personal Loan Account Costa Rica Marketing" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Urban Rohan", "sunt", "https://picsum.photos/200/200/?image=554", "Rem vitae at et nulla eum sint ratione dolorem omnis ut officia quia inventore et possimus consequatur eum explicabo perspiciatis.", 885436844, 303, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "Kessler Inc", "throughput THX wireless" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AUTHOR", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kamron Effertz", "https://picsum.photos/200/200/?image=899", "Sequi libero voluptates beatae quidem velit doloremque dolorem id eius veritatis placeat voluptas rerum adipisci quod eum ea eligendi rem.", 577145535, 154, new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), "Labadie LLC", "Unbranded Fresh Ball Balanced Unbranded Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hayley Jaskolski", "ipsa", "https://picsum.photos/200/200/?image=818", "Accusamus rerum aut esse dolor veritatis nam reprehenderit excepturi et consectetur repellat et labore adipisci hic ipsum dolores asperiores error.", 909064195, 82, new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), "Weber Group", "Branding Baht Shoes, Shoes & Automotive" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Albina Konopelski", "maxime", "https://picsum.photos/200/200/?image=129", "Nam vitae similique laborum deserunt commodi veniam provident rerum id officiis ex fugit rerum mollitia est sed amet eius quis.", 820732794, 104, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "Abshire LLC", "SMS Manors invoice" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Clint Schuppe", "aut", "https://picsum.photos/200/200/?image=883", "Aspernatur perferendis et deleniti eum adipisci aperiam harum laudantium veniam ipsam sequi dolorem ut dolor aut voluptas occaecati blanditiis sint.", 482296243, 828, new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), "Auer, Schiller and McCullough", "deliverables e-markets pixel" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Gunnar Donnelly", "ipsa", "https://picsum.photos/200/200/?image=384", "Praesentium illo sequi voluptatum explicabo eligendi magni expedita odio sequi quis minima sunt quidem labore qui dicta ratione possimus sint.", 896983745, 947, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Johnson - Zulauf", "Chief Nepalese Rupee real-time" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Watson Steuber", "vero", "https://picsum.photos/200/200/?image=132", "Repellat vel rerum sit maxime aliquam ipsam et ipsa porro vel repellat consequatur id quisquam et culpa dolores autem voluptatum.", 823359737, 739, new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "Powlowski - Altenwerth", "Yen Refined Cotton Pants violet" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Reed Price", "numquam", "https://picsum.photos/200/200/?image=709", "Omnis laudantium vero accusamus vero est voluptas fugit optio recusandae sint tempora id voluptatem suscipit dolor in quibusdam numquam laborum.", 202266254, 770, new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "Heaney - Bauch", "Concrete harness USB" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alexandrea Mante", "rerum", "https://picsum.photos/200/200/?image=576", "Aperiam delectus error dolorem voluptatum vero harum et autem dignissimos in fugit sed repellat sunt ad ut neque quas harum.", 297579233, 179, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), "Watsica - Bechtelar", "productize Mayotte action-items" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Verlie Emmerich", "veritatis", "https://picsum.photos/200/200/?image=813", "Delectus illum repudiandae qui adipisci sunt enim harum corrupti sit distinctio aperiam et eum suscipit dolores cumque est similique odio.", 308683786, 187, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), "Cruickshank, Keebler and Murray", "Assistant Garden, Kids & Garden Gorgeous Fresh Chair" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Noble Bartoletti", "praesentium", "https://picsum.photos/200/200/?image=996", "Quo nisi repellendus dolores illo quos non exercitationem ex nostrum ipsum sed exercitationem quia et eum aut quos non qui.", 289486665, 302, new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), "Lindgren, Lang and Kihn", "Bedfordshire Rapids Pennsylvania" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Darius Rodriguez", "distinctio", "https://picsum.photos/200/200/?image=1061", "Fuga enim quia rem id libero sunt assumenda perspiciatis quos aspernatur unde ipsa iste possimus dolor ut quis aut nam.", 129163365, 940, new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), "Reichel LLC", "parsing invoice Liberian Dollar" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Carmen O'Keefe", "id", "https://picsum.photos/200/200/?image=624", "Numquam autem labore est ea libero distinctio nemo a similique doloribus eos odit fugit deserunt dolorem eum eius consequatur dolores.", 648317560, 590, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), "Koch - Witting", "COM Quality-focused Handcrafted" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Delfina Mann", "amet", "https://picsum.photos/200/200/?image=821", "Non beatae consectetur eligendi enim illum aut totam et harum minima placeat quis voluptatem asperiores qui harum atque quisquam qui.", 600700451, 668, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "Bailey, Ondricka and Zemlak", "optical technologies open-source" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Chad Shields", "porro", "https://picsum.photos/200/200/?image=640", "Ratione provident nisi totam possimus incidunt voluptatem adipisci odio aut est ut modi dolorem blanditiis nihil est ut illum distinctio.", 164810062, 646, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "Stracke - Gerhold", "Licensed deposit streamline" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jessyca Balistreri", "explicabo", "https://picsum.photos/200/200/?image=360", "Ut sunt quia voluptatum mollitia molestias provident sit quis aut ullam dolorum et vero culpa aut neque et officiis culpa.", 422480205, 744, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), "Renner Inc", "IB pink payment" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Paris Rutherford", "voluptates", "https://picsum.photos/200/200/?image=236", "Iure sint vel dolores similique voluptatem molestias natus officiis amet vel animi sed mollitia non dolorem alias sed sint est.", 826636101, 646, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), "Nolan - Turner", "Wyoming Accounts 4th generation" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Randi Bode", "atque", "https://picsum.photos/200/200/?image=181", "Laboriosam et est accusamus eum et quibusdam at et et qui blanditiis maxime aspernatur eaque porro enim dolorem nostrum porro.", 929976151, 638, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "O'Kon LLC", "cross-platform Vista utilisation" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Melany Pollich", "ut", "https://picsum.photos/200/200/?image=688", "Ipsa in sint vel totam neque soluta aperiam aut eligendi ad numquam laboriosam assumenda quidem enim nihil doloremque recusandae aut.", 951860692, 830, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), "Rosenbaum - Rohan", "evolve attitude-oriented PCI" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ibrahim Strosin", "iure", "https://picsum.photos/200/200/?image=485", "Vitae praesentium eaque qui qui hic a cupiditate blanditiis consequatur aut laborum et odit qui est nostrum a eveniet ea.", 776343701, 670, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), "Leuschke - Prosacco", "International copy Incredible Steel Chair" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sean Hilll", "sit", "https://picsum.photos/200/200/?image=499", "Minima possimus fugit odio qui ea expedita similique rerum consequuntur rerum sequi vel placeat quia iure ut ducimus id voluptatem.", 217871546, 685, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Local), "Parker Inc", "intuitive initiatives synergies" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rosalinda Barrows", "aperiam", "https://picsum.photos/200/200/?image=391", "Qui rerum hic consectetur ipsum consequatur porro eius libero iste quia aut tempora voluptatibus nemo nobis fugit quam praesentium aspernatur.", 527946305, 370, new DateTime(2023, 6, 21, 0, 0, 0, 0, DateTimeKind.Local), "Cassin, Schimmel and Erdman", "Investor bus payment" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kelsie Senger", "officia", "https://picsum.photos/200/200/?image=581", "Sequi blanditiis totam in est explicabo animi occaecati fugiat quis officiis provident eos aperiam aut iure molestias nostrum corrupti fugit.", 868405222, 841, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), "Gerlach, Metz and Glover", "Buckinghamshire Mountain SAS" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Delbert Schroeder", "quasi", "https://picsum.photos/200/200/?image=94", "Laborum quia dicta perspiciatis eos accusantium sit qui incidunt quasi beatae quos voluptate consequuntur inventore ipsum deserunt vero est dolorem.", 381891460, 971, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), "Bednar, Oberbrunner and Steuber", "Yuan Renminbi Human District" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Blair Padberg", "autem", "https://picsum.photos/200/200/?image=833", "Vero quos iure ex omnis laborum id commodi nihil sunt quod sint beatae eum soluta quo dolor rem saepe aspernatur.", 638374280, 630, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Local), "Lubowitz, Tremblay and Roberts", "Strategist orchid Small" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Makayla Gaylord", "distinctio", "https://picsum.photos/200/200/?image=57", "Reprehenderit eligendi a expedita ut numquam earum repellendus fugit ducimus rerum sunt quaerat quia vel vel et fugiat laborum temporibus.", 981305871, 91, new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "Hilpert - Carroll", "Tasty Plastic Bacon HDD open architecture" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kelley Streich", "ex", "https://picsum.photos/200/200/?image=632", "Voluptate aut voluptas rerum et sit voluptatem consequatur soluta ab officia deleniti est debitis non perspiciatis quaerat tempora nemo quam.", 739181493, 432, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), "Barrows and Sons", "Belize invoice Ergonomic Cotton Computer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Magnus Bartell", "sed", "https://picsum.photos/200/200/?image=460", "Ea cum qui est consequatur autem deserunt debitis eos dolores soluta et sit ut animi quod necessitatibus et dolores libero.", 581861324, 485, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Raynor and Sons", "compressing recontextualize Senior" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lucius Pfeffer", "assumenda", "https://picsum.photos/200/200/?image=402", "Ut tenetur qui porro est ut quas exercitationem eum ut qui ut nisi sed dolorum alias quibusdam distinctio sint minus.", 846566340, 329, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), "Lindgren and Sons", "payment Dynamic Executive" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Renee Koepp", "minima", "https://picsum.photos/200/200/?image=595", "Voluptatibus provident iure sed dicta quae debitis vel qui illo id id nihil voluptatibus in quis modi dolorum qui fugiat.", 870705002, 897, new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "McDermott and Sons", "auxiliary Synchronised Money Market Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kyla Crooks", "ipsa", "https://picsum.photos/200/200/?image=268", "Rem molestiae porro architecto nihil cupiditate esse rerum id provident et qui molestias repellat sunt et quia temporibus tempora laboriosam.", 483586642, 447, new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), "Okuneva - Stoltenberg", "Pass Hong Kong Dollar intangible" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "AUTHOR", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Meredith Spencer", "https://picsum.photos/200/200/?image=748", "Sunt perferendis consequatur velit est maxime velit voluptatibus provident distinctio et eum velit ut nisi sed dolores reprehenderit quisquam reprehenderit.", 988124590, 594, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Local), "Powlowski Inc", "Ergonomic Fresh Shirt Steel New Caledonia" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Randall Mitchell", "pariatur", "https://picsum.photos/200/200/?image=1018", "In soluta ut animi et asperiores tenetur dolorem ea harum aut repellat quisquam voluptates omnis eveniet occaecati fuga eveniet molestiae.", 974295895, 89, new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), "Kihn, Wiegand and Ritchie", "Tanzanian Shilling multi-tasking Garden" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Eloise Volkman", "non", "https://picsum.photos/200/200/?image=993", "Ut officia amet repellat optio aut odio et est odit quo quibusdam qui corrupti rerum nihil placeat amet quas at.", 147661465, 318, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "Kiehn - Lehner", "Applications Green Tactics" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Katarina Prohaska", "veritatis", "https://picsum.photos/200/200/?image=1030", "Alias consequatur veniam nesciunt voluptatem placeat architecto consequatur in consequatur exercitationem modi cupiditate non est impedit voluptatem repellendus facilis illum.", 409587215, 971, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "Feest, Conroy and Schroeder", "Cape transform hierarchy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Christy Quigley", "ipsam", "https://picsum.photos/200/200/?image=737", "Laborum occaecati asperiores amet est harum dolorem fugit perferendis cupiditate mollitia perferendis et harum id voluptatem ratione vel soluta aliquid.", 202551028, 367, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), "Abshire, Hansen and McGlynn", "quantifying revolutionize mobile" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Amir Schmeler", "eaque", "https://picsum.photos/200/200/?image=408", "In molestiae qui accusantium tenetur magni enim in illo eius sit quasi et quam et aut vel similique eum dolor.", 225940680, 361, new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "Satterfield Group", "parsing Implemented Refined Fresh Chair" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Judge Moen", "autem", "https://picsum.photos/200/200/?image=1009", "Minus cum beatae libero et libero itaque dolor voluptatem reiciendis commodi pariatur sunt amet earum itaque nihil sint voluptatem cum.", 589747994, 733, new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "Rogahn - Funk", "Barbados Producer Soft" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Karlie Bergnaum", "quia", "https://picsum.photos/200/200/?image=491", "Nam dolor autem consequuntur aspernatur consequatur amet possimus quo in impedit et fugiat natus vero occaecati tempora quia aliquam reiciendis.", 460773821, 314, new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), "Predovic - Bahringer", "mint green invoice Dynamic" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Bernadine Farrell", "dignissimos", "https://picsum.photos/200/200/?image=423", "Est similique pariatur reiciendis eos temporibus molestiae minus odit quam nostrum placeat vero dolor repellendus ut ipsam rerum voluptas ratione.", 340001038, 958, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), "Towne - Rowe", "Electronics Concrete Down-sized" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lee Waters", "sunt", "https://picsum.photos/200/200/?image=406", "Mollitia aut odit inventore modi deserunt nihil omnis laudantium quisquam sit quis quibusdam aut quis aut vero voluptatum possimus temporibus.", 739275599, 335, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Barrows, Lang and Mann", "cultivate Incredible Refined Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Vernie Kozey", "sed", "https://picsum.photos/200/200/?image=441", "Aut doloribus nobis fugit non nostrum voluptatum voluptas et repellat officiis dolorem asperiores quos sapiente aliquid minus in exercitationem officia.", 842271091, 624, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), "Stiedemann, Aufderhar and Fahey", "generating Yemen Steel" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "AUTHOR", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Maya Klein", "https://picsum.photos/200/200/?image=8", "Perferendis qui cumque animi dolor hic quidem officia quam vel aut iusto sunt qui eos aut rem perspiciatis totam qui.", 399116188, 465, new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), "Moore, Jast and Pfannerstill", "Books & Baby Home, Automotive & Books Minnesota" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rodolfo Greenfelder", "suscipit", "https://picsum.photos/200/200/?image=779", "Temporibus modi ea sunt mollitia libero placeat distinctio suscipit itaque et ut nulla sed eum laudantium illo dolores autem labore.", 558665894, 606, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), "Runolfsson, Pacocha and Kirlin", "Savings Account Berkshire e-markets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Flavio Shanahan", "molestias", "https://picsum.photos/200/200/?image=90", "Enim autem omnis et architecto ratione ex velit sequi rerum quis ut illo blanditiis vitae ut magni tempore voluptate molestias.", 528497958, 570, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), "Nicolas - Fisher", "protocol Berkshire Liaison" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mervin Wisozk", "quam", "https://picsum.photos/200/200/?image=646", "Rerum quidem molestias asperiores ut officiis ipsa labore porro nam et expedita odit exercitationem rerum ipsa quos fuga cumque vel.", 165087133, 814, new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Medhurst Group", "Tajikistan Borders B2B" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Wilmer Dietrich", "fugiat", "https://picsum.photos/200/200/?image=180", "Voluptatem eos pariatur consequatur consequatur maiores mollitia facere at est enim voluptatem dolor voluptatem eligendi praesentium accusamus aut ut molestias.", 538223935, 947, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), "Kessler, Cormier and Murray", "transmit Practical Wooden Fish incentivize" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rupert Rodriguez", "qui", "https://picsum.photos/200/200/?image=318", "Aliquam quos ut voluptas nemo odit cupiditate at eaque fuga dolorem quisquam voluptatibus nihil in ipsum fuga voluptatibus dolor occaecati.", 801215596, 268, new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "Ritchie Group", "pixel SQL transmitter" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "AUTHOR", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Margaretta Goldner", "https://picsum.photos/200/200/?image=687", "Asperiores suscipit et et cum dolores veniam dolores sed ipsum aut quod dolor dicta ut impedit asperiores exercitationem quia voluptatem.", 994302834, 985, new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), "Pfeffer - West", "Incredible Concrete Car Investor Fresh" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Blanca Sauer", "quo", "https://picsum.photos/200/200/?image=272", "Repellendus vel iste labore labore consectetur aliquam laudantium voluptas eum provident blanditiis eos tempora eum voluptatem omnis asperiores dicta assumenda.", 652747530, 803, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), "Miller and Sons", "Crossing capacitor Steel" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Pierre Berge", "ut", "https://picsum.photos/200/200/?image=151", "Dignissimos nostrum nam repellat est sed modi ipsam ut veniam numquam et veniam asperiores nostrum iure eum sint est deserunt.", 999566593, 179, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Local), "Kassulke Inc", "Plastic Curve Rustic Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Thea Armstrong", "accusamus", "https://picsum.photos/200/200/?image=259", "Unde consequatur officia suscipit nemo blanditiis quas tenetur et tempora eum aliquid veniam distinctio voluptatem sit itaque quis adipisci quasi.", 316574154, 854, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), "Anderson - Beer", "Avon Iowa salmon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Janae Cronin", "unde", "https://picsum.photos/200/200/?image=192", "Ab quia pariatur id consequuntur tenetur veritatis a impedit facilis reprehenderit quasi esse animi soluta sit et sequi fugit deleniti.", 114320264, 742, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Local), "Bayer - Bernhard", "Borders Automotive & Toys recontextualize" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dana Hamill", "est", "https://picsum.photos/200/200/?image=54", "Rerum repellat dolor ipsum quo aut est quae doloribus facilis quam voluptates eum esse iste libero vero rem occaecati sed.", 921775473, 637, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "Sawayn, Nitzsche and Ferry", "multi-tasking Incredible Metal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Houston Rowe", "aut", "https://picsum.photos/200/200/?image=726", "Deleniti minima adipisci et consequuntur sit cupiditate adipisci porro rerum provident unde cum consectetur voluptas quo nihil quis rerum eligendi.", 379580531, 985, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), "Feil and Sons", "mint green enterprise Liaison" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Keon Rempel", "nam", "https://picsum.photos/200/200/?image=235", "Eius consequatur qui ea nihil optio magni eos et et ad dolor culpa magni necessitatibus exercitationem quis dolorem est voluptatibus.", 514666763, 720, new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Local), "Greenholt Inc", "Meadows Concrete Baby & Tools" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Judge Blick", "hic", "https://picsum.photos/200/200/?image=252", "Molestias possimus nemo consequuntur nihil quos qui quam at natus voluptate occaecati modi incidunt vel iusto ad velit et officiis.", 537775681, 264, new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), "Ankunding, Graham and Goodwin", "implement Berkshire UIC-Franc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ronny Kutch", "sint", "https://picsum.photos/200/200/?image=257", "Quia officia quas et qui consectetur voluptas iure dignissimos sit sunt ea tenetur maiores est vero praesentium incidunt quam quam.", 859059867, 806, new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), "Langosh, Schoen and Goldner", "New Hampshire matrix US Dollar" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Stefanie Watsica", "perspiciatis", "https://picsum.photos/200/200/?image=609", "Maiores consequatur possimus magni nobis voluptatibus eos et quae et nam veritatis perferendis ratione quam commodi et quas quidem quia.", 230339710, 831, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), "Roberts, Harber and Gottlieb", "silver Steel functionalities" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ofelia Crooks", "ea", "https://picsum.photos/200/200/?image=193", "Cumque quia ipsum officia porro quo accusamus ut libero eveniet inventore minima iste vel rerum voluptates aliquid sint voluptatem quasi.", 269739392, 228, new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), "Altenwerth and Sons", "Borders cross-platform grid-enabled" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Darian Kautzer", "et", "https://picsum.photos/200/200/?image=563", "Assumenda exercitationem libero nam quos harum dolore temporibus voluptates eius id velit commodi quos aut qui nobis ipsa ex aut.", 870711811, 272, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "Roob Group", "deposit New York e-markets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Arvid Yost", "sed", "https://picsum.photos/200/200/?image=712", "Architecto non dolor ratione repudiandae accusantium consectetur odio maxime quasi non aliquid optio est perferendis non voluptate vel deleniti alias.", 833444064, 921, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "Treutel, Reichel and Runte", "Implementation Bedfordshire Security" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dan Ziemann", "non", "https://picsum.photos/200/200/?image=186", "Corporis adipisci dolor autem illo consequatur est libero tempore quae ea aperiam repellendus natus fuga sed nisi totam sit accusamus.", 725618334, 822, new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "Ledner - Towne", "JSON Colorado tan" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Trenton Breitenberg", "qui", "https://picsum.photos/200/200/?image=719", "Commodi voluptas minima voluptas qui possimus praesentium maiores velit explicabo consectetur iure eum molestias alias officia vitae sunt soluta assumenda.", 956300300, 882, new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), "Bogan, Barrows and Kovacek", "Applications Rubber Vanuatu" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Khalid Hudson", "laboriosam", "https://picsum.photos/200/200/?image=530", "Consectetur vitae at nemo perferendis est fugiat ut ullam esse consequatur velit veritatis dignissimos eos quis aut quia deserunt delectus.", 823469796, 108, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), "Prohaska Group", "Human Island solid state" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kieran Wisozk", "dicta", "https://picsum.photos/200/200/?image=842", "Voluptate ratione ut maiores nostrum quae accusantium alias velit harum distinctio tempore et aut occaecati occaecati qui minima expedita necessitatibus.", 399431638, 888, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Pollich, Williamson and Wintheiser", "optimize Robust matrix" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Celestine Towne", "quod", "https://picsum.photos/200/200/?image=670", "Voluptatum sunt qui laudantium exercitationem magni et quo totam nam voluptatem ut deserunt possimus quia cumque est esse sed magni.", 959379396, 63, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "Reichert, Bednar and Feil", "Cambridgeshire Metal solid state" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Prince Kerluke", "tempore", "https://picsum.photos/200/200/?image=678", "Voluptates debitis velit veniam dolorem maxime impedit dolorem est hic autem ducimus animi iusto maiores in facere qui enim eum.", 151552339, 630, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Local), "Paucek Inc", "withdrawal niches Nebraska" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Eldora Bernier", "facilis", "https://picsum.photos/200/200/?image=939", "Aut perferendis in quas eius vitae odit nostrum voluptate libero ex consequatur suscipit deserunt quia a quae sunt voluptatem qui.", 785829087, 999, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), "Kub - Dach", "Club Music, Home & Jewelery virtual" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Grover Rogahn", "voluptatem", "https://picsum.photos/200/200/?image=1055", "Incidunt eos quis sed aut aut occaecati dolorum eum dolorum animi exercitationem beatae non in quia nostrum eligendi omnis doloremque.", 586676911, 491, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), "Krajcik, Daugherty and Abernathy", "deposit Visionary 6th generation" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Nora Collins", "tempore", "https://picsum.photos/200/200/?image=30", "Quaerat sit impedit architecto necessitatibus enim dolorem eveniet enim laudantium aut sint veniam illo corporis rerum autem ad est sed.", 386781202, 107, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), "Olson, Stoltenberg and Rice", "Unbranded Cotton Hat HTTP primary" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Joan Beatty", "molestiae", "https://picsum.photos/200/200/?image=725", "Aspernatur odit odio quia vitae quo in et eos quaerat debitis et praesentium neque ea non laboriosam quo modi laudantium.", 150895786, 50, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), "Feeney - Hoppe", "copying Valleys Soft" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Magnus Kris", "porro", "https://picsum.photos/200/200/?image=1074", "Delectus illo consequatur ut id asperiores debitis blanditiis perspiciatis repellendus sit dolorem aut minus perferendis qui est accusantium molestiae voluptatem.", 961468777, 676, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "Bergstrom, O'Hara and Koepp", "Buckinghamshire Wooden Tools & Kids" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Francesco Lubowitz", "quia", "https://picsum.photos/200/200/?image=666", "Cum voluptate iure fuga sit odit facilis provident dolorem illo qui sit placeat eum perspiciatis quas incidunt assumenda necessitatibus ab.", 765036865, 58, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Waters - Fisher", "e-markets orchestration Argentina" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jess Dibbert", "qui", "https://picsum.photos/200/200/?image=867", "Pariatur praesentium molestiae nobis sapiente soluta commodi iusto recusandae tempora aut culpa perferendis non quo eius iusto culpa id veritatis.", 186913752, 216, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "Okuneva, Mayer and Kuphal", "Personal Loan Account Bhutan Handcrafted Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jarret Haley", "consectetur", "https://picsum.photos/200/200/?image=257", "Debitis quia quia quia dolores ut aspernatur facere iste sint quam qui et vel explicabo accusamus quo illo doloremque fuga.", 859534603, 881, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), "Hartmann - McLaughlin", "Tunisian Dinar leverage Station" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mervin Shanahan", "exercitationem", "https://picsum.photos/200/200/?image=993", "Quia quaerat ut eveniet in non voluptatem aut consequatur ducimus aperiam ut expedita veniam non vitae voluptas voluptates id omnis.", 437039350, 602, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "Walsh, Altenwerth and Donnelly", "Sleek best-of-breed Soft" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Parker Runolfsdottir", "error", "https://picsum.photos/200/200/?image=1063", "Corrupti omnis perferendis ut praesentium facilis at dolorem est et aut dicta dolorum voluptas molestiae et quasi et aliquid aut.", 356883890, 258, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), "O'Keefe - Parker", "Web Leone Metal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Colby Labadie", "amet", "https://picsum.photos/200/200/?image=747", "Sit sit ratione velit est sint cum laudantium vel neque placeat debitis asperiores quas officiis maxime dolores tempore consectetur numquam.", 298562882, 991, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Local), "Pollich - O'Reilly", "systems Central Front-line" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Marco Thiel", "voluptatum", "https://picsum.photos/200/200/?image=615", "Magni voluptatem accusantium vel consequatur qui laudantium tempore error nihil et minima modi autem aut non dolore ut doloribus maiores.", 391556170, 803, new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), "Keeling, Howell and Bogisich", "Cambridgeshire Director navigating" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Priscilla Braun", "aliquam", "https://picsum.photos/200/200/?image=945", "Repellendus exercitationem ea consequuntur sunt est recusandae ratione vel quisquam eum repellat maxime iusto consequatur laboriosam debitis rerum et sit.", 105123996, 814, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), "Balistreri, McGlynn and Olson", "Cotton 24/365 Avon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Gerda Greenfelder", "et", "https://picsum.photos/200/200/?image=795", "Illum molestias veritatis corrupti ut quas repudiandae similique ut neque et nulla repellat quasi beatae doloribus sed velit voluptas velit.", 244003914, 788, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), "Beatty, Breitenberg and Jones", "Program Team-oriented cross-platform" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Bradford Gutmann", "ut", "https://picsum.photos/200/200/?image=944", "Magni sapiente et eum quibusdam veritatis omnis fuga suscipit ab quia voluptatem aut rerum sunt voluptatem eos veniam culpa id.", 198012963, 209, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "Brown, Gulgowski and Bradtke", "green violet Alabama" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Weldon Schamberger", "tempora", "https://picsum.photos/200/200/?image=829", "Consequuntur omnis deleniti porro molestiae repudiandae optio est tempore quia dolor quas repudiandae excepturi qui voluptatem ullam nihil error dolor.", 990241044, 579, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), "Connelly - Runte", "Hong Kong Dollar Strategist Prairie" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Serenity Moore", "non", "https://picsum.photos/200/200/?image=245", "Modi quis deleniti quia minus voluptatibus voluptatem adipisci laborum culpa est eum officia iste quod ad dignissimos fugit aut voluptatem.", 509464176, 109, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "Mraz LLC", "PCI Ville Beauty & Health" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hermina Lind", "velit", "https://picsum.photos/200/200/?image=310", "Voluptatibus id illo nam quia sed numquam adipisci ipsam ex dolor laboriosam officiis ipsum eligendi est voluptates placeat labore corporis.", 495377559, 450, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Vandervort Inc", "Massachusetts Grocery & Games navigate" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Yolanda Lindgren", "vel", "https://picsum.photos/200/200/?image=253", "Veritatis occaecati minima cumque quasi deserunt harum blanditiis ut molestiae inventore consequatur voluptas totam voluptatibus accusantium ad sed consequatur sed.", 149345817, 377, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "Hessel - Spinka", "Multi-layered transmitting optical" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Emma Gibson", "at", "https://picsum.photos/200/200/?image=85", "Quia est officiis numquam culpa similique eum dicta ducimus et voluptatem placeat qui est non numquam qui reiciendis blanditiis minus.", 823505420, 594, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "Rippin - Jones", "Computers & Electronics virtual Savings Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Marques Dietrich", "magni", "https://picsum.photos/200/200/?image=303", "Quod quae cumque facilis dolorem molestias distinctio repellat enim autem odit aut minus odio sed voluptatem ratione sint et distinctio.", 818172406, 992, new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "Jast - Walter", "Refined overriding copy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ellen Gleason", "est", "https://picsum.photos/200/200/?image=745", "Rem voluptates vel illo veritatis fuga exercitationem et fugit ratione consequatur magni totam ipsa officia possimus harum nemo dignissimos qui.", 533072907, 605, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), "Langworth - Prohaska", "architectures Brand Nuevo Sol" });
        }
    }
}
