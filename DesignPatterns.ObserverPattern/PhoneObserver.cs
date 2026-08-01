using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern
{
    class PhoneObserver : IObserver
    {
        IObservable observable;
        public PhoneObserver(IObservable observable)
        {
            observable.Add(this);
            this.observable = observable;
        }
        public void Update()
        {
            Console.WriteLine(this.GetType().Name + " : "+ observable.GetDetails());
        }
    }
}
