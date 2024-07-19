using CS_4.Binding;
using CS_4.Polymorphism_Overriding;

namespace CS_4
{
    internal class Program
    {

        #region  Polymorphism - Overloading


        // overloading just used for more readability.

        //public static int Sum(int x , int y)
        //{

        //return x + y; 
        //}

        //public static double Sum(double x, double y)
        //{

        //    return x + y;
        //}

        //public static int Sum(int x , int y , int z)
        //{
        //    return x + y + z;
        //}


        #endregion


        #region Binding EX01

        // (emp) can refer to object Employee
        // (emp) can refer to object inherit from the Employee [fullTimeEmployee, PartTimeEmployee]
        public static void ProcessEmployee(Employee emp)
        {
            if (emp is not null)
            {
                emp.getEmployeeType();
                emp.getEmployeeData();
            }
        }

        //( not overloading xx)

        //public static void ProcessEmployee(PartTimeEmployee partTimeEmployee)
        //{
        //    if (partTimeEmployee is not null)
        //    {
        //        partTimeEmployee.getEmployeeType();
        //        partTimeEmployee.getEmployeeData();
        //    }
        //}


        #endregion

        static void Main(string[] args)
        {
            #region Polymorphism - Overloading

            //int res = Program.Sum(1, 2);
            //Console.WriteLine(res); // 3


            //int res = Sum3(1, 2, 3);
            //Console.WriteLine(res); // 6


            //Console.WriteLine(Sum(1.2,5.3));

            #endregion


            #region Polymorphism - Overriding
            // supported with class only.
            // لازم يكون في وراثة عشان اقدر اطبقها

            //TypeA typeA = new TypeA(1);
            /* Console.WriteLine(typeA);*/ //CS_4.Polymorphism_Overriding.TypeA

            //typeA.A = 57;
            //typeA.myFunc01();
            //typeA.myFunc02();

            //Console.WriteLine("\n");

            //TypeB typeB = new TypeB(1, 2);
            //typeB.A = 10;
            //typeB.B = 20;


            // (output of overriding function).
            //typeB.myFunc01(); // i am child class  
            //typeB.myFunc02(); // A  = 10 ,  B = 20


            #endregion


            #region Binding

            // (Binding) => ref from parent ----> object from child
            //TypeA baseRef; //ref from parent
            //// - can  refer to an object from  TypeA.
            //// - can refer to an object from any class that inherit from TypeA.

            //baseRef = new TypeB(1,2);   // object from child  (Binding)
            //baseRef.A = 10;
            ///*  baseRef.B = 20;*/ // invalid

            //baseRef.myFunc01(); // i am base class  ---->  (MyFunc01 of TypeA)
            //baseRef.myFunc02(); // A  = 10 ,  B = 1  ---->   (MyFunc02 of TypeB)





            #endregion



            #region Not binding
            // ref from child ------> object from parent

            /* TypeB childRef = new TypeA(5);*/  //invalid
            /* TypeB childRef = (TypeB) new TypeA(5);*/ // valid , this is not binding, it is explicit casting, unsafe casting.



            //TypeA typeA = new TypeB(1, 2);
            //TypeB typeB = (TypeB) typeA;
            //Console.WriteLine(typeB.A); // output 1
            //Console.WriteLine(typeB.B); // output 2


            #endregion

            #region Binding EX01

            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(10, "Omar", 30, 6000);
            //ProcessEmployee(fullTimeEmployee);
            //emp = new FullTimeEmployee();

            //i am full time employee
            //this is full time employee
            //  id: 10 , name: Omar , age: 30 , salary: 6000



            //Console.WriteLine("====================================================");


            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            //{
            //    id = 20,
            //    name = "AAAAAAAAAAA",
            //    age = 30,
            //    countOfHours = 40,
            //    hourRate = 2.5m
            //}; // called  -----> [properties initializer]

            ////partTimeEmployee.id = 20;
            ////partTimeEmployee.name = "AAAAAAAAAAA";
            ////partTimeEmployee.age = 30;
            ////partTimeEmployee.countOfHours = 40;
            ////partTimeEmployee.hourRate = 2.5m;


            //ProcessEmployee(partTimeEmployee);
            // emp = new PartTimeEmployee();








            #endregion



            #region Binding EX02

            //TypeA typeA = new TypeC(1,2,3);  //binding
            //typeA.A = 10;
            //typeA.B = 30; //invalid
            //typeA.c = 30; //invalid


            //typeA.myFunc01(); //i am base class ----->   i am base class  static binding
            //typeA.myFunc02(); //TypeC A: 10 , b: 3 , c: 1 ----->   dynamic binding

            //Console.WriteLine("======================================");

            //TypeB typeB = new TypeC(1, 2, 3 );  //binding
            //typeB.myFunc01();
            //typeB.myFunc02();



            TypeD typeD = new TypeE(5, 1, 2, 3, 4);
            typeD.myFunc01();
            typeD.myFunc02();
            #endregion


        }
    }
}
