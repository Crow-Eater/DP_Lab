namespace task2
{
    public class BirdProducer
    {
        public List<IBird> GetBirds()
        {
            return new List<IBird> {
            new Sparrow(),
            new Pinguin()
        };
        }
    }
}
