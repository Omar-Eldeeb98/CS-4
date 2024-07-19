using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_4.Polymorphism_Overriding
{
    internal class TypeA
    {
    
        // properties
        public int A { get; set; }

        // constructors 
        public TypeA(int a)
        {
            A = a;
        }

        // object member functions [non static]
        public void myFunc01()
        {
            Console.WriteLine("i am base class");
        }


        public virtual void myFunc02() 
        {
            Console.WriteLine($"TypeA: A = {A}");
        }
    }
}
