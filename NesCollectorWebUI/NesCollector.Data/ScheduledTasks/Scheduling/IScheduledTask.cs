using System.Threading;
using System.Threading.Tasks;

namespace NesCollector.Data.ScheduledTasks.Scheduling
{
    public interface IScheduledTask
    {
        string Schedule { get; }
        Task ExecuteAsync(CancellationToken cancellationToken);
    }
}