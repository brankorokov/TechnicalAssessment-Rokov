using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechnicalAssessmentRokov.Migrations
{
    /// <inheritdoc />
    public partial class AddingIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jo Beahan", "et", "https://picsum.photos/50/50/?image=648", "Occaecati modi quas adipisci enim consectetur distinctio repudiandae asperiores modi dolor ab dolor illum omnis et ut et illum est.", 260040629, 520, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "Konopelski, Streich and Cormier", "Group models artificial intelligence" });

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
                columns: new[] { "AUTHOR", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Cole White", "https://picsum.photos/50/50/?image=856", "Esse perspiciatis quis sed sunt quo ab doloremque rem voluptas omnis omnis necessitatibus amet velit atque possimus porro quis consequatur.", 209565571, 397, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Local), "Douglas - Bradtke", "Gardens back-end Open-architected" });

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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Zella Waters", "reprehenderit", "https://picsum.photos/50/50/?image=951", "Totam omnis nam animi hic earum dolores omnis labore magnam possimus natus hic beatae ab et veritatis nobis ea et.", 404662840, 370, new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "Green - Satterfield", "Oklahoma driver Handmade Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hassan Green", "impedit", "https://picsum.photos/50/50/?image=457", "Ipsa est magnam incidunt sit quia eveniet quibusdam recusandae asperiores voluptate est dolores dolores consequatur et nobis iste doloremque et.", 347719743, 826, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "Wehner - Cormier", "Albania disintermediate Analyst" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kenneth Brakus", "molestias", "https://picsum.photos/50/50/?image=27", "Sint reiciendis assumenda dolores molestiae modi nisi soluta non sunt ut a voluptatem maxime aut exercitationem minima eos pariatur saepe.", 785997234, 591, new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), "MacGyver, Morar and Daniel", "dynamic Forest Metal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Maynard Wehner", "et", "https://picsum.photos/50/50/?image=840", "Molestiae veritatis quidem ea deleniti saepe labore voluptatem non consequatur voluptatem eius corporis atque dicta rerum blanditiis veritatis qui non.", 358401009, 489, new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), "Lind and Sons", "French Southern Territories brand Crest" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Randal Gulgowski", "placeat", "https://picsum.photos/50/50/?image=1081", "A aliquid maxime provident cum ut consectetur sit commodi omnis tempore et non iusto dignissimos voluptas magnam ullam aperiam ut.", 571354335, 986, new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), "Schaden, Aufderhar and Borer", "Officer Views synthesize" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Monty D'Amore", "illum", "https://picsum.photos/50/50/?image=845", "Est omnis consectetur amet recusandae eius quis rerum blanditiis illo tempore eaque eaque voluptatem error quia sequi perspiciatis cupiditate corrupti.", 250736792, 644, new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), "Gerlach - Schulist", "next generation Tunnel Extension" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Katlyn Rogahn", "autem", "https://picsum.photos/50/50/?image=272", "Expedita unde vero dolores nemo rerum sint facere et inventore aperiam mollitia delectus consequatur et et sed quia in praesentium.", 241698682, 531, new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Local), "Kihn, Leffler and Hickle", "Sleek Plastic Mouse collaboration dedicated" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Marlon Frami", "minima", "https://picsum.photos/50/50/?image=13", "Qui et qui dolorum voluptas et nihil commodi quae ea aut praesentium odio cumque tempore repellat laboriosam est ipsam velit.", 300991162, 932, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), "Schmeler Inc", "Colorado backing up Arkansas" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Olga Shields", "cupiditate", "https://picsum.photos/50/50/?image=1081", "Voluptatum doloribus sit rerum officiis deleniti magnam molestiae nulla ut voluptatibus odit ratione harum a voluptas id dignissimos sunt sit.", 497401294, 694, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "Padberg, Jenkins and Nicolas", "Interactions SSL Refined Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Romaine Rowe", "at", "https://picsum.photos/50/50/?image=286", "Quo voluptate vero harum maxime occaecati debitis necessitatibus fugit dolorum doloribus numquam at debitis quis vel unde modi vel commodi.", 956390999, 107, new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "Zboncak LLC", "invoice Clothing & Games encryption" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hyman Hills", "quidem", "https://picsum.photos/50/50/?image=186", "Nemo nemo nulla culpa voluptate ut eos id molestiae beatae rem et quia eveniet enim aut nulla molestiae omnis quos.", 467552270, 479, new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), "VonRueden, Bauch and Prohaska", "deliver Hawaii Associate" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sister Smitham", "eaque", "https://picsum.photos/50/50/?image=113", "Alias velit provident aut quas et reiciendis labore molestiae quia amet doloribus dicta id vero unde tenetur beatae nobis doloremque.", 662027752, 800, new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), "Wyman - Quitzon", "Knolls Liaison Planner" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mike Torphy", "est", "https://picsum.photos/50/50/?image=287", "Voluptatem quibusdam omnis iusto et ut in quibusdam eligendi dignissimos officia dolore libero et dolorem rerum omnis natus consequatur amet.", 116969906, 363, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Local), "Lubowitz - Bosco", "transmit deposit copying" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Maryse Hammes", "aut", "https://picsum.photos/50/50/?image=307", "Qui dolores quis velit unde voluptatem voluptas quia voluptates quis voluptates numquam eum voluptatem officiis excepturi error odit ex aut.", 345078156, 268, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), "Hintz, Koss and Kerluke", "Borders Gibraltar Pound SCSI" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Camron Blick", "ut", "https://picsum.photos/50/50/?image=613", "Quae mollitia et magni repellat sed autem impedit ab architecto molestias dolorem vero ut ipsa est assumenda mollitia deleniti laudantium.", 402544114, 752, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), "Cole Inc", "sticky radical software" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Thora Erdman", "nam", "https://picsum.photos/50/50/?image=200", "Nemo minus saepe similique esse iste velit tempore rem qui corrupti omnis est et voluptatem veniam delectus consequatur et labore.", 879952106, 828, new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), "Hayes, Raynor and Mosciski", "quantifying Small Plastic Keyboard Handmade Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Thad Mueller", "voluptatem", "https://picsum.photos/50/50/?image=828", "Enim perspiciatis nam omnis id ipsam quo blanditiis placeat est ut sed quidem ea qui nostrum explicabo sit recusandae iste.", 170590521, 612, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), "Shanahan, Botsford and Kautzer", "Drive input Technician" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lenny Barrows", "possimus", "https://picsum.photos/50/50/?image=790", "Sint consequatur maiores eligendi iste incidunt in ea laudantium sed quaerat minus aspernatur a quod voluptate et rerum qui animi.", 778499631, 274, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Wisozk, Weimann and Ortiz", "repurpose Books & Tools Falls" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Merlin Gleichner", "et", "https://picsum.photos/50/50/?image=802", "Molestias ut sint inventore omnis rerum accusantium perferendis earum quos assumenda adipisci sed necessitatibus veritatis qui est dignissimos qui blanditiis.", 509532997, 274, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), "Hyatt and Sons", "Macao Avon compelling" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Elmore Williamson", "qui", "https://picsum.photos/50/50/?image=374", "Cum exercitationem atque enim sed ut non sit voluptas nostrum expedita praesentium et est pariatur nihil porro iure soluta velit.", 317663697, 992, new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), "Olson - Schowalter", "backing up SMS withdrawal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Chad Langworth", "animi", "https://picsum.photos/50/50/?image=885", "Ad ipsum dolor est aut et quae mollitia maxime eum quia aut illum blanditiis fuga iusto praesentium aut eos nulla.", 844610351, 857, new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), "Kirlin, Schamberger and Klein", "Markets Investment Account deposit" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Stuart Satterfield", "nihil", "https://picsum.photos/50/50/?image=689", "Alias et nulla facilis consequatur autem illo eius est aspernatur ipsam consequatur aliquam eius culpa et est consequuntur accusamus aliquid.", 357537050, 303, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "Huel, Kuphal and Kertzmann", "Incredible Rubber Fish action-items IB" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Abby Hansen", "voluptatem", "https://picsum.photos/50/50/?image=513", "Sed omnis dolorem sed dolor asperiores libero et impedit dolor alias adipisci quam cumque et quis et rerum sint est.", 906546955, 189, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), "Kutch, Hickle and Shields", "implementation Refined Fresh Table local" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Obie Pollich", "corporis", "https://picsum.photos/50/50/?image=805", "Maiores reprehenderit unde qui voluptatem dignissimos nisi sunt sapiente hic sunt voluptas adipisci eum iste harum nesciunt iure ipsam quisquam.", 833109605, 928, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Hand, Jacobs and Torphy", "compressing Buckinghamshire Industrial & Shoes" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Imani Runolfsson", "autem", "https://picsum.photos/50/50/?image=314", "Esse autem et numquam veritatis ex eum numquam aut at harum magni quis temporibus odio impedit consequatur ullam facilis sint.", 789019651, 408, new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "Watsica, Rau and Jacobi", "XSS Paradigm Practical Cotton Car" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dewitt Dooley", "officia", "https://picsum.photos/50/50/?image=1046", "Aut molestias incidunt numquam aspernatur tempora ad nobis dolor repellendus vero molestias officia tenetur officia tenetur repudiandae et accusamus aspernatur.", 342527640, 77, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), "Pfannerstill Group", "Licensed Steel Table tertiary scalable" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Berenice Crona", "autem", "https://picsum.photos/50/50/?image=877", "Mollitia quam tempore accusantium et expedita tempora laudantium eum error laborum quis iusto aut et placeat est asperiores ut consequuntur.", 271056711, 475, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Local), "Ullrich, Walter and Kertzmann", "circuit calculate Minnesota" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Devon Marquardt", "voluptatum", "https://picsum.photos/50/50/?image=410", "Tempora aliquam sunt ea dolorum error repudiandae autem corrupti hic doloribus in quam molestias porro voluptatem velit nesciunt laboriosam voluptas.", 277208709, 975, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), "Mayert - Raynor", "Refined Steel Chair project Spring" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Leonardo Rutherford", "at", "https://picsum.photos/50/50/?image=164", "Ad cumque quia quam minima repellat sequi sed omnis ut fuga architecto veritatis nihil iure adipisci temporibus fugit quae necessitatibus.", 680303239, 510, new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "Durgan, Ferry and Hettinger", "Progressive Platinum Avon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Macy Maggio", "dolore", "https://picsum.photos/50/50/?image=703", "Debitis est vero quis beatae et quaerat occaecati beatae eius praesentium distinctio nihil reiciendis tenetur deleniti harum similique animi optio.", 577470796, 308, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "Denesik, Berge and Bergnaum", "Associate Credit Card Account Prairie" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Gavin Orn", "exercitationem", "https://picsum.photos/50/50/?image=1018", "Amet explicabo magnam suscipit possimus porro autem sed aut a aperiam eos ipsa sapiente atque odit est nihil molestiae inventore.", 381114935, 93, new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), "Carter, Fritsch and Hagenes", "Marketing CFA Franc BEAC secondary" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kirk Hand", "incidunt", "https://picsum.photos/50/50/?image=64", "Est nobis optio enim eius et et deleniti nemo officiis tenetur minus vel accusamus autem perferendis et sequi consequatur accusamus.", 124411772, 276, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "Dare - Goodwin", "New Hampshire New Hampshire Product" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Harrison Cummerata", "aut", "https://picsum.photos/50/50/?image=999", "Eum repellat ut quos quae et expedita nam sint sit omnis distinctio velit libero esse modi vitae est occaecati ducimus.", 710059717, 561, new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), "Quigley, Larson and Veum", "Streamlined parsing microchip" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Oliver Bashirian", "cupiditate", "https://picsum.photos/50/50/?image=68", "Autem tenetur ratione sunt sint rerum saepe culpa ab molestiae sed eos earum asperiores voluptatum mollitia qui qui qui eaque.", 931781546, 843, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "Heathcote, Tremblay and Jones", "distributed Generic Plastic Soap sticky" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Grayson Gleason", "rerum", "https://picsum.photos/50/50/?image=667", "Dignissimos adipisci aliquam natus quos ea magnam dolor quae assumenda est saepe similique repellendus esse eligendi et maxime voluptatum necessitatibus.", 546833936, 638, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Howe, Mitchell and Raynor", "cross-media Cambridgeshire invoice" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Reed Carter", "et", "https://picsum.photos/50/50/?image=917", "Velit culpa itaque vitae velit unde perferendis ex in aliquid vel impedit accusamus consequatur et molestiae tempore ratione corrupti placeat.", 353546359, 198, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), "Becker, Schroeder and Marquardt", "Handmade Granite Chair payment PCI" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "AUTHOR", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Hettie Schaefer", "https://picsum.photos/50/50/?image=1049", "Reprehenderit quasi earum sit et sint culpa dolorum qui consequatur amet quaerat iste sapiente quaerat deleniti sit cumque illum aut.", 298756451, 151, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), "Oberbrunner Group", "XML Savings Account cultivate" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Camron Corkery", "quisquam", "https://picsum.photos/50/50/?image=124", "Mollitia fugiat necessitatibus qui enim sed omnis eaque in ipsam nobis hic amet ut saepe qui optio labore assumenda error.", 766857883, 767, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Weimann, Muller and Schumm", "District Director action-items" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Leanne Witting", "voluptatem", "https://picsum.photos/50/50/?image=156", "Iusto dicta et deleniti tempore laudantium quidem laborum exercitationem quae impedit aut voluptas beatae veritatis harum nihil officiis nobis soluta.", 539984792, 944, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), "Monahan and Sons", "Sleek Guam Unbranded Soft Ball" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Elody Anderson", "id", "https://picsum.photos/50/50/?image=658", "Iste error autem reprehenderit et possimus minima dignissimos asperiores modi eos quod delectus ut sint nulla temporibus sequi vel quia.", 553050214, 810, new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Local), "Wolff and Sons", "HTTP Berkshire white" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Paxton Douglas", "ut", "https://picsum.photos/50/50/?image=344", "Necessitatibus nisi consequatur molestias enim neque aut sed aut et repudiandae ut repudiandae ut similique explicabo amet exercitationem est ut.", 511612810, 494, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Local), "Abbott, Zemlak and Hermann", "Ramp Handmade real-time" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Elody Erdman", "ullam", "https://picsum.photos/50/50/?image=617", "Et dicta quia sed maiores aut rerum maiores tempore magni inventore fugit nihil autem fuga ut facilis voluptas voluptate illo.", 221155203, 977, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), "Hills - Green", "panel Accountability Via" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rubye Wiza", "voluptatem", "https://picsum.photos/50/50/?image=455", "Eius aliquid deleniti odit est aut veniam id dignissimos ratione velit aspernatur eligendi illum est qui sit quae omnis et.", 368778812, 651, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), "Veum - Toy", "Money Market Account Ergonomic Steel Computer Rubber" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Malinda Von", "id", "https://picsum.photos/50/50/?image=89", "Sint dolorem sapiente et similique sunt dolor voluptatem aut ut explicabo eos doloremque iure aut et voluptatem porro nihil nam.", 592284455, 587, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), "Cole Group", "Soft Agent Kina" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kaylie Sipes", "odio", "https://picsum.photos/50/50/?image=1009", "Voluptatibus et nobis nihil aspernatur libero et quasi impedit voluptate tenetur totam tempore non maxime doloremque aperiam quis consequuntur debitis.", 226214301, 443, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Local), "Nienow Inc", "Expanded envisioneer encoding" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Katarina Rutherford", "facilis", "https://picsum.photos/50/50/?image=428", "Sapiente soluta quam cupiditate quia ratione id aliquam aliquam temporibus quam facilis porro est eum odit maxime ipsa quae ea.", 784685452, 367, new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Borer LLC", "revolutionary actuating scale" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Beaulah Bahringer", "quia", "https://picsum.photos/50/50/?image=1063", "Officia ipsa rerum fuga ut aut repellendus id debitis aut fugiat at non autem necessitatibus accusamus culpa aut alias fugit.", 474793337, 852, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "Adams, Gleichner and Wisoky", "user-facing Street Representative" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ivory Collier", "odit", "https://picsum.photos/50/50/?image=765", "Et non beatae soluta ab qui voluptates quis a et perspiciatis dignissimos sunt placeat sequi officia eveniet beatae nobis ducimus.", 697891789, 877, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Local), "Graham LLC", "models next generation New York" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jennie Spencer", "sequi", "https://picsum.photos/50/50/?image=493", "Et perspiciatis sed consectetur ad vero tenetur unde similique dolorum expedita aut assumenda itaque quos nam perspiciatis et est facilis.", 755904235, 276, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "Wintheiser LLC", "Frozen Rustic Fresh Hat Incredible" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Oscar Price", "sit", "https://picsum.photos/50/50/?image=926", "Dicta totam et quam cumque ipsam iusto tempora accusamus omnis error quis in rerum dolor suscipit voluptatem consequatur est cumque.", 655707415, 715, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "Zboncak Inc", "input syndicate Officer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Drew Cremin", "occaecati", "https://picsum.photos/50/50/?image=468", "Perspiciatis perspiciatis deleniti aperiam et exercitationem quibusdam ex occaecati voluptatum fuga qui molestiae vero ex occaecati optio saepe perspiciatis non.", 874571550, 71, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "Balistreri - McLaughlin", "Unbranded Village Plastic" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Bianka Ortiz", "eos", "https://picsum.photos/50/50/?image=198", "Laudantium omnis sequi a reiciendis impedit vel dolor sed quas occaecati doloremque ratione et sit praesentium ullam repudiandae omnis qui.", 896607343, 66, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Local), "Cummings Inc", "Usability Handcrafted Fresh Bike Illinois" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "June Jast", "qui", "https://picsum.photos/50/50/?image=32", "Ea ut occaecati ut doloribus tenetur veritatis et occaecati laborum voluptate quod accusantium recusandae laudantium molestias veniam omnis ducimus quia.", 205017409, 533, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Schoen - Harber", "Licensed leverage National" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Melyssa Ortiz", "expedita", "https://picsum.photos/50/50/?image=370", "Autem ut dolorem odit quae et voluptas sit minus quibusdam nihil deserunt non earum similique error est dolorem sint dolores.", 675981395, 324, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), "Kunde, Oberbrunner and Weimann", "Hills tangible Refined Plastic Chair" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Brown Hamill", "sunt", "https://picsum.photos/50/50/?image=742", "Sed qui rem unde cupiditate rerum et veritatis nihil autem omnis est maxime qui aut repellat placeat sit saepe dolore.", 960387125, 525, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Local), "Bailey, Crist and Zemlak", "Mall Mauritius Isle" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sage Miller", "vel", "https://picsum.photos/50/50/?image=743", "Ut magni sapiente exercitationem molestiae ipsam itaque est ea voluptatum nesciunt et necessitatibus officiis expedita beatae et praesentium corrupti et.", 473815878, 391, new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Local), "Rutherford - Swift", "Springs plum Buckinghamshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Keenan Kirlin", "molestias", "https://picsum.photos/50/50/?image=92", "Ipsa magni dolore doloribus iusto non porro soluta ipsum incidunt aperiam repellendus dolores cupiditate velit nihil et sequi libero quos.", 468778975, 806, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), "Mraz Inc", "Pula Berkshire salmon" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Maegan Yundt", "iusto", "https://picsum.photos/50/50/?image=789", "Eum placeat sint illum hic quidem perferendis delectus nam ut aperiam voluptatem est et totam voluptatem consequatur unde officiis et.", 509562149, 302, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "Mertz LLC", "Rustic Fantastic Wooden Gloves Persevering" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lonnie Fadel", "tempora", "https://picsum.photos/50/50/?image=202", "Suscipit velit deleniti nesciunt sit sed aliquam magnam sapiente eum quasi impedit aut nulla quia veritatis blanditiis libero et aut.", 713484920, 172, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), "Lakin, Ankunding and King", "initiatives Identity Extended" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Dimitri Hyatt", "vel", "https://picsum.photos/50/50/?image=39", "Magni velit accusantium debitis aperiam aliquam est est cumque autem voluptates rerum aut ullam odio corporis suscipit non officia in.", 736472718, 293, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), "Waelchi Group", "Handmade Granite Keyboard infomediaries Intelligent" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ernest Kautzer", "nisi", "https://picsum.photos/50/50/?image=980", "Corporis ut voluptate aliquid cumque necessitatibus officiis ullam sunt assumenda ullam occaecati et quam veniam ipsam aut tempora dolores praesentium.", 693300994, 316, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "Mann - Dickinson", "optimize Accountability Synchronised" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Clemmie Howe", "neque", "https://picsum.photos/50/50/?image=911", "Maiores quam possimus quia quasi sequi sint aut exercitationem aut maiores perferendis qui provident in nam sit voluptatibus numquam aut.", 797742581, 785, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "Rodriguez, Ortiz and Wunsch", "invoice green payment" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Pierce Harris", "quia", "https://picsum.photos/50/50/?image=189", "Magni dolorum unde aut quo quis dignissimos excepturi enim iure qui eum aut aliquam eos eos tempora officiis praesentium provident.", 802344686, 868, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), "Stiedemann, Davis and Lowe", "Avon Officer Metal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Wilmer Hilll", "similique", "https://picsum.photos/50/50/?image=651", "In hic ratione totam et quae dolores consequuntur quia est et velit delectus consequatur aut aperiam laudantium sint temporibus impedit.", 475049559, 819, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "Oberbrunner LLC", "Facilitator port Savings Account" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kristopher Stamm", "cum", "https://picsum.photos/50/50/?image=806", "Aspernatur dicta ipsum sed quibusdam consequatur eius ea ut cumque dolorum ut ea neque non sit delectus odio officia cum.", 118270136, 684, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "Heaney Inc", "Computers & Music Fields connect" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kyleigh Goyette", "assumenda", "https://picsum.photos/50/50/?image=963", "Temporibus voluptatum numquam fuga id dolorum nihil quia nostrum aut accusantium earum adipisci omnis cupiditate veritatis assumenda et et sed.", 238111530, 335, new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Local), "O'Reilly, Waters and Prosacco", "Facilitator Pines Internal" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Talon Jones", "est", "https://picsum.photos/50/50/?image=600", "Saepe non iste esse veniam nostrum aut voluptatibus est non perferendis nesciunt porro ab neque molestiae in occaecati minima pariatur.", 343004797, 922, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Little, Huel and Weissnat", "Summit Auto Loan Account Realigned" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Daron Stark", "quo", "https://picsum.photos/50/50/?image=521", "Corrupti ipsa aut dignissimos aut est cumque porro et saepe velit quis rerum a adipisci temporibus vel quia sunt fugit.", 395441830, 957, new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), "Fay - Bradtke", "Chad Nuevo Sol portals" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Trey McDermott", "architecto", "https://picsum.photos/50/50/?image=437", "Qui qui et at minus cupiditate nemo quidem quae veniam similique porro ipsam vero ducimus rerum deserunt dicta dolorem ut.", 565510663, 950, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Kulas Group", "multi-byte regional Synergized" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Sarah Dibbert", "magni", "https://picsum.photos/50/50/?image=294", "Iure rerum natus sit eos quibusdam ipsum sed sed numquam accusamus soluta quae fuga autem porro praesentium laudantium dolor et.", 832986762, 698, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), "Lebsack and Sons", "payment Radial Road" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alysa Abshire", "nobis", "https://picsum.photos/50/50/?image=513", "Perspiciatis rem aperiam officiis possimus aut similique voluptatem dolorem sapiente delectus voluptatum officia occaecati quia nobis est fugit et dolorem.", 500603008, 748, new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Parisian, Rice and Shanahan", "Stravenue Manager Burundi Franc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Wallace White", "vel", "https://picsum.photos/50/50/?image=824", "Ratione nobis ut asperiores et qui vitae amet atque et dolorem voluptates aperiam ipsam perferendis non similique nam autem quo.", 460109063, 638, new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "Nicolas Inc", "Metrics Principal backing up" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Leslie Heidenreich", "aut", "https://picsum.photos/50/50/?image=891", "Culpa ut dolorem ea minima voluptatum repellat sint itaque sapiente dolor blanditiis praesentium facilis dicta ea fuga adipisci enim est.", 772908609, 926, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Local), "Haag - Kuvalis", "seize bypassing Practical Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jessica Runte", "minima", "https://picsum.photos/50/50/?image=935", "Voluptate veniam sed pariatur ut ex vero dignissimos aliquid quos et repellendus in et nulla est ea dolor voluptate sunt.", 168349717, 879, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), "Durgan - Tromp", "monitoring hack IB" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Winifred Prosacco", "non", "https://picsum.photos/50/50/?image=847", "Debitis fugiat exercitationem omnis et ab ipsa delectus recusandae officia autem non itaque nisi omnis non tempore ut quam nihil.", 451447592, 516, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Local), "Rutherford - Abbott", "fuchsia Danish Krone bypassing" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Vena Ryan", "qui", "https://picsum.photos/50/50/?image=915", "Laboriosam qui voluptatem adipisci consequatur quo magni atque ut doloremque cum provident quia numquam ex numquam qui odio earum rerum.", 157794222, 752, new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "Nienow and Sons", "syndicate Incredible Arizona" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Reba Graham", "est", "https://picsum.photos/50/50/?image=562", "Est rerum adipisci et quae laboriosam praesentium asperiores quibusdam sit blanditiis et aut magnam possimus quas in ut et voluptas.", 793766180, 157, new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), "Ledner Inc", "Facilitator Practical Frozen Fish deposit" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Lew Grant", "quo", "https://picsum.photos/50/50/?image=569", "Itaque optio omnis aut dolor magni libero laboriosam asperiores et nulla voluptate facilis molestiae cum rerum laboriosam facilis eveniet molestiae.", 307978537, 575, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), "Romaguera Inc", "program enhance primary" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Giuseppe Dach", "molestiae", "https://picsum.photos/50/50/?image=601", "Incidunt modi et nam sapiente repudiandae quibusdam unde sapiente voluptate modi consequatur aperiam nisi commodi molestiae libero et ut repellendus.", 382742816, 94, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Local), "Dicki - Adams", "reciprocal Ville Data" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Pablo Bergnaum", "totam", "https://picsum.photos/50/50/?image=515", "Maxime et quis officiis et earum possimus quibusdam sed sint quidem possimus deleniti fuga illum suscipit possimus porro nisi incidunt.", 295458134, 341, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), "Douglas - Simonis", "monetize Clothing, Shoes & Movies Legacy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Mariane Blick", "sint", "https://picsum.photos/50/50/?image=762", "Officia quos sapiente optio non similique quidem sed totam nemo labore cumque ex voluptate error et quos omnis reprehenderit vel.", 306146836, 205, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), "Armstrong, Dare and Jones", "matrix Creative synthesize" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Rocio Kozey", "nostrum", "https://picsum.photos/50/50/?image=820", "Vel nihil magni earum ducimus debitis qui non aspernatur blanditiis est aut aliquid reiciendis facilis sit sequi voluptatum eum cumque.", 573983630, 744, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), "Zemlak, Simonis and Walter", "system Fresh invoice" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Heber Grant", "quibusdam", "https://picsum.photos/50/50/?image=376", "Tempora hic harum aut voluptatibus eaque totam sed nihil voluptate iure quia rerum expedita ea et esse nemo velit exercitationem.", 814353219, 976, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), "Abernathy - Kuhn", "index bluetooth Realigned" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Helena Conroy", "sint", "https://picsum.photos/50/50/?image=797", "Rerum consequatur non sed aut beatae laudantium cum qui ut repellat eum nobis commodi impedit eos enim voluptatum dignissimos blanditiis.", 379589015, 467, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "Jones - Lebsack", "SDR Burgs Berkshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Elva Stamm", "et", "https://picsum.photos/50/50/?image=142", "Fugiat dignissimos earum quos voluptatem ut repellat sit eveniet excepturi illum ab voluptatem facilis explicabo libero quo sint optio enim.", 307761354, 445, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), "Emard, Cruickshank and Senger", "cross-platform Fantastic Soft Sausages object-oriented" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Norwood Yost", "et", "https://picsum.photos/50/50/?image=22", "Expedita nihil soluta accusamus sint dolores sed omnis earum et est distinctio expedita ut voluptate asperiores quam accusantium et cupiditate.", 510941172, 899, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), "Maggio, Wiza and Klein", "bluetooth Sri Lanka Rupee Engineer" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Marlon Schiller", "quos", "https://picsum.photos/50/50/?image=345", "A esse consequatur voluptatem odit voluptatem recusandae dolore repellat consequatur error non facere accusamus non vel dicta ea possimus nulla.", 333163989, 285, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), "Harris - Jacobson", "encoding Mauritius Grocery" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Cedrick Baumbach", "dolor", "https://picsum.photos/50/50/?image=825", "Iste non consequuntur et labore excepturi aliquid similique dignissimos repudiandae odit voluptatem vel facilis optio necessitatibus unde nesciunt sed eligendi.", 473272699, 861, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), "Sanford - Leannon", "plug-and-play Computers Product" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Imogene Crona", "nobis", "https://picsum.photos/50/50/?image=174", "Ducimus veniam dolorum vel omnis velit sed quia voluptatibus rem consequuntur aut quibusdam ipsum sit repudiandae voluptatem quia aut rem.", 119315221, 251, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "Predovic, Wolff and Veum", "Borders Automotive THX" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Gillian Dach", "ad", "https://picsum.photos/50/50/?image=906", "Est veniam itaque laborum culpa officia iure commodi odit cupiditate blanditiis maiores vitae necessitatibus atque quia corrupti et necessitatibus optio.", 930872869, 458, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), "Mitchell Group", "definition Glen Throughway" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Alvera Padberg", "rem", "https://picsum.photos/50/50/?image=739", "Ad minima nobis rerum amet laborum illo nam dicta sed cupiditate est ea eius beatae quis corporis rerum dolor repellat.", 386792259, 71, new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), "Friesen and Sons", "Tasty Steel Sausages Function-based invoice" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jimmie Collier", "et", "https://picsum.photos/50/50/?image=944", "Quia asperiores repudiandae sunt doloremque vel inventore laudantium ipsum ut expedita consequatur sequi quo quia ipsum quaerat dicta facere occaecati.", 400378476, 794, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Altenwerth and Sons", "cross-platform utilize Tasty" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Claudine Gottlieb", "repellat", "https://picsum.photos/50/50/?image=787", "Repellendus voluptatem sit ut aut laboriosam hic quia praesentium non non amet ut quisquam quos vel esse temporibus eius eum.", 732084787, 704, new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), "Rohan - Stehr", "Designer Generic Granite Cheese software" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Ervin Collins", "ad", "https://picsum.photos/50/50/?image=96", "Voluptatem et ut magnam aut ratione et est dicta ut pariatur placeat quaerat tempore accusantium voluptatem exercitationem fugiat modi hic.", 595649082, 117, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "Dietrich Group", "Architect reintermediate foreground" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Myrtle Bergstrom", "voluptatum", "https://picsum.photos/50/50/?image=786", "Voluptatem maiores sequi voluptas earum aliquid et delectus et totam voluptatem et est ut commodi minima quae minus amet exercitationem.", 137684781, 195, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "Gutmann - Kerluke", "maximize Tasty Rubber Soap Berkshire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Kirstin Davis", "et", "https://picsum.photos/50/50/?image=1001", "Omnis qui ducimus sunt placeat veritatis itaque voluptatem accusamus maxime impedit enim ipsa dolore ab nihil officia aut ex incidunt.", 676273621, 572, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), "Zieme - Franecki", "synthesizing indexing disintermediate" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Julia Rau", "aperiam", "https://picsum.photos/50/50/?image=270", "Ea accusamus ea nam quia esse iure id id voluptatum vero natus magnam odio ad libero asperiores quo facilis doloremque.", 541963400, 383, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), "Schinner - Wisozk", "Incredible Frozen Gloves International Wisconsin" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Zackery Hudson", "voluptatum", "https://picsum.photos/50/50/?image=696", "Similique et debitis esse sit natus veniam veritatis est placeat incidunt ducimus ea inventore consequatur qui libero et nisi mollitia.", 729986581, 672, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Abshire - Torp", "Latvia Decentralized Handcrafted Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Moses Konopelski", "excepturi", "https://picsum.photos/50/50/?image=623", "Voluptatem architecto nobis nostrum nulla harum ex laboriosam mollitia assumenda voluptatum repellat quisquam fugiat quia inventore voluptates sit deserunt iste.", 983101595, 881, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "Kub, Nolan and Walter", "capability Total contingency" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[] { "Jailyn Heathcote", "libero", "https://picsum.photos/50/50/?image=833", "Culpa ea placeat cumque labore tenetur non ut nobis temporibus numquam nihil unde ratione repudiandae voluptatem quasi fuga debitis quia.", 374593803, 232, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), "Jacobson, O'Conner and Lubowitz", "Product Licensed Soft Chair Hill" });
        }
    }
}
