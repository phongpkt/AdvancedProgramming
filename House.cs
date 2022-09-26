using System;
using System.Collections.Generic;
using System.Linq;

namespace asm
{
    public class House
    {
        public int Floors { get; set; }
        public double Area { get; set; }
        public string Roof { get; set; }
        public string Backyard { get; set; }
        public double Garage { get; set; }
        public void setFloors(int floors)
        {
            Floors = floors;
        }
        public void setArea (double area)
        {
            Area = area;
        }
        public void setRoof (string roof)
        {
            Roof = roof;
        }
        public void setBackyard(string backyard)
        {
            Backyard = backyard;
        }
        public void setGarage(double garage)
        {
            Garage = garage;
        }
        public void Print()
        {
            Console.WriteLine("\n----- House builder -----");
            string str = "Number of floors: " + Floors + "\nArea: " + Area + "\nRoof: " + Roof + "\nBackyard: " + Backyard + "\nGarage: " + Garage;
            Console.WriteLine(str);
        }
    }
}