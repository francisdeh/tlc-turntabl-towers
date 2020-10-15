using System.Linq;

namespace TurntablTowers
{
    public abstract class Apartment
    {
        private string _floorNumber;
        private string _doorNumber;
        private string _apartmentNumber;
        private string _residentName;

        protected Apartment(string floorNumber, string apartmentNumber, string residentName)
        {
            _floorNumber = floorNumber;
            _apartmentNumber = apartmentNumber;
            _residentName = residentName;
            _doorNumber = floorNumber + apartmentNumber;
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