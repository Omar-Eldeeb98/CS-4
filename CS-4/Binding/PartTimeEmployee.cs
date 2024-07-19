using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_4.Binding
{
    public class PartTimeEmployee:Employee
    {
        public int countOfHours { get; set; }
        public decimal hourRate { get; set; }


         
        public override void getEmployeeType()
        {
            Console.WriteLine("i am part time employee");
        }

        public override void getEmployeeData()
        {
            Console.WriteLine($" this is  part time employee \n id: {id} , name:{name} , age:{age} , Count of hours: {countOfHours} , hour rate: {hourRate} ");
        }

    }
}
