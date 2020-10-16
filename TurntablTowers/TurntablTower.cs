using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace TurntablTowers
{
    public class TurntablTower
    {
        private List<Apartment> _apartments;

        public TurntablTower(List<Apartment> apartments)
        {
            _apartments = apartments;
            //attaching a listener to the events for calling
            _apartments.ForEach(apartment => apartment.OnRinged += OnRing);
            //interval to call a tower
            _apartments.ForEach(apartment =>
            {
                Thread.Sleep(1000);
                apartment.CallTower();
            });
        }

        public void TakeRegister()
        {
            IEnumerable<Apartment> query = from apartment in _apartments where apartment.FloorNumber.Equals("5") select apartment;
            
            foreach (var apartment in query)
            {
                Console.WriteLine($"Door Number: {apartment.DoorNumber},  Resident's Name {apartment.ResidentName}");
            }

            // _apartments.ForEach(apartment =>
            //     Console.WriteLine($"Door Number: {apartment.DoorNumber},  Resident's Name {apartment.ResidentName}"));
        }

        public void RingBell()
        {
            _apartments.ForEach(apartment =>
                apartment.RingBell());
        }

        private void OnRing(string nameOfResident, string? message)
        {
            Console.WriteLine($"{nameOfResident} says {message}");
        }
    }
}