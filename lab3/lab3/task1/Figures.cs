namespace task1
{
    class Sphere : IShape
    {
        public double Radius { get; set; }
        public Sphere(double radius) => Radius = radius;
        public void Accept(IShapeVisitor visitor) => visitor.Visit(this);
    }

    class Cube : IShape
    {
        public double Side { get; set; }
        public Cube(double side) => Side = side;
        public void Accept(IShapeVisitor visitor) => visitor.Visit(this);
    }

    class Cuboid : IShape
    {
        public double Width, Height, Depth;
        public Cuboid(double width, double height, double depth)
            => (Width, Height, Depth) = (width, height, depth);
        public void Accept(IShapeVisitor visitor) => visitor.Visit(this);
    }

    class Torus : IShape
    {
        public double MajorRadius, MinorRadius;
        public Torus(double R, double r) => (MajorRadius, MinorRadius) = (R, r);
        public void Accept(IShapeVisitor visitor) => visitor.Visit(this);
    }
}
