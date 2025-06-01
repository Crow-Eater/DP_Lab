namespace task1
{
    class VolumeCalculator : IShapeVisitor
    {
        public void Visit(Sphere s) =>
            Console.WriteLine($"Volume of a sphere: {(4.0 / 3.0) * Math.PI * Math.Pow(s.Radius, 3):F2}");

        public void Visit(Cube c) =>
            Console.WriteLine($"Volume of a cube: {Math.Pow(c.Side, 3):F2}");

        public void Visit(Cuboid c) =>
            Console.WriteLine($"Volume of a parallelepiped: {c.Width * c.Height * c.Depth:F2}");

        public void Visit(Torus t) =>
            Console.WriteLine($"Volume of a torus: {(2 * Math.PI * Math.PI * t.MajorRadius * Math.Pow(t.MinorRadius, 2)):F2}");
    }
}
