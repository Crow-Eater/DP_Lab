namespace task1
{
    public class TShirt : IClothing
    {
        public void DisplayInfo()
        {
            Console.WriteLine("T-Shirt created");
        }
    }

    public class Jacket : IClothing
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Jacket created");
        }
    }

    public class Jeans : IClothing
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Jeans created");
        }
    }
}
