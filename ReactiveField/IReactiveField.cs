using System;

namespace ReactiveField
{
    public interface IReactiveField<T>
    {
        event Action<T> OnChanged;
        T Value { get; }
    }
}