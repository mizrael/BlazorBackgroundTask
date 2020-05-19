using System;
using System.Threading;

namespace BlazorBackgroundTask
{
    public class Counter : ICounter
    {
        public void Increment()
        {
            Interlocked.Increment(ref _value);
            this.OnChange?.Invoke();
        }

        private long _value;
        public long Value => _value;

        public event Action OnChange;
    }
}