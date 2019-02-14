using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class TestBuffer
    {
        public static void BoxingUnboxing()
        {
            Console.WriteLine("\nBeispiel 1: Boxing/Unboxing.. ");
            Buffer buf = new _0.Buffer();
            buf.Put(3);
            buf.Put(new Rectangle(10, 10, 20, 20));
            int i1 = (int)buf.Get(0);
            Console.WriteLine("Das 1. Element aus dem Buffer ist: " + i1);
            try
            {
                int i2 = (int)buf.Get(1);
            }
            catch (TypeAccessException)
            {
                Console.WriteLine("Fehler bei Typzuweisung: int i2 = (int)buf.Get(1); ");
            }
            Object o1 = buf.Get(1);
            if (o1.GetType() == (Rectangle))
            {
                Rectangle r1 = (Rectangle)o1;
                Console.WriteLine("Der Objekt Rectangle wurde mit Typprüfung ausgelesen.");
            }
        }
    }
}
