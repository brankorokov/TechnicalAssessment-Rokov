using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechnicalAssessmentRokov.Migrations
{
    /// <inheritdoc />
    public partial class ChangePhotoSource : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Eleazar Hagenes", "et", "https://picsum.photos/640/480/?image=1067", "Unde dolores rerum aperiam quisquam mollitia ut quam cum nisi nihil eaque vitae recusandae molestiae nisi eos modi cupiditate et.", 181794752, 987, new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "Howe, Moen and Roob", "salmon Small Granite Bike Metal" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Conor Weber", "rerum", "https://picsum.photos/640/480/?image=388", "Magni est magnam reprehenderit vel animi aspernatur dolores magnam aut ut placeat ab ut unde quo rerum animi ex labore.", 845769205, 651, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "Veum - Graham", "Grove Legacy invoice" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Cassandre Fadel", "rerum", "https://picsum.photos/640/480/?image=62", "Corrupti et velit in in maiores voluptatibus veritatis blanditiis et dicta nostrum quibusdam at doloribus possimus dolores rerum a consequatur.", 786798847, 411, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "Mueller, Zieme and Cummerata", "Group EXE deposit" });

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
                columns: new[] { "AUTHOR", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Marcel Homenick", "https://picsum.photos/640/480/?image=89", "Possimus id nisi ab distinctio quia quia et nobis sequi minima et aut eos deleniti deleniti odio quasi velit autem.", 986074058, 381, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), "Larkin - Reilly", "Consultant Officer Hill" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Toni Dibbert", "est", "http://lorempixel.com/640/480/sports", "Ducimus reprehenderit eligendi consequuntur ut minima incidunt facere ducimus tempora et quis asperiores sed assumenda quasi est iste doloribus veritatis.", 620981663, 709, new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), "Reichert, Rice and Fay", "North Korean Won Assistant Triple-buffered" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ulises Lockman", "expedita", "http://lorempixel.com/640/480/nightlife", "Dolor sint sit enim sit facilis fuga consequatur magni tenetur inventore ipsum eius est sed distinctio nostrum quia ab dolorem.", 478710962, 451, new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), "Kuphal - McGlynn", "metrics Neck violet" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mathias King", "unde", "http://lorempixel.com/640/480/cats", "Necessitatibus dolorem inventore similique in quaerat adipisci fugit saepe quia sit placeat distinctio molestiae repellendus quam vero saepe in natus.", 814037030, 125, new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), "Hansen, Legros and Jerde", "Fork card Group" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mattie Bayer", "voluptate", "http://lorempixel.com/640/480/nature", "Maiores in sit ad et doloribus eveniet dicta iusto et eaque delectus ut non quidem numquam dolorem eaque dolore voluptates.", 676104445, 189, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), "Beier Inc", "Course open-source Chief" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Deven Smith", "saepe", "http://lorempixel.com/640/480/transport", "Esse aut et et consequuntur suscipit similique qui aperiam voluptate fugiat sed illum rerum blanditiis asperiores iure eum dolorum et.", 428713386, 877, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "McKenzie - Donnelly", "sensor 24/365 cyan" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Vince Zieme", "necessitatibus", "http://lorempixel.com/640/480/people", "Sequi temporibus consequatur omnis eos atque consequatur earum ut qui ut similique quo aut et incidunt et totam quod laboriosam.", 114993966, 266, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "Schneider - Wolf", "Sleek Steel Chips Reactive Monitored" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Stanley Collins", "dignissimos", "http://lorempixel.com/640/480/transport", "Numquam minima quos voluptate ea quaerat pariatur earum maxime voluptatem et non nostrum eveniet et natus velit nam id voluptas.", 786641385, 711, new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "Fadel, Skiles and Schmeler", "Handcrafted Rubber Fish Progressive North Dakota" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Norris Miller", "quam", "http://lorempixel.com/640/480/sports", "A qui doloribus voluptates ipsa quisquam provident vel minus illum voluptatibus impedit voluptatum dolor praesentium libero et est voluptates quia.", 318921706, 735, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "Nitzsche - Cruickshank", "Money Market Account calculating Home" });

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
                columns: new[] { "AUTHOR", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hollie Farrell", "http://lorempixel.com/640/480/nightlife", "Molestiae reiciendis blanditiis ut totam fuga soluta debitis omnis aliquid quo aut officia a excepturi et pariatur sit nulla excepturi.", 779508067, 336, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "Cormier - D'Amore", "6th generation Dynamic quantify" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Delbert Erdman", "aut", "http://lorempixel.com/640/480/business", "Officia hic totam quia ipsam earum vel saepe unde molestiae recusandae saepe ratione enim voluptas ab laborum quia excepturi possimus.", 340443796, 906, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), "Schinner - Breitenberg", "strategic Intelligent purple" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ryder Kilback", "soluta", "http://lorempixel.com/640/480/sports", "Iusto mollitia numquam laborum autem molestiae voluptatem et doloremque tempora enim voluptatem non officia sint rem pariatur itaque sed voluptatum.", 960753123, 486, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "Barrows Group", "compressing interfaces alarm" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Loyal Rempel", "nemo", "http://lorempixel.com/640/480/cats", "Delectus atque qui quidem recusandae numquam at dolorum nisi dolor ipsum ab eos veritatis delectus qui dolor corporis incidunt corporis.", 299409901, 883, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), "Price Group", "Cove virtual benchmark" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jody Lowe", "eveniet", "http://lorempixel.com/640/480/animals", "Quas maiores error unde reprehenderit facilis soluta fuga in sint doloribus ipsam cum natus alias aut voluptate occaecati dolores dolor.", 260630870, 468, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Local), "Renner, Satterfield and Brown", "Guyana Dollar synthesize Division" });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Beverly Hilll", "aut", "http://lorempixel.com/640/480/food", "Incidunt sed ducimus sit sit iste non fuga soluta repudiandae odit adipisci earum aut reiciendis voluptatem molestiae labore eaque officia.", 532070236, 470, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), "Frami, Zemlak and Ullrich", "Supervisor Sleek Concrete Ball Port" });

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
    }
}
