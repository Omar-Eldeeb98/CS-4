using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_4.Polymorphism_Overriding
{
    // TypeC ---> direct parent [TypeB]
    //TypeC -----> grandParent  [TypeA]
    internal class TypeC:TypeB
    {
        // properties
        public int c { get; set; }

        // constructor
        public TypeC(int c , int a , int b):base( a , b)
        {
            this.c = c;
        }


        //methods
        public new void myFunc01()
        {
            Console.WriteLine("i am grand child ");
        }


        public override void myFunc02()
        {
            Console.WriteLine($"TypeC A: {A} , b: {B} , c: {c}");
        }

    }
}
