namespace task1
{
    interface IShape
    {
        void Accept(IShapeVisitor visitor);
    }
}
