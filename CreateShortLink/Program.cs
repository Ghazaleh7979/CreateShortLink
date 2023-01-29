using CreateShortLink.Dtos;
using CreateShortLink.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ModelDbContext>(opts => {
    opts.UseSqlServer(
        builder.Configuration["ConnectionStrings:ShLinkConnection"]);
});
builder.Services.AddControllers();
builder.Services.AddSingleton<IBuildshortLink, BuildShortLink>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
// app.MapControllerRoute("Change",
//     "{longlink}",
//     new { Controller = "Change", action = "", productPage = 1 });
app.MapControllers();

app.Run();