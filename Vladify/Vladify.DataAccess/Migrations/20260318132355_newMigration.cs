using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vladify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Album = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Auth0Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Album", "Author", "Duration", "Title" },
                values: new object[,]
                {
                    { new Guid("02b06f85-9869-6388-0d34-b3d720d559d8"), "Sleek Frozen Tuna", "Seamus Fadel", new TimeSpan(0, 0, 2, 57, 0), "Try to parse" },
                    { new Guid("0507e220-ad19-a61f-92a2-5a894be47e4b"), "Refined Concrete Soap", "Eva Heaney", new TimeSpan(0, 0, 3, 0, 0), "Use the cross-platform" },
                    { new Guid("073c86f1-6eb0-eb49-eaca-0cd4c23ed24b"), "Unbranded Concrete Soap", "Llewellyn Ruecker", new TimeSpan(0, 0, 2, 35, 0), "Try to input" },
                    { new Guid("0bf2a18f-2f80-44b4-61b3-6d437da163dc"), "Gorgeous Steel Shoes", "Tad Donnelly", new TimeSpan(0, 0, 3, 6, 0), "I'll navigate the" },
                    { new Guid("0d5d93d1-101a-ec67-496f-9c2b0bd9efad"), "Handcrafted Steel Chips", "Tyshawn Casper", new TimeSpan(0, 0, 3, 20, 0), "If we index" },
                    { new Guid("10284c55-8087-37d4-244f-ce057d8d4be4"), "Small Steel Keyboard", "Gust Mann", new TimeSpan(0, 0, 3, 14, 0), "I'll quantify the" },
                    { new Guid("116011ab-1877-f674-8353-b2570830bef9"), "Rustic Soft Sausages", "Veronica Tillman", new TimeSpan(0, 0, 2, 55, 0), "We need to" },
                    { new Guid("1177c8ca-0588-4071-7959-d630241c53ee"), "Generic Rubber Keyboard", "Juliet Kshlerin", new TimeSpan(0, 0, 3, 23, 0), "You can't copy" },
                    { new Guid("137af266-a83d-b4f1-eed7-02ed3ee98ba8"), "Rustic Cotton Chair", "Jovany O'Conner", new TimeSpan(0, 0, 3, 30, 0), "If we navigate" },
                    { new Guid("13f19850-5b4e-dc97-819d-3cabbceaf6f1"), "Fantastic Soft Chicken", "Roosevelt Lind", new TimeSpan(0, 0, 2, 55, 0), "We need to" },
                    { new Guid("15c759a2-cb6d-abf1-69b7-79b4bde1c024"), "Practical Soft Pants", "Liam Koepp", new TimeSpan(0, 0, 2, 48, 0), "I'll quantify the" },
                    { new Guid("1705167d-8a5b-49a8-a548-23eae9cd03f4"), "Refined Fresh Hat", "Brielle Abshire", new TimeSpan(0, 0, 2, 35, 0), "The SMTP microchip" },
                    { new Guid("17c50ad9-0a56-0a8d-828f-09374f617d13"), "Gorgeous Metal Computer", "Andy Marquardt", new TimeSpan(0, 0, 3, 2, 0), "The EXE microchip" },
                    { new Guid("1b81abfa-6b29-94f3-eb1d-5bc0c0442262"), "Handmade Frozen Salad", "Reece Tillman", new TimeSpan(0, 0, 3, 2, 0), "I'll index the" },
                    { new Guid("1f04d275-f058-ee0a-7241-4b9e6201aa26"), "Generic Wooden Mouse", "Jaida Wisoky", new TimeSpan(0, 0, 3, 14, 0), "You can't quantify" },
                    { new Guid("1f192cb4-af67-db3c-e9fe-67f000fae4ac"), "Tasty Wooden Computer", "Alexandria Ondricka", new TimeSpan(0, 0, 2, 34, 0), "copying the transmitter" },
                    { new Guid("225be22a-2c57-0f5d-f30e-57707a44e208"), "Licensed Soft Towels", "Robbie Hessel", new TimeSpan(0, 0, 3, 7, 0), "You can't calculate" },
                    { new Guid("2a38270f-6071-1631-7684-0215182b1dee"), "Practical Cotton Salad", "Jarret Barton", new TimeSpan(0, 0, 3, 27, 0), "I'll calculate the" },
                    { new Guid("2c0d2442-82c0-9220-b1c3-5bd861474e96"), "Ergonomic Plastic Car", "Elnora McLaughlin", new TimeSpan(0, 0, 2, 55, 0), "Use the digital" },
                    { new Guid("2ce27632-f684-5805-d2fa-a1923dc0a2f7"), "Tasty Metal Pizza", "April Pagac", new TimeSpan(0, 0, 3, 3, 0), "We need to" },
                    { new Guid("302edfda-2bf7-b508-807b-98714ab924a1"), "Gorgeous Granite Computer", "Margaretta Leannon", new TimeSpan(0, 0, 2, 55, 0), "I'll index the" },
                    { new Guid("310057b1-2751-8bf8-371e-93824e09e24e"), "Fantastic Fresh Computer", "Deven Hoppe", new TimeSpan(0, 0, 2, 50, 0), "Use the bluetooth" },
                    { new Guid("3326d392-5963-f6c0-e0c7-69708c6c9d42"), "Gorgeous Rubber Chips", "Elyse Hodkiewicz", new TimeSpan(0, 0, 2, 33, 0), "Use the neural" },
                    { new Guid("338674b9-8e29-2216-15f0-3a2b4aae5fc0"), "Unbranded Concrete Car", "Tina Ferry", new TimeSpan(0, 0, 2, 54, 0), "The EXE card" },
                    { new Guid("349c6b37-0ab2-5115-1c5d-086b513e1e03"), "Handmade Metal Chair", "Eleanore Windler", new TimeSpan(0, 0, 3, 8, 0), "We need to" },
                    { new Guid("364e88ad-3c82-5c95-8694-da1e3c79b1f7"), "Incredible Rubber Pants", "Berneice Ebert", new TimeSpan(0, 0, 3, 7, 0), "I'll quantify the" },
                    { new Guid("38675bc9-166f-2202-8b39-00aad9bbe25e"), "Refined Concrete Chicken", "Anderson Hammes", new TimeSpan(0, 0, 2, 45, 0), "The ADP driver" },
                    { new Guid("390ae472-9ba7-b62d-7e32-9a7f25b5e216"), "Small Cotton Soap", "Paul Blanda", new TimeSpan(0, 0, 2, 38, 0), "The USB transmitter" },
                    { new Guid("3b789d14-406a-7988-026b-cf388b92603d"), "Ergonomic Wooden Towels", "Liliana Morar", new TimeSpan(0, 0, 2, 39, 0), "Try to input" },
                    { new Guid("3b79ffed-df03-0146-9edd-a04e11c601c9"), "Sleek Metal Ball", "Billy Swaniawski", new TimeSpan(0, 0, 2, 45, 0), "We need to" },
                    { new Guid("407c2590-e002-b2b1-66d7-f7bf31213d2f"), "Small Rubber Computer", "Samantha Jenkins", new TimeSpan(0, 0, 3, 0, 0), "You can't calculate" },
                    { new Guid("44159250-371c-e52b-6979-d68b9292dc0a"), "Awesome Soft Shirt", "Noble Kassulke", new TimeSpan(0, 0, 3, 15, 0), "connecting the sensor" },
                    { new Guid("46dcdd9f-4997-c371-3ad5-62f9311fa2c0"), "Gorgeous Soft Soap", "Orin Hansen", new TimeSpan(0, 0, 2, 36, 0), "We need to" },
                    { new Guid("46ea0196-d84b-e5c7-82ef-ce6dd0e09efd"), "Ergonomic Cotton Keyboard", "Jennings Treutel", new TimeSpan(0, 0, 3, 14, 0), "transmitting the monitor" },
                    { new Guid("470b51ee-0123-a7b6-d38e-0cd6923740c3"), "Awesome Steel Bike", "Zola Ryan", new TimeSpan(0, 0, 2, 35, 0), "If we parse" },
                    { new Guid("495648e1-44a3-973b-55d2-1ded22676e00"), "Awesome Plastic Tuna", "Michale Rempel", new TimeSpan(0, 0, 2, 55, 0), "You can't parse" },
                    { new Guid("4d60d783-8172-76a2-6c13-5cf27f1d9411"), "Small Frozen Bike", "Ben O'Connell", new TimeSpan(0, 0, 2, 40, 0), "We need to" },
                    { new Guid("51223a40-c8eb-e9c6-1d02-0ca9ca47725a"), "Generic Concrete Tuna", "Malika Kessler", new TimeSpan(0, 0, 2, 33, 0), "You can't override" },
                    { new Guid("5241daea-7eae-d980-6c8d-3fff7a859c8d"), "Fantastic Wooden Computer", "Jaylen Schuppe", new TimeSpan(0, 0, 2, 41, 0), "bypassing the alarm" },
                    { new Guid("56098df8-fb53-be2b-1141-30f15deaaf2a"), "Handcrafted Soft Tuna", "Jordon Herman", new TimeSpan(0, 0, 2, 47, 0), "If we program" },
                    { new Guid("59921489-a482-272f-6b5b-46c7867c676e"), "Licensed Cotton Mouse", "Fiona Ledner", new TimeSpan(0, 0, 2, 52, 0), "I'll program the" },
                    { new Guid("60a85b1f-706e-bd53-6c2b-417202755699"), "Licensed Wooden Keyboard", "Manuela Quitzon", new TimeSpan(0, 0, 2, 40, 0), "Try to synthesize" },
                    { new Guid("616f46da-8cca-878b-af73-9b0fc11991eb"), "Rustic Wooden Bike", "Sally Lockman", new TimeSpan(0, 0, 3, 1, 0), "The THX program" },
                    { new Guid("69b94243-01c4-e117-7e6c-8c97ee7f089f"), "Practical Cotton Ball", "Randy Beahan", new TimeSpan(0, 0, 3, 25, 0), "The GB circuit" },
                    { new Guid("6b4b99f4-1182-d76d-073b-69634b12638b"), "Handcrafted Plastic Shoes", "Theodore White", new TimeSpan(0, 0, 3, 10, 0), "I'll hack the" },
                    { new Guid("6bbed3b5-9bf0-a69d-4037-c2b125fcb302"), "Tasty Metal Towels", "Jacquelyn Schumm", new TimeSpan(0, 0, 2, 35, 0), "If we hack" },
                    { new Guid("6dd9a615-84df-c4e5-5c86-6643bab486bf"), "Ergonomic Steel Tuna", "Monique Okuneva", new TimeSpan(0, 0, 2, 34, 0), "You can't hack" },
                    { new Guid("6f79342b-2557-4301-9032-eba4563db8cc"), "Practical Rubber Mouse", "Cullen O'Keefe", new TimeSpan(0, 0, 3, 26, 0), "You can't bypass" },
                    { new Guid("70efca8f-3cff-9ce7-3915-63234e7a8cf7"), "Generic Concrete Mouse", "Ronny Rau", new TimeSpan(0, 0, 3, 0, 0), "bypassing the pixel" },
                    { new Guid("749354d5-e054-aba9-5875-85fbcbfbfda9"), "Ergonomic Rubber Bacon", "Gwendolyn Gorczany", new TimeSpan(0, 0, 2, 37, 0), "If we input" },
                    { new Guid("7a71ffa1-cd50-3c2e-cef1-87578365eb60"), "Tasty Steel Chips", "Kimberly Marks", new TimeSpan(0, 0, 2, 46, 0), "We need to" },
                    { new Guid("84cb75de-219e-76e9-5574-a35f742725c5"), "Small Rubber Mouse", "Garnett Tillman", new TimeSpan(0, 0, 2, 31, 0), "navigating the application" },
                    { new Guid("877b086b-51b9-f9cf-6f30-0159c888f5e2"), "Tasty Concrete Gloves", "Lee Haley", new TimeSpan(0, 0, 2, 46, 0), "backing up the" },
                    { new Guid("8c69ef4b-b3d3-5fa0-59bf-bcf14d45b898"), "Ergonomic Granite Car", "Claudine Emard", new TimeSpan(0, 0, 2, 57, 0), "You can't hack" },
                    { new Guid("8e09973c-766f-6f66-93be-da1a8e496bef"), "Unbranded Rubber Pizza", "Kailey Parisian", new TimeSpan(0, 0, 2, 54, 0), "Try to calculate" },
                    { new Guid("9c855adb-087b-f53a-d48e-37af87c2ee76"), "Intelligent Steel Pants", "Gerardo Ledner", new TimeSpan(0, 0, 3, 14, 0), "You can't bypass" },
                    { new Guid("9fdea678-4a21-6d13-4185-9484e1a21ecd"), "Small Cotton Mouse", "Gavin Parisian", new TimeSpan(0, 0, 3, 13, 0), "Use the back-end" },
                    { new Guid("a27bd1b8-5905-c895-ac34-023669f34f37"), "Incredible Fresh Table", "Jaleel Windler", new TimeSpan(0, 0, 2, 42, 0), "The TCP interface" },
                    { new Guid("a3b7053f-8afc-b81f-e1ef-e7dd651dbbd6"), "Handcrafted Rubber Shirt", "Melissa Kirlin", new TimeSpan(0, 0, 2, 41, 0), "You can't navigate" },
                    { new Guid("a3fab3b8-12f1-276c-286c-ed14dfab57e2"), "Handmade Frozen Pizza", "Rosemarie Daniel", new TimeSpan(0, 0, 2, 30, 0), "The XSS feed" },
                    { new Guid("a46ef40e-5e8f-0842-a90c-66a29336dccd"), "Incredible Steel Car", "Delphia Jakubowski", new TimeSpan(0, 0, 3, 4, 0), "If we parse" },
                    { new Guid("aab972b2-6fc9-ebcd-867b-c8d8fa0e800e"), "Practical Soft Soap", "Herman Schmeler", new TimeSpan(0, 0, 2, 48, 0), "You can't quantify" },
                    { new Guid("ab3ff4e6-7612-fc80-75af-48fc0daced95"), "Generic Fresh Bike", "Vivianne Gleichner", new TimeSpan(0, 0, 2, 47, 0), "Use the online" },
                    { new Guid("ab6c8ed2-7d80-c162-0059-b7c7553d8fe7"), "Awesome Fresh Chicken", "Marianne Legros", new TimeSpan(0, 0, 3, 18, 0), "Try to transmit" },
                    { new Guid("acfea3be-024e-39ae-7647-e68537b39837"), "Tasty Frozen Computer", "Khalid Lebsack", new TimeSpan(0, 0, 3, 24, 0), "If we input" },
                    { new Guid("ad650e70-877c-47f1-34b2-36bf9973883b"), "Refined Soft Fish", "Luella Langosh", new TimeSpan(0, 0, 2, 39, 0), "Try to generate" },
                    { new Guid("ae5074fc-ca93-2534-454c-992843750813"), "Ergonomic Cotton Computer", "Darrion Harris", new TimeSpan(0, 0, 3, 28, 0), "If we generate" },
                    { new Guid("af5869ba-ea39-4128-d894-68dd6537f86f"), "Handmade Wooden Hat", "Kory Jaskolski", new TimeSpan(0, 0, 3, 3, 0), "You can't quantify" },
                    { new Guid("b1b9c422-a4f3-65f3-4dac-48811ddb829e"), "Handcrafted Fresh Sausages", "Jasen Mraz", new TimeSpan(0, 0, 2, 49, 0), "Use the open-source" },
                    { new Guid("b45c0211-b270-8016-da5c-bd964b3929f5"), "Rustic Granite Shirt", "Alexandria Jones", new TimeSpan(0, 0, 2, 48, 0), "We need to" },
                    { new Guid("b5fe127a-9183-e227-c5e3-eeef27e28287"), "Unbranded Steel Bike", "Aubrey Renner", new TimeSpan(0, 0, 3, 22, 0), "Try to quantify" },
                    { new Guid("b641bdf7-7844-422f-6aaa-47f0a24c7379"), "Gorgeous Steel Hat", "Cordelia Pollich", new TimeSpan(0, 0, 3, 13, 0), "The SMTP application" },
                    { new Guid("b697ad87-9659-2f28-e029-761f4b433a47"), "Small Cotton Ball", "Andres Mertz", new TimeSpan(0, 0, 3, 27, 0), "You can't calculate" },
                    { new Guid("bca93494-9f15-1b46-e23c-118c089386fa"), "Practical Plastic Soap", "Harvey Fritsch", new TimeSpan(0, 0, 2, 47, 0), "If we synthesize" },
                    { new Guid("c1d48525-8eb7-966d-c78c-c9e9432ce31f"), "Ergonomic Granite Pants", "Berenice Littel", new TimeSpan(0, 0, 3, 24, 0), "calculating the panel" },
                    { new Guid("c4e5c742-9537-175d-ddb9-a50ad27bcf9b"), "Rustic Wooden Shoes", "Camila Koch", new TimeSpan(0, 0, 3, 29, 0), "Use the multi-byte" },
                    { new Guid("c5d5532f-26be-5e16-c3b3-1066d8782141"), "Incredible Cotton Salad", "Brandt Windler", new TimeSpan(0, 0, 3, 21, 0), "We need to" },
                    { new Guid("c78d0fe1-6117-1be1-5f55-71ec9fe16fe9"), "Awesome Rubber Ball", "Stefanie Gibson", new TimeSpan(0, 0, 2, 33, 0), "Use the 1080p" },
                    { new Guid("ccd1981e-2661-5615-8b3e-aff33418273c"), "Handmade Wooden Ball", "Gretchen Homenick", new TimeSpan(0, 0, 3, 23, 0), "overriding the port" },
                    { new Guid("ce555527-d6f7-f501-7e43-f2b8e7361fbd"), "Rustic Fresh Gloves", "Ernesto Hegmann", new TimeSpan(0, 0, 2, 57, 0), "I'll override the" },
                    { new Guid("cee69697-01ce-a687-e007-f6699c7bc574"), "Rustic Steel Cheese", "Eliezer Sporer", new TimeSpan(0, 0, 2, 57, 0), "Try to transmit" },
                    { new Guid("cf8da1cf-1968-dc08-77f0-75267594241d"), "Gorgeous Frozen Salad", "Nora Tromp", new TimeSpan(0, 0, 3, 15, 0), "synthesizing the feed" },
                    { new Guid("d8b26789-0a0b-c42c-d0da-101e67af1cf9"), "Generic Granite Pizza", "Ollie Ferry", new TimeSpan(0, 0, 2, 46, 0), "compressing the hard" },
                    { new Guid("dafb9076-3e39-5e4c-c694-f57a840f6558"), "Unbranded Rubber Table", "Mollie Littel", new TimeSpan(0, 0, 2, 37, 0), "We need to" },
                    { new Guid("db1a50e6-d053-4ccc-33f9-bfbf58f79c12"), "Sleek Frozen Pizza", "Tabitha Gerhold", new TimeSpan(0, 0, 3, 29, 0), "If we parse" },
                    { new Guid("db774e40-3592-6462-f2c0-a3e46d4257db"), "Handcrafted Metal Keyboard", "Maximus Feil", new TimeSpan(0, 0, 3, 21, 0), "I'll program the" },
                    { new Guid("df4788c3-7d04-dd26-408f-fff6009eb4ee"), "Awesome Cotton Car", "Lorenzo Mertz", new TimeSpan(0, 0, 2, 45, 0), "The AI application" },
                    { new Guid("e03ef966-2acf-1876-c6ed-7bd133e3d86d"), "Licensed Cotton Car", "Armand Adams", new TimeSpan(0, 0, 3, 6, 0), "If we hack" },
                    { new Guid("e259cb66-d501-bcb4-b93d-b00a4b0b91c0"), "Tasty Rubber Computer", "Devante Huels", new TimeSpan(0, 0, 3, 11, 0), "transmitting the matrix" },
                    { new Guid("e2a33227-077f-f568-9dd6-78be505f0985"), "Unbranded Rubber Keyboard", "Daisy Gibson", new TimeSpan(0, 0, 3, 4, 0), "The GB system" },
                    { new Guid("e392318e-0185-7406-de5c-483aaa7642fa"), "Incredible Frozen Ball", "Jamison Glover", new TimeSpan(0, 0, 3, 6, 0), "I'll parse the" },
                    { new Guid("e4fe5ccd-7355-d1f9-8c6e-a0741673ef38"), "Handmade Plastic Pants", "Herbert Braun", new TimeSpan(0, 0, 2, 31, 0), "quantifying the panel" },
                    { new Guid("e5cf24c7-964a-1190-a3dd-12a42fed31f4"), "Gorgeous Wooden Bike", "Shanie Franecki", new TimeSpan(0, 0, 3, 26, 0), "Use the virtual" },
                    { new Guid("e89cc816-72ce-e100-26aa-05cd5d36d0f5"), "Intelligent Plastic Chicken", "Adell Hickle", new TimeSpan(0, 0, 3, 8, 0), "I'll calculate the" },
                    { new Guid("ee9bdcb3-b3e8-1063-a5ee-72d28e87504c"), "Handcrafted Steel Gloves", "Carissa Kling", new TimeSpan(0, 0, 2, 59, 0), "Use the wireless" },
                    { new Guid("efa23eb3-d17a-fc76-a100-5e1c24dbca0b"), "Licensed Wooden Car", "Curt Rau", new TimeSpan(0, 0, 2, 54, 0), "Try to synthesize" },
                    { new Guid("f1dd9083-3c60-21bd-0430-501f7c7f698d"), "Intelligent Cotton Shoes", "Shaina Pfannerstill", new TimeSpan(0, 0, 3, 2, 0), "I'll calculate the" },
                    { new Guid("fa540541-003f-d457-72cf-cc35f187a0c5"), "Incredible Plastic Table", "Jerod Buckridge", new TimeSpan(0, 0, 3, 27, 0), "The AI array" },
                    { new Guid("fb3372f9-e4b2-a8f8-dedd-52ad5dd26ad1"), "Licensed Rubber Shirt", "Kathleen Carter", new TimeSpan(0, 0, 2, 56, 0), "Use the redundant" },
                    { new Guid("fbc16e58-f1d9-a4d1-b65b-855b26297426"), "Generic Soft Towels", "Seamus Kiehn", new TimeSpan(0, 0, 3, 23, 0), "The SMS system" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Auth0Id", "EmailAddress", "Gender", "Name" },
                values: new object[,]
                {
                    { new Guid("062f3c05-dd11-1323-10db-7e8ac0b8ef7e"), 73, "auth0|409472f82d94d3841f5bacac", "Cesar.Kertzmann58@gmail.com", "Female", "Ephraim" },
                    { new Guid("0e51d9f0-3e16-1570-8751-8bfcad3c76b7"), 50, "auth0|71464b4db7170a63f5f66302", "Thaddeus_Doyle90@yahoo.com", "Male", "Guadalupe" },
                    { new Guid("17f3f721-c6c8-7b79-2791-0c615bb1d678"), 73, "auth0|c2300db4d17770e0fd3b514d", "Sammie.Kilback58@hotmail.com", "Male", "Elisa" },
                    { new Guid("1c8575f0-6194-339d-ad3e-2e7c3866a80f"), 94, "auth0|1b95a2b93ad5c83c5c75374d", "Larue46@hotmail.com", "Male", "Marley" },
                    { new Guid("1e2c23c9-1e0f-d13a-4cac-27078dac190f"), 91, "auth0|dc5306dedbf39ac445bfd733", "Delia_Weissnat@gmail.com", "Female", "Bridget" },
                    { new Guid("2349b3e1-f845-5b61-fa8e-fbef8c8a9b57"), 67, "auth0|26bc1501a4483e815ee97872", "Corine.Cormier98@gmail.com", "Female", "Lelah" },
                    { new Guid("28a25f0e-dfa5-dc8a-9ec7-db94ad90e67d"), 66, "auth0|e2f2df7f262fee8312871a9d", "Emery.Kunde76@hotmail.com", "Female", "Monique" },
                    { new Guid("3a4637ab-0383-947a-860b-598de7e62046"), 88, "auth0|52a0838fcdcce32176a06863", "Clotilde_Swaniawski@gmail.com", "Male", "Vernice" },
                    { new Guid("455357b3-ab37-7d3b-8ddd-aa4a9b035760"), 61, "auth0|9d8a637327a243676fb0a2a2", "Lizzie52@hotmail.com", "Male", "Zaria" },
                    { new Guid("49bb0990-7c20-0dcf-fce5-3793219f6047"), 19, "auth0|d8b0d2646f930a379fe684d8", "Sabina.Marvin26@gmail.com", "Female", "Marianne" },
                    { new Guid("552d18c2-86b9-4773-0253-becbc4f9f3a7"), 49, "auth0|8e7649d4282d97b9af274259", "Manley_Cronin40@gmail.com", "Male", "Gerhard" },
                    { new Guid("62974f26-824a-80f7-bdb5-31fe456909ca"), 43, "auth0|ff55cad7b4daa656cc153a24", "Daniella_Senger@gmail.com", "Female", "Shirley" },
                    { new Guid("65ff82bb-8d09-8e6c-0f2b-c4d489d94086"), 52, "auth0|535aae56811c2e6ed5cfb00c", "Domenick_Steuber@hotmail.com", "Male", "Jada" },
                    { new Guid("7775e280-c280-eecf-54f4-31fbbf49b93b"), 53, "auth0|287a0086ac05cae7e30e4994", "Jett.Robel53@gmail.com", "Male", "Sterling" },
                    { new Guid("7fc71309-41a9-f4e3-287b-8345ecad8131"), 42, "auth0|7aba268e3c08c9249e9ad2f2", "Halle_Pfannerstill73@gmail.com", "Male", "Maryam" },
                    { new Guid("8717fef3-a26b-e361-ca4b-173b514b256b"), 74, "auth0|e58f8575cf3f8b24e6571f8d", "Norbert_Schroeder@gmail.com", "Female", "William" },
                    { new Guid("89d22fe4-5532-ac42-0f6e-976e2e92da05"), 100, "auth0|53d2d94826faf10990721115", "Earnest67@hotmail.com", "Female", "Julien" },
                    { new Guid("9c2b1595-45f8-672e-e24d-46b081cda8ed"), 58, "auth0|7e41734a9fdfdf60a11356ca", "Mariano.Braun85@gmail.com", "Male", "Pearline" },
                    { new Guid("a8c435d2-a3ab-8813-de0e-ac5fab782189"), 44, "auth0|c0734263ccfdaafd54b28c4a", "Darron70@yahoo.com", "Female", "Greyson" },
                    { new Guid("b471b00d-f7ee-acf9-e226-1fd24d76e93c"), 41, "auth0|e486a6697cad876bc62f970b", "Kacie.Renner92@hotmail.com", "Female", "Louie" },
                    { new Guid("d14d8488-392a-c224-376c-9545523ef9d7"), 28, "auth0|59183f9253c8ad6726aa967b", "Amelie.Pollich@gmail.com", "Female", "Enrique" },
                    { new Guid("d82de857-522c-c556-b013-d78f474f9287"), 72, "auth0|c1ea939e82e2e265a0c4df9e", "Letha_Ratke@gmail.com", "Male", "Ernie" },
                    { new Guid("d922e44d-ba77-e400-0a2a-26212685a3c3"), 90, "auth0|7af854402fac00e8a384ef82", "Ines_Balistreri@gmail.com", "Female", "Tressa" },
                    { new Guid("d9ace6d5-3d01-ab77-48e3-ab1f26334575"), 86, "auth0|69fe1fec7f569e507938043b", "Elizabeth_Braun@yahoo.com", "Female", "Brenda" },
                    { new Guid("de35e4ee-1a3c-5790-7777-f1ec1069e422"), 38, "auth0|966e3969e00ea631cb22f2a2", "Stephen48@yahoo.com", "Male", "Arne" },
                    { new Guid("e1863474-f4ae-c7e2-12bb-a8f909512da9"), 65, "auth0|1932dbc737460922d683bbf7", "Timmy_Considine@yahoo.com", "Male", "Brennon" },
                    { new Guid("eb5aa860-01f1-f11d-eb28-7b3747c1dca7"), 75, "auth0|a41e05f4e8bbb2dfa3a3731a", "Elmer76@yahoo.com", "Male", "Lester" },
                    { new Guid("f4c5bb92-c504-dc74-c969-fbb76ae50f7e"), 28, "auth0|0998f7431d4181ce6e9a5bb1", "Miller.Carter@gmail.com", "Male", "Rhoda" },
                    { new Guid("fa333e3f-3b75-cd02-7ce7-2b77e1e700a2"), 99, "auth0|d8d5248b2594d52b85cd5352", "Jeanette.Bartoletti@hotmail.com", "Female", "Joanie" },
                    { new Guid("ffd23d02-4eb5-4217-2b43-f9b46c4a45c7"), 43, "auth0|bccf82be5b1f4667c6b098af", "Leslie44@yahoo.com", "Male", "Marcia" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Auth0Id",
                table: "Users",
                column: "Auth0Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_EmailAddress",
                table: "Users",
                column: "EmailAddress",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
