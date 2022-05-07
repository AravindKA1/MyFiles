using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Singleton
{
    public class TestLogger
    {
        public static void Main()
        {
            Logger obj1 = Logger.Instance;
            Logger obj2 = Logger.Instance;
            Console.WriteLine("---Singleton---");
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());

            Test obj3 = new Test();
            Test obj4 = new Test();
            Console.WriteLine("---Non Singleton---");
            Console.WriteLine(obj3.GetHashCode());
            Console.WriteLine(obj4.GetHashCode());
        }
        
    }
     class Test 
    {

    }
}
