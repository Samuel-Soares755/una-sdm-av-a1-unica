using Microsoft.EntityFrameworkCore;
using ValeAtivos324147097.Data;
 
var builder = WebApplication.CreateBuilder(args);
 

builder.Services.AddControllers();
 

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=ValeAtivos.db"));
 

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
 
var app = builder.Build();
 

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.EnsureCreated();
}
 

app.UseSwagger();
app.UseSwaggerUI();
 
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
 
app.Run();