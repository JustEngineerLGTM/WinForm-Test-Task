using TestTaskForm.Models;
namespace TestTaskForm.Services;

public interface IEmployeeRepository
{
    IAsyncEnumerable<Person> GetAllAsync();
}
