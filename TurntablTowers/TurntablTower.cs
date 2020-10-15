using System;
using System.Collections.Generic;

namespace TurntablTowers
{
    public class TurntablTower
    {
        private List<Apartment> _apartments;

        public TurntablTower(List<Apartment> apartments)
        {
            _apartments = apartments;
        }

        public void TakeRegister()
        {
            _apartments.ForEach(apartment =>
                Console.WriteLine($"Door Number: {apartment.DoorNumber},  Resident's Name {apartment.ResidentName}"));
        }

        public void RingBell()
        {
            _apartments.ForEach(apartment =>
                apartment.RingBell());
        }
    }
}