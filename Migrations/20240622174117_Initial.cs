using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechnicalAssessmentRokov.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                    { 1, "Darien Johns", "illo", null, null, "https://picsum.photos/50/50/?image=900", "Consequatur numquam porro similique quam incidunt dolores ut nihil dignissimos deleniti voluptatem tenetur necessitatibus earum quaerat qui debitis amet molestias.", null, 832059508, 771, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Skiles Inc", "bandwidth maximized Bedfordshire" },
                    { 2, "Jace Keeling", "consequuntur", null, null, "https://picsum.photos/50/50/?image=635", "Delectus quos veniam rerum ipsam cumque quo quia ducimus dolores consequatur quia vitae voluptate dolorem quo modi ducimus quos voluptas.", null, 222059148, 773, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "Bogan - Dietrich", "CFP Franc calculate Computers & Electronics" },
                    { 3, "Makenna Stracke", "assumenda", null, null, "https://picsum.photos/50/50/?image=841", "Vero cupiditate quis libero autem repellat ullam vel natus et dolores ut dolores deleniti voluptatem sit aut qui quibusdam et.", null, 942804488, 645, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Gutmann Inc", "aggregate 5th generation Small Steel Sausages" },
                    { 4, "Josephine Kiehn", "totam", null, null, "https://picsum.photos/50/50/?image=434", "Sint consectetur est provident autem aspernatur quos dolores cum consequuntur sequi et nisi cumque impedit et eveniet et praesentium veniam.", null, 322131543, 580, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Auer - Armstrong", "Avon Investment Account Investment Account" },
                    { 5, "Matteo Beer", "voluptatem", null, null, "https://picsum.photos/50/50/?image=819", "Omnis in quas porro ducimus molestias quidem ipsam esse omnis voluptatem reprehenderit amet ex ex qui rem sapiente et quia.", null, 122892653, 72, new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), "Murazik Group", "Small Personal Loan Account Compatible" },
                    { 6, "Rigoberto Kertzmann", "qui", null, null, "https://picsum.photos/50/50/?image=918", "Distinctio quia molestias vel excepturi consequuntur corporis nobis sed eum consequatur sed ut aut cupiditate modi tempora nam amet totam.", null, 173100803, 627, new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), "Reichert, Orn and Runte", "Consultant Fantastic Wooden Chips Assurance" },
                    { 7, "Jay Ritchie", "minus", null, null, "https://picsum.photos/50/50/?image=28", "Voluptatem aspernatur eum qui quisquam aperiam consequatur quis aliquam doloremque labore earum harum qui ducimus repellendus ratione quod debitis qui.", null, 193084541, 563, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), "Simonis, Walsh and Yost", "Home Loan Account open-source pixel" },
                    { 8, "Alf Hodkiewicz", "laborum", null, null, "https://picsum.photos/50/50/?image=932", "Et qui voluptatem quasi sint voluptas maiores iusto totam facere laboriosam reprehenderit accusamus amet sed rerum asperiores quaerat fugit ut.", null, 418684516, 953, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Local), "Collier, Batz and Crooks", "Functionality synergies Money Market Account" },
                    { 9, "Sunny Halvorson", "et", null, null, "https://picsum.photos/50/50/?image=922", "Nobis minus similique magni quibusdam veritatis atque saepe aut officia aspernatur ipsa architecto ex ex nobis accusantium aperiam exercitationem quis.", null, 597378609, 111, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Local), "Langworth, Parker and Medhurst", "Ferry Rubber navigate" },
                    { 10, "Leola Monahan", "dolore", null, null, "https://picsum.photos/50/50/?image=1043", "Ut et molestiae reiciendis sed quam fugiat quis dicta temporibus consequatur et animi error adipisci sint autem eius est reprehenderit.", null, 540713010, 223, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), "Nicolas and Sons", "connecting generate Rubber" },
                    { 11, "Louisa Ernser", "accusantium", null, null, "https://picsum.photos/50/50/?image=71", "Modi asperiores odio omnis distinctio ipsam consequatur consequatur voluptate pariatur laboriosam consequatur quidem et tempora accusamus facere nesciunt numquam ipsam.", null, 958184573, 107, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), "Tremblay - Cronin", "Personal Loan Account Producer Summit" },
                    { 12, "Leonard Rogahn", "ut", null, null, "https://picsum.photos/50/50/?image=536", "Inventore praesentium quia animi ut illo aperiam numquam dolores dolores ut cumque sint et inventore eum qui autem non atque.", null, 103254055, 784, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Local), "Kuphal - Feest", "success Focused Cuba" },
                    { 13, "Stacey O'Reilly", "eligendi", null, null, "https://picsum.photos/50/50/?image=405", "Nisi dolores culpa dignissimos velit ipsa ea quibusdam et laudantium repudiandae et placeat est possimus possimus labore aperiam error aut.", null, 488555280, 686, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), "Tillman - Rohan", "Marketing Dynamic AGP" },
                    { 14, "Frida Lemke", "ducimus", null, null, "https://picsum.photos/50/50/?image=1005", "Totam alias non est harum omnis quaerat et tempore deleniti unde ut sit et veniam tempora occaecati tempore est quisquam.", null, 931716791, 722, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), "Veum - Ebert", "Square payment Handmade Cotton Shirt" },
                    { 15, "Ray Schinner", "ut", null, null, "https://picsum.photos/50/50/?image=458", "Veritatis officia repudiandae sit ipsam delectus enim vitae impedit quis cum voluptate in et recusandae fugit minima dolorem blanditiis quasi.", null, 984759859, 700, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "Johns, Schamberger and Langosh", "redundant back-end Monaco" },
                    { 16, "Lilian Mante", "et", null, null, "https://picsum.photos/50/50/?image=844", "Voluptas rem aut praesentium labore minus excepturi et perferendis est omnis ratione voluptates vel reprehenderit inventore qui quaerat et molestias.", null, 398647302, 263, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Hackett - Feeney", "Uganda Shilling Bahraini Dinar Rustic" },
                    { 17, "Brandy Mueller", "rem", null, null, "https://picsum.photos/50/50/?image=575", "Enim aut est error asperiores non nisi ullam officia iusto omnis excepturi iusto cum qui sunt ea sequi aut nulla.", null, 935125359, 963, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Local), "Kuhic - Kub", "Lock Rest scale" },
                    { 18, "Lola Ziemann", "quos", null, null, "https://picsum.photos/50/50/?image=753", "Aut consectetur modi repudiandae architecto similique pariatur rem itaque esse consectetur repellendus unde dolor quidem et voluptatibus quia atque qui.", null, 953333172, 398, new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), "Walsh Group", "firmware withdrawal Coordinator" },
                    { 19, "Jada Collins", "unde", null, null, "https://picsum.photos/50/50/?image=194", "Et eum id modi fugit eum nobis consectetur ut aspernatur quisquam minus molestias culpa dolor quas est velit facere minus.", null, 623819598, 736, new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "Ratke, Gutmann and Kshlerin", "Grove utilize Crest" },
                    { 20, "Hilma Douglas", "recusandae", null, null, "https://picsum.photos/50/50/?image=1071", "Explicabo tempore reprehenderit delectus voluptatem omnis rerum saepe numquam nihil ratione quis iste nisi nihil porro est necessitatibus assumenda maxime.", null, 105248020, 925, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Local), "Volkman, Bode and Volkman", "expedite Markets Directives" },
                    { 21, "Rodrigo Witting", "cum", null, null, "https://picsum.photos/50/50/?image=421", "Quas et dolore velit modi ut aut doloremque quidem dignissimos minus saepe tenetur tempore est quos omnis dignissimos vitae amet.", null, 783728080, 300, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "Jacobson - McKenzie", "Ethiopia Corners ROI" },
                    { 22, "Bradly Stoltenberg", "quis", null, null, "https://picsum.photos/50/50/?image=209", "Perferendis atque itaque reiciendis voluptatum voluptatem voluptatibus accusantium sit qui aut iusto adipisci totam blanditiis nobis perferendis occaecati dolor nulla.", null, 127127854, 82, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Spinka, Brown and Shields", "card Granite gold" },
                    { 23, "Grant Sanford", "ea", null, null, "https://picsum.photos/50/50/?image=913", "Ex quisquam quaerat id qui omnis qui rerum voluptas eos cumque et excepturi quidem eos nesciunt nam maiores et et.", null, 635715328, 53, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), "Bernhard - Koelpin", "Plastic orange Ecuador" },
                    { 24, "Aaliyah Keebler", "et", null, null, "https://picsum.photos/50/50/?image=10", "Quas sed dolorum voluptas modi et ex dolorum dolore in pariatur accusantium qui ratione inventore animi natus odit error et.", null, 864990197, 713, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), "Grant - Windler", "Cambridgeshire Associate Berkshire" },
                    { 25, "Patricia Luettgen", "soluta", null, null, "https://picsum.photos/50/50/?image=666", "Quia pariatur magni accusamus necessitatibus et rem omnis inventore animi amet est quibusdam accusantium aspernatur sint rerum enim omnis magni.", null, 184166775, 920, new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), "Mohr and Sons", "Alabama bleeding-edge HDD" },
                    { 26, "Kiera Shields", "ea", null, null, "https://picsum.photos/50/50/?image=777", "Fuga et nam est dolores eligendi ut quos quaerat et voluptatem et magni debitis quaerat consectetur soluta quos repellat officiis.", null, 736740695, 793, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "Emmerich, Heaney and Littel", "overriding West Virginia analyzer" },
                    { 27, "Kariane Wiegand", "veritatis", null, null, "https://picsum.photos/50/50/?image=365", "Sint sit fugit rem nesciunt ad quisquam qui reprehenderit dolor quia deleniti qui dolore molestias molestiae consequatur voluptate officia dolorem.", null, 667900069, 176, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), "Armstrong, Jones and Zboncak", "Dynamic one-to-one Riel" },
                    { 28, "Jarred Fadel", "doloribus", null, null, "https://picsum.photos/50/50/?image=914", "Id aspernatur doloremque sit ut aut in quia qui omnis suscipit architecto modi nulla et voluptatibus suscipit cum qui sint.", null, 495418436, 397, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), "Medhurst - Wunsch", "Chief Ergonomic Valley" },
                    { 29, "Terrance Langosh", "fugit", null, null, "https://picsum.photos/50/50/?image=606", "Voluptate placeat ipsum vel assumenda neque et ut necessitatibus dolores libero mollitia cum et impedit fugiat ratione voluptatibus rem quo.", null, 854651691, 867, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Local), "Lang, Bode and Kilback", "Plains Convertible Marks Money Market Account" },
                    { 30, "Vena Waelchi", "sapiente", null, null, "https://picsum.photos/50/50/?image=279", "Reiciendis suscipit eveniet quos voluptas omnis tempora nihil pariatur laborum omnis ut quasi et dolores magni id reiciendis accusantium praesentium.", null, 144845988, 317, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), "Ratke - Leuschke", "bi-directional withdrawal invoice" },
                    { 31, "Ressie Boehm", "quis", null, null, "https://picsum.photos/50/50/?image=499", "Nobis nihil voluptatem velit reiciendis rem dolorem vero minima quis quia praesentium ullam ut quam laudantium voluptate qui sint neque.", null, 718084417, 772, new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), "Hills and Sons", "Sleek Concrete Tuna West Virginia New Hampshire" },
                    { 32, "Eino Davis", "itaque", null, null, "https://picsum.photos/50/50/?image=1060", "Autem earum unde sit molestiae fuga odio et tempore ullam omnis saepe saepe qui doloremque amet sit nihil unde perferendis.", null, 211863156, 650, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), "Schiller - Robel", "wireless Rustic Plastic Shoes content" },
                    { 33, "Arnoldo Hackett", "doloremque", null, null, "https://picsum.photos/50/50/?image=1064", "Sunt maiores et repudiandae animi quo ut maxime aut aut necessitatibus nam officia est recusandae ut fugit deleniti amet neque.", null, 778045509, 446, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "Reynolds Group", "hybrid Dale mobile" },
                    { 34, "Derrick Rohan", "dolores", null, null, "https://picsum.photos/50/50/?image=164", "Pariatur cumque aperiam libero nam laborum et repellendus delectus voluptatem eius suscipit quis voluptatem ipsum a perferendis illum est iure.", null, 234928881, 389, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "Cole and Sons", "Factors extend bifurcated" },
                    { 35, "Elouise Mante", "ab", null, null, "https://picsum.photos/50/50/?image=137", "Suscipit mollitia cumque cupiditate id placeat voluptatem dolorum quis magni doloremque molestiae corrupti quia amet eum qui reprehenderit omnis beatae.", null, 414118112, 688, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), "Zboncak - O'Reilly", "Assimilated Virgin Islands, British Unions" },
                    { 36, "Ivy Kunde", "totam", null, null, "https://picsum.photos/50/50/?image=1052", "Molestiae alias voluptatum aut qui esse fuga qui voluptatum deleniti culpa hic dolores ut inventore soluta reprehenderit eum dolorem doloribus.", null, 170317388, 413, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), "Swaniawski - Windler", "Manor application Concrete" },
                    { 37, "Cathrine Torphy", "in", null, null, "https://picsum.photos/50/50/?image=409", "Beatae et maxime dolorem omnis qui aliquid corporis vel quaerat ut id ullam dolorum nihil laudantium rerum nobis id quos.", null, 119164819, 908, new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "Gaylord and Sons", "Borders Refined Plastic Shirt Plastic" },
                    { 38, "Catharine Bauch", "et", null, null, "https://picsum.photos/50/50/?image=866", "Ut non consequatur veritatis ad molestiae est odit minima id atque adipisci dicta omnis nihil non eligendi in dolor autem.", null, 726726313, 278, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), "Grimes, Upton and Monahan", "technologies Isle of Man Kyrgyz Republic" },
                    { 39, "Rosalinda Ledner", "tempore", null, null, "https://picsum.photos/50/50/?image=1080", "Numquam non id qui assumenda quia ratione voluptate ut expedita tenetur dignissimos tempora voluptatibus similique quia autem rerum nobis molestias.", null, 127560472, 939, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), "Hand, Jakubowski and Grimes", "invoice index Soft" },
                    { 40, "Llewellyn Zemlak", "consectetur", null, null, "https://picsum.photos/50/50/?image=479", "Aut explicabo dolores nemo qui sed cupiditate suscipit quo repellendus repudiandae deserunt possimus dolorum est in incidunt inventore cum et.", null, 635600219, 306, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), "Lubowitz - O'Kon", "West Virginia transmit Buckinghamshire" },
                    { 41, "Lawson Durgan", "labore", null, null, "https://picsum.photos/50/50/?image=360", "Ratione nemo fugit earum id dolorem magnam qui ea porro asperiores et dolore soluta commodi quia quia ut earum accusamus.", null, 620472063, 421, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "McCullough, Purdy and Upton", "Arizona redundant PNG" },
                    { 42, "Ashlynn Lebsack", "quo", null, null, "https://picsum.photos/50/50/?image=249", "Vitae necessitatibus nostrum sed alias non velit fuga nemo expedita deserunt eum velit aut quaerat voluptatibus rerum amet reprehenderit minima.", null, 159647526, 724, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Local), "Kassulke, Rice and Bednar", "content service-desk Paradigm" },
                    { 43, "Jermey Considine", "tempore", null, null, "https://picsum.photos/50/50/?image=590", "Ipsam aut quia et itaque omnis voluptatem voluptate nostrum et iusto doloribus velit eligendi labore odio dolorem et sequi dolorum.", null, 462754355, 903, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "Harber and Sons", "Awesome Rubber Computer RAM Berkshire" },
                    { 44, "Kenton Boyer", "dolores", null, null, "https://picsum.photos/50/50/?image=446", "Tempora consectetur quia corporis eaque nihil sed ipsa minus eveniet sed repellendus explicabo enim rem veniam rerum doloremque et porro.", null, 334528312, 196, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), "Roob, Stanton and Jerde", "optical Gorgeous Cotton Bacon leading-edge" },
                    { 45, "Jacklyn Terry", "et", null, null, "https://picsum.photos/50/50/?image=308", "Illum iste natus quia animi delectus corrupti aut culpa voluptatum nihil voluptatem ea eius vel quia illo accusamus modi quidem.", null, 986565961, 294, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), "O'Hara - Towne", "Generic bus National" },
                    { 46, "Easton Hartmann", "recusandae", null, null, "https://picsum.photos/50/50/?image=1053", "Rerum sequi quae cumque dolorum quia facilis maxime sed dolore iste in nihil aspernatur magnam reprehenderit cumque dolores ut iusto.", null, 402299084, 261, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), "Considine - Smitham", "Concrete olive Brand" },
                    { 47, "Carolanne Flatley", "tempore", null, null, "https://picsum.photos/50/50/?image=683", "Odit est quidem et esse iste magnam iusto voluptas unde quaerat minima ipsam eum molestiae iure quas velit sequi facere.", null, 938903960, 705, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), "Lakin and Sons", "Rustic Soft Salad generate Health & Clothing" },
                    { 48, "Alana Halvorson", "dolor", null, null, "https://picsum.photos/50/50/?image=100", "Incidunt molestiae nesciunt ipsa ex rerum et qui commodi odit vel eligendi dolorem distinctio esse ea debitis voluptatem quaerat omnis.", null, 257732273, 171, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Local), "O'Connell - Muller", "sensor Buckinghamshire Yemeni Rial" },
                    { 49, "Eliezer Beatty", "iure", null, null, "https://picsum.photos/50/50/?image=59", "In rerum pariatur aut saepe non aperiam iusto necessitatibus tenetur sit ipsum temporibus doloribus iusto iusto ratione illum non ut.", null, 773112150, 384, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), "Zboncak Group", "Future-proofed Practical Rubber Tuna B2B" },
                    { 50, "Brady Hermann", "ut", null, null, "https://picsum.photos/50/50/?image=1035", "Vero porro voluptas eveniet et omnis odio impedit et modi quos non et ad qui autem et deserunt voluptatem non.", null, 430768370, 208, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Local), "DuBuque Group", "mint green maximized Kip" },
                    { 51, "Ulises Fay", "commodi", null, null, "https://picsum.photos/50/50/?image=476", "Eveniet qui aut unde dolorem repudiandae illum provident voluptas non ut tenetur officiis dolore alias qui excepturi ullam sint ad.", null, 646283230, 198, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Mante - Gulgowski", "web services Borders Books & Outdoors" },
                    { 52, "Wilhelmine Kling", "doloribus", null, null, "https://picsum.photos/50/50/?image=954", "Voluptate et accusantium repellat placeat quia dignissimos qui excepturi nihil molestias et eius sit id voluptatem omnis corrupti quia non.", null, 956586232, 869, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Local), "Stoltenberg - King", "PNG Practical Granite Hat Mill" },
                    { 53, "Sandy Predovic", "ipsam", null, null, "https://picsum.photos/50/50/?image=101", "Culpa perferendis et et pariatur dolorem autem facilis accusamus et ad voluptate officia eum aut exercitationem sed sed commodi ducimus.", null, 534133716, 261, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Local), "Willms - Klein", "evolve Usability Home Loan Account" },
                    { 54, "Reagan Torp", "quidem", null, null, "https://picsum.photos/50/50/?image=347", "Quos qui cum voluptatem animi illo non qui est sed sequi qui non ab distinctio tempore omnis eligendi in voluptas.", null, 625164089, 957, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "Turner, O'Keefe and Yost", "deposit Cambridgeshire Credit Card Account" },
                    { 55, "Emelia Grant", "omnis", null, null, "https://picsum.photos/50/50/?image=838", "Amet unde rerum eius aliquam numquam laborum fugiat illum incidunt sunt architecto voluptas labore dolorum earum explicabo provident ut provident.", null, 563719076, 517, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Local), "Kub and Sons", "Crest Ergonomic Frozen Fish Shore" },
                    { 56, "Alexandro Rohan", "voluptatem", null, null, "https://picsum.photos/50/50/?image=219", "Aut ut sit numquam aut qui qui sint nihil voluptatem provident quae numquam aut est dolores eveniet sint modi dolorum.", null, 387981840, 429, new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), "Schneider and Sons", "California open-source Internal" },
                    { 57, "Petra Ankunding", "numquam", null, null, "https://picsum.photos/50/50/?image=917", "Placeat cum aut consequatur ut eos nisi repellendus fuga in vel molestias beatae tempora corrupti ab culpa laboriosam commodi eos.", null, 834949702, 174, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "Sauer and Sons", "Oregon Refined Cotton Chair infrastructure" },
                    { 58, "Kyleigh Bechtelar", "eligendi", null, null, "https://picsum.photos/50/50/?image=13", "Consequuntur eius sint enim sunt nihil perspiciatis inventore distinctio veritatis molestiae ipsum eum tempora sint unde fugiat qui et eius.", null, 245886461, 847, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "Vandervort, Windler and Tillman", "British Indian Ocean Territory (Chagos Archipelago) Home Loan Account Small" },
                    { 59, "Dell Shields", "quibusdam", null, null, "https://picsum.photos/50/50/?image=335", "Suscipit voluptatem numquam modi non et et omnis qui architecto aliquam amet impedit et ex ipsum iusto est veritatis itaque.", null, 673148472, 741, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "Lehner, Lowe and Jacobs", "Small Plastic Bike Netherlands Antillian Guilder Bedfordshire" },
                    { 60, "Samantha Kling", "veniam", null, null, "https://picsum.photos/50/50/?image=263", "Et earum accusamus nesciunt omnis eos magnam ut placeat maxime consectetur dolores ea est quaerat qui rem qui maiores illum.", null, 113529586, 678, new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), "Predovic Group", "transmitting transmit orange" },
                    { 61, "Ollie Berge", "laborum", null, null, "https://picsum.photos/50/50/?image=427", "Voluptatem sapiente eveniet recusandae ducimus ut inventore voluptatum qui sequi iste non omnis nobis eligendi nemo animi dolorum ea ut.", null, 455273943, 145, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "Bruen, Gislason and Kunde", "Tasty Shoes & Garden Future" },
                    { 62, "Hailee Breitenberg", "officiis", null, null, "https://picsum.photos/50/50/?image=785", "Quasi natus et non non quis veniam beatae sunt non vel eos et sit in optio fugiat sed omnis voluptatem.", null, 929218674, 188, new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Local), "Kemmer Inc", "Internal SSL Unbranded Granite Bike" },
                    { 63, "Clemens Barrows", "perferendis", null, null, "https://picsum.photos/50/50/?image=604", "Voluptas numquam ab qui inventore nostrum quidem non et minima voluptatem ut odio qui sapiente consequatur vel sint temporibus optio.", null, 860347076, 526, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), "Mitchell LLC", "Technician Future Bahamian Dollar" },
                    { 64, "Jean Koepp", "aliquam", null, null, "https://picsum.photos/50/50/?image=816", "Quam dolores et voluptatem iusto et accusamus explicabo eligendi non vel quis eveniet cum beatae libero in non qui quia.", null, 141856042, 827, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "Powlowski LLC", "TCP Ergonomic Awesome Concrete Bacon" },
                    { 65, "Savanah Russel", "tenetur", null, null, "https://picsum.photos/50/50/?image=132", "Ea culpa in placeat dolores reprehenderit qui architecto et et doloremque non assumenda necessitatibus nemo laborum nobis sed ut et.", null, 738930411, 332, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), "Orn, Mosciski and Stanton", "Re-contextualized Cotton feed" },
                    { 66, "Joyce Kozey", "provident", null, null, "https://picsum.photos/50/50/?image=346", "Qui placeat magnam fugit dolores dolores quam voluptatem est autem iure dicta quis repellendus praesentium sed earum doloremque dignissimos rem.", null, 150794982, 171, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), "Towne, Dooley and Will", "Ukraine Station Bahamian Dollar" },
                    { 67, "Freida Witting", "non", null, null, "https://picsum.photos/50/50/?image=836", "Rerum occaecati mollitia cumque temporibus veniam perspiciatis reprehenderit ab a accusantium provident facere ullam vel error magni ad enim magni.", null, 641309118, 226, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), "Ondricka - Goldner", "Kuwait Officer back up" },
                    { 68, "Tristin Nienow", "enim", null, null, "https://picsum.photos/50/50/?image=646", "Eveniet aut minima iure aperiam sunt qui qui ipsam tempora dignissimos ea ut placeat ea possimus voluptatem culpa repellat iure.", null, 659562424, 611, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "Walker - Thompson", "purple Regional Small" },
                    { 69, "Maryjane Wehner", "modi", null, null, "https://picsum.photos/50/50/?image=805", "Quisquam est est repellendus quas voluptate architecto quam voluptatem rerum repellat maiores aut ipsam quis cum placeat perspiciatis a nobis.", null, 298988676, 800, new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), "McGlynn, Yost and Schiller", "Awesome Licensed complexity" },
                    { 70, "Wilhelmine Nitzsche", "non", null, null, "https://picsum.photos/50/50/?image=46", "Culpa mollitia soluta perspiciatis veniam maiores voluptatem laudantium ut aliquid asperiores qui impedit voluptatem sint reiciendis excepturi et et sed.", null, 882181330, 814, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "Kuhn - Christiansen", "FTP Business-focused Consultant" },
                    { 71, "Keanu Bayer", "saepe", null, null, "https://picsum.photos/50/50/?image=258", "Maiores pariatur harum quasi consequatur sint ut rerum quia voluptate quod aliquid aut rerum cumque vel nostrum sed ad officiis.", null, 700216059, 692, new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "Monahan - Medhurst", "Future Florida Liaison" },
                    { 72, "Brain Weber", "architecto", null, null, "https://picsum.photos/50/50/?image=632", "Velit consequatur aspernatur fuga dolorem et velit consequatur excepturi libero animi repellat sapiente aliquam dolores eaque est optio omnis fuga.", null, 799842134, 262, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Streich and Sons", "incubate Directives solid state" },
                    { 73, "Gavin Dooley", "expedita", null, null, "https://picsum.photos/50/50/?image=149", "Sed quo voluptatem praesentium nihil est velit at atque deserunt iusto rerum quia voluptate minus iusto et odio voluptas harum.", null, 792846364, 989, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), "Hoppe - Collier", "Ohio workforce Quality" },
                    { 74, "Kellen Kris", "eius", null, null, "https://picsum.photos/50/50/?image=174", "Et sunt quas dolorem debitis ut voluptatem ut laudantium aut ipsa quam veniam possimus voluptas provident illum dolor consectetur adipisci.", null, 500826797, 812, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Wilkinson and Sons", "object-oriented Steel static" },
                    { 75, "Wilton Jaskolski", "aliquid", null, null, "https://picsum.photos/50/50/?image=935", "In cupiditate rem ipsam officiis veritatis cum voluptates ea vel nesciunt corporis repudiandae magnam facere et repellat est maxime cupiditate.", null, 830075973, 368, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "Gottlieb, Ratke and Kiehn", "navigating extend Extension" },
                    { 76, "Beryl Emard", "beatae", null, null, "https://picsum.photos/50/50/?image=733", "Dolore vero quasi autem nisi iste a ipsam culpa sunt vitae ipsam doloribus cumque et molestiae labore qui dolorum sapiente.", null, 287489454, 788, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), "Botsford, Fadel and Cassin", "Rustic Wooden Mobility" },
                    { 77, "Teagan Howe", "totam", null, null, "https://picsum.photos/50/50/?image=106", "Aliquid qui voluptates autem eius vel a repudiandae recusandae illo est blanditiis perspiciatis laboriosam amet est impedit non ipsam nesciunt.", null, 134847529, 434, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "Miller - Hansen", "Sleek Fresh Shirt AI JBOD" },
                    { 78, "Sophie Bergnaum", "voluptas", null, null, "https://picsum.photos/50/50/?image=423", "Voluptas cupiditate vitae quae cupiditate dolores corporis nesciunt suscipit quos aperiam veniam itaque qui voluptate aspernatur illum omnis odio consequatur.", null, 468919168, 846, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), "Mayer, Hirthe and Armstrong", "Colombia open-source Unbranded" },
                    { 79, "Arturo Sawayn", "hic", null, null, "https://picsum.photos/50/50/?image=295", "Omnis voluptatibus laboriosam mollitia maxime accusamus cumque sequi distinctio omnis qui neque at quas repellendus numquam totam nostrum excepturi deleniti.", null, 478302198, 588, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), "Mante - Schowalter", "frame Ergonomic Handcrafted Granite Computer" },
                    { 80, "Candice Kunze", "impedit", null, null, "https://picsum.photos/50/50/?image=38", "Amet accusantium dolores quis maiores corrupti eos tenetur fugit quae ad itaque doloribus doloremque possimus repudiandae cupiditate reprehenderit molestias velit.", null, 684485404, 426, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), "Leannon Inc", "Lebanese Pound Azerbaijanian Manat secondary" },
                    { 81, "Loy Pouros", "voluptatem", null, null, "https://picsum.photos/50/50/?image=456", "Nihil enim consequatur minima vitae nulla quo ipsa error modi ipsa vitae ex sint magni et quo consequatur ad provident.", null, 590360535, 759, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), "Okuneva, Schiller and Crooks", "non-volatile Riel engineer" },
                    { 82, "Jordon Glover", "eos", null, null, "https://picsum.photos/50/50/?image=740", "Hic sed corrupti qui consequatur repellendus molestiae quibusdam eveniet quas sed voluptas quo nostrum itaque fugit culpa consequuntur dicta saepe.", null, 588087579, 343, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Local), "Gerlach - Bashirian", "parse eyeballs embrace" },
                    { 83, "Electa Beahan", "iure", null, null, "https://picsum.photos/50/50/?image=679", "In dolorum sint excepturi aliquam similique qui aut et repellendus exercitationem error saepe expedita et labore hic in quis eaque.", null, 905085171, 781, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), "Cartwright and Sons", "Implementation Home Loan Account programming" },
                    { 84, "Fatima Schimmel", "et", null, null, "https://picsum.photos/50/50/?image=18", "Enim et quia maiores omnis ipsum corporis illo vel sint quis eaque et iste hic voluptate provident ad eveniet sunt.", null, 650829959, 387, new DateTime(2023, 9, 6, 0, 0, 0, 0, DateTimeKind.Local), "Hirthe, Kris and Nader", "Plastic Ergonomic Steel Shoes navigating" },
                    { 85, "Rhianna Hyatt", "magni", null, null, "https://picsum.photos/50/50/?image=179", "Debitis provident fugit delectus aperiam atque expedita sed ut facilis eos perspiciatis neque quia harum eum eligendi vel nesciunt odit.", null, 464255541, 460, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "Vandervort, Beer and Gleichner", "synthesize Metal Codes specifically reserved for testing purposes" },
                    { 86, "Salvatore Schulist", "qui", null, null, "https://picsum.photos/50/50/?image=838", "Suscipit aspernatur blanditiis assumenda et ea et laborum aut velit quam tempora qui dolores quaerat et atque officia blanditiis odio.", null, 431949891, 392, new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "McClure - Pfeffer", "Auto Loan Account Handmade Plastic Car Ways" },
                    { 87, "Kaci Abshire", "qui", null, null, "https://picsum.photos/50/50/?image=182", "Natus et maiores possimus repellendus cupiditate placeat id eligendi in sit eveniet aut nostrum quo sed fugiat vel delectus aut.", null, 683114013, 537, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), "Terry LLC", "Analyst e-markets out-of-the-box" },
                    { 88, "Grayson Price", "aperiam", null, null, "https://picsum.photos/50/50/?image=971", "Modi et maxime ea earum minima unde magni neque a asperiores ut quod ea harum id ratione inventore dolores et.", null, 902343856, 154, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), "Jacobi - Cormier", "communities hack innovative" },
                    { 89, "Lew Cummings", "in", null, null, "https://picsum.photos/50/50/?image=860", "Exercitationem eius cum non ipsam quam consequatur itaque distinctio beatae doloribus est est nihil quam neque ipsum qui unde est.", null, 153006258, 917, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "Yost Group", "Quality infrastructures technologies" },
                    { 90, "Enos Keebler", "molestiae", null, null, "https://picsum.photos/50/50/?image=273", "Vel veritatis praesentium illum suscipit consequuntur sequi consequatur corrupti veritatis fugiat nihil id consequatur sit vero et tempore autem enim.", null, 436216871, 577, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Schoen Group", "bi-directional mesh CSS" },
                    { 91, "Millie Roob", "aut", null, null, "https://picsum.photos/50/50/?image=133", "Numquam modi fugit nisi explicabo voluptates at nisi ullam minus dolorem iste nulla qui repellat ab corporis temporibus rerum eos.", null, 632937209, 162, new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "Harris Group", "wireless Cape Verde Escudo portals" },
                    { 92, "Mercedes Schuppe", "doloremque", null, null, "https://picsum.photos/50/50/?image=634", "Reiciendis qui eos vitae deserunt ut veritatis pariatur voluptatem tenetur labore blanditiis non ullam reiciendis hic deleniti est ut et.", null, 530486094, 479, new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "Mann, White and Kozey", "Road Sports, Baby & Toys Investment Account" },
                    { 93, "Phoebe Ziemann", "ullam", null, null, "https://picsum.photos/50/50/?image=505", "At velit officiis qui magni eius accusamus cupiditate in vel omnis cupiditate non consequatur qui voluptatem voluptas est quisquam labore.", null, 917530570, 251, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), "Williamson, Jacobs and Konopelski", "Avon copy Cove" },
                    { 94, "Tyra Pollich", "quas", null, null, "https://picsum.photos/50/50/?image=629", "Ut recusandae et pariatur similique sed repellendus dolorum sit itaque dolore sit quo et veniam adipisci dolor officiis doloremque quasi.", null, 217422792, 584, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), "Hintz, Mueller and Langosh", "Operations Research seamless" },
                    { 95, "Claire Farrell", "ut", null, null, "https://picsum.photos/50/50/?image=919", "Optio commodi consectetur iusto delectus dicta id qui rerum quo ipsa vero et vitae aut aut ullam provident voluptate corrupti.", null, 593213049, 463, new DateTime(2023, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "West - Keebler", "moratorium Arkansas Creative" },
                    { 96, "Edwina Schuster", "quidem", null, null, "https://picsum.photos/50/50/?image=899", "Reiciendis molestias quibusdam ipsa voluptatem fugit magnam doloribus quia et ut quidem et dignissimos minima molestiae neque culpa saepe consequatur.", null, 851614874, 894, new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), "Howell - Emmerich", "Personal Loan Account bypass Tasty Steel Sausages" },
                    { 97, "Hailie Jakubowski", "deserunt", null, null, "https://picsum.photos/50/50/?image=882", "Dignissimos dignissimos assumenda ducimus delectus eum nulla corrupti id eveniet illo asperiores dolores doloremque rerum nam consectetur itaque enim explicabo.", null, 386040341, 688, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "D'Amore Inc", "extranet Supervisor Soft" },
                    { 98, "Ladarius Satterfield", "earum", null, null, "https://picsum.photos/50/50/?image=644", "Sed vel ea molestias et debitis iusto et consequatur quibusdam incidunt qui repudiandae tenetur nostrum est dolor non sint sed.", null, 222012490, 760, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), "Kling LLC", "Sports & Baby Bedfordshire Executive" },
                    { 99, "Mireille Schneider", "sed", null, null, "https://picsum.photos/50/50/?image=849", "Qui ut nam aut sit nam distinctio consequatur dolor ut molestiae ipsa et repellat sed molestiae nam dignissimos odio excepturi.", null, 115753408, 65, new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), "Wyman Inc", "Expanded help-desk auxiliary" },
                    { 100, "Jocelyn Parisian", "et", null, null, "https://picsum.photos/50/50/?image=1014", "Voluptatibus rerum officiis quae sint voluptatem consequatur ut ipsam vero voluptate possimus iure suscipit exercitationem eos aut distinctio laboriosam expedita.", null, 667294388, 352, new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), "Buckridge Inc", "Forward leading edge Assistant" }
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
