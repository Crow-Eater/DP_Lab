using System;
using System.Collections.Generic;
namespace task1
{
    class Program
    {
        static void Main()
        {
            List<IShape> shapes = new() {
                new Sphere(3),
                new Cube(2),
                new Cuboid(2, 4, 6),
                new Torus(5, 1)
            };

            var calculator = new VolumeCalculator();
            foreach (var shape in shapes)
            {
                shape.Accept(calculator);
            }
        }
    }
}