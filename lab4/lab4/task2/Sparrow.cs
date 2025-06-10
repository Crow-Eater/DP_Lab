namespace task2
{
    public class Sparrow : IFlyingBird, IBird
    {
        public string Name => "Sparrow";
        public void Act()
        {
            Fly();
        }

        public void Fly()
        {
            Console.WriteLine("Sparrow is flying.");
        }
    }
}
