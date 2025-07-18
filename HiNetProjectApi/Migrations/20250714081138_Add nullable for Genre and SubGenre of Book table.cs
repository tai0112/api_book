using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HiNetProjectApi.Migrations
{
    /// <inheritdoc />
    public partial class AddnullableforGenreandSubGenreofBooktable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_SubGenres_SubGenreId",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("3b5a1969-38ef-4acb-ab95-e4fd2318c122"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("44022059-0fc2-4aa2-a55a-204d1d59ab24"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("53a563af-afed-4305-824c-6102684b7412"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("8e0e126b-6fc8-4e79-90fe-92709cb215fe"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("999d7097-793b-4e47-9150-70fcd4b7d64e"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("c82076f3-c6ff-425c-9c23-a0a11466dfa0"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("c8c3a4d7-07d8-4f25-b012-6d862fc91658"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("ca84d295-030c-4977-af47-7775ebfe141f"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("dd603660-ff89-438b-9818-53c6eb213d25"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("deea17bd-1d39-4c3c-bcbf-4c5c745df20e"));

            migrationBuilder.DeleteData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: new Guid("3e8388fd-6ea1-411a-a195-57e22f8bf49b"));

            migrationBuilder.DeleteData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: new Guid("bad95cb6-3404-48e7-b679-315e32d35148"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0562264c-93a0-4028-8e7a-7c26ce0e4861"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("158c87a6-fd22-43a8-b24a-9d2b6a5c5951"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("48c2b184-c674-4ae7-aeeb-fb02ebe3618a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5367fd9e-65e7-41ef-b03e-c290666451c1"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("97305923-396f-4683-ae33-4832511b7ce9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c09ad71a-fef6-44a4-86ca-9f7056897c1c"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("27094dcd-45e2-47cf-8f9b-2ca598e052ba"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3629a780-90dd-4f74-b4d4-537af3d276cb"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("384ca01c-cd82-4762-a253-82f369331154"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("389fe16b-5ffe-47e9-a0a9-6126c1180d8c"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("73888777-ac09-416b-8b9a-52e99f2aabc0"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("a6e74408-7315-472d-a67c-415e44625279"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("c3cac1c9-6993-4842-b3ce-a117e91fdfa0"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("d98fbda3-5e49-49b0-8521-5e1a18bf25e8"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("d9e470e2-fc95-41d4-8ca1-b0c277351606"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("f8deecf9-a8eb-45f6-8bf7-0badbb9b0cdd"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("00eb75ea-9bc6-433e-ad27-a461a263cc0f"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("14bb7214-315c-4266-9d4e-402ff55cb6c2"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("18f18f99-fa68-4d9b-899d-9c657132f3f9"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("4d238bd5-4a11-4162-ae9e-f802bcefca82"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("566537fb-3e08-4536-86c9-86a912b424f2"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("5d07c604-45ac-45b2-bc30-a66174a5b483"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("5f391581-1824-4a68-bf0a-92b9fe6c76f6"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("a0fc9a18-08ad-4ac3-9f14-7a2f6145f744"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("b5e9cbb2-9e5e-4c1d-8223-cfee0691c86d"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("eda20bf2-6811-4067-8415-a5c3d6436793"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("64d7e846-c8b8-4ed4-b8b0-21a8eae71e7c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("78680657-e980-43e1-83b0-3e81ce2e312f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9a95311e-9c09-4f40-9c83-d7c488565f19"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("fe461828-773a-4d70-b3a3-06d94bf9405d"));

            migrationBuilder.AlterColumn<Guid>(
                name: "SubGenreId",
                table: "Books",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "GenreId",
                table: "Books",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AgeRatings",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("2f1b3994-b94e-47cd-b091-1e04cbd7ddab"), "Dành cho trẻ em cấp 1 trở lên. Nội dung có thể bao gồm xung đột nhẹ hoặc bài học đạo đức.", "10+" },
                    { new Guid("6dc99a47-1457-4ae0-aa37-4342f2bc27ca"), "Dành cho trẻ em từ 3 tuổi trở lên. Nội dung đơn giản, không có yếu tố bạo lực hoặc gây sợ hãi.", "3+" },
                    { new Guid("81d4da79-361c-4d28-8620-71989a8361c2"), "Phù hợp với mọi lứa tuổi, kể cả trẻ sơ sinh và mẫu giáo.", "0+" },
                    { new Guid("8a8fc89a-4660-4593-82a8-885bfe09e7e2"), "Có thể có yếu tố bạo lực nhẹ, ngôn ngữ mạnh hoặc đề cập đến các chủ đề xã hội nghiêm túc.", "16+" },
                    { new Guid("99fda5c8-9aed-4f03-a875-c9b7c5a1e775"), "Phù hợp với học sinh từ tiểu học đến trung học.", "Học sinh" },
                    { new Guid("a8bc3473-9334-4a94-b31c-e3edcfcf156f"), "Nội dung phức tạp hơn, phù hợp với học sinh cấp 3. Có thể có yếu tố tình cảm hoặc suy nghĩ cá nhân.", "15+" },
                    { new Guid("b459af96-bdc0-401b-b954-7ec73eb28ff7"), "Dành cho người trưởng thành. Có thể chứa nội dung bạo lực, tâm lý phức tạp hoặc tình dục.", "18+" },
                    { new Guid("caf342ce-009f-42b5-8cbd-61680581780a"), "Dành cho trẻ em bắt đầu đọc, có thể có nội dung giáo dục và tưởng tượng nhẹ.", "6+" },
                    { new Guid("e15c1ac8-4f28-4fb2-b59e-913b732a1b3a"), "Dành cho thiếu niên. Có thể đề cập đến các vấn đề xã hội, học đường, tâm lý tuổi mới lớn.", "12+" },
                    { new Guid("ee96e98d-3f0e-4dd2-a975-37ffbefcda71"), "Dành cho người trưởng thành trẻ tuổi với nội dung chuyên môn, phát triển bản thân, hoặc kỹ năng sống.", "Sinh viên - Người đi làm" }
                });

            migrationBuilder.InsertData(
                table: "CoverTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1875d341-3c11-4e92-a14f-7828f573d733"), "Bìa mềm" },
                    { new Guid("99cde528-983d-43f7-aa06-a545bc6ce94a"), "Bìa cứng" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreateAt", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("0c12eebc-5d10-4b26-ae0b-92bb3cf2c90d"), new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1060), "Tiểu sử - Hồi ký", new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1061) },
                    { new Guid("0da55ff4-4c43-487e-bd43-b422454eb7e9"), new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1045), "Lịch sử", new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1045) },
                    { new Guid("579e8186-852a-410e-b166-808f46bf5a54"), new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1035), "Tâm lý - Tình cảm", new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1036) },
                    { new Guid("5baa5386-5a6f-4096-bff7-96e38ad8405b"), new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1028), "Khoa học - Công nghệ", new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1029) },
                    { new Guid("7c361f8c-0da9-4265-8aeb-db34ac0523d2"), new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1040), "Thiếu nhi", new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1041) },
                    { new Guid("90b8c1d3-4c06-44b8-9323-8ae7ec4679df"), new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1053), "Văn hóa - Xã hội", new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1054) },
                    { new Guid("970d34ee-7471-461b-b34d-11eb6e7507c4"), new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1023), "Giáo dục", new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1024) },
                    { new Guid("daf93d3f-f3af-4df7-9f11-b9d64392b629"), new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(944), "Kinh tế", new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(945) },
                    { new Guid("e634bcd2-3743-414a-aa2f-ed8b9cab9521"), new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(950), "Kỹ năng sống", new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(951) },
                    { new Guid("fed37f37-8b9c-42dc-8d25-20605ef4ac31"), new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(932), "Văn học", new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(937) }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1b7fd93a-635e-48e9-be1c-b76d116f0ce7"), "Nhà xuất bản Hội Nhà Văn" },
                    { new Guid("33d4e422-da76-48ce-9589-b8ce4584150d"), "Nhà xuất bản Tổng hợp TP.HCM" },
                    { new Guid("3dad09b6-2090-465c-a85b-a14dacd97c14"), "Nhà xuất bản Chính Trị Quốc Gia Sự Thật" },
                    { new Guid("3de2bdb0-b028-48f0-a6c3-de96a19d4050"), "Nhà xuất bản Văn Học" },
                    { new Guid("46dbbf8b-483d-45b8-9f9e-a10b79b00b61"), "Nhà xuất bản Phụ Nữ" },
                    { new Guid("6f5840d9-a188-4da5-84f4-5c210a99c1dc"), "Nhà xuất bản Lao Động" },
                    { new Guid("70ccb254-e7b8-4648-b9f8-8ed6bdec198d"), "Nhà xuất bản Giáo Dục Việt Nam" },
                    { new Guid("7d28e2fc-32ff-401b-b278-fe4dbd07d1fd"), "Nhà xuất bản Thanh Niên" },
                    { new Guid("c4363d2d-484c-48c5-b63c-b495827700c1"), "Nhà xuất bản Kim Đồng" },
                    { new Guid("cd0af7b2-8924-42c7-ba9d-07efd4afb0e4"), "Nhà xuất bản Trẻ" }
                });

            migrationBuilder.InsertData(
                table: "SubGenres",
                columns: new[] { "Id", "CreateAt", "GenreId", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("11640cd3-4a3c-4f84-9cdc-084a640a4d06"), new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1217), new Guid("970d34ee-7471-461b-b34d-11eb6e7507c4"), "Giáo dục sớm", new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1218) },
                    { new Guid("21c05c10-0f98-4941-8878-1f3d441f42b2"), new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1180), new Guid("daf93d3f-f3af-4df7-9f11-b9d64392b629"), "Marketing", new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1181) },
                    { new Guid("2be3e12e-96d7-435f-90aa-ba285070e6ae"), new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1157), new Guid("fed37f37-8b9c-42dc-8d25-20605ef4ac31"), "Tiểu thuyết", new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1158) },
                    { new Guid("4bd064bc-535f-4f6d-8cb0-ecfa75b82ec7"), new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1186), new Guid("daf93d3f-f3af-4df7-9f11-b9d64392b629"), "Khởi nghiệp", new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1187) },
                    { new Guid("5a7cbd2f-2e58-47b5-a19a-ed881420d0d2"), new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1225), new Guid("970d34ee-7471-461b-b34d-11eb6e7507c4"), "Tâm lý học đường", new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1226) },
                    { new Guid("664c516d-7489-4482-9468-fa1ccfd23faa"), new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1211), new Guid("e634bcd2-3743-414a-aa2f-ed8b9cab9521"), "Kỹ năng giao tiếp", new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1211) },
                    { new Guid("db884951-854b-4c60-bf95-88cf40f6be8f"), new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1204), new Guid("e634bcd2-3743-414a-aa2f-ed8b9cab9521"), "Tư duy tích cực", new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1205) },
                    { new Guid("dd12d2e9-8253-4e63-a92d-62e2fe202d49"), new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1193), new Guid("e634bcd2-3743-414a-aa2f-ed8b9cab9521"), "Phát triển bản thân", new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1193) },
                    { new Guid("dd44480d-6e49-415d-86e7-55f987e10405"), new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1173), new Guid("fed37f37-8b9c-42dc-8d25-20605ef4ac31"), "Thơ", new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1174) },
                    { new Guid("e5d456d2-87fe-43b5-b4cf-dbb0e3582e96"), new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1167), new Guid("fed37f37-8b9c-42dc-8d25-20605ef4ac31"), "Truyện ngắn", new DateTime(2025, 7, 14, 8, 11, 35, 798, DateTimeKind.Utc).AddTicks(1168) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Genres_GenreId",
                table: "Books",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_SubGenres_SubGenreId",
                table: "Books",
                column: "SubGenreId",
                principalTable: "SubGenres",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Genres_GenreId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_SubGenres_SubGenreId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_GenreId",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("2f1b3994-b94e-47cd-b091-1e04cbd7ddab"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("6dc99a47-1457-4ae0-aa37-4342f2bc27ca"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("81d4da79-361c-4d28-8620-71989a8361c2"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("8a8fc89a-4660-4593-82a8-885bfe09e7e2"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("99fda5c8-9aed-4f03-a875-c9b7c5a1e775"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("a8bc3473-9334-4a94-b31c-e3edcfcf156f"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("b459af96-bdc0-401b-b954-7ec73eb28ff7"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("caf342ce-009f-42b5-8cbd-61680581780a"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("e15c1ac8-4f28-4fb2-b59e-913b732a1b3a"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("ee96e98d-3f0e-4dd2-a975-37ffbefcda71"));

            migrationBuilder.DeleteData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: new Guid("1875d341-3c11-4e92-a14f-7828f573d733"));

            migrationBuilder.DeleteData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: new Guid("99cde528-983d-43f7-aa06-a545bc6ce94a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0c12eebc-5d10-4b26-ae0b-92bb3cf2c90d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0da55ff4-4c43-487e-bd43-b422454eb7e9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("579e8186-852a-410e-b166-808f46bf5a54"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5baa5386-5a6f-4096-bff7-96e38ad8405b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7c361f8c-0da9-4265-8aeb-db34ac0523d2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("90b8c1d3-4c06-44b8-9323-8ae7ec4679df"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("1b7fd93a-635e-48e9-be1c-b76d116f0ce7"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("33d4e422-da76-48ce-9589-b8ce4584150d"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3dad09b6-2090-465c-a85b-a14dacd97c14"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3de2bdb0-b028-48f0-a6c3-de96a19d4050"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("46dbbf8b-483d-45b8-9f9e-a10b79b00b61"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6f5840d9-a188-4da5-84f4-5c210a99c1dc"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("70ccb254-e7b8-4648-b9f8-8ed6bdec198d"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("7d28e2fc-32ff-401b-b278-fe4dbd07d1fd"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("c4363d2d-484c-48c5-b63c-b495827700c1"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cd0af7b2-8924-42c7-ba9d-07efd4afb0e4"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("11640cd3-4a3c-4f84-9cdc-084a640a4d06"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("21c05c10-0f98-4941-8878-1f3d441f42b2"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("2be3e12e-96d7-435f-90aa-ba285070e6ae"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("4bd064bc-535f-4f6d-8cb0-ecfa75b82ec7"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("5a7cbd2f-2e58-47b5-a19a-ed881420d0d2"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("664c516d-7489-4482-9468-fa1ccfd23faa"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("db884951-854b-4c60-bf95-88cf40f6be8f"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("dd12d2e9-8253-4e63-a92d-62e2fe202d49"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("dd44480d-6e49-415d-86e7-55f987e10405"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("e5d456d2-87fe-43b5-b4cf-dbb0e3582e96"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("970d34ee-7471-461b-b34d-11eb6e7507c4"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("daf93d3f-f3af-4df7-9f11-b9d64392b629"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e634bcd2-3743-414a-aa2f-ed8b9cab9521"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("fed37f37-8b9c-42dc-8d25-20605ef4ac31"));

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Books");

            migrationBuilder.AlterColumn<Guid>(
                name: "SubGenreId",
                table: "Books",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AgeRatings",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("3b5a1969-38ef-4acb-ab95-e4fd2318c122"), "Dành cho trẻ em từ 3 tuổi trở lên. Nội dung đơn giản, không có yếu tố bạo lực hoặc gây sợ hãi.", "3+" },
                    { new Guid("44022059-0fc2-4aa2-a55a-204d1d59ab24"), "Dành cho người trưởng thành trẻ tuổi với nội dung chuyên môn, phát triển bản thân, hoặc kỹ năng sống.", "Sinh viên - Người đi làm" },
                    { new Guid("53a563af-afed-4305-824c-6102684b7412"), "Nội dung phức tạp hơn, phù hợp với học sinh cấp 3. Có thể có yếu tố tình cảm hoặc suy nghĩ cá nhân.", "15+" },
                    { new Guid("8e0e126b-6fc8-4e79-90fe-92709cb215fe"), "Dành cho người trưởng thành. Có thể chứa nội dung bạo lực, tâm lý phức tạp hoặc tình dục.", "18+" },
                    { new Guid("999d7097-793b-4e47-9150-70fcd4b7d64e"), "Dành cho thiếu niên. Có thể đề cập đến các vấn đề xã hội, học đường, tâm lý tuổi mới lớn.", "12+" },
                    { new Guid("c82076f3-c6ff-425c-9c23-a0a11466dfa0"), "Dành cho trẻ em bắt đầu đọc, có thể có nội dung giáo dục và tưởng tượng nhẹ.", "6+" },
                    { new Guid("c8c3a4d7-07d8-4f25-b012-6d862fc91658"), "Dành cho trẻ em cấp 1 trở lên. Nội dung có thể bao gồm xung đột nhẹ hoặc bài học đạo đức.", "10+" },
                    { new Guid("ca84d295-030c-4977-af47-7775ebfe141f"), "Phù hợp với học sinh từ tiểu học đến trung học.", "Học sinh" },
                    { new Guid("dd603660-ff89-438b-9818-53c6eb213d25"), "Có thể có yếu tố bạo lực nhẹ, ngôn ngữ mạnh hoặc đề cập đến các chủ đề xã hội nghiêm túc.", "16+" },
                    { new Guid("deea17bd-1d39-4c3c-bcbf-4c5c745df20e"), "Phù hợp với mọi lứa tuổi, kể cả trẻ sơ sinh và mẫu giáo.", "0+" }
                });

            migrationBuilder.InsertData(
                table: "CoverTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3e8388fd-6ea1-411a-a195-57e22f8bf49b"), "Bìa mềm" },
                    { new Guid("bad95cb6-3404-48e7-b679-315e32d35148"), "Bìa cứng" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreateAt", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("0562264c-93a0-4028-8e7a-7c26ce0e4861"), new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1595), "Thiếu nhi", new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1596) },
                    { new Guid("158c87a6-fd22-43a8-b24a-9d2b6a5c5951"), new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1593), "Tâm lý - Tình cảm", new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1594) },
                    { new Guid("48c2b184-c674-4ae7-aeeb-fb02ebe3618a"), new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1599), "Lịch sử", new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1600) },
                    { new Guid("5367fd9e-65e7-41ef-b03e-c290666451c1"), new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1604), "Tiểu sử - Hồi ký", new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1604) },
                    { new Guid("64d7e846-c8b8-4ed4-b8b0-21a8eae71e7c"), new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1587), "Kỹ năng sống", new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1587) },
                    { new Guid("78680657-e980-43e1-83b0-3e81ce2e312f"), new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1578), "Văn học", new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1582) },
                    { new Guid("97305923-396f-4683-ae33-4832511b7ce9"), new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1601), "Văn hóa - Xã hội", new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1602) },
                    { new Guid("9a95311e-9c09-4f40-9c83-d7c488565f19"), new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1589), "Giáo dục", new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1589) },
                    { new Guid("c09ad71a-fef6-44a4-86ca-9f7056897c1c"), new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1591), "Khoa học - Công nghệ", new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1591) },
                    { new Guid("fe461828-773a-4d70-b3a3-06d94bf9405d"), new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1585), "Kinh tế", new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1585) }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("27094dcd-45e2-47cf-8f9b-2ca598e052ba"), "Nhà xuất bản Lao Động" },
                    { new Guid("3629a780-90dd-4f74-b4d4-537af3d276cb"), "Nhà xuất bản Chính Trị Quốc Gia Sự Thật" },
                    { new Guid("384ca01c-cd82-4762-a253-82f369331154"), "Nhà xuất bản Hội Nhà Văn" },
                    { new Guid("389fe16b-5ffe-47e9-a0a9-6126c1180d8c"), "Nhà xuất bản Giáo Dục Việt Nam" },
                    { new Guid("73888777-ac09-416b-8b9a-52e99f2aabc0"), "Nhà xuất bản Văn Học" },
                    { new Guid("a6e74408-7315-472d-a67c-415e44625279"), "Nhà xuất bản Phụ Nữ" },
                    { new Guid("c3cac1c9-6993-4842-b3ce-a117e91fdfa0"), "Nhà xuất bản Thanh Niên" },
                    { new Guid("d98fbda3-5e49-49b0-8521-5e1a18bf25e8"), "Nhà xuất bản Trẻ" },
                    { new Guid("d9e470e2-fc95-41d4-8ca1-b0c277351606"), "Nhà xuất bản Tổng hợp TP.HCM" },
                    { new Guid("f8deecf9-a8eb-45f6-8bf7-0badbb9b0cdd"), "Nhà xuất bản Kim Đồng" }
                });

            migrationBuilder.InsertData(
                table: "SubGenres",
                columns: new[] { "Id", "CreateAt", "GenreId", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("00eb75ea-9bc6-433e-ad27-a461a263cc0f"), new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1656), new Guid("78680657-e980-43e1-83b0-3e81ce2e312f"), "Thơ", new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1657) },
                    { new Guid("14bb7214-315c-4266-9d4e-402ff55cb6c2"), new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1659), new Guid("fe461828-773a-4d70-b3a3-06d94bf9405d"), "Marketing", new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1659) },
                    { new Guid("18f18f99-fa68-4d9b-899d-9c657132f3f9"), new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1671), new Guid("64d7e846-c8b8-4ed4-b8b0-21a8eae71e7c"), "Kỹ năng giao tiếp", new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1671) },
                    { new Guid("4d238bd5-4a11-4162-ae9e-f802bcefca82"), new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1649), new Guid("78680657-e980-43e1-83b0-3e81ce2e312f"), "Tiểu thuyết", new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1651) },
                    { new Guid("566537fb-3e08-4536-86c9-86a912b424f2"), new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1654), new Guid("78680657-e980-43e1-83b0-3e81ce2e312f"), "Truyện ngắn", new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1654) },
                    { new Guid("5d07c604-45ac-45b2-bc30-a66174a5b483"), new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1661), new Guid("fe461828-773a-4d70-b3a3-06d94bf9405d"), "Khởi nghiệp", new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1662) },
                    { new Guid("5f391581-1824-4a68-bf0a-92b9fe6c76f6"), new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1666), new Guid("64d7e846-c8b8-4ed4-b8b0-21a8eae71e7c"), "Phát triển bản thân", new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1666) },
                    { new Guid("a0fc9a18-08ad-4ac3-9f14-7a2f6145f744"), new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1668), new Guid("64d7e846-c8b8-4ed4-b8b0-21a8eae71e7c"), "Tư duy tích cực", new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1669) },
                    { new Guid("b5e9cbb2-9e5e-4c1d-8223-cfee0691c86d"), new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1673), new Guid("9a95311e-9c09-4f40-9c83-d7c488565f19"), "Giáo dục sớm", new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1673) },
                    { new Guid("eda20bf2-6811-4067-8415-a5c3d6436793"), new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1675), new Guid("9a95311e-9c09-4f40-9c83-d7c488565f19"), "Tâm lý học đường", new DateTime(2025, 6, 19, 15, 52, 7, 711, DateTimeKind.Utc).AddTicks(1676) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_SubGenres_SubGenreId",
                table: "Books",
                column: "SubGenreId",
                principalTable: "SubGenres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
