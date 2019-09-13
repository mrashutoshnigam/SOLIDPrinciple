using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern
{
    interface IObservable
    {
        void Add(IObserver observer);
        void Remove(IObserver observer);
        void Notify();
        string GetDetails();

        void EnterNewValue();
    }
}
