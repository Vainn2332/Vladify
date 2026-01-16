using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vladify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("1ca49918-2b9e-fe16-85ff-7c48894d1451"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("1d786e6f-f1e6-ccc9-eb61-d26b1a45e522"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("25ec0345-7053-50d5-8184-8d5c94f251b9"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("3d30f12d-4410-7952-04d4-f6fd23d00df3"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("53183397-b122-f99e-3195-5bd6f36b1ed0"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("5c0f32e3-aa59-d0e1-bca3-db713113c293"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("5cd23a14-c010-8809-f1e7-9a8a402777e5"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("5d88763c-61e4-fa35-daa6-30337d04cc92"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("72ef00d3-2796-fcdc-d2ad-b18deebda90c"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("acfa05a6-5058-5a6c-4769-5c554c5ff0b9"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("b68e4d25-1924-ece1-eced-32efbb1c9d83"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("cabb49f3-63f2-817c-941a-c66d1555e7e2"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("d8252fe2-6b6e-37b2-cc50-7c8554572cda"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e0d9a348-f8b6-75b0-65d5-0b59e7a2a849"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("f87d3529-2cbb-22b8-ffbe-d205fdc40d2b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00d3717d-72ef-2796-dcfc-d2adb18deebd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18cf9304-f12d-3d30-1044-527904d4f6fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d786e6f-f1e6-ccc9-eb61-d26b1a45e522"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a93c213-d60d-9b99-3d09-dadf61eeb518"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2efd0eb9-ebb3-97a8-3318-5322b19ef931"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3aa0b5ec-1c16-49f3-bbca-f2637c81941a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("705325ec-50d5-8481-8d5c-94f251b99052"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("89487cff-144d-7851-6258-a61f8754a12f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b989d454-1be2-af7e-0513-73e3320f5c59"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ff22b82c-d2be-fd05-c40d-2b918d104e28"));

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Album", "Author", "Duration", "Title" },
                values: new object[,]
                {
                    { new Guid("0327ef30-ab9f-da53-e334-bb82ff65098d"), "Licensed Steel Towels", "Kaylie Haley", new TimeSpan(0, 0, 2, 42, 0), "parsing the transmitter" },
                    { new Guid("1423cf1d-35b8-3081-5146-a23609cd05cc"), "Licensed Frozen Chair", "Emily Auer", new TimeSpan(0, 0, 3, 30, 0), "Use the optical" },
                    { new Guid("18c24e65-552d-86b9-7347-0253becbc4f9"), "Gorgeous Rubber Bacon", "Don Corkery", new TimeSpan(0, 0, 3, 1, 0), "The IB sensor" },
                    { new Guid("1ddd639a-4b30-7ad8-b182-3a58c5d0ec5e"), "Ergonomic Cotton Gloves", "Nelle Kris", new TimeSpan(0, 0, 2, 30, 0), "The GB interface" },
                    { new Guid("3a4637ab-0383-947a-860b-598de7e62046"), "Awesome Frozen Cheese", "Reese Schmidt", new TimeSpan(0, 0, 3, 16, 0), "Try to override" },
                    { new Guid("610d3f5f-ebd4-7a58-e271-e0d591ec3d36"), "Small Soft Ball", "Bridget Flatley", new TimeSpan(0, 0, 2, 37, 0), "The SCSI circuit" },
                    { new Guid("73c05d21-ac80-3ea7-c973-9b67ad7e5660"), "Practical Fresh Ball", "Rupert O'Conner", new TimeSpan(0, 0, 3, 27, 0), "backing up the" },
                    { new Guid("769f8bc3-32ef-d43a-475b-ecf947f58c3e"), "Tasty Granite Keyboard", "Tressa Borer", new TimeSpan(0, 0, 2, 57, 0), "Use the open-source" },
                    { new Guid("7757901a-f177-10ec-69e4-2272f2494771"), "Unbranded Metal Table", "Clara Carroll", new TimeSpan(0, 0, 3, 16, 0), "Use the multi-byte" },
                    { new Guid("7afe147d-6bc5-00a8-baa5-88cd564de422"), "Intelligent Rubber Bike", "Julian Ziemann", new TimeSpan(0, 0, 2, 56, 0), "Try to parse" },
                    { new Guid("9e58d7ea-05e5-2f3c-0611-dd231310db7e"), "Small Rubber Gloves", "Jennyfer Corkery", new TimeSpan(0, 0, 3, 28, 0), "You can't copy" },
                    { new Guid("a26b8717-e361-4bca-173b-514b256b7b3c"), "Licensed Frozen Bike", "Wayne Legros", new TimeSpan(0, 0, 3, 13, 0), "Use the haptic" },
                    { new Guid("a2faba64-c7d2-6fea-024e-1342b85c3854"), "Small Rubber Chicken", "Ronny Krajcik", new TimeSpan(0, 0, 3, 15, 0), "hacking the system" },
                    { new Guid("ac8d0727-0f19-d7ec-2df0-773a1300593a"), "Gorgeous Plastic Chicken", "Wilmer Shanahan", new TimeSpan(0, 0, 2, 58, 0), "I'll compress the" },
                    { new Guid("fc8b5187-3cad-b776-e845-d5b265f0f546"), "Fantastic Concrete Chips", "Enrique Zemlak", new TimeSpan(0, 0, 2, 53, 0), "The RSS driver" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "EmailAddress", "Gender", "Name", "PasswordHash" },
                values: new object[,]
                {
                    { new Guid("1c8575f0-6194-339d-ad3e-2e7c3866a80f"), 75, "Leonard.Hansen@hotmail.com", "Female", "Arlene", "$2a$11$DvROBdylWGmrlJGDJUF/7.0.yl.qgxDvExr.uxUoozh6GcgBTWzoK" },
                    { new Guid("26ee05f4-43fb-85e9-4dc6-833c087e1147"), 19, "Kiera26@hotmail.com", "Female", "Dorcas", "$2a$11$DvROBdylWGmrlJGDJUF/7.0.yl.qgxDvExr.uxUoozh6GcgBTWzoK" },
                    { new Guid("2713c1fd-704a-31a2-9209-abafe71bf869"), 94, "Larue46@hotmail.com", "Male", "Marley", "$2a$11$DvROBdylWGmrlJGDJUF/7.0.yl.qgxDvExr.uxUoozh6GcgBTWzoK" },
                    { new Guid("2cbb1d4f-9767-2580-3984-618cd8c03c11"), 44, "Darron70@yahoo.com", "Female", "Greyson", "$2a$11$DvROBdylWGmrlJGDJUF/7.0.yl.qgxDvExr.uxUoozh6GcgBTWzoK" },
                    { new Guid("49bb0990-7c20-0dcf-fce5-3793219f6047"), 41, "Megane.Barrows41@yahoo.com", "Male", "Rocio", "$2a$11$DvROBdylWGmrlJGDJUF/7.0.yl.qgxDvExr.uxUoozh6GcgBTWzoK" },
                    { new Guid("4d9841a6-c134-699d-e7b5-1a99feed439a"), 41, "Kacie.Renner92@hotmail.com", "Female", "Louie", "$2a$11$DvROBdylWGmrlJGDJUF/7.0.yl.qgxDvExr.uxUoozh6GcgBTWzoK" },
                    { new Guid("9c03f8cc-6c24-8c38-cb73-e6bc0fef1012"), 99, "Jeanette.Bartoletti@hotmail.com", "Female", "Joanie", "$2a$11$DvROBdylWGmrlJGDJUF/7.0.yl.qgxDvExr.uxUoozh6GcgBTWzoK" },
                    { new Guid("a8c435d2-a3ab-8813-de0e-ac5fab782189"), 49, "Jayne17@gmail.com", "Male", "Nicolas", "$2a$11$DvROBdylWGmrlJGDJUF/7.0.yl.qgxDvExr.uxUoozh6GcgBTWzoK" },
                    { new Guid("b471b00d-f7ee-acf9-e226-1fd24d76e93c"), 50, "Jocelyn.Keebler@gmail.com", "Female", "Sim", "$2a$11$DvROBdylWGmrlJGDJUF/7.0.yl.qgxDvExr.uxUoozh6GcgBTWzoK" },
                    { new Guid("fa333e3f-3b75-cd02-7ce7-2b77e1e700a2"), 62, "Rashawn25@yahoo.com", "Female", "Reuben", "$2a$11$DvROBdylWGmrlJGDJUF/7.0.yl.qgxDvExr.uxUoozh6GcgBTWzoK" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("0327ef30-ab9f-da53-e334-bb82ff65098d"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("1423cf1d-35b8-3081-5146-a23609cd05cc"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("18c24e65-552d-86b9-7347-0253becbc4f9"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("1ddd639a-4b30-7ad8-b182-3a58c5d0ec5e"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("3a4637ab-0383-947a-860b-598de7e62046"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("610d3f5f-ebd4-7a58-e271-e0d591ec3d36"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("73c05d21-ac80-3ea7-c973-9b67ad7e5660"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("769f8bc3-32ef-d43a-475b-ecf947f58c3e"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("7757901a-f177-10ec-69e4-2272f2494771"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("7afe147d-6bc5-00a8-baa5-88cd564de422"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("9e58d7ea-05e5-2f3c-0611-dd231310db7e"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("a26b8717-e361-4bca-173b-514b256b7b3c"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("a2faba64-c7d2-6fea-024e-1342b85c3854"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("ac8d0727-0f19-d7ec-2df0-773a1300593a"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("fc8b5187-3cad-b776-e845-d5b265f0f546"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c8575f0-6194-339d-ad3e-2e7c3866a80f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26ee05f4-43fb-85e9-4dc6-833c087e1147"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2713c1fd-704a-31a2-9209-abafe71bf869"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2cbb1d4f-9767-2580-3984-618cd8c03c11"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("49bb0990-7c20-0dcf-fce5-3793219f6047"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4d9841a6-c134-699d-e7b5-1a99feed439a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c03f8cc-6c24-8c38-cb73-e6bc0fef1012"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a8c435d2-a3ab-8813-de0e-ac5fab782189"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b471b00d-f7ee-acf9-e226-1fd24d76e93c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa333e3f-3b75-cd02-7ce7-2b77e1e700a2"));

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Album", "Author", "Duration", "Title" },
                values: new object[,]
                {
                    { new Guid("1ca49918-2b9e-fe16-85ff-7c48894d1451"), "Incredible Wooden Bacon", "Kimberly Price", new TimeSpan(0, 0, 2, 31, 0), "backingupthe" },
                    { new Guid("1d786e6f-f1e6-ccc9-eb61-d26b1a45e522"), "Gorgeous Wooden Hat", "Allison Berge", new TimeSpan(0, 0, 2, 32, 0), "Youcan'tprogram" },
                    { new Guid("25ec0345-7053-50d5-8184-8d5c94f251b9"), "Ergonomic Metal Shoes", "Doris Bartoletti", new TimeSpan(0, 0, 2, 50, 0), "Weneedto" },
                    { new Guid("3d30f12d-4410-7952-04d4-f6fd23d00df3"), "Ergonomic Soft Bike", "Janick Abshire", new TimeSpan(0, 0, 2, 57, 0), "TheXSScapacitor" },
                    { new Guid("53183397-b122-f99e-3195-5bd6f36b1ed0"), "Fantastic Rubber Chair", "Rodolfo Buckridge", new TimeSpan(0, 0, 2, 53, 0), "TheSSLmonitor" },
                    { new Guid("5c0f32e3-aa59-d0e1-bca3-db713113c293"), "Rustic Steel Gloves", "Adan Robel", new TimeSpan(0, 0, 2, 58, 0), "Weneedto" },
                    { new Guid("5cd23a14-c010-8809-f1e7-9a8a402777e5"), "Licensed Plastic Towels", "Adaline Braun", new TimeSpan(0, 0, 2, 44, 0), "I'llconnectthe" },
                    { new Guid("5d88763c-61e4-fa35-daa6-30337d04cc92"), "Awesome Cotton Keyboard", "Isac McKenzie", new TimeSpan(0, 0, 2, 34, 0), "Trytoback" },
                    { new Guid("72ef00d3-2796-fcdc-d2ad-b18deebda90c"), "Intelligent Rubber Bike", "Dana Strosin", new TimeSpan(0, 0, 2, 50, 0), "TheCSSmatrix" },
                    { new Guid("acfa05a6-5058-5a6c-4769-5c554c5ff0b9"), "Incredible Soft Fish", "Eric Hyatt", new TimeSpan(0, 0, 2, 37, 0), "Trytosynthesize" },
                    { new Guid("b68e4d25-1924-ece1-eced-32efbb1c9d83"), "Small Fresh Ball", "Nikolas Upton", new TimeSpan(0, 0, 2, 45, 0), "Weneedto" },
                    { new Guid("cabb49f3-63f2-817c-941a-c66d1555e7e2"), "Tasty Plastic Bacon", "Casimir Hilpert", new TimeSpan(0, 0, 2, 54, 0), "transmittingtheprogram" },
                    { new Guid("d8252fe2-6b6e-37b2-cc50-7c8554572cda"), "Small Steel Keyboard", "Juanita MacGyver", new TimeSpan(0, 0, 3, 18, 0), "Usetheprimary" },
                    { new Guid("e0d9a348-f8b6-75b0-65d5-0b59e7a2a849"), "Sleek Wooden Chicken", "Fanny Wolf", new TimeSpan(0, 0, 2, 32, 0), "Youcan'tconnect" },
                    { new Guid("f87d3529-2cbb-22b8-ffbe-d205fdc40d2b"), "Gorgeous Cotton Shirt", "Marjolaine Runolfsdottir", new TimeSpan(0, 0, 3, 16, 0), "Ifweparse" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "EmailAddress", "Gender", "Name", "PasswordHash" },
                values: new object[,]
                {
                    { new Guid("00d3717d-72ef-2796-dcfc-d2adb18deebd"), 98, "Neal_Daugherty@gmail.com", "Male", "Ansley", "$2a$11$KLoMdmI6tAx9SZBiVBT1xODM8F8CbWfPZQ25NDJySe/fRwcPKvweq" },
                    { new Guid("18cf9304-f12d-3d30-1044-527904d4f6fd"), 34, "Cara_Schuppe0@gmail.com", "Female", "Bonnie", "$2a$11$KLoMdmI6tAx9SZBiVBT1xODM8F8CbWfPZQ25NDJySe/fRwcPKvweq" },
                    { new Guid("1d786e6f-f1e6-ccc9-eb61-d26b1a45e522"), 38, "Abe86@yahoo.com", "Male", "Jaida", "$2a$11$KLoMdmI6tAx9SZBiVBT1xODM8F8CbWfPZQ25NDJySe/fRwcPKvweq" },
                    { new Guid("2a93c213-d60d-9b99-3d09-dadf61eeb518"), 65, "Jay.Price@gmail.com", "Female", "Verona", "$2a$11$KLoMdmI6tAx9SZBiVBT1xODM8F8CbWfPZQ25NDJySe/fRwcPKvweq" },
                    { new Guid("2efd0eb9-ebb3-97a8-3318-5322b19ef931"), 73, "Barney.Ebert@hotmail.com", "Female", "Alexandrea", "$2a$11$KLoMdmI6tAx9SZBiVBT1xODM8F8CbWfPZQ25NDJySe/fRwcPKvweq" },
                    { new Guid("3aa0b5ec-1c16-49f3-bbca-f2637c81941a"), 85, "Itzel_Walter@yahoo.com", "Female", "Clyde", "$2a$11$KLoMdmI6tAx9SZBiVBT1xODM8F8CbWfPZQ25NDJySe/fRwcPKvweq" },
                    { new Guid("705325ec-50d5-8481-8d5c-94f251b99052"), 54, "Sigrid71@yahoo.com", "Male", "Jacinthe", "$2a$11$KLoMdmI6tAx9SZBiVBT1xODM8F8CbWfPZQ25NDJySe/fRwcPKvweq" },
                    { new Guid("89487cff-144d-7851-6258-a61f8754a12f"), 32, "Albert22@hotmail.com", "Female", "Kimberly", "$2a$11$KLoMdmI6tAx9SZBiVBT1xODM8F8CbWfPZQ25NDJySe/fRwcPKvweq" },
                    { new Guid("b989d454-1be2-af7e-0513-73e3320f5c59"), 41, "Newell.Gerlach@hotmail.com", "Male", "Eleonore", "$2a$11$KLoMdmI6tAx9SZBiVBT1xODM8F8CbWfPZQ25NDJySe/fRwcPKvweq" },
                    { new Guid("ff22b82c-d2be-fd05-c40d-2b918d104e28"), 68, "Isom_Hyatt76@gmail.com", "Male", "Vladimir", "$2a$11$KLoMdmI6tAx9SZBiVBT1xODM8F8CbWfPZQ25NDJySe/fRwcPKvweq" }
                });
        }
    }
}
