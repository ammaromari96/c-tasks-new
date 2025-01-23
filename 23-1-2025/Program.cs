using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_1_2025
{
    internal class Program
    {


        class calculator
        {
            public int add(int a, int b)
            {
                return a + b;
            }
            public int add(int a, int b, int c)
            {
                return a + b + c;
            }

            public double add(double a, double b)
            {
                return a + b;
            }


        }
        //-------------------------------------------------------------
        class shape
        {
            public virtual void draw()
            {
                Console.WriteLine("hello shape");
            } 

          

            }

        class circle : shape
        {
            public override void draw()
            {
                Console.WriteLine("hello circle");
            }

        }
            class rectangle :shape
            {
                public override void draw() {
                    Console.WriteLine("hello rectangel");
            }



        }
        //--------------------------------------------------------

        abstract class animal
        {
            public abstract void makeSound();

            public void sleep()
            {
                Console.WriteLine("animal is sleeping");
            }
        }

            class dog : animal
            {
                public override void makeSound() {
                    Console.WriteLine("Dog barks");
            }

        }

            class cat : animal
            {
                public override void makeSound()
                {
                    Console.WriteLine("cat mewoo");
                }

            }

        //-------------------------------------------------------------------

        interface Playable
        {
            void play();
        }

        class guitar :Playable
        {
            public void play()
            {

                Console.WriteLine("Playing the guitar");

            }
        }

        class piano : Playable {

            public void play()
            {

                Console.WriteLine("Playing the Piano");

            }


        }



            static void Main(string[] args)
        {

        calculator calc = new calculator();
            Console.WriteLine(calc.add(5, 5));
            Console.WriteLine(calc.add(5, 5, 5));
            Console.WriteLine(calc.add(5.3, 5));

            //--------------------------------
            shape shap = new shape();
            shap.draw();

            //------------------------------

            cat cats = new cat();    
            cats.makeSound();

            //---------------------------------------

            Playable guitar1 = new guitar();   
            guitar1.play();
            
            






        }
    }
}
