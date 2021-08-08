using System;
using System.Collections.Generic;

namespace ObserverBaggageExample
{
    public class BaggageInfo
    {
        private string origin;

        internal BaggageInfo(string from)
        {
            this.origin = from;
        }

        public string From
        {
            get { return this.origin; }
        }
    }

    public class BaggageHandler : IObservable<BaggageInfo>
    {
        private List<IObserver<BaggageInfo>> observers;

        public BaggageHandler()
        {
            observers = new List<IObserver<BaggageInfo>>();
        }
        public IDisposable Subscribe(IObserver<BaggageInfo> observer)
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main()
        {
            var baggageHandler = new BaggageHandler();
            //var observerUnitedStates = new BaggageInfo("Luggage from USA");
            //var observerGermany = new BaggageInfo("Baggage aus Deutschland");

            //baggageHandler.Subscribe(observerUnitedStates);

            Console.WriteLine("Press any key..");
            Console.ReadKey();
        }
    }
}
