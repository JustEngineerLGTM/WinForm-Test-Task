using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using TestTaskForm.Db;

namespace TestTaskForm.Services;

public class ReportRepository(IDbContextFactory<AppDbContext> contextFactory) : IReportRepository
{
    public async Task<int> GetCountAsync(int statusId, DateTime from, DateTime to)
    {
        await using var dbContext = await contextFactory.CreateDbContextAsync();
        await using var connection = dbContext.Database.GetDbConnection();

        if (connection.State != System.Data.ConnectionState.Open)
            await connection.OpenAsync();

        await using var command = connection.CreateCommand();
        command.CommandType = System.Data.CommandType.StoredProcedure;
        command.CommandText = "GetEmployeeCount";

        command.Parameters.Add(new SqlParameter("@StatusId", statusId));
        command.Parameters.Add(new SqlParameter("@FromDate", from));
        command.Parameters.Add(new SqlParameter("@ToDate", to));

        var result = await command.ExecuteScalarAsync();
        return Convert.ToInt32(result);
    }
}