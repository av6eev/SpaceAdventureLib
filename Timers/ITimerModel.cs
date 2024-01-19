using System;

namespace Timers
{
    public interface ITimerModel
    {
        event Action OnTicked;
        event Action OnCompleted;

        bool IsPaused { get; }
    
        void Start();
        void Stop();
        void Reset(float duration);
    }
}