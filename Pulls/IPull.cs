namespace Pulls
{
    public interface IPull<T>
    {
        public void Init(int minPullCount);
        public T Get();
        public void Put(T element);
        public void Dispose();
    }
}