using ASPNETCoreWebAPIFramework.ApplicationDbContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


string connectionString = builder.Configuration.GetValue<string>("ConnectionStrings:ConnectionUrl") ?? throw new Exception("Empty Db Connection String");

// Set up database configuration
builder.Services.AddDbContext<ApplicationDbContextClass>(options =>
{
    options.UseNpgsql(connectionString,
        options =>
        {
            options.CommandTimeout(15);
            options.EnableRetryOnFailure(2);
        });
});


// Add services to the container.
builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
