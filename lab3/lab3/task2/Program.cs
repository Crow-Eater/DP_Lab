namespace task2
{
    class Program
    {
        static void Main()
        {
            ILogger realLogger = new ConsoleLogger();
            var serviceWithLogging = new UserService(realLogger);
            serviceWithLogging.Register("Lesha");

            ILogger nullLogger = new NullLogger();
            var serviceWithoutLogging = new UserService(nullLogger);
            serviceWithoutLogging.Register("Olga");
        }
    }
}