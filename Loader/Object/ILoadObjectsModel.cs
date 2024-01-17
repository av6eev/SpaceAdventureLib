namespace Loader.Object
{
    public interface ILoadObjectsModel
    {
        ILoadObjectModel<T> Load<T>(string key);
        void Unload(ILoadElement model);
    }
}