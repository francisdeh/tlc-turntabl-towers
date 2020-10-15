using System;

namespace TurntablTowers
{
    public class GrandApartment : Apartment
    {
        public GrandApartment(string floorNumber, string apartmentNumber, string residentName) : base(floorNumber,
            apartmentNumber, residentName)
        {
        }

        public override void RingBell()
        {
            Console.WriteLine($"{ResidentName} is home.");
        }
    }
}