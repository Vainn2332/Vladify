using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vladify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
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
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    { new Guid("00133a77-3a59-6194-90c5-2d29e630eba5"), "Gorgeous Frozen Shoes", "Theresa Towne", new TimeSpan(0, 0, 3, 7, 0), "overriding the panel" },
                    { new Guid("00c1627d-b759-55c7-3d8f-e703fedbd0a4"), "Licensed Steel Chips", "Abigail Howe", new TimeSpan(0, 0, 2, 36, 0), "calculating the feed" },
                    { new Guid("03b18792-8f7a-ac07-9f49-2c0d2c237f3b"), "Refined Frozen Soap", "Tessie Harris", new TimeSpan(0, 0, 2, 42, 0), "You can't copy" },
                    { new Guid("0421bd3c-5030-7c1f-7f69-8d0ecd5e20f7"), "Awesome Metal Salad", "Gia Anderson", new TimeSpan(0, 0, 2, 42, 0), "The CSS circuit" },
                    { new Guid("06f83bb9-4eb4-9dfa-ed4c-fbfc7de340d3"), "Incredible Rubber Soap", "Effie Turcotte", new TimeSpan(0, 0, 2, 30, 0), "I'll reboot the" },
                    { new Guid("0d638898-b334-20d7-d559-d86f81411edf"), "Practical Steel Chicken", "Gilbert Prohaska", new TimeSpan(0, 0, 2, 50, 0), "I'll compress the" },
                    { new Guid("101323dd-7edb-c08a-b8ef-7eebc0d13343"), "Gorgeous Fresh Bike", "Kaylah Gaylord", new TimeSpan(0, 0, 2, 36, 0), "We need to" },
                    { new Guid("10ef0fbc-c412-c0b5-2153-9a65f9f07585"), "Rustic Steel Salad", "Cortney Boyer", new TimeSpan(0, 0, 3, 13, 0), "The RSS matrix" },
                    { new Guid("1522168e-3af0-4a2b-ae5f-c037f231c445"), "Fantastic Steel Cheese", "Jailyn Yundt", new TimeSpan(0, 0, 3, 4, 0), "I'll compress the" },
                    { new Guid("1eb82dfa-c0e7-e6d5-acd9-013d77ab48e3"), "Practical Rubber Chips", "Tanner Boehm", new TimeSpan(0, 0, 3, 29, 0), "Use the primary" },
                    { new Guid("256eceb8-52b2-0095-9967-84d7831987f1"), "Gorgeous Frozen Towels", "Devan Robel", new TimeSpan(0, 0, 2, 56, 0), "The SDD array" },
                    { new Guid("26e95505-aa46-ac45-c860-e000ff1526e9"), "Handcrafted Plastic Sausages", "Hannah Wuckert", new TimeSpan(0, 0, 2, 32, 0), "Try to generate" },
                    { new Guid("2be77ccd-e177-00e7-a24d-0dd3d8dd0b91"), "Fantastic Wooden Chicken", "Katrine Hintz", new TimeSpan(0, 0, 3, 18, 0), "The GB card" },
                    { new Guid("32e4acda-9163-2661-808e-99521037bffc"), "Handcrafted Fresh Bacon", "Myah Halvorson", new TimeSpan(0, 0, 2, 54, 0), "We need to" },
                    { new Guid("334cccd0-bff9-58bf-f79c-128c030193b7"), "Tasty Steel Salad", "Dewayne Hyatt", new TimeSpan(0, 0, 3, 30, 0), "I'll compress the" },
                    { new Guid("3447f187-36b2-99bf-7388-3bbade9b295b"), "Rustic Steel Shoes", "Tyrique Langworth", new TimeSpan(0, 0, 2, 53, 0), "Use the 1080p" },
                    { new Guid("378bf827-931e-4e82-09e2-4eb9256c1f26"), "Incredible Wooden Salad", "Titus Gerhold", new TimeSpan(0, 0, 2, 31, 0), "Use the neural" },
                    { new Guid("392ad14d-c224-6c37-9545-523ef9d7529d"), "Fantastic Concrete Cheese", "Josue Orn", new TimeSpan(0, 0, 3, 19, 0), "If we hack" },
                    { new Guid("399ce73c-6315-4e23-7a8c-f7731e37254e"), "Sleek Granite Shirt", "Leanna Boehm", new TimeSpan(0, 0, 3, 1, 0), "Use the digital" },
                    { new Guid("3ac37149-62d5-31f9-1fa2-c07e45b4e464"), "Ergonomic Wooden Computer", "Anahi Kassulke", new TimeSpan(0, 0, 2, 52, 0), "You can't copy" },
                    { new Guid("40a69d9b-c237-25b1-fcb3-023f5aa36fd8"), "Ergonomic Plastic Shoes", "Enoch Price", new TimeSpan(0, 0, 3, 9, 0), "We need to" },
                    { new Guid("416d134a-9485-e184-a21e-cd4fa2232278"), "Handmade Rubber Gloves", "Bria Nolan", new TimeSpan(0, 0, 3, 26, 0), "The HTTP interface" },
                    { new Guid("42c4cbf8-16de-5617-5257-c7762d018cad"), "Intelligent Granite Table", "Benjamin Abshire", new TimeSpan(0, 0, 2, 44, 0), "Try to navigate" },
                    { new Guid("452534ca-994c-4328-7508-133178875a30"), "Tasty Metal Ball", "Dedric Gislason", new TimeSpan(0, 0, 2, 59, 0), "Use the cross-platform" },
                    { new Guid("49bb0990-7c20-0dcf-fce5-3793219f6047"), "Practical Plastic Table", "Viva Moen", new TimeSpan(0, 0, 2, 44, 0), "backing up the" },
                    { new Guid("49f27222-7147-266d-80ac-3dd5264eac89"), "Rustic Metal Keyboard", "Arne Moen", new TimeSpan(0, 0, 3, 25, 0), "If we parse" },
                    { new Guid("4a6cb4f9-c745-9254-ec8b-2326736804fd"), "Licensed Cotton Fish", "Adeline Maggio", new TimeSpan(0, 0, 3, 3, 0), "If we connect" },
                    { new Guid("4d56cd88-22e4-77d9-ba00-e40a2a262126"), "Awesome Plastic Ball", "Dereck Beahan", new TimeSpan(0, 0, 2, 38, 0), "I'll parse the" },
                    { new Guid("5576e921-a374-745f-2725-c57dcdccd185"), "Small Cotton Hat", "Patience Ortiz", new TimeSpan(0, 0, 3, 15, 0), "I'll program the" },
                    { new Guid("58aba9e0-8575-cbfb-fbfd-a92cd594f622"), "Rustic Wooden Sausages", "Marlee Schneider", new TimeSpan(0, 0, 3, 30, 0), "synthesizing the interface" },
                    { new Guid("595fa0b3-bcbf-4df1-45b8-98461c1dde97"), "Practical Steel Computer", "Rod Kautzer", new TimeSpan(0, 0, 2, 59, 0), "We need to" },
                    { new Guid("5cb84213-5438-cf71-2fef-8fa85bbb9470"), "Incredible Cotton Pizza", "Willard Bernier", new TimeSpan(0, 0, 2, 45, 0), "You can't hack" },
                    { new Guid("5cc4e584-6686-ba43-b486-bf51c65fe4b8"), "Ergonomic Plastic Table", "Llewellyn Botsford", new TimeSpan(0, 0, 3, 17, 0), "If we calculate" },
                    { new Guid("5f98c9b3-8ec0-2708-788a-fd5b25980e7c"), "Rustic Frozen Soap", "Gunnar Gaylord", new TimeSpan(0, 0, 2, 37, 0), "The THX firewall" },
                    { new Guid("65f546dc-a7d5-6b91-62fc-59cb08581aaf"), "Practical Frozen Shoes", "Dagmar Waters", new TimeSpan(0, 0, 2, 58, 0), "connecting the bandwidth" },
                    { new Guid("65ff82bb-8d09-8e6c-0f2b-c4d489d94086"), "Incredible Cotton Towels", "Bette Bins", new TimeSpan(0, 0, 3, 19, 0), "Try to program" },
                    { new Guid("680c0509-a266-def4-e8b9-3e54af6bd0b9"), "Fantastic Granite Chicken", "Earnest Armstrong", new TimeSpan(0, 0, 2, 37, 0), "If we bypass" },
                    { new Guid("69abf1cb-79b7-bdb4-e1c0-248dec8f275a"), "Incredible Rubber Bike", "Milo Pollich", new TimeSpan(0, 0, 2, 32, 0), "Use the 1080p" },
                    { new Guid("6a422f78-47aa-a2f0-4c73-7980baf93708"), "Handmade Cotton Mouse", "Loy Feeney", new TimeSpan(0, 0, 3, 22, 0), "If we synthesize" },
                    { new Guid("6b254b51-3c7b-75ac-3622-b26b5f6314b4"), "Fantastic Granite Car", "Wallace Lehner", new TimeSpan(0, 0, 3, 20, 0), "Use the back-end" },
                    { new Guid("6b272fa4-465b-86c7-7c67-6e41d314447f"), "Fantastic Metal Sausages", "Virginie Barton", new TimeSpan(0, 0, 2, 53, 0), "hacking the array" },
                    { new Guid("6cbd5370-412b-0272-7556-990b89b2975a"), "Rustic Metal Hat", "Buster Botsford", new TimeSpan(0, 0, 3, 26, 0), "The SAS feed" },
                    { new Guid("6dcbc63b-2a63-09d2-13c7-7fa941e3f428"), "Small Granite Tuna", "Maybell Nikolaus", new TimeSpan(0, 0, 2, 40, 0), "I'll bypass the" },
                    { new Guid("700d1f19-5126-e507-fa3a-92bbc5f404c5"), "Licensed Rubber Chips", "Ellsworth Barton", new TimeSpan(0, 0, 3, 7, 0), "Use the virtual" },
                    { new Guid("7639ae02-e647-3785-b398-37bf8ff9e270"), "Unbranded Metal Fish", "Blair Terry", new TimeSpan(0, 0, 3, 9, 0), "bypassing the hard" },
                    { new Guid("79407105-d659-2430-1c53-ee7f130ef4ba"), "Refined Plastic Pants", "Randi Schiller", new TimeSpan(0, 0, 2, 33, 0), "Try to connect" },
                    { new Guid("79c6c817-277b-0c91-615b-b1d67808699e"), "Ergonomic Granite Shoes", "Ivy Bailey", new TimeSpan(0, 0, 3, 26, 0), "If we transmit" },
                    { new Guid("7a23a379-2cb0-bf24-e3eb-488a6222c4ab"), "Refined Plastic Chicken", "Patricia Harvey", new TimeSpan(0, 0, 2, 37, 0), "We need to" },
                    { new Guid("7ead679b-6056-0da5-c5c8-2058c35c9662"), "Generic Plastic Soap", "Devante Will", new TimeSpan(0, 0, 3, 4, 0), "The XSS alarm" },
                    { new Guid("7ee11701-8c6c-ee97-7f08-9f8cd556634d"), "Unbranded Frozen Car", "Ophelia Bernhard", new TimeSpan(0, 0, 2, 48, 0), "Try to back" },
                    { new Guid("81dc975b-3c9d-bcab-eaf6-f16a99b60231"), "Practical Wooden Soap", "Jabari Dach", new TimeSpan(0, 0, 2, 48, 0), "Try to generate" },
                    { new Guid("820a8d0a-098f-4f37-617d-13cc8f4918e4"), "Awesome Frozen Computer", "Donald Hirthe", new TimeSpan(0, 0, 2, 49, 0), "I'll quantify the" },
                    { new Guid("84392580-8c61-c0d8-3c11-061120df963b"), "Practical Wooden Gloves", "Marina Watsica", new TimeSpan(0, 0, 3, 10, 0), "Try to connect" },
                    { new Guid("86ebcd6f-c87b-fad8-0e80-0eb52f8a9a43"), "Incredible Concrete Tuna", "Jovany Satterfield", new TimeSpan(0, 0, 2, 36, 0), "Use the neural" },
                    { new Guid("8b220216-0039-d9aa-bbe2-5edfa598a947"), "Gorgeous Steel Hat", "Arvel Pacocha", new TimeSpan(0, 0, 3, 11, 0), "If we copy" },
                    { new Guid("8cd1f973-a06e-1674-73ef-3854a0cf97fc"), "Small Frozen Pizza", "Shanel Yundt", new TimeSpan(0, 0, 3, 4, 0), "I'll bypass the" },
                    { new Guid("9041ab93-2fae-6810-6e5d-dc7bcd7f57e8"), "Refined Fresh Salad", "Mabel Weissnat", new TimeSpan(0, 0, 3, 21, 0), "The RAM hard" },
                    { new Guid("90430125-eb32-56a4-3db8-cc4710467157"), "Unbranded Soft Cheese", "Elyssa Schiller", new TimeSpan(0, 0, 3, 6, 0), "If we calculate" },
                    { new Guid("90ad94db-7de6-f2f2-21d8-8dccb292ba0e"), "Ergonomic Wooden Towels", "Isaiah Blanda", new TimeSpan(0, 0, 3, 9, 0), "We need to" },
                    { new Guid("92a61fad-5aa2-4b89-e47e-4b852713c3ac"), "Sleek Granite Ball", "Aletha Kunze", new TimeSpan(0, 0, 2, 45, 0), "If we navigate" },
                    { new Guid("936f6676-dabe-8e1a-496b-ef09d7a5592e"), "Fantastic Wooden Computer", "Maximillia Abbott", new TimeSpan(0, 0, 2, 56, 0), "The JSON firewall" },
                    { new Guid("9841a693-344d-9dc1-69e7-b51a99feed43"), "Sleek Frozen Gloves", "Laila Stark", new TimeSpan(0, 0, 2, 50, 0), "The THX monitor" },
                    { new Guid("9c2b1595-45f8-672e-e24d-46b081cda8ed"), "Incredible Metal Towels", "Ursula Smitham", new TimeSpan(0, 0, 3, 30, 0), "You can't override" },
                    { new Guid("9df56807-78d6-50be-5f09-85de6a1ec4ff"), "Awesome Cotton Computer", "Ed Feeney", new TimeSpan(0, 0, 3, 24, 0), "The JSON program" },
                    { new Guid("9e0146df-a0dd-114e-c601-c9bd66f80df0"), "Gorgeous Concrete Pants", "Ola Mraz", new TimeSpan(0, 0, 2, 40, 0), "If we program" },
                    { new Guid("a01cf8f3-9cd0-cc79-7eb3-ff22611e03a9"), "Refined Concrete Fish", "Blake Hodkiewicz", new TimeSpan(0, 0, 2, 37, 0), "Use the virtual" },
                    { new Guid("a3119096-12dd-2fa4-ed31-f467fb519d9f"), "Unbranded Fresh Salad", "Luciano Blick", new TimeSpan(0, 0, 2, 40, 0), "Use the back-end" },
                    { new Guid("a3aba8c4-8813-0ede-ac5f-ab782189b5eb"), "Licensed Soft Sausages", "Ronaldo Pagac", new TimeSpan(0, 0, 3, 9, 0), "You can't compress" },
                    { new Guid("a86028b5-eb5a-01f1-1df1-eb287b3747c1"), "Small Plastic Chips", "Else Ullrich", new TimeSpan(0, 0, 3, 1, 0), "I'll reboot the" },
                    { new Guid("ab9eaf0f-006e-9244-5efd-c113274a70a2"), "Practical Concrete Bacon", "Marley Schroeder", new TimeSpan(0, 0, 3, 6, 0), "indexing the array" },
                    { new Guid("af878b8c-9b73-c10f-1991-eb9105db76d5"), "Sleek Cotton Hat", "Ardella Powlowski", new TimeSpan(0, 0, 2, 50, 0), "Use the back-end" },
                    { new Guid("b340c0d5-5357-3745-ab3b-7d8dddaa4a9b"), "Handcrafted Cotton Bike", "Janie Fisher", new TimeSpan(0, 0, 2, 40, 0), "You can't generate" },
                    { new Guid("b6a4d1f1-855b-265b-2974-26e820a54cb5"), "Refined Rubber Gloves", "Arturo O'Kon", new TimeSpan(0, 0, 3, 22, 0), "If we index" },
                    { new Guid("bb12c7e2-f9a8-5109-2da9-4a6420f16e85"), "Small Rubber Keyboard", "Brittany Schulist", new TimeSpan(0, 0, 2, 53, 0), "indexing the card" },
                    { new Guid("bb433fae-39eb-71b1-910e-256c4d998f5a"), "Fantastic Frozen Pizza", "Tamara Ritchie", new TimeSpan(0, 0, 3, 28, 0), "We need to" },
                    { new Guid("c35e1626-10b3-d866-7821-419e1e94c5ab"), "Refined Wooden Soap", "Ramiro Harvey", new TimeSpan(0, 0, 3, 3, 0), "We need to" },
                    { new Guid("c65e4c3e-f594-847a-0f65-5853f2fee697"), "Rustic Metal Table", "Fritz Grady", new TimeSpan(0, 0, 2, 48, 0), "We need to" },
                    { new Guid("cbbe5302-f9c4-a7f3-7e45-7d293332c0b6"), "Handmade Rubber Chicken", "Wilton Corkery", new TimeSpan(0, 0, 2, 58, 0), "We need to" },
                    { new Guid("cd0936a2-cc05-ae67-291f-f0d9510e163e"), "Incredible Granite Fish", "Maxie Kuphal", new TimeSpan(0, 0, 2, 36, 0), "If we calculate" },
                    { new Guid("ce3c2ecd-87f1-8357-65eb-60bb46bd5b9f"), "Gorgeous Rubber Towels", "Deondre Emard", new TimeSpan(0, 0, 2, 34, 0), "The JBOD hard" },
                    { new Guid("d0c42c0a-10da-671e-af1c-f953b57d5493"), "Gorgeous Wooden Tuna", "Kory Christiansen", new TimeSpan(0, 0, 2, 33, 0), "Use the online" },
                    { new Guid("d0c5583a-5eec-720b-0954-94ca69eee435"), "Rustic Steel Computer", "Bert Windler", new TimeSpan(0, 0, 3, 20, 0), "You can't navigate" },
                    { new Guid("d25805f6-a1fa-3d92-c0a2-f76da2bf6d35"), "Awesome Fresh Soap", "Michel Keebler", new TimeSpan(0, 0, 3, 25, 0), "The JBOD protocol" },
                    { new Guid("d3ef43fd-5d8e-4fe3-3db7-a3e42fd28932"), "Rustic Soft Salad", "Gregg Marks", new TimeSpan(0, 0, 2, 50, 0), "synthesizing the alarm" },
                    { new Guid("d4f53a08-378e-87af-c2ee-76b5417d08ed"), "Handmade Soft Keyboard", "Deion Anderson", new TimeSpan(0, 0, 3, 13, 0), "If we generate" },
                    { new Guid("d84128ea-6894-65dd-37f8-6fc9aaad8ccc"), "Awesome Plastic Sausages", "Sophie Konopelski", new TimeSpan(0, 0, 3, 8, 0), "Use the back-end" },
                    { new Guid("d993c1d1-0d5e-71b0-b4ee-f7f9ace2261f"), "Gorgeous Granite Table", "Madaline Hirthe", new TimeSpan(0, 0, 2, 54, 0), "overriding the monitor" },
                    { new Guid("da8016b2-bd5c-4b96-3929-f517bd65b521"), "Incredible Frozen Cheese", "Velma Hand", new TimeSpan(0, 0, 2, 34, 0), "Try to index" },
                    { new Guid("dce4d4e0-26f4-974f-624a-82f780bdb531"), "Tasty Plastic Pants", "Peter Parisian", new TimeSpan(0, 0, 3, 21, 0), "I'll parse the" },
                    { new Guid("dea8f8e4-52dd-5dad-d26a-d14d282f023c"), "Practical Soft Gloves", "Barbara Stanton", new TimeSpan(0, 0, 2, 42, 0), "navigating the hard" },
                    { new Guid("e1b81f8a-e7ef-65dd-1dbb-d690142cdac9"), "Intelligent Rubber Sausages", "Andre Rohan", new TimeSpan(0, 0, 3, 9, 0), "Try to connect" },
                    { new Guid("e21b469f-113c-088c-9386-fa771d2ee184"), "Gorgeous Metal Sausages", "Marianna Hettinger", new TimeSpan(0, 0, 3, 29, 0), "The ADP interface" },
                    { new Guid("e6e78d59-4620-878d-2527-1695b0f4ae86"), "Practical Cotton Tuna", "Alessandro Kertzmann", new TimeSpan(0, 0, 3, 1, 0), "overriding the microchip" },
                    { new Guid("e943fb26-4d85-83c6-3c08-7e1147e1f117"), "Refined Fresh Bike", "Daphney Schneider", new TimeSpan(0, 0, 2, 54, 0), "I'll compress the" },
                    { new Guid("ec91d5e0-363d-e37d-c923-2c1e0f1e3ad1"), "Refined Wooden Pizza", "Polly Hamill", new TimeSpan(0, 0, 2, 42, 0), "We need to" },
                    { new Guid("f065b2d5-46f5-efe4-1d49-90e38d005c36"), "Fantastic Metal Sausages", "Columbus Sipes", new TimeSpan(0, 0, 3, 18, 0), "I'll hack the" },
                    { new Guid("f30f5d2c-570e-7a70-44e2-08d36a6ac388"), "Generic Wooden Cheese", "Francesca Harris", new TimeSpan(0, 0, 3, 23, 0), "The PNG bus" },
                    { new Guid("f547f9ec-3e8c-4f66-f342-ff6a26e57c4c"), "Handcrafted Granite Pants", "Gayle Cole", new TimeSpan(0, 0, 3, 26, 0), "If we program" },
                    { new Guid("fb8efa5b-8cef-9b8a-57e1-dada3c3d8bee"), "Unbranded Granite Computer", "Eugenia Vandervort", new TimeSpan(0, 0, 3, 25, 0), "If we override" },
                    { new Guid("fdbb9057-2368-8b74-440c-cd33f83b80e2"), "Handmade Frozen Salad", "Josianne VonRueden", new TimeSpan(0, 0, 3, 11, 0), "Try to generate" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "EmailAddress", "Gender", "Name", "PasswordHash" },
                values: new object[,]
                {
                    { new Guid("00f6ff8f-b49e-2bee-d9e6-1ad944658226"), 36, "Destiny_Fadel63@yahoo.com", "Female", "Lorenzo", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("159250a1-1c44-2b37-e569-79d68b9292dc"), 27, "Bernardo.Kassulke@hotmail.com", "Female", "Vida", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("1cdc63a1-a170-2544-0db7-18c92d8135c3"), 55, "Ralph_Carter@yahoo.com", "Male", "Dereck", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("2308f9c7-b058-92e6-3d72-e40a39a79b2d"), 57, "Stanford_Bechtelar22@hotmail.com", "Male", "Delbert", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("306ff9cf-5901-88c8-f5e2-36c50ffed1ca"), 58, "Else27@gmail.com", "Female", "Yazmin", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("374ff369-7344-520d-ca11-39e4bb378a94"), 31, "Albertha.Crooks8@hotmail.com", "Male", "Kailyn", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("400a742c-223a-eb51-c8c6-e91d020ca9ca"), 22, "Adella.Kilback@yahoo.com", "Female", "Micheal", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("43e9c98c-e32c-5a1f-a084-4c2cc88d46b8"), 34, "Stephania.Farrell89@yahoo.com", "Female", "Berenice", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("470b51ee-0123-a7b6-d38e-0cd6923740c3"), 64, "Hannah_Jakubowski@hotmail.com", "Male", "Alessia", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("4bd707c6-3eb3-efa2-7ad1-76fca1005e1c"), 25, "Tamia21@gmail.com", "Female", "Jensen", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("4d174d97-ac9a-a0da-faab-811b296bf394"), 76, "Edythe.Rosenbaum@gmail.com", "Female", "Roscoe", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("4dfdb6fa-1fc4-969a-9aee-7363b8d17ba2"), 16, "Marcia96@gmail.com", "Male", "Tommie", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("5bc3b192-61d8-4e47-9648-3399f907a0d4"), 29, "Elnora_McLaughlin@gmail.com", "Female", "Felicia", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("5d1ada9c-9b33-85b9-4fb3-dc9beee8b363"), 25, "Amir_Anderson21@yahoo.com", "Female", "Alison", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("61ccd198-1526-8b56-3eaf-f33418273c06"), 30, "Darren75@hotmail.com", "Male", "Shana", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("641d98a1-3dbb-8221-f2c7-97b08fa1f20b"), 99, "Janice.Blick6@yahoo.com", "Male", "Karelle", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("6b584d62-4b83-fb85-4667-b365275555ce"), 86, "Bettie_Rodriguez40@yahoo.com", "Male", "Dameon", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("6c8c7069-429d-b784-bea4-c9a86c5bd981"), 43, "Gardner.Fay41@gmail.com", "Male", "Gavin", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("6ebd1f36-af00-2a52-b5ea-4c536f1daf25"), 54, "Trudie48@gmail.com", "Female", "Kennedi", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("82e5c7d8-ceef-d06d-e09e-fd983c59520e"), 77, "Hailee_Conn@gmail.com", "Male", "Darion", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("8ae04cc0-7d4d-0516-175b-8aa849a54823"), 73, "Natasha_Kuphal@yahoo.com", "Female", "Estefania", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("8d6cd980-ff3f-857a-9c8d-70ab438758c8"), 95, "Asha.Kub72@gmail.com", "Female", "Giovanny", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("8fe23930-b890-fab3-a3f1-126c27286ced"), 97, "Darrin_Harvey@gmail.com", "Male", "Marcelina", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("9cc816a0-cee8-0072-e126-aa05cd5d36d0"), 68, "Ramiro28@hotmail.com", "Male", "Christiana", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("b25d2f3d-25a4-a565-e358-33d5202f92d3"), 85, "Sandy_Gusikowski@hotmail.com", "Male", "Newton", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("b4d501e2-b9bc-b03d-0a4b-0b91c05be642"), 37, "Carley.Zulauf@hotmail.com", "Male", "Rickie", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("c5f0777c-d807-0ec9-7ea6-bc90257c4002"), 82, "Reba_Abernathy82@hotmail.com", "Female", "Reynold", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("d4fda984-c6aa-37e6-6b9c-34b20a15511c"), 97, "Vallie95@gmail.com", "Male", "Malcolm", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("f3a4f3b1-4d65-48ac-811d-db829e99e7a0"), 68, "Lottie_Pagac47@yahoo.com", "Male", "Reginald", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" },
                    { new Guid("fb535609-be2b-4111-30f1-5deaaf2a9f2a"), 59, "Talon_Swaniawski64@gmail.com", "Male", "Terrill", "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey" }
                });

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
