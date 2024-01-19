using System;

namespace Timers
{
    public class TimerModel : ITimerModel
    {
        public event Action OnTicked;
        public event Action OnCompleted;

        private float _duration;
        public float Time;
        public bool IsPaused { get; private set; }
        public bool IsCompleted;

        public TimerModel(float duration, bool autoStart = true)
        {
            _duration = duration;

            if (!autoStart)
            {
                IsPaused = true;
            }
        }

        public void Start()
        {
            IsCompleted = false;
            IsPaused = false;
            Time = _duration;
        }

        public void Stop() => IsPaused = true;

        public void Reset(float duration)
        {
            _duration = duration;
            IsPaused = false;
            IsCompleted = false;
            Time = _duration;
        }

        public void Complete()
        {
            IsCompleted = true;
            IsPaused = true;
        
            OnCompleted?.Invoke();
        }

        public void Tick() => OnTicked?.Invoke();
    }
}