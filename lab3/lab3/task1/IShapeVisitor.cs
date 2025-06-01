namespace task1
{
    interface IShapeVisitor
    {
        void Visit(Sphere s);
        void Visit(Cube c);
        void Visit(Cuboid c);
        void Visit(Torus t);
    }
}
