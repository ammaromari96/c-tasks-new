using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp16.Program;

namespace ConsoleApp16
{
    internal class Program
    {
        public static void task1()
        {
            Console.WriteLine("Please enter a number to check if it even or odd");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} is even");
            }
            else
            {
                Console.WriteLine($"the number{number} is odd");
            }
        }




        public static void task2()
        {
            Console.WriteLine("Please enter five number to dispaly the secend smallest");
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());


            }
            Array.Sort(array);
            Console.WriteLine(array[1]);


        }




        public static void task3()
        {
            Console.WriteLine("please enter a number to calculate the factorial");
            int facNumber = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= facNumber; i++)
            {
                fact = fact * i;

            }
            Console.WriteLine(fact);

        }

        public static void task4()
        {
            Console.Write("Enter start value: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter end value: ");
            int end = int.Parse(Console.ReadLine());


            bool IsPrime(int num)
            {
                if (num <= 1) return false;
                for (int i = 2; i * i <= num; i++)
                {
                    if (num % i == 0) return false;
                }
                return true;
            }


            Console.WriteLine($"Prime numbers between {start} and {end} are:");
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }



        public static void task5()
        {
            Console.WriteLine("please enter 6 number of array");
            int[] ints = new int[6];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = int.Parse(Console.ReadLine());

            }
            int largest = int.MinValue;

            foreach (int num in ints)
            {
                if (num > largest)
                {
                    largest = num;
                }
            }

            Console.WriteLine($"The largest number in the array is: {largest}");

        }

        public static void task6()
        {

            int n = 5;
            int counter = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(counter++);
                }
                Console.WriteLine();

            }

        }

        public static void task7()
        {

            Console.Write("Enter the height of the pyramid: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }



        }

        public class rooms
        {
            public int roomNumber;
            public string roomType;
            public double pricePerNight;
            public bool isBooked;
            public const string hotelName = "Grand Stay Hotel";

            public void PrintRoomDetails()
            {
                Console.WriteLine($"room number: {roomNumber}");
                Console.WriteLine($"Room Type: {roomType}");
                Console.WriteLine($"price per night : {pricePerNight} $");
                Console.WriteLine($"Booked: {(isBooked ? "Yes" : "No")}");
                Console.WriteLine($"Hotel  name: {hotelName}");
                Console.WriteLine();
            }



        }




        static void Main(string[] args)
        {
            task1();
            task2();
            task3();
            task4();
            task5();
            task6();
            task7();









            rooms room = new rooms();


            Console.Write("Enter Room Number: ");
            room.roomNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Room Type Single, Double, Suite): ");
            room.roomType = Console.ReadLine();

            Console.Write("Enter Price per Night: ");
            room.pricePerNight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Is the room booked? (yes/no): ");
            string bookingStatus = Console.ReadLine();
            room.isBooked = bookingStatus.ToLower() == "yes";


            room.PrintRoomDetails();













        }
    }
}