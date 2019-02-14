using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Buffer
    {
        private ArrayList data = new ArrayList();
        public void Put(object x)
        {
            data.Add(x);
        }
        public object Get(int index)
        {
            return data[index];
        }
    }
}
