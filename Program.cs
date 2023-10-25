using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtoOBjDemo
{
    public class Employee
    {
        public int Id { get; set; }
        public  string name { get; set; }
        public string City { get; set; }
        public int Salary { get; set; }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{Id=1,name="Rohan",City="Pune",Salary=25000},
                new Employee{Id=2,name="Kishor",City="Mumbai",Salary=26000},
                new Employee{Id=3,name="Tushar",City="Nagpur",Salary=23000},
                new Employee{Id=4,name="Amol",City="Pune",Salary=28000},
                new Employee{Id=5,name="Trupti",City="Satara",Salary=22000},
                new Employee{Id=6,name="Pradnya",City="Pune",Salary=26000},
                new Employee{Id=7,name="Payal",City="Mumbai",Salary=29000},
                new Employee{Id=8,name="Suraj",City="Nashik",Salary=27000},
                new Employee{Id=9,name="Rohit",City="Solapur",Salary=21000},
                new Employee{Id=10,name="Sandesh",City="Nagpur",Salary=22000},
                new Employee{Id=11,name="Ananta",City="Pune",Salary=22500},
            };


            var result = from e in employees
                         where e.City == "Pune"
                         select e;


            //foreach (Employee item in result)
            //{
            //    Console.WriteLine($"{item.Id}, {item.Name},{item.City},{item.Salary}");
            //}


            var result2 = from e in employees
                          where e.name.StartsWith("P")
                          select e;


            //foreach (Employee item in result2)
            //{
            //    Console.WriteLine($"{item.Id}, {item.Name},{item.City},{item.Salary}");
            //}


            var result3 = from e in employees
                          where e.Salary > 24000 && e.City == "Pune"
                          select e;


            //foreach (Employee item in result3)
            //{
            //    Console.WriteLine($"{item.Id}, {item.Name},{item.City},{item.Salary}");
            //}


            //var result4 = Employees.Where(x => x.City == "Mumbai").ToList();
            var result4 = employees.Where(x => x.City == "Pune").OrderBy(x => x.Salary).ToList();
            foreach (Employee item in result4)
            {
                Console.WriteLine($"{item.Id}, {item.name},{item.City},{item.Salary}");
            }


        }

    }
}
