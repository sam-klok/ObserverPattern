using System;

namespace ObserverPatternConsoleApp
{
    class Observable
    {
        public event EventHandler SomethingHappened;

        public void DoSomething() =>
            SomethingHappened?.Invoke(this, EventArgs.Empty);
    }

    class Observer
    {
        public void HandleEvent(object sender, EventArgs args)
        {
            Console.WriteLine("Something happened to " + sender);
        }
    }

    /// <summary>
    /// Based on example at
    /// https://stackoverflow.com/questions/1249517/super-simple-example-of-c-sharp-observer-observable-with-delegates
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var observable = new Observable();
            var observer = new Observer();
            observable.SomethingHappened += observer.HandleEvent;

            // uncomment below to add another event
            //observable.SomethingHappened += observer.HandleEvent;

            observable.DoSomething();

            Console.WriteLine("Press any key..");
            Console.ReadKey();
        }
    }
}
