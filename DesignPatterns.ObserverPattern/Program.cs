using System;

namespace DesignPatterns.ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weather = new WeatherStation();

            PhoneObserver phone1 = new PhoneObserver(weather);
            PhoneObserver phone2 = new PhoneObserver(weather);
            EchoDisplay echo1 = new EchoDisplay(weather);
            EchoDisplay echo2 = new EchoDisplay(weather);

            //weather.Add(phone1);
            //weather.Add(phone2);
            //weather.Add(echo1);
            //weather.Add(echo2);
            weather.EnterTemp();
            weather.EnterTemp();
            Console.ReadLine();
        }
    }
}
