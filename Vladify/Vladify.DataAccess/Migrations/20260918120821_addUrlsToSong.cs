using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vladify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addUrlsToSong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("2c0d2442-82c0-9220-b1c3-5bd861474e96"));

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
                keyValue: new Guid("b641bdf7-7844-422f-6aaa-47f0a24c7379"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("b697ad87-9659-2f28-e029-761f4b433a47"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("bca93494-9f15-1b46-e23c-118c089386fa"));

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
                keyValue: new Guid("db774e40-3592-6462-f2c0-a3e46d4257db"));

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

            migrationBuilder.AddColumn<string>(
                name: "AudioUrl",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CoverUrl",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("0d5d93d1-101a-ec67-496f-9c2b0bd9efad"),
                columns: new[] { "AudioUrl", "CoverUrl" },
                values: new object[] { "http://chris.info/optimize/white/local", "https://jazmyn.org/reboot/trail/reboot" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("13f19850-5b4e-dc97-819d-3cabbceaf6f1"),
                columns: new[] { "AudioUrl", "CoverUrl" },
                values: new object[] { "http://elise.info/locks", "http://ruby.net/awesome/western-sahara" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("46ea0196-d84b-e5c7-82ef-ce6dd0e09efd"),
                columns: new[] { "AudioUrl", "CoverUrl" },
                values: new object[] { "http://cecelia.name/specialist", "https://enoch.org/copy/hacking/meadow" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("5241daea-7eae-d980-6c8d-3fff7a859c8d"),
                columns: new[] { "AudioUrl", "CoverUrl" },
                values: new object[] { "http://jalon.net/mobility/avon/incentivize", "http://elton.info/sms" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("56098df8-fb53-be2b-1141-30f15deaaf2a"),
                columns: new[] { "AudioUrl", "CoverUrl" },
                values: new object[] { "http://elisabeth.biz/kids--garden/uganda-shilling/", "https://adolph.biz/solomon-islands-dollar/cyan" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("9fdea678-4a21-6d13-4185-9484e1a21ecd"),
                columns: new[] { "AudioUrl", "CoverUrl" },
                values: new object[] { "https://desiree.net/benchmark/invoice", "http://callie.info/incredible-wooden-shirt/generic" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("b5fe127a-9183-e227-c5e3-eeef27e28287"),
                columns: new[] { "AudioUrl", "CoverUrl" },
                values: new object[] { "http://martina.net/css", "http://ali.com/sensor" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Album", "AudioUrl", "AuthorId", "CoverUrl", "Duration", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("022f284d-5a3c-9a21-099f-969d11025cb4"), "Refined Steel Pizza", "http://stephany.info/trace", new Guid("455357b3-ab37-7d3b-8ddd-aa4a9b035760"), "http://helen.biz/hungary", new TimeSpan(0, 0, 2, 42, 0), "Approved", "We need to" },
                    { new Guid("088c113c-8693-77fa-1d2e-e1848b144d13"), "Fantastic Frozen Mouse", "http://mireya.name/home-loan-account/artificial-in", new Guid("9c2b1595-45f8-672e-e24d-46b081cda8ed"), "http://cassidy.biz/logistical/mountain", new TimeSpan(0, 0, 2, 51, 0), "Approved", "You can't synthesize" },
                    { new Guid("0b585d74-a7bb-c43b-17b1-a10f472c160b"), "Licensed Granite Bike", "https://ignatius.info/handcrafted-concrete-keyboar", new Guid("d14d8488-392a-c224-376c-9545523ef9d7"), "https://raymundo.com/global/iterate/cyan", new TimeSpan(0, 0, 2, 56, 0), "Rejected", "Try to calculate" },
                    { new Guid("0e8d697f-5ecd-f720-05c3-81f37be64927"), "Refined Frozen Soap", "https://devin.info/bedfordshire/deposit", new Guid("062f3c05-dd11-1323-10db-7e8ac0b8ef7e"), "http://kelly.info/customer/concrete", new TimeSpan(0, 0, 2, 46, 0), "Rejected", "I'll generate the" },
                    { new Guid("1063b3e8-eea5-d272-8e87-504cfab6fd4d"), "Practical Granite Sausages", "http://rick.info/handcrafted/bypassing/supervisor", new Guid("3a4637ab-0383-947a-860b-598de7e62046"), "http://maximo.org/prairie", new TimeSpan(0, 0, 3, 15, 0), "Pending", "If we hack" },
                    { new Guid("11b45ed3-d583-15a1-244e-c799f1763d8f"), "Sleek Plastic Pants", "http://winfield.info/monitor/drive", new Guid("9c2b1595-45f8-672e-e24d-46b081cda8ed"), "http://karli.org/override", new TimeSpan(0, 0, 3, 15, 0), "Approved", "calculating the card" },
                    { new Guid("1318f97c-c47e-402a-149d-783b6a408879"), "Intelligent Granite Pants", "https://lesley.com/bandwidth/rubber", new Guid("eb5aa860-01f1-f11d-eb28-7b3747c1dca7"), "https://myrl.name/idaho/granite", new TimeSpan(0, 0, 3, 30, 0), "Pending", "You can't compress" },
                    { new Guid("148937f1-c71a-6c7f-a7f2-1e90f1863c07"), "Awesome Plastic Shirt", "https://emmie.net/licensed", new Guid("17f3f721-c6c8-7b79-2791-0c615bb1d678"), "http://christelle.name/maximized/auto-loan-account", new TimeSpan(0, 0, 2, 32, 0), "Pending", "I'll input the" },
                    { new Guid("167db078-b22a-b972-aac9-6fcdeb867bc8"), "Practical Steel Bacon", "https://orrin.com/investment-account/virtual/olive", new Guid("7fc71309-41a9-f4e3-287b-8345ecad8131"), "https://sophia.biz/dedicated/hack", new TimeSpan(0, 0, 3, 5, 0), "Approved", "You can't index" },
                    { new Guid("1f08199d-a85b-6e60-7053-bd6c2b417202"), "Generic Cotton Chicken", "http://ned.net/yuan-renminbi/payment/ergonomic-fro", new Guid("d82de857-522c-c556-b013-d78f474f9287"), "http://leilani.biz/sticky/saudi-arabia", new TimeSpan(0, 0, 2, 40, 0), "Pending", "Use the 1080p" },
                    { new Guid("23631539-7a4e-f78c-731e-37254e0c34ed"), "Generic Steel Hat", "https://meagan.biz/technician/tasty-soft-pizza/evo", new Guid("de35e4ee-1a3c-5790-7777-f1ec1069e422"), "http://dortha.com/bypass/square", new TimeSpan(0, 0, 3, 15, 0), "Rejected", "We need to" },
                    { new Guid("2483b133-f373-d74e-c183-e57bc4e5d39c"), "Intelligent Frozen Gloves", "http://lorna.com/texas/flats", new Guid("65ff82bb-8d09-8e6c-0f2b-c4d489d94086"), "http://okey.net/wooden", new TimeSpan(0, 0, 3, 12, 0), "Approved", "If we program" },
                    { new Guid("2f20d533-d392-3326-6359-c0f6e0c76970"), "Licensed Wooden Salad", "http://irma.org/function/fantastic-concrete-fish/i", new Guid("89d22fe4-5532-ac42-0f6e-976e2e92da05"), "http://cordell.com/vista", new TimeSpan(0, 0, 2, 45, 0), "Approved", "You can't input" },
                    { new Guid("3348964e-f999-a007-d47b-177c65e966cb"), "Generic Rubber Hat", "http://stacey.net/accounts", new Guid("b471b00d-f7ee-acf9-e226-1fd24d76e93c"), "http://carlos.com/tasty-rubber-computer/fault-tole", new TimeSpan(0, 0, 3, 12, 0), "Pending", "I'll quantify the" },
                    { new Guid("3705369e-c4cd-d022-ab94-e320ee79b812"), "Intelligent Soft Fish", "https://van.net/tasty-soft-sausages/haptic", new Guid("28a25f0e-dfa5-dc8a-9ec7-db94ad90e67d"), "http://rick.biz/interactive/views/guyana-dollar", new TimeSpan(0, 0, 2, 36, 0), "Approved", "We need to" },
                    { new Guid("3a33e040-6b33-76c2-224b-5fac1d9f5a2e"), "Unbranded Concrete Shirt", "http://arvid.com/mountains/optical/electronics--he", new Guid("49bb0990-7c20-0dcf-fce5-3793219f6047"), "http://raheem.org/incredible/feed", new TimeSpan(0, 0, 3, 27, 0), "Rejected", "If we calculate" },
                    { new Guid("3a8e96f9-3bd7-3dd8-50fd-a9c192cfad91"), "Handmade Concrete Towels", "https://reta.com/computers--kids", new Guid("d14d8488-392a-c224-376c-9545523ef9d7"), "http://raphaelle.info/swiss-franc/fuchsia/gorgeous", new TimeSpan(0, 0, 2, 43, 0), "Pending", "Try to reboot" },
                    { new Guid("3b341fed-0782-7b8b-961c-0d8be4500dd9"), "Sleek Plastic Shirt", "http://kelly.net/synergized/virtual/texas", new Guid("e1863474-f4ae-c7e2-12bb-a8f909512da9"), "https://erika.org/capacity", new TimeSpan(0, 0, 2, 33, 0), "Rejected", "The SCSI bandwidth" },
                    { new Guid("3fe77a9a-553a-af5d-317f-10bdc02e98ba"), "Generic Rubber Car", "http://rhea.net/road/programmable/antarctica-the-t", new Guid("455357b3-ab37-7d3b-8ddd-aa4a9b035760"), "https://ibrahim.net/e-tailers/san-marino", new TimeSpan(0, 0, 2, 36, 0), "Rejected", "We need to" },
                    { new Guid("40d741bf-6c7a-e3ed-748a-1217fdfd82d9"), "Fantastic Cotton Cheese", "https://edyth.name/representative/generating/effic", new Guid("8717fef3-a26b-e361-ca4b-173b514b256b"), "http://ulices.biz/usb", new TimeSpan(0, 0, 2, 46, 0), "Pending", "Try to bypass" },
                    { new Guid("42252606-3838-6661-2f2c-740a403a2251"), "Handcrafted Soft Tuna", "http://lafayette.biz/maryland/unbranded", new Guid("7fc71309-41a9-f4e3-287b-8345ecad8131"), "https://dee.net/withdrawal/gorgeous-wooden-pizza", new TimeSpan(0, 0, 3, 4, 0), "Pending", "You can't program" },
                    { new Guid("43baf9ce-cb90-e502-f1ac-858f3e9c4725"), "Small Rubber Chicken", "http://justina.biz/accountability/greens", new Guid("eb5aa860-01f1-f11d-eb28-7b3747c1dca7"), "http://santos.biz/tools--music/rustic-plastic-pizz", new TimeSpan(0, 0, 3, 27, 0), "Pending", "Try to override" },
                    { new Guid("465b6b27-86c7-677c-6e41-d314447f6aea"), "Tasty Frozen Chair", "https://cassie.name/experiences/macao/deposit", new Guid("65ff82bb-8d09-8e6c-0f2b-c4d489d94086"), "http://margie.com/synthesize/sports", new TimeSpan(0, 0, 2, 41, 0), "Approved", "You can't synthesize" },
                    { new Guid("4778f9be-b316-d851-974d-12c194e3cfa1"), "Rustic Fresh Cheese", "https://marlee.name/terrace/assurance", new Guid("552d18c2-86b9-4773-0253-becbc4f9f3a7"), "https://stefanie.net/interactions", new TimeSpan(0, 0, 2, 47, 0), "Rejected", "generating the sensor" },
                    { new Guid("4d46c271-12f1-9b0d-4af3-0f3e5e101ed8"), "Gorgeous Rubber Tuna", "https://krystel.org/jersey/avon", new Guid("d82de857-522c-c556-b013-d78f474f9287"), "http://ima.info/delaware", new TimeSpan(0, 0, 2, 57, 0), "Pending", "compressing the monitor" },
                    { new Guid("4d6356d5-b961-d6a4-6a7f-72b157003151"), "Awesome Metal Towels", "http://deven.info/credit-card-account/engage/revol", new Guid("062f3c05-dd11-1323-10db-7e8ac0b8ef7e"), "http://consuelo.org/fresh/functionality", new TimeSpan(0, 0, 3, 4, 0), "Approved", "synthesizing the array" },
                    { new Guid("4f30f008-936c-0edb-662e-04409ea576ef"), "Awesome Metal Keyboard", "http://idella.name/handcrafted/soft/orchestrator", new Guid("ffd23d02-4eb5-4217-2b43-f9b46c4a45c7"), "https://nikko.info/project/tanzania", new TimeSpan(0, 0, 3, 1, 0), "Approved", "We need to" },
                    { new Guid("51617a13-1e5a-44c6-6eac-6fcb0cfc319f"), "Ergonomic Concrete Shirt", "http://ernie.info/bleeding-edge", new Guid("49bb0990-7c20-0dcf-fce5-3793219f6047"), "http://madelyn.com/portals/executive/intelligent-g", new TimeSpan(0, 0, 3, 4, 0), "Approved", "Try to parse" },
                    { new Guid("53a0e799-d7a7-7a11-0e03-2921ee510b47"), "Handmade Steel Chicken", "http://laverna.org/redundant", new Guid("de35e4ee-1a3c-5790-7777-f1ec1069e422"), "https://kade.name/intelligent-frozen-cheese/gorgeo", new TimeSpan(0, 0, 2, 56, 0), "Rejected", "If we navigate" },
                    { new Guid("55e4fe5c-f973-8cd1-6ea0-741673ef3854"), "Incredible Plastic Table", "http://alice.info/jbod/wisconsin/streets", new Guid("b471b00d-f7ee-acf9-e226-1fd24d76e93c"), "https://samantha.info/calculate", new TimeSpan(0, 0, 2, 31, 0), "Rejected", "If we input" },
                    { new Guid("581db257-4981-f568-789a-4d1f2b834f73"), "Gorgeous Soft Car", "https://fatima.org/congolese-franc/arkansas", new Guid("7fc71309-41a9-f4e3-287b-8345ecad8131"), "http://gregg.info/channels", new TimeSpan(0, 0, 3, 12, 0), "Approved", "compressing the interface" },
                    { new Guid("58cfeb2d-c95e-dd9f-dc46-974971c33ad5"), "Rustic Granite Shirt", "https://erick.com/calculate", new Guid("3a4637ab-0383-947a-860b-598de7e62046"), "http://fredrick.name/steel", new TimeSpan(0, 0, 3, 13, 0), "Approved", "synthesizing the array" },
                    { new Guid("58f4d901-224e-1c87-e5b8-839472ec0cf1"), "Refined Cotton Salad", "http://hazel.org/personal-loan-account/bedfordshir", new Guid("de35e4ee-1a3c-5790-7777-f1ec1069e422"), "https://rosanna.com/program", new TimeSpan(0, 0, 3, 26, 0), "Approved", "We need to" },
                    { new Guid("5900c162-c7b7-3d55-8fe7-03fedbd0a46c"), "Ergonomic Frozen Chair", "http://amely.info/regional/solutions/pink", new Guid("65ff82bb-8d09-8e6c-0f2b-c4d489d94086"), "https://florence.name/bahamas/turquoise/lodge", new TimeSpan(0, 0, 2, 36, 0), "Rejected", "Use the wireless" },
                    { new Guid("595fa0b3-bcbf-4df1-45b8-98461c1dde97"), "Practical Steel Computer", "http://nikki.biz/leverage", new Guid("d9ace6d5-3d01-ab77-48e3-ab1f26334575"), "http://wilfred.com/cliffs/borders/models", new TimeSpan(0, 0, 2, 56, 0), "Approved", "We need to" },
                    { new Guid("5b299bde-b51a-ebf6-81ae-007690fbda39"), "Awesome Wooden Keyboard", "http://mollie.name/generic/djibouti-franc/investor", new Guid("1c8575f0-6194-339d-ad3e-2e7c3866a80f"), "http://easter.biz/withdrawal", new TimeSpan(0, 0, 3, 15, 0), "Pending", "You can't program" },
                    { new Guid("5d1c5115-6b08-3e51-1e03-1a7c77f0c507"), "Handcrafted Cotton Pizza", "https://rogelio.net/auxiliary/exe/synthesizing", new Guid("d82de857-522c-c556-b013-d78f474f9287"), "https://alf.name/harbors/withdrawal", new TimeSpan(0, 0, 2, 35, 0), "Rejected", "The SMS matrix" },
                    { new Guid("60d4c70e-37e7-694d-d953-d12191be06fd"), "Fantastic Metal Chicken", "https://eulalia.info/parsing/paradigms", new Guid("1c8575f0-6194-339d-ad3e-2e7c3866a80f"), "http://brando.info/iterate/tonga", new TimeSpan(0, 0, 3, 24, 0), "Rejected", "I'll reboot the" },
                    { new Guid("6117c78d-1be1-555f-71ec-9fe16fe92044"), "Gorgeous Fresh Ball", "http://kailee.net/benchmark", new Guid("fa333e3f-3b75-cd02-7ce7-2b77e1e700a2"), "http://henri.net/monitor", new TimeSpan(0, 0, 2, 45, 0), "Approved", "generating the hard" },
                    { new Guid("619b7f7c-a3be-acfe-4e02-ae397647e685"), "Gorgeous Frozen Shirt", "https://meredith.net/nebraska", new Guid("2349b3e1-f845-5b61-fa8e-fbef8c8a9b57"), "https://sally.net/thx", new TimeSpan(0, 0, 3, 29, 0), "Rejected", "navigating the protocol" },
                    { new Guid("61e8f7b1-40d2-4044-b7ba-d9752184f499"), "Handcrafted Concrete Salad", "http://bethel.biz/json", new Guid("d9ace6d5-3d01-ab77-48e3-ab1f26334575"), "https://unique.name/metal/dot-com", new TimeSpan(0, 0, 3, 12, 0), "Approved", "The COM capacitor" },
                    { new Guid("64011a1c-05d4-6451-efe8-513efff6857a"), "Awesome Plastic Pants", "http://marcellus.biz/interface", new Guid("d922e44d-ba77-e400-0a2a-26212685a3c3"), "https://evalyn.info/schemas/cedi/cotton", new TimeSpan(0, 0, 3, 0, 0), "Approved", "We need to" },
                    { new Guid("65b36746-5527-ce55-f7d6-01f57e43f2b8"), "Sleek Soft Chips", "http://paolo.name/virtual", new Guid("0e51d9f0-3e16-1570-8751-8bfcad3c76b7"), "http://jaylin.info/accounts", new TimeSpan(0, 0, 2, 39, 0), "Rejected", "Try to navigate" },
                    { new Guid("6610b3c3-78d8-4121-9e1e-94c5ab66b4f8"), "Licensed Plastic Towels", "https://jammie.org/e-services/money-market-account", new Guid("d922e44d-ba77-e400-0a2a-26212685a3c3"), "http://johnnie.com/granite", new TimeSpan(0, 0, 3, 19, 0), "Approved", "I'll quantify the" },
                    { new Guid("66d79c37-a06d-cafb-c877-118805714079"), "Ergonomic Granite Keyboard", "http://juliet.info/home-loan-account", new Guid("455357b3-ab37-7d3b-8ddd-aa4a9b035760"), "https://prudence.org/viral/neural/small-granite-co", new TimeSpan(0, 0, 3, 7, 0), "Rejected", "We need to" },
                    { new Guid("6a225c33-5aaa-a58f-42c7-e5c437955d17"), "Awesome Metal Hat", "http://jade.org/corporate/granite", new Guid("d9ace6d5-3d01-ab77-48e3-ab1f26334575"), "https://yvonne.org/fresh", new TimeSpan(0, 0, 3, 4, 0), "Rejected", "If we quantify" },
                    { new Guid("6f267ef7-fb91-6c26-9fed-85d09301ea22"), "Gorgeous Wooden Shirt", "http://easton.org/books", new Guid("1c8575f0-6194-339d-ad3e-2e7c3866a80f"), "http://bryon.info/soft/solutions/solution-oriented", new TimeSpan(0, 0, 2, 50, 0), "Approved", "Try to transmit" },
                    { new Guid("72e500c7-0b3e-3660-5e12-76430aaef98e"), "Tasty Concrete Table", "https://karson.biz/georgia/orchid/investment-accou", new Guid("b471b00d-f7ee-acf9-e226-1fd24d76e93c"), "http://zula.com/garden-beauty--jewelery", new TimeSpan(0, 0, 2, 39, 0), "Approved", "You can't override" },
                    { new Guid("74aff791-59fa-2e7a-afad-17d8e37fa2a1"), "Licensed Fresh Chips", "http://lamont.info/generic-fresh-mouse", new Guid("1e2c23c9-1e0f-d13a-4cac-27078dac190f"), "http://valentina.org/human-resource", new TimeSpan(0, 0, 2, 54, 0), "Pending", "The XSS interface" },
                    { new Guid("75809677-9813-2a27-8cab-0412577b3a90"), "Ergonomic Concrete Shirt", "https://kip.biz/purple/cambridgeshire/morph", new Guid("1e2c23c9-1e0f-d13a-4cac-27078dac190f"), "https://deonte.net/alarm/plaza/networks", new TimeSpan(0, 0, 2, 45, 0), "Pending", "hacking the transmitter" },
                    { new Guid("7b9c69f6-74c5-d8a6-6143-707330f453ba"), "Incredible Wooden Pants", "https://lawson.net/small", new Guid("65ff82bb-8d09-8e6c-0f2b-c4d489d94086"), "http://ashlee.com/emulation/impactful/wells", new TimeSpan(0, 0, 2, 45, 0), "Pending", "calculating the feed" },
                    { new Guid("7d614f37-cc13-498f-18e4-ae58535eac40"), "Licensed Frozen Shirt", "http://margarett.biz/regional", new Guid("1e2c23c9-1e0f-d13a-4cac-27078dac190f"), "https://makayla.org/crossroad", new TimeSpan(0, 0, 2, 57, 0), "Pending", "Use the primary" },
                    { new Guid("7e8afab5-6838-09c8-0230-974927f9ddd0"), "Refined Granite Chair", "http://hilton.net/withdrawal/bypassing/buckinghams", new Guid("e1863474-f4ae-c7e2-12bb-a8f909512da9"), "http://earlene.biz/summit/district/virtual", new TimeSpan(0, 0, 3, 1, 0), "Approved", "I'll calculate the" },
                    { new Guid("84761631-1502-2b18-1dee-7bb4ffb78d86"), "Refined Cotton Table", "https://dejon.info/paradigm/open-source", new Guid("e1863474-f4ae-c7e2-12bb-a8f909512da9"), "http://dayana.info/tunnel/tennessee/concept", new TimeSpan(0, 0, 2, 56, 0), "Rejected", "You can't reboot" },
                    { new Guid("86347e32-1e93-2457-8b9d-ada993ffafbe"), "Handmade Metal Bike", "https://callie.net/awesome-frozen-bike", new Guid("7775e280-c280-eecf-54f4-31fbbf49b93b"), "http://janice.biz/savings-account", new TimeSpan(0, 0, 3, 2, 0), "Rejected", "I'll reboot the" },
                    { new Guid("8670a9ee-efab-ea25-5684-97bf26e6fe29"), "Tasty Granite Sausages", "https://samanta.net/cambridgeshire/personal-loan-a", new Guid("d14d8488-392a-c224-376c-9545523ef9d7"), "http://demarco.net/borders", new TimeSpan(0, 0, 2, 46, 0), "Pending", "If we connect" },
                    { new Guid("8716f5b5-b41a-df02-3578-66a550419ea6"), "Incredible Frozen Salad", "http://kaleb.name/sleek-soft-mouse", new Guid("552d18c2-86b9-4773-0253-becbc4f9f3a7"), "https://philip.org/new-mexico/frozen", new TimeSpan(0, 0, 3, 8, 0), "Pending", "The EXE application" },
                    { new Guid("88a4e608-48e1-4956-a344-3b9755d21ded"), "Awesome Wooden Pizza", "https://kale.net/monitor/initiatives", new Guid("89d22fe4-5532-ac42-0f6e-976e2e92da05"), "http://alan.org/gorgeous-fresh-pants", new TimeSpan(0, 0, 3, 3, 0), "Pending", "The USB system" },
                    { new Guid("8a4b59b0-69cc-6bfc-070e-6ddf37a5c205"), "Sleek Concrete Pizza", "https://lynn.biz/east-caribbean-dollar/infrastruct", new Guid("eb5aa860-01f1-f11d-eb28-7b3747c1dca7"), "https://elta.com/web-enabled/anguilla/deposit", new TimeSpan(0, 0, 3, 3, 0), "Pending", "Use the neural" },
                    { new Guid("8b3a8081-f889-ef69-6468-0b1a3f63f3ef"), "Generic Granite Car", "https://tyreek.net/philippine-peso", new Guid("d922e44d-ba77-e400-0a2a-26212685a3c3"), "https://lauriane.org/garden/consultant/bypassing", new TimeSpan(0, 0, 2, 41, 0), "Pending", "The THX firewall" },
                    { new Guid("93ea74c1-1ec6-ffa1-717a-50cd2e3ccef1"), "Rustic Steel Table", "http://ardith.com/toys-toys--home/home-loan-accoun", new Guid("e1863474-f4ae-c7e2-12bb-a8f909512da9"), "http://grant.name/generic/mountains/administrator", new TimeSpan(0, 0, 2, 38, 0), "Approved", "Use the bluetooth" },
                    { new Guid("a17d436d-dc63-701c-a144-250db718c92d"), "Rustic Metal Tuna", "http://martina.info/buckinghamshire/models", new Guid("62974f26-824a-80f7-bdb5-31fe456909ca"), "https://laurence.biz/application/sky-blue/circles", new TimeSpan(0, 0, 2, 34, 0), "Pending", "We need to" },
                    { new Guid("a27e6baf-f99d-2b63-97e5-dc0f34f8b90d"), "Licensed Rubber Keyboard", "https://beryl.biz/deposit/practical/designer", new Guid("e1863474-f4ae-c7e2-12bb-a8f909512da9"), "https://micaela.info/tan/invoice/cross-platform", new TimeSpan(0, 0, 2, 57, 0), "Rejected", "hacking the hard" },
                    { new Guid("ab7c1839-8897-6c26-93a0-e6cc79efabf5"), "Sleek Cotton Pants", "https://buddy.name/cape/re-contextualized/bedfords", new Guid("0e51d9f0-3e16-1570-8751-8bfcad3c76b7"), "https://eudora.com/palladium/bypassing", new TimeSpan(0, 0, 3, 30, 0), "Pending", "I'll transmit the" },
                    { new Guid("ad87cb4c-b697-9659-282f-e029761f4b43"), "Incredible Rubber Chair", "http://jorge.net/integration/digital", new Guid("de35e4ee-1a3c-5790-7777-f1ec1069e422"), "http://elise.biz/capacity/e-enable/branding", new TimeSpan(0, 0, 2, 47, 0), "Pending", "hacking the driver" },
                    { new Guid("ad9936d9-6bfe-3313-766b-27fa059da01a"), "Unbranded Cotton Pants", "https://zakary.org/automotive/automotive/extensibl", new Guid("062f3c05-dd11-1323-10db-7e8ac0b8ef7e"), "https://ursula.com/dynamic/wisconsin", new TimeSpan(0, 0, 2, 58, 0), "Rejected", "parsing the program" },
                    { new Guid("b3340d63-20d7-59d5-d86f-81411edf23b1"), "Handcrafted Cotton Chicken", "http://vaughn.name/synergized", new Guid("1e2c23c9-1e0f-d13a-4cac-27078dac190f"), "http://virgil.name/credit-card-account/jewelery-ba", new TimeSpan(0, 0, 2, 58, 0), "Rejected", "I'll back up" },
                    { new Guid("b5c6322b-1449-75de-cb84-9e21e9765574"), "Handmade Frozen Shoes", "http://shany.com/savings-account", new Guid("65ff82bb-8d09-8e6c-0f2b-c4d489d94086"), "http://duane.org/senegal/payment", new TimeSpan(0, 0, 3, 16, 0), "Rejected", "If we back" },
                    { new Guid("b6a4d1f1-855b-265b-2974-26e820a54cb5"), "Refined Rubber Gloves", "http://robin.com/maine/malaysian-ringgit/reverse-e", new Guid("1c8575f0-6194-339d-ad3e-2e7c3866a80f"), "https://tate.info/frozen", new TimeSpan(0, 0, 3, 9, 0), "Rejected", "If we index" },
                    { new Guid("b71bd510-8c6f-b431-7029-458a8a8cebf8"), "Ergonomic Rubber Bike", "https://vergie.biz/engineer/cambridgeshire/gorgeou", new Guid("49bb0990-7c20-0dcf-fce5-3793219f6047"), "https://eli.org/investment-account", new TimeSpan(0, 0, 3, 10, 0), "Rejected", "I'll generate the" },
                    { new Guid("b8d0d8cf-6880-b9b1-d3d6-58fb9cd313cc"), "Fantastic Cotton Bacon", "https://lessie.com/identity/uic-franc", new Guid("7775e280-c280-eecf-54f4-31fbbf49b93b"), "https://annette.info/reduced/direct/sdd", new TimeSpan(0, 0, 3, 3, 0), "Rejected", "Use the haptic" },
                    { new Guid("ba807973-37f9-1a08-34da-036c6c2415a6"), "Awesome Metal Salad", "http://ansel.com/jordanian-dinar/fantastic-frozen-", new Guid("eb5aa860-01f1-f11d-eb28-7b3747c1dca7"), "http://llewellyn.com/alarm/incredible", new TimeSpan(0, 0, 2, 55, 0), "Approved", "The SSL array" },
                    { new Guid("c014c71b-e04c-4d8a-7d16-05175b8aa849"), "Sleek Rubber Tuna", "https://jimmy.com/cambridgeshire", new Guid("7775e280-c280-eecf-54f4-31fbbf49b93b"), "http://troy.info/licensed", new TimeSpan(0, 0, 3, 12, 0), "Pending", "If we input" },
                    { new Guid("c42c0a0b-dad0-1e10-67af-1cf953b57d54"), "Gorgeous Plastic Computer", "http://aryanna.net/systematic", new Guid("e1863474-f4ae-c7e2-12bb-a8f909512da9"), "https://gladyce.com/buckinghamshire/licensed-metal", new TimeSpan(0, 0, 3, 5, 0), "Pending", "Use the bluetooth" },
                    { new Guid("c6459f8d-0f9b-fc61-7450-ae93ca342545"), "Handmade Wooden Bacon", "https://edmund.biz/fantastic-wooden-bike/collabora", new Guid("f4c5bb92-c504-dc74-c969-fbb76ae50f7e"), "http://donavon.info/berkshire", new TimeSpan(0, 0, 2, 44, 0), "Rejected", "I'll navigate the" },
                    { new Guid("cc8cadaa-e43f-ffe9-3681-8fb974863329"), "Unbranded Fresh Chair", "https://dakota.com/global/customized", new Guid("455357b3-ab37-7d3b-8ddd-aa4a9b035760"), "https://selmer.info/intuitive/handmade/ways", new TimeSpan(0, 0, 3, 16, 0), "Approved", "Use the solid" },
                    { new Guid("d2374f04-9e73-78b2-384f-6b03ecda0971"), "Rustic Cotton Cheese", "https://danielle.com/gorgeous-concrete-pizza/cotto", new Guid("89d22fe4-5532-ac42-0f6e-976e2e92da05"), "https://haylie.com/hard-drive", new TimeSpan(0, 0, 3, 17, 0), "Approved", "The JBOD protocol" },
                    { new Guid("db57426d-7dfc-e236-a7d9-6d674eca1e00"), "Gorgeous Soft Mouse", "http://alycia.org/invoice/rustic-granite-table/fro", new Guid("17f3f721-c6c8-7b79-2791-0c615bb1d678"), "http://connie.info/handcrafted", new TimeSpan(0, 0, 3, 13, 0), "Pending", "You can't compress" },
                    { new Guid("e2206501-0507-ad19-1fa6-92a25a894be4"), "Handmade Steel Pizza", "http://destinee.name/borders/3rd-generation", new Guid("3a4637ab-0383-947a-860b-598de7e62046"), "https://catherine.name/metal", new TimeSpan(0, 0, 3, 7, 0), "Approved", "Try to quantify" },
                    { new Guid("e22a1e63-225b-2c57-5d0f-f30e57707a44"), "Rustic Metal Cheese", "http://schuyler.biz/checking-account/navigate", new Guid("9c2b1595-45f8-672e-e24d-46b081cda8ed"), "https://myron.info/ib/transmitting/unbranded", new TimeSpan(0, 0, 3, 4, 0), "Rejected", "I'll input the" },
                    { new Guid("e43911ca-37bb-948a-4105-54fa3f0057d4"), "Handmade Granite Tuna", "http://bethel.org/incredible/hub", new Guid("552d18c2-86b9-4773-0253-becbc4f9f3a7"), "http://troy.org/dynamic/avon/glens", new TimeSpan(0, 0, 3, 13, 0), "Approved", "Try to copy" },
                    { new Guid("e44b8d7d-6053-d09a-9089-c57b79d0263d"), "Incredible Metal Cheese", "https://betty.name/green/canyon", new Guid("2349b3e1-f845-5b61-fa8e-fbef8c8a9b57"), "http://angel.biz/director", new TimeSpan(0, 0, 2, 37, 0), "Approved", "I'll reboot the" },
                    { new Guid("e52b371c-7969-8bd6-9292-dc0a828fadfc"), "Practical Soft Mouse", "https://chaya.biz/system/high-level/portals", new Guid("1e2c23c9-1e0f-d13a-4cac-27078dac190f"), "https://marcella.com/scale/liaison", new TimeSpan(0, 0, 2, 58, 0), "Approved", "You can't input" },
                    { new Guid("e55730a3-0c67-81e5-5146-5953901790b1"), "Rustic Soft Bacon", "https://della.com/future-proofed/maine/hardware", new Guid("1e2c23c9-1e0f-d13a-4cac-27078dac190f"), "http://mayra.net/group/incredible-wooden-chair/vir", new TimeSpan(0, 0, 3, 13, 0), "Approved", "Use the redundant" },
                    { new Guid("e6b05823-3d92-e472-0a39-a79b2db67e32"), "Handmade Soft Pants", "https://ardella.com/plain", new Guid("d922e44d-ba77-e400-0a2a-26212685a3c3"), "http://miracle.info/buckinghamshire/grocery--healt", new TimeSpan(0, 0, 3, 19, 0), "Pending", "If we index" },
                    { new Guid("e9c98cc7-2c43-1fe3-5aa0-844c2cc88d46"), "Gorgeous Fresh Bike", "http://rhett.name/avon/refined-fresh-soap", new Guid("e1863474-f4ae-c7e2-12bb-a8f909512da9"), "https://emanuel.biz/automotive--industrial/front-l", new TimeSpan(0, 0, 3, 28, 0), "Approved", "Try to synthesize" },
                    { new Guid("eb9119c1-0591-76db-d533-fb7ff83db8d7"), "Rustic Cotton Car", "http://urban.info/white/shoes/navigate", new Guid("062f3c05-dd11-1323-10db-7e8ac0b8ef7e"), "http://golden.org/json/zero-administration/unbrand", new TimeSpan(0, 0, 2, 39, 0), "Pending", "You can't input" },
                    { new Guid("ed850750-b467-60a3-2a31-ea7144c2d9ff"), "Awesome Wooden Towels", "http://johanna.com/portugal/backing-up/algorithm", new Guid("de35e4ee-1a3c-5790-7777-f1ec1069e422"), "https://wava.biz/points", new TimeSpan(0, 0, 3, 17, 0), "Pending", "The AGP monitor" },
                    { new Guid("ee0af058-4172-9e4b-6201-aa262ab552db"), "Tasty Soft Ball", "http://kendra.com/avon", new Guid("0e51d9f0-3e16-1570-8751-8bfcad3c76b7"), "http://susan.info/quality/rustic/senior", new TimeSpan(0, 0, 3, 28, 0), "Pending", "If we connect" },
                    { new Guid("f2662437-137a-a83d-f1b4-eed702ed3ee9"), "Intelligent Plastic Mouse", "http://jayda.biz/producer/florida", new Guid("de35e4ee-1a3c-5790-7777-f1ec1069e422"), "http://xzavier.info/oval/loop", new TimeSpan(0, 0, 2, 30, 0), "Approved", "You can't synthesize" },
                    { new Guid("f3674074-5e5a-886b-dd65-7ce998dbdafd"), "Practical Fresh Table", "https://quentin.name/cultivate/open-source", new Guid("17f3f721-c6c8-7b79-2791-0c615bb1d678"), "https://damon.net/distributed", new TimeSpan(0, 0, 2, 46, 0), "Rejected", "If we compress" },
                    { new Guid("f829be8f-25ac-9d2b-cb3b-20f4ec2fea70"), "Handmade Concrete Sausages", "http://randal.net/deploy/principal/buckinghamshire", new Guid("28a25f0e-dfa5-dc8a-9ec7-db94ad90e67d"), "http://rosanna.com/compress", new TimeSpan(0, 0, 2, 55, 0), "Approved", "Try to connect" },
                    { new Guid("fc76d17a-00a1-1c5e-24db-ca0bdacac16f"), "Handmade Cotton Salad", "https://javonte.info/invoice/summit/plastic", new Guid("17f3f721-c6c8-7b79-2791-0c615bb1d678"), "http://michaela.org/way/universal/integrate", new TimeSpan(0, 0, 3, 3, 0), "Pending", "We need to" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("022f284d-5a3c-9a21-099f-969d11025cb4"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("088c113c-8693-77fa-1d2e-e1848b144d13"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("0b585d74-a7bb-c43b-17b1-a10f472c160b"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("0e8d697f-5ecd-f720-05c3-81f37be64927"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("1063b3e8-eea5-d272-8e87-504cfab6fd4d"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("11b45ed3-d583-15a1-244e-c799f1763d8f"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("1318f97c-c47e-402a-149d-783b6a408879"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("148937f1-c71a-6c7f-a7f2-1e90f1863c07"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("167db078-b22a-b972-aac9-6fcdeb867bc8"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("1f08199d-a85b-6e60-7053-bd6c2b417202"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("23631539-7a4e-f78c-731e-37254e0c34ed"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("2483b133-f373-d74e-c183-e57bc4e5d39c"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("2f20d533-d392-3326-6359-c0f6e0c76970"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("3348964e-f999-a007-d47b-177c65e966cb"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("3705369e-c4cd-d022-ab94-e320ee79b812"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("3a33e040-6b33-76c2-224b-5fac1d9f5a2e"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("3a8e96f9-3bd7-3dd8-50fd-a9c192cfad91"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("3b341fed-0782-7b8b-961c-0d8be4500dd9"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("3fe77a9a-553a-af5d-317f-10bdc02e98ba"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("40d741bf-6c7a-e3ed-748a-1217fdfd82d9"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("42252606-3838-6661-2f2c-740a403a2251"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("43baf9ce-cb90-e502-f1ac-858f3e9c4725"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("465b6b27-86c7-677c-6e41-d314447f6aea"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("4778f9be-b316-d851-974d-12c194e3cfa1"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("4d46c271-12f1-9b0d-4af3-0f3e5e101ed8"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("4d6356d5-b961-d6a4-6a7f-72b157003151"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("4f30f008-936c-0edb-662e-04409ea576ef"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("51617a13-1e5a-44c6-6eac-6fcb0cfc319f"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("53a0e799-d7a7-7a11-0e03-2921ee510b47"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("55e4fe5c-f973-8cd1-6ea0-741673ef3854"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("581db257-4981-f568-789a-4d1f2b834f73"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("58cfeb2d-c95e-dd9f-dc46-974971c33ad5"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("58f4d901-224e-1c87-e5b8-839472ec0cf1"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("5900c162-c7b7-3d55-8fe7-03fedbd0a46c"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("595fa0b3-bcbf-4df1-45b8-98461c1dde97"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("5b299bde-b51a-ebf6-81ae-007690fbda39"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("5d1c5115-6b08-3e51-1e03-1a7c77f0c507"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("60d4c70e-37e7-694d-d953-d12191be06fd"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("6117c78d-1be1-555f-71ec-9fe16fe92044"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("619b7f7c-a3be-acfe-4e02-ae397647e685"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("61e8f7b1-40d2-4044-b7ba-d9752184f499"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("64011a1c-05d4-6451-efe8-513efff6857a"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("65b36746-5527-ce55-f7d6-01f57e43f2b8"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("6610b3c3-78d8-4121-9e1e-94c5ab66b4f8"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("66d79c37-a06d-cafb-c877-118805714079"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("6a225c33-5aaa-a58f-42c7-e5c437955d17"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("6f267ef7-fb91-6c26-9fed-85d09301ea22"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("72e500c7-0b3e-3660-5e12-76430aaef98e"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("74aff791-59fa-2e7a-afad-17d8e37fa2a1"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("75809677-9813-2a27-8cab-0412577b3a90"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("7b9c69f6-74c5-d8a6-6143-707330f453ba"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("7d614f37-cc13-498f-18e4-ae58535eac40"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("7e8afab5-6838-09c8-0230-974927f9ddd0"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("84761631-1502-2b18-1dee-7bb4ffb78d86"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("86347e32-1e93-2457-8b9d-ada993ffafbe"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("8670a9ee-efab-ea25-5684-97bf26e6fe29"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("8716f5b5-b41a-df02-3578-66a550419ea6"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("88a4e608-48e1-4956-a344-3b9755d21ded"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("8a4b59b0-69cc-6bfc-070e-6ddf37a5c205"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("8b3a8081-f889-ef69-6468-0b1a3f63f3ef"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("93ea74c1-1ec6-ffa1-717a-50cd2e3ccef1"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("a17d436d-dc63-701c-a144-250db718c92d"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("a27e6baf-f99d-2b63-97e5-dc0f34f8b90d"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("ab7c1839-8897-6c26-93a0-e6cc79efabf5"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("ad87cb4c-b697-9659-282f-e029761f4b43"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("ad9936d9-6bfe-3313-766b-27fa059da01a"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("b3340d63-20d7-59d5-d86f-81411edf23b1"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("b5c6322b-1449-75de-cb84-9e21e9765574"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("b6a4d1f1-855b-265b-2974-26e820a54cb5"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("b71bd510-8c6f-b431-7029-458a8a8cebf8"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("b8d0d8cf-6880-b9b1-d3d6-58fb9cd313cc"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("ba807973-37f9-1a08-34da-036c6c2415a6"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("c014c71b-e04c-4d8a-7d16-05175b8aa849"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("c42c0a0b-dad0-1e10-67af-1cf953b57d54"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("c6459f8d-0f9b-fc61-7450-ae93ca342545"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("cc8cadaa-e43f-ffe9-3681-8fb974863329"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("d2374f04-9e73-78b2-384f-6b03ecda0971"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("db57426d-7dfc-e236-a7d9-6d674eca1e00"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e2206501-0507-ad19-1fa6-92a25a894be4"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e22a1e63-225b-2c57-5d0f-f30e57707a44"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e43911ca-37bb-948a-4105-54fa3f0057d4"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e44b8d7d-6053-d09a-9089-c57b79d0263d"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e52b371c-7969-8bd6-9292-dc0a828fadfc"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e55730a3-0c67-81e5-5146-5953901790b1"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e6b05823-3d92-e472-0a39-a79b2db67e32"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e9c98cc7-2c43-1fe3-5aa0-844c2cc88d46"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("eb9119c1-0591-76db-d533-fb7ff83db8d7"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("ed850750-b467-60a3-2a31-ea7144c2d9ff"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("ee0af058-4172-9e4b-6201-aa262ab552db"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("f2662437-137a-a83d-f1b4-eed702ed3ee9"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("f3674074-5e5a-886b-dd65-7ce998dbdafd"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("f829be8f-25ac-9d2b-cb3b-20f4ec2fea70"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("fc76d17a-00a1-1c5e-24db-ca0bdacac16f"));

            migrationBuilder.DropColumn(
                name: "AudioUrl",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "CoverUrl",
                table: "Songs");

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Album", "AuthorId", "Duration", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("02b06f85-9869-6388-0d34-b3d720d559d8"), "Sleek Frozen Tuna", new Guid("d14d8488-392a-c224-376c-9545523ef9d7"), new TimeSpan(0, 0, 2, 43, 0), "Approved", "Try to parse" },
                    { new Guid("0507e220-ad19-a61f-92a2-5a894be47e4b"), "Refined Concrete Soap", new Guid("1e2c23c9-1e0f-d13a-4cac-27078dac190f"), new TimeSpan(0, 0, 2, 50, 0), "Approved", "Use the cross-platform" },
                    { new Guid("073c86f1-6eb0-eb49-eaca-0cd4c23ed24b"), "Unbranded Concrete Soap", new Guid("eb5aa860-01f1-f11d-eb28-7b3747c1dca7"), new TimeSpan(0, 0, 3, 16, 0), "Pending", "Try to input" },
                    { new Guid("0bf2a18f-2f80-44b4-61b3-6d437da163dc"), "Gorgeous Steel Shoes", new Guid("28a25f0e-dfa5-dc8a-9ec7-db94ad90e67d"), new TimeSpan(0, 0, 2, 42, 0), "Approved", "I'll navigate the" },
                    { new Guid("10284c55-8087-37d4-244f-ce057d8d4be4"), "Small Steel Keyboard", new Guid("552d18c2-86b9-4773-0253-becbc4f9f3a7"), new TimeSpan(0, 0, 3, 4, 0), "Rejected", "I'll quantify the" },
                    { new Guid("116011ab-1877-f674-8353-b2570830bef9"), "Rustic Soft Sausages", new Guid("89d22fe4-5532-ac42-0f6e-976e2e92da05"), new TimeSpan(0, 0, 3, 23, 0), "Approved", "We need to" },
                    { new Guid("1177c8ca-0588-4071-7959-d630241c53ee"), "Generic Rubber Keyboard", new Guid("17f3f721-c6c8-7b79-2791-0c615bb1d678"), new TimeSpan(0, 0, 2, 59, 0), "Rejected", "You can't copy" },
                    { new Guid("137af266-a83d-b4f1-eed7-02ed3ee98ba8"), "Rustic Cotton Chair", new Guid("17f3f721-c6c8-7b79-2791-0c615bb1d678"), new TimeSpan(0, 0, 3, 9, 0), "Rejected", "If we navigate" },
                    { new Guid("15c759a2-cb6d-abf1-69b7-79b4bde1c024"), "Practical Soft Pants", new Guid("eb5aa860-01f1-f11d-eb28-7b3747c1dca7"), new TimeSpan(0, 0, 2, 58, 0), "Pending", "I'll quantify the" },
                    { new Guid("1705167d-8a5b-49a8-a548-23eae9cd03f4"), "Refined Fresh Hat", new Guid("a8c435d2-a3ab-8813-de0e-ac5fab782189"), new TimeSpan(0, 0, 2, 30, 0), "Pending", "The SMTP microchip" },
                    { new Guid("17c50ad9-0a56-0a8d-828f-09374f617d13"), "Gorgeous Metal Computer", new Guid("fa333e3f-3b75-cd02-7ce7-2b77e1e700a2"), new TimeSpan(0, 0, 3, 4, 0), "Approved", "The EXE microchip" },
                    { new Guid("1b81abfa-6b29-94f3-eb1d-5bc0c0442262"), "Handmade Frozen Salad", new Guid("d82de857-522c-c556-b013-d78f474f9287"), new TimeSpan(0, 0, 3, 23, 0), "Approved", "I'll index the" },
                    { new Guid("1f04d275-f058-ee0a-7241-4b9e6201aa26"), "Generic Wooden Mouse", new Guid("de35e4ee-1a3c-5790-7777-f1ec1069e422"), new TimeSpan(0, 0, 3, 29, 0), "Rejected", "You can't quantify" },
                    { new Guid("1f192cb4-af67-db3c-e9fe-67f000fae4ac"), "Tasty Wooden Computer", new Guid("49bb0990-7c20-0dcf-fce5-3793219f6047"), new TimeSpan(0, 0, 3, 10, 0), "Pending", "copying the transmitter" },
                    { new Guid("225be22a-2c57-0f5d-f30e-57707a44e208"), "Licensed Soft Towels", new Guid("d9ace6d5-3d01-ab77-48e3-ab1f26334575"), new TimeSpan(0, 0, 2, 51, 0), "Approved", "You can't calculate" },
                    { new Guid("2a38270f-6071-1631-7684-0215182b1dee"), "Practical Cotton Salad", new Guid("62974f26-824a-80f7-bdb5-31fe456909ca"), new TimeSpan(0, 0, 2, 32, 0), "Rejected", "I'll calculate the" },
                    { new Guid("2c0d2442-82c0-9220-b1c3-5bd861474e96"), "Ergonomic Plastic Car", new Guid("8717fef3-a26b-e361-ca4b-173b514b256b"), new TimeSpan(0, 0, 3, 6, 0), "Approved", "Use the digital" },
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
                    { new Guid("470b51ee-0123-a7b6-d38e-0cd6923740c3"), "Awesome Steel Bike", new Guid("455357b3-ab37-7d3b-8ddd-aa4a9b035760"), new TimeSpan(0, 0, 3, 17, 0), "Pending", "If we parse" },
                    { new Guid("495648e1-44a3-973b-55d2-1ded22676e00"), "Awesome Plastic Tuna", new Guid("7fc71309-41a9-f4e3-287b-8345ecad8131"), new TimeSpan(0, 0, 3, 14, 0), "Approved", "You can't parse" },
                    { new Guid("4d60d783-8172-76a2-6c13-5cf27f1d9411"), "Small Frozen Bike", new Guid("b471b00d-f7ee-acf9-e226-1fd24d76e93c"), new TimeSpan(0, 0, 3, 9, 0), "Pending", "We need to" },
                    { new Guid("51223a40-c8eb-e9c6-1d02-0ca9ca47725a"), "Generic Concrete Tuna", new Guid("e1863474-f4ae-c7e2-12bb-a8f909512da9"), new TimeSpan(0, 0, 2, 56, 0), "Pending", "You can't override" },
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
                    { new Guid("b641bdf7-7844-422f-6aaa-47f0a24c7379"), "Gorgeous Steel Hat", new Guid("0e51d9f0-3e16-1570-8751-8bfcad3c76b7"), new TimeSpan(0, 0, 3, 12, 0), "Rejected", "The SMTP application" },
                    { new Guid("b697ad87-9659-2f28-e029-761f4b433a47"), "Small Cotton Ball", new Guid("fa333e3f-3b75-cd02-7ce7-2b77e1e700a2"), new TimeSpan(0, 0, 3, 6, 0), "Rejected", "You can't calculate" },
                    { new Guid("bca93494-9f15-1b46-e23c-118c089386fa"), "Practical Plastic Soap", new Guid("552d18c2-86b9-4773-0253-becbc4f9f3a7"), new TimeSpan(0, 0, 2, 45, 0), "Pending", "If we synthesize" },
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
                    { new Guid("db774e40-3592-6462-f2c0-a3e46d4257db"), "Handcrafted Metal Keyboard", new Guid("7775e280-c280-eecf-54f4-31fbbf49b93b"), new TimeSpan(0, 0, 2, 44, 0), "Rejected", "I'll program the" },
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
    }
}
