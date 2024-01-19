using System.Linq;
using Updater;

namespace Timers
{
    public class TimersUpdater : IUpdater
    {
        private readonly TimersModel _timers;

        public TimersUpdater(TimersModel timers)
        {
            _timers = timers;
        }
    
        public void Update(float deltaTime)
        {
            foreach (var timer in _timers.Models.Where(timer => !timer.IsPaused))
            {
                timer.Tick();
                timer.Time -= deltaTime;

                if (timer.Time <= 0)
                {
                    timer.Complete();
                }
            }
        }
    }
}