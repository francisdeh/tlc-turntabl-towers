using System;

namespace TurntablTowers
{
    public class BasicApartment : Apartment
    {
        public BasicApartment(string floorNumber, string apartmentNumber, string residentName) : base(floorNumber,
            apartmentNumber, residentName)
        {
        }

        public override void RingBell()
        {
            //10%
            Random random = new Random();
            int randomNumber = random.Next(100);


            if (randomNumber <= 10)
            {
                Console.WriteLine($"{ResidentName} is home.");
            }
            else
            {
                // throw new NobodyHomeException($"{ResidentName} is not home.");
                Console.WriteLine($"{ResidentName} is not home.");
            }

        }
    }
}