namespace task1
{
    class Program
    {
        static void Main()
        {
            var catalog = new Catalog();

            catalog.AddItem(1001, "M", 2499.99m, true, "T-Shirt", "Nike", "Cotton", "White");
            catalog.AddItem(1002, "L", 2499.99m, true, "T-Shirt", "Nike", "Cotton", "White");
            catalog.AddItem(1003, "XL", 2499.99m, false, "T-Shirt", "Nike", "Cotton", "White");

            catalog.AddItem(2001, "M", 5999.99m, true, "Jacket", "Adidas", "Polyester", "Black");
            catalog.AddItem(2002, "S", 5999.99m, true, "Jacket", "Adidas", "Polyester", "Black");

            catalog.AddItem(3001, "M", 3999.50m, true, "Jeans", "Levi's", "Denim", "Blue");

            catalog.DisplayCatalog();
        }
    }
}