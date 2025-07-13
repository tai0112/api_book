using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HiNetProjectApi.Migrations
{
    /// <inheritdoc />
    public partial class AdddbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgeRatings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgeRatings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoverTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoverTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TotalPrice = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubGenres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubGenres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    PriceInit = table.Column<float>(type: "real", nullable: false),
                    PriceTotal = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartDetails_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaidMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceTotal = table.Column<float>(type: "real", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_Orders_OderId",
                        column: x => x.OderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActiveAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<float>(type: "real", nullable: false),
                    Witdh = table.Column<float>(type: "real", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    PriceInit = table.Column<float>(type: "real", nullable: false),
                    PriceBeforeDiscount = table.Column<float>(type: "real", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    PageTotal = table.Column<int>(type: "int", nullable: false),
                    YearPublish = table.Column<int>(type: "int", nullable: false),
                    IsActived = table.Column<bool>(type: "bit", nullable: false),
                    SubGenreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoverTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AgeRatingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoldTotal = table.Column<int>(type: "int", nullable: false),
                    Translate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublisherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_AgeRatings_AgeRatingId",
                        column: x => x.AgeRatingId,
                        principalTable: "AgeRatings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_CoverTypes_CoverTypeId",
                        column: x => x.CoverTypeId,
                        principalTable: "CoverTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_SubGenres_SubGenreId",
                        column: x => x.SubGenreId,
                        principalTable: "SubGenres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileExtension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileSizeInBytes = table.Column<long>(type: "bigint", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookImages_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    PriceInit = table.Column<float>(type: "real", nullable: false),
                    PriceTotal = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockQuantities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantities = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockQuantities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockQuantities_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "845BD59F-2220-44E2-93A7-E1F6BE4FF0C2", "845BD59F-2220-44E2-93A7-E1F6BE4FF0C2", "admin", "ADMIN" },
                    { "845BD59F-2220-44E2-93A7-E1F6BE4FF0C3", "845BD59F-2220-44E2-93A7-E1F6BE4FF0C3", "user", "USER" }
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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BookImages_BookId",
                table: "BookImages",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AgeRatingId",
                table: "Books",
                column: "AgeRatingId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CoverTypeId",
                table: "Books",
                column: "CoverTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_SubGenreId",
                table: "Books",
                column: "SubGenreId");

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_CartId",
                table: "CartDetails",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_BookId",
                table: "OrderDetails",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OderId",
                table: "Payments",
                column: "OderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_UserId",
                table: "Payments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StockQuantities_BookId",
                table: "StockQuantities",
                column: "BookId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubGenres_GenreId",
                table: "SubGenres",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BookImages");

            migrationBuilder.DropTable(
                name: "CartDetails");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "StockQuantities");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AgeRatings");

            migrationBuilder.DropTable(
                name: "CoverTypes");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropTable(
                name: "SubGenres");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
