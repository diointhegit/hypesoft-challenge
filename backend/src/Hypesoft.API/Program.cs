using Hypesoft.Infrastructure;
using MediatR;using Hypesoft.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
MongoBootstrap.Initialize(); 
builder.Services.AddMediatR(typeof(Hypesoft.Application.Commands.CreateCategory.CreateCategoryCommand).Assembly);
builder.Services.AddInfrastructure(builder.Configuration);
var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();
app.Run();
