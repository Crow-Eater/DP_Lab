namespace task1
{
    public class TShirtFactory : ClothingFactory
    {
        public override IClothing CreateClothing()
        {
            return new TShirt();
        }
    }

    public class JacketFactory : ClothingFactory
    {
        public override IClothing CreateClothing()
        {
            return new Jacket();
        }
    }

    public class JeansFactory : ClothingFactory
    {
        public override IClothing CreateClothing()
        {
            return new Jeans();
        }
    }
}
