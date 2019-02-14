using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Generics
{
    partial class TestBuffer
    {
        public static void BoxingUnboxing()
        {
            Console.WriteLine("\nBeispiel 1: Boxing/Unboxing.. ");
            Buffer buf = new Generics.Buffer();
            buf.Put(3);
            buf.Put(new Rectangle(10, 10, 20, 20));
            int i1 = (int)buf.Get(0);
            Console.WriteLine("Das 1. Element aus dem Buffer ist: " + i1);
            try
            {
                int i2 = (int)buf.Get(1);
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Fehler bei Typzuweisung: int i2 = (int)buf.Get(1); ");
            }
            Object o1 = buf.Get(1);
            if (o1.GetType() == typeof(Rectangle))
            {
                Rectangle r1 = (Rectangle)o1;
                Console.WriteLine("Der Objekt Rectangle wurde mit Typprüfung ausgelesen.");
            }
        }
        public static void Generics1()
        {
            //ArrayList<int> list0 = new ArrayList<int>();
            List<int> list = new List<int>();
            IList<string> strList = new List<string>();
            //list0.Add(null);
            //list.Add(null);
            strList.Add(null);
        }
    }
}
