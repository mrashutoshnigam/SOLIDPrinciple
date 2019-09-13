using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern
{
    class WeatherStation : IObservable
    {
        IList<IObserver> list;
        string somevalue;
        public WeatherStation()
        {
            list = new List<IObserver>();
        }
        public void Add(IObserver observer) => list.Add(observer);

        public void EnterTemp()
        {
            Console.WriteLine("Enter New value");
            somevalue = Console.ReadLine();
            Notify();
        }

        public string GetDetails() => somevalue;

        public void Notify()
        {
            foreach (IObserver item in list)
            {
                item.Update();
            }
        }

        public void Remove(IObserver observer) => list.Remove(observer);
    }
}
