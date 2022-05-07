using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Project
{
    public class QueryMixedSyntax
    {public void run()
        {
            List<int> integerList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            var QuerySyntax = (from obj in integerList
                               where obj > 5
                               select obj).Sum();
            Console.WriteLine(QuerySyntax);
        }
    }
}
