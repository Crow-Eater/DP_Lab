namespace task1
{ 
    class Program
    {
        static void Main(string[] args)
        {
            ClothingFactory factory;

            factory = new TShirtFactory();
            IClothing tshirt = factory.CreateClothing();
            tshirt.DisplayInfo();

            factory = new JacketFactory();
            IClothing jacket = factory.CreateClothing();
            jacket.DisplayInfo();

            factory = new JeansFactory();
            IClothing jeans = factory.CreateClothing();
            jeans.DisplayInfo();
        }
    }
}
