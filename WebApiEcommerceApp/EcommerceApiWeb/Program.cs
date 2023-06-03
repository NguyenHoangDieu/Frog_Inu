using EcommerceApiWeb.Data.Abstract;
using EcommerceApiWeb.Data.Entity;
using EcommerceApiWeb.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Nest;
using System.Configuration;
using System.Data.Entity;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DbContext");
builder.Services.AddControllersWithViews();
builder.Services.AddSession();
builder.Services.AddControllers();
builder.Services.AddDbContext<EcommerceAppDbContext>(x => x.UseSqlServer(connectionString));
builder.Services.AddScoped<ISanPhamRepository , SanPhamRepository>();
builder.Services.AddScoped<IDanhMucSanPhamRepository, DanhMucSanPhamRepository>();
builder.Services.AddScoped<IUserRepository , UserRepository>();
builder.Services.AddMemoryCache();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = builder.Configuration["Jwt:Audience"],
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthentication();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseDeveloperExceptionPage();
app.UseAuthorization();
app.MapControllers();

app.Run();
