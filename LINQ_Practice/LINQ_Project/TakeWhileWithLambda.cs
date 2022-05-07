using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Project
{
    public class TakeWhileWithLambda
    {
        public void run()
        {
            List<string> list = new List<string>() { "one", "two", "three", "four", "five", "six" };

            // var list1=(from nums in list select nums).TakeWhile((nums,i)=>nums.Length>i);

            foreach (var nums in (from nums in list select nums).TakeWhile((nums, index) => nums.Length > index))
            {
                Console.WriteLine(nums);
            }
        }
    }
}
