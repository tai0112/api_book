using System.Reflection.Emit;
using HiNetProjectApi.Models.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HiNetProjectApi.Data
{
    public class BookEcommerceDbContext : IdentityDbContext<ApplicationUser>
    {
        public BookEcommerceDbContext(DbContextOptions<BookEcommerceDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<AgeRating> AgeRatings { get; set; }
        public DbSet<BookImage> BookImages { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }
        public DbSet<CoverType> CoverTypes { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<SubGenre> SubGenres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<StockQuantity> StockQuantities { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Order>()
                .HasOne(o => o.Payment)
                .WithOne(p => p.Order)
                .HasForeignKey<Payment>(p => p.OderId)
                .OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(builder);
            var idRoleAdmin = "845BD59F-2220-44E2-93A7-E1F6BE4FF0C2";
            var idRoleUser = "845BD59F-2220-44E2-93A7-E1F6BE4FF0C3";
            var roles = new List<IdentityRole>()
            {
                new IdentityRole
                {
                    Id = idRoleAdmin,
                    Name = "admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = idRoleAdmin
                },
                new IdentityRole
                {
                    Id = idRoleUser,
                    Name = "user",
                    NormalizedName = "USER",
                    ConcurrencyStamp = idRoleUser
                }
            };
            builder.Entity<IdentityRole>().HasData(roles);

            var coverTypes = new List<CoverType>()
            {
                new CoverType
                {
                    Id = Guid.NewGuid(),
                    Name = "Bìa mềm"
                },
                new CoverType
                {
                    Id = Guid.NewGuid(),
                    Name = "Bìa cứng"
                },
            };
            builder.Entity<CoverType>().HasData(coverTypes);

            var publishers = new List<Publisher>
            {
                new Publisher { Id = Guid.NewGuid(), Name = "Nhà xuất bản Kim Đồng" },
                new Publisher { Id = Guid.NewGuid(), Name = "Nhà xuất bản Trẻ" },
                new Publisher { Id = Guid.NewGuid(), Name = "Nhà xuất bản Tổng hợp TP.HCM" },
                new Publisher { Id = Guid.NewGuid(), Name = "Nhà xuất bản Lao Động" },
                new Publisher { Id = Guid.NewGuid(), Name = "Nhà xuất bản Văn Học" },
                new Publisher { Id = Guid.NewGuid(), Name = "Nhà xuất bản Giáo Dục Việt Nam" },
                new Publisher { Id = Guid.NewGuid(), Name = "Nhà xuất bản Chính Trị Quốc Gia Sự Thật" },
                new Publisher { Id = Guid.NewGuid(), Name = "Nhà xuất bản Hội Nhà Văn" },
                new Publisher { Id = Guid.NewGuid(), Name = "Nhà xuất bản Thanh Niên" },
                new Publisher { Id = Guid.NewGuid(), Name = "Nhà xuất bản Phụ Nữ" }
            };
            builder.Entity<Publisher>().HasData(publishers);

            var genres = new List<Genre>
            {
                new Genre { Id = Guid.NewGuid(), Name = "Văn học", CreateAt = DateTime.UtcNow, UpdateAt = DateTime.UtcNow },
                new Genre { Id = Guid.NewGuid(), Name = "Kinh tế", CreateAt = DateTime.UtcNow, UpdateAt = DateTime.UtcNow },
                new Genre { Id = Guid.NewGuid(), Name = "Kỹ năng sống", CreateAt = DateTime.UtcNow, UpdateAt = DateTime.UtcNow },
                new Genre { Id = Guid.NewGuid(), Name = "Giáo dục", CreateAt = DateTime.UtcNow, UpdateAt = DateTime.UtcNow },
                new Genre { Id = Guid.NewGuid(), Name = "Khoa học - Công nghệ", CreateAt = DateTime.UtcNow, UpdateAt = DateTime.UtcNow },
                new Genre { Id = Guid.NewGuid(), Name = "Tâm lý - Tình cảm", CreateAt = DateTime.UtcNow, UpdateAt = DateTime.UtcNow },
                new Genre { Id = Guid.NewGuid(), Name = "Thiếu nhi", CreateAt = DateTime.UtcNow, UpdateAt = DateTime.UtcNow },
                new Genre { Id = Guid.NewGuid(), Name = "Lịch sử", CreateAt = DateTime.UtcNow, UpdateAt = DateTime.UtcNow },
                new Genre { Id = Guid.NewGuid(), Name = "Văn hóa - Xã hội", CreateAt = DateTime.UtcNow, UpdateAt = DateTime.UtcNow },
                new Genre { Id = Guid.NewGuid(), Name = "Tiểu sử - Hồi ký", CreateAt = DateTime.UtcNow, UpdateAt = DateTime.UtcNow }
            };
            builder.Entity<Genre>().HasData(genres);

            var subGenres = new List<SubGenre>
            {
                new SubGenre { Id = Guid.NewGuid(), Name = "Tiểu thuyết", GenreId = genres[0].Id, CreateAt = DateTime.UtcNow, UpdateAt = DateTime.UtcNow },
                new SubGenre { Id = Guid.NewGuid(), Name = "Truyện ngắn", GenreId = genres[0].Id, CreateAt = DateTime.UtcNow, UpdateAt = DateTime.UtcNow },
                new SubGenre { Id = Guid.NewGuid(), Name = "Thơ", GenreId = genres[0].Id, CreateAt = DateTime.UtcNow, UpdateAt = DateTime.UtcNow },
                new SubGenre { Id = Guid.NewGuid(), Name = "Marketing", GenreId = genres[1].Id, CreateAt = DateTime.UtcNow, UpdateAt = DateTime.UtcNow },
                new SubGenre { Id = Guid.NewGuid(), Name = "Khởi nghiệp", GenreId = genres[1].Id, CreateAt = DateTime.UtcNow, UpdateAt = DateTime.UtcNow },
                new SubGenre { Id = Guid.NewGuid(), Name = "Phát triển bản thân", GenreId = genres[2].Id, CreateAt = DateTime.UtcNow, UpdateAt = DateTime.UtcNow },
                new SubGenre { Id = Guid.NewGuid(), Name = "Tư duy tích cực", GenreId = genres[2].Id, CreateAt = DateTime.UtcNow, UpdateAt = DateTime.UtcNow },
                new SubGenre { Id = Guid.NewGuid(), Name = "Kỹ năng giao tiếp", GenreId = genres[2].Id, CreateAt = DateTime.UtcNow, UpdateAt = DateTime.UtcNow },
                new SubGenre { Id = Guid.NewGuid(), Name = "Giáo dục sớm", GenreId = genres[3].Id, CreateAt = DateTime.UtcNow, UpdateAt = DateTime.UtcNow },
                new SubGenre { Id = Guid.NewGuid(), Name = "Tâm lý học đường", GenreId = genres[3].Id, CreateAt = DateTime.UtcNow, UpdateAt = DateTime.UtcNow }
            };
            builder.Entity<SubGenre>().HasData(subGenres);

            var ageRatings = new List<AgeRating>
            {
                new AgeRating
                {
                    Id = Guid.NewGuid(),
                    Name = "0+",
                    Description = "Phù hợp với mọi lứa tuổi, kể cả trẻ sơ sinh và mẫu giáo."
                },
                new AgeRating
                {
                    Id = Guid.NewGuid(),
                    Name = "3+",
                    Description = "Dành cho trẻ em từ 3 tuổi trở lên. Nội dung đơn giản, không có yếu tố bạo lực hoặc gây sợ hãi."
                },
                new AgeRating
                {
                    Id = Guid.NewGuid(),
                    Name = "6+",
                    Description = "Dành cho trẻ em bắt đầu đọc, có thể có nội dung giáo dục và tưởng tượng nhẹ."
                },
                new AgeRating
                {
                    Id = Guid.NewGuid(),
                    Name = "10+",
                    Description = "Dành cho trẻ em cấp 1 trở lên. Nội dung có thể bao gồm xung đột nhẹ hoặc bài học đạo đức."
                },
                new AgeRating
                {
                    Id = Guid.NewGuid(),
                    Name = "12+",
                    Description = "Dành cho thiếu niên. Có thể đề cập đến các vấn đề xã hội, học đường, tâm lý tuổi mới lớn."
                },
                new AgeRating
                {
                    Id = Guid.NewGuid(),
                    Name = "15+",
                    Description = "Nội dung phức tạp hơn, phù hợp với học sinh cấp 3. Có thể có yếu tố tình cảm hoặc suy nghĩ cá nhân."
                },
                new AgeRating
                {
                    Id = Guid.NewGuid(),
                    Name = "16+",
                    Description = "Có thể có yếu tố bạo lực nhẹ, ngôn ngữ mạnh hoặc đề cập đến các chủ đề xã hội nghiêm túc."
                },
                new AgeRating
                {
                    Id = Guid.NewGuid(),
                    Name = "18+",
                    Description = "Dành cho người trưởng thành. Có thể chứa nội dung bạo lực, tâm lý phức tạp hoặc tình dục."
                },
                new AgeRating
                {
                    Id = Guid.NewGuid(),
                    Name = "Học sinh",
                    Description = "Phù hợp với học sinh từ tiểu học đến trung học."
                },
                new AgeRating
                {
                    Id = Guid.NewGuid(),
                    Name = "Sinh viên - Người đi làm",
                    Description = "Dành cho người trưởng thành trẻ tuổi với nội dung chuyên môn, phát triển bản thân, hoặc kỹ năng sống."
                }
            };
            builder.Entity<AgeRating>().HasData(ageRatings);


        }

    }
}
