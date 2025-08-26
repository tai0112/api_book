using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HiNetProjectApi.Migrations
{
    /// <inheritdoc />
    public partial class Addnotificationtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "StockQuantities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "StockQuantities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");

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

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "StockQuantities");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "StockQuantities");

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
    }
}
