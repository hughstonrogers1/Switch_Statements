using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite Class?");
            Console.WriteLine("Select from the options below:");
            Console.WriteLine("0: Math");
            Console.WriteLine("1: English");
            Console.WriteLine("2: History");
            Console.WriteLine("3: Science");
            Console.WriteLine("4: PE");
            Console.WriteLine("5: Other");

            int userColor = int.Parse(Console.ReadLine());

            switch (userColor)
            {
                case 0 :
                    Console.WriteLine("Math");
                    break;

                case 1 :
                    Console.WriteLine("English");
                    break;

                case 2 :
                    Console.WriteLine("History");
                    break;

                case 3 :
                    Console.WriteLine("Science");
                    break;

                case 4 :
                    Console.WriteLine("PE");
                    break;

                default :
                    Console.WriteLine("Really??? Nope! You are wrong!");
                    break;
            }




        }
    }
}
