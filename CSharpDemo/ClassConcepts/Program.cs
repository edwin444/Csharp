using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.setSalary(10000);
            Console.WriteLine($"Emp salary: {emp.salary}");
      
        }

    }

    class employee
    {
        public int salary { get; set; }
        public int getSalary()
        {
            return salary;
        }
        public void setSalary(int sal)
        {
            salary = sal;
        }


    }


}
