using System;
using System.Collections.Generic;

namespace asm
{
    public class HouseBuilder : IBuilder
    {
        private House house = new House();
        public void setFloors()
        {
            Console.Write("Enter number of floors: ");
            int floors = Convert.ToInt32(Console.ReadLine());
            house.setFloors(floors);
        }
        public void setArea()
        {
            Console.Write("Enter the area of the house: ");
            double area = Convert.ToDouble(Console.ReadLine());
            house.setArea(area);
        }
        public void setRoof()
        {
            Console.Write("Enter type of roof: ");
            string roof = Console.ReadLine();
            house.setRoof(roof);
        }
        public void setBackyard()
        {
            Console.Write("Enter the design of backyard: ");
            string backyard = Console.ReadLine();
            house.setBackyard(backyard);
        }
        public void setGarage()
        {
            Console.Write("Enter the area of the garage: ");
            double garage = Convert.ToDouble(Console.ReadLine());
            house.setGarage(garage);
        }
        public House getHouse()
        {
            House house = this.house;
            return house;
        }
    }
}