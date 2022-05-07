using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Project
{
   public class AggregateFunctionsDemo
    {
        public void run()
        {
            List<int> integerList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            Console.WriteLine($"Maximum of list is {integerList.Max()}");

            Console.WriteLine($"Minimum of list is {integerList.Min()}");

            Console.WriteLine($"Count of list is {integerList.Count()}");

            int product = integerList.Aggregate((a, b) => a * b);
            Console.WriteLine($"Product of the list {product}");

            int sum = integerList.Aggregate((a, b) => a + b);
            Console.WriteLine($"Sum of the list {sum}");

            Console.WriteLine($"Sum of the lsit {integerList.Sum()}");

            List<string> list = new List<string>() { "Aravind", "is", "in", "2nd", "floor." };
            Console.WriteLine(list.Aggregate((a, b) => a + " " + b));
        }
    }
}
