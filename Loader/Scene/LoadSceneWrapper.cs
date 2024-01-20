namespace Loader.Scene
{
    public abstract class LoadSceneWrapper<T> : ILoadSceneWrapper where T : IBaseGameModel
    {
        protected readonly T GameModel;

        protected LoadSceneWrapper(T gameModel)
        {
            GameModel = gameModel;
        }

        public abstract void Load(LoadSceneModel model);
        public abstract void Unload(ILoadSceneModel loadElement);
    }
}