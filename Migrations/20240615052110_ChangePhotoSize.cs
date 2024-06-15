using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechnicalAssessmentRokov.Migrations
{
    /// <inheritdoc />
    public partial class ChangePhotoSize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kamron Effertz", "maiores", "https://picsum.photos/200/200/?image=899", "Sequi libero voluptates beatae quidem velit doloremque dolorem id eius veritatis placeat voluptas rerum adipisci quod eum ea eligendi rem.", 577145535, 154, new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), "Labadie LLC", "Unbranded Fresh Ball Balanced Unbranded Soft Bacon" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLISHER", "TITLE" },
                values: new object[] { "Watson Steuber", "vero", "https://picsum.photos/200/200/?image=132", "Repellat vel rerum sit maxime aliquam ipsam et ipsa porro vel repellat consequatur id quisquam et culpa dolores autem voluptatum.", 823359737, 739, "Powlowski - Altenwerth", "Yen Refined Cotton Pants violet" });

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
                columns: new[] { "AUTHOR", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alexandrea Mante", "https://picsum.photos/200/200/?image=576", "Aperiam delectus error dolorem voluptatum vero harum et autem dignissimos in fugit sed repellat sunt ad ut neque quas harum.", 297579233, 179, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), "Watsica - Bechtelar", "productize Mayotte action-items" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Meredith Spencer", "qui", "https://picsum.photos/200/200/?image=748", "Sunt perferendis consequatur velit est maxime velit voluptatibus provident distinctio et eum velit ut nisi sed dolores reprehenderit quisquam reprehenderit.", 988124590, 594, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Local), "Powlowski Inc", "Ergonomic Fresh Shirt Steel New Caledonia" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Maya Klein", "et", "https://picsum.photos/200/200/?image=8", "Perferendis qui cumque animi dolor hic quidem officia quam vel aut iusto sunt qui eos aut rem perspiciatis totam qui.", 399116188, 465, new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), "Moore, Jast and Pfannerstill", "Books & Baby Home, Automotive & Books Minnesota" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hillard Wilderman", "aperiam", "https://picsum.photos/640/480/?image=6", "Ut vel officiis ab minus cupiditate assumenda nisi laboriosam ea facere veritatis consequatur error consequatur vel est voluptatem officia ullam.", 145961479, 746, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Local), "Leuschke - Dicki", "Burg help-desk transparent" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Janiya Bahringer", "nihil", "https://picsum.photos/640/480/?image=420", "Maiores nostrum officia aut officia consequatur dolores repellendus iusto quos autem numquam nihil nemo et sed occaecati est sint velit.", 314024296, 967, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), "Bartoletti - Cremin", "FTP syndicate paradigm" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Clair Bashirian", "atque", "https://picsum.photos/640/480/?image=34", "Qui qui ullam qui voluptate itaque ad aut soluta corrupti temporibus perferendis sunt corporis qui vitae corporis adipisci doloremque facere.", 631154752, 646, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), "Jacobi - Witting", "Rapid Meadows foreground" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Tremaine Macejkovic", "illo", "https://picsum.photos/640/480/?image=550", "Amet est qui sit earum et ipsa molestiae rem velit porro qui minus aspernatur earum numquam a vero aut veritatis.", 605596755, 152, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "Simonis - Waelchi", "Dominica Generic Granite Chicken navigate" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Myriam Farrell", "porro", "https://picsum.photos/640/480/?image=443", "Amet omnis dolores quia neque dolor similique et magni minima laboriosam fugit sunt nulla quos qui maxime placeat dolorum maxime.", 666586928, 664, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), "Pouros LLC", "optical open-source networks" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Brice Jerde", "corporis", "https://picsum.photos/640/480/?image=299", "Nihil sequi enim aut blanditiis accusantium sed sunt unde et voluptate in laudantium dolor repellendus voluptatem natus minus tempore sed.", 183606337, 999, new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), "Satterfield Group", "Computers & Shoes Practical Fresh Keyboard solution" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jessica Durgan", "laborum", "https://picsum.photos/640/480/?image=685", "Aut sapiente perspiciatis maiores minus explicabo porro et ut at ut cupiditate tempore expedita consequatur blanditiis hic dolorem sunt illo.", 682471026, 820, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "Dooley - McClure", "monitoring Shoes & Movies Practical Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lewis Strosin", "cupiditate", "https://picsum.photos/640/480/?image=120", "Rerum molestiae maxime voluptatum sit accusamus pariatur id qui possimus velit suscipit commodi maxime illo aut animi excepturi vel soluta.", 185456299, 928, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "Marks Inc", "leverage Automotive, Shoes & Books synthesize" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Gideon Huel", "reiciendis", "https://picsum.photos/640/480/?image=751", "Voluptas quo voluptas libero exercitationem quod dolores officia officiis dolorem iusto qui eveniet distinctio quidem veniam omnis aliquam aliquid autem.", 505225553, 267, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), "Schinner, Welch and Cummerata", "transmit transmit Licensed" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hattie Stark", "maiores", "https://picsum.photos/640/480/?image=193", "Quis ut est sapiente unde neque corporis laborum non excepturi enim maxime ratione molestiae atque minima necessitatibus dolores id fugit.", 742159421, 884, new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Local), "Smitham Group", "schemas Frozen cultivate" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Francesco Wiegand", "dolores", "https://picsum.photos/640/480/?image=1083", "Expedita rerum amet maiores non molestias nostrum est iste qui qui quia deleniti veritatis quas molestiae error hic sit ipsa.", 708842702, 316, new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "Denesik Inc", "Zimbabwe salmon revolutionize" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Patrick Deckow", "qui", "https://picsum.photos/640/480/?image=56", "Voluptatem dolores ab sunt nulla deserunt minima illum eaque est ea eveniet quisquam recusandae fugit quisquam explicabo vero error necessitatibus.", 390301883, 450, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), "Little Inc", "one-to-one Lead Borders" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Devon Waters", "quia", "https://picsum.photos/640/480/?image=84", "Sed voluptatibus iusto incidunt officia fugiat inventore fuga nihil placeat ab natus aut consectetur aut et nihil amet est dolorem.", 201259612, 872, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Local), "Orn - Fadel", "green Money Market Account Quality" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kolby Kshlerin", "ipsum", "https://picsum.photos/640/480/?image=279", "Id sit eligendi id dolorem iure autem tempore consequatur recusandae vel iure est dolore sequi harum recusandae similique magnam quo.", 681413433, 987, new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), "Klein - Carroll", "client-server Unbranded Metal Shoes Operative" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Madison O'Hara", "et", "https://picsum.photos/640/480/?image=169", "Est eum quo sit enim iure sunt dolor culpa omnis culpa culpa ad nemo qui et aut eum nisi aut.", 493630226, 155, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), "Bogisich Group", "Savings Account Awesome Soft" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Justus Schimmel", "nulla", "https://picsum.photos/640/480/?image=61", "Occaecati non molestias et sed ipsam autem et dignissimos similique molestiae veritatis sequi velit maiores rem est tempora ipsum eaque.", 399492755, 181, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "Huel Group", "virtual Senior encompassing" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLISHER", "TITLE" },
                values: new object[] { "Eleazar Hagenes", "et", "https://picsum.photos/640/480/?image=1067", "Unde dolores rerum aperiam quisquam mollitia ut quam cum nisi nihil eaque vitae recusandae molestiae nisi eos modi cupiditate et.", 181794752, 987, "Howe, Moen and Roob", "salmon Small Granite Bike Metal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jermain Beatty", "eveniet", "https://picsum.photos/640/480/?image=191", "Laudantium ad possimus eos ut fuga eius est accusamus deserunt earum modi mollitia adipisci alias voluptatem aut illum autem fugiat.", 325034227, 268, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "Kohler, Trantow and Smitham", "Credit Card Account withdrawal Generic Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "AUTHOR", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Conor Weber", "https://picsum.photos/640/480/?image=388", "Magni est magnam reprehenderit vel animi aspernatur dolores magnam aut ut placeat ab ut unde quo rerum animi ex labore.", 845769205, 651, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "Veum - Graham", "Grove Legacy invoice" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Edmond Wilderman", "placeat", "https://picsum.photos/640/480/?image=831", "Doloremque atque ut id sint deleniti consequatur ipsam accusamus quia quam cum aut illum nam voluptatum nulla et consequatur voluptatem.", 439823845, 496, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "Kuvalis Group", "Dynamic Hungary Incredible" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rolando Kshlerin", "autem", "https://picsum.photos/640/480/?image=821", "Saepe consectetur ullam excepturi dolores nihil voluptate consequatur et ex necessitatibus qui quia perspiciatis voluptas nam earum magnam error dolorum.", 531188237, 808, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), "Cremin and Sons", "Fort Hill Auto Loan Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Leone Grant", "occaecati", "https://picsum.photos/640/480/?image=140", "Deleniti omnis consequatur voluptatibus aspernatur error consequatur consectetur ut exercitationem quia iure molestiae et voluptate harum impedit quia labore voluptatibus.", 850087255, 270, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "Hudson, Deckow and Lowe", "Clothing & Sports Underpass solid state" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Theresa Friesen", "harum", "https://picsum.photos/640/480/?image=583", "Nam ab ut corporis doloremque voluptatem et facilis quia sed illo at voluptatem aut et rerum aut et eos numquam.", 358947616, 930, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), "Blanda and Sons", "Credit Card Account Hollow methodologies" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Adonis Auer", "consequatur", "https://picsum.photos/640/480/?image=76", "Accusantium eos necessitatibus consectetur quia explicabo error quaerat hic laborum beatae incidunt magni ipsum fuga nam cupiditate id impedit eum.", 576027845, 192, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "Bashirian - Streich", "PNG Ways Strategist" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Winfield Mosciski", "totam", "https://picsum.photos/640/480/?image=194", "Doloremque quia molestiae id iure dolorum et rerum soluta quia ab deserunt laboriosam fuga asperiores consequuntur libero pariatur nobis nam.", 488540463, 512, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), "Herman - Reichert", "Small Concrete Keyboard monitor Assistant" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lafayette Kutch", "id", "https://picsum.photos/640/480/?image=863", "Animi labore animi nemo sit cumque eveniet voluptate quasi tenetur et quasi veritatis minima ut quas deserunt ea ipsa quam.", 633084974, 756, new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), "Kreiger, Dare and Schaefer", "cross-platform Garden & Beauty deposit" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Nikko Boyle", "explicabo", "https://picsum.photos/640/480/?image=72", "Vero soluta magnam itaque qui saepe asperiores quaerat repellendus commodi excepturi sunt mollitia excepturi dolorum exercitationem et nisi consequatur vel.", 938769027, 638, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), "Schuster LLC", "Auto Loan Account sexy Vista" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Eudora Champlin", "cupiditate", "https://picsum.photos/640/480/?image=719", "Non voluptatum doloremque nesciunt nesciunt nihil omnis ipsam est voluptas labore reiciendis minima debitis facere consectetur occaecati repellendus repellendus voluptatem.", 583697578, 941, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Local), "Bogan, Grant and Goodwin", "even-keeled Handmade Granite Tuna Branding" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Myrtle Wuckert", "voluptas", "https://picsum.photos/640/480/?image=445", "Labore et consequatur vel porro ipsum maxime quae qui unde aliquid facere quidem perferendis dolores labore pariatur dolorem unde laborum.", 283040694, 515, new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), "Ernser, Bergstrom and Murazik", "backing up fault-tolerant deposit" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Camden Lowe", "quaerat", "https://picsum.photos/640/480/?image=236", "Ut sint dolor quis tenetur quam eligendi hic accusantium rerum quo delectus voluptas ducimus doloremque qui tempora dolorum cum consequuntur.", 176857114, 170, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), "Stamm, Boyer and Wehner", "PCI Tunisia Legacy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sophia Bauch", "aut", "https://picsum.photos/640/480/?image=672", "Itaque voluptas et rerum officiis aut voluptates quaerat ullam consequatur laudantium a fugit illum temporibus quia ut sed odio et.", 184874381, 145, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Local), "Moen, Leannon and Hilpert", "Technician recontextualize olive" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Aaliyah Kiehn", "qui", "https://picsum.photos/640/480/?image=914", "Et aut laborum eius sint ut numquam provident ullam sint error asperiores at et aut doloremque est dolorem voluptatum aut.", 704349282, 100, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), "Huels, Harber and Abshire", "Dominica Gorgeous Analyst" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Cameron Steuber", "sequi", "https://picsum.photos/640/480/?image=593", "Numquam asperiores nemo officiis nemo eos delectus et rerum ut rerum laudantium dolores dolore nesciunt et nam blanditiis ea aut.", 754889857, 577, new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Local), "Bergstrom Inc", "program Engineer capacitor" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Garret Pagac", "nemo", "https://picsum.photos/640/480/?image=299", "Praesentium mollitia corrupti aut qui cum temporibus quia debitis aliquam dolorem culpa natus veniam minus et saepe dolores dolor omnis.", 171205560, 53, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), "Gibson Group", "Albania generate Pakistan Rupee" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Gage Gerhold", "omnis", "https://picsum.photos/640/480/?image=254", "Aut doloribus deserunt itaque voluptates totam aperiam non necessitatibus eos libero sit voluptate minus et asperiores et dolorem nisi non.", 566781834, 880, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), "Halvorson - Bahringer", "Health, Clothing & Grocery Bahraini Dinar Small Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jeffry Heathcote", "rerum", "https://picsum.photos/640/480/?image=856", "Laboriosam iste molestiae aliquid id in natus facere quo iusto odit deleniti numquam est voluptatem qui id voluptate voluptatem perspiciatis.", 997326254, 427, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), "Feil - Bogisich", "Berkshire blockchains Wooden" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Efren Wolf", "quia", "https://picsum.photos/640/480/?image=631", "Quia totam non dolor magnam praesentium omnis quis et dolorem quas repudiandae neque quia odio quia repellendus occaecati consequatur repellendus.", 843033025, 879, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "Hilpert and Sons", "program Incredible Soft Shoes Connecticut" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Johnnie Hahn", "id", "https://picsum.photos/640/480/?image=134", "Nulla totam facere non architecto occaecati molestiae aut voluptatem autem quisquam id esse est in totam nesciunt cum eum qui.", 495735360, 621, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), "VonRueden - Cremin", "Cook Islands multi-byte connecting" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alyson Abernathy", "exercitationem", "https://picsum.photos/640/480/?image=919", "Eum sit tempore et deleniti dolor voluptas similique cupiditate possimus id quibusdam nam beatae rerum qui deleniti quia odio quibusdam.", 887318117, 363, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), "Wiza and Sons", "Isle Tunnel enable" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Fabian Heathcote", "itaque", "https://picsum.photos/640/480/?image=687", "Corporis accusamus voluptatem autem porro architecto odio sint dolore omnis similique omnis voluptates explicabo voluptatem tempore fugit amet quam velit.", 393513165, 381, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), "Jakubowski Inc", "Computers Configurable Licensed Soft Car" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rhiannon Lind", "perspiciatis", "https://picsum.photos/640/480/?image=556", "Vitae et veniam sint ut et sed quia totam delectus placeat itaque ratione minima alias voluptas est vel aut ducimus.", 686391750, 387, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "Vandervort, Corkery and Abshire", "Electronics, Automotive & Industrial XML Checking Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Muhammad Abshire", "corrupti", "https://picsum.photos/640/480/?image=379", "Magnam ipsam eveniet enim ea quis possimus molestiae soluta non culpa hic autem dicta ipsum error beatae aut labore neque.", 786749753, 897, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), "Douglas - Leffler", "client-driven deposit upward-trending" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lottie Homenick", "asperiores", "https://picsum.photos/640/480/?image=781", "Rerum dolor voluptatibus voluptas tempora debitis deleniti tempore eum in nobis voluptas culpa qui animi debitis temporibus ducimus voluptatibus a.", 879788263, 913, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), "Sauer, Gaylord and Christiansen", "Borders 1080p Jewelery, Home & Shoes" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alexandra D'Amore", "dolore", "https://picsum.photos/640/480/?image=672", "Deserunt deserunt nemo laborum tenetur et rerum dolorem cupiditate quisquam ut qui doloremque in possimus perferendis incidunt eveniet laboriosam incidunt.", 668447893, 702, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), "Howe LLC", "zero tolerance Berkshire Intelligent Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Velva Mayer", "doloremque", "https://picsum.photos/640/480/?image=591", "Doloribus deleniti occaecati qui at cumque voluptatibus corporis sit quia quis dolores cumque quis aliquam eum tenetur at et quibusdam.", 825848973, 896, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), "Bogan - Denesik", "connecting Guyana incentivize" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Niko Turner", "dolore", "https://picsum.photos/640/480/?image=156", "Et incidunt atque ut sunt et quia nemo quas deserunt qui nulla adipisci aperiam doloribus voluptas quae error eum impedit.", 164518846, 168, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), "Conn, Shanahan and Kub", "quantify Architect Refined Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Angie Hamill", "ut", "https://picsum.photos/640/480/?image=300", "Eum est cumque voluptatem quae quae ipsum est placeat aut qui enim voluptas ratione illum ea repellendus ullam non facilis.", 271336230, 845, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), "Cole - Kessler", "next generation relationships Interactions" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Remington Lakin", "velit", "https://picsum.photos/640/480/?image=375", "Minus saepe deserunt nemo qui at sed atque eos aut fugit odit fugit quibusdam qui rerum qui sint vitae voluptatem.", 315960369, 284, new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), "Corkery Inc", "background innovate Directives" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Aliyah Wolff", "voluptatem", "https://picsum.photos/640/480/?image=675", "Aut repellendus voluptate repellat non velit molestias ut dolorem quos velit explicabo explicabo veritatis voluptate iure ex provident ipsa eius.", 328444660, 136, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), "Gleichner - Pacocha", "copying SAS Garden" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Gus Ernser", "asperiores", "https://picsum.photos/640/480/?image=1030", "Fuga eum similique asperiores vitae praesentium aliquam impedit corrupti ipsum rerum possimus magni occaecati qui officiis eligendi dolore ea sint.", 664247479, 487, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), "Nikolaus, Shanahan and King", "multimedia encryption Exclusive" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jamie Bernhard", "harum", "https://picsum.photos/640/480/?image=272", "Cupiditate blanditiis iure ducimus temporibus aut non omnis quod molestiae mollitia ut optio excepturi aut similique sequi quia ipsum eum.", 634166246, 430, new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), "Hills - Terry", "multi-byte Rwanda Franc Switchable" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Johnathon Klocko", "culpa", "https://picsum.photos/640/480/?image=764", "Qui aliquid dolores molestiae maxime ut aut veritatis porro est aut porro velit minus rem voluptatem ratione quam doloremque consectetur.", 371313509, 250, new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), "Ledner, Considine and Bode", "Plaza salmon Movies & Garden" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jaeden Schneider", "in", "https://picsum.photos/640/480/?image=734", "Numquam ex nobis id aut et tenetur ipsam voluptate quas error quas qui excepturi consequatur reiciendis et quos atque repellendus.", 457741643, 312, new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), "Deckow Group", "Rubber Handcrafted bypass" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lelia Wuckert", "quia", "https://picsum.photos/640/480/?image=265", "Non fugit iusto eos eligendi velit consequatur rerum aperiam necessitatibus voluptatem est consequatur dolorem qui aliquid voluptas rerum necessitatibus voluptatem.", 583723895, 642, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), "Padberg - Farrell", "magenta Cloned Summit" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Nathanael Lesch", "non", "https://picsum.photos/640/480/?image=688", "Vitae aut id ipsum incidunt porro earum iusto possimus voluptatem quo modi ducimus architecto magnam aperiam voluptas fuga laudantium recusandae.", 383253145, 50, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "Kreiger, Veum and West", "deposit navigating one-to-one" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Adalberto Hand", "suscipit", "https://picsum.photos/640/480/?image=529", "Consectetur quia quaerat qui vel et ea quos voluptatem facilis omnis expedita sint maxime fugiat vitae sit provident qui sint.", 266101215, 656, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "Rice LLC", "Kenyan Shilling Steel Cove" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Trey Harvey", "rerum", "https://picsum.photos/640/480/?image=845", "Necessitatibus asperiores dolorem aut voluptatum reprehenderit nobis molestias repellat deleniti dolore quis qui itaque sit deserunt ut id non sint.", 888446682, 850, new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), "Erdman and Sons", "Paraguay compress protocol" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Issac O'Keefe", "cum", "https://picsum.photos/640/480/?image=1042", "Ut magni quibusdam amet enim velit ut consequatur sit quos corrupti voluptate assumenda laudantium saepe ut sunt deserunt suscipit ex.", 199906399, 403, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), "Heller - Abbott", "Bermudian Dollar (customarily known as Bermuda Dollar) Squares Mount" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "AUTHOR", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Cassandre Fadel", "https://picsum.photos/640/480/?image=62", "Corrupti et velit in in maiores voluptatibus veritatis blanditiis et dicta nostrum quibusdam at doloribus possimus dolores rerum a consequatur.", 786798847, 411, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "Mueller, Zieme and Cummerata", "Group EXE deposit" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ferne Gusikowski", "occaecati", "https://picsum.photos/640/480/?image=963", "Nisi quia nostrum optio asperiores ea non id qui architecto sit voluptatem molestiae aut dolorem est cumque qui natus quasi.", 142894610, 967, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "Schaden, Gerhold and Nader", "Director Fork Ergonomic Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Zion Stokes", "excepturi", "https://picsum.photos/640/480/?image=579", "Possimus officia nobis nihil dicta tenetur et hic ipsum et rerum id recusandae voluptatem ullam quo quia et amet quos.", 417796666, 786, new DateTime(2024, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), "Cremin Inc", "Berkshire Gorgeous Plastic Computer deposit" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kiarra Bruen", "sint", "https://picsum.photos/640/480/?image=787", "Illum quos repellat eos quia iste laudantium perferendis debitis maiores minima quam architecto reiciendis in nam sed eaque eos ut.", 263738229, 358, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "Willms, Herzog and Sipes", "Plain Ecuador Avon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mackenzie Kreiger", "molestiae", "https://picsum.photos/640/480/?image=725", "Id veniam cumque non impedit et debitis culpa qui sint totam fugit magnam eos inventore provident sit dolore eaque labore.", 299947512, 539, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), "Wiza - Waelchi", "Jewelery & Kids quantify Executive" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Marcel Homenick", "rem", "https://picsum.photos/640/480/?image=89", "Possimus id nisi ab distinctio quia quia et nobis sequi minima et aut eos deleniti deleniti odio quasi velit autem.", 986074058, 381, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), "Larkin - Reilly", "Consultant Officer Hill" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Maryam Gleichner", "placeat", "https://picsum.photos/640/480/?image=125", "Culpa et nostrum ex laborum amet et maiores autem corporis repudiandae quis laborum autem aliquid excepturi voluptatem minus incidunt in.", 155472165, 593, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), "Pfannerstill - Gottlieb", "Frozen Facilitator Turks and Caicos Islands" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Anya Gislason", "modi", "https://picsum.photos/640/480/?image=55", "Nisi repudiandae illum rerum illo aliquid dolore molestiae consectetur officia magnam consequatur quo omnis alias ab rerum sunt libero repudiandae.", 289554814, 414, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), "Runolfsdottir, Erdman and Koss", "Corporate connect Refined Steel Chair" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Johnson Veum", "consequatur", "https://picsum.photos/640/480/?image=90", "Libero et aperiam quibusdam laboriosam dolorem consequatur quis non neque est nisi error omnis nobis quo in laudantium atque harum.", 377930232, 593, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), "Langosh - Harber", "Rustic Buckinghamshire Pass" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Brooklyn Spencer", "asperiores", "https://picsum.photos/640/480/?image=390", "Rerum omnis placeat deleniti culpa dolorum unde in pariatur id iusto ipsa est quo quasi qui quo ut quia provident.", 738358525, 211, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), "Tromp - Trantow", "SMTP South Dakota Course" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Carlo Gleichner", "ipsam", "https://picsum.photos/640/480/?image=36", "Non quaerat laboriosam distinctio aut voluptatem officia illum maiores aut ea consequatur eaque quis modi autem et nemo dolorum et.", 981976933, 492, new DateTime(2023, 6, 21, 0, 0, 0, 0, DateTimeKind.Local), "Wyman - Schmitt", "Security Generic Soft Shirt Crossing" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Delbert Hamill", "harum", "https://picsum.photos/640/480/?image=27", "Molestias nobis aspernatur neque soluta quia tempore eius et totam maxime libero doloremque voluptatem explicabo enim nam ullam maxime aut.", 762659940, 70, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "Lynch, Legros and Romaguera", "Facilitator Turkey capacity" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Bud Larson", "laboriosam", "https://picsum.photos/640/480/?image=436", "Necessitatibus at quibusdam dolorem perspiciatis et quia quisquam nobis nulla corrupti mollitia similique voluptates voluptas quisquam temporibus libero pariatur non.", 515849949, 221, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Local), "Wolf Inc", "Executive Director feed" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kacie Beer", "vitae", "https://picsum.photos/640/480/?image=744", "Ratione doloribus eligendi qui aperiam et sequi quibusdam qui molestias ea est rem cum culpa earum rerum sit accusantium harum.", 170878606, 774, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Nader - Smith", "Vatu Estonia SQL" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Isac Hermann", "a", "https://picsum.photos/640/480/?image=173", "Et autem tempora nemo dolorem minima quidem quidem rerum nam recusandae odit vel eligendi vitae eaque perspiciatis id minus laboriosam.", 244351599, 506, new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Local), "Howell, Schowalter and Morar", "Cote d'Ivoire Cambridgeshire Tala" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Skyla Morissette", "totam", "https://picsum.photos/640/480/?image=424", "Dolorum neque consequatur velit omnis ipsa ipsum hic sunt perferendis ullam id cupiditate libero illo perferendis ratione itaque distinctio consectetur.", 263788840, 967, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Local), "Steuber and Sons", "Niger Outdoors, Clothing & Kids Personal Loan Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Thea Hermiston", "explicabo", "https://picsum.photos/640/480/?image=892", "Voluptatem voluptatem eligendi non reprehenderit quia molestiae quos sit qui provident amet et ipsam dolore voluptas deserunt dolores perspiciatis rerum.", 228510107, 970, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), "Bauch Group", "Gibraltar Pound Lake Solutions" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kelly Morissette", "id", "https://picsum.photos/640/480/?image=960", "Quaerat impedit nesciunt fugit dolorem accusamus vel consectetur harum nobis voluptatem vero tempore vel praesentium dolore provident dignissimos natus quia.", 582817996, 448, new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), "Heaney - Daniel", "payment leverage plug-and-play" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Daniella Runte", "sunt", "https://picsum.photos/640/480/?image=376", "Nulla et autem ut aut rerum dolorum impedit rerum ad earum autem enim ipsa et est omnis dolor aliquid odio.", 426225185, 360, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), "Conroy - Schowalter", "national application Supervisor" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Javonte Roberts", "quae", "https://picsum.photos/640/480/?image=22", "Fugiat id delectus modi natus accusamus ut ducimus explicabo consequatur veritatis tenetur ea veritatis qui perspiciatis excepturi ea quae saepe.", 712493938, 170, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), "Swift - Dare", "Principal standardization input" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Julia Bosco", "est", "https://picsum.photos/640/480/?image=992", "Est nesciunt expedita quo dolores vel aperiam delectus rem voluptatem est quia ullam qui veritatis vitae ad numquam nam eos.", 954455836, 669, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), "Morissette LLC", "synthesize synergistic Kip" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Noemie Grant", "omnis", "https://picsum.photos/640/480/?image=765", "Voluptates quis ut voluptatum repellat cum vel enim repudiandae atque voluptas deleniti ea explicabo quo est sequi perspiciatis iure rerum.", 426614439, 763, new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), "Wiza and Sons", "Investment Account end-to-end Lake" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alta Schmitt", "aut", "https://picsum.photos/640/480/?image=58", "Quia voluptas sunt odio a molestias accusamus nostrum enim tenetur pariatur in beatae libero et a et et eligendi quibusdam.", 488201877, 519, new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "Kshlerin, Bartoletti and Daniel", "Licensed Concrete Computer Circle Lead" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Isabell Kerluke", "qui", "https://picsum.photos/640/480/?image=603", "Provident sunt dolores ea consequatur fugit consequatur quam et quo ipsum sit quaerat tenetur corrupti incidunt eius neque accusamus esse.", 285354893, 245, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Lesch, Sawayn and Bergnaum", "synthesizing Buckinghamshire National" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Brandt Vandervort", "autem", "https://picsum.photos/640/480/?image=103", "Autem atque rerum facere facere magni sequi rerum assumenda dolor minima delectus dolores fuga labore dolorum omnis voluptas et aliquid.", 331171291, 186, new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Local), "Senger, Braun and Cole", "Awesome Metal Chair Stravenue COM" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Trace Deckow", "recusandae", "https://picsum.photos/640/480/?image=307", "Harum voluptatibus temporibus blanditiis temporibus quae quia iste rem et voluptatem sit distinctio error nesciunt pariatur dolorem qui ut dolores.", 612544000, 894, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), "O'Keefe, Rempel and Cormier", "quantify Savings Account index" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Monte Ankunding", "quae", "https://picsum.photos/640/480/?image=557", "Debitis ea vel est sed libero voluptas facilis et dolorum atque voluptas aut voluptatem quisquam iusto facilis laudantium aut exercitationem.", 199508017, 613, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), "Hettinger Inc", "Investor Lead Analyst" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Grace Senger", "at", "https://picsum.photos/640/480/?image=910", "Qui et mollitia soluta aliquam eius cupiditate ipsa temporibus dolores ut est reiciendis voluptatem nesciunt maiores dolor vitae quo et.", 669490343, 448, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), "Purdy Group", "Argentine Peso JBOD Metal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Angelica Russel", "sint", "https://picsum.photos/640/480/?image=314", "Amet ut rerum expedita exercitationem ut officia vitae perspiciatis doloremque esse occaecati nostrum temporibus vel ipsam et accusantium excepturi id.", 289367081, 216, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "Leffler Inc", "deposit Mobility Director" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ulises Hills", "provident", "https://picsum.photos/640/480/?image=630", "Incidunt a quasi id iure deleniti placeat necessitatibus vel et cumque odit eius voluptatibus vel porro qui reprehenderit consequatur soluta.", 271510653, 781, new DateTime(2023, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), "Pollich and Sons", "Personal Loan Account override reintermediate" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alphonso Kshlerin", "libero", "https://picsum.photos/640/480/?image=502", "Sed commodi neque fugiat qui rem impedit assumenda possimus corporis iste beatae dignissimos cupiditate provident facere vitae ea nisi dicta.", 886772972, 606, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Local), "VonRueden Group", "Frozen Dynamic local area network" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Andy Jast", "assumenda", "https://picsum.photos/640/480/?image=416", "Itaque atque temporibus ab non quidem est officia deserunt expedita illo aut nobis necessitatibus aspernatur ab et expedita id qui.", 620433979, 864, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), "Hermann LLC", "optical scalable sensor" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Amara Carter", "id", "https://picsum.photos/640/480/?image=1032", "Repudiandae debitis esse ullam incidunt eum laudantium inventore beatae molestiae vel aut molestiae dolore at veritatis exercitationem qui odit natus.", 206583032, 975, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "Volkman, Block and Dooley", "background Germany Reunion" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lori Daniel", "voluptatem", "https://picsum.photos/640/480/?image=896", "Qui deserunt delectus deleniti neque exercitationem optio labore voluptatem et odio et et quos non hic qui reprehenderit quod est.", 762953172, 929, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), "Cole - Nolan", "withdrawal Viaduct Product" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Brandt Kuvalis", "quia", "https://picsum.photos/640/480/?image=599", "Tenetur autem repudiandae voluptatem laborum dolorem cupiditate vel perferendis reiciendis quia id sapiente nemo culpa quo magnam at ipsa est.", 124928948, 232, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), "Will and Sons", "Cambridgeshire Chief haptic" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Roy Baumbach", "perspiciatis", "https://picsum.photos/640/480/?image=53", "Architecto labore reiciendis repudiandae non occaecati magnam nemo saepe omnis quisquam tenetur explicabo placeat quidem et necessitatibus doloremque vel nostrum.", 547855953, 929, new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Crist, Spencer and Stamm", "teal out-of-the-box index" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ian Marquardt", "laudantium", "https://picsum.photos/640/480/?image=1052", "Ex voluptas quisquam perferendis deleniti consequatur ipsa enim repellendus dolorum sit labore et eos nihil id dolores dolorem tenetur neque.", 913368904, 768, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), "Connelly, Gaylord and Mayer", "Seamless driver Key" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Destini Medhurst", "omnis", "https://picsum.photos/640/480/?image=518", "Autem natus ex quaerat atque distinctio ea rerum ratione quo omnis eos non asperiores voluptas occaecati dolorem nihil officiis non.", 873079105, 524, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), "Shields, Denesik and Kiehn", "Up-sized EXE SSL" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kyra Wiza", "excepturi", "https://picsum.photos/640/480/?image=230", "Illo voluptatem nisi recusandae necessitatibus mollitia fugit expedita voluptatem fuga voluptatem repellendus et optio omnis aut illum nihil dignissimos nesciunt.", 936368131, 474, new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), "Krajcik, Murray and Koelpin", "Response initiatives Mozambique" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Wilmer Schulist", "et", "https://picsum.photos/640/480/?image=56", "Ut consequatur odio voluptas omnis nemo ut voluptates a nobis veritatis exercitationem doloribus consequatur enim ex excepturi vel neque nostrum.", 666494507, 808, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Dicki, Daugherty and Lang", "Burkina Faso Manat Delaware" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Orville Lueilwitz", "nemo", "https://picsum.photos/640/480/?image=539", "Omnis est qui ut blanditiis aut occaecati eos veritatis aut distinctio voluptatum sunt magnam esse rerum velit sit omnis qui.", 435343298, 615, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Simonis and Sons", "Nevada Tools, Clothing & Jewelery scalable" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Maverick Funk", "dolores", "https://picsum.photos/640/480/?image=684", "Aut culpa et nostrum est ut veniam sit ut voluptatem illum sed ab quaerat id fugiat fugit perferendis rerum at.", 244235758, 632, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), "Heathcote, Crona and Zboncak", "robust Bahraini Dinar pixel" });
        }
    }
}
