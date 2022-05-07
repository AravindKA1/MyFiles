using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    class PrimeOrNot
    {
        int number;
        public PrimeOrNot(int number)
        {
            this.number = number;
        }
        public void PrimeCheck()
        {
            int ctr=0;
            for (int i = 2; i < number/2; i++)
            {
                if (number % i == 0)
                {
                    ctr++;
                }
            }
            if (ctr == 0)
            {
                Console.WriteLine($"{number} is a prime number");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number");
            }
        }
    }
}
