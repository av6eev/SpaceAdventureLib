namespace Timers
{
    public interface ITimersModel
    {
        ITimerModel Add(float duration, bool isAutoStart = true);
        void Remove(ITimerModel model);
    }
}