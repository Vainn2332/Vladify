using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vladify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
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
                columns: new[] { "Id", "Age", "Auth0Id", "EmailAddress", "Gender", "Name" },
                values: new object[,]
                {
                    { new Guid("0b327472-1f14-2c4f-f4b9-57c2e58e042b"), 51, "auth0|6c2eb9758e47a3adb6059897", "Darien47@yahoo.com", "Male", "Eleonore" },
                    { new Guid("0cf19b61-ead8-4a1f-dedf-253b1a19f953"), 73, "auth0|708b8e9a26246dc8c180428a", "Devin26@gmail.com", "Female", "Hudson" },
                    { new Guid("0e59f64a-393f-8e5f-c0b9-727020618505"), 89, "auth0|5382bb1cc37f9b50b3fc99b7", "Abdiel12@hotmail.com", "Male", "Friedrich" },
                    { new Guid("131551d9-8b51-aa9b-5f4f-60149b73ce36"), 65, "auth0|e382a76cd42b83d8af9c2165", "Stefan_OKon@hotmail.com", "Female", "Lottie" },
                    { new Guid("265efd82-23e1-5055-0ec1-99e1909eee51"), 68, "auth0|baff45a455ed41a5afb4ded2", "Camilla_Goyette@yahoo.com", "Female", "Ryann" },
                    { new Guid("289aeedd-ea39-f13c-de85-52c7ea8161d0"), 44, "auth0|3f3f1d6f39be703485f6099a", "Moses.Witting@yahoo.com", "Female", "Thora" },
                    { new Guid("2bc16a08-bd79-3f4c-78f5-82f459651adf"), 61, "auth0|cf68da0320cafa947cb71dbd", "Coy86@hotmail.com", "Male", "Rigoberto" },
                    { new Guid("2f3191fb-7b43-e21c-1ef7-3a0bdf30ef5e"), 45, "auth0|0d06f8a5d03ffecf0915d30b", "Akeem.Kub@gmail.com", "Male", "Darrick" },
                    { new Guid("379cf832-8f81-a957-af5e-eced582074a6"), 62, "auth0|765480824399de75eedfb0ea", "Dejuan_Haag@yahoo.com", "Female", "Jermaine" },
                    { new Guid("3e2e7eff-03ed-fb51-8b66-f9f7e90b5a76"), 54, "auth0|81cdcefe7262032c85516cd4", "Malachi.Harris@hotmail.com", "Male", "Serena" },
                    { new Guid("5dc8ad76-49f7-80c2-bd08-8d65dad270bb"), 63, "auth0|43268d72ef231de6321e0d6d", "Jay_Cummerata@yahoo.com", "Female", "Alva" },
                    { new Guid("78cc6070-4980-07c1-2d55-e70d9db375be"), 15, "auth0|1381d1fa2ec420b3aeb0885f", "Cleo.Romaguera80@gmail.com", "Male", "Kylee" },
                    { new Guid("7a55571c-5026-c92b-f08e-d2467b19eb3b"), 100, "auth0|2f51113811b58582f0f6b953", "Rocky.Schneider51@hotmail.com", "Male", "Maiya" },
                    { new Guid("866293ea-f419-3c74-37a3-acfa8809bb01"), 64, "auth0|431fbbb4792d4ea0fb02931b", "Ola72@gmail.com", "Female", "Alexa" },
                    { new Guid("86a5f586-9356-c520-56cf-a74d613d8d83"), 85, "auth0|1535cf887f4e5a78687c076b", "Name2@hotmail.com", "Female", "Bella" },
                    { new Guid("929ce18a-987f-8050-daa7-a68a5b66bdc9"), 36, "auth0|156988978ac0c3aab17fb8d7", "Clint1@yahoo.com", "Male", "Enos" },
                    { new Guid("a69b52b6-c94c-8597-3caa-d96c3f343546"), 73, "auth0|4c4a76a71424fc97509b211b", "Rebekah_Schimmel@yahoo.com", "Female", "Tyshawn" },
                    { new Guid("a72240dd-7e82-3f97-9241-3474c8a08aaf"), 76, "auth0|9d94419b81c0bd8a512e61b4", "Boyd7@hotmail.com", "Female", "Arlene" },
                    { new Guid("b4565a79-c451-e1fa-a2fe-dfc6ff8952d4"), 26, "auth0|608da6edcc2d35d9bec40cea", "Domenic57@yahoo.com", "Male", "Annamae" },
                    { new Guid("b5f6a58e-161c-3ad5-265d-89020ae34f9c"), 16, "auth0|dfc1415a5808166d318a32ae", "Casper_Jerde57@gmail.com", "Female", "Austin" },
                    { new Guid("bea1547b-b9d1-f09e-93b5-fda972d6c8f6"), 22, "auth0|03d889a3a9af9d1893aa44a4", "Hailey_Welch28@yahoo.com", "Female", "Nova" },
                    { new Guid("c21587eb-a5ce-fc9f-b788-85944d7805cb"), 44, "auth0|7b4fb00a4d7846411b64d384", "Annette5@gmail.com", "Female", "Daniela" },
                    { new Guid("c2246c1d-89ab-1cb3-5de1-80fbc7452042"), 72, "auth0|6447208c38f13950a546d3f0", "Chyna84@yahoo.com", "Male", "Sid" },
                    { new Guid("c3d55153-3986-d237-762e-2a76fc42d63d"), 17, "auth0|4d611989f74d395718abccb8", "Giuseppe.Jaskolski4@hotmail.com", "Female", "Blanca" },
                    { new Guid("c77b6191-dd09-bdfd-02c2-b6293ab1188b"), 55, "auth0|cb330fc98cf2b7d49400ed7d", "Alek_McLaughlin@gmail.com", "Male", "Laila" },
                    { new Guid("dff46f0a-6755-3f32-8800-9bed12a121e3"), 54, "auth0|dfd0773f359ff22a4e4e8b2b", "Alda.Hegmann@yahoo.com", "Female", "Kathlyn" },
                    { new Guid("e2c7bad6-e520-2637-bf5f-1655295e33a9"), 46, "auth0|d7b6e1a126e9ff1c04c23e94", "Zechariah_McCullough63@yahoo.com", "Male", "Edna" },
                    { new Guid("e4cfc815-3aa1-7b93-2173-b65f52b832fe"), 37, "auth0|be664f36c55f55b068af6199", "Marie68@hotmail.com", "Female", "Ulises" },
                    { new Guid("ecd1ff1b-e67b-6ec1-86a6-d504a97024a3"), 73, "auth0|dff5029d98ae3fe1cf84c2a7", "Eldridge_Heller52@hotmail.com", "Male", "Milton" },
                    { new Guid("f0ccfb89-f1bb-d438-69d3-84d968ca1de4"), 98, "auth0|005c3a0e2b925d10715035cf", "Oceane_Ruecker40@yahoo.com", "Male", "Irwin" }
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
