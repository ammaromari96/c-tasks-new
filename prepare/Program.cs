using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prepare
{
    internal class Program
    {

        class employee
        {

            public int empId { get; set; } // auto property  //1

            private double age; // field

            public double Age // property related to specific field 
            { get {
                    return age;

                } set
                {

                    age = value;


                } } // property


            public employee(int empId , double Age)
            {

                //property       // value come from main 
                this.empId = empId;
                this.Age = Age;
            }

        }


        static void Main(string[] args)
        {

                employee e = new employee(1,12);
              //  e.Age = 10;


            Console.WriteLine(e.empId);


        }
    }
}
