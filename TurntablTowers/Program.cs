using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace TurntablTowers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Apartment apartment1 = new GrandApartment("4", "02", "Mike");
            // int total = 0;
            // total = total + 5;
            // total += 5;
            //add subscriber
            apartment1.OnRinged += TurntablTower.OnRing;
            
            apartment1.Ring();
            
            
            Apartment apartment2 = new BasicApartment("5", "05", "Jane");
            Apartment apartment3 = new GrandApartment("5", "06", "John");
            Apartment apartment4 = new SilverApartment("4", "01", "Grace");
            Apartment apartment5 = new BasicApartment("7", "01", "Joan");

            apartment2.RingBell();


            // List<Apartment> apartments = new List<Apartment>(
            // )
            // {
            //     apartment1, apartment2, apartment3, apartment4, apartment5
            // };
            //
            // TurntablTower turntablTower = new TurntablTower(apartments);
            // turntablTower.TakeRegister();
            // turntablTower.RingBell();
        }
    }
}