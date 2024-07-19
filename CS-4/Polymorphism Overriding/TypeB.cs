using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_4.Polymorphism_Overriding
{
    internal class TypeB:TypeA
    {
     
        // properties
        public int B { get; set; }

        // constructors
        public TypeB(int a, int b) :base(a)
        {
            B = b;
        }

        // parent class methods -----> [Override]

        // 1 - apply override  using override keyword
        //- function must me inherited from parent, public, virtual function
       

        // 2 - apply override using new keyword
        public new void myFunc01()
        {
            Console.WriteLine("i am child class ");
        }

        public override void myFunc02()
        {
            Console.WriteLine($"A  = {A} ,  B = {B}");
        }




    }
}
