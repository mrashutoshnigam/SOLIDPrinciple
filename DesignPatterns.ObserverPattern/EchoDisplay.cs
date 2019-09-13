using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern
{
    class EchoDisplay : IObserver
    {
        WeatherStation weatherStation;
        public EchoDisplay(WeatherStation weatherStation)
        {
            weatherStation.Add(this);
            this.weatherStation = weatherStation;
        }
        public void Update()
        {
            Console.WriteLine(this.GetType().Name+ " : " + weatherStation.GetTemp()) ;
        }
    }
}
