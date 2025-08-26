using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HiNetProjectApi.Migrations
{
    /// <inheritdoc />
    public partial class removerelationshipnotificationtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_AspNetUsers_UserId",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications");

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("085f3507-a4b2-4da5-8a98-a35a1c0779d8"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("0dd4fc74-dd6a-43dd-8ff3-373761fb3196"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("954ed735-b683-47e0-844b-36f76fba7e64"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("a4e2b937-8bda-4f13-8ce9-b4fc9f8bc637"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("b0f73947-ef70-48c2-af3d-b717913c9881"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("c52a6109-aa5e-40b1-9f06-076f77c2d9d6"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("c76594ba-ad3d-47be-8220-81b38e712a06"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("d83238db-d0be-4192-b108-8f037fe38bd8"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("f8b05cbd-92b1-4704-9645-c88639d526c3"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("fff61113-26ca-423f-b85c-4dc6568e4982"));

            migrationBuilder.DeleteData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: new Guid("5877bba1-652b-497c-8acc-8199b0c00cf9"));

            migrationBuilder.DeleteData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: new Guid("b90a4146-a82e-4c4b-8636-aa1ee190ac3e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("094d5d57-195e-4216-95a2-02f0634f4927"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("51b657a5-832c-4b7b-b756-0a635ff739c9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5b94956c-6426-4ade-a502-be50377d05ca"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5f06f01f-b4c2-4644-98ec-d205eab9eb07"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("8b46d456-4e7a-4252-8dac-40115b205f5c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("99d5f27f-d17a-4d02-aeba-f944902f3f75"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("04dfd13c-9099-4c4e-b3c2-33ac857eb1ba"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("35c8cea6-deab-4b6f-9365-3f1a0c6f1317"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("4741a92e-ff56-48bd-8110-f3b639ebd481"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("49e84691-419a-4e27-841d-ff2e144ac065"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("727dfbe9-ae63-4b01-a17c-506da5c6dcd3"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("ae0b2d57-f7bd-47de-b3f5-320f10240226"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("d51db000-babf-4e95-8e7d-89f801cb734e"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("dd70fa4a-cf08-4262-9bbb-4f0bd138acf5"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("e7a8e169-a5d2-4eb3-9425-e5de0a32c98a"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("f994fcec-d184-467a-a664-63064d306d5a"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("142ed4e3-9ca1-4390-8541-8016c2a7fe68"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("40af47b6-1602-4b20-aa3b-db93f2ecc212"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("4b5989be-adcc-4840-bfa5-bdd39399bafc"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("65418997-1390-4cd6-8266-9efab8ea2c32"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("68a9e25a-eae6-4daf-9a68-34c69a6c6500"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("7324638b-0859-463b-aac0-e5151709bc40"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("827646f9-54d3-4bba-8eca-b71c76f6657d"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("91c13167-a565-4fc6-ae34-322791252cca"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("dea64975-e00c-405e-98ca-654c06b67274"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("eaa5da07-9c56-4a2b-a71a-ce7d58233e39"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("216c23c9-cdc5-4d70-9e46-c7103ac34114"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("8e75fd1f-cc4b-4f7c-8fd2-9709af8ddc0a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ed23fc64-0b03-4676-8ee4-157990e589d0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ed2ffafb-aacd-4c02-876c-3b0fbc8cf015"));

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "AgeRatings",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("2c994161-5662-443b-b9ab-6c6c0953135d"), "Dành cho trẻ em cấp 1 trở lên. Nội dung có thể bao gồm xung đột nhẹ hoặc bài học đạo đức.", "10+" },
                    { new Guid("38c9a5bc-fd16-4cfe-98ad-8596885823a6"), "Phù hợp với mọi lứa tuổi, kể cả trẻ sơ sinh và mẫu giáo.", "0+" },
                    { new Guid("3c434270-31a1-4789-b7a0-6942f677faf3"), "Dành cho thiếu niên. Có thể đề cập đến các vấn đề xã hội, học đường, tâm lý tuổi mới lớn.", "12+" },
                    { new Guid("44c67b72-1032-4e8f-9ec4-d39ead0e529d"), "Dành cho người trưởng thành trẻ tuổi với nội dung chuyên môn, phát triển bản thân, hoặc kỹ năng sống.", "Sinh viên - Người đi làm" },
                    { new Guid("5f017f33-c136-41e6-814c-3f218f88aff6"), "Phù hợp với học sinh từ tiểu học đến trung học.", "Học sinh" },
                    { new Guid("6927136d-8256-4d1a-942c-2dde892dce2d"), "Dành cho trẻ em bắt đầu đọc, có thể có nội dung giáo dục và tưởng tượng nhẹ.", "6+" },
                    { new Guid("95de34ad-3e2a-4fd7-93f4-1cad58fef562"), "Dành cho người trưởng thành. Có thể chứa nội dung bạo lực, tâm lý phức tạp hoặc tình dục.", "18+" },
                    { new Guid("af95f5a2-e88b-42d7-882f-91cf6367a84b"), "Dành cho trẻ em từ 3 tuổi trở lên. Nội dung đơn giản, không có yếu tố bạo lực hoặc gây sợ hãi.", "3+" },
                    { new Guid("c27c3947-f242-45b4-b4a5-a51157948037"), "Nội dung phức tạp hơn, phù hợp với học sinh cấp 3. Có thể có yếu tố tình cảm hoặc suy nghĩ cá nhân.", "15+" },
                    { new Guid("f6c382a6-4c15-4cbe-bfa2-52adcaf2515b"), "Có thể có yếu tố bạo lực nhẹ, ngôn ngữ mạnh hoặc đề cập đến các chủ đề xã hội nghiêm túc.", "16+" }
                });

            migrationBuilder.InsertData(
                table: "CoverTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a2fb3a98-5683-4fd2-9c48-a4e5dbbeb89b"), "Bìa mềm" },
                    { new Guid("e8bf47c9-d940-4385-85a3-6295e9b78a33"), "Bìa cứng" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreateAt", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("1a714fee-5b7f-4ee5-a8cf-4feabf2b6d0e"), new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3014), "Tâm lý - Tình cảm", new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3014) },
                    { new Guid("24365f1d-bbcc-4100-8b86-990fa22cb957"), new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3019), "Lịch sử", new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3019) },
                    { new Guid("276df91e-a552-497c-b95f-917899412204"), new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3025), "Tiểu sử - Hồi ký", new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3025) },
                    { new Guid("588059f6-ce07-4c98-8146-f39b06adb01e"), new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3009), "Khoa học - Công nghệ", new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3010) },
                    { new Guid("5d28fe8b-a1b2-43a2-b592-a050dc33d7a0"), new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(2999), "Kinh tế", new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3000) },
                    { new Guid("87841a60-e8ea-4daa-b38d-03b78829ca6b"), new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3004), "Kỹ năng sống", new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3005) },
                    { new Guid("89af6711-5ac5-4258-89b7-afc7c90eacc2"), new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3016), "Thiếu nhi", new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3017) },
                    { new Guid("bf8234f7-6973-4d62-8108-ef2f9c4dad31"), new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3007), "Giáo dục", new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3007) },
                    { new Guid("c0ea0e79-5e2a-4381-8131-a7bed0d0025e"), new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3021), "Văn hóa - Xã hội", new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3022) },
                    { new Guid("e0a150e3-3d1f-4366-b1b7-8a146533f866"), new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(2991), "Văn học", new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(2995) }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("06c81552-4b1c-4428-8b10-74a42d58a316"), "Nhà xuất bản Văn Học" },
                    { new Guid("435af5c4-8992-4c94-b98f-7f483815c165"), "Nhà xuất bản Giáo Dục Việt Nam" },
                    { new Guid("5310bdd6-cf31-452a-8e52-d32bb601a4a4"), "Nhà xuất bản Kim Đồng" },
                    { new Guid("7884d857-6363-41f5-b691-276d611da010"), "Nhà xuất bản Lao Động" },
                    { new Guid("a14f4aff-db64-487c-b6ae-8e38c62c9443"), "Nhà xuất bản Chính Trị Quốc Gia Sự Thật" },
                    { new Guid("a9e42029-4533-443c-a991-77c4fd025983"), "Nhà xuất bản Hội Nhà Văn" },
                    { new Guid("cf1cafe6-f572-4fda-865e-b5c474a40c95"), "Nhà xuất bản Thanh Niên" },
                    { new Guid("d018a1ac-7815-45e0-abdf-227f64144ecb"), "Nhà xuất bản Phụ Nữ" },
                    { new Guid("d350bcd9-2525-48c6-9d69-46bae4aec52f"), "Nhà xuất bản Trẻ" },
                    { new Guid("ea9957e6-7db0-4da0-b424-71d294ca4762"), "Nhà xuất bản Tổng hợp TP.HCM" }
                });

            migrationBuilder.InsertData(
                table: "SubGenres",
                columns: new[] { "Id", "CreateAt", "GenreId", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("256702e8-a815-45e1-9561-6e52be3ab65f"), new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3186), new Guid("87841a60-e8ea-4daa-b38d-03b78829ca6b"), "Kỹ năng giao tiếp", new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3187) },
                    { new Guid("385e8fe9-2380-4ec5-97df-230996f7b285"), new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3094), new Guid("e0a150e3-3d1f-4366-b1b7-8a146533f866"), "Tiểu thuyết", new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3094) },
                    { new Guid("493baa5b-9751-417b-8b10-c9f259168b7b"), new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3104), new Guid("e0a150e3-3d1f-4366-b1b7-8a146533f866"), "Thơ", new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3104) },
                    { new Guid("6f9a9ecb-7a79-45ea-88a2-ee0de24e964a"), new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3176), new Guid("5d28fe8b-a1b2-43a2-b592-a050dc33d7a0"), "Khởi nghiệp", new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3177) },
                    { new Guid("d15299ce-aba5-4123-903c-8a612e363b40"), new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3100), new Guid("e0a150e3-3d1f-4366-b1b7-8a146533f866"), "Truyện ngắn", new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3101) },
                    { new Guid("d3ad3b7e-f881-456c-9fc8-89156c55a2c8"), new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3184), new Guid("87841a60-e8ea-4daa-b38d-03b78829ca6b"), "Tư duy tích cực", new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3184) },
                    { new Guid("d7233a86-3d42-4850-bf68-d44a845d7856"), new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3196), new Guid("bf8234f7-6973-4d62-8108-ef2f9c4dad31"), "Tâm lý học đường", new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3196) },
                    { new Guid("dbfbfd37-a68e-4c0b-99be-58ee7a091071"), new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3173), new Guid("5d28fe8b-a1b2-43a2-b592-a050dc33d7a0"), "Marketing", new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3174) },
                    { new Guid("e1a98a44-b60e-492a-88af-2c6a27afe285"), new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3192), new Guid("bf8234f7-6973-4d62-8108-ef2f9c4dad31"), "Giáo dục sớm", new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3192) },
                    { new Guid("ea934d49-64d7-4030-9830-f6938462d6bd"), new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3181), new Guid("87841a60-e8ea-4daa-b38d-03b78829ca6b"), "Phát triển bản thân", new DateTime(2025, 7, 29, 3, 13, 27, 843, DateTimeKind.Utc).AddTicks(3181) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("2c994161-5662-443b-b9ab-6c6c0953135d"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("38c9a5bc-fd16-4cfe-98ad-8596885823a6"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("3c434270-31a1-4789-b7a0-6942f677faf3"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("44c67b72-1032-4e8f-9ec4-d39ead0e529d"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("5f017f33-c136-41e6-814c-3f218f88aff6"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("6927136d-8256-4d1a-942c-2dde892dce2d"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("95de34ad-3e2a-4fd7-93f4-1cad58fef562"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("af95f5a2-e88b-42d7-882f-91cf6367a84b"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("c27c3947-f242-45b4-b4a5-a51157948037"));

            migrationBuilder.DeleteData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: new Guid("f6c382a6-4c15-4cbe-bfa2-52adcaf2515b"));

            migrationBuilder.DeleteData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: new Guid("a2fb3a98-5683-4fd2-9c48-a4e5dbbeb89b"));

            migrationBuilder.DeleteData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: new Guid("e8bf47c9-d940-4385-85a3-6295e9b78a33"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("1a714fee-5b7f-4ee5-a8cf-4feabf2b6d0e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("24365f1d-bbcc-4100-8b86-990fa22cb957"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("276df91e-a552-497c-b95f-917899412204"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("588059f6-ce07-4c98-8146-f39b06adb01e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("89af6711-5ac5-4258-89b7-afc7c90eacc2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c0ea0e79-5e2a-4381-8131-a7bed0d0025e"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("06c81552-4b1c-4428-8b10-74a42d58a316"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("435af5c4-8992-4c94-b98f-7f483815c165"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5310bdd6-cf31-452a-8e52-d32bb601a4a4"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("7884d857-6363-41f5-b691-276d611da010"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("a14f4aff-db64-487c-b6ae-8e38c62c9443"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("a9e42029-4533-443c-a991-77c4fd025983"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cf1cafe6-f572-4fda-865e-b5c474a40c95"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("d018a1ac-7815-45e0-abdf-227f64144ecb"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("d350bcd9-2525-48c6-9d69-46bae4aec52f"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("ea9957e6-7db0-4da0-b424-71d294ca4762"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("256702e8-a815-45e1-9561-6e52be3ab65f"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("385e8fe9-2380-4ec5-97df-230996f7b285"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("493baa5b-9751-417b-8b10-c9f259168b7b"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("6f9a9ecb-7a79-45ea-88a2-ee0de24e964a"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("d15299ce-aba5-4123-903c-8a612e363b40"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("d3ad3b7e-f881-456c-9fc8-89156c55a2c8"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("d7233a86-3d42-4850-bf68-d44a845d7856"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("dbfbfd37-a68e-4c0b-99be-58ee7a091071"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("e1a98a44-b60e-492a-88af-2c6a27afe285"));

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: new Guid("ea934d49-64d7-4030-9830-f6938462d6bd"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5d28fe8b-a1b2-43a2-b592-a050dc33d7a0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("87841a60-e8ea-4daa-b38d-03b78829ca6b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("bf8234f7-6973-4d62-8108-ef2f9c4dad31"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e0a150e3-3d1f-4366-b1b7-8a146533f866"));

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Notifications",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AgeRatings",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("085f3507-a4b2-4da5-8a98-a35a1c0779d8"), "Có thể có yếu tố bạo lực nhẹ, ngôn ngữ mạnh hoặc đề cập đến các chủ đề xã hội nghiêm túc.", "16+" },
                    { new Guid("0dd4fc74-dd6a-43dd-8ff3-373761fb3196"), "Phù hợp với mọi lứa tuổi, kể cả trẻ sơ sinh và mẫu giáo.", "0+" },
                    { new Guid("954ed735-b683-47e0-844b-36f76fba7e64"), "Dành cho người trưởng thành trẻ tuổi với nội dung chuyên môn, phát triển bản thân, hoặc kỹ năng sống.", "Sinh viên - Người đi làm" },
                    { new Guid("a4e2b937-8bda-4f13-8ce9-b4fc9f8bc637"), "Dành cho trẻ em bắt đầu đọc, có thể có nội dung giáo dục và tưởng tượng nhẹ.", "6+" },
                    { new Guid("b0f73947-ef70-48c2-af3d-b717913c9881"), "Dành cho người trưởng thành. Có thể chứa nội dung bạo lực, tâm lý phức tạp hoặc tình dục.", "18+" },
                    { new Guid("c52a6109-aa5e-40b1-9f06-076f77c2d9d6"), "Dành cho trẻ em từ 3 tuổi trở lên. Nội dung đơn giản, không có yếu tố bạo lực hoặc gây sợ hãi.", "3+" },
                    { new Guid("c76594ba-ad3d-47be-8220-81b38e712a06"), "Dành cho trẻ em cấp 1 trở lên. Nội dung có thể bao gồm xung đột nhẹ hoặc bài học đạo đức.", "10+" },
                    { new Guid("d83238db-d0be-4192-b108-8f037fe38bd8"), "Phù hợp với học sinh từ tiểu học đến trung học.", "Học sinh" },
                    { new Guid("f8b05cbd-92b1-4704-9645-c88639d526c3"), "Dành cho thiếu niên. Có thể đề cập đến các vấn đề xã hội, học đường, tâm lý tuổi mới lớn.", "12+" },
                    { new Guid("fff61113-26ca-423f-b85c-4dc6568e4982"), "Nội dung phức tạp hơn, phù hợp với học sinh cấp 3. Có thể có yếu tố tình cảm hoặc suy nghĩ cá nhân.", "15+" }
                });

            migrationBuilder.InsertData(
                table: "CoverTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5877bba1-652b-497c-8acc-8199b0c00cf9"), "Bìa cứng" },
                    { new Guid("b90a4146-a82e-4c4b-8636-aa1ee190ac3e"), "Bìa mềm" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreateAt", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("094d5d57-195e-4216-95a2-02f0634f4927"), new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7484), "Tiểu sử - Hồi ký", new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7484) },
                    { new Guid("216c23c9-cdc5-4d70-9e46-c7103ac34114"), new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7448), "Văn học", new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7456) },
                    { new Guid("51b657a5-832c-4b7b-b756-0a635ff739c9"), new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7476), "Thiếu nhi", new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7477) },
                    { new Guid("5b94956c-6426-4ade-a502-be50377d05ca"), new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7471), "Khoa học - Công nghệ", new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7471) },
                    { new Guid("5f06f01f-b4c2-4644-98ec-d205eab9eb07"), new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7478), "Lịch sử", new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7479) },
                    { new Guid("8b46d456-4e7a-4252-8dac-40115b205f5c"), new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7481), "Văn hóa - Xã hội", new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7481) },
                    { new Guid("8e75fd1f-cc4b-4f7c-8fd2-9709af8ddc0a"), new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7461), "Kinh tế", new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7461) },
                    { new Guid("99d5f27f-d17a-4d02-aeba-f944902f3f75"), new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7474), "Tâm lý - Tình cảm", new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7474) },
                    { new Guid("ed23fc64-0b03-4676-8ee4-157990e589d0"), new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7468), "Giáo dục", new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7469) },
                    { new Guid("ed2ffafb-aacd-4c02-876c-3b0fbc8cf015"), new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7463), "Kỹ năng sống", new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7464) }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("04dfd13c-9099-4c4e-b3c2-33ac857eb1ba"), "Nhà xuất bản Văn Học" },
                    { new Guid("35c8cea6-deab-4b6f-9365-3f1a0c6f1317"), "Nhà xuất bản Thanh Niên" },
                    { new Guid("4741a92e-ff56-48bd-8110-f3b639ebd481"), "Nhà xuất bản Hội Nhà Văn" },
                    { new Guid("49e84691-419a-4e27-841d-ff2e144ac065"), "Nhà xuất bản Tổng hợp TP.HCM" },
                    { new Guid("727dfbe9-ae63-4b01-a17c-506da5c6dcd3"), "Nhà xuất bản Giáo Dục Việt Nam" },
                    { new Guid("ae0b2d57-f7bd-47de-b3f5-320f10240226"), "Nhà xuất bản Kim Đồng" },
                    { new Guid("d51db000-babf-4e95-8e7d-89f801cb734e"), "Nhà xuất bản Phụ Nữ" },
                    { new Guid("dd70fa4a-cf08-4262-9bbb-4f0bd138acf5"), "Nhà xuất bản Chính Trị Quốc Gia Sự Thật" },
                    { new Guid("e7a8e169-a5d2-4eb3-9425-e5de0a32c98a"), "Nhà xuất bản Trẻ" },
                    { new Guid("f994fcec-d184-467a-a664-63064d306d5a"), "Nhà xuất bản Lao Động" }
                });

            migrationBuilder.InsertData(
                table: "SubGenres",
                columns: new[] { "Id", "CreateAt", "GenreId", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("142ed4e3-9ca1-4390-8541-8016c2a7fe68"), new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7560), new Guid("ed2ffafb-aacd-4c02-876c-3b0fbc8cf015"), "Tư duy tích cực", new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7561) },
                    { new Guid("40af47b6-1602-4b20-aa3b-db93f2ecc212"), new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7550), new Guid("8e75fd1f-cc4b-4f7c-8fd2-9709af8ddc0a"), "Marketing", new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7551) },
                    { new Guid("4b5989be-adcc-4840-bfa5-bdd39399bafc"), new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7554), new Guid("8e75fd1f-cc4b-4f7c-8fd2-9709af8ddc0a"), "Khởi nghiệp", new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7555) },
                    { new Guid("65418997-1390-4cd6-8266-9efab8ea2c32"), new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7566), new Guid("ed23fc64-0b03-4676-8ee4-157990e589d0"), "Giáo dục sớm", new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7566) },
                    { new Guid("68a9e25a-eae6-4daf-9a68-34c69a6c6500"), new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7557), new Guid("ed2ffafb-aacd-4c02-876c-3b0fbc8cf015"), "Phát triển bản thân", new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7558) },
                    { new Guid("7324638b-0859-463b-aac0-e5151709bc40"), new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7548), new Guid("216c23c9-cdc5-4d70-9e46-c7103ac34114"), "Thơ", new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7548) },
                    { new Guid("827646f9-54d3-4bba-8eca-b71c76f6657d"), new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7563), new Guid("ed2ffafb-aacd-4c02-876c-3b0fbc8cf015"), "Kỹ năng giao tiếp", new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7563) },
                    { new Guid("91c13167-a565-4fc6-ae34-322791252cca"), new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7545), new Guid("216c23c9-cdc5-4d70-9e46-c7103ac34114"), "Truyện ngắn", new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7545) },
                    { new Guid("dea64975-e00c-405e-98ca-654c06b67274"), new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7537), new Guid("216c23c9-cdc5-4d70-9e46-c7103ac34114"), "Tiểu thuyết", new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7538) },
                    { new Guid("eaa5da07-9c56-4a2b-a71a-ce7d58233e39"), new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7571), new Guid("ed23fc64-0b03-4676-8ee4-157990e589d0"), "Tâm lý học đường", new DateTime(2025, 7, 29, 3, 11, 6, 58, DateTimeKind.Utc).AddTicks(7572) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_AspNetUsers_UserId",
                table: "Notifications",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
