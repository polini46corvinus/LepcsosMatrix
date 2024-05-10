
namespace System.Collections.Generic
{
    internal class ICollectionDebugView<T>
    {
        private List<Array> mLista;

        public ICollectionDebugView(List<Array> mLista)
        {
            this.mLista = mLista;
        }
    }
}