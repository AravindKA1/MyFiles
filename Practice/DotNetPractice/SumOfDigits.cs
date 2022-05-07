using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    public class SumOfDigits
    {
        public int SumOfDigitsMethod(int number)
        {
            int sum = 0;
            while(number > 0)
            {
                sum = sum + number % 10;
                number /= 10;
            }
            return sum;

        }
    }
}

