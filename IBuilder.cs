using System;

namespace asm
{
    public interface IBuilder
    {
        public void setFloors();
        public void setArea();
        public void setRoof();
        public void setBackyard();
        public void setGarage();
        public House getHouse();
    }
}