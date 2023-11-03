using InstitutoIENServices.Api;

var builder = WebApplication.CreateBuilder(args);

//add services dependencyInjection llamo al método AddService de la clase creada llamada DenpendencyInjection
builder.Services.AddService(builder.Configuration);

// Add services to the container.

builder.Services.AddControllers();



var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
