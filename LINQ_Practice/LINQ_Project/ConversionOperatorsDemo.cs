using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Project
{
    public class ConversionOperatorsDemo
    {
        public void ToListMethod()
        {
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> NumList = Numbers.ToList();
            foreach (int num in from n in NumList select n)
            {
                Console.WriteLine(num);
            }
        }
        public void ToArrayMethod()
        {
            List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] NumList = Numbers.ToArray();
            foreach (int num in from n in NumList select n)
            {
                Console.WriteLine(num);
            }
        }
        public void ToLookUpMethod()
        {
            // It like a grouping any attributes
            List<Employee> EmpObj = new List<Employee>()
         {
             new Employee(){Name="Aravind",Department="CSE",Country="India"},
             new Employee(){Name="Rahul",Department="CSE",Country="India"},
             new Employee(){Name="Karthi",Department="CSE",Country="India"},
             new Employee(){Name="Joyal",Department="CSE",Country="India"},
             new Employee(){Name="Penie",Department="ECE",Country="India"},
             new Employee(){Name="Vaseem",Department="ECE",Country="India"},
             new Employee(){Name="Shaja",Department="EEE",Country="India"},
             new Employee(){Name="Nandhi",Department="EEE",Country="India"},
             new Employee(){Name="Muthu",Department="EEE",Country="India"},
             new Employee(){Name="Kishore",Department="AI",Country="India"},
             new Employee(){Name="Nishanth",Department="AI",Country="India"}
             };
            var Emp = EmpObj.ToLookup(x => x.Department).OrderBy(c => c.Key);
            foreach (var emp in Emp)
            {
                Console.WriteLine(emp.Key + ":" + emp.Count());
                foreach (var stu in emp.OrderByDescending(a => a.Name))
                {
                    Console.WriteLine(stu.Name + " " + stu.Department + " " + stu.Country);
                }
            }
        }
        public void ToDictionaryMethod()
        {
            //Convertig List obj to the key value paired Dictionary obj
            List<Employee> EmpObj = new List<Employee>()
            {
                new Employee(){Id=1,Name="Aravind",Department="CSE",Country="India"},
                new Employee(){Id=2,Name="Balu",Department="MECH",Country="India"},
                new Employee(){Id=3,Name="Aravind",Department="CSE",Country="India"},
                new Employee(){Id=4,Name="Balu",Department="MECH",Country="India"},
                new Employee(){Id=5,Name="Aravind",Department="CSE",Country="India"},
                new Employee(){Id=6,Name="Balu",Department="MECH",Country="India"},
                new Employee(){Id=7,Name="Aravind",Department="CSE",Country="India"},
                new Employee(){Id=8,Name="Balu",Department="MECH",Country="India"},
                new Employee(){Id=9,Name="Aravind",Department="CSE",Country="India"},
                new Employee(){Id=10,Name="Balu",Department="MECH",Country="India"}
            };

            var EmpDetails = EmpObj.ToDictionary(x => x.Id, x => x.Name);
            foreach (var emp in EmpDetails)
            {
                Console.WriteLine(emp);
            }

        }
        public void CastMethod()
        {
            //Converting the ArryList object to string type object
            ArrayList obj = new ArrayList();
            obj.Add("Aravind");
            obj.Add("Balu");
            obj.Add("Akku");
            obj.Add("Ambi");
            IEnumerable<string> family = obj.Cast<string>();
            foreach (var mem in family.OrderBy(x => x))
            {
                Console.WriteLine(mem);
            }
        }
        public void OfTypeMethod()
        {
            ArrayList obj = new ArrayList();
            obj.Add("Aravind");
            obj.Add("Balu");
            obj.Add("Akku");
            obj.Add("Ambi");
            obj.Add(1);
            IEnumerable<string> family = obj.OfType<string>();
            foreach (var mem in family.OrderBy(x => x))
            {
                Console.WriteLine(mem);
            }
        }
        public void AsEnumerableMethod()
        {
            int[] NumbersArray = { 1, 2, 3, 4, 5, 6, 7 };
            var resultArray = NumbersArray.AsEnumerable();
            foreach (int i in resultArray.OrderByDescending(x => x))
            {
                Console.WriteLine(i);
            }

        }
    }
}
