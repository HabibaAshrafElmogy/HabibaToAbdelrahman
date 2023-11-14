using PermissionBasedAuthorization.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContextIdentity(builder.Configuration);
builder.Services.AddDatabaseDeveloperPageExceptionFilter();


builder.Services.AddControllersWithViews();


var app = builder.Build();

using var scope = app.Services.CreateScope();

await app.ConfigurationPipeLines(scope.ServiceProvider);


app.Run();
