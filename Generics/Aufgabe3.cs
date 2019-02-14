using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Buffer<Element>
    {
        private List<Element> data = new List<Element>();
        public void Put(Element x)
        {
            data.Add(x);
        }
        public Element Get(int index)
        {
            return data[index];
        }
    }
    partial class TestBuffer
    {
        public static void Generics2()
        {
            Console.WriteLine("\nAufgabe Generics 2: ... ");
            Buffer<int> a = new Buffer<int>();
            a.Put(3);
            int i = a.Get(0);
            Console.WriteLine("Das 1.Element von Buffer<int> ist: " + i);
            Buffer<Rectangle> b = new Buffer<Rectangle>();
            b.Put(new Rectangle());
            Rectangle r = b.Get(0);
            Console.WriteLine("Das 1.Element von Buffer<Rectangle> ist: " + r);
            Buffer<double> c = new Buffer<double>();
            c.Put(3.5);
            double d = c.Get(0);
            Console.WriteLine("Das 1.Element von Buffer<double> ist: " + d);
        }
    }
}
