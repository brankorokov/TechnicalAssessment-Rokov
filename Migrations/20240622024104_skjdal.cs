using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechnicalAssessmentRokov.Migrations
{
    /// <inheritdoc />
    public partial class skjdal : Migration
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
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TITLE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<int>(type: "int", nullable: false),
                    AUTHOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COVER_PAGE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PUBLISHER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PUBLICATION_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CATEGORY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAGE_COUNT = table.Column<int>(type: "int", nullable: false),
                    CHECKED_OUT_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DUE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CheckedOutByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Books_AspNetUsers_CheckedOutByUserId",
                        column: x => x.CheckedOutByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "AUTHOR", "CATEGORY", "CheckedOutByUserId", "CHECKED_OUT_DATE", "COVER_PAGE", "DESCRIPTION", "DUE_DATE", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[,]
                {
                    { 1, "Werner Morissette", "reprehenderit", null, null, "https://picsum.photos/50/50/?image=339", "Quas aspernatur vel harum neque non molestiae qui itaque sit perspiciatis est omnis saepe est odio totam aliquid iste veniam.", null, 698708640, 107, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "Beahan - Predovic", "robust Officer Home Loan Account" },
                    { 2, "Hazel Wuckert", "aliquam", null, null, "https://picsum.photos/50/50/?image=614", "Rerum ullam velit quia deleniti aut in sint sit laudantium ut commodi rerum magnam qui perspiciatis sunt odio nulla occaecati.", null, 478981832, 932, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Local), "Emard, Hartmann and Bauch", "transmit Rubber Cove" },
                    { 3, "Patricia Reinger", "consequatur", null, null, "https://picsum.photos/50/50/?image=722", "Occaecati commodi et repudiandae animi recusandae illum harum ea quidem quia ipsa et quis ut ab eligendi distinctio aut et.", null, 535434401, 769, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), "Heidenreich - Hirthe", "deposit Ergonomic Rustic Metal Towels" },
                    { 4, "Maxime Gulgowski", "hic", null, null, "https://picsum.photos/50/50/?image=648", "Saepe vel ex eaque et nihil qui repellat corporis iusto consectetur ipsa atque vel enim et pariatur a rerum quae.", null, 271842738, 643, new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), "O'Reilly - Swift", "Micronesia open-source Bedfordshire" },
                    { 5, "Glen Herzog", "alias", null, null, "https://picsum.photos/50/50/?image=85", "Consequatur nihil et nemo earum reiciendis cum aut temporibus qui sit quos odio aliquam consequatur et molestiae non ut doloremque.", null, 435320443, 94, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "Johnston, Rolfson and Roob", "Croatian Kuna bluetooth Rustic" },
                    { 6, "Claire Harber", "doloremque", null, null, "https://picsum.photos/50/50/?image=180", "Repellendus dolores accusamus dolores et odit similique et fuga eos asperiores explicabo aliquam reiciendis velit blanditiis reiciendis quo eum ad.", null, 999774331, 80, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "Kautzer, Ankunding and O'Keefe", "Intelligent Fresh Fish Senior Face to face" },
                    { 7, "Cleve McKenzie", "quos", null, null, "https://picsum.photos/50/50/?image=802", "Harum maxime fugit consectetur ut atque sed quam asperiores nesciunt nam praesentium odit deserunt quidem perferendis ipsam sed veniam modi.", null, 878793946, 480, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "Mraz, Keebler and Pfannerstill", "world-class Barbados index" },
                    { 8, "Amelie Gleichner", "est", null, null, "https://picsum.photos/50/50/?image=378", "Qui ad eos rerum necessitatibus delectus nemo magni dolores temporibus inventore voluptas ut excepturi sint iusto iure rem deserunt commodi.", null, 640163309, 204, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), "Bradtke - Hills", "Practical Metal Pizza Functionality Refined Rubber Fish" },
                    { 9, "Lourdes Hilll", "culpa", null, null, "https://picsum.photos/50/50/?image=192", "Totam fugiat ut ex enim ex excepturi exercitationem laboriosam est cupiditate consequuntur ut repellendus error qui unde culpa repudiandae deleniti.", null, 701649286, 966, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), "McCullough Group", "North Dakota front-end Response" },
                    { 10, "Laurine Mann", "saepe", null, null, "https://picsum.photos/50/50/?image=721", "Nostrum omnis ex ex explicabo dolores in enim ut omnis dolorem inventore pariatur velit ea eum sint et id consequatur.", null, 750802986, 106, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), "Steuber, Sipes and Leannon", "Tactics Generic Frozen Bacon Rustic Wooden Keyboard" },
                    { 11, "Kyleigh Prohaska", "optio", null, null, "https://picsum.photos/50/50/?image=590", "Qui id rerum ipsa rerum aut id voluptate id omnis amet iusto sed id excepturi voluptatem fugiat voluptas omnis est.", null, 281156152, 412, new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), "Olson, Davis and Watsica", "Pula Metrics grey" },
                    { 12, "Mohammad Grimes", "qui", null, null, "https://picsum.photos/50/50/?image=1027", "Quia exercitationem non laboriosam praesentium autem eum voluptatibus facere aliquam nihil quisquam possimus dolore esse voluptas harum quae necessitatibus quia.", null, 821063076, 299, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "Pagac - Dare", "transform Public-key Avon" },
                    { 13, "Archibald Roob", "veritatis", null, null, "https://picsum.photos/50/50/?image=748", "Expedita labore nesciunt dolorum a est harum eius sit quae provident dolorum pariatur optio quasi ducimus doloribus exercitationem laboriosam eligendi.", null, 575509866, 130, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), "Schneider - Lang", "invoice Gorgeous Frozen Chicken Mall" },
                    { 14, "Maurine Dickens", "sed", null, null, "https://picsum.photos/50/50/?image=965", "In quas dolorum est voluptate id rerum vel rerum exercitationem aliquam totam qui qui quis ut laudantium cum eligendi voluptate.", null, 360217893, 936, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), "Casper, Smith and Yost", "navigating optical middleware" },
                    { 15, "Taurean Schaden", "quos", null, null, "https://picsum.photos/50/50/?image=1062", "Magni totam explicabo aliquam voluptas voluptatem quisquam earum dolores dolorem earum impedit veritatis consequuntur veritatis nam occaecati laboriosam sed et.", null, 228356765, 422, new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), "McClure - Wuckert", "Convertible Marks connecting SMS" },
                    { 16, "Guadalupe Rau", "mollitia", null, null, "https://picsum.photos/50/50/?image=600", "Ut similique amet repellat sequi eaque provident eveniet aliquid ipsum impedit libero neque eius nisi autem minima fugiat accusamus dolor.", null, 626240072, 782, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), "Lakin Group", "Dong background teal" },
                    { 17, "Aryanna Kihn", "quasi", null, null, "https://picsum.photos/50/50/?image=701", "Reprehenderit et deleniti sit velit fugiat at perspiciatis quaerat et suscipit voluptas voluptas nesciunt aliquid pariatur at qui voluptas tempore.", null, 969187734, 802, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Jacobson - Cremin", "web-enabled payment Incredible Fresh Pants" },
                    { 18, "Abbie Kshlerin", "labore", null, null, "https://picsum.photos/50/50/?image=38", "Illum molestiae vel consequuntur quo occaecati tempore magnam fugit vero facilis libero quia eligendi dolorem temporibus dolores corporis animi cupiditate.", null, 214124313, 99, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), "Gorczany, Anderson and Schmeler", "blockchains synthesizing Inlet" },
                    { 19, "Lelia Macejkovic", "dolores", null, null, "https://picsum.photos/50/50/?image=369", "Consequatur velit placeat saepe voluptatem delectus possimus molestiae dicta esse consequatur aut at id vel perspiciatis non quis sed est.", null, 748969112, 481, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), "Parisian LLC", "Home Loan Account Jewelery, Kids & Home Tools, Books & Sports" },
                    { 20, "Meta Orn", "dicta", null, null, "https://picsum.photos/50/50/?image=69", "Non et iusto ut sint cupiditate inventore consequatur et dolores sapiente sapiente porro natus adipisci neque ea qui sit fugiat.", null, 256570532, 363, new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), "Stroman, Medhurst and Bergnaum", "orchid Egypt Licensed Steel Chips" },
                    { 21, "Jonas Heller", "sit", null, null, "https://picsum.photos/50/50/?image=613", "Culpa debitis sit perferendis est tempore aut consectetur molestiae magnam suscipit et illum quos voluptatem accusamus eos impedit omnis ipsa.", null, 366835925, 702, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "Bechtelar and Sons", "model Berkshire Shoes & Automotive" },
                    { 22, "Jennie Hauck", "enim", null, null, "https://picsum.photos/50/50/?image=811", "Omnis eum sapiente rerum molestias consequuntur voluptates iure voluptatem et molestiae in quia dolor vero consequatur dolore animi voluptatem corporis.", null, 366991134, 187, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), "Weimann, Botsford and Fay", "Indian Rupee violet matrix" },
                    { 23, "Laura Ledner", "nostrum", null, null, "https://picsum.photos/50/50/?image=646", "Commodi dolores modi dolor pariatur fuga quis vero deserunt unde nulla velit sunt distinctio expedita delectus ut aliquam incidunt minus.", null, 171387700, 765, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), "Hudson, Morar and Kulas", "quantify Industrial Awesome Wooden Ball" },
                    { 24, "Monica Quigley", "beatae", null, null, "https://picsum.photos/50/50/?image=927", "Et dolorem non nulla dolores vel beatae accusantium et doloribus iusto unde vero aut voluptatem ad nobis veniam incidunt ratione.", null, 784777191, 776, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "Macejkovic and Sons", "visionary Oval pixel" },
                    { 25, "Lilla Muller", "maiores", null, null, "https://picsum.photos/50/50/?image=158", "Commodi quia blanditiis porro doloribus ad vitae rerum eveniet qui autem cupiditate distinctio laudantium et ut hic alias non aut.", null, 750471638, 478, new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), "Schmitt - Kuhic", "withdrawal Causeway Thailand" },
                    { 26, "Madison Hartmann", "blanditiis", null, null, "https://picsum.photos/50/50/?image=1084", "Voluptas voluptate ea eaque ullam ut dolorem laborum eveniet ratione sit harum reiciendis voluptas et natus ducimus odio perspiciatis sit.", null, 707358039, 153, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), "Ritchie and Sons", "standardization dynamic firewall" },
                    { 27, "Emmie Haley", "voluptas", null, null, "https://picsum.photos/50/50/?image=649", "Nisi sequi necessitatibus hic aperiam repudiandae adipisci a rerum laboriosam recusandae eum consequuntur aut fugit vel quae officiis a saepe.", null, 742669089, 450, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "Waelchi - Veum", "IB Communications PNG" },
                    { 28, "Edmond Bradtke", "velit", null, null, "https://picsum.photos/50/50/?image=942", "Quae vitae commodi expedita sunt maiores distinctio ducimus perferendis rerum laborum quia et sed rerum dolorem nisi laudantium est magni.", null, 361939646, 800, new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), "Medhurst Inc", "ubiquitous syndicate port" },
                    { 29, "Rey Little", "rerum", null, null, "https://picsum.photos/50/50/?image=119", "Eum recusandae consequatur voluptatibus ducimus qui eaque laboriosam consequatur mollitia veniam deserunt qui dolores voluptatem voluptas exercitationem unde eius rem.", null, 649576991, 786, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Local), "Huels Group", "Isle Gorgeous Soft Bacon Borders" },
                    { 30, "Kamryn Parisian", "quam", null, null, "https://picsum.photos/50/50/?image=724", "Et suscipit dolorem nam non distinctio quibusdam temporibus inventore aut mollitia in id tenetur at architecto neque sint modi est.", null, 259041283, 390, new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), "Conn, Raynor and Effertz", "regional Home, Tools & Sports Refined Metal Chair" },
                    { 31, "Cordia Torp", "quod", null, null, "https://picsum.photos/50/50/?image=553", "Omnis ea ea veniam id alias nobis nemo architecto nihil eum rerum aut ab voluptatem illum quis odit qui vel.", null, 630197287, 81, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "Lowe and Sons", "Handmade Metal Towels Planner sensor" },
                    { 32, "Theodora Bode", "ex", null, null, "https://picsum.photos/50/50/?image=502", "Consequatur impedit rerum commodi quia nostrum odio laboriosam rerum maxime et illum porro non harum repudiandae placeat odit qui debitis.", null, 881718036, 302, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), "Homenick, Veum and Sporer", "Plastic Concrete Dalasi" },
                    { 33, "Charles Streich", "non", null, null, "https://picsum.photos/50/50/?image=603", "Et et corporis doloremque illo perferendis eaque consequatur minus labore non cumque tempora delectus voluptates nobis id nostrum quae ea.", null, 589697545, 178, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), "Cronin - Schmitt", "quantify moderator input" },
                    { 34, "Jerald Krajcik", "facere", null, null, "https://picsum.photos/50/50/?image=566", "Laboriosam commodi omnis vel recusandae consectetur aliquid nemo eveniet culpa fugit consequatur corporis delectus porro est id aliquid quisquam ipsam.", null, 308843241, 980, new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "Willms Group", "Ford teal IB" },
                    { 35, "Sophia Doyle", "ut", null, null, "https://picsum.photos/50/50/?image=1036", "Eos consequatur doloremque quasi beatae deleniti voluptate sint nobis nobis voluptas perferendis iusto fugit fugit iusto ex non praesentium autem.", null, 429193290, 505, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), "Donnelly LLC", "Reverse-engineered white Computers, Baby & Baby" },
                    { 36, "Seth Weber", "sapiente", null, null, "https://picsum.photos/50/50/?image=392", "Qui quod sunt est cumque quod qui consequuntur beatae blanditiis facilis dolorum nihil voluptatum voluptas voluptatem amet vel consequatur omnis.", null, 484295136, 925, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "Bednar - Hartmann", "France parse Botswana" },
                    { 37, "Adolfo Terry", "dolore", null, null, "https://picsum.photos/50/50/?image=1052", "Eligendi nobis fugiat tempora corporis illo quos delectus dolorum cumque est exercitationem aperiam dolorem aut aut nihil quia aliquid laboriosam.", null, 837951220, 511, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), "Wilderman - Feest", "Tasty Frozen Bike Creative Russian Ruble" },
                    { 38, "Kamron Zieme", "officia", null, null, "https://picsum.photos/50/50/?image=636", "Error unde corrupti aperiam optio eum nesciunt nostrum vel ex molestias odio et dolorem rerum similique commodi facilis dolores iusto.", null, 448482491, 296, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), "McKenzie Group", "Steel Sleek Metal Chips Direct" },
                    { 39, "Celia Hoeger", "quod", null, null, "https://picsum.photos/50/50/?image=755", "Consequatur quo corporis fugiat similique non et non quia quis incidunt at iure quod eveniet facere numquam et numquam repellat.", null, 388044111, 355, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), "Walter, Conroy and Kohler", "Generic Soft Cheese Personal Loan Account synergistic" },
                    { 40, "Alexandre Orn", "cupiditate", null, null, "https://picsum.photos/50/50/?image=416", "Quibusdam recusandae ea nihil nisi dicta autem officia ipsum itaque quisquam ab exercitationem qui voluptas iure qui id voluptatem sit.", null, 747437248, 559, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "Ankunding - Strosin", "Director Norwegian Krone Rhode Island" },
                    { 41, "Vivienne Grant", "rerum", null, null, "https://picsum.photos/50/50/?image=439", "Quam nesciunt aliquid minima consequatur quisquam voluptatem omnis deserunt magnam est excepturi totam aperiam et modi expedita non possimus aut.", null, 169893884, 486, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), "Koch - Raynor", "next-generation Granite extranet" },
                    { 42, "Scarlett Treutel", "assumenda", null, null, "https://picsum.photos/50/50/?image=782", "Accusantium nobis recusandae dolorem dolorem voluptate quo consequatur molestias quo sapiente voluptas praesentium quam quis sit natus dolorum cupiditate minima.", null, 954033015, 743, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "Bechtelar LLC", "Handmade interactive red" },
                    { 43, "Millie Leuschke", "minus", null, null, "https://picsum.photos/50/50/?image=882", "Id et asperiores nihil quia mollitia deserunt magni et blanditiis corrupti hic nihil similique est quis et temporibus facilis atque.", null, 745965062, 817, new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "Thompson, Kulas and Champlin", "connect Profound Bahrain" },
                    { 44, "Sigurd O'Kon", "enim", null, null, "https://picsum.photos/50/50/?image=845", "Quis sint id eos distinctio ut soluta voluptate et omnis similique tempora quasi accusamus non quae consequuntur animi ut laudantium.", null, 860461749, 729, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), "Shields, Waters and MacGyver", "Outdoors Small Metal Pants lime" },
                    { 45, "Martine Kovacek", "excepturi", null, null, "https://picsum.photos/50/50/?image=94", "Rem blanditiis minus nisi quos vel nisi assumenda omnis quia commodi dolorem ut cupiditate nostrum voluptatibus aut recusandae pariatur laboriosam.", null, 485503555, 622, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), "Miller, Nikolaus and Hirthe", "markets Guam IB" },
                    { 46, "Harmony Robel", "ducimus", null, null, "https://picsum.photos/50/50/?image=697", "Vero itaque possimus voluptatum omnis atque eum alias qui ipsa provident et praesentium id qui quo sunt ea dolores aspernatur.", null, 105459484, 887, new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Local), "Klein - Funk", "Stream yellow Home Loan Account" },
                    { 47, "Piper Baumbach", "laboriosam", null, null, "https://picsum.photos/50/50/?image=700", "Dolor quos rerum sit totam et rerum explicabo tempora veniam quis ab quia voluptatem deserunt delectus est sed occaecati sunt.", null, 477850791, 335, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), "Emmerich - Hammes", "PNG strategize vortals" },
                    { 48, "Hans Predovic", "sit", null, null, "https://picsum.photos/50/50/?image=322", "Laudantium delectus animi eligendi facilis quibusdam ullam aut voluptas quidem aut quisquam quos commodi hic praesentium non animi fugiat voluptatum.", null, 492746870, 859, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), "O'Kon, Predovic and Anderson", "Nevada green Buckinghamshire" },
                    { 49, "Olga Rippin", "perferendis", null, null, "https://picsum.photos/50/50/?image=996", "Temporibus voluptates aut nulla et voluptas est quod voluptatem rerum rerum veritatis dolores voluptatem voluptatibus culpa nam aperiam pariatur et.", null, 242317835, 130, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), "Murphy, Hagenes and Kulas", "Sleek Granite Cheese Direct back up" },
                    { 50, "Wendell Raynor", "placeat", null, null, "https://picsum.photos/50/50/?image=347", "Omnis officiis qui dicta doloremque sed rerum labore illum quas amet ab aperiam voluptates officia ratione saepe voluptatem aut officia.", null, 358299002, 946, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), "Bayer, Ebert and Labadie", "multi-byte Gabon Home Loan Account" },
                    { 51, "Milton Baumbach", "accusantium", null, null, "https://picsum.photos/50/50/?image=214", "Velit ipsa quos iusto in eos nobis corporis voluptatem saepe ut distinctio omnis dolore asperiores velit quod fugiat rerum quisquam.", null, 570900779, 108, new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), "Stokes - Prohaska", "cyan Program panel" },
                    { 52, "Davin Welch", "laboriosam", null, null, "https://picsum.photos/50/50/?image=722", "Aliquam accusantium impedit enim ut incidunt qui sapiente omnis laborum deleniti aut excepturi soluta impedit consequatur temporibus perferendis quia suscipit.", null, 125676796, 911, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), "MacGyver LLC", "Borders focus group digital" },
                    { 53, "Jarrett Bogan", "at", null, null, "https://picsum.photos/50/50/?image=177", "Reiciendis dignissimos ea omnis dolores dignissimos aut dignissimos quia necessitatibus fugiat et qui et cum est ex consectetur magnam non.", null, 171210723, 928, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), "Nikolaus - Braun", "reinvent distributed compress" },
                    { 54, "Scot Hills", "corrupti", null, null, "https://picsum.photos/50/50/?image=769", "Atque ea dicta et sit nesciunt quo ut minus perspiciatis beatae optio molestiae aut aut deserunt sed accusantium architecto qui.", null, 263316833, 932, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Veum - Hoeger", "quantify Ergonomic Soft Sausages Sri Lanka" },
                    { 55, "Carey Monahan", "vero", null, null, "https://picsum.photos/50/50/?image=196", "Aliquid commodi enim consequatur et quis sit doloribus ipsum maxime perspiciatis doloribus asperiores adipisci omnis maxime et quam temporibus quia.", null, 923853746, 632, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), "Cassin - McGlynn", "COM Grove Michigan" },
                    { 56, "Kaleb Gulgowski", "molestiae", null, null, "https://picsum.photos/50/50/?image=523", "Sed qui ea et fuga ea quia sit quam quaerat reiciendis libero ipsam vitae repudiandae itaque veritatis laboriosam fugiat voluptates.", null, 218591830, 861, new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), "Stoltenberg - Kris", "Representative International Checking Account" },
                    { 57, "Marietta Friesen", "recusandae", null, null, "https://picsum.photos/50/50/?image=977", "Exercitationem dicta laudantium suscipit dolores in cum alias quas et voluptas perferendis aliquid fugit delectus repellendus nihil cum dolorem vero.", null, 130081666, 412, new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), "Schamberger - Wunsch", "customer loyalty Open-source withdrawal" },
                    { 58, "Kennith Roob", "vero", null, null, "https://picsum.photos/50/50/?image=420", "Incidunt quia nisi magni qui quasi maxime occaecati qui eos id et nesciunt magnam nam ratione dolorem nam eos reprehenderit.", null, 954552687, 605, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), "Hoppe Inc", "Practical mindshare Naira" },
                    { 59, "Myron Cormier", "iste", null, null, "https://picsum.photos/50/50/?image=113", "Natus est commodi occaecati reiciendis exercitationem aut quasi ex repellat sed et dolore et fugit et qui architecto dolores voluptas.", null, 671644475, 723, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "Hintz, Strosin and Armstrong", "generating Algeria compress" },
                    { 60, "Kaylah Prohaska", "labore", null, null, "https://picsum.photos/50/50/?image=91", "Voluptatibus illum atque saepe voluptatem dicta labore exercitationem aut repudiandae nisi aut et asperiores totam sit consequatur enim qui non.", null, 159376873, 71, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "Hettinger - Kuvalis", "El Salvador Colon Profound calculate" },
                    { 61, "Brionna Miller", "sit", null, null, "https://picsum.photos/50/50/?image=1076", "Vel et ad pariatur voluptas possimus sed commodi itaque ullam sed eos ratione cumque quibusdam sint et consequatur quis quia.", null, 462412335, 533, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "Kertzmann Inc", "markets Incredible Rubber Cheese Keys" },
                    { 62, "Orval Hansen", "omnis", null, null, "https://picsum.photos/50/50/?image=871", "At eligendi voluptatem autem quae illum omnis aut iusto officia odio eaque commodi rerum voluptates dolor provident aspernatur dolores ut.", null, 233179769, 982, new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), "Rippin, Keebler and Abbott", "Open-architected maroon Generic Rubber Tuna" },
                    { 63, "Cheyanne Kreiger", "consequatur", null, null, "https://picsum.photos/50/50/?image=867", "Suscipit quia voluptatem error molestiae expedita sed est exercitationem odit quis repudiandae aperiam incidunt voluptate harum neque ullam laudantium dolor.", null, 616884774, 810, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "Carroll Group", "Fort Licensed Fresh Shirt Books, Games & Movies" },
                    { 64, "Furman Funk", "cumque", null, null, "https://picsum.photos/50/50/?image=181", "Explicabo nemo consequuntur qui placeat eum reiciendis asperiores totam veniam totam illum numquam dolorum odio quaerat voluptatem cupiditate rerum hic.", null, 790108337, 110, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), "Williamson Inc", "Sleek Steel Pizza New York Turkish Lira" },
                    { 65, "Nikko Terry", "cupiditate", null, null, "https://picsum.photos/50/50/?image=673", "Deleniti magnam quidem dolorem facere aperiam ut et labore aut occaecati eos consequatur rerum fugit et omnis fugiat officia sit.", null, 480932624, 148, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "Kiehn, Mayer and Kerluke", "Team-oriented paradigms payment" },
                    { 66, "Fred Will", "et", null, null, "https://picsum.photos/50/50/?image=981", "Vel repudiandae est soluta earum hic fugiat voluptatibus amet sunt dolores beatae aliquam tempora nihil minus ut quibusdam et et.", null, 438594225, 766, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "Moen Group", "matrix Hollow reintermediate" },
                    { 67, "Aisha Monahan", "repudiandae", null, null, "https://picsum.photos/50/50/?image=452", "Facere ratione ab maiores vel mollitia est omnis ullam qui exercitationem voluptatem aut praesentium non officiis ut asperiores doloribus sequi.", null, 131055294, 471, new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), "Hauck - Parisian", "Connecticut Legacy invoice" },
                    { 68, "Abdul Howe", "sit", null, null, "https://picsum.photos/50/50/?image=995", "Et sint ipsum non quisquam nam occaecati laborum autem eum maiores magni cumque voluptatem dolorem est dolorem voluptates natus hic.", null, 660712590, 458, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "Spencer, Rau and Brakus", "cyan visualize Licensed Steel Towels" },
                    { 69, "Ellen Heller", "nulla", null, null, "https://picsum.photos/50/50/?image=831", "Et quia autem qui soluta odit facere exercitationem eveniet quod labore nesciunt officiis voluptatem nesciunt reiciendis nihil delectus eos veniam.", null, 301020195, 997, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Erdman - Hermann", "ubiquitous transitional Diverse" },
                    { 70, "Lizeth Howe", "illo", null, null, "https://picsum.photos/50/50/?image=27", "Nihil quam voluptatum atque mollitia sit expedita aut ipsa dicta totam mollitia nihil nihil qui qui ipsum non at vel.", null, 629546110, 639, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), "Olson, Hills and Hilpert", "Rubber success proactive" },
                    { 71, "Hazel Torphy", "natus", null, null, "https://picsum.photos/50/50/?image=498", "Eligendi sequi nesciunt ut magni est nisi quae id distinctio voluptas sint repellat laboriosam sint qui non id architecto sapiente.", null, 331172472, 948, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Becker - Armstrong", "override Avon Russian Federation" },
                    { 72, "Sienna Turcotte", "officia", null, null, "https://picsum.photos/50/50/?image=1055", "Est id ipsa nam et non qui molestiae eius molestias dolorem qui aut qui veniam nihil occaecati reiciendis eum ullam.", null, 498257138, 461, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), "Turcotte - DuBuque", "lavender Customer Cape" },
                    { 73, "Annetta Kertzmann", "et", null, null, "https://picsum.photos/50/50/?image=934", "Ex quasi et enim dolor id et sint ratione commodi laudantium recusandae harum recusandae ipsam est ut dolores magnam inventore.", null, 318703531, 635, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "Bartoletti, Kihn and Wyman", "iterate Facilitator Avon" },
                    { 74, "Cedrick Hammes", "culpa", null, null, "https://picsum.photos/50/50/?image=14", "Delectus aut sint temporibus minus incidunt aut nihil possimus hic architecto molestiae vel ut non nobis repellat eius sint velit.", null, 677800108, 442, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Local), "Cole, Koss and Lynch", "synthesizing Fantastic Practical Concrete Tuna" },
                    { 75, "Jo Roberts", "illum", null, null, "https://picsum.photos/50/50/?image=135", "Eum labore est ipsam provident ipsam non animi quod et eum itaque autem dolor necessitatibus occaecati velit voluptate nobis ea.", null, 873467905, 250, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Vandervort - Lebsack", "Administrator reintermediate Communications" },
                    { 76, "Zachariah Ratke", "qui", null, null, "https://picsum.photos/50/50/?image=920", "Rerum enim illo voluptatum excepturi et vel tempore laudantium quae reprehenderit eos voluptatum nulla dolore laborum sint cum quis ut.", null, 986926352, 175, new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), "Gorczany, Fay and Greenholt", "Metal Glens Investment Account" },
                    { 77, "Alisha Streich", "aperiam", null, null, "https://picsum.photos/50/50/?image=128", "Perferendis cumque et quia est in veritatis ipsum unde molestiae quod fuga rerum molestias consequatur alias magnam corporis molestias et.", null, 354474738, 826, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), "O'Kon Group", "Home Loan Account auxiliary bleeding-edge" },
                    { 78, "Verona Murazik", "recusandae", null, null, "https://picsum.photos/50/50/?image=978", "A officiis beatae ex beatae nemo aperiam et est natus dicta sequi cum molestiae aut iusto sint consequuntur delectus dolores.", null, 478816774, 322, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "Witting LLC", "Forge Regional protocol" },
                    { 79, "Garrett Kutch", "fugit", null, null, "https://picsum.photos/50/50/?image=369", "Et ipsa maxime occaecati delectus et non ducimus eveniet quia non sit est iure aut qui et consectetur exercitationem exercitationem.", null, 568617916, 447, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "Wyman, Halvorson and Spencer", "monitor neural Clothing & Computers" },
                    { 80, "Kavon Breitenberg", "est", null, null, "https://picsum.photos/50/50/?image=194", "Autem modi laboriosam vero ab doloremque dolores deserunt dolorem expedita corrupti ducimus qui velit sed culpa nobis et temporibus repudiandae.", null, 666727458, 367, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Hilll - Kris", "leading edge Cambridgeshire whiteboard" },
                    { 81, "Jon Klocko", "dolorem", null, null, "https://picsum.photos/50/50/?image=1081", "Soluta et illo id accusamus qui quasi vel aut non voluptas debitis et blanditiis veritatis sit aut illum deserunt ducimus.", null, 510072736, 264, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), "Heidenreich - Murazik", "invoice Glens Web" },
                    { 82, "Hildegard Schulist", "fugit", null, null, "https://picsum.photos/50/50/?image=936", "Id praesentium ut consequatur est quia exercitationem et animi corporis placeat dicta autem perspiciatis ipsa quia perferendis iusto dolorem enim.", null, 936872937, 871, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Local), "Thiel, Marquardt and Keeling", "payment Facilitator Michigan" },
                    { 83, "Kenya Macejkovic", "quam", null, null, "https://picsum.photos/50/50/?image=1005", "Eos qui qui ad magni nihil aliquam odit provident eum tenetur sunt et quo voluptate ut explicabo consequatur amet non.", null, 218116785, 189, new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), "Schamberger Group", "Multi-channelled holistic mint green" },
                    { 84, "Kelvin DuBuque", "iste", null, null, "https://picsum.photos/50/50/?image=46", "Sunt laboriosam nihil rerum voluptas ipsam voluptas reiciendis voluptas assumenda eligendi reiciendis dolorem commodi est harum magnam quae rerum ut.", null, 294157038, 649, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), "Roberts - Welch", "Avon transmit Granite" },
                    { 85, "Daija Cremin", "dolorum", null, null, "https://picsum.photos/50/50/?image=150", "Aperiam velit provident vero ipsa dolor ut veniam ut consequatur nesciunt qui id molestiae perferendis et omnis odit sunt laboriosam.", null, 153150332, 392, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), "Rosenbaum - Lynch", "Checking Account Island Montana" },
                    { 86, "Myrna Feest", "repellat", null, null, "https://picsum.photos/50/50/?image=817", "Illo maiores eos libero sit dignissimos velit dolorum et veniam consequuntur reiciendis quia aut aperiam sit commodi dolor minus natus.", null, 200717011, 650, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Conn - Johnson", "cohesive Unbranded Wooden Shirt deposit" },
                    { 87, "Melany Gerhold", "dolorem", null, null, "https://picsum.photos/50/50/?image=247", "Reiciendis sit deleniti aut cupiditate laboriosam qui voluptas explicabo accusamus illo repellat delectus sapiente excepturi dolorum adipisci impedit sunt est.", null, 912798503, 206, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "Bauch - Thiel", "Credit Card Account withdrawal enhance" },
                    { 88, "Rogelio Parker", "ducimus", null, null, "https://picsum.photos/50/50/?image=111", "Commodi illo magnam aliquam voluptatibus illum a odit sed quos quia pariatur suscipit ad cupiditate assumenda illum voluptatum ea ea.", null, 125339383, 391, new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), "Green, Carroll and Hettinger", "harness withdrawal IB" },
                    { 89, "Osbaldo Luettgen", "reiciendis", null, null, "https://picsum.photos/50/50/?image=454", "Veritatis vero sit quos harum molestiae repudiandae ut sit illo aliquid commodi et aut dolores ratione enim consequatur dolore nesciunt.", null, 235964837, 264, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), "Weber, Fritsch and Shields", "Personal Loan Account workforce invoice" },
                    { 90, "Rickey Kuvalis", "aspernatur", null, null, "https://picsum.photos/50/50/?image=618", "Est iusto suscipit quas incidunt sit numquam voluptate earum reiciendis officia non quia et labore odit beatae rerum blanditiis quia.", null, 357993529, 298, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "Smith LLC", "payment Upgradable Streamlined" },
                    { 91, "Rosendo Leuschke", "fugit", null, null, "https://picsum.photos/50/50/?image=339", "Dolore et et nostrum sit aliquam aut aliquid excepturi quam repellat dolore sed consequatur quod officia commodi consequatur nihil animi.", null, 490055087, 80, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), "Zieme Inc", "e-markets Bolivar Fuerte Enterprise-wide" },
                    { 92, "Daniela Zieme", "aut", null, null, "https://picsum.photos/50/50/?image=932", "Consectetur dolores sed fuga maiores est sed vel unde quam expedita non aut molestias doloremque deserunt et asperiores autem omnis.", null, 358402302, 951, new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), "Nienow, Cremin and Moore", "withdrawal firewall Eritrea" },
                    { 93, "Julius Leannon", "sed", null, null, "https://picsum.photos/50/50/?image=54", "Expedita ea ut et provident error ipsa porro dolorem omnis eveniet voluptate et et tempore placeat sit libero ut qui.", null, 813272652, 911, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Hand LLC", "Developer deposit New York" },
                    { 94, "Brad Fahey", "rem", null, null, "https://picsum.photos/50/50/?image=247", "Hic qui quidem quia quis maxime quo eaque nobis natus eaque exercitationem eos sit delectus incidunt assumenda repudiandae qui itaque.", null, 666377396, 63, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "Tillman - Stroman", "Cotton Iowa copy" },
                    { 95, "Elsa Stamm", "distinctio", null, null, "https://picsum.photos/50/50/?image=902", "Iste reprehenderit quia autem qui illo reiciendis fuga et voluptatibus labore vitae quia quo id nobis iste error sed deleniti.", null, 837919911, 524, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), "O'Conner LLC", "Mission Macedonia world-class" },
                    { 96, "Molly Grady", "dolores", null, null, "https://picsum.photos/50/50/?image=445", "Omnis quae non adipisci molestias doloribus provident blanditiis quisquam distinctio eius distinctio velit deleniti eligendi necessitatibus eius nulla totam voluptatem.", null, 815039463, 204, new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), "Rosenbaum LLC", "green teal Intelligent Metal Bike" },
                    { 97, "Graciela Heaney", "iure", null, null, "https://picsum.photos/50/50/?image=814", "Sed quia quae id eaque aspernatur officiis odit est itaque nesciunt corporis fugiat cumque recusandae laudantium sit cumque expedita expedita.", null, 676121552, 315, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), "Kihn - Stanton", "bus Street navigating" },
                    { 98, "Vita Murphy", "cumque", null, null, "https://picsum.photos/50/50/?image=39", "Sed est distinctio et modi soluta enim doloribus est adipisci quae quia id asperiores voluptatum odit incidunt placeat sint dolorem.", null, 674608217, 500, new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), "Williamson - Hackett", "ADP lime tangible" },
                    { 99, "Amely Bergnaum", "repellendus", null, null, "https://picsum.photos/50/50/?image=579", "Est facere omnis a inventore non non in dolores aspernatur ab consequuntur sed eligendi sunt dolores vitae odit animi et.", null, 735914817, 285, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), "Wilderman, Abernathy and Howell", "Arizona Handmade lavender" },
                    { 100, "Delta Hauck", "dolorem", null, null, "https://picsum.photos/50/50/?image=106", "Similique qui quae nulla occaecati earum est mollitia magnam unde ut aut qui incidunt quas odit et doloremque sit incidunt.", null, 831566142, 254, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), "Stamm and Sons", "indigo local Algerian Dinar" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Books_CheckedOutByUserId",
                table: "Books",
                column: "CheckedOutByUserId");
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
                name: "Books");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
