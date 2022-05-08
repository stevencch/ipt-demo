var builder = WebApplication.CreateBuilder(args);
Log.Logger = CreateSerilogLogger(builder.Configuration);

// Add services to the container.
Log.Information("Configuring web host");
builder.Services.AddControllers();
builder.Services.AddCustomDbContext(builder.Configuration)
    .AddSupportedService()
    .AddCoreServices()
    .AddCustomCors(builder.Configuration, AppConstants.ApiCorsPolicy);
builder.Host.UseSerilog();
var app = builder.Build();

Log.Information("Starting web host");
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(AppConstants.ApiCorsPolicy);
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapControllers();
app.MapFallbackToFile("index.html");
app.Run();

Serilog.ILogger CreateSerilogLogger(IConfiguration configuration)
{
    return new LoggerConfiguration()
        .MinimumLevel.Verbose()
        .Enrich.FromLogContext()
        .WriteTo.Console()
        .ReadFrom.Configuration(configuration)
        .CreateLogger();
}
//export for integration test
public partial class Program { }
