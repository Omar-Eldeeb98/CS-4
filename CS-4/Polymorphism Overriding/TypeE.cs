using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_4.Polymorphism_Overriding
{
    internal class TypeE:TypeD 
    {
        // properties
        public int e { get; set; }


        // constructor
        public TypeE(int e , int a , int b , int c , int d):base(a,b,c,d)
        {
            this.e = e;
        }


        public override void myFunc02()
        {
            Console.WriteLine($"typeE\n a: {A} , b:{B} , c: {c} , d: {d} , e:{e}");
        }

        public new void myFunc01()
        {
            Console.WriteLine("i am typeE");
        }

    }
}
