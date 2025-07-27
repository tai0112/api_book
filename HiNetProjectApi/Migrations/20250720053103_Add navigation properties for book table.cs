using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HiNetProjectApi.Migrations
{
    /// <inheritdoc />
    public partial class Addnavigationpropertiesforbooktable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AgeRatings",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("04fc9b75-7b4c-447e-ba38-393b289a2001"), "Dành cho trẻ em bắt đầu đọc, có thể có nội dung giáo dục và tưởng tượng nhẹ.", "6+" },
                    { new Guid("0815a0d7-2a33-40cf-a8ac-245bc34e3d1d"), "Dành cho người trưởng thành trẻ tuổi với nội dung chuyên môn, phát triển bản thân, hoặc kỹ năng sống.", "Sinh viên - Người đi làm" },
                    { new Guid("24113ed2-9e93-44a4-b8bd-00faf815e3e0"), "Có thể có yếu tố bạo lực nhẹ, ngôn ngữ mạnh hoặc đề cập đến các chủ đề xã hội nghiêm túc.", "16+" },
                    { new Guid("245fbe60-6dda-4925-9cce-2439e0911095"), "Dành cho người trưởng thành. Có thể chứa nội dung bạo lực, tâm lý phức tạp hoặc tình dục.", "18+" },
                    { new Guid("55d418b6-b45e-4ae7-8ba1-7d757120d008"), "Nội dung phức tạp hơn, phù hợp với học sinh cấp 3. Có thể có yếu tố tình cảm hoặc suy nghĩ cá nhân.", "15+" },
                    { new Guid("57e4ae32-6823-497d-a9b9-95e574d28c57"), "Phù hợp với học sinh từ tiểu học đến trung học.", "Học sinh" },
                    { new Guid("8add367a-027c-4d19-9197-cf380a937a45"), "Dành cho trẻ em cấp 1 trở lên. Nội dung có thể bao gồm xung đột nhẹ hoặc bài học đạo đức.", "10+" },
                    { new Guid("ab1cfd6c-eddc-4f13-8454-d1d4fe3d0d2b"), "Phù hợp với mọi lứa tuổi, kể cả trẻ sơ sinh và mẫu giáo.", "0+" },
                    { new Guid("b6835aec-e0a0-412c-87da-3ca8781563d1"), "Dành cho trẻ em từ 3 tuổi trở lên. Nội dung đơn giản, không có yếu tố bạo lực hoặc gây sợ hãi.", "3+" },
                    { new Guid("edb402b7-4d09-4eff-ba13-08bc8a1ad2bc"), "Dành cho thiếu niên. Có thể đề cập đến các vấn đề xã hội, học đường, tâm lý tuổi mới lớn.", "12+" }
                });

            migrationBuilder.InsertData(
                table: "CoverTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("23d697c6-1cf7-4c07-a9d2-316858e0c478"), "Bìa mềm" },
                    { new Guid("4d49a038-1e9b-49ad-b18d-58f969f75a51"), "Bìa cứng" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreateAt", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("02830a27-6173-45b3-85d5-c50d756cb27a"), new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9683), "Giáo dục", new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9684) },
                    { new Guid("1c9a5a12-95d7-4ca0-bc05-6f251a1c4a6a"), new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9670), "Văn học", new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9673) },
                    { new Guid("226540af-ada0-4ac2-a091-c09279731fb9"), new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9690), "Tâm lý - Tình cảm", new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9691) },
                    { new Guid("28a2ed59-7aa6-4034-bbc2-22dfcb837a74"), new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9695), "Lịch sử", new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9696) },
                    { new Guid("3fb1948d-fac8-45aa-a67a-7cb42774a700"), new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9693), "Thiếu nhi", new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9693) },
                    { new Guid("5228074d-f995-43cd-8ab3-5d85b105ccaf"), new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9680), "Kỹ năng sống", new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9681) },
                    { new Guid("ab57b26c-2493-4c5a-b499-439fdd92c28b"), new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9700), "Văn hóa - Xã hội", new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9700) },
                    { new Guid("b6360f5d-b14e-4a96-8e9c-dd8476e7d1e4"), new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9686), "Khoa học - Công nghệ", new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9687) },
                    { new Guid("ced5f08f-7eef-48d3-8768-7635943b3adf"), new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9704), "Tiểu sử - Hồi ký", new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9705) },
                    { new Guid("e9283373-b190-4569-b9d6-ed8bf3531567"), new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9678), "Kinh tế", new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9678) }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0f1992e2-99f0-40bf-95ea-617075993d7a"), "Nhà xuất bản Tổng hợp TP.HCM" },
                    { new Guid("1014213b-98a1-4baf-bd33-e8bd0b28a410"), "Nhà xuất bản Kim Đồng" },
                    { new Guid("26d43222-2dd9-4594-a10e-b53865ace9b2"), "Nhà xuất bản Hội Nhà Văn" },
                    { new Guid("2af8eb99-6ec8-4ff1-85ad-16c379052582"), "Nhà xuất bản Chính Trị Quốc Gia Sự Thật" },
                    { new Guid("3ebe1fe6-a3cf-455d-9508-db9675959878"), "Nhà xuất bản Trẻ" },
                    { new Guid("528ee637-4fd5-4ca4-922c-e2519c5716f5"), "Nhà xuất bản Lao Động" },
                    { new Guid("a8d6b5b6-7a52-4499-ad12-1e4659fc601f"), "Nhà xuất bản Giáo Dục Việt Nam" },
                    { new Guid("c2165410-d280-420a-a0f3-995c01a091e9"), "Nhà xuất bản Văn Học" },
                    { new Guid("d21920d2-611b-409d-99f4-ef0f368f3e99"), "Nhà xuất bản Thanh Niên" },
                    { new Guid("f746b51a-e69b-467c-9aee-dbe6fe51afb0"), "Nhà xuất bản Phụ Nữ" }
                });

            migrationBuilder.InsertData(
                table: "SubGenres",
                columns: new[] { "Id", "CreateAt", "GenreId", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("313d0185-b2fa-4ee7-8729-1dc9ec9bbdf0"), new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9787), new Guid("5228074d-f995-43cd-8ab3-5d85b105ccaf"), "Kỹ năng giao tiếp", new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9787) },
                    { new Guid("533e5e9f-c3d7-4fb0-9b0d-31a84cacefaf"), new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9765), new Guid("1c9a5a12-95d7-4ca0-bc05-6f251a1c4a6a"), "Thơ", new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9769) },
                    { new Guid("5a5fd117-929c-44a0-bff7-bbc11932b379"), new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9774), new Guid("e9283373-b190-4569-b9d6-ed8bf3531567"), "Khởi nghiệp", new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9775) },
                    { new Guid("93ac0a34-29c5-47e3-93ac-766b48aad905"), new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9771), new Guid("e9283373-b190-4569-b9d6-ed8bf3531567"), "Marketing", new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9772) },
                    { new Guid("969cd023-202b-4fd3-8bca-807ab2a0a81c"), new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9794), new Guid("02830a27-6173-45b3-85d5-c50d756cb27a"), "Tâm lý học đường", new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9794) },
                    { new Guid("9d4f858e-e5d8-424a-a5c1-26e7eda45bfc"), new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9784), new Guid("5228074d-f995-43cd-8ab3-5d85b105ccaf"), "Tư duy tích cực", new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9784) },
                    { new Guid("c4c68b1e-6006-4385-aba6-a2786a7b1bec"), new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9762), new Guid("1c9a5a12-95d7-4ca0-bc05-6f251a1c4a6a"), "Truyện ngắn", new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9763) },
                    { new Guid("ecf096fc-af3c-4cce-9569-e9a2ca0d9be3"), new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9778), new Guid("5228074d-f995-43cd-8ab3-5d85b105ccaf"), "Phát triển bản thân", new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9779) },
                    { new Guid("eed3c7a5-f06e-4c43-aa82-eaeab1a3b83f"), new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9790), new Guid("02830a27-6173-45b3-85d5-c50d756cb27a"), "Giáo dục sớm", new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9790) },
                    { new Guid("efe1d5ce-c635-4787-b26b-fa25d42b9315"), new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9757), new Guid("1c9a5a12-95d7-4ca0-bc05-6f251a1c4a6a"), "Tiểu thuyết", new DateTime(2025, 7, 20, 5, 31, 0, 432, DateTimeKind.Utc).AddTicks(9758) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("04fc9b75-7b4c-447e-ba38-393b289a2001"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("0815a0d7-2a33-40cf-a8ac-245bc34e3d1d"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("24113ed2-9e93-44a4-b8bd-00faf815e3e0"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("245fbe60-6dda-4925-9cce-2439e0911095"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("55d418b6-b45e-4ae7-8ba1-7d757120d008"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("57e4ae32-6823-497d-a9b9-95e574d28c57"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("8add367a-027c-4d19-9197-cf380a937a45"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("ab1cfd6c-eddc-4f13-8454-d1d4fe3d0d2b"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("b6835aec-e0a0-412c-87da-3ca8781563d1"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("edb402b7-4d09-4eff-ba13-08bc8a1ad2bc"));

            migrationBuilder.DeleteData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: new Guid("23d697c6-1cf7-4c07-a9d2-316858e0c478"));

            migrationBuilder.DeleteData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: new Guid("4d49a038-1e9b-49ad-b18d-58f969f75a51"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("226540af-ada0-4ac2-a091-c09279731fb9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("28a2ed59-7aa6-4034-bbc2-22dfcb837a74"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("3fb1948d-fac8-45aa-a67a-7cb42774a700"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ab57b26c-2493-4c5a-b499-439fdd92c28b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b6360f5d-b14e-4a96-8e9c-dd8476e7d1e4"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ced5f08f-7eef-48d3-8768-7635943b3adf"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("0f1992e2-99f0-40bf-95ea-617075993d7a"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("1014213b-98a1-4baf-bd33-e8bd0b28a410"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("26d43222-2dd9-4594-a10e-b53865ace9b2"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("2af8eb99-6ec8-4ff1-85ad-16c379052582"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3ebe1fe6-a3cf-455d-9508-db9675959878"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("528ee637-4fd5-4ca4-922c-e2519c5716f5"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("a8d6b5b6-7a52-4499-ad12-1e4659fc601f"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("c2165410-d280-420a-a0f3-995c01a091e9"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("d21920d2-611b-409d-99f4-ef0f368f3e99"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("f746b51a-e69b-467c-9aee-dbe6fe51afb0"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("313d0185-b2fa-4ee7-8729-1dc9ec9bbdf0"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("533e5e9f-c3d7-4fb0-9b0d-31a84cacefaf"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("5a5fd117-929c-44a0-bff7-bbc11932b379"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("93ac0a34-29c5-47e3-93ac-766b48aad905"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("969cd023-202b-4fd3-8bca-807ab2a0a81c"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("9d4f858e-e5d8-424a-a5c1-26e7eda45bfc"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("c4c68b1e-6006-4385-aba6-a2786a7b1bec"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("ecf096fc-af3c-4cce-9569-e9a2ca0d9be3"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("eed3c7a5-f06e-4c43-aa82-eaeab1a3b83f"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("efe1d5ce-c635-4787-b26b-fa25d42b9315"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("02830a27-6173-45b3-85d5-c50d756cb27a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("1c9a5a12-95d7-4ca0-bc05-6f251a1c4a6a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5228074d-f995-43cd-8ab3-5d85b105ccaf"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e9283373-b190-4569-b9d6-ed8bf3531567"));

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
        }
    }
}
