using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConversionOperatorsDemo obj = new ConversionOperatorsDemo();
            obj.ToListMethod();
            Console.WriteLine("--------------------------------------------------------------");
            obj.ToArrayMethod();
            Console.WriteLine("--------------------------------------------------------------");
            obj.ToLookUpMethod();
            Console.WriteLine("--------------------------------------------------------------");
            obj.ToDictionaryMethod();
            Console.WriteLine("--------------------------------------------------------------");
            obj.OfTypeMethod();
            Console.WriteLine("--------------------------------------------------------------");
            obj.AsEnumerableMethod();
            Console.WriteLine("--------------------------------------------------------------");
            obj.CastMethod();
            Console.WriteLine("--------------------------------------------------------------");
        }
    }
}



