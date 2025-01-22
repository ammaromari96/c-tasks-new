using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace _22_1_2025
{
    internal class Program
    {
        class vehicle
        {
            public string brand { get; set; }
            public string model { get; set; }



            public void print()
            {

                Console.WriteLine($"the brand : {brand} and the model {model} ");
            }

           
        }
        class car : vehicle
        {
            public int numberOfDoor { get; set; }


        }






        static void Main(string[] args)
        {
            vehicle vehicle1 = new vehicle();
            vehicle1.brand = "avanti";
            vehicle1.model = "hundai";



            car car1 = new car();
            car1.brand = "bmw";
            car1.model = "e46";
            car1.numberOfDoor = 4;
            car1.print();
     
           
        }
    }
}

//What is constructor ==> giving inttial value
//What are the basic concepts of OOPs ==> inhertance encapsolation polymorphisem abstraction
//What is the Encapsulation ==> get set 500 
//What is the sealed class ==> didn't inhertance 
//What is the Inheritance concept ==> give the method and propartis for the child

