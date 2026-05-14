using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vladify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addUserSongsFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("00133a77-3a59-6194-90c5-2d29e630eba5"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("00c1627d-b759-55c7-3d8f-e703fedbd0a4"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("03b18792-8f7a-ac07-9f49-2c0d2c237f3b"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("0421bd3c-5030-7c1f-7f69-8d0ecd5e20f7"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("06f83bb9-4eb4-9dfa-ed4c-fbfc7de340d3"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("0d638898-b334-20d7-d559-d86f81411edf"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("101323dd-7edb-c08a-b8ef-7eebc0d13343"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("10ef0fbc-c412-c0b5-2153-9a65f9f07585"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("1522168e-3af0-4a2b-ae5f-c037f231c445"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("1eb82dfa-c0e7-e6d5-acd9-013d77ab48e3"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("256eceb8-52b2-0095-9967-84d7831987f1"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("26e95505-aa46-ac45-c860-e000ff1526e9"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("2be77ccd-e177-00e7-a24d-0dd3d8dd0b91"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("32e4acda-9163-2661-808e-99521037bffc"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("334cccd0-bff9-58bf-f79c-128c030193b7"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("3447f187-36b2-99bf-7388-3bbade9b295b"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("378bf827-931e-4e82-09e2-4eb9256c1f26"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("392ad14d-c224-6c37-9545-523ef9d7529d"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("399ce73c-6315-4e23-7a8c-f7731e37254e"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("3ac37149-62d5-31f9-1fa2-c07e45b4e464"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("40a69d9b-c237-25b1-fcb3-023f5aa36fd8"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("416d134a-9485-e184-a21e-cd4fa2232278"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("42c4cbf8-16de-5617-5257-c7762d018cad"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("452534ca-994c-4328-7508-133178875a30"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("49bb0990-7c20-0dcf-fce5-3793219f6047"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("49f27222-7147-266d-80ac-3dd5264eac89"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("4a6cb4f9-c745-9254-ec8b-2326736804fd"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("4d56cd88-22e4-77d9-ba00-e40a2a262126"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("5576e921-a374-745f-2725-c57dcdccd185"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("58aba9e0-8575-cbfb-fbfd-a92cd594f622"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("595fa0b3-bcbf-4df1-45b8-98461c1dde97"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("5cb84213-5438-cf71-2fef-8fa85bbb9470"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("5cc4e584-6686-ba43-b486-bf51c65fe4b8"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("5f98c9b3-8ec0-2708-788a-fd5b25980e7c"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("65f546dc-a7d5-6b91-62fc-59cb08581aaf"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("65ff82bb-8d09-8e6c-0f2b-c4d489d94086"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("680c0509-a266-def4-e8b9-3e54af6bd0b9"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("69abf1cb-79b7-bdb4-e1c0-248dec8f275a"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("6a422f78-47aa-a2f0-4c73-7980baf93708"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("6b254b51-3c7b-75ac-3622-b26b5f6314b4"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("6b272fa4-465b-86c7-7c67-6e41d314447f"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("6cbd5370-412b-0272-7556-990b89b2975a"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("6dcbc63b-2a63-09d2-13c7-7fa941e3f428"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("700d1f19-5126-e507-fa3a-92bbc5f404c5"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("7639ae02-e647-3785-b398-37bf8ff9e270"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("79407105-d659-2430-1c53-ee7f130ef4ba"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("79c6c817-277b-0c91-615b-b1d67808699e"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("7a23a379-2cb0-bf24-e3eb-488a6222c4ab"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("7ead679b-6056-0da5-c5c8-2058c35c9662"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("7ee11701-8c6c-ee97-7f08-9f8cd556634d"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("81dc975b-3c9d-bcab-eaf6-f16a99b60231"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("820a8d0a-098f-4f37-617d-13cc8f4918e4"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("84392580-8c61-c0d8-3c11-061120df963b"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("86ebcd6f-c87b-fad8-0e80-0eb52f8a9a43"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("8b220216-0039-d9aa-bbe2-5edfa598a947"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("8cd1f973-a06e-1674-73ef-3854a0cf97fc"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("9041ab93-2fae-6810-6e5d-dc7bcd7f57e8"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("90430125-eb32-56a4-3db8-cc4710467157"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("90ad94db-7de6-f2f2-21d8-8dccb292ba0e"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("92a61fad-5aa2-4b89-e47e-4b852713c3ac"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("936f6676-dabe-8e1a-496b-ef09d7a5592e"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("9841a693-344d-9dc1-69e7-b51a99feed43"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("9c2b1595-45f8-672e-e24d-46b081cda8ed"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("9df56807-78d6-50be-5f09-85de6a1ec4ff"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("9e0146df-a0dd-114e-c601-c9bd66f80df0"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("a01cf8f3-9cd0-cc79-7eb3-ff22611e03a9"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("a3119096-12dd-2fa4-ed31-f467fb519d9f"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("a3aba8c4-8813-0ede-ac5f-ab782189b5eb"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("a86028b5-eb5a-01f1-1df1-eb287b3747c1"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("ab9eaf0f-006e-9244-5efd-c113274a70a2"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("b340c0d5-5357-3745-ab3b-7d8dddaa4a9b"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("b6a4d1f1-855b-265b-2974-26e820a54cb5"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("bb12c7e2-f9a8-5109-2da9-4a6420f16e85"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("bb433fae-39eb-71b1-910e-256c4d998f5a"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("c35e1626-10b3-d866-7821-419e1e94c5ab"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("c65e4c3e-f594-847a-0f65-5853f2fee697"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("cbbe5302-f9c4-a7f3-7e45-7d293332c0b6"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("cd0936a2-cc05-ae67-291f-f0d9510e163e"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("ce3c2ecd-87f1-8357-65eb-60bb46bd5b9f"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("d0c42c0a-10da-671e-af1c-f953b57d5493"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("d0c5583a-5eec-720b-0954-94ca69eee435"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("d25805f6-a1fa-3d92-c0a2-f76da2bf6d35"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("d3ef43fd-5d8e-4fe3-3db7-a3e42fd28932"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("d4f53a08-378e-87af-c2ee-76b5417d08ed"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("d84128ea-6894-65dd-37f8-6fc9aaad8ccc"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("d993c1d1-0d5e-71b0-b4ee-f7f9ace2261f"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("da8016b2-bd5c-4b96-3929-f517bd65b521"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("dce4d4e0-26f4-974f-624a-82f780bdb531"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("dea8f8e4-52dd-5dad-d26a-d14d282f023c"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e1b81f8a-e7ef-65dd-1dbb-d690142cdac9"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e21b469f-113c-088c-9386-fa771d2ee184"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e6e78d59-4620-878d-2527-1695b0f4ae86"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("e943fb26-4d85-83c6-3c08-7e1147e1f117"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("ec91d5e0-363d-e37d-c923-2c1e0f1e3ad1"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("f065b2d5-46f5-efe4-1d49-90e38d005c36"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("f30f5d2c-570e-7a70-44e2-08d36a6ac388"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("f547f9ec-3e8c-4f66-f342-ff6a26e57c4c"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("fb8efa5b-8cef-9b8a-57e1-dada3c3d8bee"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("fdbb9057-2368-8b74-440c-cd33f83b80e2"));

            migrationBuilder.DropColumn(
                name: "Author",
                table: "Songs");

            migrationBuilder.AddColumn<Guid>(
                name: "AuthorId",
                table: "Songs",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("af878b8c-9b73-c10f-1991-eb9105db76d5"),
                columns: new[] { "AuthorId", "Duration" },
                values: new object[] { new Guid("1c8575f0-6194-339d-ad3e-2e7c3866a80f"), new TimeSpan(0, 0, 3, 12, 0) });

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
                name: "IX_Songs_AuthorId",
                table: "Songs",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Users_AuthorId",
                table: "Songs",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Users_AuthorId",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Songs_AuthorId",
                table: "Songs");

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
                keyValue: new Guid("2c0d2442-82c0-9220-b1c3-5bd861474e96"));

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
                keyValue: new Guid("9fdea678-4a21-6d13-4185-9484e1a21ecd"));

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
                keyValue: new Guid("bca93494-9f15-1b46-e23c-118c089386fa"));

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
                keyValue: new Guid("db774e40-3592-6462-f2c0-a3e46d4257db"));

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

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Songs");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Songs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("af878b8c-9b73-c10f-1991-eb9105db76d5"),
                columns: new[] { "Author", "Duration" },
                values: new object[] { "Ardella Powlowski", new TimeSpan(0, 0, 2, 50, 0) });

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
        }
    }
}
