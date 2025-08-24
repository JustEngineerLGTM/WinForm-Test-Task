using TestTaskForm.Models;
namespace TestTaskForm.Services;

public interface IReportRepository
{
    Task<int> GetCountAsync(int statusId, DateTime from, DateTime to);
}