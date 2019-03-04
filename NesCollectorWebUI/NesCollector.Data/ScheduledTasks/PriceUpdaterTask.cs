using NesCollector.Data.ScheduledTasks.Scheduling;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NesCollector.Data.ScheduledTasks
{
    class PriceUpdaterTask : IScheduledTask
    {
        public string Schedule => "* */6 * * *";

        public Task ExecuteAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
