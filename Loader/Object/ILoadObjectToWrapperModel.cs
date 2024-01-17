namespace Loader.Object
{
    public interface ILoadObjectToWrapperModel<in T> : IWrapperLoadModel
    {
        T Result { set; }
        string Key { get; }
    }
}