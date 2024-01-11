using MiniChallenge8To10.Services.MiniChallenge8;
using MiniChallenge8To10.Services.MiniChallenge9;
using MiniChallenge8To10.Services.MiniChallenge10;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMiniChallenge8Service, MiniChallenge8Service>();
builder.Services.AddScoped<IMiniChallenge9Service, MiniChallenge9Service>();
builder.Services.AddScoped<IMiniChallenge10Service, MiniChallenge10Service>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
