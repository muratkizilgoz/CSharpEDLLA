using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    // where T : struct => value type
    // where T : new() from default constructor => instance
    public class Utilities<T> where T: IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a + b;
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        
        public void BirseylerYap(T value)
        {
            var obj = new T();
        }
    }
}
