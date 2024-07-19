using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_4.Binding
{
    public class Employee
    {
   
        // properties
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }


        // constructor
        public Employee(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }


        public Employee() { }   


        // methods
        public virtual void getEmployeeType()         //   في حالة ال new هيشوف مين ال ref ويشغلها
        {
            Console.WriteLine("i am employee");
        }


        public virtual void getEmployeeData()  // بيشوف اخر override ويشغلها 
        {
            Console.WriteLine($"id: {id} , name: {name} , age:{age}");
        }
    }
}
