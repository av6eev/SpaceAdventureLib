using System.Collections.Generic;

namespace Timers
{
    public class TimersModel : ITimersModel
    {
        public readonly List<TimerModel> Models = new();

        public ITimerModel Add(float duration, bool isAutoStart = true)
        {
            var timer = new TimerModel(duration, isAutoStart);
        
            Models.Add(timer);

            return timer;
        }

        public void Remove(ITimerModel model) => Models.Remove((TimerModel)model);
    }
}