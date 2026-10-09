using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vladify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddPlaylistSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Playlists",
                columns: new[] { "Id", "AuthorId", "Name" },
                values: new object[,]
                {
                    { new Guid("053215db-3ae2-25ef-4c5e-075499b181d1"), new Guid("d82de857-522c-c556-b013-d78f474f9287"), "virtual Rock" },
                    { new Guid("1231d47f-bbe0-6ea2-81c8-8031f795553c"), new Guid("28a25f0e-dfa5-dc8a-9ec7-db94ad90e67d"), "bluetooth Pop" },
                    { new Guid("25a1511e-a58a-be8b-7432-396de82947c5"), new Guid("2349b3e1-f845-5b61-fa8e-fbef8c8a9b57"), "auxiliary Electronic" },
                    { new Guid("2ee09359-2bfc-1529-9f70-beffe5e4dcf0"), new Guid("a8c435d2-a3ab-8813-de0e-ac5fab782189"), "redundant Rap" },
                    { new Guid("49254e2d-b50e-79a1-700d-a9f40c5c904b"), new Guid("65ff82bb-8d09-8e6c-0f2b-c4d489d94086"), "multi-byte Rock" },
                    { new Guid("4c0711bd-98ad-fd01-b0fb-91e60c334099"), new Guid("1c8575f0-6194-339d-ad3e-2e7c3866a80f"), "1080p Rock" },
                    { new Guid("5eb1373c-be8d-e655-95be-4635cf14f706"), new Guid("7fc71309-41a9-f4e3-287b-8345ecad8131"), "virtual Country" },
                    { new Guid("6d358d5b-4c47-d8e3-0c24-3c6ce4aab9d1"), new Guid("d9ace6d5-3d01-ab77-48e3-ab1f26334575"), "redundant World" },
                    { new Guid("7af11948-bd4b-3db9-1c87-cba466159900"), new Guid("28a25f0e-dfa5-dc8a-9ec7-db94ad90e67d"), "primary Stage And Screen" },
                    { new Guid("809bebbf-5f3f-dd6c-a0bb-665731e16d2d"), new Guid("a8c435d2-a3ab-8813-de0e-ac5fab782189"), "neural Rap" },
                    { new Guid("81d3a165-5f39-19ca-df20-3613a1faaa58"), new Guid("89d22fe4-5532-ac42-0f6e-976e2e92da05"), "mobile Classical" },
                    { new Guid("a6b7e634-fd02-c9c2-9b4c-1ba4d912561f"), new Guid("17f3f721-c6c8-7b79-2791-0c615bb1d678"), "back-end Classical" },
                    { new Guid("ad6c5056-2792-71ae-08d0-a1ef172266cb"), new Guid("d922e44d-ba77-e400-0a2a-26212685a3c3"), "multi-byte Electronic" },
                    { new Guid("b1578d7a-3f6b-c66a-c1d1-152de3c6761a"), new Guid("d9ace6d5-3d01-ab77-48e3-ab1f26334575"), "mobile Country" },
                    { new Guid("c833dda0-54e6-6faa-f032-32e589e5ca24"), new Guid("7fc71309-41a9-f4e3-287b-8345ecad8131"), "redundant Rock" },
                    { new Guid("db441324-6239-3d46-2588-f9995b980705"), new Guid("49bb0990-7c20-0dcf-fce5-3793219f6047"), "primary Stage And Screen" },
                    { new Guid("dea5b154-0f62-f38b-45d7-8e6de75dc429"), new Guid("e1863474-f4ae-c7e2-12bb-a8f909512da9"), "multi-byte Metal" },
                    { new Guid("e0a19ea9-07c4-5008-6682-831a78d0da67"), new Guid("455357b3-ab37-7d3b-8ddd-aa4a9b035760"), "cross-platform Classical" },
                    { new Guid("ef952bb5-ab7c-d56d-dd72-67bd43728941"), new Guid("d9ace6d5-3d01-ab77-48e3-ab1f26334575"), "online Blues" },
                    { new Guid("f6e13a85-6bf8-5a06-e8de-f0fae9b599a6"), new Guid("7775e280-c280-eecf-54f4-31fbbf49b93b"), "virtual Electronic" }
                });

            migrationBuilder.InsertData(
                table: "PlaylistSong",
                columns: new[] { "PlaylistsId", "SongsId" },
                values: new object[,]
                {
                    { new Guid("053215db-3ae2-25ef-4c5e-075499b181d1"), new Guid("aedf2bad-9d7f-3494-a9bc-159f461be23c") },
                    { new Guid("053215db-3ae2-25ef-4c5e-075499b181d1"), new Guid("e2b819c9-1489-5992-82a4-2f276b5b46c7") },
                    { new Guid("053215db-3ae2-25ef-4c5e-075499b181d1"), new Guid("ef6b498e-d709-59a5-2e77-1378b07d162a") },
                    { new Guid("1231d47f-bbe0-6ea2-81c8-8031f795553c"), new Guid("164778f9-51b3-97d8-4d12-c194e3cfa18d") },
                    { new Guid("1231d47f-bbe0-6ea2-81c8-8031f795553c"), new Guid("1a0d5d93-6710-49ec-6f9c-2b0bd9efadf8") },
                    { new Guid("1231d47f-bbe0-6ea2-81c8-8031f795553c"), new Guid("1a148937-7fc7-a76c-f21e-90f1863c07b0") },
                    { new Guid("1231d47f-bbe0-6ea2-81c8-8031f795553c"), new Guid("387e8afa-c868-0209-3097-4927f9ddd08d") },
                    { new Guid("1231d47f-bbe0-6ea2-81c8-8031f795553c"), new Guid("3e72e500-600b-5e36-1276-430aaef98e88") },
                    { new Guid("1231d47f-bbe0-6ea2-81c8-8031f795553c"), new Guid("43012557-3290-a4eb-563d-b8cc47104671") },
                    { new Guid("1231d47f-bbe0-6ea2-81c8-8031f795553c"), new Guid("8ed2a6dc-ab6c-7d80-62c1-0059b7c7553d") },
                    { new Guid("1231d47f-bbe0-6ea2-81c8-8031f795553c"), new Guid("bb0b585d-3ba7-17c4-b1a1-0f472c160bb2") },
                    { new Guid("1231d47f-bbe0-6ea2-81c8-8031f795553c"), new Guid("bbe43911-8a37-4194-0554-fa3f0057d472") },
                    { new Guid("1231d47f-bbe0-6ea2-81c8-8031f795553c"), new Guid("e4b2fb33-a8f8-ddde-52ad-5dd26ad14d28") },
                    { new Guid("25a1511e-a58a-be8b-7432-396de82947c5"), new Guid("1a0d5d93-6710-49ec-6f9c-2b0bd9efadf8") },
                    { new Guid("25a1511e-a58a-be8b-7432-396de82947c5"), new Guid("3a3fe77a-5d55-31af-7f10-bdc02e98ba98") },
                    { new Guid("25a1511e-a58a-be8b-7432-396de82947c5"), new Guid("3e72e500-600b-5e36-1276-430aaef98e88") },
                    { new Guid("25a1511e-a58a-be8b-7432-396de82947c5"), new Guid("7af26624-3d13-f1a8-b4ee-d702ed3ee98b") },
                    { new Guid("25a1511e-a58a-be8b-7432-396de82947c5"), new Guid("837f88a2-0196-46ea-4bd8-c7e582efce6d") },
                    { new Guid("25a1511e-a58a-be8b-7432-396de82947c5"), new Guid("97ad87cb-59b6-2896-2fe0-29761f4b433a") },
                    { new Guid("25a1511e-a58a-be8b-7432-396de82947c5"), new Guid("aedf2bad-9d7f-3494-a9bc-159f461be23c") },
                    { new Guid("25a1511e-a58a-be8b-7432-396de82947c5"), new Guid("ef6b498e-d709-59a5-2e77-1378b07d162a") },
                    { new Guid("2ee09359-2bfc-1529-9f70-beffe5e4dcf0"), new Guid("13758096-2798-8c2a-ab04-12577b3a903a") },
                    { new Guid("2ee09359-2bfc-1529-9f70-beffe5e4dcf0"), new Guid("1a148937-7fc7-a76c-f21e-90f1863c07b0") },
                    { new Guid("2ee09359-2bfc-1529-9f70-beffe5e4dcf0"), new Guid("aa6a225c-8f5a-42a5-c7e5-c437955d17dd") },
                    { new Guid("2ee09359-2bfc-1529-9f70-beffe5e4dcf0"), new Guid("bd75b3bf-7b9e-6f85-b002-699888630d34") },
                    { new Guid("49254e2d-b50e-79a1-700d-a9f40c5c904b"), new Guid("0cf8855d-56b9-6e58-c1fb-d9f1d1a4b65b") },
                    { new Guid("49254e2d-b50e-79a1-700d-a9f40c5c904b"), new Guid("43e9c98c-e32c-5a1f-a084-4c2cc88d46b8") },
                    { new Guid("49254e2d-b50e-79a1-700d-a9f40c5c904b"), new Guid("7e1318f9-2ac4-1440-9d78-3b6a40887902") },
                    { new Guid("49254e2d-b50e-79a1-700d-a9f40c5c904b"), new Guid("9fdea678-4a21-6d13-4185-9484e1a21ecd") },
                    { new Guid("49254e2d-b50e-79a1-700d-a9f40c5c904b"), new Guid("aa6a225c-8f5a-42a5-c7e5-c437955d17dd") },
                    { new Guid("49254e2d-b50e-79a1-700d-a9f40c5c904b"), new Guid("e4b2fb33-a8f8-ddde-52ad-5dd26ad14d28") },
                    { new Guid("4c0711bd-98ad-fd01-b0fb-91e60c334099"), new Guid("43e9c98c-e32c-5a1f-a084-4c2cc88d46b8") },
                    { new Guid("4c0711bd-98ad-fd01-b0fb-91e60c334099"), new Guid("5a51617a-c61e-6e44-ac6f-cb0cfc319fc4") },
                    { new Guid("4c0711bd-98ad-fd01-b0fb-91e60c334099"), new Guid("aedf2bad-9d7f-3494-a9bc-159f461be23c") },
                    { new Guid("5eb1373c-be8d-e655-95be-4635cf14f706"), new Guid("13758096-2798-8c2a-ab04-12577b3a903a") },
                    { new Guid("5eb1373c-be8d-e655-95be-4635cf14f706"), new Guid("1a148937-7fc7-a76c-f21e-90f1863c07b0") },
                    { new Guid("5eb1373c-be8d-e655-95be-4635cf14f706"), new Guid("73d2374f-b29e-3878-4f6b-03ecda0971f2") },
                    { new Guid("5eb1373c-be8d-e655-95be-4635cf14f706"), new Guid("aedf2bad-9d7f-3494-a9bc-159f461be23c") },
                    { new Guid("5eb1373c-be8d-e655-95be-4635cf14f706"), new Guid("e2b819c9-1489-5992-82a4-2f276b5b46c7") },
                    { new Guid("5eb1373c-be8d-e655-95be-4635cf14f706"), new Guid("e4b2fb33-a8f8-ddde-52ad-5dd26ad14d28") },
                    { new Guid("6d358d5b-4c47-d8e3-0c24-3c6ce4aab9d1"), new Guid("53e44b8d-9a60-90d0-89c5-7b79d0263d0e") },
                    { new Guid("6d358d5b-4c47-d8e3-0c24-3c6ce4aab9d1"), new Guid("7af26624-3d13-f1a8-b4ee-d702ed3ee98b") },
                    { new Guid("6d358d5b-4c47-d8e3-0c24-3c6ce4aab9d1"), new Guid("bbe43911-8a37-4194-0554-fa3f0057d472") },
                    { new Guid("7af11948-bd4b-3db9-1c87-cba466159900"), new Guid("4e58f4d9-8722-e51c-b883-9472ec0cf175") },
                    { new Guid("7af11948-bd4b-3db9-1c87-cba466159900"), new Guid("5af36740-6b5e-dd88-657c-e998dbdafd1c") },
                    { new Guid("7af11948-bd4b-3db9-1c87-cba466159900"), new Guid("97ad87cb-59b6-2896-2fe0-29761f4b433a") },
                    { new Guid("7af11948-bd4b-3db9-1c87-cba466159900"), new Guid("aa6a225c-8f5a-42a5-c7e5-c437955d17dd") },
                    { new Guid("7af11948-bd4b-3db9-1c87-cba466159900"), new Guid("bd75b3bf-7b9e-6f85-b002-699888630d34") },
                    { new Guid("809bebbf-5f3f-dd6c-a0bb-665731e16d2d"), new Guid("15399ce7-2363-7a4e-8cf7-731e37254e0c") },
                    { new Guid("809bebbf-5f3f-dd6c-a0bb-665731e16d2d"), new Guid("387e8afa-c868-0209-3097-4927f9ddd08d") },
                    { new Guid("809bebbf-5f3f-dd6c-a0bb-665731e16d2d"), new Guid("3e72e500-600b-5e36-1276-430aaef98e88") },
                    { new Guid("809bebbf-5f3f-dd6c-a0bb-665731e16d2d"), new Guid("5af36740-6b5e-dd88-657c-e998dbdafd1c") },
                    { new Guid("809bebbf-5f3f-dd6c-a0bb-665731e16d2d"), new Guid("7e1318f9-2ac4-1440-9d78-3b6a40887902") },
                    { new Guid("809bebbf-5f3f-dd6c-a0bb-665731e16d2d"), new Guid("b565bd17-ff21-9e0b-73ba-6e9e5098f113") },
                    { new Guid("809bebbf-5f3f-dd6c-a0bb-665731e16d2d"), new Guid("c57b9c69-a674-61d8-4370-7330f453bac3") },
                    { new Guid("81d3a165-5f39-19ca-df20-3613a1faaa58"), new Guid("0cf8855d-56b9-6e58-c1fb-d9f1d1a4b65b") },
                    { new Guid("81d3a165-5f39-19ca-df20-3613a1faaa58"), new Guid("43e9c98c-e32c-5a1f-a084-4c2cc88d46b8") },
                    { new Guid("81d3a165-5f39-19ca-df20-3613a1faaa58"), new Guid("5a51617a-c61e-6e44-ac6f-cb0cfc319fc4") },
                    { new Guid("81d3a165-5f39-19ca-df20-3613a1faaa58"), new Guid("630acb88-0a1d-532f-d5c5-be26165ec3b3") },
                    { new Guid("81d3a165-5f39-19ca-df20-3613a1faaa58"), new Guid("8ed2a6dc-ab6c-7d80-62c1-0059b7c7553d") },
                    { new Guid("81d3a165-5f39-19ca-df20-3613a1faaa58"), new Guid("a51063b3-72ee-8ed2-8750-4cfab6fd4dc4") },
                    { new Guid("81d3a165-5f39-19ca-df20-3613a1faaa58"), new Guid("ae5241da-807e-6cd9-8d3f-ff7a859c8d70") },
                    { new Guid("81d3a165-5f39-19ca-df20-3613a1faaa58"), new Guid("aedf2bad-9d7f-3494-a9bc-159f461be23c") },
                    { new Guid("81d3a165-5f39-19ca-df20-3613a1faaa58"), new Guid("bb0b585d-3ba7-17c4-b1a1-0f472c160bb2") },
                    { new Guid("81d3a165-5f39-19ca-df20-3613a1faaa58"), new Guid("ef6b498e-d709-59a5-2e77-1378b07d162a") },
                    { new Guid("a6b7e634-fd02-c9c2-9b4c-1ba4d912561f"), new Guid("0cf8855d-56b9-6e58-c1fb-d9f1d1a4b65b") },
                    { new Guid("a6b7e634-fd02-c9c2-9b4c-1ba4d912561f"), new Guid("15399ce7-2363-7a4e-8cf7-731e37254e0c") },
                    { new Guid("a6b7e634-fd02-c9c2-9b4c-1ba4d912561f"), new Guid("a51063b3-72ee-8ed2-8750-4cfab6fd4dc4") },
                    { new Guid("a6b7e634-fd02-c9c2-9b4c-1ba4d912561f"), new Guid("aedf2bad-9d7f-3494-a9bc-159f461be23c") },
                    { new Guid("a6b7e634-fd02-c9c2-9b4c-1ba4d912561f"), new Guid("e2b819c9-1489-5992-82a4-2f276b5b46c7") },
                    { new Guid("ad6c5056-2792-71ae-08d0-a1ef172266cb"), new Guid("164778f9-51b3-97d8-4d12-c194e3cfa18d") },
                    { new Guid("ad6c5056-2792-71ae-08d0-a1ef172266cb"), new Guid("3e72e500-600b-5e36-1276-430aaef98e88") },
                    { new Guid("ad6c5056-2792-71ae-08d0-a1ef172266cb"), new Guid("aedf2bad-9d7f-3494-a9bc-159f461be23c") },
                    { new Guid("ad6c5056-2792-71ae-08d0-a1ef172266cb"), new Guid("c57b9c69-a674-61d8-4370-7330f453bac3") },
                    { new Guid("b1578d7a-3f6b-c66a-c1d1-152de3c6761a"), new Guid("53e44b8d-9a60-90d0-89c5-7b79d0263d0e") },
                    { new Guid("b1578d7a-3f6b-c66a-c1d1-152de3c6761a"), new Guid("630acb88-0a1d-532f-d5c5-be26165ec3b3") },
                    { new Guid("b1578d7a-3f6b-c66a-c1d1-152de3c6761a"), new Guid("8ed2a6dc-ab6c-7d80-62c1-0059b7c7553d") },
                    { new Guid("b1578d7a-3f6b-c66a-c1d1-152de3c6761a"), new Guid("aa6a225c-8f5a-42a5-c7e5-c437955d17dd") },
                    { new Guid("b1578d7a-3f6b-c66a-c1d1-152de3c6761a"), new Guid("bbe43911-8a37-4194-0554-fa3f0057d472") },
                    { new Guid("c833dda0-54e6-6faa-f032-32e589e5ca24"), new Guid("15399ce7-2363-7a4e-8cf7-731e37254e0c") },
                    { new Guid("c833dda0-54e6-6faa-f032-32e589e5ca24"), new Guid("837f88a2-0196-46ea-4bd8-c7e582efce6d") },
                    { new Guid("c833dda0-54e6-6faa-f032-32e589e5ca24"), new Guid("9fdea678-4a21-6d13-4185-9484e1a21ecd") },
                    { new Guid("c833dda0-54e6-6faa-f032-32e589e5ca24"), new Guid("ae5241da-807e-6cd9-8d3f-ff7a859c8d70") },
                    { new Guid("c833dda0-54e6-6faa-f032-32e589e5ca24"), new Guid("bd75b3bf-7b9e-6f85-b002-699888630d34") },
                    { new Guid("c833dda0-54e6-6faa-f032-32e589e5ca24"), new Guid("c57b9c69-a674-61d8-4370-7330f453bac3") },
                    { new Guid("db441324-6239-3d46-2588-f9995b980705"), new Guid("43012557-3290-a4eb-563d-b8cc47104671") },
                    { new Guid("db441324-6239-3d46-2588-f9995b980705"), new Guid("4e58f4d9-8722-e51c-b883-9472ec0cf175") },
                    { new Guid("db441324-6239-3d46-2588-f9995b980705"), new Guid("630acb88-0a1d-532f-d5c5-be26165ec3b3") },
                    { new Guid("db441324-6239-3d46-2588-f9995b980705"), new Guid("ae5241da-807e-6cd9-8d3f-ff7a859c8d70") },
                    { new Guid("db441324-6239-3d46-2588-f9995b980705"), new Guid("ef6b498e-d709-59a5-2e77-1378b07d162a") },
                    { new Guid("dea5b154-0f62-f38b-45d7-8e6de75dc429"), new Guid("2765b367-5555-f7ce-d601-f57e43f2b8e7") },
                    { new Guid("dea5b154-0f62-f38b-45d7-8e6de75dc429"), new Guid("387e8afa-c868-0209-3097-4927f9ddd08d") },
                    { new Guid("dea5b154-0f62-f38b-45d7-8e6de75dc429"), new Guid("8ed2a6dc-ab6c-7d80-62c1-0059b7c7553d") },
                    { new Guid("dea5b154-0f62-f38b-45d7-8e6de75dc429"), new Guid("a51063b3-72ee-8ed2-8750-4cfab6fd4dc4") },
                    { new Guid("dea5b154-0f62-f38b-45d7-8e6de75dc429"), new Guid("ae5241da-807e-6cd9-8d3f-ff7a859c8d70") },
                    { new Guid("dea5b154-0f62-f38b-45d7-8e6de75dc429"), new Guid("bd75b3bf-7b9e-6f85-b002-699888630d34") },
                    { new Guid("dea5b154-0f62-f38b-45d7-8e6de75dc429"), new Guid("e2b819c9-1489-5992-82a4-2f276b5b46c7") },
                    { new Guid("dea5b154-0f62-f38b-45d7-8e6de75dc429"), new Guid("e4b2fb33-a8f8-ddde-52ad-5dd26ad14d28") },
                    { new Guid("dea5b154-0f62-f38b-45d7-8e6de75dc429"), new Guid("ef6b498e-d709-59a5-2e77-1378b07d162a") },
                    { new Guid("e0a19ea9-07c4-5008-6682-831a78d0da67"), new Guid("15399ce7-2363-7a4e-8cf7-731e37254e0c") },
                    { new Guid("e0a19ea9-07c4-5008-6682-831a78d0da67"), new Guid("1a0d5d93-6710-49ec-6f9c-2b0bd9efadf8") },
                    { new Guid("e0a19ea9-07c4-5008-6682-831a78d0da67"), new Guid("3a3fe77a-5d55-31af-7f10-bdc02e98ba98") },
                    { new Guid("ef952bb5-ab7c-d56d-dd72-67bd43728941"), new Guid("13758096-2798-8c2a-ab04-12577b3a903a") },
                    { new Guid("ef952bb5-ab7c-d56d-dd72-67bd43728941"), new Guid("3a3fe77a-5d55-31af-7f10-bdc02e98ba98") },
                    { new Guid("ef952bb5-ab7c-d56d-dd72-67bd43728941"), new Guid("3e72e500-600b-5e36-1276-430aaef98e88") },
                    { new Guid("ef952bb5-ab7c-d56d-dd72-67bd43728941"), new Guid("53e44b8d-9a60-90d0-89c5-7b79d0263d0e") },
                    { new Guid("ef952bb5-ab7c-d56d-dd72-67bd43728941"), new Guid("5af36740-6b5e-dd88-657c-e998dbdafd1c") },
                    { new Guid("ef952bb5-ab7c-d56d-dd72-67bd43728941"), new Guid("ae5241da-807e-6cd9-8d3f-ff7a859c8d70") },
                    { new Guid("ef952bb5-ab7c-d56d-dd72-67bd43728941"), new Guid("e4b2fb33-a8f8-ddde-52ad-5dd26ad14d28") },
                    { new Guid("f6e13a85-6bf8-5a06-e8de-f0fae9b599a6"), new Guid("0cf8855d-56b9-6e58-c1fb-d9f1d1a4b65b") },
                    { new Guid("f6e13a85-6bf8-5a06-e8de-f0fae9b599a6"), new Guid("13758096-2798-8c2a-ab04-12577b3a903a") },
                    { new Guid("f6e13a85-6bf8-5a06-e8de-f0fae9b599a6"), new Guid("43012557-3290-a4eb-563d-b8cc47104671") },
                    { new Guid("f6e13a85-6bf8-5a06-e8de-f0fae9b599a6"), new Guid("53e44b8d-9a60-90d0-89c5-7b79d0263d0e") },
                    { new Guid("f6e13a85-6bf8-5a06-e8de-f0fae9b599a6"), new Guid("5a51617a-c61e-6e44-ac6f-cb0cfc319fc4") },
                    { new Guid("f6e13a85-6bf8-5a06-e8de-f0fae9b599a6"), new Guid("aedf2bad-9d7f-3494-a9bc-159f461be23c") },
                    { new Guid("f6e13a85-6bf8-5a06-e8de-f0fae9b599a6"), new Guid("b565bd17-ff21-9e0b-73ba-6e9e5098f113") },
                    { new Guid("f6e13a85-6bf8-5a06-e8de-f0fae9b599a6"), new Guid("bb0b585d-3ba7-17c4-b1a1-0f472c160bb2") },
                    { new Guid("f6e13a85-6bf8-5a06-e8de-f0fae9b599a6"), new Guid("bbe43911-8a37-4194-0554-fa3f0057d472") },
                    { new Guid("f6e13a85-6bf8-5a06-e8de-f0fae9b599a6"), new Guid("c57b9c69-a674-61d8-4370-7330f453bac3") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("053215db-3ae2-25ef-4c5e-075499b181d1"), new Guid("aedf2bad-9d7f-3494-a9bc-159f461be23c") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("053215db-3ae2-25ef-4c5e-075499b181d1"), new Guid("e2b819c9-1489-5992-82a4-2f276b5b46c7") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("053215db-3ae2-25ef-4c5e-075499b181d1"), new Guid("ef6b498e-d709-59a5-2e77-1378b07d162a") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("1231d47f-bbe0-6ea2-81c8-8031f795553c"), new Guid("164778f9-51b3-97d8-4d12-c194e3cfa18d") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("1231d47f-bbe0-6ea2-81c8-8031f795553c"), new Guid("1a0d5d93-6710-49ec-6f9c-2b0bd9efadf8") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("1231d47f-bbe0-6ea2-81c8-8031f795553c"), new Guid("1a148937-7fc7-a76c-f21e-90f1863c07b0") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("1231d47f-bbe0-6ea2-81c8-8031f795553c"), new Guid("387e8afa-c868-0209-3097-4927f9ddd08d") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("1231d47f-bbe0-6ea2-81c8-8031f795553c"), new Guid("3e72e500-600b-5e36-1276-430aaef98e88") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("1231d47f-bbe0-6ea2-81c8-8031f795553c"), new Guid("43012557-3290-a4eb-563d-b8cc47104671") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("1231d47f-bbe0-6ea2-81c8-8031f795553c"), new Guid("8ed2a6dc-ab6c-7d80-62c1-0059b7c7553d") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("1231d47f-bbe0-6ea2-81c8-8031f795553c"), new Guid("bb0b585d-3ba7-17c4-b1a1-0f472c160bb2") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("1231d47f-bbe0-6ea2-81c8-8031f795553c"), new Guid("bbe43911-8a37-4194-0554-fa3f0057d472") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("1231d47f-bbe0-6ea2-81c8-8031f795553c"), new Guid("e4b2fb33-a8f8-ddde-52ad-5dd26ad14d28") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("25a1511e-a58a-be8b-7432-396de82947c5"), new Guid("1a0d5d93-6710-49ec-6f9c-2b0bd9efadf8") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("25a1511e-a58a-be8b-7432-396de82947c5"), new Guid("3a3fe77a-5d55-31af-7f10-bdc02e98ba98") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("25a1511e-a58a-be8b-7432-396de82947c5"), new Guid("3e72e500-600b-5e36-1276-430aaef98e88") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("25a1511e-a58a-be8b-7432-396de82947c5"), new Guid("7af26624-3d13-f1a8-b4ee-d702ed3ee98b") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("25a1511e-a58a-be8b-7432-396de82947c5"), new Guid("837f88a2-0196-46ea-4bd8-c7e582efce6d") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("25a1511e-a58a-be8b-7432-396de82947c5"), new Guid("97ad87cb-59b6-2896-2fe0-29761f4b433a") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("25a1511e-a58a-be8b-7432-396de82947c5"), new Guid("aedf2bad-9d7f-3494-a9bc-159f461be23c") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("25a1511e-a58a-be8b-7432-396de82947c5"), new Guid("ef6b498e-d709-59a5-2e77-1378b07d162a") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("2ee09359-2bfc-1529-9f70-beffe5e4dcf0"), new Guid("13758096-2798-8c2a-ab04-12577b3a903a") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("2ee09359-2bfc-1529-9f70-beffe5e4dcf0"), new Guid("1a148937-7fc7-a76c-f21e-90f1863c07b0") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("2ee09359-2bfc-1529-9f70-beffe5e4dcf0"), new Guid("aa6a225c-8f5a-42a5-c7e5-c437955d17dd") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("2ee09359-2bfc-1529-9f70-beffe5e4dcf0"), new Guid("bd75b3bf-7b9e-6f85-b002-699888630d34") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("49254e2d-b50e-79a1-700d-a9f40c5c904b"), new Guid("0cf8855d-56b9-6e58-c1fb-d9f1d1a4b65b") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("49254e2d-b50e-79a1-700d-a9f40c5c904b"), new Guid("43e9c98c-e32c-5a1f-a084-4c2cc88d46b8") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("49254e2d-b50e-79a1-700d-a9f40c5c904b"), new Guid("7e1318f9-2ac4-1440-9d78-3b6a40887902") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("49254e2d-b50e-79a1-700d-a9f40c5c904b"), new Guid("9fdea678-4a21-6d13-4185-9484e1a21ecd") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("49254e2d-b50e-79a1-700d-a9f40c5c904b"), new Guid("aa6a225c-8f5a-42a5-c7e5-c437955d17dd") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("49254e2d-b50e-79a1-700d-a9f40c5c904b"), new Guid("e4b2fb33-a8f8-ddde-52ad-5dd26ad14d28") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("4c0711bd-98ad-fd01-b0fb-91e60c334099"), new Guid("43e9c98c-e32c-5a1f-a084-4c2cc88d46b8") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("4c0711bd-98ad-fd01-b0fb-91e60c334099"), new Guid("5a51617a-c61e-6e44-ac6f-cb0cfc319fc4") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("4c0711bd-98ad-fd01-b0fb-91e60c334099"), new Guid("aedf2bad-9d7f-3494-a9bc-159f461be23c") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("5eb1373c-be8d-e655-95be-4635cf14f706"), new Guid("13758096-2798-8c2a-ab04-12577b3a903a") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("5eb1373c-be8d-e655-95be-4635cf14f706"), new Guid("1a148937-7fc7-a76c-f21e-90f1863c07b0") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("5eb1373c-be8d-e655-95be-4635cf14f706"), new Guid("73d2374f-b29e-3878-4f6b-03ecda0971f2") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("5eb1373c-be8d-e655-95be-4635cf14f706"), new Guid("aedf2bad-9d7f-3494-a9bc-159f461be23c") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("5eb1373c-be8d-e655-95be-4635cf14f706"), new Guid("e2b819c9-1489-5992-82a4-2f276b5b46c7") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("5eb1373c-be8d-e655-95be-4635cf14f706"), new Guid("e4b2fb33-a8f8-ddde-52ad-5dd26ad14d28") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("6d358d5b-4c47-d8e3-0c24-3c6ce4aab9d1"), new Guid("53e44b8d-9a60-90d0-89c5-7b79d0263d0e") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("6d358d5b-4c47-d8e3-0c24-3c6ce4aab9d1"), new Guid("7af26624-3d13-f1a8-b4ee-d702ed3ee98b") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("6d358d5b-4c47-d8e3-0c24-3c6ce4aab9d1"), new Guid("bbe43911-8a37-4194-0554-fa3f0057d472") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("7af11948-bd4b-3db9-1c87-cba466159900"), new Guid("4e58f4d9-8722-e51c-b883-9472ec0cf175") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("7af11948-bd4b-3db9-1c87-cba466159900"), new Guid("5af36740-6b5e-dd88-657c-e998dbdafd1c") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("7af11948-bd4b-3db9-1c87-cba466159900"), new Guid("97ad87cb-59b6-2896-2fe0-29761f4b433a") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("7af11948-bd4b-3db9-1c87-cba466159900"), new Guid("aa6a225c-8f5a-42a5-c7e5-c437955d17dd") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("7af11948-bd4b-3db9-1c87-cba466159900"), new Guid("bd75b3bf-7b9e-6f85-b002-699888630d34") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("809bebbf-5f3f-dd6c-a0bb-665731e16d2d"), new Guid("15399ce7-2363-7a4e-8cf7-731e37254e0c") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("809bebbf-5f3f-dd6c-a0bb-665731e16d2d"), new Guid("387e8afa-c868-0209-3097-4927f9ddd08d") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("809bebbf-5f3f-dd6c-a0bb-665731e16d2d"), new Guid("3e72e500-600b-5e36-1276-430aaef98e88") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("809bebbf-5f3f-dd6c-a0bb-665731e16d2d"), new Guid("5af36740-6b5e-dd88-657c-e998dbdafd1c") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("809bebbf-5f3f-dd6c-a0bb-665731e16d2d"), new Guid("7e1318f9-2ac4-1440-9d78-3b6a40887902") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("809bebbf-5f3f-dd6c-a0bb-665731e16d2d"), new Guid("b565bd17-ff21-9e0b-73ba-6e9e5098f113") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("809bebbf-5f3f-dd6c-a0bb-665731e16d2d"), new Guid("c57b9c69-a674-61d8-4370-7330f453bac3") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("81d3a165-5f39-19ca-df20-3613a1faaa58"), new Guid("0cf8855d-56b9-6e58-c1fb-d9f1d1a4b65b") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("81d3a165-5f39-19ca-df20-3613a1faaa58"), new Guid("43e9c98c-e32c-5a1f-a084-4c2cc88d46b8") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("81d3a165-5f39-19ca-df20-3613a1faaa58"), new Guid("5a51617a-c61e-6e44-ac6f-cb0cfc319fc4") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("81d3a165-5f39-19ca-df20-3613a1faaa58"), new Guid("630acb88-0a1d-532f-d5c5-be26165ec3b3") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("81d3a165-5f39-19ca-df20-3613a1faaa58"), new Guid("8ed2a6dc-ab6c-7d80-62c1-0059b7c7553d") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("81d3a165-5f39-19ca-df20-3613a1faaa58"), new Guid("a51063b3-72ee-8ed2-8750-4cfab6fd4dc4") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("81d3a165-5f39-19ca-df20-3613a1faaa58"), new Guid("ae5241da-807e-6cd9-8d3f-ff7a859c8d70") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("81d3a165-5f39-19ca-df20-3613a1faaa58"), new Guid("aedf2bad-9d7f-3494-a9bc-159f461be23c") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("81d3a165-5f39-19ca-df20-3613a1faaa58"), new Guid("bb0b585d-3ba7-17c4-b1a1-0f472c160bb2") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("81d3a165-5f39-19ca-df20-3613a1faaa58"), new Guid("ef6b498e-d709-59a5-2e77-1378b07d162a") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("a6b7e634-fd02-c9c2-9b4c-1ba4d912561f"), new Guid("0cf8855d-56b9-6e58-c1fb-d9f1d1a4b65b") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("a6b7e634-fd02-c9c2-9b4c-1ba4d912561f"), new Guid("15399ce7-2363-7a4e-8cf7-731e37254e0c") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("a6b7e634-fd02-c9c2-9b4c-1ba4d912561f"), new Guid("a51063b3-72ee-8ed2-8750-4cfab6fd4dc4") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("a6b7e634-fd02-c9c2-9b4c-1ba4d912561f"), new Guid("aedf2bad-9d7f-3494-a9bc-159f461be23c") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("a6b7e634-fd02-c9c2-9b4c-1ba4d912561f"), new Guid("e2b819c9-1489-5992-82a4-2f276b5b46c7") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("ad6c5056-2792-71ae-08d0-a1ef172266cb"), new Guid("164778f9-51b3-97d8-4d12-c194e3cfa18d") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("ad6c5056-2792-71ae-08d0-a1ef172266cb"), new Guid("3e72e500-600b-5e36-1276-430aaef98e88") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("ad6c5056-2792-71ae-08d0-a1ef172266cb"), new Guid("aedf2bad-9d7f-3494-a9bc-159f461be23c") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("ad6c5056-2792-71ae-08d0-a1ef172266cb"), new Guid("c57b9c69-a674-61d8-4370-7330f453bac3") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("b1578d7a-3f6b-c66a-c1d1-152de3c6761a"), new Guid("53e44b8d-9a60-90d0-89c5-7b79d0263d0e") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("b1578d7a-3f6b-c66a-c1d1-152de3c6761a"), new Guid("630acb88-0a1d-532f-d5c5-be26165ec3b3") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("b1578d7a-3f6b-c66a-c1d1-152de3c6761a"), new Guid("8ed2a6dc-ab6c-7d80-62c1-0059b7c7553d") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("b1578d7a-3f6b-c66a-c1d1-152de3c6761a"), new Guid("aa6a225c-8f5a-42a5-c7e5-c437955d17dd") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("b1578d7a-3f6b-c66a-c1d1-152de3c6761a"), new Guid("bbe43911-8a37-4194-0554-fa3f0057d472") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("c833dda0-54e6-6faa-f032-32e589e5ca24"), new Guid("15399ce7-2363-7a4e-8cf7-731e37254e0c") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("c833dda0-54e6-6faa-f032-32e589e5ca24"), new Guid("837f88a2-0196-46ea-4bd8-c7e582efce6d") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("c833dda0-54e6-6faa-f032-32e589e5ca24"), new Guid("9fdea678-4a21-6d13-4185-9484e1a21ecd") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("c833dda0-54e6-6faa-f032-32e589e5ca24"), new Guid("ae5241da-807e-6cd9-8d3f-ff7a859c8d70") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("c833dda0-54e6-6faa-f032-32e589e5ca24"), new Guid("bd75b3bf-7b9e-6f85-b002-699888630d34") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("c833dda0-54e6-6faa-f032-32e589e5ca24"), new Guid("c57b9c69-a674-61d8-4370-7330f453bac3") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("db441324-6239-3d46-2588-f9995b980705"), new Guid("43012557-3290-a4eb-563d-b8cc47104671") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("db441324-6239-3d46-2588-f9995b980705"), new Guid("4e58f4d9-8722-e51c-b883-9472ec0cf175") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("db441324-6239-3d46-2588-f9995b980705"), new Guid("630acb88-0a1d-532f-d5c5-be26165ec3b3") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("db441324-6239-3d46-2588-f9995b980705"), new Guid("ae5241da-807e-6cd9-8d3f-ff7a859c8d70") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("db441324-6239-3d46-2588-f9995b980705"), new Guid("ef6b498e-d709-59a5-2e77-1378b07d162a") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("dea5b154-0f62-f38b-45d7-8e6de75dc429"), new Guid("2765b367-5555-f7ce-d601-f57e43f2b8e7") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("dea5b154-0f62-f38b-45d7-8e6de75dc429"), new Guid("387e8afa-c868-0209-3097-4927f9ddd08d") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("dea5b154-0f62-f38b-45d7-8e6de75dc429"), new Guid("8ed2a6dc-ab6c-7d80-62c1-0059b7c7553d") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("dea5b154-0f62-f38b-45d7-8e6de75dc429"), new Guid("a51063b3-72ee-8ed2-8750-4cfab6fd4dc4") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("dea5b154-0f62-f38b-45d7-8e6de75dc429"), new Guid("ae5241da-807e-6cd9-8d3f-ff7a859c8d70") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("dea5b154-0f62-f38b-45d7-8e6de75dc429"), new Guid("bd75b3bf-7b9e-6f85-b002-699888630d34") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("dea5b154-0f62-f38b-45d7-8e6de75dc429"), new Guid("e2b819c9-1489-5992-82a4-2f276b5b46c7") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("dea5b154-0f62-f38b-45d7-8e6de75dc429"), new Guid("e4b2fb33-a8f8-ddde-52ad-5dd26ad14d28") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("dea5b154-0f62-f38b-45d7-8e6de75dc429"), new Guid("ef6b498e-d709-59a5-2e77-1378b07d162a") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("e0a19ea9-07c4-5008-6682-831a78d0da67"), new Guid("15399ce7-2363-7a4e-8cf7-731e37254e0c") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("e0a19ea9-07c4-5008-6682-831a78d0da67"), new Guid("1a0d5d93-6710-49ec-6f9c-2b0bd9efadf8") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("e0a19ea9-07c4-5008-6682-831a78d0da67"), new Guid("3a3fe77a-5d55-31af-7f10-bdc02e98ba98") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("ef952bb5-ab7c-d56d-dd72-67bd43728941"), new Guid("13758096-2798-8c2a-ab04-12577b3a903a") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("ef952bb5-ab7c-d56d-dd72-67bd43728941"), new Guid("3a3fe77a-5d55-31af-7f10-bdc02e98ba98") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("ef952bb5-ab7c-d56d-dd72-67bd43728941"), new Guid("3e72e500-600b-5e36-1276-430aaef98e88") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("ef952bb5-ab7c-d56d-dd72-67bd43728941"), new Guid("53e44b8d-9a60-90d0-89c5-7b79d0263d0e") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("ef952bb5-ab7c-d56d-dd72-67bd43728941"), new Guid("5af36740-6b5e-dd88-657c-e998dbdafd1c") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("ef952bb5-ab7c-d56d-dd72-67bd43728941"), new Guid("ae5241da-807e-6cd9-8d3f-ff7a859c8d70") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("ef952bb5-ab7c-d56d-dd72-67bd43728941"), new Guid("e4b2fb33-a8f8-ddde-52ad-5dd26ad14d28") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("f6e13a85-6bf8-5a06-e8de-f0fae9b599a6"), new Guid("0cf8855d-56b9-6e58-c1fb-d9f1d1a4b65b") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("f6e13a85-6bf8-5a06-e8de-f0fae9b599a6"), new Guid("13758096-2798-8c2a-ab04-12577b3a903a") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("f6e13a85-6bf8-5a06-e8de-f0fae9b599a6"), new Guid("43012557-3290-a4eb-563d-b8cc47104671") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("f6e13a85-6bf8-5a06-e8de-f0fae9b599a6"), new Guid("53e44b8d-9a60-90d0-89c5-7b79d0263d0e") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("f6e13a85-6bf8-5a06-e8de-f0fae9b599a6"), new Guid("5a51617a-c61e-6e44-ac6f-cb0cfc319fc4") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("f6e13a85-6bf8-5a06-e8de-f0fae9b599a6"), new Guid("aedf2bad-9d7f-3494-a9bc-159f461be23c") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("f6e13a85-6bf8-5a06-e8de-f0fae9b599a6"), new Guid("b565bd17-ff21-9e0b-73ba-6e9e5098f113") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("f6e13a85-6bf8-5a06-e8de-f0fae9b599a6"), new Guid("bb0b585d-3ba7-17c4-b1a1-0f472c160bb2") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("f6e13a85-6bf8-5a06-e8de-f0fae9b599a6"), new Guid("bbe43911-8a37-4194-0554-fa3f0057d472") });

            migrationBuilder.DeleteData(
                table: "PlaylistSong",
                keyColumns: new[] { "PlaylistsId", "SongsId" },
                keyValues: new object[] { new Guid("f6e13a85-6bf8-5a06-e8de-f0fae9b599a6"), new Guid("c57b9c69-a674-61d8-4370-7330f453bac3") });

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: new Guid("053215db-3ae2-25ef-4c5e-075499b181d1"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: new Guid("1231d47f-bbe0-6ea2-81c8-8031f795553c"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: new Guid("25a1511e-a58a-be8b-7432-396de82947c5"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: new Guid("2ee09359-2bfc-1529-9f70-beffe5e4dcf0"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: new Guid("49254e2d-b50e-79a1-700d-a9f40c5c904b"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: new Guid("4c0711bd-98ad-fd01-b0fb-91e60c334099"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: new Guid("5eb1373c-be8d-e655-95be-4635cf14f706"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: new Guid("6d358d5b-4c47-d8e3-0c24-3c6ce4aab9d1"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: new Guid("7af11948-bd4b-3db9-1c87-cba466159900"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: new Guid("809bebbf-5f3f-dd6c-a0bb-665731e16d2d"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: new Guid("81d3a165-5f39-19ca-df20-3613a1faaa58"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: new Guid("a6b7e634-fd02-c9c2-9b4c-1ba4d912561f"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: new Guid("ad6c5056-2792-71ae-08d0-a1ef172266cb"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: new Guid("b1578d7a-3f6b-c66a-c1d1-152de3c6761a"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: new Guid("c833dda0-54e6-6faa-f032-32e589e5ca24"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: new Guid("db441324-6239-3d46-2588-f9995b980705"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: new Guid("dea5b154-0f62-f38b-45d7-8e6de75dc429"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: new Guid("e0a19ea9-07c4-5008-6682-831a78d0da67"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: new Guid("ef952bb5-ab7c-d56d-dd72-67bd43728941"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: new Guid("f6e13a85-6bf8-5a06-e8de-f0fae9b599a6"));
        }
    }
}
