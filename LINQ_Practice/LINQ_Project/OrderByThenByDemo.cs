using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Project
{
    public class OrderByThenByDemo
    {public void run()
        {
            List<Student> studentObj = new List<Student>()
            {
                new Student(){Name="AAravind",Gender="AMale",Subjects=new List<string>(){"Java",".NET"} },
                new Student(){Name="BAravind",Gender="BMale",Subjects=new List<string>(){"Java",".NET"} },
                new Student(){Name="CAravind",Gender="CMale",Subjects=new List<string>(){"Java",".NET"} },
                new Student(){Name="DAravind",Gender="DMale",Subjects=new List<string>(){"Java",".NET"} }

            };
            foreach (var str in studentObj.OrderBy(x => x.Name).ThenBy(x => x.Gender))
            {
                Console.WriteLine($"Name: {str.Name} Gender: {str.Gender}");
            }
        }
    }
}
