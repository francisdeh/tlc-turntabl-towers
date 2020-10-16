using System;
using System.Linq;
using System.Threading;

namespace TurntablTowers
{
    
    //delegate method
    public delegate void InterComEventHandler(string nameOfResident, string? message);

    public abstract class Apartment
    {
        private string _floorNumber; //2
        private string _doorNumber; //204
        private string _apartmentNumber;//04
        private string _residentName; // Jane
        
        private string[] _mesages = new string[] {"Door is broken", "I need a plumber", "Cant find washroom", "Windows cant open", "I need your help"};

        //event handler
        public InterComEventHandler OnRinged;
        

        protected Apartment(string floorNumber, string apartmentNumber, string residentName)
        {
            _floorNumber = floorNumber;
            _apartmentNumber = apartmentNumber;
            _residentName = residentName;
            _doorNumber = floorNumber + apartmentNumber;
        }

        public void CallTower()
        {
            Random random = new Random();
            OnRinged?.Invoke(_residentName, _mesages[random.Next(_mesages.Length - 1)]);
        }

        public string FloorNumber
        {
            get => _floorNumber;
            set => _floorNumber = value;
        }

        public string DoorNumber
        {
            get => _doorNumber;
            set => _doorNumber = value;
        }

        public string ApartmentNumber
        {
            get => _apartmentNumber;
            set => _apartmentNumber = value;
        }

        public string ResidentName
        {
            get => _residentName;
            set => _residentName = value;
        }

        public abstract void RingBell();
    }
}