using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vladify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class @try : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b327472-1f14-2c4f-f4b9-57c2e58e042b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0cf19b61-ead8-4a1f-dedf-253b1a19f953"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e59f64a-393f-8e5f-c0b9-727020618505"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("131551d9-8b51-aa9b-5f4f-60149b73ce36"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("265efd82-23e1-5055-0ec1-99e1909eee51"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("289aeedd-ea39-f13c-de85-52c7ea8161d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2bc16a08-bd79-3f4c-78f5-82f459651adf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f3191fb-7b43-e21c-1ef7-3a0bdf30ef5e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("379cf832-8f81-a957-af5e-eced582074a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e2e7eff-03ed-fb51-8b66-f9f7e90b5a76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5dc8ad76-49f7-80c2-bd08-8d65dad270bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78cc6070-4980-07c1-2d55-e70d9db375be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a55571c-5026-c92b-f08e-d2467b19eb3b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("866293ea-f419-3c74-37a3-acfa8809bb01"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86a5f586-9356-c520-56cf-a74d613d8d83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("929ce18a-987f-8050-daa7-a68a5b66bdc9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a69b52b6-c94c-8597-3caa-d96c3f343546"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a72240dd-7e82-3f97-9241-3474c8a08aaf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b4565a79-c451-e1fa-a2fe-dfc6ff8952d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5f6a58e-161c-3ad5-265d-89020ae34f9c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bea1547b-b9d1-f09e-93b5-fda972d6c8f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c21587eb-a5ce-fc9f-b788-85944d7805cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c2246c1d-89ab-1cb3-5de1-80fbc7452042"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3d55153-3986-d237-762e-2a76fc42d63d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c77b6191-dd09-bdfd-02c2-b6293ab1188b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dff46f0a-6755-3f32-8800-9bed12a121e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e2c7bad6-e520-2637-bf5f-1655295e33a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4cfc815-3aa1-7b93-2173-b65f52b832fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ecd1ff1b-e67b-6ec1-86a6-d504a97024a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0ccfb89-f1bb-d438-69d3-84d968ca1de4"));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("062f3c05-dd11-1323-10db-7e8ac0b8ef7e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e51d9f0-3e16-1570-8751-8bfcad3c76b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17f3f721-c6c8-7b79-2791-0c615bb1d678"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c8575f0-6194-339d-ad3e-2e7c3866a80f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e2c23c9-1e0f-d13a-4cac-27078dac190f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2349b3e1-f845-5b61-fa8e-fbef8c8a9b57"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("28a25f0e-dfa5-dc8a-9ec7-db94ad90e67d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a4637ab-0383-947a-860b-598de7e62046"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("455357b3-ab37-7d3b-8ddd-aa4a9b035760"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("49bb0990-7c20-0dcf-fce5-3793219f6047"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("552d18c2-86b9-4773-0253-becbc4f9f3a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62974f26-824a-80f7-bdb5-31fe456909ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("65ff82bb-8d09-8e6c-0f2b-c4d489d94086"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7775e280-c280-eecf-54f4-31fbbf49b93b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fc71309-41a9-f4e3-287b-8345ecad8131"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8717fef3-a26b-e361-ca4b-173b514b256b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("89d22fe4-5532-ac42-0f6e-976e2e92da05"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c2b1595-45f8-672e-e24d-46b081cda8ed"));

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
                keyValue: new Guid("d14d8488-392a-c224-376c-9545523ef9d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d82de857-522c-c556-b013-d78f474f9287"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d922e44d-ba77-e400-0a2a-26212685a3c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d9ace6d5-3d01-ab77-48e3-ab1f26334575"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de35e4ee-1a3c-5790-7777-f1ec1069e422"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e1863474-f4ae-c7e2-12bb-a8f909512da9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb5aa860-01f1-f11d-eb28-7b3747c1dca7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f4c5bb92-c504-dc74-c969-fbb76ae50f7e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa333e3f-3b75-cd02-7ce7-2b77e1e700a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ffd23d02-4eb5-4217-2b43-f9b46c4a45c7"));

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
        }
    }
}
