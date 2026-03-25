using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Generic
{
    public class Class1<T>
    {
        public T[] values=new T[10];

        public void InsertElement(T[] t)
        {
            values = t;
        }

        public void ReadElement()
        {
            for(int i=0;i<values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
        }


    }
}
