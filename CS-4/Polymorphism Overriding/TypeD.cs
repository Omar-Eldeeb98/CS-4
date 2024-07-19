using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_4.Polymorphism_Overriding
{
    internal class TypeD:TypeC
    {
        // properties
        public int d { get; set; }

        // constructor
        public TypeD(int d , int a , int b , int c):base(a,b,c)
        {
            this.d = d;
        }


        // methods
        public new void myFunc01()
        {
            Console.WriteLine(" i am typeD class ");
        }

        public new virtual void myFunc02()
            // new --> end old sequence
            // virtual --> start new sequence from here 

        {
            Console.WriteLine($"this is typeD\n a: {A} , b: {B} , c: {c} , d: {d}");
        }


    }
}
