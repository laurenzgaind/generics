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
}
