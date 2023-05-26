using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddDapr(); // Adds a DaprClient singleton for use in the app
builder.Services.AddAuthentication().AddDapr(); // Adds Dapr authentication
builder.Services.AddAuthorization(options =>
{
  options.AddDapr(); // Adds Dapr authorization
});
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

app.UseRouting();
app.UseAuthorization();
app.UseAuthorization();

app.UseCloudEvents();
app.MapSubscribeHandler();
app.MapControllers().RequireAuthorization();

app.Run();
