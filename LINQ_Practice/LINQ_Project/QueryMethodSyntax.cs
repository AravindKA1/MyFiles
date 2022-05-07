using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Project
{
public class QueryMethodSyntax
    {
        public void run()
        {
            List<int> integerList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            var QuerySyntax = integerList.Where(obj => obj > 5).ToList();

            foreach (var item in QuerySyntax)
            {
                Console.Write(item + " ");
            }
        }
    }
}
