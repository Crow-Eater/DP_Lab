namespace task1
{
    public class ClothingFactory
    {
        private readonly Dictionary<string, IClothing> models = new();

        public IClothing GetClothingModel(string type, string brand, string material, string color)
        {
            string key = $"{type}_{brand}_{material}_{color}";
            if (!models.ContainsKey(key))
            {
                models[key] = new ClothingModel(type, brand, material, color);
                Console.WriteLine($"[Model created] {brand} {type} ({color}, {material})");
            }

            return models[key];
        }
    }
}
