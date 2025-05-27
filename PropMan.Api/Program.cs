var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); // ✅ Add this
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Service.AddDbContext<CohoHubDbContext>(options => Use)
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// ✅ Add this to map controller endpoints
app.UseAuthorization();
app.MapControllers();

app.Run();
