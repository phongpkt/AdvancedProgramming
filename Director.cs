using System;
using System.Collections.Generic;

namespace asm
{
    public class Director
    {
        public void makeHouse(IBuilder Builder)
        {
            Builder.setFloors();
            Builder.setArea();
            Builder.setRoof();
            Builder.setBackyard();
            Builder.setGarage();
        }
    }
}