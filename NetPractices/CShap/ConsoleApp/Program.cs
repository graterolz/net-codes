using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program A = new Program();
            //Console.WriteLine("Hi, " + args[0]);
            A.Program1();
            //A.Program2();
            //A.Program3();
            Console.ReadKey();
        }

        public void Program1()
        {
            Console.WriteLine("Your name:");
            string name = Console.ReadLine();

            Console.WriteLine("How many hours of sleep did you get last night?:");
            int hoursOfSleep = int.Parse(Console.ReadLine());

            Console.WriteLine("Hi, " + name);
            if (hoursOfSleep > 8)
            {
                Console.WriteLine("You are well rested");
            }
            else
            {
                Console.WriteLine("You need more sleep");
            }

        }
        public void Program2()
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();

            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(text);
            Console.WriteLine(number);

            if (number == 1)
            {
                Console.WriteLine(DateTime.Now);
            }
        }

        public void Program3()
        {
            Program2 book = new Program2();
            book.AddGrade(91);
            book.AddGrade(89.5f);

            book = new Program2();
            book.AddGrade(75);

            //Program2 book2 = new Program2();
            Program2 book2 = book;
            book2.AddGrade(75);
        }

    }
}
