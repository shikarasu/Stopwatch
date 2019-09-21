using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopWatch();

            for (var i = 0; i < 2; i++)
            {
                stopwatch.Start();

                stopwatch.Stop(1000);

                Console.WriteLine("Duration: " + stopwatch.GetInterval());

                Console.WriteLine("Press Enter to run the stopwatch one more time");
                Console.ReadLine();
            }
        }
    }
    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _running;
            
        public void Start()
        {
            if (_running)
       
                throw new InvalidOperationException("Stopwatch is already running");
       
            _startTime = DateTime.Now;
            _running = true;
        }
  
        public void Stop(int v)
        {
            if (!_running)
           
                throw new InvalidOperationException("Stopwatch is not running");
            _endTime = DateTime.Now;
            _running = false;
          
        }

        public TimeSpan GetInterval()
        {
            return _endTime - _startTime;

        }

    }
}    