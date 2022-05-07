using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    public class CountOfPrime
    {
        
        public int CountOfPrimeMethod(int []Numbers)
        {
            int count = 0;
            foreach(int num in Numbers)
            {
                int flag = 0;
                for (int i = 2; i < num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        flag++;
                    }
                }
                if (flag == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
