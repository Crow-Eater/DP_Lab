namespace task1
{
    public class ClothingItem
    {
        public int Id { get; }
        public string Size { get; }
        public decimal Price { get; }
        public bool InStock { get; }
        private IClothing model;

        public ClothingItem(int id, string size, decimal price, bool inStock, IClothing model)
        {
            Id = id;
            Size = size;
            Price = price;
            InStock = inStock;
            this.model = model;
        }

        public void Display()
        {
            Console.WriteLine($"Item ID: {Id} | Size: {Size} | Price: {Price:C} | Is in stock: {(InStock ? "Yes" : "No")}");
            model.DisplaySharedInfo();
            Console.WriteLine(new string('-', 60));
        }
    }
}
