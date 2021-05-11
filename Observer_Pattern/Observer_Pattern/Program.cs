using System;
using System.Collections.Generic;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple Observable Design Pattern Example
            WeatherStation weatherStation = new WeatherStation();

            NewsAgency agency1 = new NewsAgency("alpha");
            weatherStation.Attach(agency1);

            NewsAgency agency2 = new NewsAgency("gamma");
            weatherStation.Attach(agency2);

            weatherStation.Temperature = 31.2f;
            weatherStation.Temperature = 42.2f;
            weatherStation.Temperature = 37.8f;
            weatherStation.Temperature = 45.2f;

            Console.ReadLine();
        }

    }

    interface ISubject
    {
        void Attach(IObserver observer);
        void Notify();
    }

    class WeatherStation : ISubject
    {
        private List<IObserver> _observers;
        private float _temperature;

        public float Temperature
        {
            get { return _temperature; }
            set {
                _temperature = value;
                Notify();
            }
        }

        public WeatherStation()
        {
            _observers = new List<IObserver>();
        }

        public void Attach(IObserver observer) {
            _observers.Add(observer);
        }

        public void Notify()
        {
            _observers.ForEach(o =>
            {
                o.Update(this);
            });
        }
    }

    interface IObserver
    {

        void Update(ISubject subject);
    }

    class NewsAgency : IObserver
    {
        public String AgencyName { get; set; }
        public NewsAgency(String name){
            AgencyName = name;
        }
        public void Update(ISubject subject) {
            if (subject is WeatherStation weatherStation) {
                Console.WriteLine(
                    String.Format("{0} reporting temperature {1} degree celcius",
                    AgencyName,weatherStation.Temperature));

                Console.WriteLine();
            }
        }

    }
}
