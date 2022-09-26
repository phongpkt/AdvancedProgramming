using System;

namespace asm
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            ApartmentBuilder apt = new ApartmentBuilder();
            HouseBuilder hos = new HouseBuilder();
            bool running = true;

            while(running)
            {
                Console.WriteLine("\n=========================");
                Console.WriteLine("1. Build a house");
                Console.WriteLine("2. Build an appartment");
                Console.WriteLine("3. Exit");
                Console.WriteLine("=========================");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if(choice==1)
                {
                    Console.WriteLine("\n----- Build a house -----");
                    director.makeHouse(hos);
                    House h2 = hos.getHouse();
                    h2.Print();
                }
                else if (choice==2)
                {
                    Console.WriteLine("\n----- Build an appartment -----");
                    director.makeHouse(apt);
                    House h1 = apt.getHouse();
                    h1.Print();
                }
                else if (choice==3)
                {
                    running = false;
                }
                else
                    Console.WriteLine("Invalid Choice!");
            }
        }
    }
}