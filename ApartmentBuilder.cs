using System;
namespace asm
{
    public class ApartmentBuilder : IBuilder
    {
        private House house = new House();
        public void setFloors()
        {
            int floors = 1;
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
            string roof = "No roof";
            house.setRoof(roof);
        }
        public void setBackyard()
        {
            string backyard = "No backyard";
            house.setBackyard(backyard);
        }
        public void setGarage()
        {
            double garage = 0;
            house.setGarage(garage);
        }
        public House getHouse()
        {
            House apartment = this.house;
            return apartment;
        }
    }
}