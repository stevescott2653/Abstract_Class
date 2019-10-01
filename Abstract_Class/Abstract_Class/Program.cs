using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public abstract class Shape
    {
        public abstract void Draw();
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing rectangle...");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing circle...");
        }
    }

    public class TestAbstract
    {
        public static void Main()
        {
            Shape s;
            s = new Rectangle();
            s.Draw();
            s =new Circle();
            s.Draw();
        }
    }
}
