namespace Logical_Programming
{
    internal class StopwatchProgram
    {

        public class StopwatchProgram
        {
            private DateTime startTime;
            private DateTime endTime;
            private bool isRunning;

            public void Start()
            {
                if (!isRunning)
                {
                    startTime = DateTime.Now;
                    isRunning = true;
                    Console.WriteLine("Stopwatch started.");
                }
                else
                {
                    Console.WriteLine("Stopwatch is already running.");
                }
            }

            public void Stop()
            {
                if (isRunning)
                {
                    endTime = DateTime.Now;
                    isRunning = false;
                    Console.WriteLine("Stopwatch stopped.");
                }
                else
                {
                    Console.WriteLine("Stopwatch is not running.");
                }
            }

            public TimeSpan GetElapsedTime()
            {
                if (isRunning)
                {
                    return DateTime.Now - startTime;
                }
                else
                {
                    return endTime - startTime;
                }
            }

            public static void Main(string[] args)
            {
                StopwatchProgram stopwatch = new StopwatchProgram();

                Console.WriteLine("Press 's' to start the stopwatch, 'e' to end it, and 'q' to quit.");

                while (true)
                {
                    char input = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    if (input == 's')
                    {
                        stopwatch.Start();
                    }
                    else if (input == 'e')
                    {
                        stopwatch.Stop();
                        TimeSpan elapsed = stopwatch.GetElapsedTime();
                        Console.WriteLine($"Elapsed time: {elapsed.TotalSeconds} seconds");
                    }
                    else if (input == 'q')
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                }
            }
        }
    }
}


