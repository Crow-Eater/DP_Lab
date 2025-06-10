namespace task2
{
    public class Pinguin : IBird
    {
        public string Name => "Pinguin";
        public void Act()
        {
            Console.WriteLine("Pinguin is swimming.");
        }
    }
}
