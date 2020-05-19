using System;

namespace BlazorBackgroundTask
{
    public interface ICounter
    {
        long Value { get; }
        void Increment();
        event Action OnChange;
    }
}