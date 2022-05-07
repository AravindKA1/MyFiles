using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    public class FibonacciSeries
    {
        public void FibonacciRun()
        {
          List<int> list = new List<int>() { 1,1};
            while (list.Count <20)
            {
                var previous = list[list.Count - 1];
                var previous2 = list[list.Count - 2];
                list.Add(previous + previous2);
            }
            foreach (var item in list)
            {
                Console.Write(item+" ");
            }
            

        }
    }
}
