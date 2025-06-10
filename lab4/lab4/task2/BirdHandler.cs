namespace task2
{
    public class BirdHandler
    {
        private readonly BirdProducer _producer;

        public BirdHandler(BirdProducer producer)
        {
            _producer = producer;
        }

        public void DoBirdAction()
        {
            List<IBird> birds = _producer.GetBirds();
            foreach (var bird in birds)
            {
                Console.Write($"{bird.Name}: ");
                bird.Act();
            }
        }
    }

}
