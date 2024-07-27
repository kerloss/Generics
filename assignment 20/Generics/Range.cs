using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_20.Generics
{
    internal class Range<T> where T : IComparable<T>
    {
        //properity to min and max
        public T Minimum { get; set; }
        public T Maximunm { get; set; }

        //constructor to intialize the range of min and max
        public Range(T _minimum , T _maximum)
        {
            if (_minimum.CompareTo(_maximum) > 0)
            {
                Console.WriteLine("minimum value must be less or equal to maximum value");
            }
            Minimum = _minimum;
            Maximunm = _maximum;
        }

        //method to check if the value in range return true else return false
        public bool IsRange(T value)
        {
            return value.CompareTo(Minimum) >= 0 && value.CompareTo(Maximunm) <= 0;
        }

        //method to calc the length of the range
        public T length()
        {
            return (dynamic)Maximunm-(dynamic)Minimum;
        }

        public override string ToString()
        {
            return $"Range: [{Minimum} - {Maximunm}]";
        }
    }
}
