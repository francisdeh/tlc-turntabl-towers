using System.Linq;
using System.Threading;

namespace TurntablTowers
{
    //delegate method
    public delegate void InterComEventHandler(string nameOfResident, string? message);

    public abstract class Apartment
    {
        private string _floorNumber;
        private string _doorNumber;
        private string _apartmentNumber;
        private string _residentName;

        //event handler
        public InterComEventHandler OnRinged;

        protected Apartment(string floorNumber, string apartmentNumber, string residentName)
        {
            _floorNumber = floorNumber;
            _apartmentNumber = apartmentNumber;
            _residentName = residentName;
            _doorNumber = floorNumber + apartmentNumber;
        }

        public void Ring()
        {
            Thread.Sleep(5000);

            if (OnRinged != null)
            {
                OnRinged(_residentName, "I cant open the window");
            }
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