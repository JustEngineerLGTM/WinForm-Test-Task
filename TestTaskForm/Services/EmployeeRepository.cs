using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using TestTaskForm.Db;
using TestTaskForm.Models;

namespace TestTaskForm.Services;

public class EmployeeRepository(IDbContextFactory<AppDbContext> contextFactory) : IEmployeeRepository
{


    public async IAsyncEnumerable<Person> GetAllAsync()
    {
        await using var dbContextAsync = await contextFactory.CreateDbContextAsync();
        
        var persons = await dbContextAsync.Persons
            .FromSqlRaw("EXEC GetAllPersons")
            .AsNoTracking()
            .ToListAsync();
        
        foreach (var person in persons)
        {
            await dbContextAsync.Entry(person)
                .Reference(p => p.Status)
                .LoadAsync();
            await dbContextAsync.Entry(person)
                .Reference(p => p.Dep)
                .LoadAsync();
            await dbContextAsync.Entry(person)
                .Reference(p => p.Post)
                .LoadAsync();
            
            yield return person;
        }
    }
    
}