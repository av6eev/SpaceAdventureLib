using System;

namespace Reactive.Field
{
    public interface IReactiveField<out T>
    {
        event Action<T, T> OnChanged;
        T Value { get; }
    }
}