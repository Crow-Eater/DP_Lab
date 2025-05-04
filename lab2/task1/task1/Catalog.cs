namespace task1
{
    public class Catalog
    {
        private readonly List<ClothingItem> items = new();
        private readonly ClothingFactory factory = new();

        public void AddItem(int id, string size, decimal price, bool inStock,
                            string type, string brand, string material, string color)
        {
            var model = factory.GetClothingModel(type, brand, material, color);
            var item = new ClothingItem(id, size, price, inStock, model);
            items.Add(item);
        }

        public void DisplayCatalog()
        {
            Console.WriteLine("\n=== Items catalog ===\n");
            foreach (var item in items)
            {
                item.Display();
            }
        }
    }
}
