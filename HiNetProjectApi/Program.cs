using System.Text;
using FluentValidation;
using FluentValidation.AspNetCore;
using HiNetProjectApi.Data;
using HiNetProjectApi.Mappings;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;
using HiNetProjectApi.Repository;
using HiNetProjectApi.Repository.IRepositoriy;
using HiNetProjectApi.Repository.IRepository;
using HiNetProjectApi.Services;
using HiNetProjectApi.Services.IServices;
using HiNetProjectApi.Validators;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//SignalR
builder.Services.AddSignalR();

//Config CORS
builder.Services.AddCors(options => options.AddPolicy("AllowFrontEnd", policy =>
{
    policy.WithOrigins("http://localhost:3000")
    .AllowAnyHeader()
    .AllowAnyMethod()
    .AllowCredentials();
}));

//Config identity
builder.Services.AddIdentityCore<ApplicationUser>().AddRoles<IdentityRole>().AddTokenProvider<DataProtectorTokenProvider<ApplicationUser>>("HiNetProjectApi").AddEntityFrameworkStores<BookEcommerceDbContext>().AddDefaultTokenProviders();

//Config dbContext
builder.Services.AddDbContext<BookEcommerceDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));

//Config HttpContextAccessor
builder.Services.AddHttpContextAccessor();

//Config JWT
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options => options.TokenValidationParameters = new TokenValidationParameters
{
    ValidateIssuer = true,
    ValidateAudience = true,
    ValidateLifetime = true,
    ValidateIssuerSigningKey = true,
    ValidIssuer = builder.Configuration["Jwt:Issuer"],
    ValidAudience = builder.Configuration["Jwt:Audience"],
    IssuerSigningKey = new SymmetricSecurityKey(
        Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
});

//DI
builder.Services.AddScoped<IGenreRepository, GenreRepository>();
builder.Services.AddScoped<ISubGenreRepository, SubGenreRepository>();
builder.Services.AddScoped<IAgeRatingRepository, AgeRatingRepository>();
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IBookImageRepository, BookImageRepository>();
builder.Services.AddScoped<ICartRepository, CartRepository>();
builder.Services.AddScoped<ICartDetailRepository, CartDetailRepository>();
builder.Services.AddScoped<ICoverTypeRepository, CoverTypeRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
builder.Services.AddScoped<IPaymentRepository, PaymentRepository>();
builder.Services.AddScoped<IPublisherRepository, PublisherRepository >();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ITokenRepository, TokenRepository>();
builder.Services.AddScoped<IStockQuantityRepository, StockQuantityRepository>();

//Logger
builder.Services.AddSingleton<ILogService, LogService>();


//Fluent Validation
builder.Services.AddValidatorsFromAssemblyContaining<AgeRatingAddValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<AgeRatingUpdateValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<BookAddValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<BookUpdateValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<GenreCreateValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<GenreUpdateValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<CartDetailAddValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<CartDetailUpdateValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<CoverTypeAddValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<CoverTypeUpdateValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<SubGenreAddValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<SubGenreUpdateValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<OrderAddValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<OrderUpdateValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<OrderDetailAddValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<OrderUpdateValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<StockQuantityAddValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<StockQuantityUpdateValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<GenreCreateValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<GenreUpdateValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<OrderAddValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<OrderUpdateValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<PublisherAddValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<PublisherUpdateValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<LoginUserValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<RegisterUserValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<BookImageAddValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<BookImageUpdateValidator>();

//Services Injection
builder.Services.AddScoped<IAgeRatingService, AgeRatingService>();
builder.Services.AddScoped<IGenreService, GenreService>();
builder.Services.AddScoped<ISubGenreService, SubGenreService>();
builder.Services.AddScoped<IPublisherService, PublisherService>();
builder.Services.AddScoped<ICoverTypeService, CoverTypeService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<ICartDetailService, CartDetailService>();
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IBookImageService, BookImageService>();
builder.Services.AddScoped<IStockQuantityService, StockQuantityService>();

//Config mapper
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(Directory.GetCurrentDirectory(), "Images")),
    RequestPath = "/Images"
});

app.UseHttpsRedirection();

app.UseCors("AllowFrontEnd");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
