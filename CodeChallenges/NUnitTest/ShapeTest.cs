using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using Code;

namespace Test
{
    class ShapeTest
    {
        [Test]
        public void testPolymorphismExample()
        {
            List<Shape> shapes = new List<Shape>();
            //sreadonly Shape rectShape = new Rectangle();

            shapes.Add(new Rectangle());
            shapes.Add(new Triangle());
            shapes.Add(new Circle());

            // Polymorphism at work #2: the virtual method Draw is
            // invoked on each of the derived classes, not the base class.
            foreach (Shape s in shapes)
            {
                s.Draw();
            }

            // Keep the console open in debug mode.
            Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();

            Assert.AreEqual(1, 2);
        }
    }
}
