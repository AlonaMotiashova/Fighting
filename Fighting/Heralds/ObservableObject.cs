namespace Fighting.Heralds
{
    public delegate void NotifyObserver();

    public abstract class ObservableObject
    {
        private event NotifyObserver NotifyObserverEvent;

        public void AddObserver(NotifyObserver ob)
            => NotifyObserverEvent += ob;

        public void RemoveObserver(NotifyObserver ob) 
            => NotifyObserverEvent -= ob;
      
        public void Notify() 
            => NotifyObserverEvent?.Invoke();
    }
}