using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_1_2025
{


    internal class Program
    {
        public class Student
        {


            public const int MinAge = 18;
            public const int MaxAge = 40;


            private string name;
            private int age;
            private int studentID;


            public string Email { get; set; }

          
            public Student(string name, int age, int studentID)
            {
             
                Name = name;
                Age = age;
                StudentID = studentID;
            }

         
            ~Student()
            {
              
                System.Console.WriteLine($"hello my name is ammar");
            }

     
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Age
            {
                get { return age; }
                set
                {
                 
                    if (value < MinAge || value > MaxAge)
                    {
                        System.Console.WriteLine($"Age must be between {MinAge} and {MaxAge}.");
                        return;
                    }
                    age = value;
                }
            }

            public int StudentID
            {
                get { return studentID; }
                set { studentID = value; }
            }

      
            public void GetDetails()
            {
                System.Console.WriteLine($"Name: {Name}, Age: {Age}, Student ID: {StudentID}, Email: {Email}");
            }




            static void Main(string[] args)
            {

           
                Student student1 = new Student("Ammar", 28, 1);
                student1.Email = "amar.alomari@gmail.com"; 
                student1.GetDetails(); 

             
                Student student2 = new Student("mohammad", 25, 2);
                student2.Email = "omari@gmail.com";
                student2.GetDetails();











            }
            }
        }
    }
