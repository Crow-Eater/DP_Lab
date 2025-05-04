namespace task1
{
    public class ClothingModel : IClothing
    {
        public string Type { get; }
        public string Brand { get; }
        public string Material { get; }
        public string Color { get; }

        public ClothingModel(string type, string brand, string material, string color)
        {
            Type = type;
            Brand = brand;
            Material = material;
            Color = color;
        }

        public void DisplaySharedInfo()
        {
            Console.WriteLine($"  Model: {Brand} {Type} ({Color}, {Material})");
        }
    }
}
