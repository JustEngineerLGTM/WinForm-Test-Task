using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TestTaskForm.Db;
using TestTaskForm.Services;
namespace TestTaskForm;

static class Program
{
    static async Task Main()
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();
        var connectionString = configuration.GetConnectionString("Connection");

        var builder = Host.CreateApplicationBuilder();
        builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        builder.Services.AddScoped<IReportRepository, ReportRepository>();
        builder.Services.AddDbContextFactory<AppDbContext>(options =>
            options.UseSqlServer(connectionString));
        var host = builder.Build();

        var contextFactory = host.Services.GetRequiredService<IDbContextFactory<AppDbContext>>();
        await using var dbContextAsync = await contextFactory.CreateDbContextAsync();
        await dbContextAsync.Database.MigrateAsync();

        ApplicationConfiguration.Initialize();
        Application.Run(new Form1(host.Services));
    }
}