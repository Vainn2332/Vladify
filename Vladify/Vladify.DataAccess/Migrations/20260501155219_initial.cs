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
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExternalId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Playlists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Playlists_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Album = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Songs_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PlaylistSong",
                columns: table => new
                {
                    PlaylistsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SongsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistSong", x => new { x.PlaylistsId, x.SongsId });
                    table.ForeignKey(
                        name: "FK_PlaylistSong_Playlists_PlaylistsId",
                        column: x => x.PlaylistsId,
                        principalTable: "Playlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaylistSong_Songs_SongsId",
                        column: x => x.SongsId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "EmailAddress", "ExternalId", "Gender", "Name" },
                values: new object[,]
                {
                    { new Guid("062f3c05-dd11-1323-10db-7e8ac0b8ef7e"), 73, "Cesar.Kertzmann58@gmail.com", "auth0|409472f82d94d3841f5bacac", "Female", "Ephraim" },
                    { new Guid("0e51d9f0-3e16-1570-8751-8bfcad3c76b7"), 50, "Thaddeus_Doyle90@yahoo.com", "auth0|71464b4db7170a63f5f66302", "Male", "Guadalupe" },
                    { new Guid("17f3f721-c6c8-7b79-2791-0c615bb1d678"), 73, "Sammie.Kilback58@hotmail.com", "auth0|c2300db4d17770e0fd3b514d", "Male", "Elisa" },
                    { new Guid("1c8575f0-6194-339d-ad3e-2e7c3866a80f"), 94, "Larue46@hotmail.com", "auth0|1b95a2b93ad5c83c5c75374d", "Male", "Marley" },
                    { new Guid("1e2c23c9-1e0f-d13a-4cac-27078dac190f"), 91, "Delia_Weissnat@gmail.com", "auth0|dc5306dedbf39ac445bfd733", "Female", "Bridget" },
                    { new Guid("2349b3e1-f845-5b61-fa8e-fbef8c8a9b57"), 67, "Corine.Cormier98@gmail.com", "auth0|26bc1501a4483e815ee97872", "Female", "Lelah" },
                    { new Guid("28a25f0e-dfa5-dc8a-9ec7-db94ad90e67d"), 66, "Emery.Kunde76@hotmail.com", "auth0|e2f2df7f262fee8312871a9d", "Female", "Monique" },
                    { new Guid("3a4637ab-0383-947a-860b-598de7e62046"), 88, "Clotilde_Swaniawski@gmail.com", "auth0|52a0838fcdcce32176a06863", "Male", "Vernice" },
                    { new Guid("455357b3-ab37-7d3b-8ddd-aa4a9b035760"), 61, "Lizzie52@hotmail.com", "auth0|9d8a637327a243676fb0a2a2", "Male", "Zaria" },
                    { new Guid("49bb0990-7c20-0dcf-fce5-3793219f6047"), 19, "Sabina.Marvin26@gmail.com", "auth0|d8b0d2646f930a379fe684d8", "Female", "Marianne" },
                    { new Guid("552d18c2-86b9-4773-0253-becbc4f9f3a7"), 49, "Manley_Cronin40@gmail.com", "auth0|8e7649d4282d97b9af274259", "Male", "Gerhard" },
                    { new Guid("62974f26-824a-80f7-bdb5-31fe456909ca"), 43, "Daniella_Senger@gmail.com", "auth0|ff55cad7b4daa656cc153a24", "Female", "Shirley" },
                    { new Guid("65ff82bb-8d09-8e6c-0f2b-c4d489d94086"), 52, "Domenick_Steuber@hotmail.com", "auth0|535aae56811c2e6ed5cfb00c", "Male", "Jada" },
                    { new Guid("7775e280-c280-eecf-54f4-31fbbf49b93b"), 53, "Jett.Robel53@gmail.com", "auth0|287a0086ac05cae7e30e4994", "Male", "Sterling" },
                    { new Guid("7fc71309-41a9-f4e3-287b-8345ecad8131"), 42, "Halle_Pfannerstill73@gmail.com", "auth0|7aba268e3c08c9249e9ad2f2", "Male", "Maryam" },
                    { new Guid("8717fef3-a26b-e361-ca4b-173b514b256b"), 74, "Norbert_Schroeder@gmail.com", "auth0|e58f8575cf3f8b24e6571f8d", "Female", "William" },
                    { new Guid("89d22fe4-5532-ac42-0f6e-976e2e92da05"), 100, "Earnest67@hotmail.com", "auth0|53d2d94826faf10990721115", "Female", "Julien" },
                    { new Guid("9c2b1595-45f8-672e-e24d-46b081cda8ed"), 58, "Mariano.Braun85@gmail.com", "auth0|7e41734a9fdfdf60a11356ca", "Male", "Pearline" },
                    { new Guid("a8c435d2-a3ab-8813-de0e-ac5fab782189"), 44, "Darron70@yahoo.com", "auth0|c0734263ccfdaafd54b28c4a", "Female", "Greyson" },
                    { new Guid("b471b00d-f7ee-acf9-e226-1fd24d76e93c"), 41, "Kacie.Renner92@hotmail.com", "auth0|e486a6697cad876bc62f970b", "Female", "Louie" },
                    { new Guid("d14d8488-392a-c224-376c-9545523ef9d7"), 28, "Amelie.Pollich@gmail.com", "auth0|59183f9253c8ad6726aa967b", "Female", "Enrique" },
                    { new Guid("d82de857-522c-c556-b013-d78f474f9287"), 72, "Letha_Ratke@gmail.com", "auth0|c1ea939e82e2e265a0c4df9e", "Male", "Ernie" },
                    { new Guid("d922e44d-ba77-e400-0a2a-26212685a3c3"), 90, "Ines_Balistreri@gmail.com", "auth0|7af854402fac00e8a384ef82", "Female", "Tressa" },
                    { new Guid("d9ace6d5-3d01-ab77-48e3-ab1f26334575"), 86, "Elizabeth_Braun@yahoo.com", "auth0|69fe1fec7f569e507938043b", "Female", "Brenda" },
                    { new Guid("de35e4ee-1a3c-5790-7777-f1ec1069e422"), 38, "Stephen48@yahoo.com", "auth0|966e3969e00ea631cb22f2a2", "Male", "Arne" },
                    { new Guid("e1863474-f4ae-c7e2-12bb-a8f909512da9"), 65, "Timmy_Considine@yahoo.com", "auth0|1932dbc737460922d683bbf7", "Male", "Brennon" },
                    { new Guid("eb5aa860-01f1-f11d-eb28-7b3747c1dca7"), 75, "Elmer76@yahoo.com", "auth0|a41e05f4e8bbb2dfa3a3731a", "Male", "Lester" },
                    { new Guid("f4c5bb92-c504-dc74-c969-fbb76ae50f7e"), 28, "Miller.Carter@gmail.com", "auth0|0998f7431d4181ce6e9a5bb1", "Male", "Rhoda" },
                    { new Guid("fa333e3f-3b75-cd02-7ce7-2b77e1e700a2"), 99, "Jeanette.Bartoletti@hotmail.com", "auth0|d8d5248b2594d52b85cd5352", "Female", "Joanie" },
                    { new Guid("ffd23d02-4eb5-4217-2b43-f9b46c4a45c7"), 43, "Leslie44@yahoo.com", "auth0|bccf82be5b1f4667c6b098af", "Male", "Marcia" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Album", "AuthorId", "Duration", "Title" },
                values: new object[,]
                {
                    { new Guid("00ae81eb-9076-dafb-393e-4c5ec694f57a"), "Ergonomic Metal Chicken", new Guid("0e51d9f0-3e16-1570-8751-8bfcad3c76b7"), new TimeSpan(0, 0, 3, 24, 0), "If we parse" },
                    { new Guid("04f5621f-6374-2a1e-e25b-22572c5d0ff3"), "Small Cotton Car", new Guid("7775e280-c280-eecf-54f4-31fbbf49b93b"), new TimeSpan(0, 0, 3, 16, 0), "We need to" },
                    { new Guid("06ed55e8-0796-319e-0f27-382a71603116"), "Handcrafted Metal Salad", new Guid("455357b3-ab37-7d3b-8ddd-aa4a9b035760"), new TimeSpan(0, 0, 2, 31, 0), "backing up the" },
                    { new Guid("07e0a687-69f6-7b9c-c574-a6d861437073"), "Generic Soft Chicken", new Guid("d922e44d-ba77-e400-0a2a-26212685a3c3"), new TimeSpan(0, 0, 2, 48, 0), "We need to" },
                    { new Guid("0fe166fe-c78d-6117-e11b-5f5571ec9fe1"), "Tasty Rubber Towels", new Guid("eb5aa860-01f1-f11d-eb28-7b3747c1dca7"), new TimeSpan(0, 0, 2, 46, 0), "Try to generate" },
                    { new Guid("11d7a753-0e7a-2903-21ee-510b472301b6"), "Practical Cotton Chips", new Guid("49bb0990-7c20-0dcf-fce5-3793219f6047"), new TimeSpan(0, 0, 3, 19, 0), "If we synthesize" },
                    { new Guid("150ab234-1c51-085d-6b51-3e1e031a7c77"), "Incredible Frozen Tuna", new Guid("7775e280-c280-eecf-54f4-31fbbf49b93b"), new TimeSpan(0, 0, 2, 54, 0), "Use the 1080p" },
                    { new Guid("1968cf8d-dc08-f077-7526-7594241dbeeb"), "Unbranded Soft Salad", new Guid("9c2b1595-45f8-672e-e24d-46b081cda8ed"), new TimeSpan(0, 0, 2, 54, 0), "The PNG program" },
                    { new Guid("1e6ade85-ffc4-77bc-3989-cfce7dcd5cfe"), "Licensed Metal Table", new Guid("28a25f0e-dfa5-dc8a-9ec7-db94ad90e67d"), new TimeSpan(0, 0, 2, 45, 0), "We need to" },
                    { new Guid("205ecd0e-05f7-81c3-f37b-e6492732a3e2"), "Gorgeous Plastic Salad", new Guid("1e2c23c9-1e0f-d13a-4cac-27078dac190f"), new TimeSpan(0, 0, 2, 59, 0), "We need to" },
                    { new Guid("215a3c02-099a-969f-9d11-025cb470b216"), "Tasty Concrete Hat", new Guid("d922e44d-ba77-e400-0a2a-26212685a3c3"), new TimeSpan(0, 0, 3, 6, 0), "The IB protocol" },
                    { new Guid("2178d866-9e41-941e-c5ab-66b4f8e8788e"), "Gorgeous Soft Tuna", new Guid("e1863474-f4ae-c7e2-12bb-a8f909512da9"), new TimeSpan(0, 0, 2, 55, 0), "synthesizing the array" },
                    { new Guid("23631539-7a4e-f78c-731e-37254e0c34ed"), "Generic Steel Hat", new Guid("de35e4ee-1a3c-5790-7777-f1ec1069e422"), new TimeSpan(0, 0, 3, 15, 0), "We need to" },
                    { new Guid("25576f79-4301-3290-eba4-563db8cc4710"), "Intelligent Concrete Tuna", new Guid("28a25f0e-dfa5-dc8a-9ec7-db94ad90e67d"), new TimeSpan(0, 0, 3, 18, 0), "If we generate" },
                    { new Guid("26826544-8a52-ea82-da41-52ae7e80d96c"), "Unbranded Soft Ball", new Guid("7775e280-c280-eecf-54f4-31fbbf49b93b"), new TimeSpan(0, 0, 2, 37, 0), "Try to input" },
                    { new Guid("2aafea5d-2a9f-a383-d2aa-0ff2513ca0a0"), "Refined Fresh Pizza", new Guid("65ff82bb-8d09-8e6c-0f2b-c4d489d94086"), new TimeSpan(0, 0, 2, 48, 0), "The TCP array" },
                    { new Guid("2c0d2442-82c0-9220-b1c3-5bd861474e96"), "Ergonomic Plastic Car", new Guid("8717fef3-a26b-e361-ca4b-173b514b256b"), new TimeSpan(0, 0, 3, 6, 0), "Use the digital" },
                    { new Guid("2dc918b7-3581-88c3-47df-047d26dd408f"), "Handcrafted Cotton Bacon", new Guid("7fc71309-41a9-f4e3-287b-8345ecad8131"), new TimeSpan(0, 0, 3, 17, 0), "You can't navigate" },
                    { new Guid("3102b699-832c-394b-e07b-12f7bd41b644"), "Practical Fresh Chicken", new Guid("2349b3e1-f845-5b61-fa8e-fbef8c8a9b57"), new TimeSpan(0, 0, 2, 45, 0), "You can't parse" },
                    { new Guid("31f962d5-a21f-7ec0-45b4-e464ea3b827f"), "Practical Cotton Towels", new Guid("62974f26-824a-80f7-bdb5-31fe456909ca"), new TimeSpan(0, 0, 2, 48, 0), "bypassing the bandwidth" },
                    { new Guid("360234ac-f369-374f-4473-0d52ca1139e4"), "Small Wooden Fish", new Guid("552d18c2-86b9-4773-0253-becbc4f9f3a7"), new TimeSpan(0, 0, 2, 34, 0), "You can't reboot" },
                    { new Guid("36e2f588-0fc5-d1fe-caf1-b3ebd0835df8"), "Unbranded Granite Tuna", new Guid("7775e280-c280-eecf-54f4-31fbbf49b93b"), new TimeSpan(0, 0, 3, 9, 0), "The HDD hard" },
                    { new Guid("3785e647-98b3-bf37-8ff9-e270aecda919"), "Refined Metal Fish", new Guid("d9ace6d5-3d01-ab77-48e3-ab1f26334575"), new TimeSpan(0, 0, 3, 16, 0), "Use the solid" },
                    { new Guid("37f9ba80-1a08-da34-036c-6c2415a6d96d"), "Refined Rubber Table", new Guid("62974f26-824a-80f7-bdb5-31fe456909ca"), new TimeSpan(0, 0, 3, 2, 0), "hacking the firewall" },
                    { new Guid("3d92e6b0-e472-390a-a79b-2db67e329a7f"), "Fantastic Concrete Bacon", new Guid("3a4637ab-0383-947a-860b-598de7e62046"), new TimeSpan(0, 0, 2, 31, 0), "I'll input the" },
                    { new Guid("43067c1f-b942-c469-0117-e17e6c8c97ee"), "Incredible Fresh Gloves", new Guid("552d18c2-86b9-4773-0253-becbc4f9f3a7"), new TimeSpan(0, 0, 2, 52, 0), "You can't connect" },
                    { new Guid("439a8a2f-4a68-0686-e7ef-c58390ddf160"), "Unbranded Concrete Table", new Guid("a8c435d2-a3ab-8813-de0e-ac5fab782189"), new TimeSpan(0, 0, 3, 18, 0), "Use the open-source" },
                    { new Guid("45868db7-d3f0-bd28-ecda-df2e30f72b08"), "Incredible Soft Table", new Guid("d14d8488-392a-c224-376c-9545523ef9d7"), new TimeSpan(0, 0, 3, 4, 0), "I'll compress the" },
                    { new Guid("4cccd053-f933-bfbf-58f7-9c128c030193"), "Gorgeous Frozen Computer", new Guid("d14d8488-392a-c224-376c-9545523ef9d7"), new TimeSpan(0, 0, 2, 46, 0), "Try to reboot" },
                    { new Guid("4d467d69-6056-07c6-d74b-b33ea2ef7ad1"), "Sleek Concrete Salad", new Guid("a8c435d2-a3ab-8813-de0e-ac5fab782189"), new TimeSpan(0, 0, 2, 50, 0), "I'll override the" },
                    { new Guid("55279550-d1d9-318e-92e3-85010674de5c"), "Unbranded Fresh Shoes", new Guid("455357b3-ab37-7d3b-8ddd-aa4a9b035760"), new TimeSpan(0, 0, 2, 52, 0), "I'll input the" },
                    { new Guid("5667bfcd-58d4-0e54-7a65-e44ccb87ad97"), "Licensed Wooden Car", new Guid("fa333e3f-3b75-cd02-7ce7-2b77e1e700a2"), new TimeSpan(0, 0, 2, 40, 0), "programming the transmitter" },
                    { new Guid("58aee418-5e53-40ac-1e3c-97098e6f7666"), "Fantastic Concrete Chicken", new Guid("062f3c05-dd11-1323-10db-7e8ac0b8ef7e"), new TimeSpan(0, 0, 2, 47, 0), "You can't reboot" },
                    { new Guid("58d08c88-a2c6-aabc-f972-33fbb2e4f8a8"), "Handmade Cotton Soap", new Guid("fa333e3f-3b75-cd02-7ce7-2b77e1e700a2"), new TimeSpan(0, 0, 2, 56, 0), "bypassing the circuit" },
                    { new Guid("59cb66e9-01e2-b4d5-bcb9-3db00a4b0b91"), "Rustic Frozen Soap", new Guid("1c8575f0-6194-339d-ad3e-2e7c3866a80f"), new TimeSpan(0, 0, 2, 45, 0), "I'll parse the" },
                    { new Guid("59d520d7-6fd8-4181-1edf-23b10c04bc4a"), "Practical Soft Keyboard", new Guid("d922e44d-ba77-e400-0a2a-26212685a3c3"), new TimeSpan(0, 0, 3, 23, 0), "You can't navigate" },
                    { new Guid("5b1f0819-60a8-706e-53bd-6c2b41720275"), "Practical Metal Bacon", new Guid("3a4637ab-0383-947a-860b-598de7e62046"), new TimeSpan(0, 0, 2, 37, 0), "I'll quantify the" },
                    { new Guid("5fc651bf-b8e4-cb0a-7fe7-4309dd8967b2"), "Handmade Rubber Keyboard", new Guid("1e2c23c9-1e0f-d13a-4cac-27078dac190f"), new TimeSpan(0, 0, 3, 7, 0), "If we program" },
                    { new Guid("5ffeb0ea-034c-5bc9-6738-6f1602228b39"), "Generic Cotton Cheese", new Guid("7775e280-c280-eecf-54f4-31fbbf49b93b"), new TimeSpan(0, 0, 2, 30, 0), "Use the bluetooth" },
                    { new Guid("60d78300-724d-a281-766c-135cf27f1d94"), "Practical Steel Sausages", new Guid("0e51d9f0-3e16-1570-8751-8bfcad3c76b7"), new TimeSpan(0, 0, 2, 36, 0), "If we quantify" },
                    { new Guid("61d46d8d-39a3-da62-ffb4-dc554c281087"), "Refined Frozen Pants", new Guid("d82de857-522c-c556-b013-d78f474f9287"), new TimeSpan(0, 0, 3, 4, 0), "We need to" },
                    { new Guid("633326d3-c059-e0f6-c769-708c6c9d4284"), "Awesome Frozen Gloves", new Guid("65ff82bb-8d09-8e6c-0f2b-c4d489d94086"), new TimeSpan(0, 0, 2, 33, 0), "The PNG capacitor" },
                    { new Guid("66d79c37-a06d-cafb-c877-118805714079"), "Ergonomic Granite Keyboard", new Guid("455357b3-ab37-7d3b-8ddd-aa4a9b035760"), new TimeSpan(0, 0, 3, 7, 0), "We need to" },
                    { new Guid("6b584d62-4b83-fb85-4667-b365275555ce"), "Fantastic Fresh Pants", new Guid("8717fef3-a26b-e361-ca4b-173b514b256b"), new TimeSpan(0, 0, 2, 47, 0), "We need to" },
                    { new Guid("70153693-650e-7cad-87f1-4734b236bf99"), "Tasty Rubber Hat", new Guid("d9ace6d5-3d01-ab77-48e3-ab1f26334575"), new TimeSpan(0, 0, 3, 14, 0), "compressing the sensor" },
                    { new Guid("727f6ad6-57b1-3100-5127-f88b371e9382"), "Generic Metal Shirt", new Guid("f4c5bb92-c504-dc74-c969-fbb76ae50f7e"), new TimeSpan(0, 0, 2, 52, 0), "The COM hard" },
                    { new Guid("74187711-83f6-b253-5708-30bef9784716"), "Tasty Fresh Shirt", new Guid("62974f26-824a-80f7-bdb5-31fe456909ca"), new TimeSpan(0, 0, 2, 46, 0), "I'll parse the" },
                    { new Guid("772e59a5-7813-7db0-162a-b272b9aac96f"), "Refined Wooden Soap", new Guid("d922e44d-ba77-e400-0a2a-26212685a3c3"), new TimeSpan(0, 0, 2, 55, 0), "We need to" },
                    { new Guid("79b769ab-bdb4-c0e1-248d-ec8f275a537f"), "Intelligent Metal Chicken", new Guid("fa333e3f-3b75-cd02-7ce7-2b77e1e700a2"), new TimeSpan(0, 0, 3, 11, 0), "indexing the card" },
                    { new Guid("83b5fe12-2791-c5e2-e3ee-ef27e28287d1"), "Small Concrete Computer", new Guid("7fc71309-41a9-f4e3-287b-8345ecad8131"), new TimeSpan(0, 0, 3, 22, 0), "We need to" },
                    { new Guid("842175d9-99f4-6b4b-8211-6dd7073b6963"), "Ergonomic Concrete Shoes", new Guid("b471b00d-f7ee-acf9-e226-1fd24d76e93c"), new TimeSpan(0, 0, 3, 12, 0), "The THX capacitor" },
                    { new Guid("857558ab-cbfb-fdfb-a92c-d594f622d636"), "Unbranded Metal Bacon", new Guid("455357b3-ab37-7d3b-8ddd-aa4a9b035760"), new TimeSpan(0, 0, 2, 52, 0), "Use the redundant" },
                    { new Guid("8b561526-af3e-34f3-1827-3c0626254238"), "Refined Fresh Ball", new Guid("e1863474-f4ae-c7e2-12bb-a8f909512da9"), new TimeSpan(0, 0, 3, 0, 0), "We need to" },
                    { new Guid("8b9ed91a-d16c-5d93-0d1a-1067ec496f9c"), "Awesome Rubber Shoes", new Guid("65ff82bb-8d09-8e6c-0f2b-c4d489d94086"), new TimeSpan(0, 0, 2, 56, 0), "We need to" },
                    { new Guid("8ed272ee-5087-fa4c-b6fd-4dc41f9a969a"), "Ergonomic Frozen Computer", new Guid("7775e280-c280-eecf-54f4-31fbbf49b93b"), new TimeSpan(0, 0, 3, 20, 0), "We need to" },
                    { new Guid("9250a1e3-4415-371c-2be5-6979d68b9292"), "Sleek Wooden Towels", new Guid("2349b3e1-f845-5b61-fa8e-fbef8c8a9b57"), new TimeSpan(0, 0, 2, 54, 0), "You can't generate" },
                    { new Guid("93ae5074-34ca-4525-4c99-284375081331"), "Fantastic Wooden Bike", new Guid("8717fef3-a26b-e361-ca4b-173b514b256b"), new TimeSpan(0, 0, 3, 28, 0), "quantifying the firewall" },
                    { new Guid("976fc1ca-174d-9a4d-acda-a0faab811b29"), "Handmade Granite Table", new Guid("7fc71309-41a9-f4e3-287b-8345ecad8131"), new TimeSpan(0, 0, 3, 4, 0), "The IB panel" },
                    { new Guid("97c7f282-8fb0-f2a1-0b80-2fb44461b36d"), "Intelligent Metal Table", new Guid("ffd23d02-4eb5-4217-2b43-f9b46c4a45c7"), new TimeSpan(0, 0, 2, 50, 0), "I'll reboot the" },
                    { new Guid("9fdea678-4a21-6d13-4185-9484e1a21ecd"), "Small Cotton Mouse", new Guid("65ff82bb-8d09-8e6c-0f2b-c4d489d94086"), new TimeSpan(0, 0, 3, 11, 0), "Use the back-end" },
                    { new Guid("a05438ef-97cf-3dfc-a289-5d224a6bba69"), "Incredible Steel Shirt", new Guid("a8c435d2-a3ab-8813-de0e-ac5fab782189"), new TimeSpan(0, 0, 3, 16, 0), "I'll program the" },
                    { new Guid("a05a1fe3-4c84-c82c-8d46-b8613a716b08"), "Awesome Granite Car", new Guid("fa333e3f-3b75-cd02-7ce7-2b77e1e700a2"), new TimeSpan(0, 0, 3, 20, 0), "We need to" },
                    { new Guid("a0b3d38c-595f-bcbf-f14d-45b898461c1d"), "Intelligent Concrete Table", new Guid("49bb0990-7c20-0dcf-fce5-3793219f6047"), new TimeSpan(0, 0, 2, 36, 0), "If we bypass" },
                    { new Guid("a292a61f-895a-e44b-7e4b-852713c3ac49"), "Awesome Concrete Chair", new Guid("62974f26-824a-80f7-bdb5-31fe456909ca"), new TimeSpan(0, 0, 2, 45, 0), "copying the array" },
                    { new Guid("aa6a225c-8f5a-42a5-c7e5-c437955d17dd"), "Handcrafted Granite Pizza", new Guid("f4c5bb92-c504-dc74-c969-fbb76ae50f7e"), new TimeSpan(0, 0, 3, 18, 0), "We need to" },
                    { new Guid("add0dfab-4e88-8236-3c95-5c8694da1e3c"), "Incredible Wooden Soap", new Guid("8717fef3-a26b-e361-ca4b-173b514b256b"), new TimeSpan(0, 0, 3, 5, 0), "The RAM capacitor" },
                    { new Guid("af006ebd-2a52-eab5-4c53-6f1daf2585d4"), "Handmade Granite Salad", new Guid("8717fef3-a26b-e361-ca4b-173b514b256b"), new TimeSpan(0, 0, 3, 29, 0), "I'll quantify the" },
                    { new Guid("af878b8c-9b73-c10f-1991-eb9105db76d5"), "Sleek Cotton Hat", new Guid("1c8575f0-6194-339d-ad3e-2e7c3866a80f"), new TimeSpan(0, 0, 3, 12, 0), "Use the back-end" },
                    { new Guid("b4f1a83d-d7ee-ed02-3ee9-8ba871714375"), "Handcrafted Frozen Fish", new Guid("ffd23d02-4eb5-4217-2b43-f9b46c4a45c7"), new TimeSpan(0, 0, 2, 40, 0), "We need to" },
                    { new Guid("b553f91c-547d-7493-883d-0c876c0bdb5a"), "Ergonomic Soft Bacon", new Guid("62974f26-824a-80f7-bdb5-31fe456909ca"), new TimeSpan(0, 0, 3, 17, 0), "Use the auxiliary" },
                    { new Guid("b576eec2-7d41-ed08-d12b-32c6b54914de"), "Gorgeous Wooden Table", new Guid("1c8575f0-6194-339d-ad3e-2e7c3866a80f"), new TimeSpan(0, 0, 2, 34, 0), "We need to" },
                    { new Guid("b7053f45-fca3-1f8a-b8e1-efe7dd651dbb"), "Incredible Metal Soap", new Guid("65ff82bb-8d09-8e6c-0f2b-c4d489d94086"), new TimeSpan(0, 0, 3, 13, 0), "You can't hack" },
                    { new Guid("b819c9a4-89e2-9214-5982-a42f276b5b46"), "Unbranded Rubber Gloves", new Guid("49bb0990-7c20-0dcf-fce5-3793219f6047"), new TimeSpan(0, 0, 3, 22, 0), "We need to" },
                    { new Guid("b8908fe2-fab3-f1a3-126c-27286ced14df"), "Generic Metal Chair", new Guid("9c2b1595-45f8-672e-e24d-46b081cda8ed"), new TimeSpan(0, 0, 3, 30, 0), "We need to" },
                    { new Guid("b90cf885-5856-c16e-fbd9-f1d1a4b65b85"), "Handmade Fresh Shoes", new Guid("de35e4ee-1a3c-5790-7777-f1ec1069e422"), new TimeSpan(0, 0, 2, 36, 0), "If we calculate" },
                    { new Guid("bca93494-9f15-1b46-e23c-118c089386fa"), "Practical Plastic Soap", new Guid("552d18c2-86b9-4773-0253-becbc4f9f3a7"), new TimeSpan(0, 0, 2, 45, 0), "If we synthesize" },
                    { new Guid("c05fae4a-f237-c431-4532-bfb375bd9e7b"), "Sleek Cotton Keyboard", new Guid("28a25f0e-dfa5-dc8a-9ec7-db94ad90e67d"), new TimeSpan(0, 0, 3, 1, 0), "If we program" },
                    { new Guid("c5252774-cd7d-d1cc-8511-88cb0a631d0a"), "Gorgeous Frozen Towels", new Guid("d82de857-522c-c556-b013-d78f474f9287"), new TimeSpan(0, 0, 3, 16, 0), "You can't hack" },
                    { new Guid("c6114ea0-c901-66bd-f80d-f0472debcf58"), "Rustic Cotton Bacon", new Guid("89d22fe4-5532-ac42-0f6e-976e2e92da05"), new TimeSpan(0, 0, 2, 30, 0), "copying the application" },
                    { new Guid("c783f8a3-cb68-7632-e22c-84f60558d2fa"), "Rustic Frozen Fish", new Guid("28a25f0e-dfa5-dc8a-9ec7-db94ad90e67d"), new TimeSpan(0, 0, 2, 53, 0), "We need to" },
                    { new Guid("c7b75900-3d55-e78f-03fe-dbd0a46c6d89"), "Small Cotton Computer", new Guid("7fc71309-41a9-f4e3-287b-8345ecad8131"), new TimeSpan(0, 0, 3, 20, 0), "The SMTP protocol" },
                    { new Guid("c96ff837-adaa-cc8c-3fe4-e9ff36818fb9"), "Unbranded Fresh Chicken", new Guid("d9ace6d5-3d01-ab77-48e3-ab1f26334575"), new TimeSpan(0, 0, 3, 27, 0), "I'll program the" },
                    { new Guid("cccf72d4-f135-a087-c5b4-c7e3d0d06351"), "Unbranded Metal Shoes", new Guid("a8c435d2-a3ab-8813-de0e-ac5fab782189"), new TimeSpan(0, 0, 2, 58, 0), "Try to program" },
                    { new Guid("cde9ea23-f403-b625-459c-da1a5d339bb9"), "Incredible Concrete Salad", new Guid("fa333e3f-3b75-cd02-7ce7-2b77e1e700a2"), new TimeSpan(0, 0, 2, 53, 0), "If we navigate" },
                    { new Guid("cf24c7d6-4ae5-9096-11a3-dd12a42fed31"), "Sleek Plastic Keyboard", new Guid("0e51d9f0-3e16-1570-8751-8bfcad3c76b7"), new TimeSpan(0, 0, 3, 23, 0), "The EXE pixel" },
                    { new Guid("d0365dcd-94f5-a11d-e71b-c714c04ce08a"), "Unbranded Concrete Shoes", new Guid("fa333e3f-3b75-cd02-7ce7-2b77e1e700a2"), new TimeSpan(0, 0, 2, 32, 0), "The JBOD program" },
                    { new Guid("d09a6053-8990-7bc5-79d0-263d0ef46ea4"), "Rustic Granite Shoes", new Guid("f4c5bb92-c504-dc74-c969-fbb76ae50f7e"), new TimeSpan(0, 0, 2, 47, 0), "The JSON application" },
                    { new Guid("db774e40-3592-6462-f2c0-a3e46d4257db"), "Handcrafted Metal Keyboard", new Guid("7775e280-c280-eecf-54f4-31fbbf49b93b"), new TimeSpan(0, 0, 2, 44, 0), "I'll program the" },
                    { new Guid("e002407c-b2b1-d766-f7bf-31213d2f5db2"), "Ergonomic Fresh Shirt", new Guid("62974f26-824a-80f7-bdb5-31fe456909ca"), new TimeSpan(0, 0, 2, 52, 0), "Try to quantify" },
                    { new Guid("e08bacba-fa08-fa96-d90a-c517560a8d0a"), "Awesome Frozen Fish", new Guid("ffd23d02-4eb5-4217-2b43-f9b46c4a45c7"), new TimeSpan(0, 0, 3, 11, 0), "calculating the microchip" },
                    { new Guid("e9c6c8eb-021d-a90c-ca47-725a8d651ef6"), "Practical Steel Bike", new Guid("b471b00d-f7ee-acf9-e226-1fd24d76e93c"), new TimeSpan(0, 0, 3, 22, 0), "I'll calculate the" },
                    { new Guid("e9db3caf-67fe-00f0-fae4-acd07a34559d"), "Ergonomic Soft Tuna", new Guid("7fc71309-41a9-f4e3-287b-8345ecad8131"), new TimeSpan(0, 0, 3, 21, 0), "Use the back-end" },
                    { new Guid("ef82e5c7-6dce-e0d0-9efd-983c59520e8b"), "Gorgeous Frozen Ball", new Guid("b471b00d-f7ee-acf9-e226-1fd24d76e93c"), new TimeSpan(0, 0, 2, 40, 0), "If we input" },
                    { new Guid("f0ecc858-6647-7f5b-22c4-b9b1f3a4f365"), "Incredible Cotton Hat", new Guid("fa333e3f-3b75-cd02-7ce7-2b77e1e700a2"), new TimeSpan(0, 0, 2, 46, 0), "You can't compress" },
                    { new Guid("f195edac-8937-1a14-c77f-6ca7f21e90f1"), "Incredible Rubber Fish", new Guid("ffd23d02-4eb5-4217-2b43-f9b46c4a45c7"), new TimeSpan(0, 0, 2, 47, 0), "We need to" },
                    { new Guid("f8fa473a-593d-f7ad-bc11-7a52e5b9e6f4"), "Rustic Cotton Salad", new Guid("89d22fe4-5532-ac42-0f6e-976e2e92da05"), new TimeSpan(0, 0, 3, 10, 0), "We need to" },
                    { new Guid("fc25b1c2-02b3-5a3f-a36f-d8e743f37c7f"), "Handcrafted Steel Pants", new Guid("de35e4ee-1a3c-5790-7777-f1ec1069e422"), new TimeSpan(0, 0, 3, 2, 0), "indexing the card" },
                    { new Guid("fe38bd4d-e18a-e608-a488-e1485649a344"), "Handcrafted Soft Shirt", new Guid("e1863474-f4ae-c7e2-12bb-a8f909512da9"), new TimeSpan(0, 0, 2, 56, 0), "Try to copy" },
                    { new Guid("ff21b565-9e0b-ba73-6e9e-5098f1134e5b"), "Ergonomic Steel Towels", new Guid("1c8575f0-6194-339d-ad3e-2e7c3866a80f"), new TimeSpan(0, 0, 2, 43, 0), "We need to" },
                    { new Guid("ffa11ec6-7a71-cd50-2e3c-cef187578365"), "Rustic Metal Chips", new Guid("49bb0990-7c20-0dcf-fce5-3793219f6047"), new TimeSpan(0, 0, 3, 29, 0), "You can't calculate" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Playlists_AuthorId",
                table: "Playlists",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistSong_SongsId",
                table: "PlaylistSong",
                column: "SongsId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_AuthorId",
                table: "Songs",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_EmailAddress",
                table: "Users",
                column: "EmailAddress",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_ExternalId",
                table: "Users",
                column: "ExternalId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlaylistSong");

            migrationBuilder.DropTable(
                name: "Playlists");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
