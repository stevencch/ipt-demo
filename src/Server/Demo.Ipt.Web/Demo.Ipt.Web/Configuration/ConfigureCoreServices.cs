namespace Demo.Ipt.Web.Configuration;

public static class ConfigureCoreServices
{
    public static IServiceCollection AddCustomDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<IptDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString(nameof(IptDbContext)), b => b.MigrationsAssembly("Demo.Ipt.Web"))
                .EnableSensitiveDataLogging());
        return services;
    }
}
