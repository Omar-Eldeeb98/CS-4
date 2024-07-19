using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_4.Binding
{
    public class FullTimeEmployee:Employee
    {
        // properties
        public decimal salary { get; set; }


        // methods

        public override void getEmployeeType()
        {
            Console.WriteLine("i am full time employee");
        }
        public override void getEmployeeData()
        {
            Console.WriteLine($"this is full time employee\n id: {id} , name:{name} , age:{age} , salary: {salary}");
        }


        // constructor
        public FullTimeEmployee(int id , string name , int age , decimal salary):base(id , name , age) {
           this.salary = salary;
        }

    }
}
