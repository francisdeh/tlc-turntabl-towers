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

            Apartment apartment1 = new GrandApartment("4", "2", "Ike");
            var apartment1ApartmentNumber = apartment1.ApartmentNumber;
            Console.Write(apartment1ApartmentNumber);
        }

    }
}