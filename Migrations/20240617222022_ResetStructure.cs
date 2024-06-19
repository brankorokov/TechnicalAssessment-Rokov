﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechnicalAssessmentRokov.Migrations
{
    /// <inheritdoc />
    public partial class ResetStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    PAGE_COUNT = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserAccounts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USER_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PASSWORD = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ROLE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccounts", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "AUTHOR", "CATEGORY", "COVER_PAGE", "DESCRIPTION", "ISBN", "PAGE_COUNT", "PUBLICATION_DATE", "PUBLISHER", "TITLE" },
                values: new object[,]
                {
                    { 1, "Madge Lang", "totam", "https://picsum.photos/50/50/?image=516", "Aliquid eum laborum quis sunt non eligendi ullam deleniti debitis doloremque unde perspiciatis laudantium voluptas molestiae ad odio quasi voluptatem.", 371573908, 521, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "Leuschke - Cormier", "Electronics & Tools bypassing California" },
                    { 2, "Mireya McCullough", "laudantium", "https://picsum.photos/50/50/?image=438", "Enim distinctio quia commodi dolores consequuntur nisi consequuntur doloribus deleniti quidem qui qui saepe iusto eum est sequi molestias reiciendis.", 743899247, 403, new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "Berge - Terry", "communities withdrawal Frozen" },
                    { 3, "Kayla Halvorson", "nulla", "https://picsum.photos/50/50/?image=365", "Doloremque possimus atque quam sunt inventore vel quibusdam nemo iure culpa quo eligendi sed rerum saepe sit quaerat sint vel.", 204433492, 62, new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), "Morar, Willms and Schowalter", "infrastructures web-readiness protocol" },
                    { 4, "Edward Kiehn", "dolor", "https://picsum.photos/50/50/?image=553", "Dolorem praesentium occaecati necessitatibus voluptas repellendus dolore sed temporibus quod ut qui repellat voluptatem labore et molestiae accusantium maxime alias.", 146470699, 664, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), "Glover - Hermann", "payment integrated Home Loan Account" },
                    { 5, "Bettye Wisozk", "aut", "https://picsum.photos/50/50/?image=795", "Est quos voluptatem dolores adipisci sapiente dolorum corporis recusandae laudantium et possimus nisi autem et amet beatae unde in tempora.", 702131600, 176, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), "Daugherty, Shanahan and Lebsack", "pixel Avon holistic" },
                    { 6, "Malcolm Shields", "hic", "https://picsum.photos/50/50/?image=223", "Molestias ut alias et qui reprehenderit ducimus qui odio non illo quas dolores neque consequatur quam quia quis delectus non.", 707457854, 321, new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), "Connelly, Kerluke and Nikolaus", "Personal Loan Account Pitcairn Islands Forge" },
                    { 7, "Emilie Swaniawski", "accusamus", "https://picsum.photos/50/50/?image=783", "Illo in sit in pariatur voluptatem enim tempora rerum pariatur voluptatum quia in asperiores deleniti possimus maxime iste repellendus officiis.", 790781708, 467, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), "Mayer, Quigley and Rippin", "Plastic Pike ubiquitous" },
                    { 8, "Luis Krajcik", "aut", "https://picsum.photos/50/50/?image=699", "Repellat rerum molestiae est qui sint et et assumenda aut corrupti minima veniam fuga est fuga vero cupiditate eaque voluptatem.", 902883336, 356, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), "Wiza, Cummerata and Weber", "overriding deliver Chief" },
                    { 9, "Odell Schimmel", "corporis", "https://picsum.photos/50/50/?image=747", "Adipisci libero est distinctio maiores nesciunt sint facilis beatae facilis rem voluptatum aperiam reprehenderit voluptatem unde ut quaerat molestiae magnam.", 979979712, 565, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "Keeling, McKenzie and Gorczany", "National white quantify" },
                    { 10, "Paige Feeney", "est", "https://picsum.photos/50/50/?image=842", "Non quas omnis ducimus consequatur deleniti quod labore asperiores quia magni atque voluptatem rerum neque odio sed esse ea aut.", 735164012, 340, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), "Bailey and Sons", "Liechtenstein withdrawal software" },
                    { 11, "Cleta Price", "commodi", "https://picsum.photos/50/50/?image=386", "Incidunt adipisci inventore voluptatem amet non sit aliquid facere maiores voluptatem et facilis eius culpa iusto sit odio libero iure.", 494481323, 994, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), "Boehm - Glover", "Handcrafted Rubber Mouse Cotton matrix" },
                    { 12, "Alyson Walter", "fugiat", "https://picsum.photos/50/50/?image=403", "Ut officiis a perferendis qui veniam molestias harum qui dolorum temporibus quis asperiores culpa id ducimus recusandae nulla veniam fuga.", 129015943, 484, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), "Langworth and Sons", "SSL Liaison Gorgeous" },
                    { 13, "Catalina Emard", "aut", "https://picsum.photos/50/50/?image=379", "Aperiam a ut similique placeat voluptates sequi deleniti quisquam ratione est velit impedit consequuntur et quia cupiditate qui quod voluptatum.", 418736660, 501, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), "Little, O'Kon and Willms", "Rustic Metal Gloves Cotton Metrics" },
                    { 14, "Shania Pacocha", "voluptate", "https://picsum.photos/50/50/?image=137", "Facilis quia possimus modi animi et voluptas harum natus quidem doloremque sint temporibus corrupti non autem facilis autem iste quia.", 770407573, 292, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), "Kshlerin and Sons", "alarm Buckinghamshire backing up" },
                    { 15, "Marie Feeney", "ut", "https://picsum.photos/50/50/?image=1049", "Consequatur sunt quos sit sapiente soluta deleniti blanditiis et quidem architecto consectetur ut vitae omnis in sit ad voluptate molestiae.", 411179307, 601, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Jaskolski, Hirthe and Keeling", "optical bluetooth cyan" },
                    { 16, "Lane Bartoletti", "quam", "https://picsum.photos/50/50/?image=841", "Asperiores corporis aut ut et perspiciatis odio deserunt eveniet quod impedit numquam ut voluptatem fugiat excepturi et autem laborum asperiores.", 715948820, 225, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "Abbott, Jones and Schaefer", "Credit Card Account Movies Virginia" },
                    { 17, "Tressa Streich", "voluptas", "https://picsum.photos/50/50/?image=471", "Deleniti qui ut accusamus quasi non dolores possimus et eos doloribus odit omnis nihil nam repellendus ullam aliquid praesentium aperiam.", 297886920, 588, new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), "Gorczany Group", "Chief Personal Loan Account Mississippi" },
                    { 18, "Ebony Dicki", "repudiandae", "https://picsum.photos/50/50/?image=95", "Earum quam eum consequatur unde blanditiis temporibus magni et fugit adipisci rerum quibusdam aperiam sed iusto animi quidem voluptatibus eos.", 890654102, 912, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), "Cummerata - Franecki", "Ports Station synergies" },
                    { 19, "Elmore Nicolas", "adipisci", "https://picsum.photos/50/50/?image=155", "Aperiam cupiditate est veniam inventore tempora ipsa et qui consequatur qui quis similique explicabo odit ea rerum consequatur eos similique.", 539165734, 830, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), "Goodwin, McClure and Langosh", "Street pixel Fantastic Concrete Fish" },
                    { 20, "Vivien Leffler", "aspernatur", "https://picsum.photos/50/50/?image=1011", "Est eum dolorem voluptatem excepturi eum molestiae laborum doloremque inventore fuga in qui eum illum unde praesentium officia ad aut.", 333451232, 634, new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "Bergnaum and Sons", "Court strategic Garden & Garden" },
                    { 21, "Cindy Adams", "ipsum", "https://picsum.photos/50/50/?image=438", "Consequatur quam corrupti voluptates debitis cupiditate dolorum quia neque et ut ea in velit porro qui asperiores omnis et qui.", 473914166, 560, new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), "Romaguera, Bruen and McCullough", "Lebanese Pound Sports & Health Berkshire" },
                    { 22, "Geoffrey Huels", "vero", "https://picsum.photos/50/50/?image=711", "In consequatur perspiciatis qui fuga et quo molestiae et consequatur esse iste sed atque magnam nihil asperiores voluptatem voluptas sed.", 479846557, 376, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), "Kuvalis, Herman and Lynch", "Rustic Fresh Shirt Haiti XSS" },
                    { 23, "Barney Windler", "vel", "https://picsum.photos/50/50/?image=226", "Enim fugiat eveniet in sapiente rerum qui id id expedita libero voluptate et molestias quis deleniti fugiat nisi minus autem.", 149570147, 875, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "Pfeffer - Nolan", "Serbia parse Directives" },
                    { 24, "Chauncey Jones", "eveniet", "https://picsum.photos/50/50/?image=777", "Qui est quae beatae quia unde sit voluptas rem voluptatem voluptatum voluptas ut et voluptatum occaecati dicta et qui aut.", 760666234, 461, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), "Steuber, Murazik and Kshlerin", "River Papua New Guinea Circle" },
                    { 25, "Cayla Witting", "assumenda", "https://picsum.photos/50/50/?image=560", "Est sed repellendus sint et et corporis possimus illo dolores saepe sequi eum quas repellendus cumque velit error quos earum.", 857676432, 392, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Stark - Hermiston", "silver interactive architecture" },
                    { 26, "Everardo Ullrich", "dolorem", "https://picsum.photos/50/50/?image=437", "Corporis ut enim veniam et dolore et velit ad distinctio quidem qui vel ab error similique dolorum aperiam voluptatem neque.", 428495078, 238, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "Schinner - Batz", "visualize intuitive program" },
                    { 27, "Juliana Haag", "eaque", "https://picsum.photos/50/50/?image=72", "Culpa exercitationem vel dolores assumenda et inventore quam delectus minus dicta aliquid ut dolores repudiandae eveniet sit in ab accusamus.", 561983063, 421, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), "Walsh LLC", "Dong SSL Ukraine" },
                    { 28, "Milford Schroeder", "reiciendis", "https://picsum.photos/50/50/?image=710", "Quia sint iste voluptatem minus qui odit qui iusto sunt exercitationem odio et dignissimos consectetur ullam placeat aperiam doloremque qui.", 216229626, 806, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), "Berge, Jacobs and Botsford", "Texas magenta Awesome Soft Pizza" },
                    { 29, "Kathryn Bode", "explicabo", "https://picsum.photos/50/50/?image=851", "Alias corrupti ea unde modi aut voluptas quia est nulla et nulla qui nihil ullam qui harum voluptatem dolorem et.", 112829357, 338, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), "Schroeder, Schuster and Mills", "parsing e-markets Human" },
                    { 30, "Rusty Yost", "sint", "https://picsum.photos/50/50/?image=5", "Rerum laudantium sit rem velit vel ex et autem sed fuga doloribus laborum animi omnis et fuga ex eligendi ex.", 784882285, 290, new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), "Reichert Inc", "Plastic Paradigm Horizontal" },
                    { 31, "Karen Feest", "quibusdam", "https://picsum.photos/50/50/?image=914", "Accusantium fugiat amet libero molestiae quos accusamus quos fuga iste ducimus enim sint veniam nam et magnam odio recusandae et.", 509052475, 858, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Satterfield, Labadie and Hamill", "Fantastic Rubber Pants Beauty process improvement" },
                    { 32, "Alejandrin Lubowitz", "quaerat", "https://picsum.photos/50/50/?image=170", "Dolores veniam est rerum atque temporibus aliquam aliquam illo quasi debitis non nihil et facilis et quis id laborum voluptatem.", 167597620, 930, new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), "Block, Kulas and Bosco", "Sleek Credit Card Account compressing" },
                    { 33, "Marley McCullough", "aut", "https://picsum.photos/50/50/?image=940", "Non et repellendus temporibus et minima consequatur soluta consequuntur culpa cum facilis quae ipsum rem ut nobis non deserunt ut.", 903590152, 441, new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), "Rice - Nikolaus", "Ergonomic Cameroon Developer" },
                    { 34, "Danielle Cole", "officiis", "https://picsum.photos/50/50/?image=794", "Occaecati itaque nulla repellat ut non incidunt vero sint repellat consequatur eum similique explicabo eaque temporibus et et autem voluptatem.", 542005903, 558, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), "Pagac, Blanda and Walker", "Checking Account Granite Unbranded" },
                    { 35, "Eula Conn", "nihil", "https://picsum.photos/50/50/?image=901", "Qui vel occaecati voluptatem occaecati sint architecto qui dolorem quae optio cum autem nulla sed non nesciunt nisi quae eos.", 624722456, 339, new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), "Dooley, Ward and Schinner", "bluetooth Ergonomic Regional" },
                    { 36, "Nyah Homenick", "exercitationem", "https://picsum.photos/50/50/?image=193", "Totam quas debitis voluptas adipisci atque commodi molestiae nisi quam qui natus dolore pariatur aperiam et aut deleniti aut dolorem.", 847386727, 884, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), "Gulgowski - Hilpert", "SDD synthesizing success" },
                    { 37, "Shaylee Hane", "tempora", "https://picsum.photos/50/50/?image=7", "Excepturi eveniet quibusdam optio amet enim repudiandae non officia id aspernatur maxime sed repudiandae officiis delectus accusamus dolor vel ut.", 155619421, 731, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), "Beatty LLC", "brand end-to-end Analyst" },
                    { 38, "Rylee Stroman", "nemo", "https://picsum.photos/50/50/?image=139", "Enim aut repudiandae exercitationem a maiores voluptas consequatur minus consequatur amet quia mollitia dolor laborum reiciendis amet voluptas nihil excepturi.", 924892285, 929, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), "Bashirian and Sons", "back up Accountability payment" },
                    { 39, "Bradford Berge", "molestiae", "https://picsum.photos/50/50/?image=377", "Corrupti omnis tempora totam consequatur impedit praesentium nesciunt eaque consequatur rerum reprehenderit odio error eaque est voluptatem distinctio in et.", 967572328, 283, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), "Hane, Weissnat and Ullrich", "Berkshire optical haptic" },
                    { 40, "Easton Witting", "tenetur", "https://picsum.photos/50/50/?image=305", "Vel quaerat ea reiciendis nulla enim quia quae a sed eum dignissimos omnis vel aspernatur doloremque earum minima molestiae nam.", 689345858, 954, new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "Daugherty and Sons", "Points Executive frictionless" },
                    { 41, "Dashawn Windler", "architecto", "https://picsum.photos/50/50/?image=920", "Voluptate ab ad incidunt tempore illo consequatur temporibus sapiente quia mollitia veritatis ut et omnis est dolor ea fugiat sunt.", 652908508, 661, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "Ruecker, Schamberger and Kerluke", "Steel Court back-end" },
                    { 42, "Lauryn Bode", "doloremque", "https://picsum.photos/50/50/?image=472", "Est blanditiis distinctio dolores deleniti perferendis asperiores vero cupiditate quidem aut qui voluptatem et aut et est nam velit quibusdam.", 456006965, 239, new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "Schumm Inc", "value-added Mississippi Networked" },
                    { 43, "Rozella Volkman", "adipisci", "https://picsum.photos/50/50/?image=126", "Rerum rerum laboriosam quia mollitia ipsum et et et nisi occaecati quibusdam sed est eveniet incidunt doloremque ratione veritatis ea.", 385814869, 114, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), "Hilpert - Emmerich", "driver mobile Russian Ruble" },
                    { 44, "Timothy Lakin", "non", "https://picsum.photos/50/50/?image=251", "Deserunt voluptatem voluptatum aperiam quod sit beatae consequuntur sunt magni dicta repudiandae omnis voluptatum perspiciatis consequatur laudantium ut officiis ad.", 278229548, 775, new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), "Koss, Williamson and Marks", "Enhanced Loaf deposit" },
                    { 45, "Jayne Boehm", "reiciendis", "https://picsum.photos/50/50/?image=1083", "Doloremque quia ad fugiat in quod tenetur aut est voluptates cumque et quidem repellat aspernatur similique eligendi ex consequuntur aliquam.", 966961663, 118, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Local), "Kassulke, Murphy and Swaniawski", "SQL core withdrawal" },
                    { 46, "Jaycee Walker", "harum", "https://picsum.photos/50/50/?image=425", "Animi rerum doloremque non nobis et qui ea aut omnis et quidem sit et aut minima quia debitis beatae omnis.", 326673108, 128, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "Adams - Dach", "El Salvador haptic Garden" },
                    { 47, "Marjory Morissette", "atque", "https://picsum.photos/50/50/?image=1054", "Sint dolores numquam enim repudiandae quia optio minima magnam numquam ut tempora explicabo id eum mollitia officia voluptas minima rerum.", 942689508, 632, new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), "Thompson Group", "Island Small Rubber Pants Plains" },
                    { 48, "Ed Nolan", "dicta", "https://picsum.photos/50/50/?image=657", "Reprehenderit commodi aut repellat iure velit esse sunt impedit rem neque et alias harum ipsam rem repellat omnis quidem quod.", 528054998, 286, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Corkery, Batz and Blick", "Licensed Plastic Tuna sexy Communications" },
                    { 49, "Constance Harris", "aut", "https://picsum.photos/50/50/?image=733", "Consequatur voluptatum praesentium perferendis dolorem laboriosam velit sed veritatis minima commodi placeat nostrum aspernatur quia qui voluptas corporis sed est.", 295601123, 51, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), "Legros, Gerlach and Blick", "Agent matrix deploy" },
                    { 50, "Brice Ebert", "qui", "https://picsum.photos/50/50/?image=441", "Debitis voluptatem eos minima voluptas quos aut sed maxime hic hic magni atque in labore veritatis sed omnis in eum.", 315042982, 129, new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), "Ward, Terry and Moen", "parsing Guinea Fundamental" },
                    { 51, "April Thompson", "odit", "https://picsum.photos/50/50/?image=1073", "Voluptatem quam ullam ipsa itaque velit sunt deleniti repellendus ullam sit vitae quos dolor repellendus numquam molestiae qui eligendi maiores.", 750123590, 513, new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "Kulas - McCullough", "Practical Fresh Gloves Berkshire black" },
                    { 52, "Baron Cole", "voluptatem", "https://picsum.photos/50/50/?image=757", "Nemo quia sit cupiditate et debitis explicabo non saepe expedita perferendis consequatur dolores qui autem cum ea nam voluptas ad.", 603272044, 187, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Local), "Medhurst LLC", "Investment Account auxiliary Money Market Account" },
                    { 53, "Amy Cronin", "ea", "https://picsum.photos/50/50/?image=213", "Est accusantium maiores nihil consectetur illum nam fuga aut vero non tempora nesciunt nesciunt dolores quam doloremque temporibus voluptas soluta.", 623227603, 61, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), "Bahringer - Turner", "channels card Optimization" },
                    { 54, "Cordell Crona", "laboriosam", "https://picsum.photos/50/50/?image=844", "Accusamus ad sit vel est eum cum recusandae numquam aut culpa tempore quisquam amet harum quaerat dolores delectus accusantium sint.", 822988323, 196, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), "Vandervort Group", "Auto Loan Account mobile bandwidth-monitored" },
                    { 55, "Afton Armstrong", "dignissimos", "https://picsum.photos/50/50/?image=311", "Ut dolor quo accusamus quidem accusantium modi ea alias quia exercitationem eligendi dolorem cum assumenda vitae aut beatae quo libero.", 617796888, 476, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Local), "Balistreri LLC", "dynamic Unbranded Rubber Salad Bahamian Dollar" },
                    { 56, "Vincent Hyatt", "voluptas", "https://picsum.photos/50/50/?image=505", "Asperiores voluptatem aut sapiente rem omnis corrupti facere veritatis veniam sint fuga placeat officiis in necessitatibus rerum sint odio rerum.", 308002227, 801, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Local), "Bogan - Moore", "challenge Parkway Berkshire" },
                    { 57, "Maurine Krajcik", "ea", "https://picsum.photos/50/50/?image=148", "Nam non qui enim veniam quibusdam modi facilis reprehenderit et recusandae nam et molestias ipsa et cum neque aut magni.", 451720544, 805, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "Bradtke, Turcotte and Carroll", "fuchsia Face to face Savings Account" },
                    { 58, "Merritt Skiles", "in", "https://picsum.photos/50/50/?image=89", "Quaerat possimus tenetur blanditiis eveniet eius inventore totam officia nemo aut atque vel at quia aut laboriosam sit temporibus quis.", 205008178, 577, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), "Howell and Sons", "Cambridgeshire Organic International" },
                    { 59, "Myrl Wuckert", "voluptas", "https://picsum.photos/50/50/?image=242", "Perspiciatis molestias omnis sapiente perferendis vitae placeat qui sit porro atque blanditiis ab doloribus ut perspiciatis maxime repellat mollitia dolorem.", 251374798, 531, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), "Stokes - Koss", "leverage National conglomeration" },
                    { 60, "Oswald Streich", "nobis", "https://picsum.photos/50/50/?image=706", "Qui molestias eveniet ut voluptatem occaecati eum distinctio sit at cupiditate labore quod totam velit rerum sint deserunt quaerat dicta.", 999142781, 288, new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), "Murray - Terry", "deposit Refined Principal" },
                    { 61, "Alec Bailey", "et", "https://picsum.photos/50/50/?image=423", "Provident et aut porro molestias sed ea officiis excepturi quasi cupiditate vitae at rerum suscipit dolores similique sint minus aut.", 884050470, 746, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "Klein - Botsford", "backing up Australia Legacy" },
                    { 62, "Justus Cronin", "sequi", "https://picsum.photos/50/50/?image=658", "Porro laboriosam placeat est modi quia aperiam totam omnis eveniet voluptas qui asperiores culpa ex ut nisi quibusdam fugit nobis.", 385354171, 352, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), "Kozey, Vandervort and Yost", "Director hack National" },
                    { 63, "Arely Heaney", "accusantium", "https://picsum.photos/50/50/?image=473", "Reiciendis porro quas quia dicta voluptatibus ducimus impedit maxime corporis dolores voluptate illum aut ut perspiciatis ipsum quae rerum cum.", 101846816, 320, new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Local), "Crooks, Kshlerin and Bernier", "Tasty Frozen Fish leverage deliverables" },
                    { 64, "Kelton Collins", "molestiae", "https://picsum.photos/50/50/?image=406", "Et voluptate vero consequatur et maxime itaque qui nulla quam voluptatem qui veritatis nihil similique autem qui a sit nostrum.", 923539324, 771, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), "Hills Inc", "Rubber Checking Account District" },
                    { 65, "Curtis Rath", "enim", "https://picsum.photos/50/50/?image=841", "Aut numquam mollitia omnis ex sint provident ut est consequatur itaque quasi hic quae ipsam fugiat ea numquam nobis nihil.", 387070785, 994, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), "Rodriguez - Larkin", "Borders Svalbard & Jan Mayen Islands Robust" },
                    { 66, "Emanuel Collier", "incidunt", "https://picsum.photos/50/50/?image=3", "Sit numquam sequi placeat quas sit officiis vel ea ducimus molestiae qui est ut qui cupiditate dignissimos tempore sunt est.", 458188196, 602, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), "Armstrong, Feil and Gutkowski", "Awesome Metal Sleek Steel Ball" },
                    { 67, "Charley Balistreri", "ullam", "https://picsum.photos/50/50/?image=136", "Eum libero quam dolorem repellendus quibusdam numquam nostrum ratione qui corrupti et voluptatem qui recusandae quo ipsam eum voluptatibus aspernatur.", 218111320, 298, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "McKenzie, Barrows and Smith", "dot-com connecting program" },
                    { 68, "Oliver Sporer", "odit", "https://picsum.photos/50/50/?image=106", "Debitis ut iste neque cupiditate quam consequatur tempora facere perferendis odit qui cum perferendis qui et molestiae a autem voluptatem.", 906122695, 781, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), "Mitchell Inc", "Auto Loan Account Auto Loan Account local" },
                    { 69, "Ova Wiegand", "qui", "https://picsum.photos/50/50/?image=545", "Rerum culpa dolor repudiandae quia necessitatibus et error illo blanditiis minima quis sint voluptates rerum natus et fugiat ut ut.", 731376239, 448, new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), "Cassin LLC", "hack efficient end-to-end" },
                    { 70, "Hal Blick", "provident", "https://picsum.photos/50/50/?image=546", "Quibusdam non consectetur itaque error quis porro voluptatem ipsam aut consequatur rerum voluptas non ut iure sequi reprehenderit tempora sit.", 239911048, 797, new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "Rowe, Yundt and Vandervort", "Specialist Investment Account Alley" },
                    { 71, "Jeanette Schneider", "assumenda", "https://picsum.photos/50/50/?image=416", "Aut expedita omnis aut molestias sequi aut est tempore enim sit debitis et libero quis maxime iure eius veniam velit.", 439987411, 824, new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), "Harvey - Muller", "Money Market Account Mission Incredible Frozen Chair" },
                    { 72, "Mossie Rice", "et", "https://picsum.photos/50/50/?image=646", "Tempora ut autem accusamus ea dicta nostrum non deleniti eum quibusdam ab in illum enim dolorem dolor amet ut non.", 267924791, 881, new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), "Runte LLC", "communities withdrawal Qatari Rial" },
                    { 73, "Nathen Goodwin", "fuga", "https://picsum.photos/50/50/?image=460", "Praesentium ullam est aut aut hic sequi beatae voluptate et enim possimus non cupiditate ut quia expedita reiciendis reiciendis eum.", 862807061, 774, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), "Flatley Inc", "Virginia override Kansas" },
                    { 74, "Elvie McDermott", "voluptates", "https://picsum.photos/50/50/?image=286", "Rerum itaque voluptas id accusamus quae animi optio amet ut et quo veritatis veritatis quo quia aperiam laborum praesentium labore.", 326749860, 841, new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), "Lebsack, Rippin and Padberg", "Product Plastic Licensed Frozen Car" },
                    { 75, "Johnny Bernier", "aut", "https://picsum.photos/50/50/?image=400", "Iusto voluptatibus dolor non eius nobis iure assumenda velit aut sed totam quae quia voluptatem qui vel cum autem reprehenderit.", 270883989, 331, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "Sawayn LLC", "Gorgeous Concrete Keyboard Infrastructure ADP" },
                    { 76, "Easton Sawayn", "nulla", "https://picsum.photos/50/50/?image=704", "Quis assumenda aut ut numquam et ut deserunt assumenda nulla culpa eius consequatur cum nostrum sed quo vitae ipsa voluptas.", 609953850, 746, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), "Schowalter Inc", "leading-edge Analyst Upgradable" },
                    { 77, "Rylan Kirlin", "quasi", "https://picsum.photos/50/50/?image=651", "Non nobis quod aut quos perferendis quo maiores debitis expedita architecto sit dolor doloremque incidunt quo ut quos quo aut.", 729782788, 570, new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), "Jacobi, Harris and Monahan", "Unbranded functionalities Auto Loan Account" },
                    { 78, "Luisa Quigley", "quod", "https://picsum.photos/50/50/?image=1041", "Corporis amet soluta et et a maxime doloremque voluptatem et aut asperiores dolorem natus doloremque repellendus perferendis vel esse sunt.", 867671170, 490, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Vandervort, Daugherty and Barrows", "Bedfordshire contingency UIC-Franc" },
                    { 79, "Mikayla Boyer", "cum", "https://picsum.photos/50/50/?image=631", "Repellat labore omnis mollitia dicta nostrum eos minima quia quibusdam non distinctio fuga libero a aut ratione molestiae sed dolorem.", 952348641, 252, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "O'Hara, Batz and Schulist", "quantifying streamline National" },
                    { 80, "Barrett Sipes", "quaerat", "https://picsum.photos/50/50/?image=501", "Id recusandae id vero perferendis est voluptate illum reiciendis omnis molestiae architecto voluptatem exercitationem officiis quia neque aperiam veritatis dolorem.", 827775810, 209, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Morissette, Huels and Roob", "Accounts Credit Card Account Metal" },
                    { 81, "Leonardo Zemlak", "et", "https://picsum.photos/50/50/?image=937", "Atque dolorem praesentium dicta et quod et nostrum dignissimos explicabo quod eum sunt sit rerum suscipit dolor enim unde at.", 448230623, 797, new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Rippin - Keeling", "Frozen Credit Card Account communities" },
                    { 82, "Mittie Powlowski", "occaecati", "https://picsum.photos/50/50/?image=43", "Sapiente ratione sint maiores maiores dolores maiores dolor rerum quia nihil perferendis cupiditate quis aspernatur eveniet aut est in ipsum.", 676743446, 343, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "Williamson and Sons", "portals Ouguiya Central" },
                    { 83, "Chaim Schultz", "aut", "https://picsum.photos/50/50/?image=671", "Illum et aperiam et et nam omnis eum ab consequatur facere ea ducimus est modi qui nulla illo qui eum.", 199478769, 579, new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), "Kautzer - Robel", "Investor Rustic Metal Gloves Industrial, Grocery & Toys" },
                    { 84, "Queen Barrows", "libero", "https://picsum.photos/50/50/?image=213", "Dolores sit aliquid qui sed illum non sed sequi ut eos necessitatibus vel aut ratione consequuntur culpa earum ab aperiam.", 957440822, 266, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), "Lebsack, Nienow and Rutherford", "Specialist Synergized PNG" },
                    { 85, "Chadrick Thompson", "tempore", "https://picsum.photos/50/50/?image=565", "Eum dolore debitis eos voluptatem aperiam reprehenderit provident enim amet officiis modi culpa blanditiis totam alias eos ea consequuntur omnis.", 252166184, 977, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), "Hickle, Roob and Jerde", "e-services pink Soft" },
                    { 86, "Megane Feest", "sint", "https://picsum.photos/50/50/?image=526", "Dolor eos consequatur officia numquam eaque nulla natus ut veritatis debitis occaecati placeat ad at in tempora sapiente numquam iusto.", 969590767, 96, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "King, Windler and Lockman", "Avon Auto Loan Account Terrace" },
                    { 87, "Lon Will", "asperiores", "https://picsum.photos/50/50/?image=80", "Laboriosam molestias et veritatis quia praesentium et eum nihil dolores ab aut est quo hic sint itaque eos molestiae qui.", 853135604, 671, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), "Johnston Group", "Utah virtual program" },
                    { 88, "Haven Conroy", "beatae", "https://picsum.photos/50/50/?image=548", "Consectetur quo consequatur dignissimos in nesciunt consequatur dolor atque saepe vel perspiciatis eius id dolor placeat optio nihil atque sunt.", 458988991, 287, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), "Funk Group", "magenta Investor hard drive" },
                    { 89, "Roxanne Carter", "aut", "https://picsum.photos/50/50/?image=1036", "Aliquam pariatur voluptas autem asperiores omnis saepe ut ex alias soluta eos in sit ullam voluptatem corrupti sint omnis provident.", 836110580, 265, new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), "Kuhic - Lueilwitz", "generating content killer" },
                    { 90, "Declan Schulist", "possimus", "https://picsum.photos/50/50/?image=514", "Adipisci asperiores rerum atque fugiat architecto aut qui et dignissimos officiis sed suscipit ab et est temporibus atque est voluptatem.", 733239327, 856, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Local), "Kertzmann Inc", "SCSI interactive Isle" },
                    { 91, "Randal Gerlach", "aliquid", "https://picsum.photos/50/50/?image=49", "Necessitatibus odit totam odio et vitae doloribus voluptatem nulla quis distinctio accusamus ut rem modi laboriosam porro eveniet aliquid sed.", 391118516, 600, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "Lang, Weissnat and Bartell", "Overpass coherent niches" },
                    { 92, "Sanford Tromp", "omnis", "https://picsum.photos/50/50/?image=164", "Fugiat minima consequatur incidunt explicabo ut at labore aut facere accusamus eveniet ut quod voluptas ut dolores nihil placeat alias.", 321545648, 439, new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), "Fadel Inc", "navigating Tasty circuit" },
                    { 93, "Ivy VonRueden", "accusantium", "https://picsum.photos/50/50/?image=878", "Fugit reprehenderit sequi et qui ad consequatur ducimus consectetur consequatur eaque et vel placeat ab autem ipsa aperiam aut saepe.", 388769637, 58, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), "Olson and Sons", "Via bandwidth pixel" },
                    { 94, "Ezequiel Kemmer", "explicabo", "https://picsum.photos/50/50/?image=792", "Minus autem asperiores alias dolores eum veniam quo sit atque dignissimos alias velit temporibus id officiis expedita ut repudiandae rerum.", 884444004, 955, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), "Kilback and Sons", "SQL Forges yellow" },
                    { 95, "Matteo Goldner", "rerum", "https://picsum.photos/50/50/?image=350", "In aut sequi iste dicta ea quia et excepturi ducimus autem aperiam qui aliquid laboriosam nam placeat qui non accusamus.", 553284259, 634, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "Bergnaum - Kshlerin", "deposit Human Unbranded Steel Bacon" },
                    { 96, "Breanna Anderson", "quis", "https://picsum.photos/50/50/?image=810", "Aut vel unde officia modi non dolores saepe quod ut quaerat quis adipisci occaecati dolores voluptate aut eligendi pariatur rerum.", 844180651, 411, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), "Considine Group", "Peru cutting-edge Principal" },
                    { 97, "Eloise Koss", "id", "https://picsum.photos/50/50/?image=277", "Ut quia natus amet et quam porro commodi sunt ex culpa ex aut modi magnam enim eum eligendi omnis ipsum.", 732461167, 552, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), "McLaughlin, Prosacco and Satterfield", "Denar Synchronised overriding" },
                    { 98, "Colton Jaskolski", "est", "https://picsum.photos/50/50/?image=81", "Occaecati eos illo quo tenetur quo aut qui iure eveniet ex nam hic voluptas porro officia est incidunt sapiente quidem.", 386064541, 986, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "Howe, Halvorson and Cronin", "AI Ohio aggregate" },
                    { 99, "Braden Kertzmann", "beatae", "https://picsum.photos/50/50/?image=689", "Est consequatur facilis rerum ducimus quas in aut sit velit in deserunt quia est ipsum similique consequatur nam necessitatibus ipsam.", 863253150, 894, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), "Lindgren LLC", "South Carolina Jersey Rustic Frozen Computer" },
                    { 100, "Donnie Schinner", "magni", "https://picsum.photos/50/50/?image=271", "Voluptatum necessitatibus vel facilis est velit maiores libero sunt ducimus voluptatem velit enim quia repellat ut totam voluptatibus autem sint.", 591758949, 250, new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), "Botsford and Sons", "5th generation 24 hour Cuban Peso" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "UserAccounts");
        }
    }
}