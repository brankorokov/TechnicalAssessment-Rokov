using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechnicalAssessmentRokov.Migrations
{
    /// <inheritdoc />
    public partial class InitializeDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DUE_DATE",
                table: "Books",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CHECKED_OUT_DATE",
                table: "Books",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Zella Waters", "reprehenderit", null, "https://picsum.photos/50/50/?image=951", "Totam omnis nam animi hic earum dolores omnis labore magnam possimus natus hic beatae ab et veritatis nobis ea et.", null, 404662840, 370, new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "Green - Satterfield", "Oklahoma driver Handmade Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hassan Green", "impedit", null, "https://picsum.photos/50/50/?image=457", "Ipsa est magnam incidunt sit quia eveniet quibusdam recusandae asperiores voluptate est dolores dolores consequatur et nobis iste doloremque et.", null, 347719743, 826, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "Wehner - Cormier", "Albania disintermediate Analyst" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kenneth Brakus", "molestias", null, "https://picsum.photos/50/50/?image=27", "Sint reiciendis assumenda dolores molestiae modi nisi soluta non sunt ut a voluptatem maxime aut exercitationem minima eos pariatur saepe.", null, 785997234, 591, new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), "MacGyver, Morar and Daniel", "dynamic Forest Metal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Maynard Wehner", "et", null, "https://picsum.photos/50/50/?image=840", "Molestiae veritatis quidem ea deleniti saepe labore voluptatem non consequatur voluptatem eius corporis atque dicta rerum blanditiis veritatis qui non.", null, 358401009, 489, new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), "Lind and Sons", "French Southern Territories brand Crest" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Randal Gulgowski", "placeat", null, "https://picsum.photos/50/50/?image=1081", "A aliquid maxime provident cum ut consectetur sit commodi omnis tempore et non iusto dignissimos voluptas magnam ullam aperiam ut.", null, 571354335, 986, new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), "Schaden, Aufderhar and Borer", "Officer Views synthesize" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Monty D'Amore", "illum", null, "https://picsum.photos/50/50/?image=845", "Est omnis consectetur amet recusandae eius quis rerum blanditiis illo tempore eaque eaque voluptatem error quia sequi perspiciatis cupiditate corrupti.", null, 250736792, 644, new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), "Gerlach - Schulist", "next generation Tunnel Extension" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Katlyn Rogahn", "autem", null, "https://picsum.photos/50/50/?image=272", "Expedita unde vero dolores nemo rerum sint facere et inventore aperiam mollitia delectus consequatur et et sed quia in praesentium.", null, 241698682, 531, new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Local), "Kihn, Leffler and Hickle", "Sleek Plastic Mouse collaboration dedicated" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Marlon Frami", "minima", null, "https://picsum.photos/50/50/?image=13", "Qui et qui dolorum voluptas et nihil commodi quae ea aut praesentium odio cumque tempore repellat laboriosam est ipsam velit.", null, 300991162, 932, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), "Schmeler Inc", "Colorado backing up Arkansas" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Olga Shields", "cupiditate", null, "https://picsum.photos/50/50/?image=1081", "Voluptatum doloribus sit rerum officiis deleniti magnam molestiae nulla ut voluptatibus odit ratione harum a voluptas id dignissimos sunt sit.", null, 497401294, 694, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "Padberg, Jenkins and Nicolas", "Interactions SSL Refined Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Romaine Rowe", "at", null, "https://picsum.photos/50/50/?image=286", "Quo voluptate vero harum maxime occaecati debitis necessitatibus fugit dolorum doloribus numquam at debitis quis vel unde modi vel commodi.", null, 956390999, 107, new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "Zboncak LLC", "invoice Clothing & Games encryption" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hyman Hills", "quidem", null, "https://picsum.photos/50/50/?image=186", "Nemo nemo nulla culpa voluptate ut eos id molestiae beatae rem et quia eveniet enim aut nulla molestiae omnis quos.", null, 467552270, 479, new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), "VonRueden, Bauch and Prohaska", "deliver Hawaii Associate" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sister Smitham", "eaque", null, "https://picsum.photos/50/50/?image=113", "Alias velit provident aut quas et reiciendis labore molestiae quia amet doloribus dicta id vero unde tenetur beatae nobis doloremque.", null, 662027752, 800, new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), "Wyman - Quitzon", "Knolls Liaison Planner" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mike Torphy", "est", null, "https://picsum.photos/50/50/?image=287", "Voluptatem quibusdam omnis iusto et ut in quibusdam eligendi dignissimos officia dolore libero et dolorem rerum omnis natus consequatur amet.", null, 116969906, 363, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Local), "Lubowitz - Bosco", "transmit deposit copying" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Maryse Hammes", "aut", null, "https://picsum.photos/50/50/?image=307", "Qui dolores quis velit unde voluptatem voluptas quia voluptates quis voluptates numquam eum voluptatem officiis excepturi error odit ex aut.", null, 345078156, 268, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), "Hintz, Koss and Kerluke", "Borders Gibraltar Pound SCSI" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Camron Blick", "ut", null, "https://picsum.photos/50/50/?image=613", "Quae mollitia et magni repellat sed autem impedit ab architecto molestias dolorem vero ut ipsa est assumenda mollitia deleniti laudantium.", null, 402544114, 752, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), "Cole Inc", "sticky radical software" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Thora Erdman", "nam", null, "https://picsum.photos/50/50/?image=200", "Nemo minus saepe similique esse iste velit tempore rem qui corrupti omnis est et voluptatem veniam delectus consequatur et labore.", null, 879952106, 828, new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), "Hayes, Raynor and Mosciski", "quantifying Small Plastic Keyboard Handmade Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Thad Mueller", "voluptatem", null, "https://picsum.photos/50/50/?image=828", "Enim perspiciatis nam omnis id ipsam quo blanditiis placeat est ut sed quidem ea qui nostrum explicabo sit recusandae iste.", null, 170590521, 612, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), "Shanahan, Botsford and Kautzer", "Drive input Technician" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lenny Barrows", "possimus", null, "https://picsum.photos/50/50/?image=790", "Sint consequatur maiores eligendi iste incidunt in ea laudantium sed quaerat minus aspernatur a quod voluptate et rerum qui animi.", null, 778499631, 274, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Wisozk, Weimann and Ortiz", "repurpose Books & Tools Falls" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Merlin Gleichner", "et", null, "https://picsum.photos/50/50/?image=802", "Molestias ut sint inventore omnis rerum accusantium perferendis earum quos assumenda adipisci sed necessitatibus veritatis qui est dignissimos qui blanditiis.", null, 509532997, 274, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), "Hyatt and Sons", "Macao Avon compelling" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Elmore Williamson", "qui", null, "https://picsum.photos/50/50/?image=374", "Cum exercitationem atque enim sed ut non sit voluptas nostrum expedita praesentium et est pariatur nihil porro iure soluta velit.", null, 317663697, 992, new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), "Olson - Schowalter", "backing up SMS withdrawal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Chad Langworth", "animi", null, "https://picsum.photos/50/50/?image=885", "Ad ipsum dolor est aut et quae mollitia maxime eum quia aut illum blanditiis fuga iusto praesentium aut eos nulla.", null, 844610351, 857, new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), "Kirlin, Schamberger and Klein", "Markets Investment Account deposit" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Stuart Satterfield", "nihil", null, "https://picsum.photos/50/50/?image=689", "Alias et nulla facilis consequatur autem illo eius est aspernatur ipsam consequatur aliquam eius culpa et est consequuntur accusamus aliquid.", null, 357537050, 303, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "Huel, Kuphal and Kertzmann", "Incredible Rubber Fish action-items IB" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Abby Hansen", "voluptatem", null, "https://picsum.photos/50/50/?image=513", "Sed omnis dolorem sed dolor asperiores libero et impedit dolor alias adipisci quam cumque et quis et rerum sint est.", null, 906546955, 189, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), "Kutch, Hickle and Shields", "implementation Refined Fresh Table local" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Obie Pollich", "corporis", null, "https://picsum.photos/50/50/?image=805", "Maiores reprehenderit unde qui voluptatem dignissimos nisi sunt sapiente hic sunt voluptas adipisci eum iste harum nesciunt iure ipsam quisquam.", null, 833109605, 928, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Hand, Jacobs and Torphy", "compressing Buckinghamshire Industrial & Shoes" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Imani Runolfsson", "autem", null, "https://picsum.photos/50/50/?image=314", "Esse autem et numquam veritatis ex eum numquam aut at harum magni quis temporibus odio impedit consequatur ullam facilis sint.", null, 789019651, 408, new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "Watsica, Rau and Jacobi", "XSS Paradigm Practical Cotton Car" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dewitt Dooley", "officia", null, "https://picsum.photos/50/50/?image=1046", "Aut molestias incidunt numquam aspernatur tempora ad nobis dolor repellendus vero molestias officia tenetur officia tenetur repudiandae et accusamus aspernatur.", null, 342527640, 77, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), "Pfannerstill Group", "Licensed Steel Table tertiary scalable" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Berenice Crona", "autem", null, "https://picsum.photos/50/50/?image=877", "Mollitia quam tempore accusantium et expedita tempora laudantium eum error laborum quis iusto aut et placeat est asperiores ut consequuntur.", null, 271056711, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Local), "Ullrich, Walter and Kertzmann", "circuit calculate Minnesota" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Devon Marquardt", "voluptatum", null, "https://picsum.photos/50/50/?image=410", "Tempora aliquam sunt ea dolorum error repudiandae autem corrupti hic doloribus in quam molestias porro voluptatem velit nesciunt laboriosam voluptas.", null, 277208709, 975, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), "Mayert - Raynor", "Refined Steel Chair project Spring" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Leonardo Rutherford", "at", null, "https://picsum.photos/50/50/?image=164", "Ad cumque quia quam minima repellat sequi sed omnis ut fuga architecto veritatis nihil iure adipisci temporibus fugit quae necessitatibus.", null, 680303239, 510, new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "Durgan, Ferry and Hettinger", "Progressive Platinum Avon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Macy Maggio", "dolore", null, "https://picsum.photos/50/50/?image=703", "Debitis est vero quis beatae et quaerat occaecati beatae eius praesentium distinctio nihil reiciendis tenetur deleniti harum similique animi optio.", null, 577470796, 308, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "Denesik, Berge and Bergnaum", "Associate Credit Card Account Prairie" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Gavin Orn", "exercitationem", null, "https://picsum.photos/50/50/?image=1018", "Amet explicabo magnam suscipit possimus porro autem sed aut a aperiam eos ipsa sapiente atque odit est nihil molestiae inventore.", null, 381114935, 93, new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), "Carter, Fritsch and Hagenes", "Marketing CFA Franc BEAC secondary" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kirk Hand", "incidunt", null, "https://picsum.photos/50/50/?image=64", "Est nobis optio enim eius et et deleniti nemo officiis tenetur minus vel accusamus autem perferendis et sequi consequatur accusamus.", null, 124411772, 276, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "Dare - Goodwin", "New Hampshire New Hampshire Product" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Harrison Cummerata", "aut", null, "https://picsum.photos/50/50/?image=999", "Eum repellat ut quos quae et expedita nam sint sit omnis distinctio velit libero esse modi vitae est occaecati ducimus.", null, 710059717, 561, new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), "Quigley, Larson and Veum", "Streamlined parsing microchip" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Oliver Bashirian", "cupiditate", null, "https://picsum.photos/50/50/?image=68", "Autem tenetur ratione sunt sint rerum saepe culpa ab molestiae sed eos earum asperiores voluptatum mollitia qui qui qui eaque.", null, 931781546, 843, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "Heathcote, Tremblay and Jones", "distributed Generic Plastic Soap sticky" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Grayson Gleason", "rerum", null, "https://picsum.photos/50/50/?image=667", "Dignissimos adipisci aliquam natus quos ea magnam dolor quae assumenda est saepe similique repellendus esse eligendi et maxime voluptatum necessitatibus.", null, 546833936, 638, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Howe, Mitchell and Raynor", "cross-media Cambridgeshire invoice" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Reed Carter", "et", null, "https://picsum.photos/50/50/?image=917", "Velit culpa itaque vitae velit unde perferendis ex in aliquid vel impedit accusamus consequatur et molestiae tempore ratione corrupti placeat.", null, 353546359, 198, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), "Becker, Schroeder and Marquardt", "Handmade Granite Chair payment PCI" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hettie Schaefer", "ut", null, "https://picsum.photos/50/50/?image=1049", "Reprehenderit quasi earum sit et sint culpa dolorum qui consequatur amet quaerat iste sapiente quaerat deleniti sit cumque illum aut.", null, 298756451, 151, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), "Oberbrunner Group", "XML Savings Account cultivate" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Camron Corkery", "quisquam", null, "https://picsum.photos/50/50/?image=124", "Mollitia fugiat necessitatibus qui enim sed omnis eaque in ipsam nobis hic amet ut saepe qui optio labore assumenda error.", null, 766857883, 767, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Weimann, Muller and Schumm", "District Director action-items" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Leanne Witting", "voluptatem", null, "https://picsum.photos/50/50/?image=156", "Iusto dicta et deleniti tempore laudantium quidem laborum exercitationem quae impedit aut voluptas beatae veritatis harum nihil officiis nobis soluta.", null, 539984792, 944, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), "Monahan and Sons", "Sleek Guam Unbranded Soft Ball" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Elody Anderson", "id", null, "https://picsum.photos/50/50/?image=658", "Iste error autem reprehenderit et possimus minima dignissimos asperiores modi eos quod delectus ut sint nulla temporibus sequi vel quia.", null, 553050214, 810, new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Local), "Wolff and Sons", "HTTP Berkshire white" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Paxton Douglas", "ut", null, "https://picsum.photos/50/50/?image=344", "Necessitatibus nisi consequatur molestias enim neque aut sed aut et repudiandae ut repudiandae ut similique explicabo amet exercitationem est ut.", null, 511612810, 494, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Local), "Abbott, Zemlak and Hermann", "Ramp Handmade real-time" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Elody Erdman", "ullam", null, "https://picsum.photos/50/50/?image=617", "Et dicta quia sed maiores aut rerum maiores tempore magni inventore fugit nihil autem fuga ut facilis voluptas voluptate illo.", null, 221155203, 977, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), "Hills - Green", "panel Accountability Via" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rubye Wiza", "voluptatem", null, "https://picsum.photos/50/50/?image=455", "Eius aliquid deleniti odit est aut veniam id dignissimos ratione velit aspernatur eligendi illum est qui sit quae omnis et.", null, 368778812, 651, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), "Veum - Toy", "Money Market Account Ergonomic Steel Computer Rubber" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Malinda Von", "id", null, "https://picsum.photos/50/50/?image=89", "Sint dolorem sapiente et similique sunt dolor voluptatem aut ut explicabo eos doloremque iure aut et voluptatem porro nihil nam.", null, 592284455, 587, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), "Cole Group", "Soft Agent Kina" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kaylie Sipes", "odio", null, "https://picsum.photos/50/50/?image=1009", "Voluptatibus et nobis nihil aspernatur libero et quasi impedit voluptate tenetur totam tempore non maxime doloremque aperiam quis consequuntur debitis.", null, 226214301, 443, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Local), "Nienow Inc", "Expanded envisioneer encoding" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Katarina Rutherford", "facilis", null, "https://picsum.photos/50/50/?image=428", "Sapiente soluta quam cupiditate quia ratione id aliquam aliquam temporibus quam facilis porro est eum odit maxime ipsa quae ea.", null, 784685452, 367, new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Borer LLC", "revolutionary actuating scale" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Beaulah Bahringer", "quia", null, "https://picsum.photos/50/50/?image=1063", "Officia ipsa rerum fuga ut aut repellendus id debitis aut fugiat at non autem necessitatibus accusamus culpa aut alias fugit.", null, 474793337, 852, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "Adams, Gleichner and Wisoky", "user-facing Street Representative" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ivory Collier", "odit", null, "https://picsum.photos/50/50/?image=765", "Et non beatae soluta ab qui voluptates quis a et perspiciatis dignissimos sunt placeat sequi officia eveniet beatae nobis ducimus.", null, 697891789, 877, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Local), "Graham LLC", "models next generation New York" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jennie Spencer", "sequi", null, "https://picsum.photos/50/50/?image=493", "Et perspiciatis sed consectetur ad vero tenetur unde similique dolorum expedita aut assumenda itaque quos nam perspiciatis et est facilis.", null, 755904235, 276, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "Wintheiser LLC", "Frozen Rustic Fresh Hat Incredible" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Oscar Price", "sit", null, "https://picsum.photos/50/50/?image=926", "Dicta totam et quam cumque ipsam iusto tempora accusamus omnis error quis in rerum dolor suscipit voluptatem consequatur est cumque.", null, 655707415, 715, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "Zboncak Inc", "input syndicate Officer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Drew Cremin", "occaecati", null, "https://picsum.photos/50/50/?image=468", "Perspiciatis perspiciatis deleniti aperiam et exercitationem quibusdam ex occaecati voluptatum fuga qui molestiae vero ex occaecati optio saepe perspiciatis non.", null, 874571550, 71, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "Balistreri - McLaughlin", "Unbranded Village Plastic" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Bianka Ortiz", "eos", null, "https://picsum.photos/50/50/?image=198", "Laudantium omnis sequi a reiciendis impedit vel dolor sed quas occaecati doloremque ratione et sit praesentium ullam repudiandae omnis qui.", null, 896607343, 66, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Local), "Cummings Inc", "Usability Handcrafted Fresh Bike Illinois" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "June Jast", "qui", null, "https://picsum.photos/50/50/?image=32", "Ea ut occaecati ut doloribus tenetur veritatis et occaecati laborum voluptate quod accusantium recusandae laudantium molestias veniam omnis ducimus quia.", null, 205017409, 533, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Schoen - Harber", "Licensed leverage National" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Melyssa Ortiz", "expedita", null, "https://picsum.photos/50/50/?image=370", "Autem ut dolorem odit quae et voluptas sit minus quibusdam nihil deserunt non earum similique error est dolorem sint dolores.", null, 675981395, 324, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), "Kunde, Oberbrunner and Weimann", "Hills tangible Refined Plastic Chair" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Brown Hamill", "sunt", null, "https://picsum.photos/50/50/?image=742", "Sed qui rem unde cupiditate rerum et veritatis nihil autem omnis est maxime qui aut repellat placeat sit saepe dolore.", null, 960387125, 525, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Local), "Bailey, Crist and Zemlak", "Mall Mauritius Isle" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sage Miller", "vel", null, "https://picsum.photos/50/50/?image=743", "Ut magni sapiente exercitationem molestiae ipsam itaque est ea voluptatum nesciunt et necessitatibus officiis expedita beatae et praesentium corrupti et.", null, 473815878, 391, new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Local), "Rutherford - Swift", "Springs plum Buckinghamshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Keenan Kirlin", "molestias", null, "https://picsum.photos/50/50/?image=92", "Ipsa magni dolore doloribus iusto non porro soluta ipsum incidunt aperiam repellendus dolores cupiditate velit nihil et sequi libero quos.", null, 468778975, 806, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), "Mraz Inc", "Pula Berkshire salmon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Maegan Yundt", "iusto", null, "https://picsum.photos/50/50/?image=789", "Eum placeat sint illum hic quidem perferendis delectus nam ut aperiam voluptatem est et totam voluptatem consequatur unde officiis et.", null, 509562149, 302, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "Mertz LLC", "Rustic Fantastic Wooden Gloves Persevering" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lonnie Fadel", "tempora", null, "https://picsum.photos/50/50/?image=202", "Suscipit velit deleniti nesciunt sit sed aliquam magnam sapiente eum quasi impedit aut nulla quia veritatis blanditiis libero et aut.", null, 713484920, 172, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), "Lakin, Ankunding and King", "initiatives Identity Extended" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dimitri Hyatt", "vel", null, "https://picsum.photos/50/50/?image=39", "Magni velit accusantium debitis aperiam aliquam est est cumque autem voluptates rerum aut ullam odio corporis suscipit non officia in.", null, 736472718, 293, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), "Waelchi Group", "Handmade Granite Keyboard infomediaries Intelligent" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ernest Kautzer", "nisi", null, "https://picsum.photos/50/50/?image=980", "Corporis ut voluptate aliquid cumque necessitatibus officiis ullam sunt assumenda ullam occaecati et quam veniam ipsam aut tempora dolores praesentium.", null, 693300994, 316, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "Mann - Dickinson", "optimize Accountability Synchronised" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Clemmie Howe", "neque", null, "https://picsum.photos/50/50/?image=911", "Maiores quam possimus quia quasi sequi sint aut exercitationem aut maiores perferendis qui provident in nam sit voluptatibus numquam aut.", null, 797742581, 785, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "Rodriguez, Ortiz and Wunsch", "invoice green payment" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Pierce Harris", "quia", null, "https://picsum.photos/50/50/?image=189", "Magni dolorum unde aut quo quis dignissimos excepturi enim iure qui eum aut aliquam eos eos tempora officiis praesentium provident.", null, 802344686, 868, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), "Stiedemann, Davis and Lowe", "Avon Officer Metal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Wilmer Hilll", "similique", null, "https://picsum.photos/50/50/?image=651", "In hic ratione totam et quae dolores consequuntur quia est et velit delectus consequatur aut aperiam laudantium sint temporibus impedit.", null, 475049559, 819, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "Oberbrunner LLC", "Facilitator port Savings Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kristopher Stamm", "cum", null, "https://picsum.photos/50/50/?image=806", "Aspernatur dicta ipsum sed quibusdam consequatur eius ea ut cumque dolorum ut ea neque non sit delectus odio officia cum.", null, 118270136, 684, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "Heaney Inc", "Computers & Music Fields connect" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kyleigh Goyette", "assumenda", null, "https://picsum.photos/50/50/?image=963", "Temporibus voluptatum numquam fuga id dolorum nihil quia nostrum aut accusantium earum adipisci omnis cupiditate veritatis assumenda et et sed.", null, 238111530, 335, new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Local), "O'Reilly, Waters and Prosacco", "Facilitator Pines Internal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Talon Jones", "est", null, "https://picsum.photos/50/50/?image=600", "Saepe non iste esse veniam nostrum aut voluptatibus est non perferendis nesciunt porro ab neque molestiae in occaecati minima pariatur.", null, 343004797, 922, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Little, Huel and Weissnat", "Summit Auto Loan Account Realigned" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Daron Stark", "quo", null, "https://picsum.photos/50/50/?image=521", "Corrupti ipsa aut dignissimos aut est cumque porro et saepe velit quis rerum a adipisci temporibus vel quia sunt fugit.", null, 395441830, 957, new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), "Fay - Bradtke", "Chad Nuevo Sol portals" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Trey McDermott", "architecto", null, "https://picsum.photos/50/50/?image=437", "Qui qui et at minus cupiditate nemo quidem quae veniam similique porro ipsam vero ducimus rerum deserunt dicta dolorem ut.", null, 565510663, 950, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Kulas Group", "multi-byte regional Synergized" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sarah Dibbert", "magni", null, "https://picsum.photos/50/50/?image=294", "Iure rerum natus sit eos quibusdam ipsum sed sed numquam accusamus soluta quae fuga autem porro praesentium laudantium dolor et.", null, 832986762, 698, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), "Lebsack and Sons", "payment Radial Road" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alysa Abshire", "nobis", null, "https://picsum.photos/50/50/?image=513", "Perspiciatis rem aperiam officiis possimus aut similique voluptatem dolorem sapiente delectus voluptatum officia occaecati quia nobis est fugit et dolorem.", null, 500603008, 748, new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Parisian, Rice and Shanahan", "Stravenue Manager Burundi Franc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Wallace White", "vel", null, "https://picsum.photos/50/50/?image=824", "Ratione nobis ut asperiores et qui vitae amet atque et dolorem voluptates aperiam ipsam perferendis non similique nam autem quo.", null, 460109063, 638, new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "Nicolas Inc", "Metrics Principal backing up" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Leslie Heidenreich", "aut", null, "https://picsum.photos/50/50/?image=891", "Culpa ut dolorem ea minima voluptatum repellat sint itaque sapiente dolor blanditiis praesentium facilis dicta ea fuga adipisci enim est.", null, 772908609, 926, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Local), "Haag - Kuvalis", "seize bypassing Practical Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jessica Runte", "minima", null, "https://picsum.photos/50/50/?image=935", "Voluptate veniam sed pariatur ut ex vero dignissimos aliquid quos et repellendus in et nulla est ea dolor voluptate sunt.", null, 168349717, 879, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), "Durgan - Tromp", "monitoring hack IB" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Winifred Prosacco", "non", null, "https://picsum.photos/50/50/?image=847", "Debitis fugiat exercitationem omnis et ab ipsa delectus recusandae officia autem non itaque nisi omnis non tempore ut quam nihil.", null, 451447592, 516, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Local), "Rutherford - Abbott", "fuchsia Danish Krone bypassing" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Vena Ryan", "qui", null, "https://picsum.photos/50/50/?image=915", "Laboriosam qui voluptatem adipisci consequatur quo magni atque ut doloremque cum provident quia numquam ex numquam qui odio earum rerum.", null, 157794222, 752, new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "Nienow and Sons", "syndicate Incredible Arizona" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Reba Graham", "est", null, "https://picsum.photos/50/50/?image=562", "Est rerum adipisci et quae laboriosam praesentium asperiores quibusdam sit blanditiis et aut magnam possimus quas in ut et voluptas.", null, 793766180, 157, new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), "Ledner Inc", "Facilitator Practical Frozen Fish deposit" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lew Grant", "quo", null, "https://picsum.photos/50/50/?image=569", "Itaque optio omnis aut dolor magni libero laboriosam asperiores et nulla voluptate facilis molestiae cum rerum laboriosam facilis eveniet molestiae.", null, 307978537, 575, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), "Romaguera Inc", "program enhance primary" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Giuseppe Dach", "molestiae", null, "https://picsum.photos/50/50/?image=601", "Incidunt modi et nam sapiente repudiandae quibusdam unde sapiente voluptate modi consequatur aperiam nisi commodi molestiae libero et ut repellendus.", null, 382742816, 94, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Local), "Dicki - Adams", "reciprocal Ville Data" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Pablo Bergnaum", "totam", null, "https://picsum.photos/50/50/?image=515", "Maxime et quis officiis et earum possimus quibusdam sed sint quidem possimus deleniti fuga illum suscipit possimus porro nisi incidunt.", null, 295458134, 341, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), "Douglas - Simonis", "monetize Clothing, Shoes & Movies Legacy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mariane Blick", "sint", null, "https://picsum.photos/50/50/?image=762", "Officia quos sapiente optio non similique quidem sed totam nemo labore cumque ex voluptate error et quos omnis reprehenderit vel.", null, 306146836, 205, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), "Armstrong, Dare and Jones", "matrix Creative synthesize" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rocio Kozey", "nostrum", null, "https://picsum.photos/50/50/?image=820", "Vel nihil magni earum ducimus debitis qui non aspernatur blanditiis est aut aliquid reiciendis facilis sit sequi voluptatum eum cumque.", null, 573983630, 744, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), "Zemlak, Simonis and Walter", "system Fresh invoice" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Heber Grant", "quibusdam", null, "https://picsum.photos/50/50/?image=376", "Tempora hic harum aut voluptatibus eaque totam sed nihil voluptate iure quia rerum expedita ea et esse nemo velit exercitationem.", null, 814353219, 976, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), "Abernathy - Kuhn", "index bluetooth Realigned" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Helena Conroy", "sint", null, "https://picsum.photos/50/50/?image=797", "Rerum consequatur non sed aut beatae laudantium cum qui ut repellat eum nobis commodi impedit eos enim voluptatum dignissimos blanditiis.", null, 379589015, 467, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "Jones - Lebsack", "SDR Burgs Berkshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Elva Stamm", "et", null, "https://picsum.photos/50/50/?image=142", "Fugiat dignissimos earum quos voluptatem ut repellat sit eveniet excepturi illum ab voluptatem facilis explicabo libero quo sint optio enim.", null, 307761354, 445, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), "Emard, Cruickshank and Senger", "cross-platform Fantastic Soft Sausages object-oriented" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Norwood Yost", "et", null, "https://picsum.photos/50/50/?image=22", "Expedita nihil soluta accusamus sint dolores sed omnis earum et est distinctio expedita ut voluptate asperiores quam accusantium et cupiditate.", null, 510941172, 899, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), "Maggio, Wiza and Klein", "bluetooth Sri Lanka Rupee Engineer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Marlon Schiller", "quos", null, "https://picsum.photos/50/50/?image=345", "A esse consequatur voluptatem odit voluptatem recusandae dolore repellat consequatur error non facere accusamus non vel dicta ea possimus nulla.", null, 333163989, 285, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), "Harris - Jacobson", "encoding Mauritius Grocery" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Cedrick Baumbach", "dolor", null, "https://picsum.photos/50/50/?image=825", "Iste non consequuntur et labore excepturi aliquid similique dignissimos repudiandae odit voluptatem vel facilis optio necessitatibus unde nesciunt sed eligendi.", null, 473272699, 861, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), "Sanford - Leannon", "plug-and-play Computers Product" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Imogene Crona", "nobis", null, "https://picsum.photos/50/50/?image=174", "Ducimus veniam dolorum vel omnis velit sed quia voluptatibus rem consequuntur aut quibusdam ipsum sit repudiandae voluptatem quia aut rem.", null, 119315221, 251, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "Predovic, Wolff and Veum", "Borders Automotive THX" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Gillian Dach", "ad", null, "https://picsum.photos/50/50/?image=906", "Est veniam itaque laborum culpa officia iure commodi odit cupiditate blanditiis maiores vitae necessitatibus atque quia corrupti et necessitatibus optio.", null, 930872869, 458, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), "Mitchell Group", "definition Glen Throughway" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alvera Padberg", "rem", null, "https://picsum.photos/50/50/?image=739", "Ad minima nobis rerum amet laborum illo nam dicta sed cupiditate est ea eius beatae quis corporis rerum dolor repellat.", null, 386792259, 71, new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), "Friesen and Sons", "Tasty Steel Sausages Function-based invoice" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jimmie Collier", "et", null, "https://picsum.photos/50/50/?image=944", "Quia asperiores repudiandae sunt doloremque vel inventore laudantium ipsum ut expedita consequatur sequi quo quia ipsum quaerat dicta facere occaecati.", null, 400378476, 794, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Altenwerth and Sons", "cross-platform utilize Tasty" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Claudine Gottlieb", "repellat", null, "https://picsum.photos/50/50/?image=787", "Repellendus voluptatem sit ut aut laboriosam hic quia praesentium non non amet ut quisquam quos vel esse temporibus eius eum.", null, 732084787, 704, new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), "Rohan - Stehr", "Designer Generic Granite Cheese software" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ervin Collins", "ad", null, "https://picsum.photos/50/50/?image=96", "Voluptatem et ut magnam aut ratione et est dicta ut pariatur placeat quaerat tempore accusantium voluptatem exercitationem fugiat modi hic.", null, 595649082, 117, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "Dietrich Group", "Architect reintermediate foreground" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Myrtle Bergstrom", "voluptatum", null, "https://picsum.photos/50/50/?image=786", "Voluptatem maiores sequi voluptas earum aliquid et delectus et totam voluptatem et est ut commodi minima quae minus amet exercitationem.", null, 137684781, 195, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "Gutmann - Kerluke", "maximize Tasty Rubber Soap Berkshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kirstin Davis", "et", null, "https://picsum.photos/50/50/?image=1001", "Omnis qui ducimus sunt placeat veritatis itaque voluptatem accusamus maxime impedit enim ipsa dolore ab nihil officia aut ex incidunt.", null, 676273621, 572, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), "Zieme - Franecki", "synthesizing indexing disintermediate" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Julia Rau", "aperiam", null, "https://picsum.photos/50/50/?image=270", "Ea accusamus ea nam quia esse iure id id voluptatum vero natus magnam odio ad libero asperiores quo facilis doloremque.", null, 541963400, 383, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), "Schinner - Wisozk", "Incredible Frozen Gloves International Wisconsin" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Zackery Hudson", "voluptatum", null, "https://picsum.photos/50/50/?image=696", "Similique et debitis esse sit natus veniam veritatis est placeat incidunt ducimus ea inventore consequatur qui libero et nisi mollitia.", null, 729986581, 672, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Abshire - Torp", "Latvia Decentralized Handcrafted Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Moses Konopelski", "excepturi", null, "https://picsum.photos/50/50/?image=623", "Voluptatem architecto nobis nostrum nulla harum ex laboriosam mollitia assumenda voluptatum repellat quisquam fugiat quia inventore voluptates sit deserunt iste.", null, 983101595, 881, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "Kub, Nolan and Walter", "capability Total contingency" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jailyn Heathcote", "libero", null, "https://picsum.photos/50/50/?image=833", "Culpa ea placeat cumque labore tenetur non ut nobis temporibus numquam nihil unde ratione repudiandae voluptatem quasi fuga debitis quia.", null, 374593803, 232, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), "Jacobson, O'Conner and Lubowitz", "Product Licensed Soft Chair Hill" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DUE_DATE",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CHECKED_OUT_DATE",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Johnpaul Moore", "qui", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=837", "Et reiciendis delectus exercitationem voluptatem laborum at adipisci maiores et dignissimos libero quasi quaerat illum quis deleniti cum sapiente sed.", new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Local), 786961622, 766, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), "Rempel - O'Hara", "invoice Summit workforce" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Erling Hermiston", "consequuntur", new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=1064", "Iste et ad quas eligendi voluptas eaque voluptatem autem quod tempora fugiat sint assumenda officiis temporibus cumque quam suscipit aperiam.", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), 683007736, 843, new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Konopelski Group", "explicit New Mexico Multi-lateral" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kylie Hauck", "fugiat", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=388", "Ut rerum sint tenetur esse animi nobis repellendus libero omnis iste et id amet cum reprehenderit tempora nesciunt omnis et.", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), 212295032, 314, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), "Hickle, Kunde and Schamberger", "Creative Generic Fresh Chips Executive" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Palma Koss", "dolor", new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=845", "Perspiciatis distinctio laborum itaque debitis quibusdam rem quos facere ab reprehenderit ipsum illum natus voluptatem assumenda et reiciendis eaque sit.", new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), 805483662, 921, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), "Maggio LLC", "architectures Valleys Legacy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mekhi Brakus", "doloremque", new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=706", "Iure officia dolores praesentium odit soluta autem omnis rerum qui tempore reprehenderit est voluptatem quod dolor atque quos dignissimos eveniet.", new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), 372573685, 829, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "Murphy, McCullough and Carroll", "redundant convergence Course" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Garnet Veum", "vero", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=94", "Doloremque maiores quo consequuntur sit ea illo nobis commodi velit sit unde neque ratione et eum in voluptatibus tempore molestias.", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), 956880373, 147, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), "Sawayn, Toy and Rutherford", "algorithm facilitate Central" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Oleta Berge", "id", new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=370", "Quidem autem magnam natus reprehenderit sed nisi qui autem quas labore repellendus delectus et quam voluptas dolorem adipisci voluptas sit.", new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Local), 148609132, 499, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "Dooley, Bartoletti and Rolfson", "Tunisian Dinar fuchsia indigo" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jordane Tromp", "explicabo", new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=432", "In consequatur quod tempore ipsa non id aliquid quia quis temporibus exercitationem necessitatibus voluptas veniam quo quo non ipsum porro.", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 574154299, 169, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), "Zemlak - Conroy", "teal Investment Account Rustic" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sydni Dare", "excepturi", new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=697", "Vel dolorum qui voluptas dolorem voluptatem non aut eveniet excepturi est dolor distinctio quia ipsa ex cum est culpa non.", new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), 784132636, 368, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), "Hills - Morar", "Outdoors Intranet Planner" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Molly Kunze", "inventore", new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=385", "Voluptas repellat ipsum quo voluptate rerum praesentium et et pariatur accusamus cum sunt consequatur voluptatum earum sit numquam voluptatem voluptas.", new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), 273730644, 799, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), "Rippin Inc", "Research Courts ADP" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Wendell Bahringer", "sed", new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=588", "Doloremque beatae fugiat nihil ducimus culpa enim velit quia a error quia vitae repudiandae ut natus quod cupiditate pariatur aliquid.", new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Local), 288294544, 451, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), "Turcotte Inc", "Georgia protocol port" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Casandra Lind", "eligendi", new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=914", "Fugit expedita beatae consequatur itaque sit voluptates est alias quidem hic rerum sint et voluptatibus atque est doloribus magnam eveniet.", new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), 661415381, 846, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), "Zulauf - Runolfsson", "Refined Refined Plastic Chicken Incredible Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Erling Windler", "vero", new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=163", "Natus sit itaque iusto fugit laboriosam eum voluptas expedita aut id qui ex assumenda voluptatem nemo facere sapiente cupiditate veritatis.", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), 999484002, 277, new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "Macejkovic, Trantow and Hagenes", "invoice monetize Idaho" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Emmanuelle Fisher", "eveniet", new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=59", "Debitis ullam mollitia ut atque rem sit quam quia voluptatem quis dolor ut autem repudiandae non nihil hic qui aperiam.", new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), 310405193, 543, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Doyle, Larkin and Kilback", "deploy green parsing" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Colin Heller", "eum", new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=102", "Doloribus dolore illo assumenda aliquam rerum fugit vel modi odit incidunt totam minima possimus consequatur veritatis voluptates quaerat consequatur quia.", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), 177122434, 870, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), "Oberbrunner - Muller", "Money Market Account compressing hacking" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Anthony Gerhold", "modi", new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=882", "Voluptatem et nobis voluptas provident qui sint dolor repudiandae sunt rerum perferendis eum est nemo eius vel quia facere nihil.", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), 385307914, 127, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), "Stiedemann - Leffler", "Innovative context-sensitive Washington" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Cullen Douglas", "quod", new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=621", "Quis quo occaecati ea ducimus non et quasi vel accusantium et aperiam ducimus quia quae asperiores eveniet ut neque architecto.", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), 980488860, 543, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Local), "Jenkins, Ratke and Gorczany", "optical complexity Guatemala" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jamarcus Feeney", "sed", new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=446", "Enim quam laudantium qui voluptatibus accusamus et eum earum cumque eos facilis est autem fugiat ut fuga sapiente quo a.", new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), 235722980, 170, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Rath, Auer and Thiel", "bandwidth Pula Stravenue" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Emmett Beer", "ullam", new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=577", "Minima ut necessitatibus dolorem possimus quia molestiae delectus reiciendis quos sed debitis autem et est iure voluptatum id eum quas.", new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), 869418177, 894, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "Rau Group", "Multi-layered Berkshire Tactics" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Oren Schoen", "eius", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=933", "Odio a autem dicta mollitia quasi ut aperiam dolor sed cum eos quam perspiciatis asperiores esse porro facilis quisquam excepturi.", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), 515560370, 217, new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), "Glover and Sons", "Trail GB Isle" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hillard Brekke", "voluptate", new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=28", "Similique nemo est placeat et cupiditate et non dicta aut ut doloribus et aliquam aliquid ea velit commodi recusandae velit.", new DateTime(2023, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), 790340205, 218, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Gottlieb, Hamill and Marks", "Nuevo Sol Cambridgeshire applications" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dolores Simonis", "soluta", new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=96", "Distinctio voluptatem et nihil aut necessitatibus voluptatibus corporis sunt voluptatem qui harum est delectus dignissimos cum ut quisquam magni enim.", new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Local), 672273723, 996, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), "Reilly - Lowe", "Infrastructure Skyway Senior" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dallas Langosh", "mollitia", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=1019", "Enim laudantium eaque et consequuntur voluptatem modi qui veniam occaecati aut vitae nihil ut est eligendi voluptas qui quia ut.", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), 647201397, 163, new DateTime(2024, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), "Hodkiewicz, Beer and Weimann", "Fantastic Plastic Mouse XML Tasty Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Maudie Russel", "magnam", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=813", "Reprehenderit aut assumenda deserunt veniam voluptatem excepturi exercitationem in quae quam enim modi voluptatem qui ab voluptatem minima facere beatae.", new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), 538548189, 272, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), "Kunde, Schowalter and O'Conner", "Handmade Soft Chips reintermediate Port" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Angelita Mueller", "tempore", new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=1019", "Mollitia occaecati laboriosam sunt cupiditate inventore aut et dolorem esse quibusdam sit modi recusandae et nemo delectus qui accusantium molestiae.", new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Local), 867574740, 258, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), "D'Amore - Greenfelder", "primary Unbranded Rubber Ball Zimbabwe Dollar" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Audie McCullough", "voluptas", new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=672", "Quo assumenda et autem ut saepe omnis sint nulla ea sit quo illum consequatur aperiam maxime eum dolores aut nisi.", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), 352784262, 490, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Runte Group", "ubiquitous synthesizing Handcrafted Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Irwin Corwin", "sit", new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=87", "Incidunt impedit voluptatem dolore quo est expedita error sit nihil qui aut magnam repellat est voluptate recusandae velit error facere.", new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), 156521018, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "Romaguera - Greenholt", "payment bypass hack" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Cali Ruecker", "ut", new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=237", "Blanditiis suscipit vitae eos et odio non minus aliquam aut eligendi rem quo laboriosam qui veniam vel qui totam alias.", new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), 660109563, 448, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), "Reynolds and Sons", "optical Cote d'Ivoire streamline" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Theresia Runolfsson", "minima", new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=205", "Tempora accusantium quos praesentium facilis eaque quia dolorem et voluptatibus provident ex quam eaque qui dolores quia aut laborum voluptates.", new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), 965812759, 366, new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Local), "Toy, Daniel and Hills", "AGP Dalasi enable" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Wanda Paucek", "consequuntur", new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=230", "Ea voluptatem fuga occaecati autem rem est aspernatur rerum in dolorem ipsa et repudiandae unde corporis eaque consequuntur tempore non.", new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), 192505453, 391, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Local), "Mertz, Rowe and Daniel", "Strategist Future-proofed grey" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jody McLaughlin", "itaque", new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=776", "Fugiat quia quidem rerum dolorem nam quia nostrum sunt id illum ab iure autem natus earum architecto esse tempora inventore.", new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), 337770147, 619, new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "Abshire, Rath and Durgan", "Avon compressing Officer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Leone Koepp", "suscipit", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=118", "Velit omnis eos laborum accusantium alias esse ut praesentium quidem a omnis totam eos nulla eaque ducimus maxime est quibusdam.", new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), 277834678, 686, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Local), "Von, Toy and Abshire", "Regional target compress" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Skylar Abbott", "vel", new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=305", "Sed voluptas qui iusto dolorum impedit nostrum voluptate optio sed repellat pariatur totam sapiente possimus vero dolor dolor eius a.", new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), 556676871, 772, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), "Mayert - Haag", "calculate vortals RSS" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Aurelio Morissette", "corrupti", new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=320", "Quia provident ipsa numquam tenetur alias ad quaerat quidem voluptatem officiis vel est commodi ullam et et illo suscipit necessitatibus.", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), 110681685, 126, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), "Wintheiser - Upton", "Awesome Cotton Bacon user-centric Designer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Gust Schaefer", "quas", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=993", "Voluptatum quae aut qui voluptatem consectetur sed quasi sequi vitae et architecto vero quos voluptatum non odit voluptate qui sed.", new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Local), 487937784, 589, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), "Turcotte, Williamson and Larson", "mission-critical Rubber scale" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sydnie Grady", "labore", new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=206", "Omnis vel sapiente fugiat harum architecto magnam et dolores tempore hic consequatur corporis autem deserunt atque aut et ut quia.", new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), 696060459, 494, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "Hahn, Murray and Conroy", "syndicate lavender flexibility" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Chandler Rau", "sint", new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=524", "Nulla eligendi temporibus maiores assumenda ut recusandae explicabo aut ea illum suscipit ipsum asperiores dolorem est et esse dignissimos omnis.", new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), 629406162, 398, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), "Rau - Rice", "convergence Representative bandwidth" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Carroll Strosin", "at", new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=727", "Dolor cumque perferendis optio nihil consequatur aliquam laboriosam omnis est vel at rerum mollitia non culpa optio vel quia inventore.", new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Local), 329099144, 779, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Local), "Schowalter, Kovacek and Boyle", "Kyat silver Fresh" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Earline Koch", "repellat", new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=539", "Consequuntur nemo reprehenderit praesentium tempore fugiat iure quae itaque et quis maxime harum in in voluptatem praesentium impedit impedit id.", new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), 311310261, 764, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), "Lemke - Kutch", "bypassing Ergonomic Unbranded Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Geovany Moen", "culpa", new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=446", "Commodi et qui aut ut aliquam consequuntur rem dolorem sed sit eos quibusdam perspiciatis ut labore iste est voluptas fugiat.", new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), 173604268, 832, new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "Langosh and Sons", "Small Concrete Computer calculate Kids" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Shyanne Feeney", "ducimus", new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=196", "Tenetur et sunt iusto rerum vel doloremque nam eius voluptatem praesentium est ut corporis inventore sunt incidunt rerum qui ad.", new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), 485269178, 788, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), "Buckridge - Cruickshank", "quantifying Refined Fields" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Brady Bauch", "quia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=265", "Minima dolores perferendis odio hic labore dolorum quia enim sequi qui qui qui veritatis similique rerum et laudantium pariatur magnam.", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), 737856687, 729, new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), "Fritsch, Kris and Price", "Strategist New Zealand Dollar Officer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Beau Gutkowski", "impedit", new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=797", "Sed aut nam voluptatem voluptas et consequuntur molestiae aspernatur sunt et aliquam velit voluptas aut quis modi magni et rerum.", new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 674466611, 404, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "Herzog, Hilpert and Steuber", "Practical Rubber Bacon Drives Street" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Barry Kling", "iure", new DateTime(2023, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=894", "Possimus voluptatibus est fugiat numquam aut repudiandae rerum nulla beatae nostrum debitis recusandae culpa distinctio perferendis placeat qui tempora eos.", new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), 386611192, 749, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "Hauck and Sons", "Rhode Island payment sky blue" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Deontae Ullrich", "laboriosam", new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=825", "Hic qui facere perspiciatis commodi ipsam mollitia illo minima quisquam fugit velit id reiciendis qui dolores voluptatem quos voluptate corporis.", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), 695302823, 857, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "Abbott - O'Reilly", "Baht quantifying Sleek" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Colin Prosacco", "in", new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=569", "Voluptatum laudantium ipsa magni itaque molestiae omnis cupiditate fuga facilis quia veniam sapiente nostrum qui sunt dignissimos quasi sit aliquid.", new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), 146001292, 153, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), "Walker - Fritsch", "Forward Tennessee multi-byte" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Terrell Ratke", "modi", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=880", "Ea blanditiis officiis sunt suscipit sed voluptatem reprehenderit blanditiis voluptas sapiente amet distinctio a nostrum quibusdam unde id sint molestiae.", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), 439905347, 929, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), "Stroman, Dickinson and Abshire", "monetize payment web services" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Randal Willms", "nemo", new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=557", "Harum perspiciatis ipsum facilis at totam ex occaecati est officiis iure qui perspiciatis ut consequatur reprehenderit sunt qui est a.", new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Local), 236850911, 320, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), "Wilderman LLC", "Concrete connecting Club" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Darren Wisoky", "excepturi", new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=1072", "Dolorem ipsum id eius harum ex odit animi exercitationem temporibus iste est necessitatibus ut rerum omnis et dolor sed aspernatur.", new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), 229153592, 214, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "Jacobi - Feil", "Metal pink Nakfa" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Houston Mosciski", "est", new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=424", "Magnam at aut qui error explicabo ipsum aut dolorem laborum aliquid quasi tenetur eius reprehenderit quidem ea ut blanditiis perspiciatis.", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), 542706290, 781, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "Renner, Armstrong and Morar", "Handcrafted Metal Keyboard leverage back-end" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Judge Crona", "cupiditate", new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=942", "Sequi totam explicabo sint quasi quia sequi dolor odit iusto iste et architecto ut quia quis eaque aut ex maiores.", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), 458339536, 183, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "Schoen and Sons", "Fantastic Wooden Pants black port" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Wilfredo Cartwright", "rerum", new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=1025", "Cum cum voluptas nemo dolorum neque nesciunt nihil neque laborum velit asperiores officia dolores aut soluta eum molestias quisquam tempore.", new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Local), 604245900, 330, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "Hudson - Simonis", "Locks ADP collaborative" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Yadira Krajcik", "quia", new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=69", "Sed consequatur totam velit qui sequi ducimus velit dolorem voluptatibus quia mollitia asperiores veritatis aut exercitationem eum dolorem veritatis ratione.", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), 485139112, 860, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), "Ziemann - Mills", "Agent New Mexico Tennessee" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Tia Mills", "iste", new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=651", "Dicta nobis nostrum nulla rerum quis ducimus soluta ut omnis dolor et eveniet harum quasi corporis vitae quo iure nihil.", new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), 738548757, 976, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), "Schumm Group", "indexing Granite Intelligent" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sidney Torphy", "alias", new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=393", "Ipsam id voluptatem et modi ipsam dolores perspiciatis modi ducimus delectus dolorem eos est in exercitationem hic iure consequatur quo.", new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), 204550108, 397, new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), "Gerlach - Stroman", "connect killer Rubber" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Erna Monahan", "veritatis", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=135", "Omnis consequatur ipsa fugiat culpa ab debitis veritatis officiis dolor neque quas repellendus et aut molestiae eaque debitis voluptatibus animi.", new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), 733917117, 610, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), "Ortiz - Windler", "Moroccan Dirham US Dollar Checking Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ceasar Littel", "repudiandae", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=119", "Nostrum quibusdam non et maxime earum molestiae inventore rerum eligendi fugit neque aut delectus minus maiores sunt blanditiis est enim.", new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), 510914022, 448, new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), "Bins Group", "Handmade Soft Towels paradigms Tasty Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Deron West", "quis", new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=674", "Laudantium eum est ea labore sapiente praesentium cupiditate suscipit repudiandae sed natus sed ex assumenda sed minima qui inventore fuga.", new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Local), 783292910, 871, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), "Brakus Inc", "Massachusetts online throughput" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Veda Robel", "corrupti", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=967", "Debitis sunt est nam dolores ratione error enim incidunt esse cum rerum fugiat rerum accusamus quis in modi distinctio voluptas.", new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), 757377143, 899, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Reichel Group", "Communications Guam synthesize" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Genesis Zemlak", "doloremque", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=528", "Eum error sit quis in quidem adipisci assumenda voluptatem non possimus dolore quae aperiam repellat quod ex quo labore rerum.", new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Local), 297153617, 461, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "Grimes and Sons", "redundant deposit Re-contextualized" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Johnpaul Ferry", "consectetur", new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=935", "Debitis aliquam earum quasi ut quo eos sunt quod illum ab ipsum debitis et quidem et molestias nemo eos dolorem.", new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Local), 374858752, 425, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Koch Inc", "e-services TCP mission-critical" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Quincy Hickle", "nesciunt", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=53", "Sapiente quod suscipit facilis consequuntur tenetur et ad odit fugit enim non eos corporis ex distinctio accusantium nemo eos voluptate.", new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), 356192010, 912, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), "Grimes - Hauck", "Operative olive PCI" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Maxwell Lebsack", "et", new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=730", "Quo et consequatur aliquam distinctio eveniet molestias reprehenderit aliquid unde iste excepturi error in illum optio ex omnis debitis voluptas.", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), 426606039, 463, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), "Von, Metz and Kuvalis", "digital systems Latvian Lats" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Braden Connelly", "in", new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=335", "Ea hic et ut sit quidem voluptates reprehenderit dolorem inventore qui non adipisci repellendus dolore eum dolorem aspernatur corrupti odit.", new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), 319704483, 773, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "Monahan, Koelpin and Howe", "Checking Account leading edge synergies" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Anissa Mohr", "rem", new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=330", "Tempora sit aspernatur qui iusto vitae cumque laudantium eos explicabo perferendis voluptatem repudiandae dolor quas quasi corporis molestiae dignissimos ea.", new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Local), 650899800, 761, new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), "Upton, Reynolds and Little", "Bridge deposit Plaza" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ressie Rohan", "architecto", new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=686", "Maxime ut velit iure qui in quasi laboriosam totam quas assumenda neque vel assumenda laudantium vel possimus doloribus aut asperiores.", new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), 955812091, 213, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "Wolf Inc", "Directives bus copying" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Monroe Ernser", "et", new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=929", "Est aut debitis tempora totam quae similique omnis temporibus consectetur iusto omnis sit quis pariatur provident doloribus vel consequatur velit.", new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Local), 813298511, 766, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "Fadel - Klocko", "Cambridgeshire Jersey human-resource" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Daisha Bahringer", "autem", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=671", "Et dolor optio temporibus incidunt et possimus distinctio minus ut eum laudantium eveniet corrupti similique aut et nobis velit incidunt.", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 861699634, 905, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), "Labadie, Walker and Hickle", "alarm systematic Singapore" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kay Gorczany", "explicabo", new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=239", "Aut et qui numquam incidunt sit atque porro incidunt natus vel aperiam est sint qui ducimus aperiam est qui doloremque.", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), 344251671, 996, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), "Treutel Inc", "Guinea-Bissau circuit process improvement" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Arianna Pouros", "qui", new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=909", "Facere exercitationem cum ut consequuntur consectetur commodi temporibus quia quod aspernatur est ut quo sint saepe enim omnis debitis exercitationem.", new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), 160514272, 646, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), "Torphy Group", "next generation Egypt Fantastic Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Orlo Kessler", "magnam", new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=56", "Temporibus dolor laborum blanditiis amet sunt esse nulla illum doloremque at sed omnis sunt est consectetur aut ducimus recusandae voluptas.", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 231100379, 838, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "Ziemann - Schaden", "Refined Steel Hat value-added sky blue" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Domingo Waters", "quibusdam", new DateTime(2023, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=535", "Veniam porro nulla vitae perferendis architecto eos possimus beatae eveniet et quia veniam sit nemo dolor non sit quia magni.", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), 837895749, 789, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), "Rodriguez LLC", "Russian Ruble Zloty knowledge base" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Moises Toy", "ullam", new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=652", "Sequi laborum dolor voluptas voluptas maxime alias deleniti quo facilis aut et pariatur non officia quasi omnis pariatur sequi eveniet.", new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 280028078, 912, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), "Kassulke Group", "Zloty Tanzania circuit" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Danial Larkin", "necessitatibus", new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=952", "Dolorem suscipit odit officia ut dolor sed quibusdam voluptates asperiores sapiente aspernatur voluptatem rem praesentium optio aut odit ea quo.", new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), 631824437, 280, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), "Swift Group", "quantify AGP transmitter" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dakota Miller", "nobis", new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=981", "Eos labore officia enim est omnis est eveniet pariatur aut amet veniam omnis libero neque aut unde dolore beatae voluptatibus.", new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), 167253441, 408, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), "Lakin - Emard", "Bridge Cotton Awesome" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Stefanie Lindgren", "enim", new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=748", "Necessitatibus ut eos aut est rem atque voluptatem quia repellendus unde praesentium maxime saepe pariatur fugiat dolorem nam rerum dicta.", new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), 941705037, 875, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "Mraz, Dach and Muller", "input Singapore back-end" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alphonso Connelly", "nesciunt", new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=1", "Maxime sapiente accusantium quia officia minima rem porro error vitae minus beatae magni reiciendis ut consectetur ea dolorem libero animi.", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), 537620031, 678, new DateTime(2023, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), "Lynch - Cole", "lavender Road system" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dayna Hettinger", "eum", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=472", "Autem aut veritatis est in sunt iure eius iure odit autem dicta itaque dolorem enim modi culpa accusantium illum quia.", new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), 965276157, 821, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), "Rosenbaum Inc", "Money Market Account Tasty Fresh Cheese Administrator" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Adrianna Lowe", "ea", new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=389", "Ea veniam dolorum est eum iste aliquid similique aliquam aut magni eveniet voluptas autem velit id aut labore minus perferendis.", new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), 230299895, 353, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), "Gorczany - Lindgren", "Manager Small Producer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Easter Hand", "iste", new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=486", "Omnis aut dignissimos delectus quis qui in qui nisi ipsum harum minus architecto maxime ea sit expedita doloremque sed pariatur.", new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), 415915823, 111, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Local), "Prohaska, Roob and Boyle", "Auto Loan Account XML Isle" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Henriette Altenwerth", "quasi", new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=469", "Soluta sequi quasi inventore qui natus ut officia voluptatibus nihil at aperiam id nihil aspernatur enim occaecati excepturi beatae neque.", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), 413035921, 197, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), "Franecki - Stark", "Iceland 24 hour Consultant" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Elenor Brekke", "dolor", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=964", "Quia quia explicabo dolores ab omnis itaque quidem porro nemo ut repellendus id consectetur consequuntur facilis aspernatur illo porro non.", new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), 697584086, 747, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), "Howe - Hermann", "Field Fantastic Soft Keyboard Terrace" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Tremayne Collins", "eius", new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=377", "Laborum assumenda temporibus possimus nihil nobis reiciendis ipsa voluptatem aspernatur eaque fugiat dolores placeat voluptas et vel possimus labore dolor.", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), 763852516, 804, new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), "Kemmer, Bernier and Hauck", "engineer communities Virginia" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Madyson Nicolas", "voluptatibus", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=78", "At ut veritatis expedita ipsum fugiat harum vel aliquid rem aut sint ratione veritatis eius eaque placeat quia ut asperiores.", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), 548590148, 106, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), "Carroll, Hirthe and Trantow", "Awesome hack Home Loan Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Shania Hartmann", "quia", new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=831", "Occaecati deleniti placeat sint consectetur quo aut saepe quod eos sunt pariatur quos possimus minima hic qui ducimus perspiciatis animi.", new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), 401717504, 90, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), "Sawayn Group", "strategic Handmade Court" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mireya Bernier", "nostrum", new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=982", "Accusantium natus aut ipsa impedit accusamus consequatur sint non molestiae eaque illum nobis corrupti earum dolorum ut aliquid consequatur sequi.", new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), 223965866, 222, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Local), "Padberg Inc", "Iowa optimal Delaware" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Timmy Fay", "est", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=850", "Velit est vero eveniet dolor et libero est nobis voluptate adipisci illo eligendi libero aspernatur minima eum quis animi quo.", new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), 272539720, 279, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), "Rau - Hessel", "PNG Avon EXE" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Shanon Reynolds", "in", new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=890", "Est maiores mollitia optio velit et distinctio at sint sed enim velit voluptas et velit natus aliquid autem tempora cum.", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), 276326390, 563, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Kutch, Hirthe and Crist", "Configurable Administrator Architect" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hollis Haag", "nam", new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=833", "Autem quia iusto iste eveniet eos natus sequi dolorem ipsam quia necessitatibus cumque nobis deleniti enim placeat aut aliquid aut.", new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 353715171, 101, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), "Dibbert, Moore and Satterfield", "Factors Handmade Soft Fish Borders" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Bo Borer", "excepturi", new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=1010", "Recusandae sit illum omnis impedit voluptatibus et aut in quasi pariatur totam consequuntur est ab dolores enim nihil velit illum.", new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), 300551401, 750, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), "Frami, Spencer and Monahan", "payment alarm syndicate" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jessy Braun", "dolore", new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=766", "Libero eos quo deleniti aliquam officia est soluta reiciendis aut ut magnam error fugiat sit excepturi dolorem quos unde tempore.", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), 549994793, 895, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "Wunsch, Towne and O'Reilly", "Extensions model Handcrafted Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Harrison Schneider", "tenetur", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=161", "Officiis fugiat sit suscipit tempora eaque distinctio rerum eligendi perspiciatis dolorem omnis quo velit sint exercitationem expedita aliquid et itaque.", new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), 499989026, 234, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "Wyman - Denesik", "Fantastic Metal Shoes Gorgeous Granite Car firewall" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sunny Kreiger", "ut", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=390", "Ut quos autem quasi reprehenderit laborum eum est velit quasi maxime libero labore excepturi sed qui corrupti et inventore fugiat.", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 132611011, 523, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), "Hettinger, Ratke and Collins", "panel calculate orchid" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Aliyah Miller", "vitae", new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=649", "Est dolorum aut sint molestiae eius optio pariatur sunt rerum qui id vel quia cumque recusandae nihil voluptate et ipsum.", new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), 790375345, 783, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "Brown Inc", "multi-byte Extended Michigan" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Amelia Harris", "quisquam", new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=321", "Ut sequi nostrum facilis voluptas et labore maxime animi quod autem illum porro est sunt hic voluptatibus vitae praesentium doloremque.", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 204346782, 904, new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Local), "Kerluke Group", "Lithuanian Litas grow Lane" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Milton Terry", "officiis", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=168", "Provident sed id nostrum vitae aliquam ea corrupti amet iure odit voluptatibus est sunt est ut et dolorem aut similique.", new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), 334585602, 249, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), "Hettinger, O'Keefe and Maggio", "Direct Savings Account Canyon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Oswald Cruickshank", "nihil", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=205", "Eum veritatis repellat architecto praesentium eveniet labore quia sed quas iure sunt officia velit quia quam placeat mollitia velit aliquam.", new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), 286586073, 619, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Local), "Weissnat - Leuschke", "panel Cambridgeshire Sri Lanka Rupee" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Marshall Jenkins", "culpa", new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=956", "Voluptatem repellendus ut est officia ut accusamus distinctio consequatur laborum voluptas exercitationem est mollitia in neque omnis voluptas animi id.", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), 617376439, 65, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Keebler - Mann", "New Jersey Solomon Islands Dollar neural" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jeffrey Towne", "voluptates", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=116", "Molestiae sequi aut eligendi voluptatem voluptas ut aut rerum vitae iure dolor et perferendis et qui tempora enim tenetur recusandae.", new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), 808800576, 672, new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), "Tromp - Mraz", "cyan Central Sleek Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "AUTHOR", "CATEGORY", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Brennon Hintz", "ipsum", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "https://picsum.photos/50/50/?image=451", "Pariatur vel veniam dolorum quam ea reprehenderit eum at delectus nostrum vero repellendus nostrum praesentium ea voluptas quos dolorum vitae.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), 987756071, 470, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "Bosco LLC", "El Salvador Colon methodologies JSON" });
        }
    }
}
