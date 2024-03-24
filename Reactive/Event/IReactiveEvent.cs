using System;

namespace Reactive.Event
{
    public interface IReactiveEvent
    {
        event Action OnChanged;
    }
    
    public interface IReactiveEvent<out T>
    {
        event Action<T> OnChanged;
    }
}