public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<SchoolDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("MertDb")));
        // Diðer servisler...
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Middleware konfigürasyonu...
    }
}
