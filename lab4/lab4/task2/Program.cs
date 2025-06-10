namespace task2
{
    class Program
    {
        static void Main()
        {
            var handler = new BirdHandler(new BirdProducer());
            handler.DoBirdAction();
        }
    }
}