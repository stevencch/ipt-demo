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

    public static IServiceCollection AddSupportedService(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        return services;
    }

    public static IServiceCollection AddCoreServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
        services.AddScoped<IProposalRepository, ProposalRepository>();
        services.AddScoped<IProposalQuery, ProposalQuery>();
        services.AddScoped<IProposalService, ProposalService>();
        return services;
    }
}
