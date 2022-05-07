using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Project
{
    public class TakeWhileDemo
    {public void run()
        {
            List<int> RollNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var LimRollNum = RollNumbers.Take(6); // Linq Method

            //var LimRollNum= (from rollId in RollNumbers select rollId).Take(6); //Linq Query

            var LimRollNum = (from rollId in RollNumbers select rollId).TakeWhile(num => num < 6);


            foreach (int RollNums in LimRollNum)
            {
                Console.WriteLine(RollNums);
            }
        }
    }
}
