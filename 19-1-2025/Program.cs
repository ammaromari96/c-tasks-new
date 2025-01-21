//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _1_19_2025
//{
//    internal class Program
//    {
//        static double ConvertKmToMiles(double kilometersPerHour)
//        {
//            return kilometersPerHour * 0.621371;
//        }

//        static int CalculateTotalMinutes(int hours, int minutes)
//        {
//            return (hours * 60) + minutes;
//        }

//        static (int hours, int minutes) ConvertToHoursAndMinutes(int totalMinutes)
//        {
//            int hours = totalMinutes / 60;
//            int minutes = totalMinutes % 60;
//            return (hours, minutes);
//        }

//        static void Main(string[] args)
//        {
//            Console.WriteLine("please enter a number");
//            string number = Console.ReadLine();
//            double t = Convert.ToDouble(number);
//            int y = (int)t;
//            Console.WriteLine($"Double :{t}");
//            Console.WriteLine($"Converted Int :{y}");


//            Console.WriteLine("please enter a number");
//            int number1 = Convert.ToInt32(Console.ReadLine());
//            string number2 = "Your number is :" + Convert.ToString(number1);
//            Console.WriteLine(number2);



//            string seq = "hello its me ammar";
//            Console.WriteLine("Uppercase :" + seq.ToUpper());
//            Console.WriteLine("lowercase :" + seq.ToLower());


//            Console.WriteLine("please enter your first name");
//            string firstName = Console.ReadLine();
//            Console.WriteLine("please enter your secend name");
//            string lastName = Console.ReadLine();
//            Console.WriteLine("First Name :" + firstName);
//            Console.WriteLine("Last Name :" + lastName);
//            Console.WriteLine(firstName.Length + lastName.Length);


//            Console.WriteLine("please enter the first number");
//            int n1 = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("please enter the secend number");
//            int n2 = Convert.ToInt32(Console.ReadLine());

//            int smallernumber;
//            if (n1 < n2)
//            {
//                smallernumber = n1;
//            }
//            else
//            {
//                smallernumber = n2;
//            }
//            Console.WriteLine("the smallest number is :" + smallernumber);


//            Console.Write("Enter speed in kilometers per hour (km/h): ");
//            double kmh = Convert.ToDouble(Console.ReadLine());


//            double mph = ConvertKmToMiles(kmh);

//            Console.WriteLine($"{kmh} km/h is equivalent to {mph} mph.");

//            Console.Write("Enter the number of hours: ");
//            int hours = Convert.ToInt32(Console.ReadLine());


//            Console.Write("Enter the number of minutes: ");
//            int minutes = Convert.ToInt32(Console.ReadLine());

//            int totalMinutes = CalculateTotalMinutes(hours, minutes);


//            Console.WriteLine($"Total: {totalMinutes} minutes");




//            Console.Write("Enter total minutes: ");
//            int totalMinutes = Convert.ToInt32(Console.ReadLine());


//            var result = ConvertToHoursAndMinutes(totalMinutes);

//            Console.WriteLine($"{result.hours} Hours, {result.minutes} Minutes");


//            Console.Write("Enter the first number: ");
//            int num1 = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Enter the second number: ");
//            int num2 = Convert.ToInt32(Console.ReadLine());


//            if (num1 == num2)
//            {
//                Console.WriteLine("Equal");
//            }
//            else if (num1 > num2)
//            {
//                Console.WriteLine("Greater");
//            }
//            else
//            {
//                Console.WriteLine("Smaller");
//            }


//            Console.Write("Enter a number: ");
//            int number = Convert.ToInt32(Console.ReadLine());

//            int sum = 0;


//            while (number > 0)
//            {
//                sum += number % 10;
//                number /= 10;
//            }
//            Console.WriteLine($"Sum of digits: {sum}");


//            Console.Write("Enter a number: ");
//            int number = Convert.ToInt32(Console.ReadLine());

//            int reversedNumber = 0;


//            while (number > 0)
//            {
//                reversedNumber = (reversedNumber * 10) + (number % 10);
//                number /= 10;

//                Console.WriteLine($"Reversed Number: {reversedNumber}");



//                Console.Write("Enter the first number: ");
//                int num1 = Convert.ToInt32(Console.ReadLine());

//                Console.Write("Enter the second number: ");
//                int num2 = Convert.ToInt32(Console.ReadLine());

//                string result = (num2 != 0 && num1 % num2 == 0) ? "Divisible" : "Not Divisible";

//                Console.WriteLine(result);


//                Console.Write("Enter the first number: ");
//                int num1 = Convert.ToInt32(Console.ReadLine());

//                Console.Write("Enter the second number: ");
//                int num2 = Convert.ToInt32(Console.ReadLine());

//                Console.Write("Enter the third number: ");
//                int num3 = Convert.ToInt32(Console.ReadLine());

//                int middleValue = 0;

//                if ((num1 > num2 && num1 < num3) || (num1 < num2 && num1 > num3))
//                {
//                    middleValue = num1;
//                }
//                else if ((num2 > num1 && num2 < num3) || (num2 < num1 && num2 > num3))
//                {
//                    middleValue = num2;
//                }
//                else
//                {
//                    middleValue = num3;
//                }

//                Console.WriteLine($"The middle value is: {middleValue}");





//            }
//    }
//}