using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vladify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class removeStandardValueInUrls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("0d5d93d1-101a-ec67-496f-9c2b0bd9efad"));

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
                keyValue: new Guid("13f19850-5b4e-dc97-819d-3cabbceaf6f1"));

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
                keyValue: new Guid("46ea0196-d84b-e5c7-82ef-ce6dd0e09efd"));

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
                keyValue: new Guid("5241daea-7eae-d980-6c8d-3fff7a859c8d"));

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
                keyValue: new Guid("56098df8-fb53-be2b-1141-30f15deaaf2a"));

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
                keyValue: new Guid("b5fe127a-9183-e227-c5e3-eeef27e28287"));

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

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("9fdea678-4a21-6d13-4185-9484e1a21ecd"),
                columns: new[] { "AudioUrl", "CoverUrl", "Status" },
                values: new object[] { "http://marlon.org/money-market-account/metal/globa", "http://alvera.name/scalable", "Approved" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Album", "AudioUrl", "AuthorId", "CoverUrl", "Duration", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("02847616-1815-1d2b-ee7b-b4ffb78d8645"), "Fantastic Granite Tuna", "https://dejon.info/paradigm/open-source", new Guid("de35e4ee-1a3c-5790-7777-f1ec1069e422"), "http://dayana.info/tunnel/tennessee/concept", new TimeSpan(0, 0, 3, 11, 0), "Pending", "You can't program" },
                    { new Guid("0cf8855d-56b9-6e58-c1fb-d9f1d1a4b65b"), "Generic Metal Salad", "https://seamus.info/spring", new Guid("62974f26-824a-80f7-bdb5-31fe456909ca"), "https://furman.net/kansas/handcrafted/usb", new TimeSpan(0, 0, 2, 57, 0), "Approved", "synthesizing the transmitter" },
                    { new Guid("0fb79301-e525-e361-79a6-4bef698cd3b3"), "Gorgeous Plastic Pizza", "http://cary.com/driver", new Guid("552d18c2-86b9-4773-0253-becbc4f9f3a7"), "http://bethany.org/intelligent/violet", new TimeSpan(0, 0, 3, 0, 0), "Approved", "The GB card" },
                    { new Guid("13758096-2798-8c2a-ab04-12577b3a903a"), "Intelligent Cotton Pants", "https://kip.biz/purple/cambridgeshire/morph", new Guid("d922e44d-ba77-e400-0a2a-26212685a3c3"), "https://deonte.net/alarm/plaza/networks", new TimeSpan(0, 0, 2, 37, 0), "Approved", "synthesizing the array" },
                    { new Guid("15399ce7-2363-7a4e-8cf7-731e37254e0c"), "Sleek Cotton Soap", "https://carter.org/transmit/namibia-dollar", new Guid("1c8575f0-6194-339d-ad3e-2e7c3866a80f"), "https://orie.com/navigating/licensed/algerian-dina", new TimeSpan(0, 0, 3, 1, 0), "Approved", "Use the digital" },
                    { new Guid("164778f9-51b3-97d8-4d12-c194e3cfa18d"), "Licensed Soft Table", "https://marlee.name/terrace/assurance", new Guid("062f3c05-dd11-1323-10db-7e8ac0b8ef7e"), "https://stefanie.net/interactions", new TimeSpan(0, 0, 3, 24, 0), "Approved", "If we hack" },
                    { new Guid("1a0d5d93-6710-49ec-6f9c-2b0bd9efadf8"), "Small Frozen Sausages", "http://chris.info/optimize/white/local", new Guid("b471b00d-f7ee-acf9-e226-1fd24d76e93c"), "https://jazmyn.org/reboot/trail/reboot", new TimeSpan(0, 0, 3, 20, 0), "Approved", "Use the online" },
                    { new Guid("1a148937-7fc7-a76c-f21e-90f1863c07b0"), "Incredible Cotton Hat", "https://emmie.net/licensed", new Guid("fa333e3f-3b75-cd02-7ce7-2b77e1e700a2"), "http://christelle.name/maximized/auto-loan-account", new TimeSpan(0, 0, 2, 34, 0), "Approved", "I'll quantify the" },
                    { new Guid("1a8716f5-02b4-35df-7866-a550419ea657"), "Tasty Fresh Table", "http://kaleb.name/sleek-soft-mouse", new Guid("eb5aa860-01f1-f11d-eb28-7b3747c1dca7"), "https://philip.org/new-mexico/frozen", new TimeSpan(0, 0, 2, 40, 0), "Rejected", "Use the auxiliary" },
                    { new Guid("2765b367-5555-f7ce-d601-f57e43f2b8e7"), "Licensed Frozen Bike", "http://paolo.name/virtual", new Guid("a8c435d2-a3ab-8813-de0e-ac5fab782189"), "http://jaylin.info/accounts", new TimeSpan(0, 0, 3, 20, 0), "Approved", "Try to connect" },
                    { new Guid("333a33e0-c26b-2276-4b5f-ac1d9f5a2e3c"), "Intelligent Cotton Chair", "http://arvid.com/mountains/optical/electronics--he", new Guid("89d22fe4-5532-ac42-0f6e-976e2e92da05"), "http://raheem.org/incredible/feed", new TimeSpan(0, 0, 3, 28, 0), "Rejected", "Try to reboot" },
                    { new Guid("3358e3a5-20d5-922f-d326-336359c0f6e0"), "Incredible Granite Fish", "http://gardner.biz/functionality/wall/function", new Guid("2349b3e1-f845-5b61-fa8e-fbef8c8a9b57"), "https://vilma.info/inverse/magnetic/hacking", new TimeSpan(0, 0, 2, 36, 0), "Pending", "Try to parse" },
                    { new Guid("349c6b37-0ab2-5115-1c5d-086b513e1e03"), "Handmade Metal Chair", "http://reynold.net/kenyan-shilling/synthesizing", new Guid("062f3c05-dd11-1323-10db-7e8ac0b8ef7e"), "http://emery.name/beauty-sports--jewelery/tennesse", new TimeSpan(0, 0, 3, 28, 0), "Pending", "We need to" },
                    { new Guid("387e8afa-c868-0209-3097-4927f9ddd08d"), "Sleek Steel Tuna", "http://hilton.net/withdrawal/bypassing/buckinghams", new Guid("17f3f721-c6c8-7b79-2791-0c615bb1d678"), "http://earlene.biz/summit/district/virtual", new TimeSpan(0, 0, 2, 51, 0), "Approved", "We need to" },
                    { new Guid("3a3fe77a-5d55-31af-7f10-bdc02e98ba98"), "Generic Steel Chips", "http://rhea.net/road/programmable/antarctica-the-t", new Guid("b471b00d-f7ee-acf9-e226-1fd24d76e93c"), "https://ibrahim.net/e-tailers/san-marino", new TimeSpan(0, 0, 3, 28, 0), "Approved", "The HDD array" },
                    { new Guid("3c271834-2606-4225-3838-61662f2c740a"), "Unbranded Steel Sausages", "http://asha.org/payment/alabama/park", new Guid("d9ace6d5-3d01-ab77-48e3-ab1f26334575"), "https://malika.info/forks", new TimeSpan(0, 0, 3, 9, 0), "Pending", "connecting the sensor" },
                    { new Guid("3c60f1dd-21bd-3004-501f-7c7f698d0ecd"), "Sleek Fresh Chicken", "https://lavina.biz/implement/gold/vermont", new Guid("ffd23d02-4eb5-4217-2b43-f9b46c4a45c7"), "http://elisabeth.name/pci", new TimeSpan(0, 0, 3, 10, 0), "Pending", "Try to index" },
                    { new Guid("3e72e500-600b-5e36-1276-430aaef98e88"), "Intelligent Cotton Keyboard", "https://karson.biz/georgia/orchid/investment-accou", new Guid("a8c435d2-a3ab-8813-de0e-ac5fab782189"), "http://zula.com/garden-beauty--jewelery", new TimeSpan(0, 0, 3, 4, 0), "Approved", "hacking the program" },
                    { new Guid("4128ea39-94d8-dd68-6537-f86fc9aaad8c"), "Fantastic Rubber Pants", "https://maxine.org/home-loan-account/scsi", new Guid("28a25f0e-dfa5-dc8a-9ec7-db94ad90e67d"), "https://juston.biz/backing-up/producer/home-loan-a", new TimeSpan(0, 0, 3, 24, 0), "Rejected", "bypassing the firewall" },
                    { new Guid("43012557-3290-a4eb-563d-b8cc47104671"), "Handcrafted Frozen Bacon", "https://breana.org/grove/cotton/personal-loan-acco", new Guid("9c2b1595-45f8-672e-e24d-46b081cda8ed"), "https://dayana.net/scale/fresh", new TimeSpan(0, 0, 2, 49, 0), "Approved", "If we override" },
                    { new Guid("43e9c98c-e32c-5a1f-a084-4c2cc88d46b8"), "Unbranded Concrete Tuna", "http://rhett.name/avon/refined-fresh-soap", new Guid("89d22fe4-5532-ac42-0f6e-976e2e92da05"), "https://emanuel.biz/automotive--industrial/front-l", new TimeSpan(0, 0, 2, 50, 0), "Approved", "If we compress" },
                    { new Guid("47f1877c-b234-bf36-9973-883bbade9b29"), "Sleek Wooden Car", "https://archibald.org/synergize/ssl", new Guid("de35e4ee-1a3c-5790-7777-f1ec1069e422"), "http://lou.net/rustic/handmade-wooden-sausages", new TimeSpan(0, 0, 3, 27, 0), "Pending", "Use the optical" },
                    { new Guid("48964e47-9933-07f9-a0d4-7b177c65e966"), "Generic Rubber Soap", "https://zelma.com/concrete/accounts/superstructure", new Guid("17f3f721-c6c8-7b79-2791-0c615bb1d678"), "http://carlos.com/corner/fault-tolerant/deposit", new TimeSpan(0, 0, 2, 36, 0), "Rejected", "We need to" },
                    { new Guid("4cc014c7-8ae0-7d4d-1605-175b8aa849a5"), "Generic Metal Chicken", "https://jimmy.com/cambridgeshire", new Guid("7775e280-c280-eecf-54f4-31fbbf49b93b"), "http://troy.info/licensed", new TimeSpan(0, 0, 2, 42, 0), "Pending", "If we connect" },
                    { new Guid("4e58f4d9-8722-e51c-b883-9472ec0cf175"), "Practical Fresh Table", "http://hazel.org/personal-loan-account/bedfordshir", new Guid("28a25f0e-dfa5-dc8a-9ec7-db94ad90e67d"), "https://rosanna.com/program", new TimeSpan(0, 0, 3, 7, 0), "Approved", "The TCP alarm" },
                    { new Guid("5356098d-2bfb-11be-4130-f15deaaf2a9f"), "Licensed Metal Hat", "http://elisabeth.biz/kids--garden/uganda-shilling/", new Guid("1e2c23c9-1e0f-d13a-4cac-27078dac190f"), "https://adolph.biz/solomon-islands-dollar/cyan", new TimeSpan(0, 0, 2, 47, 0), "Pending", "I'll synthesize the" },
                    { new Guid("535a278f-807f-0ba6-0165-20e2070519ad"), "Handcrafted Steel Pants", "https://anita.org/engage", new Guid("28a25f0e-dfa5-dc8a-9ec7-db94ad90e67d"), "http://jerod.name/money-market-account", new TimeSpan(0, 0, 3, 5, 0), "Pending", "We need to" },
                    { new Guid("53e44b8d-9a60-90d0-89c5-7b79d0263d0e"), "Handcrafted Soft Bacon", "https://betty.name/green/canyon", new Guid("b471b00d-f7ee-acf9-e226-1fd24d76e93c"), "http://angel.biz/director", new TimeSpan(0, 0, 3, 0, 0), "Approved", "Use the open-source" },
                    { new Guid("5a3f02b3-6fa3-e7d8-43f3-7c7f9b61bea3"), "Awesome Fresh Pizza", "https://una.com/holy-see-vatican-city-state/fantas", new Guid("062f3c05-dd11-1323-10db-7e8ac0b8ef7e"), "http://selmer.name/tonga/singapore-dollar", new TimeSpan(0, 0, 3, 23, 0), "Rejected", "Try to connect" },
                    { new Guid("5a51617a-c61e-6e44-ac6f-cb0cfc319fc4"), "Gorgeous Cotton Chair", "http://ernie.info/bleeding-edge", new Guid("f4c5bb92-c504-dc74-c969-fbb76ae50f7e"), "http://madelyn.com/portals/executive/intelligent-g", new TimeSpan(0, 0, 2, 50, 0), "Approved", "You can't bypass" },
                    { new Guid("5af36740-6b5e-dd88-657c-e998dbdafd1c"), "Refined Cotton Hat", "https://quentin.name/cultivate/open-source", new Guid("d922e44d-ba77-e400-0a2a-26212685a3c3"), "https://damon.net/distributed", new TimeSpan(0, 0, 3, 22, 0), "Approved", "If we connect" },
                    { new Guid("5ee2bbd9-a5df-a998-471f-62f50474631e"), "Incredible Fresh Table", "https://okey.com/national/http/optimize", new Guid("0e51d9f0-3e16-1570-8751-8bfcad3c76b7"), "http://libby.com/input/street", new TimeSpan(0, 0, 3, 20, 0), "Rejected", "If we quantify" },
                    { new Guid("630acb88-0a1d-532f-d5c5-be26165ec3b3"), "Rustic Granite Computer", "https://brandt.org/hardware", new Guid("9c2b1595-45f8-672e-e24d-46b081cda8ed"), "https://malvina.name/rubber/cross-platform/illinoi", new TimeSpan(0, 0, 2, 39, 0), "Approved", "generating the sensor" },
                    { new Guid("63a17d43-1cdc-a170-4425-0db718c92d81"), "Handcrafted Metal Shoes", "http://martina.info/buckinghamshire/models", new Guid("1c8575f0-6194-339d-ad3e-2e7c3866a80f"), "https://laurence.biz/application/sky-blue/circles", new TimeSpan(0, 0, 2, 31, 0), "Pending", "Use the open-source" },
                    { new Guid("67e55730-e50c-5181-4659-53901790b11f"), "Handmade Soft Pants", "https://della.com/future-proofed/maine/hardware", new Guid("7fc71309-41a9-f4e3-287b-8345ecad8131"), "http://mayra.net/group/incredible-wooden-chair/vir", new TimeSpan(0, 0, 3, 7, 0), "Pending", "I'll hack the" },
                    { new Guid("67ed8507-a3b4-2a60-31ea-7144c2d9ffca"), "Rustic Rubber Table", "http://johanna.com/portugal/backing-up/algorithm", new Guid("2349b3e1-f845-5b61-fa8e-fbef8c8a9b57"), "https://wava.biz/points", new TimeSpan(0, 0, 2, 43, 0), "Pending", "Try to generate" },
                    { new Guid("69e52b37-d679-928b-92dc-0a828fadfc0f"), "Handmade Wooden Pants", "https://chaya.biz/system/high-level/portals", new Guid("de35e4ee-1a3c-5790-7777-f1ec1069e422"), "https://marcella.com/scale/liaison", new TimeSpan(0, 0, 3, 10, 0), "Rejected", "We need to" },
                    { new Guid("6c4f30f0-db93-660e-2e04-409ea576efa8"), "Handcrafted Wooden Hat", "http://idella.name/handcrafted/soft/orchestrator", new Guid("17f3f721-c6c8-7b79-2791-0c615bb1d678"), "https://nikko.info/project/tanzania", new TimeSpan(0, 0, 3, 2, 0), "Rejected", "We need to" },
                    { new Guid("6c7ee117-978c-7fee-089f-8cd556634d61"), "Tasty Steel Cheese", "https://kenyatta.biz/mayotte/cross-platform/salmon", new Guid("1c8575f0-6194-339d-ad3e-2e7c3866a80f"), "http://laury.info/vermont/credit-card-account", new TimeSpan(0, 0, 2, 48, 0), "Rejected", "You can't reboot" },
                    { new Guid("6fb71bd5-318c-70b4-2945-8a8a8cebf891"), "Awesome Concrete Chair", "https://vergie.biz/engineer/cambridgeshire/gorgeou", new Guid("e1863474-f4ae-c7e2-12bb-a8f909512da9"), "https://eli.org/investment-account", new TimeSpan(0, 0, 3, 26, 0), "Pending", "If we bypass" },
                    { new Guid("72ee0af0-4b41-629e-01aa-262ab552dbf5"), "Handmade Plastic Bike", "http://kendra.com/avon", new Guid("89d22fe4-5532-ac42-0f6e-976e2e92da05"), "http://susan.info/quality/rustic/senior", new TimeSpan(0, 0, 2, 48, 0), "Pending", "Use the digital" },
                    { new Guid("732483b1-4ef3-c1d7-83e5-7bc4e5d39ccc"), "Unbranded Plastic Shirt", "http://lorna.com/texas/flats", new Guid("7775e280-c280-eecf-54f4-31fbbf49b93b"), "http://okey.net/wooden", new TimeSpan(0, 0, 2, 58, 0), "Pending", "If we compress" },
                    { new Guid("73d2374f-b29e-3878-4f6b-03ecda0971f2"), "Practical Soft Sausages", "https://danielle.com/gorgeous-concrete-pizza/cotto", new Guid("2349b3e1-f845-5b61-fa8e-fbef8c8a9b57"), "https://haylie.com/hard-drive", new TimeSpan(0, 0, 2, 59, 0), "Approved", "I'll override the" },
                    { new Guid("7a40d741-ed6c-74e3-8a12-17fdfd82d98f"), "Practical Soft Gloves", "https://edyth.name/representative/generating/effic", new Guid("062f3c05-dd11-1323-10db-7e8ac0b8ef7e"), "http://ulices.biz/usb", new TimeSpan(0, 0, 2, 34, 0), "Rejected", "I'll index the" },
                    { new Guid("7af26624-3d13-f1a8-b4ee-d702ed3ee98b"), "Incredible Wooden Table", "http://jayda.biz/producer/florida", new Guid("49bb0990-7c20-0dcf-fce5-3793219f6047"), "http://xzavier.info/oval/loop", new TimeSpan(0, 0, 3, 1, 0), "Approved", "If we override" },
                    { new Guid("7e1318f9-2ac4-1440-9d78-3b6a40887902"), "Practical Plastic Soap", "https://lesley.com/bandwidth/rubber", new Guid("455357b3-ab37-7d3b-8ddd-aa4a9b035760"), "https://myrl.name/idaho/granite", new TimeSpan(0, 0, 2, 30, 0), "Approved", "The XML port" },
                    { new Guid("7fcb0ab8-43e7-dd09-8967-b2d80b0a2cc4"), "Handmade Frozen Bacon", "https://jennie.org/new-jersey", new Guid("f4c5bb92-c504-dc74-c969-fbb76ae50f7e"), "http://donald.org/extended/generic/crescent", new TimeSpan(0, 0, 2, 53, 0), "Pending", "I'll calculate the" },
                    { new Guid("80b8d0d8-b168-d3b9-d658-fb9cd313cc9c"), "Practical Soft Chicken", "https://lessie.com/identity/uic-franc", new Guid("ffd23d02-4eb5-4217-2b43-f9b46c4a45c7"), "https://annette.info/reduced/direct/sdd", new TimeSpan(0, 0, 3, 15, 0), "Pending", "You can't navigate" },
                    { new Guid("81581db2-6849-78f5-9a4d-1f2b834f73d3"), "Handmade Steel Fish", "https://fatima.org/congolese-franc/arkansas", new Guid("7fc71309-41a9-f4e3-287b-8345ecad8131"), "http://gregg.info/channels", new TimeSpan(0, 0, 3, 8, 0), "Pending", "The GB feed" },
                    { new Guid("823b341f-8b07-967b-1c0d-8be4500dd903"), "Incredible Cotton Tuna", "http://kelly.net/synergized/virtual/texas", new Guid("fa333e3f-3b75-cd02-7ce7-2b77e1e700a2"), "https://erika.org/capacity", new TimeSpan(0, 0, 3, 19, 0), "Pending", "I'll connect the" },
                    { new Guid("8311b45e-a1d5-2415-4ec7-99f1763d8f0f"), "Incredible Plastic Cheese", "http://winfield.info/monitor/drive", new Guid("9c2b1595-45f8-672e-e24d-46b081cda8ed"), "http://karli.org/override", new TimeSpan(0, 0, 3, 0, 0), "Rejected", "The SDD firewall" },
                    { new Guid("837f88a2-0196-46ea-4bd8-c7e582efce6d"), "Rustic Fresh Fish", "http://zion.biz/granite/international", new Guid("0e51d9f0-3e16-1570-8751-8bfcad3c76b7"), "http://rodrigo.biz/generic-metal-cheese", new TimeSpan(0, 0, 2, 35, 0), "Approved", "You can't calculate" },
                    { new Guid("83b5fe12-2791-c5e2-e3ee-ef27e28287d1"), "Small Concrete Computer", "http://martina.net/css", new Guid("7fc71309-41a9-f4e3-287b-8345ecad8131"), "http://ali.com/sensor", new TimeSpan(0, 0, 3, 22, 0), "Rejected", "We need to" },
                    { new Guid("898b3a80-69f8-64ef-680b-1a3f63f3ef3e"), "Sleek Steel Bike", "https://tyreek.net/philippine-peso", new Guid("3a4637ab-0383-947a-860b-598de7e62046"), "https://lauriane.org/garden/consultant/bypassing", new TimeSpan(0, 0, 2, 48, 0), "Pending", "The COM pixel" },
                    { new Guid("8cca616f-878b-73af-9b0f-c11991eb9105"), "Intelligent Fresh Towels", "http://isadore.com/handcrafted/bricks-and-clicks", new Guid("17f3f721-c6c8-7b79-2791-0c615bb1d678"), "http://aaliyah.com/rustic-metal-mouse", new TimeSpan(0, 0, 2, 53, 0), "Rejected", "You can't hack" },
                    { new Guid("8ed2a6dc-ab6c-7d80-62c1-0059b7c7553d"), "Handcrafted Soft Hat", "https://stefan.info/sierra-leone/tasty-steel-shirt", new Guid("d82de857-522c-c556-b013-d78f474f9287"), "http://jamil.org/cohesive/proactive", new TimeSpan(0, 0, 3, 12, 0), "Approved", "I'll synthesize the" },
                    { new Guid("9043baf9-02cb-f1e5-ac85-8f3e9c4725ba"), "Awesome Metal Soap", "http://justina.biz/accountability/greens", new Guid("89d22fe4-5532-ac42-0f6e-976e2e92da05"), "http://santos.biz/tools--music/rustic-plastic-pizz", new TimeSpan(0, 0, 2, 48, 0), "Pending", "I'll back up" },
                    { new Guid("916f267e-26fb-9f6c-ed85-d09301ea229b"), "Rustic Cotton Computer", "http://easton.org/books", new Guid("1e2c23c9-1e0f-d13a-4cac-27078dac190f"), "http://bryon.info/soft/solutions/solution-oriented", new TimeSpan(0, 0, 3, 8, 0), "Rejected", "We need to" },
                    { new Guid("92e6b058-723d-0ae4-39a7-9b2db67e329a"), "Handmade Cotton Ball", "https://ardella.com/plain", new Guid("d82de857-522c-c556-b013-d78f474f9287"), "http://miracle.info/buckinghamshire/grocery--healt", new TimeSpan(0, 0, 2, 42, 0), "Pending", "I'll input the" },
                    { new Guid("9386347e-571e-8b24-9dad-a993ffafbe62"), "Handcrafted Concrete Chicken", "https://callie.net/awesome-frozen-bike", new Guid("17f3f721-c6c8-7b79-2791-0c615bb1d678"), "http://janice.biz/savings-account", new TimeSpan(0, 0, 3, 12, 0), "Pending", "If we synthesize" },
                    { new Guid("97ab7c18-2688-936c-a0e6-cc79efabf52a"), "Fantastic Plastic Mouse", "https://buddy.name/cape/re-contextualized/bedfords", new Guid("455357b3-ab37-7d3b-8ddd-aa4a9b035760"), "https://eudora.com/palladium/bypassing", new TimeSpan(0, 0, 2, 37, 0), "Pending", "Try to connect" },
                    { new Guid("97ad87cb-59b6-2896-2fe0-29761f4b433a"), "Generic Steel Table", "http://jorge.net/integration/digital", new Guid("062f3c05-dd11-1323-10db-7e8ac0b8ef7e"), "http://elise.biz/capacity/e-enable/branding", new TimeSpan(0, 0, 2, 33, 0), "Approved", "We need to" },
                    { new Guid("9da27e6b-63f9-972b-e5dc-0f34f8b90d75"), "Generic Wooden Tuna", "https://beryl.biz/deposit/practical/designer", new Guid("de35e4ee-1a3c-5790-7777-f1ec1069e422"), "https://micaela.info/tan/invoice/cross-platform", new TimeSpan(0, 0, 3, 29, 0), "Rejected", "I'll transmit the" },
                    { new Guid("a1fc76d1-5e00-241c-dbca-0bdacac16f97"), "Fantastic Fresh Hat", "https://javonte.info/invoice/summit/plastic", new Guid("ffd23d02-4eb5-4217-2b43-f9b46c4a45c7"), "http://michaela.org/way/universal/integrate", new TimeSpan(0, 0, 2, 33, 0), "Rejected", "The SAS program" },
                    { new Guid("a51063b3-72ee-8ed2-8750-4cfab6fd4dc4"), "Sleek Frozen Mouse", "http://rick.info/handcrafted/bypassing/supervisor", new Guid("9c2b1595-45f8-672e-e24d-46b081cda8ed"), "http://maximo.org/prairie", new TimeSpan(0, 0, 2, 35, 0), "Approved", "Use the auxiliary" },
                    { new Guid("a753a0e7-11d7-0e7a-0329-21ee510b4723"), "Small Metal Table", "http://laverna.org/redundant", new Guid("552d18c2-86b9-4773-0253-becbc4f9f3a7"), "https://kade.name/intelligent-frozen-cheese/gorgeo", new TimeSpan(0, 0, 3, 28, 0), "Rejected", "Use the primary" },
                    { new Guid("aa6a225c-8f5a-42a5-c7e5-c437955d17dd"), "Handcrafted Granite Pizza", "http://jade.org/corporate/granite", new Guid("f4c5bb92-c504-dc74-c969-fbb76ae50f7e"), "https://yvonne.org/fresh", new TimeSpan(0, 0, 3, 18, 0), "Approved", "We need to" },
                    { new Guid("ab8670a9-25ef-56ea-8497-bf26e6fe2977"), "Sleek Frozen Salad", "https://samanta.net/cambridgeshire/personal-loan-a", new Guid("062f3c05-dd11-1323-10db-7e8ac0b8ef7e"), "http://demarco.net/borders", new TimeSpan(0, 0, 2, 31, 0), "Pending", "Use the online" },
                    { new Guid("acf829be-2b25-cb9d-3b20-f4ec2fea700c"), "Intelligent Frozen Salad", "http://randal.net/deploy/principal/buckinghamshire", new Guid("552d18c2-86b9-4773-0253-becbc4f9f3a7"), "http://rosanna.com/compress", new TimeSpan(0, 0, 3, 9, 0), "Rejected", "I'll input the" },
                    { new Guid("ae5241da-807e-6cd9-8d3f-ff7a859c8d70"), "Ergonomic Steel Shoes", "http://jalon.net/mobility/avon/incentivize", new Guid("d82de857-522c-c556-b013-d78f474f9287"), "http://elton.info/sms", new TimeSpan(0, 0, 2, 41, 0), "Approved", "Try to index" },
                    { new Guid("aedf2bad-9d7f-3494-a9bc-159f461be23c"), "Ergonomic Frozen Chair", "https://tom.net/inlet/investment-account/direction", new Guid("de35e4ee-1a3c-5790-7777-f1ec1069e422"), "https://ethel.name/officer/array", new TimeSpan(0, 0, 3, 13, 0), "Approved", "Try to generate" },
                    { new Guid("af378ed4-c287-76ee-b541-7d08edd12b32"), "Gorgeous Steel Fish", "https://lizzie.org/practical-steel-car", new Guid("552d18c2-86b9-4773-0253-becbc4f9f3a7"), "http://golden.net/reboot", new TimeSpan(0, 0, 2, 46, 0), "Rejected", "Try to hack" },
                    { new Guid("b565bd17-ff21-9e0b-73ba-6e9e5098f113"), "Unbranded Concrete Computer", "http://crawford.name/innovative", new Guid("1c8575f0-6194-339d-ad3e-2e7c3866a80f"), "https://roosevelt.name/drive", new TimeSpan(0, 0, 3, 5, 0), "Approved", "If we parse" },
                    { new Guid("b641bdf7-7844-422f-6aaa-47f0a24c7379"), "Gorgeous Steel Hat", "http://carolina.name/leverage/savings-account/sms", new Guid("0e51d9f0-3e16-1570-8751-8bfcad3c76b7"), "http://ambrose.info/hdd/supply-chains/philippines", new TimeSpan(0, 0, 3, 12, 0), "Rejected", "The SMTP application" },
                    { new Guid("bb0b585d-3ba7-17c4-b1a1-0f472c160bb2"), "Sleek Concrete Salad", "https://ignatius.info/handcrafted-concrete-keyboar", new Guid("552d18c2-86b9-4773-0253-becbc4f9f3a7"), "https://raymundo.com/global/iterate/cyan", new TimeSpan(0, 0, 3, 14, 0), "Approved", "The RAM alarm" },
                    { new Guid("bbe43911-8a37-4194-0554-fa3f0057d472"), "Awesome Metal Shirt", "http://bethel.org/incredible/hub", new Guid("7fc71309-41a9-f4e3-287b-8345ecad8131"), "http://troy.org/dynamic/avon/glens", new TimeSpan(0, 0, 3, 10, 0), "Approved", "I'll input the" },
                    { new Guid("bcffc41e-3977-cf89-ce7d-cd5cfee45573"), "Unbranded Concrete Pizza", "http://stefanie.net/russian-ruble", new Guid("8717fef3-a26b-e361-ca4b-173b514b256b"), "https://roger.org/killer/small", new TimeSpan(0, 0, 3, 18, 0), "Rejected", "Use the 1080p" },
                    { new Guid("bd75b3bf-7b9e-6f85-b002-699888630d34"), "Gorgeous Cotton Pants", "http://marian.info/cambridgeshire/invoice/multi-ch", new Guid("2349b3e1-f845-5b61-fa8e-fbef8c8a9b57"), "http://vaughn.name/web-enabled/back-end/synergized", new TimeSpan(0, 0, 3, 6, 0), "Approved", "Use the 1080p" },
                    { new Guid("c03d92a1-f7a2-a26d-bf6d-35379cd7666d"), "Unbranded Soft Tuna", "http://isac.info/client-server", new Guid("8717fef3-a26b-e361-ca4b-173b514b256b"), "https://lexi.org/avon", new TimeSpan(0, 0, 3, 15, 0), "Pending", "The EXE monitor" },
                    { new Guid("c57b9c69-a674-61d8-4370-7330f453bac3"), "Rustic Plastic Shirt", "https://lawson.net/small", new Guid("d922e44d-ba77-e400-0a2a-26212685a3c3"), "http://ashlee.com/emulation/impactful/wells", new TimeSpan(0, 0, 2, 46, 0), "Approved", "You can't copy" },
                    { new Guid("c6114ea0-c901-66bd-f80d-f0472debcf58"), "Rustic Cotton Bacon", "http://mazie.biz/bluetooth/transmit", new Guid("89d22fe4-5532-ac42-0f6e-976e2e92da05"), "http://olin.name/channels/interface", new TimeSpan(0, 0, 2, 30, 0), "Rejected", "copying the application" },
                    { new Guid("cc8a4b59-fc69-076b-0e6d-df37a5c2059d"), "Gorgeous Fresh Soap", "https://lynn.biz/east-caribbean-dollar/infrastruct", new Guid("ffd23d02-4eb5-4217-2b43-f9b46c4a45c7"), "https://elta.com/web-enabled/anguilla/deposit", new TimeSpan(0, 0, 2, 42, 0), "Rejected", "The IB feed" },
                    { new Guid("cd370536-22c4-abd0-94e3-20ee79b81247"), "Handmade Soft Salad", "https://van.net/tasty-soft-sausages/haptic", new Guid("b471b00d-f7ee-acf9-e226-1fd24d76e93c"), "http://rick.biz/interactive/views/guyana-dollar", new TimeSpan(0, 0, 2, 53, 0), "Rejected", "You can't override" },
                    { new Guid("d261e8f7-4440-b740-bad9-752184f4994b"), "Intelligent Fresh Pizza", "http://bethel.biz/json", new Guid("7fc71309-41a9-f4e3-287b-8345ecad8131"), "https://unique.name/metal/dot-com", new TimeSpan(0, 0, 3, 8, 0), "Pending", "Use the digital" },
                    { new Guid("d464011a-5105-ef64-e851-3efff6857a02"), "Incredible Plastic Ball", "http://marcellus.biz/interface", new Guid("17f3f721-c6c8-7b79-2791-0c615bb1d678"), "https://evalyn.info/schemas/cedi/cotton", new TimeSpan(0, 0, 3, 1, 0), "Rejected", "I'll quantify the" },
                    { new Guid("d73a8e96-d83b-503d-fda9-c192cfad9108"), "Gorgeous Rubber Pizza", "https://reta.com/computers--kids", new Guid("0e51d9f0-3e16-1570-8751-8bfcad3c76b7"), "http://raphaelle.info/swiss-franc/fuchsia/gorgeous", new TimeSpan(0, 0, 2, 38, 0), "Rejected", "backing up the" },
                    { new Guid("da2c1490-39c9-74c1-ea93-c61ea1ff717a"), "Awesome Concrete Tuna", "https://abbey.org/small-cotton-tuna/metal", new Guid("d9ace6d5-3d01-ab77-48e3-ab1f26334575"), "http://cristian.com/indiana/home-loan-account", new TimeSpan(0, 0, 2, 57, 0), "Pending", "The SCSI bandwidth" },
                    { new Guid("e16117c7-5f1b-7155-ec9f-e16fe9204462"), "Unbranded Concrete Car", "http://kailee.net/benchmark", new Guid("d922e44d-ba77-e400-0a2a-26212685a3c3"), "http://henri.net/monitor", new TimeSpan(0, 0, 2, 51, 0), "Pending", "Use the multi-byte" },
                    { new Guid("e188a4e6-5648-a349-443b-9755d21ded22"), "Ergonomic Fresh Chips", "https://kale.net/monitor/initiatives", new Guid("ffd23d02-4eb5-4217-2b43-f9b46c4a45c7"), "http://alan.org/gorgeous-fresh-pants", new TimeSpan(0, 0, 2, 50, 0), "Rejected", "The AI protocol" },
                    { new Guid("e2b819c9-1489-5992-82a4-2f276b5b46c7"), "Awesome Plastic Chair", "https://alfonzo.info/fantastic-granite-pants/plati", new Guid("d9ace6d5-3d01-ab77-48e3-ab1f26334575"), "http://tillman.name/valley", new TimeSpan(0, 0, 3, 19, 0), "Approved", "I'll reboot the" },
                    { new Guid("e4b2fb33-a8f8-ddde-52ad-5dd26ad14d28"), "Fantastic Rubber Computer", "http://mireille.net/refined", new Guid("de35e4ee-1a3c-5790-7777-f1ec1069e422"), "https://winifred.biz/connecting/backing-up", new TimeSpan(0, 0, 3, 16, 0), "Approved", "You can't quantify" },
                    { new Guid("e760d4c7-4d37-d969-53d1-2191be06fd55"), "Generic Metal Computer", "https://eulalia.info/parsing/paradigms", new Guid("d14d8488-392a-c224-376c-9545523ef9d7"), "http://brando.info/iterate/tonga", new TimeSpan(0, 0, 3, 22, 0), "Pending", "overriding the capacitor" },
                    { new Guid("ef6b498e-d709-59a5-2e77-1378b07d162a"), "Rustic Soft Hat", "http://immanuel.com/hacking/money-market-account", new Guid("62974f26-824a-80f7-bdb5-31fe456909ca"), "https://elmo.biz/hard-drive/station/investment-acc", new TimeSpan(0, 0, 2, 53, 0), "Approved", "If we back" },
                    { new Guid("f14d46c2-0d12-4a9b-f30f-3e5e101ed881"), "Awesome Metal Bacon", "https://krystel.org/jersey/avon", new Guid("de35e4ee-1a3c-5790-7777-f1ec1069e422"), "http://ima.info/delaware", new TimeSpan(0, 0, 2, 41, 0), "Rejected", "Try to compress" },
                    { new Guid("f431ed2f-fb67-9d51-9fb2-b4c1809d1908"), "Awesome Granite Fish", "http://leatha.info/distributed/legacy/infrastructu", new Guid("28a25f0e-dfa5-dc8a-9ec7-db94ad90e67d"), "https://johnnie.com/digital/metal/yuan-renminbi", new TimeSpan(0, 0, 2, 40, 0), "Pending", "bypassing the microchip" },
                    { new Guid("fa08e08b-fa96-0ad9-c517-560a8d0a828f"), "Handmade Granite Chicken", "https://bernadine.biz/realigned/ergonomic/nebraska", new Guid("89d22fe4-5532-ac42-0f6e-976e2e92da05"), "http://jada.com/project/coordinator", new TimeSpan(0, 0, 2, 41, 0), "Pending", "transmitting the hard" },
                    { new Guid("fa74aff7-7a59-af2e-ad17-d8e37fa2a1fc"), "Unbranded Frozen Pants", "http://lamont.info/generic-fresh-mouse", new Guid("65ff82bb-8d09-8e6c-0f2b-c4d489d94086"), "http://valentina.org/human-resource", new TimeSpan(0, 0, 2, 42, 0), "Pending", "I'll transmit the" },
                    { new Guid("fcdb5742-367d-a7e2-d96d-674eca1e0083"), "Handmade Wooden Hat", "http://alycia.org/invoice/rustic-granite-table/fro", new Guid("7fc71309-41a9-f4e3-287b-8345ecad8131"), "http://connie.info/handcrafted", new TimeSpan(0, 0, 2, 42, 0), "Pending", "Try to compress" },
                    { new Guid("fead9936-136b-7633-6b27-fa059da01a28"), "Practical Plastic Ball", "https://zakary.org/automotive/automotive/extensibl", new Guid("de35e4ee-1a3c-5790-7777-f1ec1069e422"), "https://ursula.com/dynamic/wisconsin", new TimeSpan(0, 0, 3, 13, 0), "Rejected", "You can't program" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("02847616-1815-1d2b-ee7b-b4ffb78d8645"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("0cf8855d-56b9-6e58-c1fb-d9f1d1a4b65b"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("0fb79301-e525-e361-79a6-4bef698cd3b3"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("13758096-2798-8c2a-ab04-12577b3a903a"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("15399ce7-2363-7a4e-8cf7-731e37254e0c"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("164778f9-51b3-97d8-4d12-c194e3cfa18d"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("1a0d5d93-6710-49ec-6f9c-2b0bd9efadf8"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("1a148937-7fc7-a76c-f21e-90f1863c07b0"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("1a8716f5-02b4-35df-7866-a550419ea657"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("2765b367-5555-f7ce-d601-f57e43f2b8e7"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("333a33e0-c26b-2276-4b5f-ac1d9f5a2e3c"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("3358e3a5-20d5-922f-d326-336359c0f6e0"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("349c6b37-0ab2-5115-1c5d-086b513e1e03"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("387e8afa-c868-0209-3097-4927f9ddd08d"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("3a3fe77a-5d55-31af-7f10-bdc02e98ba98"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("3c271834-2606-4225-3838-61662f2c740a"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("3c60f1dd-21bd-3004-501f-7c7f698d0ecd"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("3e72e500-600b-5e36-1276-430aaef98e88"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("4128ea39-94d8-dd68-6537-f86fc9aaad8c"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("43012557-3290-a4eb-563d-b8cc47104671"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("43e9c98c-e32c-5a1f-a084-4c2cc88d46b8"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("47f1877c-b234-bf36-9973-883bbade9b29"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("48964e47-9933-07f9-a0d4-7b177c65e966"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("4cc014c7-8ae0-7d4d-1605-175b8aa849a5"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("4e58f4d9-8722-e51c-b883-9472ec0cf175"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("5356098d-2bfb-11be-4130-f15deaaf2a9f"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("535a278f-807f-0ba6-0165-20e2070519ad"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("53e44b8d-9a60-90d0-89c5-7b79d0263d0e"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("5a3f02b3-6fa3-e7d8-43f3-7c7f9b61bea3"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("5a51617a-c61e-6e44-ac6f-cb0cfc319fc4"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("5af36740-6b5e-dd88-657c-e998dbdafd1c"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("5ee2bbd9-a5df-a998-471f-62f50474631e"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("630acb88-0a1d-532f-d5c5-be26165ec3b3"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("63a17d43-1cdc-a170-4425-0db718c92d81"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("67e55730-e50c-5181-4659-53901790b11f"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("67ed8507-a3b4-2a60-31ea-7144c2d9ffca"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("69e52b37-d679-928b-92dc-0a828fadfc0f"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("6c4f30f0-db93-660e-2e04-409ea576efa8"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("6c7ee117-978c-7fee-089f-8cd556634d61"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("6fb71bd5-318c-70b4-2945-8a8a8cebf891"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("72ee0af0-4b41-629e-01aa-262ab552dbf5"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("732483b1-4ef3-c1d7-83e5-7bc4e5d39ccc"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("73d2374f-b29e-3878-4f6b-03ecda0971f2"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("7a40d741-ed6c-74e3-8a12-17fdfd82d98f"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("7af26624-3d13-f1a8-b4ee-d702ed3ee98b"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("7e1318f9-2ac4-1440-9d78-3b6a40887902"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("7fcb0ab8-43e7-dd09-8967-b2d80b0a2cc4"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("80b8d0d8-b168-d3b9-d658-fb9cd313cc9c"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("81581db2-6849-78f5-9a4d-1f2b834f73d3"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("823b341f-8b07-967b-1c0d-8be4500dd903"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("8311b45e-a1d5-2415-4ec7-99f1763d8f0f"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("837f88a2-0196-46ea-4bd8-c7e582efce6d"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("83b5fe12-2791-c5e2-e3ee-ef27e28287d1"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("898b3a80-69f8-64ef-680b-1a3f63f3ef3e"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("8cca616f-878b-73af-9b0f-c11991eb9105"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("8ed2a6dc-ab6c-7d80-62c1-0059b7c7553d"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("9043baf9-02cb-f1e5-ac85-8f3e9c4725ba"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("916f267e-26fb-9f6c-ed85-d09301ea229b"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("92e6b058-723d-0ae4-39a7-9b2db67e329a"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("9386347e-571e-8b24-9dad-a993ffafbe62"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("97ab7c18-2688-936c-a0e6-cc79efabf52a"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("97ad87cb-59b6-2896-2fe0-29761f4b433a"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("9da27e6b-63f9-972b-e5dc-0f34f8b90d75"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("a1fc76d1-5e00-241c-dbca-0bdacac16f97"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("a51063b3-72ee-8ed2-8750-4cfab6fd4dc4"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("a753a0e7-11d7-0e7a-0329-21ee510b4723"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("aa6a225c-8f5a-42a5-c7e5-c437955d17dd"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("ab8670a9-25ef-56ea-8497-bf26e6fe2977"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("acf829be-2b25-cb9d-3b20-f4ec2fea700c"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("ae5241da-807e-6cd9-8d3f-ff7a859c8d70"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("aedf2bad-9d7f-3494-a9bc-159f461be23c"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("af378ed4-c287-76ee-b541-7d08edd12b32"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("b565bd17-ff21-9e0b-73ba-6e9e5098f113"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("b641bdf7-7844-422f-6aaa-47f0a24c7379"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("bb0b585d-3ba7-17c4-b1a1-0f472c160bb2"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("bbe43911-8a37-4194-0554-fa3f0057d472"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("bcffc41e-3977-cf89-ce7d-cd5cfee45573"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("bd75b3bf-7b9e-6f85-b002-699888630d34"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("c03d92a1-f7a2-a26d-bf6d-35379cd7666d"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("c57b9c69-a674-61d8-4370-7330f453bac3"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("c6114ea0-c901-66bd-f80d-f0472debcf58"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("cc8a4b59-fc69-076b-0e6d-df37a5c2059d"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("cd370536-22c4-abd0-94e3-20ee79b81247"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("d261e8f7-4440-b740-bad9-752184f4994b"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("d464011a-5105-ef64-e851-3efff6857a02"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("d73a8e96-d83b-503d-fda9-c192cfad9108"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("da2c1490-39c9-74c1-ea93-c61ea1ff717a"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e16117c7-5f1b-7155-ec9f-e16fe9204462"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e188a4e6-5648-a349-443b-9755d21ded22"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e2b819c9-1489-5992-82a4-2f276b5b46c7"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e4b2fb33-a8f8-ddde-52ad-5dd26ad14d28"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e760d4c7-4d37-d969-53d1-2191be06fd55"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("ef6b498e-d709-59a5-2e77-1378b07d162a"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("f14d46c2-0d12-4a9b-f30f-3e5e101ed881"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("f431ed2f-fb67-9d51-9fb2-b4c1809d1908"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("fa08e08b-fa96-0ad9-c517-560a8d0a828f"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("fa74aff7-7a59-af2e-ad17-d8e37fa2a1fc"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("fcdb5742-367d-a7e2-d96d-674eca1e0083"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("fead9936-136b-7633-6b27-fa059da01a28"));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("9fdea678-4a21-6d13-4185-9484e1a21ecd"),
                columns: new[] { "AudioUrl", "CoverUrl", "Status" },
                values: new object[] { "https://desiree.net/benchmark/invoice", "http://callie.info/incredible-wooden-shirt/generic", "Rejected" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Album", "AudioUrl", "AuthorId", "CoverUrl", "Duration", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("022f284d-5a3c-9a21-099f-969d11025cb4"), "Refined Steel Pizza", "http://stephany.info/trace", new Guid("455357b3-ab37-7d3b-8ddd-aa4a9b035760"), "http://helen.biz/hungary", new TimeSpan(0, 0, 2, 42, 0), "Approved", "We need to" },
                    { new Guid("088c113c-8693-77fa-1d2e-e1848b144d13"), "Fantastic Frozen Mouse", "http://mireya.name/home-loan-account/artificial-in", new Guid("9c2b1595-45f8-672e-e24d-46b081cda8ed"), "http://cassidy.biz/logistical/mountain", new TimeSpan(0, 0, 2, 51, 0), "Approved", "You can't synthesize" },
                    { new Guid("0b585d74-a7bb-c43b-17b1-a10f472c160b"), "Licensed Granite Bike", "https://ignatius.info/handcrafted-concrete-keyboar", new Guid("d14d8488-392a-c224-376c-9545523ef9d7"), "https://raymundo.com/global/iterate/cyan", new TimeSpan(0, 0, 2, 56, 0), "Rejected", "Try to calculate" },
                    { new Guid("0d5d93d1-101a-ec67-496f-9c2b0bd9efad"), "Handcrafted Steel Chips", "http://chris.info/optimize/white/local", new Guid("89d22fe4-5532-ac42-0f6e-976e2e92da05"), "https://jazmyn.org/reboot/trail/reboot", new TimeSpan(0, 0, 2, 37, 0), "Rejected", "If we index" },
                    { new Guid("0e8d697f-5ecd-f720-05c3-81f37be64927"), "Refined Frozen Soap", "https://devin.info/bedfordshire/deposit", new Guid("062f3c05-dd11-1323-10db-7e8ac0b8ef7e"), "http://kelly.info/customer/concrete", new TimeSpan(0, 0, 2, 46, 0), "Rejected", "I'll generate the" },
                    { new Guid("1063b3e8-eea5-d272-8e87-504cfab6fd4d"), "Practical Granite Sausages", "http://rick.info/handcrafted/bypassing/supervisor", new Guid("3a4637ab-0383-947a-860b-598de7e62046"), "http://maximo.org/prairie", new TimeSpan(0, 0, 3, 15, 0), "Pending", "If we hack" },
                    { new Guid("11b45ed3-d583-15a1-244e-c799f1763d8f"), "Sleek Plastic Pants", "http://winfield.info/monitor/drive", new Guid("9c2b1595-45f8-672e-e24d-46b081cda8ed"), "http://karli.org/override", new TimeSpan(0, 0, 3, 15, 0), "Approved", "calculating the card" },
                    { new Guid("1318f97c-c47e-402a-149d-783b6a408879"), "Intelligent Granite Pants", "https://lesley.com/bandwidth/rubber", new Guid("eb5aa860-01f1-f11d-eb28-7b3747c1dca7"), "https://myrl.name/idaho/granite", new TimeSpan(0, 0, 3, 30, 0), "Pending", "You can't compress" },
                    { new Guid("13f19850-5b4e-dc97-819d-3cabbceaf6f1"), "Fantastic Soft Chicken", "http://elise.info/locks", new Guid("d9ace6d5-3d01-ab77-48e3-ab1f26334575"), "http://ruby.net/awesome/western-sahara", new TimeSpan(0, 0, 3, 2, 0), "Approved", "We need to" },
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
                    { new Guid("46ea0196-d84b-e5c7-82ef-ce6dd0e09efd"), "Ergonomic Cotton Keyboard", "http://cecelia.name/specialist", new Guid("62974f26-824a-80f7-bdb5-31fe456909ca"), "https://enoch.org/copy/hacking/meadow", new TimeSpan(0, 0, 3, 24, 0), "Rejected", "transmitting the monitor" },
                    { new Guid("4778f9be-b316-d851-974d-12c194e3cfa1"), "Rustic Fresh Cheese", "https://marlee.name/terrace/assurance", new Guid("552d18c2-86b9-4773-0253-becbc4f9f3a7"), "https://stefanie.net/interactions", new TimeSpan(0, 0, 2, 47, 0), "Rejected", "generating the sensor" },
                    { new Guid("4d46c271-12f1-9b0d-4af3-0f3e5e101ed8"), "Gorgeous Rubber Tuna", "https://krystel.org/jersey/avon", new Guid("d82de857-522c-c556-b013-d78f474f9287"), "http://ima.info/delaware", new TimeSpan(0, 0, 2, 57, 0), "Pending", "compressing the monitor" },
                    { new Guid("4d6356d5-b961-d6a4-6a7f-72b157003151"), "Awesome Metal Towels", "http://deven.info/credit-card-account/engage/revol", new Guid("062f3c05-dd11-1323-10db-7e8ac0b8ef7e"), "http://consuelo.org/fresh/functionality", new TimeSpan(0, 0, 3, 4, 0), "Approved", "synthesizing the array" },
                    { new Guid("4f30f008-936c-0edb-662e-04409ea576ef"), "Awesome Metal Keyboard", "http://idella.name/handcrafted/soft/orchestrator", new Guid("ffd23d02-4eb5-4217-2b43-f9b46c4a45c7"), "https://nikko.info/project/tanzania", new TimeSpan(0, 0, 3, 1, 0), "Approved", "We need to" },
                    { new Guid("51617a13-1e5a-44c6-6eac-6fcb0cfc319f"), "Ergonomic Concrete Shirt", "http://ernie.info/bleeding-edge", new Guid("49bb0990-7c20-0dcf-fce5-3793219f6047"), "http://madelyn.com/portals/executive/intelligent-g", new TimeSpan(0, 0, 3, 4, 0), "Approved", "Try to parse" },
                    { new Guid("5241daea-7eae-d980-6c8d-3fff7a859c8d"), "Fantastic Wooden Computer", "http://jalon.net/mobility/avon/incentivize", new Guid("62974f26-824a-80f7-bdb5-31fe456909ca"), "http://elton.info/sms", new TimeSpan(0, 0, 3, 20, 0), "Pending", "bypassing the alarm" },
                    { new Guid("53a0e799-d7a7-7a11-0e03-2921ee510b47"), "Handmade Steel Chicken", "http://laverna.org/redundant", new Guid("de35e4ee-1a3c-5790-7777-f1ec1069e422"), "https://kade.name/intelligent-frozen-cheese/gorgeo", new TimeSpan(0, 0, 2, 56, 0), "Rejected", "If we navigate" },
                    { new Guid("55e4fe5c-f973-8cd1-6ea0-741673ef3854"), "Incredible Plastic Table", "http://alice.info/jbod/wisconsin/streets", new Guid("b471b00d-f7ee-acf9-e226-1fd24d76e93c"), "https://samantha.info/calculate", new TimeSpan(0, 0, 2, 31, 0), "Rejected", "If we input" },
                    { new Guid("56098df8-fb53-be2b-1141-30f15deaaf2a"), "Handcrafted Soft Tuna", "http://elisabeth.biz/kids--garden/uganda-shilling/", new Guid("17f3f721-c6c8-7b79-2791-0c615bb1d678"), "https://adolph.biz/solomon-islands-dollar/cyan", new TimeSpan(0, 0, 2, 51, 0), "Pending", "If we program" },
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
                    { new Guid("b5fe127a-9183-e227-c5e3-eeef27e28287"), "Unbranded Steel Bike", "http://martina.net/css", new Guid("1c8575f0-6194-339d-ad3e-2e7c3866a80f"), "http://ali.com/sensor", new TimeSpan(0, 0, 3, 14, 0), "Rejected", "Try to quantify" },
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
    }
}
