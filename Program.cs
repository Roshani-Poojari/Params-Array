using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    internal class Program
    {
        static void Main(string[] args) {
            SummationOfElements(21,56,64,47,19,83);
        }

        static void SummationOfElements(params int[] elements){
            int sum = 0;
            foreach (int item in elements)
            {
                sum += item;
            }
            Console.WriteLine("Sum of all elements in params array is: "+sum);
        }

    }
}
