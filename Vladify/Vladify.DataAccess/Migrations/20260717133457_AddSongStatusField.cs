using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vladify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddSongStatusField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("00ae81eb-9076-dafb-393e-4c5ec694f57a"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("04f5621f-6374-2a1e-e25b-22572c5d0ff3"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("06ed55e8-0796-319e-0f27-382a71603116"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("07e0a687-69f6-7b9c-c574-a6d861437073"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("0fe166fe-c78d-6117-e11b-5f5571ec9fe1"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("11d7a753-0e7a-2903-21ee-510b472301b6"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("150ab234-1c51-085d-6b51-3e1e031a7c77"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("1968cf8d-dc08-f077-7526-7594241dbeeb"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("1e6ade85-ffc4-77bc-3989-cfce7dcd5cfe"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("205ecd0e-05f7-81c3-f37b-e6492732a3e2"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("215a3c02-099a-969f-9d11-025cb470b216"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("2178d866-9e41-941e-c5ab-66b4f8e8788e"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("23631539-7a4e-f78c-731e-37254e0c34ed"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("25576f79-4301-3290-eba4-563db8cc4710"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("26826544-8a52-ea82-da41-52ae7e80d96c"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("2aafea5d-2a9f-a383-d2aa-0ff2513ca0a0"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("2dc918b7-3581-88c3-47df-047d26dd408f"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("3102b699-832c-394b-e07b-12f7bd41b644"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("31f962d5-a21f-7ec0-45b4-e464ea3b827f"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("360234ac-f369-374f-4473-0d52ca1139e4"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("36e2f588-0fc5-d1fe-caf1-b3ebd0835df8"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("3785e647-98b3-bf37-8ff9-e270aecda919"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("37f9ba80-1a08-da34-036c-6c2415a6d96d"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("3d92e6b0-e472-390a-a79b-2db67e329a7f"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("43067c1f-b942-c469-0117-e17e6c8c97ee"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("439a8a2f-4a68-0686-e7ef-c58390ddf160"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("45868db7-d3f0-bd28-ecda-df2e30f72b08"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("4cccd053-f933-bfbf-58f7-9c128c030193"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("4d467d69-6056-07c6-d74b-b33ea2ef7ad1"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("55279550-d1d9-318e-92e3-85010674de5c"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("5667bfcd-58d4-0e54-7a65-e44ccb87ad97"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("58aee418-5e53-40ac-1e3c-97098e6f7666"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("58d08c88-a2c6-aabc-f972-33fbb2e4f8a8"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("59cb66e9-01e2-b4d5-bcb9-3db00a4b0b91"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("59d520d7-6fd8-4181-1edf-23b10c04bc4a"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("5b1f0819-60a8-706e-53bd-6c2b41720275"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("5fc651bf-b8e4-cb0a-7fe7-4309dd8967b2"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("5ffeb0ea-034c-5bc9-6738-6f1602228b39"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("60d78300-724d-a281-766c-135cf27f1d94"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("61d46d8d-39a3-da62-ffb4-dc554c281087"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("633326d3-c059-e0f6-c769-708c6c9d4284"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("66d79c37-a06d-cafb-c877-118805714079"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("6b584d62-4b83-fb85-4667-b365275555ce"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("70153693-650e-7cad-87f1-4734b236bf99"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("727f6ad6-57b1-3100-5127-f88b371e9382"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("74187711-83f6-b253-5708-30bef9784716"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("772e59a5-7813-7db0-162a-b272b9aac96f"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("79b769ab-bdb4-c0e1-248d-ec8f275a537f"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("83b5fe12-2791-c5e2-e3ee-ef27e28287d1"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("842175d9-99f4-6b4b-8211-6dd7073b6963"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("857558ab-cbfb-fdfb-a92c-d594f622d636"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("8b561526-af3e-34f3-1827-3c0626254238"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("8b9ed91a-d16c-5d93-0d1a-1067ec496f9c"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("8ed272ee-5087-fa4c-b6fd-4dc41f9a969a"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("9250a1e3-4415-371c-2be5-6979d68b9292"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("93ae5074-34ca-4525-4c99-284375081331"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("976fc1ca-174d-9a4d-acda-a0faab811b29"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("97c7f282-8fb0-f2a1-0b80-2fb44461b36d"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("a05438ef-97cf-3dfc-a289-5d224a6bba69"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("a05a1fe3-4c84-c82c-8d46-b8613a716b08"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("a0b3d38c-595f-bcbf-f14d-45b898461c1d"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("a292a61f-895a-e44b-7e4b-852713c3ac49"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("aa6a225c-8f5a-42a5-c7e5-c437955d17dd"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("add0dfab-4e88-8236-3c95-5c8694da1e3c"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("af006ebd-2a52-eab5-4c53-6f1daf2585d4"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("af878b8c-9b73-c10f-1991-eb9105db76d5"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("b4f1a83d-d7ee-ed02-3ee9-8ba871714375"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("b553f91c-547d-7493-883d-0c876c0bdb5a"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("b576eec2-7d41-ed08-d12b-32c6b54914de"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("b7053f45-fca3-1f8a-b8e1-efe7dd651dbb"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("b819c9a4-89e2-9214-5982-a42f276b5b46"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("b8908fe2-fab3-f1a3-126c-27286ced14df"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("b90cf885-5856-c16e-fbd9-f1d1a4b65b85"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("c05fae4a-f237-c431-4532-bfb375bd9e7b"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("c5252774-cd7d-d1cc-8511-88cb0a631d0a"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("c6114ea0-c901-66bd-f80d-f0472debcf58"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("c783f8a3-cb68-7632-e22c-84f60558d2fa"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("c7b75900-3d55-e78f-03fe-dbd0a46c6d89"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("c96ff837-adaa-cc8c-3fe4-e9ff36818fb9"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("cccf72d4-f135-a087-c5b4-c7e3d0d06351"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("cde9ea23-f403-b625-459c-da1a5d339bb9"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("cf24c7d6-4ae5-9096-11a3-dd12a42fed31"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("d0365dcd-94f5-a11d-e71b-c714c04ce08a"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("d09a6053-8990-7bc5-79d0-263d0ef46ea4"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e002407c-b2b1-d766-f7bf-31213d2f5db2"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e08bacba-fa08-fa96-d90a-c517560a8d0a"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e9c6c8eb-021d-a90c-ca47-725a8d651ef6"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e9db3caf-67fe-00f0-fae4-acd07a34559d"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("ef82e5c7-6dce-e0d0-9efd-983c59520e8b"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("f0ecc858-6647-7f5b-22c4-b9b1f3a4f365"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("f195edac-8937-1a14-c77f-6ca7f21e90f1"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("f8fa473a-593d-f7ad-bc11-7a52e5b9e6f4"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("fc25b1c2-02b3-5a3f-a36f-d8e743f37c7f"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("fe38bd4d-e18a-e608-a488-e1485649a344"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("ff21b565-9e0b-ba73-6e9e-5098f1134e5b"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("ffa11ec6-7a71-cd50-2e3c-cef187578365"));

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("2c0d2442-82c0-9220-b1c3-5bd861474e96"),
                column: "Status",
                value: "Approved");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("9fdea678-4a21-6d13-4185-9484e1a21ecd"),
                column: "Status",
                value: "Rejected");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("bca93494-9f15-1b46-e23c-118c089386fa"),
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("db774e40-3592-6462-f2c0-a3e46d4257db"),
                column: "Status",
                value: "Rejected");

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Album", "AuthorId", "Duration", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("02b06f85-9869-6388-0d34-b3d720d559d8"), "Sleek Frozen Tuna", new Guid("d14d8488-392a-c224-376c-9545523ef9d7"), new TimeSpan(0, 0, 2, 43, 0), "Approved", "Try to parse" },
                    { new Guid("0507e220-ad19-a61f-92a2-5a894be47e4b"), "Refined Concrete Soap", new Guid("1e2c23c9-1e0f-d13a-4cac-27078dac190f"), new TimeSpan(0, 0, 2, 50, 0), "Approved", "Use the cross-platform" },
                    { new Guid("073c86f1-6eb0-eb49-eaca-0cd4c23ed24b"), "Unbranded Concrete Soap", new Guid("eb5aa860-01f1-f11d-eb28-7b3747c1dca7"), new TimeSpan(0, 0, 3, 16, 0), "Pending", "Try to input" },
                    { new Guid("0bf2a18f-2f80-44b4-61b3-6d437da163dc"), "Gorgeous Steel Shoes", new Guid("28a25f0e-dfa5-dc8a-9ec7-db94ad90e67d"), new TimeSpan(0, 0, 2, 42, 0), "Approved", "I'll navigate the" },
                    { new Guid("0d5d93d1-101a-ec67-496f-9c2b0bd9efad"), "Handcrafted Steel Chips", new Guid("89d22fe4-5532-ac42-0f6e-976e2e92da05"), new TimeSpan(0, 0, 2, 37, 0), "Rejected", "If we index" },
                    { new Guid("10284c55-8087-37d4-244f-ce057d8d4be4"), "Small Steel Keyboard", new Guid("552d18c2-86b9-4773-0253-becbc4f9f3a7"), new TimeSpan(0, 0, 3, 4, 0), "Rejected", "I'll quantify the" },
                    { new Guid("116011ab-1877-f674-8353-b2570830bef9"), "Rustic Soft Sausages", new Guid("89d22fe4-5532-ac42-0f6e-976e2e92da05"), new TimeSpan(0, 0, 3, 23, 0), "Approved", "We need to" },
                    { new Guid("1177c8ca-0588-4071-7959-d630241c53ee"), "Generic Rubber Keyboard", new Guid("17f3f721-c6c8-7b79-2791-0c615bb1d678"), new TimeSpan(0, 0, 2, 59, 0), "Rejected", "You can't copy" },
                    { new Guid("137af266-a83d-b4f1-eed7-02ed3ee98ba8"), "Rustic Cotton Chair", new Guid("17f3f721-c6c8-7b79-2791-0c615bb1d678"), new TimeSpan(0, 0, 3, 9, 0), "Rejected", "If we navigate" },
                    { new Guid("13f19850-5b4e-dc97-819d-3cabbceaf6f1"), "Fantastic Soft Chicken", new Guid("d9ace6d5-3d01-ab77-48e3-ab1f26334575"), new TimeSpan(0, 0, 3, 2, 0), "Approved", "We need to" },
                    { new Guid("15c759a2-cb6d-abf1-69b7-79b4bde1c024"), "Practical Soft Pants", new Guid("eb5aa860-01f1-f11d-eb28-7b3747c1dca7"), new TimeSpan(0, 0, 2, 58, 0), "Pending", "I'll quantify the" },
                    { new Guid("1705167d-8a5b-49a8-a548-23eae9cd03f4"), "Refined Fresh Hat", new Guid("a8c435d2-a3ab-8813-de0e-ac5fab782189"), new TimeSpan(0, 0, 2, 30, 0), "Pending", "The SMTP microchip" },
                    { new Guid("17c50ad9-0a56-0a8d-828f-09374f617d13"), "Gorgeous Metal Computer", new Guid("fa333e3f-3b75-cd02-7ce7-2b77e1e700a2"), new TimeSpan(0, 0, 3, 4, 0), "Approved", "The EXE microchip" },
                    { new Guid("1b81abfa-6b29-94f3-eb1d-5bc0c0442262"), "Handmade Frozen Salad", new Guid("d82de857-522c-c556-b013-d78f474f9287"), new TimeSpan(0, 0, 3, 23, 0), "Approved", "I'll index the" },
                    { new Guid("1f04d275-f058-ee0a-7241-4b9e6201aa26"), "Generic Wooden Mouse", new Guid("de35e4ee-1a3c-5790-7777-f1ec1069e422"), new TimeSpan(0, 0, 3, 29, 0), "Rejected", "You can't quantify" },
                    { new Guid("1f192cb4-af67-db3c-e9fe-67f000fae4ac"), "Tasty Wooden Computer", new Guid("49bb0990-7c20-0dcf-fce5-3793219f6047"), new TimeSpan(0, 0, 3, 10, 0), "Pending", "copying the transmitter" },
                    { new Guid("225be22a-2c57-0f5d-f30e-57707a44e208"), "Licensed Soft Towels", new Guid("d9ace6d5-3d01-ab77-48e3-ab1f26334575"), new TimeSpan(0, 0, 2, 51, 0), "Approved", "You can't calculate" },
                    { new Guid("2a38270f-6071-1631-7684-0215182b1dee"), "Practical Cotton Salad", new Guid("62974f26-824a-80f7-bdb5-31fe456909ca"), new TimeSpan(0, 0, 2, 32, 0), "Rejected", "I'll calculate the" },
                    { new Guid("2ce27632-f684-5805-d2fa-a1923dc0a2f7"), "Tasty Metal Pizza", new Guid("1c8575f0-6194-339d-ad3e-2e7c3866a80f"), new TimeSpan(0, 0, 3, 11, 0), "Approved", "We need to" },
                    { new Guid("302edfda-2bf7-b508-807b-98714ab924a1"), "Gorgeous Granite Computer", new Guid("7775e280-c280-eecf-54f4-31fbbf49b93b"), new TimeSpan(0, 0, 3, 1, 0), "Approved", "I'll index the" },
                    { new Guid("310057b1-2751-8bf8-371e-93824e09e24e"), "Fantastic Fresh Computer", new Guid("d922e44d-ba77-e400-0a2a-26212685a3c3"), new TimeSpan(0, 0, 2, 53, 0), "Approved", "Use the bluetooth" },
                    { new Guid("3326d392-5963-f6c0-e0c7-69708c6c9d42"), "Gorgeous Rubber Chips", new Guid("8717fef3-a26b-e361-ca4b-173b514b256b"), new TimeSpan(0, 0, 2, 53, 0), "Pending", "Use the neural" },
                    { new Guid("338674b9-8e29-2216-15f0-3a2b4aae5fc0"), "Unbranded Concrete Car", new Guid("28a25f0e-dfa5-dc8a-9ec7-db94ad90e67d"), new TimeSpan(0, 0, 2, 44, 0), "Approved", "The EXE card" },
                    { new Guid("349c6b37-0ab2-5115-1c5d-086b513e1e03"), "Handmade Metal Chair", new Guid("062f3c05-dd11-1323-10db-7e8ac0b8ef7e"), new TimeSpan(0, 0, 3, 28, 0), "Approved", "We need to" },
                    { new Guid("364e88ad-3c82-5c95-8694-da1e3c79b1f7"), "Incredible Rubber Pants", new Guid("b471b00d-f7ee-acf9-e226-1fd24d76e93c"), new TimeSpan(0, 0, 2, 42, 0), "Approved", "I'll quantify the" },
                    { new Guid("38675bc9-166f-2202-8b39-00aad9bbe25e"), "Refined Concrete Chicken", new Guid("fa333e3f-3b75-cd02-7ce7-2b77e1e700a2"), new TimeSpan(0, 0, 2, 49, 0), "Pending", "The ADP driver" },
                    { new Guid("390ae472-9ba7-b62d-7e32-9a7f25b5e216"), "Small Cotton Soap", new Guid("2349b3e1-f845-5b61-fa8e-fbef8c8a9b57"), new TimeSpan(0, 0, 2, 34, 0), "Pending", "The USB transmitter" },
                    { new Guid("3b789d14-406a-7988-026b-cf388b92603d"), "Ergonomic Wooden Towels", new Guid("eb5aa860-01f1-f11d-eb28-7b3747c1dca7"), new TimeSpan(0, 0, 3, 7, 0), "Pending", "Try to input" },
                    { new Guid("3b79ffed-df03-0146-9edd-a04e11c601c9"), "Sleek Metal Ball", new Guid("b471b00d-f7ee-acf9-e226-1fd24d76e93c"), new TimeSpan(0, 0, 3, 23, 0), "Pending", "We need to" },
                    { new Guid("407c2590-e002-b2b1-66d7-f7bf31213d2f"), "Small Rubber Computer", new Guid("d9ace6d5-3d01-ab77-48e3-ab1f26334575"), new TimeSpan(0, 0, 2, 55, 0), "Approved", "You can't calculate" },
                    { new Guid("44159250-371c-e52b-6979-d68b9292dc0a"), "Awesome Soft Shirt", new Guid("9c2b1595-45f8-672e-e24d-46b081cda8ed"), new TimeSpan(0, 0, 2, 55, 0), "Rejected", "connecting the sensor" },
                    { new Guid("46dcdd9f-4997-c371-3ad5-62f9311fa2c0"), "Gorgeous Soft Soap", new Guid("2349b3e1-f845-5b61-fa8e-fbef8c8a9b57"), new TimeSpan(0, 0, 2, 49, 0), "Pending", "We need to" },
                    { new Guid("46ea0196-d84b-e5c7-82ef-ce6dd0e09efd"), "Ergonomic Cotton Keyboard", new Guid("62974f26-824a-80f7-bdb5-31fe456909ca"), new TimeSpan(0, 0, 3, 24, 0), "Rejected", "transmitting the monitor" },
                    { new Guid("470b51ee-0123-a7b6-d38e-0cd6923740c3"), "Awesome Steel Bike", new Guid("455357b3-ab37-7d3b-8ddd-aa4a9b035760"), new TimeSpan(0, 0, 3, 17, 0), "Pending", "If we parse" },
                    { new Guid("495648e1-44a3-973b-55d2-1ded22676e00"), "Awesome Plastic Tuna", new Guid("7fc71309-41a9-f4e3-287b-8345ecad8131"), new TimeSpan(0, 0, 3, 14, 0), "Approved", "You can't parse" },
                    { new Guid("4d60d783-8172-76a2-6c13-5cf27f1d9411"), "Small Frozen Bike", new Guid("b471b00d-f7ee-acf9-e226-1fd24d76e93c"), new TimeSpan(0, 0, 3, 9, 0), "Pending", "We need to" },
                    { new Guid("51223a40-c8eb-e9c6-1d02-0ca9ca47725a"), "Generic Concrete Tuna", new Guid("e1863474-f4ae-c7e2-12bb-a8f909512da9"), new TimeSpan(0, 0, 2, 56, 0), "Pending", "You can't override" },
                    { new Guid("5241daea-7eae-d980-6c8d-3fff7a859c8d"), "Fantastic Wooden Computer", new Guid("62974f26-824a-80f7-bdb5-31fe456909ca"), new TimeSpan(0, 0, 3, 20, 0), "Pending", "bypassing the alarm" },
                    { new Guid("56098df8-fb53-be2b-1141-30f15deaaf2a"), "Handcrafted Soft Tuna", new Guid("17f3f721-c6c8-7b79-2791-0c615bb1d678"), new TimeSpan(0, 0, 2, 51, 0), "Pending", "If we program" },
                    { new Guid("59921489-a482-272f-6b5b-46c7867c676e"), "Licensed Cotton Mouse", new Guid("1e2c23c9-1e0f-d13a-4cac-27078dac190f"), new TimeSpan(0, 0, 3, 1, 0), "Approved", "I'll program the" },
                    { new Guid("60a85b1f-706e-bd53-6c2b-417202755699"), "Licensed Wooden Keyboard", new Guid("7775e280-c280-eecf-54f4-31fbbf49b93b"), new TimeSpan(0, 0, 3, 13, 0), "Pending", "Try to synthesize" },
                    { new Guid("616f46da-8cca-878b-af73-9b0fc11991eb"), "Rustic Wooden Bike", new Guid("d9ace6d5-3d01-ab77-48e3-ab1f26334575"), new TimeSpan(0, 0, 3, 3, 0), "Approved", "The THX program" },
                    { new Guid("69b94243-01c4-e117-7e6c-8c97ee7f089f"), "Practical Cotton Ball", new Guid("d82de857-522c-c556-b013-d78f474f9287"), new TimeSpan(0, 0, 2, 32, 0), "Rejected", "The GB circuit" },
                    { new Guid("6b4b99f4-1182-d76d-073b-69634b12638b"), "Handcrafted Plastic Shoes", new Guid("28a25f0e-dfa5-dc8a-9ec7-db94ad90e67d"), new TimeSpan(0, 0, 3, 27, 0), "Approved", "I'll hack the" },
                    { new Guid("6bbed3b5-9bf0-a69d-4037-c2b125fcb302"), "Tasty Metal Towels", new Guid("de35e4ee-1a3c-5790-7777-f1ec1069e422"), new TimeSpan(0, 0, 3, 19, 0), "Pending", "If we hack" },
                    { new Guid("6dd9a615-84df-c4e5-5c86-6643bab486bf"), "Ergonomic Steel Tuna", new Guid("7fc71309-41a9-f4e3-287b-8345ecad8131"), new TimeSpan(0, 0, 3, 10, 0), "Pending", "You can't hack" },
                    { new Guid("6f79342b-2557-4301-9032-eba4563db8cc"), "Practical Rubber Mouse", new Guid("0e51d9f0-3e16-1570-8751-8bfcad3c76b7"), new TimeSpan(0, 0, 3, 9, 0), "Rejected", "You can't bypass" },
                    { new Guid("70efca8f-3cff-9ce7-3915-63234e7a8cf7"), "Generic Concrete Mouse", new Guid("d9ace6d5-3d01-ab77-48e3-ab1f26334575"), new TimeSpan(0, 0, 3, 13, 0), "Approved", "bypassing the pixel" },
                    { new Guid("749354d5-e054-aba9-5875-85fbcbfbfda9"), "Ergonomic Rubber Bacon", new Guid("552d18c2-86b9-4773-0253-becbc4f9f3a7"), new TimeSpan(0, 0, 2, 46, 0), "Pending", "If we input" },
                    { new Guid("7a71ffa1-cd50-3c2e-cef1-87578365eb60"), "Tasty Steel Chips", new Guid("f4c5bb92-c504-dc74-c969-fbb76ae50f7e"), new TimeSpan(0, 0, 3, 4, 0), "Pending", "We need to" },
                    { new Guid("84cb75de-219e-76e9-5574-a35f742725c5"), "Small Rubber Mouse", new Guid("65ff82bb-8d09-8e6c-0f2b-c4d489d94086"), new TimeSpan(0, 0, 3, 23, 0), "Pending", "navigating the application" },
                    { new Guid("877b086b-51b9-f9cf-6f30-0159c888f5e2"), "Tasty Concrete Gloves", new Guid("eb5aa860-01f1-f11d-eb28-7b3747c1dca7"), new TimeSpan(0, 0, 2, 49, 0), "Pending", "backing up the" },
                    { new Guid("8c69ef4b-b3d3-5fa0-59bf-bcf14d45b898"), "Ergonomic Granite Car", new Guid("3a4637ab-0383-947a-860b-598de7e62046"), new TimeSpan(0, 0, 2, 43, 0), "Approved", "You can't hack" },
                    { new Guid("8e09973c-766f-6f66-93be-da1a8e496bef"), "Unbranded Rubber Pizza", new Guid("ffd23d02-4eb5-4217-2b43-f9b46c4a45c7"), new TimeSpan(0, 0, 3, 11, 0), "Approved", "Try to calculate" },
                    { new Guid("9c855adb-087b-f53a-d48e-37af87c2ee76"), "Intelligent Steel Pants", new Guid("65ff82bb-8d09-8e6c-0f2b-c4d489d94086"), new TimeSpan(0, 0, 3, 1, 0), "Rejected", "You can't bypass" },
                    { new Guid("a27bd1b8-5905-c895-ac34-023669f34f37"), "Incredible Fresh Table", new Guid("de35e4ee-1a3c-5790-7777-f1ec1069e422"), new TimeSpan(0, 0, 3, 28, 0), "Pending", "The TCP interface" },
                    { new Guid("a3b7053f-8afc-b81f-e1ef-e7dd651dbbd6"), "Handcrafted Rubber Shirt", new Guid("7fc71309-41a9-f4e3-287b-8345ecad8131"), new TimeSpan(0, 0, 2, 57, 0), "Pending", "You can't navigate" },
                    { new Guid("a3fab3b8-12f1-276c-286c-ed14dfab57e2"), "Handmade Frozen Pizza", new Guid("d9ace6d5-3d01-ab77-48e3-ab1f26334575"), new TimeSpan(0, 0, 2, 40, 0), "Pending", "The XSS feed" },
                    { new Guid("a46ef40e-5e8f-0842-a90c-66a29336dccd"), "Incredible Steel Car", new Guid("d922e44d-ba77-e400-0a2a-26212685a3c3"), new TimeSpan(0, 0, 2, 54, 0), "Approved", "If we parse" },
                    { new Guid("aab972b2-6fc9-ebcd-867b-c8d8fa0e800e"), "Practical Soft Soap", new Guid("552d18c2-86b9-4773-0253-becbc4f9f3a7"), new TimeSpan(0, 0, 3, 18, 0), "Pending", "You can't quantify" },
                    { new Guid("ab3ff4e6-7612-fc80-75af-48fc0daced95"), "Generic Fresh Bike", new Guid("455357b3-ab37-7d3b-8ddd-aa4a9b035760"), new TimeSpan(0, 0, 2, 46, 0), "Pending", "Use the online" },
                    { new Guid("ab6c8ed2-7d80-c162-0059-b7c7553d8fe7"), "Awesome Fresh Chicken", new Guid("7775e280-c280-eecf-54f4-31fbbf49b93b"), new TimeSpan(0, 0, 3, 2, 0), "Rejected", "Try to transmit" },
                    { new Guid("acfea3be-024e-39ae-7647-e68537b39837"), "Tasty Frozen Computer", new Guid("f4c5bb92-c504-dc74-c969-fbb76ae50f7e"), new TimeSpan(0, 0, 3, 1, 0), "Rejected", "If we input" },
                    { new Guid("ad650e70-877c-47f1-34b2-36bf9973883b"), "Refined Soft Fish", new Guid("e1863474-f4ae-c7e2-12bb-a8f909512da9"), new TimeSpan(0, 0, 3, 1, 0), "Pending", "Try to generate" },
                    { new Guid("ae5074fc-ca93-2534-454c-992843750813"), "Ergonomic Cotton Computer", new Guid("d922e44d-ba77-e400-0a2a-26212685a3c3"), new TimeSpan(0, 0, 2, 50, 0), "Rejected", "If we generate" },
                    { new Guid("af5869ba-ea39-4128-d894-68dd6537f86f"), "Handmade Wooden Hat", new Guid("f4c5bb92-c504-dc74-c969-fbb76ae50f7e"), new TimeSpan(0, 0, 2, 54, 0), "Approved", "You can't quantify" },
                    { new Guid("b1b9c422-a4f3-65f3-4dac-48811ddb829e"), "Handcrafted Fresh Sausages", new Guid("62974f26-824a-80f7-bdb5-31fe456909ca"), new TimeSpan(0, 0, 3, 7, 0), "Pending", "Use the open-source" },
                    { new Guid("b45c0211-b270-8016-da5c-bd964b3929f5"), "Rustic Granite Shirt", new Guid("49bb0990-7c20-0dcf-fce5-3793219f6047"), new TimeSpan(0, 0, 2, 55, 0), "Pending", "We need to" },
                    { new Guid("b5fe127a-9183-e227-c5e3-eeef27e28287"), "Unbranded Steel Bike", new Guid("1c8575f0-6194-339d-ad3e-2e7c3866a80f"), new TimeSpan(0, 0, 3, 14, 0), "Rejected", "Try to quantify" },
                    { new Guid("b641bdf7-7844-422f-6aaa-47f0a24c7379"), "Gorgeous Steel Hat", new Guid("0e51d9f0-3e16-1570-8751-8bfcad3c76b7"), new TimeSpan(0, 0, 3, 12, 0), "Rejected", "The SMTP application" },
                    { new Guid("b697ad87-9659-2f28-e029-761f4b433a47"), "Small Cotton Ball", new Guid("fa333e3f-3b75-cd02-7ce7-2b77e1e700a2"), new TimeSpan(0, 0, 3, 6, 0), "Rejected", "You can't calculate" },
                    { new Guid("c1d48525-8eb7-966d-c78c-c9e9432ce31f"), "Ergonomic Granite Pants", new Guid("b471b00d-f7ee-acf9-e226-1fd24d76e93c"), new TimeSpan(0, 0, 3, 3, 0), "Rejected", "calculating the panel" },
                    { new Guid("c4e5c742-9537-175d-ddb9-a50ad27bcf9b"), "Rustic Wooden Shoes", new Guid("a8c435d2-a3ab-8813-de0e-ac5fab782189"), new TimeSpan(0, 0, 2, 57, 0), "Rejected", "Use the multi-byte" },
                    { new Guid("c5d5532f-26be-5e16-c3b3-1066d8782141"), "Incredible Cotton Salad", new Guid("b471b00d-f7ee-acf9-e226-1fd24d76e93c"), new TimeSpan(0, 0, 3, 28, 0), "Rejected", "We need to" },
                    { new Guid("c78d0fe1-6117-1be1-5f55-71ec9fe16fe9"), "Awesome Rubber Ball", new Guid("d14d8488-392a-c224-376c-9545523ef9d7"), new TimeSpan(0, 0, 2, 45, 0), "Pending", "Use the 1080p" },
                    { new Guid("ccd1981e-2661-5615-8b3e-aff33418273c"), "Handmade Wooden Ball", new Guid("552d18c2-86b9-4773-0253-becbc4f9f3a7"), new TimeSpan(0, 0, 2, 53, 0), "Rejected", "overriding the port" },
                    { new Guid("ce555527-d6f7-f501-7e43-f2b8e7361fbd"), "Rustic Fresh Gloves", new Guid("8717fef3-a26b-e361-ca4b-173b514b256b"), new TimeSpan(0, 0, 2, 51, 0), "Approved", "I'll override the" },
                    { new Guid("cee69697-01ce-a687-e007-f6699c7bc574"), "Rustic Steel Cheese", new Guid("062f3c05-dd11-1323-10db-7e8ac0b8ef7e"), new TimeSpan(0, 0, 3, 21, 0), "Approved", "Try to transmit" },
                    { new Guid("cf8da1cf-1968-dc08-77f0-75267594241d"), "Gorgeous Frozen Salad", new Guid("9c2b1595-45f8-672e-e24d-46b081cda8ed"), new TimeSpan(0, 0, 3, 24, 0), "Rejected", "synthesizing the feed" },
                    { new Guid("d8b26789-0a0b-c42c-d0da-101e67af1cf9"), "Generic Granite Pizza", new Guid("2349b3e1-f845-5b61-fa8e-fbef8c8a9b57"), new TimeSpan(0, 0, 2, 44, 0), "Pending", "compressing the hard" },
                    { new Guid("dafb9076-3e39-5e4c-c694-f57a840f6558"), "Unbranded Rubber Table", new Guid("7fc71309-41a9-f4e3-287b-8345ecad8131"), new TimeSpan(0, 0, 3, 3, 0), "Pending", "We need to" },
                    { new Guid("db1a50e6-d053-4ccc-33f9-bfbf58f79c12"), "Sleek Frozen Pizza", new Guid("28a25f0e-dfa5-dc8a-9ec7-db94ad90e67d"), new TimeSpan(0, 0, 2, 45, 0), "Rejected", "If we parse" },
                    { new Guid("df4788c3-7d04-dd26-408f-fff6009eb4ee"), "Awesome Cotton Car", new Guid("e1863474-f4ae-c7e2-12bb-a8f909512da9"), new TimeSpan(0, 0, 3, 6, 0), "Pending", "The AI application" },
                    { new Guid("e03ef966-2acf-1876-c6ed-7bd133e3d86d"), "Licensed Cotton Car", new Guid("1c8575f0-6194-339d-ad3e-2e7c3866a80f"), new TimeSpan(0, 0, 2, 30, 0), "Approved", "If we hack" },
                    { new Guid("e259cb66-d501-bcb4-b93d-b00a4b0b91c0"), "Tasty Rubber Computer", new Guid("d922e44d-ba77-e400-0a2a-26212685a3c3"), new TimeSpan(0, 0, 2, 54, 0), "Rejected", "transmitting the matrix" },
                    { new Guid("e2a33227-077f-f568-9dd6-78be505f0985"), "Unbranded Rubber Keyboard", new Guid("0e51d9f0-3e16-1570-8751-8bfcad3c76b7"), new TimeSpan(0, 0, 2, 45, 0), "Approved", "The GB system" },
                    { new Guid("e392318e-0185-7406-de5c-483aaa7642fa"), "Incredible Frozen Ball", new Guid("62974f26-824a-80f7-bdb5-31fe456909ca"), new TimeSpan(0, 0, 2, 46, 0), "Approved", "I'll parse the" },
                    { new Guid("e4fe5ccd-7355-d1f9-8c6e-a0741673ef38"), "Handmade Plastic Pants", new Guid("552d18c2-86b9-4773-0253-becbc4f9f3a7"), new TimeSpan(0, 0, 2, 36, 0), "Pending", "quantifying the panel" },
                    { new Guid("e5cf24c7-964a-1190-a3dd-12a42fed31f4"), "Gorgeous Wooden Bike", new Guid("d14d8488-392a-c224-376c-9545523ef9d7"), new TimeSpan(0, 0, 2, 45, 0), "Rejected", "Use the virtual" },
                    { new Guid("e89cc816-72ce-e100-26aa-05cd5d36d0f5"), "Intelligent Plastic Chicken", new Guid("49bb0990-7c20-0dcf-fce5-3793219f6047"), new TimeSpan(0, 0, 2, 52, 0), "Approved", "I'll calculate the" },
                    { new Guid("ee9bdcb3-b3e8-1063-a5ee-72d28e87504c"), "Handcrafted Steel Gloves", new Guid("a8c435d2-a3ab-8813-de0e-ac5fab782189"), new TimeSpan(0, 0, 2, 57, 0), "Approved", "Use the wireless" },
                    { new Guid("efa23eb3-d17a-fc76-a100-5e1c24dbca0b"), "Licensed Wooden Car", new Guid("0e51d9f0-3e16-1570-8751-8bfcad3c76b7"), new TimeSpan(0, 0, 3, 13, 0), "Approved", "Try to synthesize" },
                    { new Guid("f1dd9083-3c60-21bd-0430-501f7c7f698d"), "Intelligent Cotton Shoes", new Guid("d14d8488-392a-c224-376c-9545523ef9d7"), new TimeSpan(0, 0, 3, 11, 0), "Approved", "I'll calculate the" },
                    { new Guid("fa540541-003f-d457-72cf-cc35f187a0c5"), "Incredible Plastic Table", new Guid("62974f26-824a-80f7-bdb5-31fe456909ca"), new TimeSpan(0, 0, 2, 36, 0), "Rejected", "The AI array" },
                    { new Guid("fb3372f9-e4b2-a8f8-dedd-52ad5dd26ad1"), "Licensed Rubber Shirt", new Guid("ffd23d02-4eb5-4217-2b43-f9b46c4a45c7"), new TimeSpan(0, 0, 2, 37, 0), "Approved", "Use the redundant" },
                    { new Guid("fbc16e58-f1d9-a4d1-b65b-855b26297426"), "Generic Soft Towels", new Guid("d14d8488-392a-c224-376c-9545523ef9d7"), new TimeSpan(0, 0, 2, 56, 0), "Rejected", "The SMS system" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("02b06f85-9869-6388-0d34-b3d720d559d8"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("0507e220-ad19-a61f-92a2-5a894be47e4b"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("073c86f1-6eb0-eb49-eaca-0cd4c23ed24b"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("0bf2a18f-2f80-44b4-61b3-6d437da163dc"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("0d5d93d1-101a-ec67-496f-9c2b0bd9efad"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("10284c55-8087-37d4-244f-ce057d8d4be4"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("116011ab-1877-f674-8353-b2570830bef9"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("1177c8ca-0588-4071-7959-d630241c53ee"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("137af266-a83d-b4f1-eed7-02ed3ee98ba8"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("13f19850-5b4e-dc97-819d-3cabbceaf6f1"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("15c759a2-cb6d-abf1-69b7-79b4bde1c024"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("1705167d-8a5b-49a8-a548-23eae9cd03f4"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("17c50ad9-0a56-0a8d-828f-09374f617d13"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("1b81abfa-6b29-94f3-eb1d-5bc0c0442262"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("1f04d275-f058-ee0a-7241-4b9e6201aa26"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("1f192cb4-af67-db3c-e9fe-67f000fae4ac"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("225be22a-2c57-0f5d-f30e-57707a44e208"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("2a38270f-6071-1631-7684-0215182b1dee"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("2ce27632-f684-5805-d2fa-a1923dc0a2f7"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("302edfda-2bf7-b508-807b-98714ab924a1"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("310057b1-2751-8bf8-371e-93824e09e24e"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("3326d392-5963-f6c0-e0c7-69708c6c9d42"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("338674b9-8e29-2216-15f0-3a2b4aae5fc0"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("349c6b37-0ab2-5115-1c5d-086b513e1e03"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("364e88ad-3c82-5c95-8694-da1e3c79b1f7"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("38675bc9-166f-2202-8b39-00aad9bbe25e"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("390ae472-9ba7-b62d-7e32-9a7f25b5e216"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("3b789d14-406a-7988-026b-cf388b92603d"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("3b79ffed-df03-0146-9edd-a04e11c601c9"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("407c2590-e002-b2b1-66d7-f7bf31213d2f"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("44159250-371c-e52b-6979-d68b9292dc0a"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("46dcdd9f-4997-c371-3ad5-62f9311fa2c0"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("46ea0196-d84b-e5c7-82ef-ce6dd0e09efd"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("470b51ee-0123-a7b6-d38e-0cd6923740c3"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("495648e1-44a3-973b-55d2-1ded22676e00"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("4d60d783-8172-76a2-6c13-5cf27f1d9411"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("51223a40-c8eb-e9c6-1d02-0ca9ca47725a"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("5241daea-7eae-d980-6c8d-3fff7a859c8d"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("56098df8-fb53-be2b-1141-30f15deaaf2a"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("59921489-a482-272f-6b5b-46c7867c676e"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("60a85b1f-706e-bd53-6c2b-417202755699"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("616f46da-8cca-878b-af73-9b0fc11991eb"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("69b94243-01c4-e117-7e6c-8c97ee7f089f"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("6b4b99f4-1182-d76d-073b-69634b12638b"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("6bbed3b5-9bf0-a69d-4037-c2b125fcb302"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("6dd9a615-84df-c4e5-5c86-6643bab486bf"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("6f79342b-2557-4301-9032-eba4563db8cc"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("70efca8f-3cff-9ce7-3915-63234e7a8cf7"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("749354d5-e054-aba9-5875-85fbcbfbfda9"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("7a71ffa1-cd50-3c2e-cef1-87578365eb60"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("84cb75de-219e-76e9-5574-a35f742725c5"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("877b086b-51b9-f9cf-6f30-0159c888f5e2"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("8c69ef4b-b3d3-5fa0-59bf-bcf14d45b898"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("8e09973c-766f-6f66-93be-da1a8e496bef"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("9c855adb-087b-f53a-d48e-37af87c2ee76"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("a27bd1b8-5905-c895-ac34-023669f34f37"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("a3b7053f-8afc-b81f-e1ef-e7dd651dbbd6"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("a3fab3b8-12f1-276c-286c-ed14dfab57e2"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("a46ef40e-5e8f-0842-a90c-66a29336dccd"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("aab972b2-6fc9-ebcd-867b-c8d8fa0e800e"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("ab3ff4e6-7612-fc80-75af-48fc0daced95"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("ab6c8ed2-7d80-c162-0059-b7c7553d8fe7"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("acfea3be-024e-39ae-7647-e68537b39837"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("ad650e70-877c-47f1-34b2-36bf9973883b"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("ae5074fc-ca93-2534-454c-992843750813"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("af5869ba-ea39-4128-d894-68dd6537f86f"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("b1b9c422-a4f3-65f3-4dac-48811ddb829e"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("b45c0211-b270-8016-da5c-bd964b3929f5"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("b5fe127a-9183-e227-c5e3-eeef27e28287"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("b641bdf7-7844-422f-6aaa-47f0a24c7379"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("b697ad87-9659-2f28-e029-761f4b433a47"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("c1d48525-8eb7-966d-c78c-c9e9432ce31f"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("c4e5c742-9537-175d-ddb9-a50ad27bcf9b"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("c5d5532f-26be-5e16-c3b3-1066d8782141"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("c78d0fe1-6117-1be1-5f55-71ec9fe16fe9"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("ccd1981e-2661-5615-8b3e-aff33418273c"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("ce555527-d6f7-f501-7e43-f2b8e7361fbd"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("cee69697-01ce-a687-e007-f6699c7bc574"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("cf8da1cf-1968-dc08-77f0-75267594241d"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("d8b26789-0a0b-c42c-d0da-101e67af1cf9"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("dafb9076-3e39-5e4c-c694-f57a840f6558"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("db1a50e6-d053-4ccc-33f9-bfbf58f79c12"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("df4788c3-7d04-dd26-408f-fff6009eb4ee"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e03ef966-2acf-1876-c6ed-7bd133e3d86d"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e259cb66-d501-bcb4-b93d-b00a4b0b91c0"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e2a33227-077f-f568-9dd6-78be505f0985"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e392318e-0185-7406-de5c-483aaa7642fa"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e4fe5ccd-7355-d1f9-8c6e-a0741673ef38"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e5cf24c7-964a-1190-a3dd-12a42fed31f4"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e89cc816-72ce-e100-26aa-05cd5d36d0f5"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("ee9bdcb3-b3e8-1063-a5ee-72d28e87504c"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("efa23eb3-d17a-fc76-a100-5e1c24dbca0b"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("f1dd9083-3c60-21bd-0430-501f7c7f698d"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("fa540541-003f-d457-72cf-cc35f187a0c5"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("fb3372f9-e4b2-a8f8-dedd-52ad5dd26ad1"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("fbc16e58-f1d9-a4d1-b65b-855b26297426"));

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Songs");

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
        }
    }
}
