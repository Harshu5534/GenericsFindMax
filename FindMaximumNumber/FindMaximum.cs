using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
    public class FindMaximum<T> where T : IComparable
    {
        public T[] value;

        public FindMaximum(T[] value)
        {
            this.value = value;
        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(params T[] values)
        {
            var sorted_values=Sort(values);
            return sorted_values[^1];
        }
        public T PrintMaxMethod()
        {
            var max=MaxValue(this.value);
            Console.WriteLine("Maximum value is :" + max);
            return max;
        }
    }
}
