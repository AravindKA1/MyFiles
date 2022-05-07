using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Project
{
    public class OrderByThenByDescDemo
    {public void run()
        {
            List<Student> studentObj = new List<Student>()
            {
                new Student(){Name="Aravind",Gender="AMale",Subjects=new List<string>(){"Java",".NET"} },
                new Student(){Name="Aravind",Gender="BMale",Subjects=new List<string>(){"Java",".NET"} },
                new Student(){Name="CAravind",Gender="CMale",Subjects=new List<string>(){"Java",".NET"} },
                new Student(){Name="DAravind",Gender="DMale",Subjects=new List<string>(){"Java",".NET"} }

            };
            foreach (var str in studentObj.OrderByDescending(x => x.Name).ThenByDescending(x => x.Gender))
            {
                Console.WriteLine($"Name: {str.Name} Gender: {str.Gender}");
            }
        }
    }
}
