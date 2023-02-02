using CreateShortLink.Application;
using CreateShortLink.Database;
using CreateShortLink.Models;
using CreateShortLink.Models.Entity;
using CreateShortLink.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ModelDbContext>(opts => {
    opts.UseNpgsql(
        builder.Configuration.GetConnectionString("ShLinkConnection")!);
});
builder.Services.AddControllers();
builder.Services.AddScoped<IModelRepository, ModelRepository>();
builder.Services.AddScoped<IBuildshortLink, BuildShortLink>();
builder.Services.AddScoped<ShortLink>();
builder.Services.AddScoped<Longlink>();
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