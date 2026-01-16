using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vladify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
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
                    { new Guid("03a32c0c-dfd8-75d3-9cbb-d1d1179d9221"), "Handcrafted Wooden Towels", "Fay Rodriguez", new TimeSpan(0, 0, 2, 46, 0), "Use the multi-byte JSON capacitor, then you can ov" },
                    { new Guid("16792114-006b-3522-c8f5-b2186f474e11"), "Refined Fresh Cheese", "Angus Moen", new TimeSpan(0, 0, 3, 24, 0), "The CSS monitor is down, index the virtual monitor" },
                    { new Guid("1e2aeb2e-aded-8f56-c6e7-5aa7e1e9ee75"), "Small Wooden Shoes", "Tod Schmitt", new TimeSpan(0, 0, 2, 57, 0), "You can't back up the port without programming the" },
                    { new Guid("20f25a68-0c63-cd94-fdda-b8292753fabf"), "Rustic Granite Keyboard", "Emiliano Lemke", new TimeSpan(0, 0, 2, 50, 0), "We need to calculate the virtual EXE driver!" },
                    { new Guid("21694ed3-26aa-ea88-37f6-d977c03e29fa"), "Sleek Metal Gloves", "Emelia Langworth", new TimeSpan(0, 0, 2, 44, 0), "Try to hack the HDD hard drive, maybe it will hack" },
                    { new Guid("68b64f25-1f81-47e8-94ad-66c50add85d2"), "Awesome Concrete Fish", "Maude Schumm", new TimeSpan(0, 0, 2, 50, 0), "We need to generate the optical RAM pixel!" },
                    { new Guid("6ec416e1-40b1-21c2-9ab3-7c80966d8b78"), "Practical Frozen Keyboard", "Cassandra Satterfield", new TimeSpan(0, 0, 3, 11, 0), "We need to transmit the mobile SMS matrix!" },
                    { new Guid("aa111f74-39f3-e8c5-3f70-f6a055e26563"), "Sleek Concrete Table", "Paul O'Hara", new TimeSpan(0, 0, 3, 15, 0), "Use the back-end EXE pixel, then you can transmit" },
                    { new Guid("bb4abd66-92b6-13db-ccf2-c8750ef0c75f"), "Generic Granite Bike", "Clemens Schmidt", new TimeSpan(0, 0, 3, 9, 0), "The HTTP capacitor is down, back up the primary ca" },
                    { new Guid("c2a31245-af50-bc92-96fe-cf10eb92c8bd"), "Unbranded Fresh Bacon", "Harmon Bode", new TimeSpan(0, 0, 2, 54, 0), "I'll hack the auxiliary XML transmitter, that shou" },
                    { new Guid("d7f8fba1-4660-fa20-1788-1e321c8060c5"), "Handmade Wooden Table", "Camden Bernier", new TimeSpan(0, 0, 2, 35, 0), "The SQL array is down, navigate the solid state ar" },
                    { new Guid("e12c3cbd-671a-de0e-7016-1a84c27f54d1"), "Sleek Granite Gloves", "Kimberly Hand", new TimeSpan(0, 0, 3, 21, 0), "Use the wireless HTTP bus, then you can parse the" },
                    { new Guid("e461cac3-a797-9d2e-c55d-37a2386989be"), "Licensed Cotton Hat", "Yazmin Gottlieb", new TimeSpan(0, 0, 2, 37, 0), "Try to calculate the EXE card, maybe it will calcu" },
                    { new Guid("f6f8e718-ad1f-35ca-1c90-9e8a323eb529"), "Unbranded Cotton Gloves", "Nicole Heathcote", new TimeSpan(0, 0, 3, 19, 0), "Use the mobile RAM protocol, then you can navigate" },
                    { new Guid("fd212961-3e6f-85b0-ecfc-971428c40a50"), "Small Metal Hat", "Hans McCullough", new TimeSpan(0, 0, 2, 34, 0), "Try to override the SDD microchip, maybe it will o" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "EmailAddress", "Gender", "Name", "PasswordHash" },
                values: new object[,]
                {
                    { new Guid("111f7409-f3aa-c539-e83f-70f6a055e265"), 82, "Karson_Corwin@yahoo.com", "Male", "Freddie", "$2a$11$wTbEK3tCinUPujptWa0WVu9AEoaRxZMPqtQAbkjea69zHGiO4hnCC" },
                    { new Guid("241eb9a3-9c4b-a115-fbf8-d7604620fa17"), 32, "Oral42@hotmail.com", "Female", "Arturo", "$2a$11$wTbEK3tCinUPujptWa0WVu9AEoaRxZMPqtQAbkjea69zHGiO4hnCC" },
                    { new Guid("82375f54-0c32-a32c-03d8-dfd3759cbbd1"), 93, "Hermina_Smith@yahoo.com", "Female", "Asha", "$2a$11$wTbEK3tCinUPujptWa0WVu9AEoaRxZMPqtQAbkjea69zHGiO4hnCC" },
                    { new Guid("844d47fe-2114-1679-6b00-2235c8f5b218"), 31, "Adelia.Medhurst32@hotmail.com", "Female", "Kyler", "$2a$11$wTbEK3tCinUPujptWa0WVu9AEoaRxZMPqtQAbkjea69zHGiO4hnCC" },
                    { new Guid("b45a9481-b534-34e6-9ef6-71685af22063"), 39, "Penelope.Champlin43@gmail.com", "Male", "Candelario", "$2a$11$wTbEK3tCinUPujptWa0WVu9AEoaRxZMPqtQAbkjea69zHGiO4hnCC" },
                    { new Guid("c892eb10-c8bd-336b-6139-f6ec530be72e"), 83, "Krystal62@yahoo.com", "Male", "Greg", "$2a$11$wTbEK3tCinUPujptWa0WVu9AEoaRxZMPqtQAbkjea69zHGiO4hnCC" },
                    { new Guid("d9f637ea-c077-293e-fa11-8122b02ccada"), 46, "Emelia26@gmail.com", "Male", "Lucious", "$2a$11$wTbEK3tCinUPujptWa0WVu9AEoaRxZMPqtQAbkjea69zHGiO4hnCC" },
                    { new Guid("e0f9bffa-0e92-f443-87a3-b642616d4512"), 86, "Arturo.Hyatt2@gmail.com", "Male", "Dean", "$2a$11$wTbEK3tCinUPujptWa0WVu9AEoaRxZMPqtQAbkjea69zHGiO4hnCC" },
                    { new Guid("e81f8168-9447-66ad-c50a-dd85d292bba0"), 74, "Johathan70@yahoo.com", "Female", "Miracle", "$2a$11$wTbEK3tCinUPujptWa0WVu9AEoaRxZMPqtQAbkjea69zHGiO4hnCC" },
                    { new Guid("f6f8e718-ad1f-35ca-1c90-9e8a323eb529"), 95, "Vada37@gmail.com", "Male", "Lila", "$2a$11$wTbEK3tCinUPujptWa0WVu9AEoaRxZMPqtQAbkjea69zHGiO4hnCC" }
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
