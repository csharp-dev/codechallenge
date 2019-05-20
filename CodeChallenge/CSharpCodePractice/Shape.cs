using System;
using System.Collections.Generic;
using System.Text;

namespace Code
{
    public class Shape
    {
        // A few example members
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        // Virtual method
        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing tasks");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            // Code to draw a circle...
            Console.WriteLine("Drawing a circle");
            base.Draw();
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            // Code to draw a rectangle...
            Console.WriteLine("Drawing a rectangle");
            base.Draw();
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            // Code to draw a triangle...
            Console.WriteLine("Drawing a triangle");
            base.Draw();
        }
    }

    //class program
    //{
    //    static void main(string[] args)
    //    {
    //        // polymorphism at work #1: a rectangle, triangle and circle
    //        // can all be used whereever a shape is expected. no cast is
    //        // required because an implicit conversion exists from a derived 
    //        // class to its base class.
    //        system.collections.generic.list<shape> shapes = new system.collections.generic.list<shape>();
    //        shapes.add(new rectangle());
    //        shapes.add(new triangle());
    //        shapes.add(new circle());

    //        // polymorphism at work #2: the virtual method draw is
    //        // invoked on each of the derived classes, not the base class.
    //        foreach (shape s in shapes)
    //        {
    //            s.draw();
    //        }

    //        // keep the console open in debug mode.
    //        console.writeline("press any key to exit.");
    //        console.readkey();
    //    }

    //}
}
