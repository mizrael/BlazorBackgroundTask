using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorBackgroundTask
{
    public class Counter : ICounter
    {
        public void Increment()
        {
            Interlocked.Increment(ref _value);
            this.OnChangeAsync?.Invoke();
        }

        private long _value;
        public long Value => _value;

        public event Func<Task> OnChangeAsync;
    }
}