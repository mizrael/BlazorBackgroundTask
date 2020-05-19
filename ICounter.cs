using System;
using System.Threading.Tasks;

namespace BlazorBackgroundTask
{
    public interface ICounter
    {
        long Value { get; }
        void Increment();
        event Func<Task> OnChangeAsync;
    }
}