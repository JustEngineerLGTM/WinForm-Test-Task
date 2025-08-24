using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TestTaskForm.Db;
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
        builder.Services.AddDbContextFactory<AppDbContext>(options =>
            options.UseSqlServer(connectionString));
        var host = builder.Build();

        var contextFactory = host.Services.GetRequiredService<IDbContextFactory<AppDbContext>>();
        await using var dbContext = await contextFactory.CreateDbContextAsync();
        await dbContext.Database.MigrateAsync();

        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}