using System;

namespace Reactive.Field
{
    public interface IReactiveField<out T>
    {
        event Action<T> OnChanged;
        T Value { get; }
    }
}