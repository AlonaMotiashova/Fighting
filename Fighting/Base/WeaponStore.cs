using System;
using System.Collections.Generic;

namespace Fighting
{
    public class WeaponStore : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string ProductName { get; set; }
        private int ProductPrice { get; set; }
        private string Availability { get; set; }

        public WeaponStore(string productName, int productPrice, string availability)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            Availability = availability;
        }

        public string GetAvailability()
        {
            return Availability;
        }

        public void SetAvailability(string availability)
        {
            this.Availability = availability;
            Console.WriteLine("Availability changed from Out of Stock to Available.");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            Console.WriteLine("Observer Added : " + ((Creature)observer).Name);
            observers.Add(observer);
        }
        public void AddObservers(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            Console.WriteLine("Weapon name :"
                            + ProductName + ", weapon price : "
                            + ProductPrice + " is Now available. So notifying all Registered users ");
            Console.WriteLine();
            foreach (IObserver observer in observers)
            {
                observer.Update(Availability);
            }
        }
    }
}
