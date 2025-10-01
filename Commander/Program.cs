using Commander.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers().AddNewtonsoftJson(s => {
	s.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
});

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDbContext<CommanderContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("CommanderConnection")));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
//builder.Services.AddScoped<ICommanderRepo, MockCommanderRepo>();
builder.Services.AddScoped<ICommanderRepo, SqlCommanderRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
