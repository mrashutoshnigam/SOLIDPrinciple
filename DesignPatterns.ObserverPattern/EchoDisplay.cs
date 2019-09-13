using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern
{
    class EchoDisplay : IObserver
    {
        IObservable observable;
        public EchoDisplay(IObservable observable)
        {
            this.observable = observable;
        }
        public void Update()
        {
            Console.WriteLine(observable.GetDetails()) ;
        }
    }
}
