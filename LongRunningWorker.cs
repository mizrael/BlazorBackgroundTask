using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace BlazorBackgroundTask
{
    public class LongRunningWorker : BackgroundService
    {
        private readonly ICounter _counter;

        public LongRunningWorker(ICounter counter)
        {
            _counter = counter ?? throw new ArgumentNullException(nameof(counter));
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            return Task.Run(async () =>
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    _counter.Increment();
                    await Task.Delay(500);
                }
            });
        }
    }
}