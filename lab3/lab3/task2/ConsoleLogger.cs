namespace task2
{
    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[Log] {message}");
        }
    }

    class NullLogger : ILogger
    {
        public void Log(string message) {}
    }
}
