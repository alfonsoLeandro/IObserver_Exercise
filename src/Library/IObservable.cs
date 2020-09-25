namespace Observer
{
    public interface IObservable
    {
        public void Subscribe(IObserver observer);

        public void UnSubscribe(IObserver observer);

        public void Notify();

    }

}