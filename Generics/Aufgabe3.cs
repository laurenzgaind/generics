using System;
using System.Collections.Generic;
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
        }
    }
}
