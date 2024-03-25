using GestioneApp.Core.Services;
using GestioneApp.Core.Services.Interfaces;
using GestioneApp.DataLayer.Context;
using Microsoft.EntityFrameworkCore;

public class Startup
{
    public IConfiguration configRoot
    {
        get;
    }
    public Startup(IConfiguration configuration)
    {
        configRoot = configuration;
    }
    public void ConfigureServices(IServiceCollection services)
    {
        
        services.AddRazorPages();
        services.AddDbContext<GestioneAppContext>(options =>
        {
            options.UseSqlServer(configRoot.GetConnectionString("SoftwareGestione"));
        });
        services.AddTransient<ILegislativeAuditService, LegislativeAuditService>();

    }
    public void Configure(WebApplication app, IWebHostEnvironment env)
    {
        app.UseStaticFiles();
        app.UseRouting();
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
        app.MapRazorPages();
        app.Run();

    }
}